namespace NhanXetSinhVien
{
    partial class frmDanhGia
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
            this.label2 = new System.Windows.Forms.Label();
            this.cbochonsv = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tchi21 = new System.Windows.Forms.ComboBox();
            this.grb1 = new System.Windows.Forms.GroupBox();
            this.tc23 = new System.Windows.Forms.ComboBox();
            this.tc22 = new System.Windows.Forms.ComboBox();
            this.grp2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tc12 = new System.Windows.Forms.ComboBox();
            this.tc11 = new System.Windows.Forms.ComboBox();
            this.thuchien = new System.Windows.Forms.Button();
            this.thoat = new System.Windows.Forms.Button();
            this.grb1.SuspendLayout();
            this.grp2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 13);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Chọn SV muốn đánh giá";
            // 
            // cbochonsv
            // 
            this.cbochonsv.FormattingEnabled = true;
            this.cbochonsv.Location = new System.Drawing.Point(161, 11);
            this.cbochonsv.Margin = new System.Windows.Forms.Padding(2);
            this.cbochonsv.Name = "cbochonsv";
            this.cbochonsv.Size = new System.Drawing.Size(211, 21);
            this.cbochonsv.TabIndex = 3;
            this.cbochonsv.SelectedIndexChanged += new System.EventHandler(this.chonsv_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 22);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Bài 2 (TC21)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 58);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Bài 3 (TC22)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 93);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Bài 4 (TC23)";
            // 
            // tchi21
            // 
            this.tchi21.FormattingEnabled = true;
            this.tchi21.Location = new System.Drawing.Point(75, 20);
            this.tchi21.Margin = new System.Windows.Forms.Padding(2);
            this.tchi21.Name = "tchi21";
            this.tchi21.Size = new System.Drawing.Size(88, 21);
            this.tchi21.TabIndex = 7;
            // 
            // grb1
            // 
            this.grb1.Controls.Add(this.tc23);
            this.grb1.Controls.Add(this.tc22);
            this.grb1.Controls.Add(this.tchi21);
            this.grb1.Controls.Add(this.label5);
            this.grb1.Controls.Add(this.label4);
            this.grb1.Controls.Add(this.label3);
            this.grb1.Location = new System.Drawing.Point(198, 48);
            this.grb1.Margin = new System.Windows.Forms.Padding(2);
            this.grb1.Name = "grb1";
            this.grb1.Padding = new System.Windows.Forms.Padding(2);
            this.grb1.Size = new System.Drawing.Size(174, 120);
            this.grb1.TabIndex = 10;
            this.grb1.TabStop = false;
            this.grb1.Text = "Phần thực hành";
            // 
            // tc23
            // 
            this.tc23.FormattingEnabled = true;
            this.tc23.Location = new System.Drawing.Point(75, 90);
            this.tc23.Margin = new System.Windows.Forms.Padding(2);
            this.tc23.Name = "tc23";
            this.tc23.Size = new System.Drawing.Size(88, 21);
            this.tc23.TabIndex = 11;
            // 
            // tc22
            // 
            this.tc22.FormattingEnabled = true;
            this.tc22.Location = new System.Drawing.Point(75, 54);
            this.tc22.Margin = new System.Windows.Forms.Padding(2);
            this.tc22.Name = "tc22";
            this.tc22.Size = new System.Drawing.Size(88, 21);
            this.tc22.TabIndex = 7;
            // 
            // grp2
            // 
            this.grp2.Controls.Add(this.label7);
            this.grp2.Controls.Add(this.label8);
            this.grp2.Controls.Add(this.tc12);
            this.grp2.Controls.Add(this.tc11);
            this.grp2.Location = new System.Drawing.Point(19, 48);
            this.grp2.Margin = new System.Windows.Forms.Padding(2);
            this.grp2.Name = "grp2";
            this.grp2.Padding = new System.Windows.Forms.Padding(2);
            this.grp2.Size = new System.Drawing.Size(175, 120);
            this.grp2.TabIndex = 11;
            this.grp2.TabStop = false;
            this.grp2.Text = "Phần lý thuyết ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 58);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Bài 2 (TC12)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 22);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Bài 1 (TC11)";
            // 
            // tc12
            // 
            this.tc12.FormattingEnabled = true;
            this.tc12.Location = new System.Drawing.Point(75, 53);
            this.tc12.Margin = new System.Windows.Forms.Padding(2);
            this.tc12.Name = "tc12";
            this.tc12.Size = new System.Drawing.Size(88, 21);
            this.tc12.TabIndex = 7;
            // 
            // tc11
            // 
            this.tc11.FormattingEnabled = true;
            this.tc11.Location = new System.Drawing.Point(76, 20);
            this.tc11.Margin = new System.Windows.Forms.Padding(2);
            this.tc11.Name = "tc11";
            this.tc11.Size = new System.Drawing.Size(88, 21);
            this.tc11.TabIndex = 7;
            // 
            // thuchien
            // 
            this.thuchien.Location = new System.Drawing.Point(94, 185);
            this.thuchien.Margin = new System.Windows.Forms.Padding(2);
            this.thuchien.Name = "thuchien";
            this.thuchien.Size = new System.Drawing.Size(81, 28);
            this.thuchien.TabIndex = 14;
            this.thuchien.Text = "Lưu kết quả";
            this.thuchien.UseVisualStyleBackColor = true;
            this.thuchien.Click += new System.EventHandler(this.thuchien_Click);
            // 
            // thoat
            // 
            this.thoat.Location = new System.Drawing.Point(186, 185);
            this.thoat.Margin = new System.Windows.Forms.Padding(2);
            this.thoat.Name = "thoat";
            this.thoat.Size = new System.Drawing.Size(81, 28);
            this.thoat.TabIndex = 17;
            this.thoat.Text = "Thoát";
            this.thoat.UseVisualStyleBackColor = true;
            this.thoat.Click += new System.EventHandler(this.thoat_Click);
            // 
            // frmDanhGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 224);
            this.Controls.Add(this.thoat);
            this.Controls.Add(this.thuchien);
            this.Controls.Add(this.grp2);
            this.Controls.Add(this.grb1);
            this.Controls.Add(this.cbochonsv);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmDanhGia";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Đánh Giá Tốt Nghiệp Sinh Viên";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grb1.ResumeLayout(false);
            this.grb1.PerformLayout();
            this.grp2.ResumeLayout(false);
            this.grp2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbochonsv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox tchi21;
        private System.Windows.Forms.GroupBox grb1;
        private System.Windows.Forms.GroupBox grp2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button thuchien;
        private System.Windows.Forms.Button thoat;
        private System.Windows.Forms.ComboBox tc23;
        private System.Windows.Forms.ComboBox tc22;
        private System.Windows.Forms.ComboBox tc12;
        private System.Windows.Forms.ComboBox tc11;
    }
}

