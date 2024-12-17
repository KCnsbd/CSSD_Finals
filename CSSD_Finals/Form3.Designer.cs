namespace CSSD_Finals
{
    partial class frmHistory
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            HistoryData = new DataGridView();
            panel1 = new Panel();
            label1 = new Label();
            dataFilter = new ComboBox();
            button1 = new Button();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)HistoryData).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // HistoryData
            // 
            HistoryData.BackgroundColor = Color.FromArgb(20, 15, 35);
            HistoryData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            HistoryData.GridColor = Color.FromArgb(50, 50, 80);
            HistoryData.Location = new Point(54, 145);
            HistoryData.Name = "HistoryData";
            HistoryData.RowHeadersWidth = 62;
            HistoryData.Size = new Size(992, 629);
            HistoryData.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(dataFilter);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(54, 43);
            panel1.Name = "panel1";
            panel1.Size = new Size(684, 86);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(197, 198, 199);
            label1.Location = new Point(29, 26);
            label1.Name = "label1";
            label1.Size = new Size(262, 34);
            label1.TabIndex = 0;
            label1.Text = "Filter by Category:";
            // 
            // dataFilter
            // 
            dataFilter.BackColor = Color.FromArgb(20, 15, 35);
            dataFilter.FlatStyle = FlatStyle.Flat;
            dataFilter.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataFilter.ForeColor = Color.FromArgb(197, 198, 199);
            dataFilter.FormattingEnabled = true;
            dataFilter.Location = new Point(314, 26);
            dataFilter.Name = "dataFilter";
            dataFilter.Size = new Size(329, 38);
            dataFilter.TabIndex = 1;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 28F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(102, 252, 241);
            button1.Location = new Point(781, 43);
            button1.Name = "button1";
            button1.Size = new Size(265, 86);
            button1.TabIndex = 2;
            button1.Text = "GO";
            button1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Location = new Point(1067, 145);
            panel2.Name = "panel2";
            panel2.Size = new Size(413, 629);
            panel2.TabIndex = 3;
            // 
            // frmHistory
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 30);
            ClientSize = new Size(1506, 827);
            Controls.Add(panel2);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(HistoryData);
            Name = "frmHistory";
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)HistoryData).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView HistoryData;
        private Panel panel1;
        private ComboBox dataFilter;
        private Label label1;
        private Button button1;
        private Panel panel2;
    }
}