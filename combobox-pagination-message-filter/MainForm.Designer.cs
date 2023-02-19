
namespace ivs_combobox_pagination
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxWithPagination = new ivs_combobox_pagination.ComboBoxWithPagingEx();
            this.SuspendLayout();
            // 
            // comboBoxWithPagination
            // 
            this.comboBoxWithPagination.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxWithPagination.AutoSize = true;
            this.comboBoxWithPagination.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.comboBoxWithPagination.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxWithPagination.Location = new System.Drawing.Point(32, 42);
            this.comboBoxWithPagination.Margin = new System.Windows.Forms.Padding(0);
            this.comboBoxWithPagination.Name = "comboBoxWithPagination";
            this.comboBoxWithPagination.PageLength = 10;
            this.comboBoxWithPagination.SelectedIndex = -1;
            this.comboBoxWithPagination.Size = new System.Drawing.Size(393, 36);
            this.comboBoxWithPagination.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 244);
            this.Controls.Add(this.comboBoxWithPagination);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBoxWithPagingEx comboBoxWithPagination;
    }
}

