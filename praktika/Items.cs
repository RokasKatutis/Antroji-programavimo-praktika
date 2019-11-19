using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace praktika
{
    public partial class Items : UserControl
    {
        public Items()
        {
            InitializeComponent();
        }
        private string Title;

        public void setTitle(string TITLE)
        {
            Title = TITLE;
         
        }
        public string GetTitle()
        {
            return Title;
        }
        private void label1_Click(object sender, EventArgs e)
        {
            

        }
    }
}
