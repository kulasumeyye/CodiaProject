using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AracPark
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int toplamKazanc;
        int toplamSure;
        int sayac;

        private void btnEkle_Click(object sender, EventArgs e)
        {

            string Model = txtModel.Text;
            int sure = Convert.ToInt16(txtSure.Text);
            int ucret = sure * 5;

            toplamKazanc += ucret;
            toplamSure += sure;



            listBox1.Items.Add(Model);
            listBox2.Items.Add(Convert.ToString(sure));
            listBox3.Items.Add(Convert.ToString(ucret));
            sayac++;
            label9.Text = Convert.ToString(sayac);
            label10.Text = Convert.ToString(toplamKazanc);
            label11.Text = Convert.ToString(toplamSure);


        }
    }
}
