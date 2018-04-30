using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZenginSayi
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
            int i, toplam = 0;
            for (i = 1; i < sayi; i++)
            {
                if (sayi % i == 0)
                    toplam += i;
            }
            if (toplam > sayi)
                label1.Text = ("Zengin Sayıdır");
            else
                label1.Text = ("Zengin Sayı Değildir");
        }
    }
}
