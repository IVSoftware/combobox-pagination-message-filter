namespace combo_box_pagination
{
    partial class Pagination
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.FirstPaginationButton = new System.Windows.Forms.Button();
            this.PrevPaginationButton = new System.Windows.Forms.Button();
            this.NextPaginationButton = new System.Windows.Forms.Button();
            this.LastPaginationButton = new System.Windows.Forms.Button();
            this.PagesLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.Controls.Add(this.FirstPaginationButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.PrevPaginationButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.NextPaginationButton, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.LastPaginationButton, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.PagesLabel, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(531, 53);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // FirstPaginationButton
            // 
            this.FirstPaginationButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FirstPaginationButton.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FirstPaginationButton.Location = new System.Drawing.Point(3, 3);
            this.FirstPaginationButton.Name = "FirstPaginationButton";
            this.FirstPaginationButton.Size = new System.Drawing.Size(54, 47);
            this.FirstPaginationButton.TabIndex = 0;
            this.FirstPaginationButton.Text = "<<";
            this.FirstPaginationButton.UseVisualStyleBackColor = true;
            // 
            // PrevPaginationButton
            // 
            this.PrevPaginationButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PrevPaginationButton.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PrevPaginationButton.Location = new System.Drawing.Point(63, 3);
            this.PrevPaginationButton.Name = "PrevPaginationButton";
            this.PrevPaginationButton.Size = new System.Drawing.Size(54, 47);
            this.PrevPaginationButton.TabIndex = 0;
            this.PrevPaginationButton.Text = "<";
            this.PrevPaginationButton.UseVisualStyleBackColor = true;
            // 
            // NextPaginationButton
            // 
            this.NextPaginationButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NextPaginationButton.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NextPaginationButton.Location = new System.Drawing.Point(414, 3);
            this.NextPaginationButton.Name = "NextPaginationButton";
            this.NextPaginationButton.Size = new System.Drawing.Size(54, 47);
            this.NextPaginationButton.TabIndex = 1;
            this.NextPaginationButton.Text = ">";
            this.NextPaginationButton.UseVisualStyleBackColor = true;
            // 
            // LastPaginationButton
            // 
            this.LastPaginationButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LastPaginationButton.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LastPaginationButton.Location = new System.Drawing.Point(474, 3);
            this.LastPaginationButton.Name = "LastPaginationButton";
            this.LastPaginationButton.Size = new System.Drawing.Size(54, 47);
            this.LastPaginationButton.TabIndex = 2;
            this.LastPaginationButton.Text = ">>";
            this.LastPaginationButton.UseVisualStyleBackColor = true;
            // 
            // PagesLabel
            // 
            this.PagesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PagesLabel.AutoSize = true;
            this.PagesLabel.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PagesLabel.Location = new System.Drawing.Point(123, 0);
            this.PagesLabel.Name = "PagesLabel";
            this.PagesLabel.Size = new System.Drawing.Size(285, 53);
            this.PagesLabel.TabIndex = 3;
            this.PagesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Pagination
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Pagination";
            this.Size = new System.Drawing.Size(531, 53);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button FirstPaginationButton;
        private System.Windows.Forms.Button PrevPaginationButton;
        private System.Windows.Forms.Button NextPaginationButton;
        private System.Windows.Forms.Button LastPaginationButton;
        private System.Windows.Forms.Label PagesLabel;
    }
}
