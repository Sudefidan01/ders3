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
    public partial class Combobox_Ornek1 : Form
    {
        public Combobox_Ornek1()
        {
            InitializeComponent();
        }

        private void Combobox_Ornek1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("İstanbul");
            comboBox1.Items.Add("Ankara");
            comboBox1.Items.Add("İzmir");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (comboBox1.SelectedIndex==0)
            {
                listBox1.Items.Add("Avcılar");
                listBox1.Items.Add("Bahçelievler");
                listBox1.Items.Add("Kadıköy");
                listBox1.Items.Add("Maltepe");
            }

            else if (comboBox1.SelectedIndex==1)
            {
                listBox1.Items.Add("Yenimahalle");
                listBox1.Items.Add("Çankaya");
                listBox1.Items.Add("Keçiören");
                listBox1.Items.Add("Etimesgut");

               
            }

            else if (comboBox1.SelectedIndex==2)
            {
                listBox1.Items.Add("Bornova");
                listBox1.Items.Add("Buca");
                listBox1.Items.Add("Dikili");
                listBox1.Items.Add("Göztepe");

            }
        }
    }
}
