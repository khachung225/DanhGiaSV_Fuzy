﻿namespace NhanSetGiaoVien
{
    partial class frmKQNhanSet
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbochonsv = new System.Windows.Forms.ComboBox();
            this.btnDanhGia = new System.Windows.Forms.Button();
            this.txtTieuchi = new System.Windows.Forms.TextBox();
            this.txtTieuchuan = new System.Windows.Forms.TextBox();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1061, 157);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(427, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "1: Rất tốt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(493, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "2:Tốt";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(609, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "4:Bình thường";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(555, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "3:Khá";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(702, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "5: Dưới bình thường";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(94, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Giáo Viên";
            // 
            // cbochonsv
            // 
            this.cbochonsv.FormattingEnabled = true;
            this.cbochonsv.Location = new System.Drawing.Point(166, 11);
            this.cbochonsv.Margin = new System.Windows.Forms.Padding(2);
            this.cbochonsv.Name = "cbochonsv";
            this.cbochonsv.Size = new System.Drawing.Size(202, 21);
            this.cbochonsv.TabIndex = 8;
            this.cbochonsv.SelectedIndexChanged += new System.EventHandler(this.cbochonsv_SelectedIndexChanged);
            // 
            // btnDanhGia
            // 
            this.btnDanhGia.Location = new System.Drawing.Point(12, 214);
            this.btnDanhGia.Name = "btnDanhGia";
            this.btnDanhGia.Size = new System.Drawing.Size(75, 23);
            this.btnDanhGia.TabIndex = 9;
            this.btnDanhGia.Text = "Đánh giá";
            this.btnDanhGia.UseVisualStyleBackColor = true;
            this.btnDanhGia.Click += new System.EventHandler(this.btnDanhGia_Click);
            // 
            // txtTieuchi
            // 
            this.txtTieuchi.Location = new System.Drawing.Point(105, 200);
            this.txtTieuchi.Multiline = true;
            this.txtTieuchi.Name = "txtTieuchi";
            this.txtTieuchi.Size = new System.Drawing.Size(330, 115);
            this.txtTieuchi.TabIndex = 22;
            // 
            // txtTieuchuan
            // 
            this.txtTieuchuan.Location = new System.Drawing.Point(441, 200);
            this.txtTieuchuan.Multiline = true;
            this.txtTieuchuan.Name = "txtTieuchuan";
            this.txtTieuchuan.Size = new System.Drawing.Size(333, 115);
            this.txtTieuchuan.TabIndex = 23;
            // 
            // txtKetQua
            // 
            this.txtKetQua.BackColor = System.Drawing.SystemColors.Info;
            this.txtKetQua.ForeColor = System.Drawing.Color.Red;
            this.txtKetQua.Location = new System.Drawing.Point(780, 200);
            this.txtKetQua.Multiline = true;
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(293, 115);
            this.txtKetQua.TabIndex = 24;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(12, 254);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 25;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 292);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "Danh Sách";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 321);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(1061, 157);
            this.dataGridView2.TabIndex = 0;
            // 
            // frmKQRenLuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 480);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.txtTieuchuan);
            this.Controls.Add(this.txtTieuchi);
            this.Controls.Add(this.btnDanhGia);
            this.Controls.Add(this.cbochonsv);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmKQRenLuyen";
            this.Text = "Kết quả nhận sét";
            this.Load += new System.EventHandler(this.frmKQRenLuyen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbochonsv;
        private System.Windows.Forms.Button btnDanhGia;
        private System.Windows.Forms.TextBox txtTieuchi;
        private System.Windows.Forms.TextBox txtTieuchuan;
        private System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}