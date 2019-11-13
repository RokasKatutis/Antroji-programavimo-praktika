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
    public partial class MainLangas : Form
    {
        Form1 Forma;
        public MainLangas(Form1 F)
        {
            InitializeComponent();
            Forma = F;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Forma.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Shop Pard = new Shop();
            Pard.Show();
           
            
        }

        private void MainLangas_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Krepselis Krep = new Krepselis();
            Krep.Show();
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
          
            
        }
    }
}
