using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace combo_box_pagination
{
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
                        IterateControlTree((control) => onAnyControlClick(control, client));
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

        private void onAnyControlClick(Control control, Point client)
        {
            if (control.Bounds.Contains(client))
            {
                switch (control.Name)
                {
                    case nameof(FirstPaginationButton): Page = 1; break;
                    case nameof(PrevPaginationButton): Page --; break;
                    case nameof(NextPaginationButton): Page ++; break;
                    case nameof(LastPaginationButton): Page = Pages; break;
                    default: break;
                }
            }
        }

        void IterateControlTree(Action<Control> action, Control control = null)
        {
            if (control == null)
            {
                control = this;
            }
            action(control);
            foreach (Control child in control.Controls)
            {
                IterateControlTree(action, child);
            }
        }
        int _page = 1; // Minimum
        public int Page
        {
            get => _page;
            set
            {
                value = Math.Max(1, value);
                value = Math.Min(Pages, value);
                if (!Equals(_page, value))
                {
                    _page = value;
                    PagesLabel.Text = $"Page {Page} of {Pages}";
                    PageChanged?.Invoke(this, new PageChangedEventArgs(page: Page, pages : Pages));
                }
            }
        }

        public int PageLength { get; set; } = 10;

        int _length = 0;
        public int Length
        {
            get => _length;
            set
            {
                if (!Equals(_length, value))
                {
                    _length = value;
                }
            }
        }
        public int Pages => 
            Math.Max(
                1,
                Length % PageLength == 0 ?
                Length / PageLength :
                1 + (Length / PageLength));

        public int Start => (Page - 1) * PageLength;

        public event PageChangedEventHandler PageChanged;
    }

    public delegate void PageChangedEventHandler(Object sender, PageChangedEventArgs e);
    public class PageChangedEventArgs : EventArgs
    {
        public PageChangedEventArgs(int page, int pages)
        {
            Page = page;
            Pages = pages;
        }
        public int Page { get; }
        public int Pages { get; }
    }
}
