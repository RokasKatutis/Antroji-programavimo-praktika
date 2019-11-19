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
    public partial class Managment : Form
    {
        FLogin F;
        string photopath = "";
        public Managment(FLogin _F)
        {
            F = _F;
            InitializeComponent();
        }

        private void Managment_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            try
            {
                new SQL().InsertProduct(textBox1.Text, comboBox1.SelectedIndex, photopath, Convert.ToInt32(numericUpDown1.Value), textBox2.Text);
                MessageBox.Show("uzsakymas idetas!");
            }
            catch
            {
                MessageBox.Show("Klaida! Kreipkites 862530072");
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    photopath = openFileDialog1.FileName;
                    Image bkg = Image.FromFile(openFileDialog1.FileName);

                    button1.BackgroundImage = bkg;


                }
                catch (Exception ex)
                {
                    MessageBox.Show("klaida:"+ex.ToString());
                }
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
