namespace Vista_Dinamica__Menu {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            Menu1 = new Button();
            Menu2 = new Button();
            Menu3 = new Button();
            Menu4 = new Button();
            VistasDeMenus = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(VistasDeMenus, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(Menu1, 0, 0);
            tableLayoutPanel2.Controls.Add(Menu2, 0, 1);
            tableLayoutPanel2.Controls.Add(Menu3, 0, 2);
            tableLayoutPanel2.Controls.Add(Menu4, 0, 3);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.Size = new Size(154, 444);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // Menu1
            // 
            Menu1.Dock = DockStyle.Fill;
            Menu1.Location = new Point(3, 3);
            Menu1.Name = "Menu1";
            Menu1.Size = new Size(148, 105);
            Menu1.TabIndex = 0;
            Menu1.Text = "Menu1";
            Menu1.UseVisualStyleBackColor = true;
            Menu1.Click += Menu1_Click;
            // 
            // Menu2
            // 
            Menu2.Dock = DockStyle.Fill;
            Menu2.Location = new Point(3, 114);
            Menu2.Name = "Menu2";
            Menu2.Size = new Size(148, 105);
            Menu2.TabIndex = 1;
            Menu2.Text = "Menu2";
            Menu2.UseVisualStyleBackColor = true;
            // 
            // Menu3
            // 
            Menu3.Dock = DockStyle.Fill;
            Menu3.Location = new Point(3, 225);
            Menu3.Name = "Menu3";
            Menu3.Size = new Size(148, 105);
            Menu3.TabIndex = 2;
            Menu3.Text = "Menu3";
            Menu3.UseVisualStyleBackColor = true;
            // 
            // Menu4
            // 
            Menu4.Dock = DockStyle.Fill;
            Menu4.Location = new Point(3, 336);
            Menu4.Name = "Menu4";
            Menu4.Size = new Size(148, 105);
            Menu4.TabIndex = 3;
            Menu4.Text = "Menu4";
            Menu4.UseVisualStyleBackColor = true;
            // 
            // VistasDeMenus
            // 
            VistasDeMenus.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            VistasDeMenus.ColumnCount = 1;
            VistasDeMenus.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            VistasDeMenus.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            VistasDeMenus.Location = new Point(163, 3);
            VistasDeMenus.Name = "VistasDeMenus";
            VistasDeMenus.RowCount = 1;
            VistasDeMenus.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            VistasDeMenus.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            VistasDeMenus.Size = new Size(634, 444);
            VistasDeMenus.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button Menu1;
        private Button Menu2;
        private Button Menu3;
        private Button Menu4;
        private TableLayoutPanel VistasDeMenus;
    }
}
