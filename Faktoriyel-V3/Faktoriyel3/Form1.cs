using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Faktoriyel3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static int sonuc;

        private void button1_Click(object sender, EventArgs e)
        {
            int deger = Convert.ToInt32(txtval.Text);
            int faktoriyell=FaktoriyelHesapla(deger);
            lblsonuc.Text = Convert.ToString(faktoriyell);


           



        }
      public int FaktoriyelHesapla(int sayi)
        {

            if (sayi == 0)
                return 1;
            else
              return  sayi * (FaktoriyelHesapla(sayi - 1));

             
           

        }
       
    }
}
