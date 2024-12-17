namespace CSSD_Finals
{
    partial class frmDashboard
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
            panel1 = new Panel();
            Total = new Label();
            label3 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            incTotal = new Label();
            label4 = new Label();
            panel3 = new Panel();
            expTotal = new Label();
            label5 = new Label();
            label2 = new Label();
            label6 = new Label();
            panel4 = new Panel();
            recentRec = new DataGridView();
            label7 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)recentRec).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(20, 15, 35);
            panel1.Controls.Add(Total);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.ForeColor = Color.FromArgb(197, 198, 199);
            panel1.Location = new Point(30, 29);
            panel1.Name = "panel1";
            panel1.Size = new Size(545, 357);
            panel1.TabIndex = 0;
            // 
            // Total
            // 
            Total.AutoSize = true;
            Total.Font = new Font("Century Gothic", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Total.ForeColor = Color.FromArgb(102, 252, 241);
            Total.Location = new Point(35, 134);
            Total.Name = "Total";
            Total.Size = new Size(306, 85);
            Total.TabIndex = 0;
            Total.Text = "PHP 100";
            Total.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(197, 198, 199);
            label3.Location = new Point(53, 229);
            label3.Name = "label3";
            label3.Size = new Size(201, 30);
            label3.TabIndex = 0;
            label3.Text = "in your account";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(197, 198, 199);
            label1.Location = new Point(35, 53);
            label1.Name = "label1";
            label1.Size = new Size(361, 30);
            label1.TabIndex = 0;
            label1.Text = "You currently have a total of:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(20, 15, 35);
            panel2.Controls.Add(incTotal);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(631, 29);
            panel2.Name = "panel2";
            panel2.Size = new Size(414, 357);
            panel2.TabIndex = 3;
            // 
            // incTotal
            // 
            incTotal.AutoSize = true;
            incTotal.Font = new Font("Century Gothic", 28F, FontStyle.Bold, GraphicsUnit.Point, 0);
            incTotal.ForeColor = Color.FromArgb(50, 255, 180);
            incTotal.Location = new Point(35, 150);
            incTotal.Name = "incTotal";
            incTotal.Size = new Size(237, 66);
            incTotal.TabIndex = 2;
            incTotal.Text = "PHP 100";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(197, 198, 199);
            label4.Location = new Point(35, 53);
            label4.Name = "label4";
            label4.Size = new Size(147, 39);
            label4.TabIndex = 1;
            label4.Text = "Income:";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(20, 15, 35);
            panel3.Controls.Add(expTotal);
            panel3.Controls.Add(label5);
            panel3.Location = new Point(1063, 29);
            panel3.Name = "panel3";
            panel3.Size = new Size(414, 357);
            panel3.TabIndex = 3;
            // 
            // expTotal
            // 
            expTotal.AutoSize = true;
            expTotal.Font = new Font("Century Gothic", 28F, FontStyle.Bold, GraphicsUnit.Point, 0);
            expTotal.ForeColor = Color.FromArgb(255, 150, 180);
            expTotal.Location = new Point(35, 150);
            expTotal.Name = "expTotal";
            expTotal.Size = new Size(237, 66);
            expTotal.TabIndex = 2;
            expTotal.Text = "PHP 100";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(197, 198, 199);
            label5.Location = new Point(35, 53);
            label5.Name = "label5";
            label5.Size = new Size(166, 39);
            label5.TabIndex = 1;
            label5.Text = "Expenses:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Schoolbook", 20F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(197, 198, 199);
            label2.Location = new Point(83, 468);
            label2.Name = "label2";
            label2.Size = new Size(431, 230);
            label2.TabIndex = 4;
            label2.Text = "\" A   p e n y   s a v e d\r\n \r\ni s   a   p e n n y   \r\n\r\ne a r n e d . . .  \"";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Schoolbook", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(197, 198, 199);
            label6.Location = new Point(324, 745);
            label6.Name = "label6";
            label6.Size = new Size(251, 29);
            label6.TabIndex = 4;
            label6.Text = "~ Benjamin Franklin";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            panel4.Controls.Add(label7);
            panel4.Controls.Add(recentRec);
            panel4.Location = new Point(631, 422);
            panel4.Name = "panel4";
            panel4.Size = new Size(846, 380);
            panel4.TabIndex = 5;
            // 
            // recentRec
            // 
            recentRec.BackgroundColor = Color.FromArgb(20, 15, 35);
            recentRec.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            recentRec.GridColor = Color.FromArgb(50, 50, 80);
            recentRec.Location = new Point(35, 69);
            recentRec.Name = "recentRec";
            recentRec.RowHeadersWidth = 62;
            recentRec.Size = new Size(775, 283);
            recentRec.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(197, 198, 199);
            label7.Location = new Point(35, 28);
            label7.Name = "label7";
            label7.Size = new Size(270, 30);
            label7.TabIndex = 1;
            label7.Text = "Your Recent Records:";
            // 
            // frmDashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 30);
            ClientSize = new Size(1506, 827);
            Controls.Add(panel4);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmDashboard";
            Text = "Form2";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)recentRec).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label Total;
        private Label label3;
        private Panel panel2;
        private Label label4;
        private Label incTotal;
        private Panel panel3;
        private Label expTotal;
        private Label label5;
        private Label label2;
        private Label label6;
        private Panel panel4;
        private DataGridView recentRec;
        private Label label7;
    }
}