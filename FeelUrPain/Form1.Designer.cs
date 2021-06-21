namespace FeelUrPain
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_colorFill = new System.Windows.Forms.Button();
            this.cbbDashStyle = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnColor = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rdb_NoFill = new System.Windows.Forms.RadioButton();
            this.rdb_Fill = new System.Windows.Forms.RadioButton();
            this.btnPolygon = new System.Windows.Forms.Button();
            this.btnEllipse = new System.Windows.Forms.Button();
            this.btnSqua = new System.Windows.Forms.Button();
            this.btnRec = new System.Windows.Forms.Button();
            this.btnCir = new System.Windows.Forms.Button();
            this.btnLine = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnUnGroup = new System.Windows.Forms.Button();
            this.btnGroup = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.clb_listHinh = new System.Windows.Forms.CheckedListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bePainted1 = new FeelUrPain.bePainted();
            this.btnBezier = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1898, 76);
            this.panel1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(300, 214);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(532, 277);
            this.panel5.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.btn_colorFill);
            this.panel4.Controls.Add(this.cbbDashStyle);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.numericUpDown1);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.btnColor);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1342, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(556, 76);
            this.panel4.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(255, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Color Fill";
            // 
            // btn_colorFill
            // 
            this.btn_colorFill.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_colorFill.Location = new System.Drawing.Point(357, 8);
            this.btn_colorFill.Name = "btn_colorFill";
            this.btn_colorFill.Size = new System.Drawing.Size(38, 30);
            this.btn_colorFill.TabIndex = 7;
            this.btn_colorFill.UseVisualStyleBackColor = false;
            this.btn_colorFill.Click += new System.EventHandler(this.btn_colorFill_Click);
            // 
            // cbbDashStyle
            // 
            this.cbbDashStyle.FormattingEnabled = true;
            this.cbbDashStyle.Location = new System.Drawing.Point(356, 44);
            this.cbbDashStyle.Name = "cbbDashStyle";
            this.cbbDashStyle.Size = new System.Drawing.Size(121, 28);
            this.cbbDashStyle.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(255, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Dashstyle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Width";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(105, 45);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Color";
            // 
            // btnColor
            // 
            this.btnColor.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnColor.Location = new System.Drawing.Point(105, 8);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(38, 30);
            this.btnColor.TabIndex = 0;
            this.btnColor.UseVisualStyleBackColor = false;
            this.btnColor.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnBezier);
            this.panel3.Controls.Add(this.rdb_NoFill);
            this.panel3.Controls.Add(this.rdb_Fill);
            this.panel3.Controls.Add(this.btnPolygon);
            this.panel3.Controls.Add(this.btnEllipse);
            this.panel3.Controls.Add(this.btnSqua);
            this.panel3.Controls.Add(this.btnRec);
            this.panel3.Controls.Add(this.btnCir);
            this.panel3.Controls.Add(this.btnLine);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(894, 64);
            this.panel3.TabIndex = 0;
            // 
            // rdb_NoFill
            // 
            this.rdb_NoFill.AutoSize = true;
            this.rdb_NoFill.Location = new System.Drawing.Point(799, 33);
            this.rdb_NoFill.Name = "rdb_NoFill";
            this.rdb_NoFill.Size = new System.Drawing.Size(77, 24);
            this.rdb_NoFill.TabIndex = 7;
            this.rdb_NoFill.TabStop = true;
            this.rdb_NoFill.Text = "No Fill";
            this.rdb_NoFill.UseVisualStyleBackColor = true;
            this.rdb_NoFill.CheckedChanged += new System.EventHandler(this.rdb_NoFill_CheckedChanged);
            // 
            // rdb_Fill
            // 
            this.rdb_Fill.AutoSize = true;
            this.rdb_Fill.Location = new System.Drawing.Point(799, 3);
            this.rdb_Fill.Name = "rdb_Fill";
            this.rdb_Fill.Size = new System.Drawing.Size(53, 24);
            this.rdb_Fill.TabIndex = 6;
            this.rdb_Fill.TabStop = true;
            this.rdb_Fill.Text = "Fill";
            this.rdb_Fill.UseVisualStyleBackColor = true;
            // 
            // btnPolygon
            // 
            this.btnPolygon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPolygon.Location = new System.Drawing.Point(425, 5);
            this.btnPolygon.Name = "btnPolygon";
            this.btnPolygon.Size = new System.Drawing.Size(98, 44);
            this.btnPolygon.TabIndex = 5;
            this.btnPolygon.Text = "Polygon";
            this.btnPolygon.UseVisualStyleBackColor = false;
            this.btnPolygon.Click += new System.EventHandler(this.btnPolygon_Click);
            // 
            // btnEllipse
            // 
            this.btnEllipse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnEllipse.Location = new System.Drawing.Point(529, 5);
            this.btnEllipse.Name = "btnEllipse";
            this.btnEllipse.Size = new System.Drawing.Size(98, 44);
            this.btnEllipse.TabIndex = 4;
            this.btnEllipse.Text = "Ellipse";
            this.btnEllipse.UseVisualStyleBackColor = false;
            this.btnEllipse.Click += new System.EventHandler(this.btnEllipse_Click);
            // 
            // btnSqua
            // 
            this.btnSqua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSqua.Location = new System.Drawing.Point(113, 5);
            this.btnSqua.Name = "btnSqua";
            this.btnSqua.Size = new System.Drawing.Size(98, 44);
            this.btnSqua.TabIndex = 3;
            this.btnSqua.Text = "Square";
            this.btnSqua.UseVisualStyleBackColor = false;
            this.btnSqua.Click += new System.EventHandler(this.btnSqua_Click);
            // 
            // btnRec
            // 
            this.btnRec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnRec.Location = new System.Drawing.Point(321, 5);
            this.btnRec.Name = "btnRec";
            this.btnRec.Size = new System.Drawing.Size(98, 44);
            this.btnRec.TabIndex = 2;
            this.btnRec.Text = "Rectangle";
            this.btnRec.UseVisualStyleBackColor = false;
            this.btnRec.Click += new System.EventHandler(this.btnRec_Click);
            // 
            // btnCir
            // 
            this.btnCir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCir.Location = new System.Drawing.Point(217, 5);
            this.btnCir.Name = "btnCir";
            this.btnCir.Size = new System.Drawing.Size(98, 44);
            this.btnCir.TabIndex = 1;
            this.btnCir.Text = "Circle";
            this.btnCir.UseVisualStyleBackColor = false;
            this.btnCir.Click += new System.EventHandler(this.btnCir_Click);
            // 
            // btnLine
            // 
            this.btnLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnLine.Location = new System.Drawing.Point(9, 5);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(98, 44);
            this.btnLine.TabIndex = 0;
            this.btnLine.Text = "Line";
            this.btnLine.UseVisualStyleBackColor = false;
            this.btnLine.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnClear.Location = new System.Drawing.Point(12, 42);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(237, 44);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Controls.Add(this.panel2);
            this.panel6.Controls.Add(this.panel1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1898, 1024);
            this.panel6.TabIndex = 2;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel7.Controls.Add(this.btnClear);
            this.panel7.Controls.Add(this.btnUnGroup);
            this.panel7.Controls.Add(this.btnGroup);
            this.panel7.Controls.Add(this.btnDel);
            this.panel7.Controls.Add(this.clb_listHinh);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(0, 76);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(261, 948);
            this.panel7.TabIndex = 0;
            // 
            // btnUnGroup
            // 
            this.btnUnGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnUnGroup.Location = new System.Drawing.Point(162, 3);
            this.btnUnGroup.Name = "btnUnGroup";
            this.btnUnGroup.Size = new System.Drawing.Size(87, 37);
            this.btnUnGroup.TabIndex = 7;
            this.btnUnGroup.Text = "Ungroup";
            this.btnUnGroup.UseVisualStyleBackColor = false;
            this.btnUnGroup.Click += new System.EventHandler(this.btnUnGroup_Click);
            // 
            // btnGroup
            // 
            this.btnGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnGroup.Location = new System.Drawing.Point(86, 3);
            this.btnGroup.Name = "btnGroup";
            this.btnGroup.Size = new System.Drawing.Size(70, 37);
            this.btnGroup.TabIndex = 6;
            this.btnGroup.Text = "Group";
            this.btnGroup.UseVisualStyleBackColor = false;
            this.btnGroup.Click += new System.EventHandler(this.btnGroup_Click);
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDel.Location = new System.Drawing.Point(10, 3);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(70, 37);
            this.btnDel.TabIndex = 5;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // clb_listHinh
            // 
            this.clb_listHinh.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.clb_listHinh.CheckOnClick = true;
            this.clb_listHinh.FormattingEnabled = true;
            this.clb_listHinh.Location = new System.Drawing.Point(10, 92);
            this.clb_listHinh.Name = "clb_listHinh";
            this.clb_listHinh.Size = new System.Drawing.Size(239, 717);
            this.clb_listHinh.TabIndex = 0;
            this.clb_listHinh.SelectedIndexChanged += new System.EventHandler(this.clb_listHinh_SelectedIndexChanged);
            this.clb_listHinh.KeyDown += new System.Windows.Forms.KeyEventHandler(this.clb_listHinh_KeyDown);
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.bePainted1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 76);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1898, 948);
            this.panel2.TabIndex = 1;
            // 
            // bePainted1
            // 
            this.bePainted1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bePainted1.Location = new System.Drawing.Point(0, 0);
            this.bePainted1.Name = "bePainted1";
            this.bePainted1.Size = new System.Drawing.Size(1898, 948);
            this.bePainted1.TabIndex = 0;
            this.bePainted1.Paint += new System.Windows.Forms.PaintEventHandler(this.bePainted1_Paint);
            this.bePainted1.DoubleClick += new System.EventHandler(this.bePainted1_DoubleClick);
            this.bePainted1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bePainted1_MouseClick);
            this.bePainted1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bePainted1_MouseDown);
            this.bePainted1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.bePainted1_MouseMove);
            this.bePainted1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bePainted1_MouseUp);
            // 
            // btnBezier
            // 
            this.btnBezier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnBezier.Location = new System.Drawing.Point(633, 5);
            this.btnBezier.Name = "btnBezier";
            this.btnBezier.Size = new System.Drawing.Size(98, 44);
            this.btnBezier.TabIndex = 8;
            this.btnBezier.Text = "Bezier";
            this.btnBezier.UseVisualStyleBackColor = false;
            this.btnBezier.Click += new System.EventHandler(this.btnBezier_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1898, 1024);
            this.Controls.Add(this.panel6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnSqua;
        private System.Windows.Forms.Button btnRec;
        private System.Windows.Forms.Button btnCir;
        private System.Windows.Forms.Button btnLine;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ComboBox cbbDashStyle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.CheckedListBox clb_listHinh;
        private System.Windows.Forms.Panel panel2;
        private bePainted bePainted1;
        private System.Windows.Forms.Button btnPolygon;
        private System.Windows.Forms.Button btnEllipse;
        private System.Windows.Forms.RadioButton rdb_NoFill;
        private System.Windows.Forms.RadioButton rdb_Fill;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_colorFill;
        private System.Windows.Forms.Button btnUnGroup;
        private System.Windows.Forms.Button btnGroup;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnBezier;
    }
}

