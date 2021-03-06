﻿using System;
using System.Windows.Forms;
using DatabaseDAL.DAO;

namespace NhanSetGiaoVien
{
    public partial class ShowListData : Form
    {
        private int _type = 0;
        public ShowListData()
        {
            InitializeComponent();
        }
        public ShowListData(int type)
            : this()
        {
            if (type == 1)
                this.Text = @"Danh Sách Sinh viên";
            if (type == 2)
                this.Text = @"Danh Sách giáo viên";
            _type = type;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        SINHVIENDao SINHVIENDao = new SINHVIENDao();
        GIAOVIENDao GIAOVIENDao = new GIAOVIENDao();
        private void ShowListData_Load(object sender, EventArgs e)
        {
            if (_type == 1)
            {
                var list = GIAOVIENDao.GetAll();
                dataGridView1.DataSource = list;
            }else if (_type == 2)
            {
                var list = SINHVIENDao.GetAll("");
                dataGridView1.DataSource = list;
            }
        }
    }
}
