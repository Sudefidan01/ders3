using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders3
{
    public partial class AnaEkran : Form
    {
        public AnaEkran()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form= new Form1();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Combobox_Ornek1 f=new Combobox_Ornek1();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ComboBox_Ornek2 f=new ComboBox_Ornek2();
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Timer f=new Timer();
            f.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Timer_Odev f =new Timer_Odev();
            f.Show();
        }
    }
}
