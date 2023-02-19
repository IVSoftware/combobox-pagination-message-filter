using combo_box_pagination;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ivs_combobox_pagination
{
    public partial class ComboBoxWithPagingEx : UserControl
    {
        public ComboBoxWithPagingEx()
        {
            InitializeComponent();
            Size = comboBox.Size;
            Items = new ObservableCollection<object>();
            Items.CollectionChanged += (sender, e) => _pagination.Length = Items.Count;
            _pagination = new Pagination() {Padding = new Padding(0),};
            _pagination.PageChanged += onPageChanged;
            _dropdown = new ToolStripDropDown{Padding = new Padding(0), };
            _dropdown.Items.Add(new ToolStripControlHost(_pagination));
            // Get handle now so we don't have to wait for it on the first drop.
            var forceHandle = _dropdown.Handle;
            comboBox.DropDown += (sender, e) =>
            {
                _prevItemCount = comboBox.Items.Count;
                _pagination.MinimumSize = new Size(comboBox.Width, 30);
                BeginInvoke(new Action(()=>_dropdown.Show(
                    this, 
                    0,
                    comboBox.Height + (comboBox.Items.Count * comboBox.ItemHeight))));
            };
            comboBox.DropDownClosed += (sender, e) =>_dropdown.Hide();
        }

        int _prevItemCount;
        private void onPageChanged(object sender, PageChangedEventArgs e)
        {
            refreshPagination();
            if (_prevItemCount < comboBox.Items.Count)
            {
                comboBox.DroppedDown = false;
                comboBox.DroppedDown = true;
            }
        }

        private readonly Pagination _pagination;
        private readonly ToolStripDropDown _dropdown;

        private void refreshPagination()
        {
            comboBox.Items.Clear();
            int itemIndex = _pagination.Start;
            for (int i = 0; i < _pagination.PageLength; i++)
            {
                if (itemIndex < Items.Count)
                {
                    comboBox.Items.Add(Items[itemIndex]);
                    itemIndex++;
                }
                else break;
            }
        }
        public new ObservableCollection<object> Items { get; }
        public int SelectedIndex
        {
            get => comboBox.SelectedIndex;
            set
            {
                if (!Equals(comboBox.SelectedIndex, value))
                {
                    refreshPagination();
                    comboBox.SelectedIndex = value;
                }
            }
        }
        public int PageLength
        {
            get => _pagination.PageLength;
            set => _pagination.PageLength = value;
        }
    }
}
