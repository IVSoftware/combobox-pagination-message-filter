using System.Windows.Forms;

namespace ivs_combobox_pagination
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
            for (int i = 1; i <= 25; i++)
            {
                comboBoxWithPagination.Items.Add($"Item {i}");
            }
            comboBoxWithPagination.SelectedIndex = 0;
        }
    }
}
