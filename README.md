As I understand it, you've made a `UserControl` for the pagination and when you click on one of the nav buttons it results in an unwanted close of the drop down. 

[![user-control][1]][1]

I was able to reproduce the behavior you're describing and then was able to suppress it by implementing [IMessageFilter](https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.imessagefilter) for the user control in order to intercept the mouse events and mark them as "handled" in the filter (if they occur inside the client rectangle of the UC). 

[![nav][2]][2]

    public partial class Pagination : UserControl, IMessageFilter
    {
        public Pagination()
        {
            InitializeComponent();
            Application.AddMessageFilter(this);
            Disposed += (sender, e) =>Application.RemoveMessageFilter(this);
            PagesLabel.Text = $"Page {Page} of {Pages}";
        }

        const int WM_LBUTTONDOWN = 0x0201;
        const int WM_LBUTTONUP = 0x0202;
        public bool PreFilterMessage(ref Message m)
        {
            var client = PointToClient(MousePosition);
            switch (m.Msg)
            {
                case WM_LBUTTONDOWN:
                    if (ClientRectangle.Contains(client))
                    {
                        IterateControlTree((control) => hitTest(control, client));
                        return true;
                    }
                    break;
                case WM_LBUTTONUP:
                    if(ClientRectangle.Contains(client))
                    {
                        return true;
                    }
                    break;
            }
            return false;
        }
        .
        .
        .
    }

To be clear,  this means no `Button.Click` events are going to take place either! For this reason it's necessary to iterate the `Control` tree of the user control to perform a hit test on the button controls it contains. 

    bool IterateControlTree(Func<Control, bool> action, Control control = null)
    {
        if (control == null) control = this;
        if(action(control)) return true;
        foreach (Control child in control.Controls)
        {
            if(IterateControlTree(action, child))
            {
                return true;
            }
        }
        return false;
    }

For example, detecting a click in the client rectangle of one of the buttons could modify a `Page` property which in turn fires an event for the combo box to react.

    private bool hitTest(Control control, Point client)
    {
        if (control.Bounds.Contains(client))
        {
            switch (control.Name)
            {
                case nameof(FirstPaginationButton): Page = 1; return true;
                case nameof(PrevPaginationButton): Page --; return true;
                case nameof(NextPaginationButton): Page ++; return true;
                case nameof(LastPaginationButton): Page = Pages; return true;
                default: break;
            }
        }
        return false;
    }

Feel free to browse or [clone](https://github.com/IVSoftware/combobox-pagination-message-filter.git) the code I wrote to test this answer if that would be helpful.


  [1]: https://i.stack.imgur.com/QlZbI.png
  [2]: https://i.stack.imgur.com/zLY1Y.png