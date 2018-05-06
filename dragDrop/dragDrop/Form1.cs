using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dragDrop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            Point nokta = new Point(e.X,e.Y);
            int sira=listBox1.IndexFromPoint(nokta);
            if(e.Button==MouseButtons.Left)
            {
                listBox1.DoDragDrop(listBox1.Items[sira], DragDropEffects.All);
            }
        }

        private void listBox2_DragOver(object sender, DragEventArgs e)
        {
            if(e.KeyState==1)
            {
                e.Effect = DragDropEffects.Move;
            }
        }

        private void listBox2_DragDrop(object sender, DragEventArgs e)
        {
            listBox2.Items.Add(e.Data.GetData(DataFormats.StringFormat).ToString());
        }


       
    }
}
