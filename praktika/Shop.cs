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
    public partial class Shop : Form
    {
        MainLangas F;

        SQL _SQL = new SQL();

        List<Product> p = new List<Product>();

        List<Basket> B = new List<Basket>();

        public Shop(MainLangas _F)
        {
            F = _F;
            _F.Hide();
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hide();
            F.Show();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty)
                MessageBox.Show("Reikia ivesti varda!");
            else if (textBox2.Text == string.Empty)
                MessageBox.Show("Reikia ivesti pavarde!");
            else if (textBox3.Text == string.Empty)
                MessageBox.Show("Reikia ivesti telefono numeri!");
            else if (textBox4.Text == string.Empty)
                MessageBox.Show("Reikia ivesti adresa!");
            else
            {
                _SQL.InsertOrder(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, B);
                MessageBox.Show("Sekmingai prideta!");
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Shop_Load(object sender, EventArgs e)
        {
            p = _SQL.GetProducts();

            for (int i = 0; i < p.Count; i++)
                listBox1.Items.Add(string.Format("{0}   |   {1}", p[i].GetName(), p[i].GetPrice()));
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Image bkg = Image.FromFile(p[listBox1.SelectedIndex].GetPhoto());
            pictureBox1.Image = bkg;


            label8.Text = "Aprašymas: " + p[listBox1.SelectedIndex].GetDescription();
        }

        void listbox2Populate()
        {
            for (int i = 0; i < B.Count; i++)
            {
                listBox2.Items.Add(string.Format("{0}   |   {1}", B[i].GetName(), B[i].GetPrice()));
            }
        }

        void LabelSuma()
        {
            int sum = 0;

            for (int i = 0; i < B.Count; i++)
            {
                sum += B[i].GetPrice();
            }

            label3.Text = "Suma:" + sum.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();

            Basket _B = new Basket();
            _B.SetName(p[listBox1.SelectedIndex].GetName());
            _B.SetPrice(p[listBox1.SelectedIndex].GetPrice());
            _B.setID(listBox1.SelectedIndex + 1);

            B.Add(_B);

            listbox2Populate();
            LabelSuma();
        }
    }
}
