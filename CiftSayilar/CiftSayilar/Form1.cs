using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CiftSayilar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnYaz_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(txtSayi.Text);
            int i;
            for (i = 1; i <= sayi; i++)
            {
                if (i % 2 == 0)
                    listBoxYaz.Items.Add(Convert.ToString(i) + Environment.NewLine);



            }
        }
    }
}
