using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Faktoriyel
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
            if (deger == 0 || deger == 1)
                lblsonuc.Text = Convert.ToString(faktoriyel);
            else
            {
                for (int i = 1; i <=deger; i++)
                {
                    faktoriyel = faktoriyel * i;
                }

                lblsonuc.Text = Convert.ToString(faktoriyel);
            }
        }

        
    }
}
