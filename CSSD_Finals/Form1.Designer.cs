namespace CSSD_Finals
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            btnCalendar = new Button();
            btnHistory = new Button();
            newRecord = new Button();
            btnDash = new Button();
            panel2 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            mainPanel = new Panel();
            frmTitle = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(31, 40, 80);
            panel1.Controls.Add(btnCalendar);
            panel1.Controls.Add(btnHistory);
            panel1.Controls.Add(newRecord);
            panel1.Controls.Add(btnDash);
            panel1.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.Location = new Point(1, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(375, 1230);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // btnCalendar
            // 
            btnCalendar.BackColor = Color.FromArgb(31, 40, 80);
            btnCalendar.FlatAppearance.BorderSize = 0;
            btnCalendar.FlatStyle = FlatStyle.Flat;
            btnCalendar.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCalendar.ForeColor = Color.FromArgb(197, 198, 199);
            btnCalendar.Image = (Image)resources.GetObject("btnCalendar.Image");
            btnCalendar.Location = new Point(-1, 841);
            btnCalendar.Margin = new Padding(4);
            btnCalendar.Name = "btnCalendar";
            btnCalendar.Size = new Size(379, 101);
            btnCalendar.TabIndex = 1;
            btnCalendar.Text = "     Calendar   ";
            btnCalendar.TextAlign = ContentAlignment.MiddleLeft;
            btnCalendar.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnCalendar.UseVisualStyleBackColor = false;
            btnCalendar.Click += btnHistory_Click;
            btnCalendar.Leave += btnHistory_Leave;
            // 
            // btnHistory
            // 
            btnHistory.BackColor = Color.FromArgb(31, 40, 80);
            btnHistory.FlatAppearance.BorderSize = 0;
            btnHistory.FlatStyle = FlatStyle.Flat;
            btnHistory.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHistory.ForeColor = Color.FromArgb(197, 198, 199);
            btnHistory.Image = (Image)resources.GetObject("btnHistory.Image");
            btnHistory.Location = new Point(-3, 681);
            btnHistory.Margin = new Padding(4);
            btnHistory.Name = "btnHistory";
            btnHistory.Size = new Size(379, 101);
            btnHistory.TabIndex = 1;
            btnHistory.Text = "     History        ";
            btnHistory.TextAlign = ContentAlignment.MiddleLeft;
            btnHistory.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnHistory.UseVisualStyleBackColor = false;
            btnHistory.Click += btnHistory_Click;
            btnHistory.Leave += btnHistory_Leave;
            // 
            // newRecord
            // 
            newRecord.BackColor = Color.FromArgb(69, 162, 158);
            newRecord.FlatAppearance.BorderSize = 0;
            newRecord.FlatStyle = FlatStyle.Flat;
            newRecord.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            newRecord.ForeColor = Color.FromArgb(31, 40, 80);
            newRecord.Image = (Image)resources.GetObject("newRecord.Image");
            newRecord.Location = new Point(0, 344);
            newRecord.Margin = new Padding(4);
            newRecord.Name = "newRecord";
            newRecord.Size = new Size(375, 101);
            newRecord.TabIndex = 1;
            newRecord.Text = "     Create Record";
            newRecord.TextAlign = ContentAlignment.MiddleLeft;
            newRecord.TextImageRelation = TextImageRelation.TextBeforeImage;
            newRecord.UseVisualStyleBackColor = false;
            // 
            // btnDash
            // 
            btnDash.BackColor = Color.FromArgb(31, 40, 80);
            btnDash.FlatAppearance.BorderSize = 0;
            btnDash.FlatStyle = FlatStyle.Flat;
            btnDash.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDash.ForeColor = Color.FromArgb(197, 198, 199);
            btnDash.Image = Properties.Resources.dashboard;
            btnDash.Location = new Point(-3, 530);
            btnDash.Margin = new Padding(4);
            btnDash.Name = "btnDash";
            btnDash.Size = new Size(379, 101);
            btnDash.TabIndex = 1;
            btnDash.Text = "     Dashboard";
            btnDash.TextAlign = ContentAlignment.MiddleLeft;
            btnDash.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnDash.UseVisualStyleBackColor = false;
            btnDash.Click += btnDash_Click;
            btnDash.Leave += btnDash_Leave;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(31, 40, 80);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(1, 0);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(375, 336);
            panel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(197, 198, 199);
            label1.Location = new Point(64, 213);
            label1.Name = "label1";
            label1.Size = new Size(260, 68);
            label1.TabIndex = 1;
            label1.Text = "Expense Tracking \r\nSystem";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(42, 65);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(299, 129);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // mainPanel
            // 
            mainPanel.Location = new Point(384, 155);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1528, 883);
            mainPanel.TabIndex = 1;
            // 
            // frmTitle
            // 
            frmTitle.AutoSize = true;
            frmTitle.Font = new Font("Century Gothic", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            frmTitle.ForeColor = Color.FromArgb(197, 198, 199);
            frmTitle.Location = new Point(384, 43);
            frmTitle.Name = "frmTitle";
            frmTitle.Size = new Size(473, 85);
            frmTitle.TabIndex = 2;
            frmTitle.Text = "DASHBOARD";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 30);
            ClientSize = new Size(1924, 1050);
            Controls.Add(frmTitle);
            Controls.Add(mainPanel);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "EXPENSE TRACKING SYSTEM";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button btnDash;
        private Button btnHistory;
        private Button newRecord;
        private PictureBox pictureBox1;
        private Label label1;
        private Button btnCalendar;
        private Panel mainPanel;
        private Label frmTitle;
    }
}
