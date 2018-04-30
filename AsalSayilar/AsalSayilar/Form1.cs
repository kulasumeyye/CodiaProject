using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsalSayilar
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
            int i,sayac=0;
            for (i = 2; i < sayi; i++)
            {
                if (sayi % i == 0)
                { sayac++;
                break;
                }
                  

              
                    
           }

            if (sayac > 0)
                label1.Text = ("sayı asal değil");

            else
                label1.Text = ("sayı asal ");



            
        }
    }
}
