﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace praktika
{
    public partial class MainLangas : Form
    {
        FLogin Forma;
        public MainLangas()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Forma.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Shop Pard = new Shop(this);
            Pard.Show();


        }

        private void MainLangas_Load(object sender, EventArgs e)
        {
            if (!File.Exists("a.db"))
            {
                SQL _SQL = new SQL();
                _SQL.CreateTable();
                _SQL.InsertUser("Admin", "Admin");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            new FLogin(this).Show();


        }
    }
}
