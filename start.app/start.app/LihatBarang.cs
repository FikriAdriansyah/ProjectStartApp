﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace start.app
{
    public partial class LihatBarang : Form
    {
        public LihatBarang()
        {
            InitializeComponent();
        }

        private void btnTambahBarang_Click(object sender, EventArgs e)
        {
            TambahBarang showForm = new TambahBarang();

            showForm.StartPosition = FormStartPosition.CenterScreen;

            showForm.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateBarang showForm = new UpdateBarang();

            showForm.StartPosition = FormStartPosition.CenterScreen;

            showForm.Show();
        }
    }
}
