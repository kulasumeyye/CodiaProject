using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Faktoriyel2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int deger = Convert.ToInt32(txtval.Text);
            int faktoriyel = 1;
            int i=deger;
            while(i!=0)
            {
                faktoriyel = faktoriyel * i;
                i = i - 1;
            }

            lblsonuc.Text = Convert.ToString(faktoriyel);
        }
    }
}
