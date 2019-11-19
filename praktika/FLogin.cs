using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace praktika
{
    public partial class FLogin : Form
    {
        MainLangas Ml;
        public FLogin(MainLangas _Ml)
        {
            Ml = _Ml;
            Ml.Hide();
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SQL _SQL = new SQL();

            if (_SQL.userExists(textBox1.Text,maskedTextBox1.Text))
            {
                new Managment(this).Show();
                MessageBox.Show("prisijungta!");
                Hide();
            }
            else
            {
                MessageBox.Show("Duomenys neteisingi!");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Ml.Show();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
