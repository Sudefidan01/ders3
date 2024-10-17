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
    public partial class ComboBox_Ornek2 : Form
    {
        List<string> sehirler=new List<string>()
        {
                  "İstanbul","Ankara","Antalya","İzmir","Manisa","Çanakkale","Bursa","Bilecik","Kocaeli"
        }   ;
        public ComboBox_Ornek2()
        {
            InitializeComponent();

        }

        private void ComboBox_Ornek2_Load(object sender, EventArgs e)
        {
            //foreach (var item in sehirler)
            //{
            //    comboBox1.Items.Add(item);
            //}
            sehirler.ForEach(item => comboBox1.Items.Add(item));
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string metin=txtEkle.Text;
            if (string.IsNullOrEmpty(metin))
            {
                lblBilgi.Text = "Yazı Alanını Boş Bırakmayınız";
                lblBilgi.ForeColor = Color.Red;
                txtEkle.Focus();
            }
            else
            {
                comboBox1.Items.Add(metin);
                txtEkle.Clear();
                lblBilgi.Text = string.Format(" ' {0} ' değeri başarı ile eklendi",metin);
                lblBilgi.ForeColor = Color.Green;
            }
        }

        private void btnOku_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex==-1)
            {
                lblBilgi.Text = "Herhangi bir şehir bilgisi seçmediniz";
                lblBilgi.ForeColor = Color.Red;
            }
            else
            {
                lblBilgi.Text=string.Format("Seçilen öğe {0} - {1} ",comboBox1.SelectedIndex , comboBox1.Text);
                lblBilgi.ForeColor = Color.Green;

            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int seciliIndex=comboBox1.SelectedIndex;
            if (seciliIndex==-1)
            {
                lblBilgi.Text = "Herhangi bir şehir bilgisi seçmediniz";
                lblBilgi.ForeColor = Color.Red;
            }
            else
            {
                string sehir = comboBox1.Items[seciliIndex].ToString();
                comboBox1.Items.RemoveAt(seciliIndex);
                lblBilgi.Text = string.Format(" {0} şehri listenizden çıkarıldı ",sehir);
                lblBilgi.ForeColor = Color.Green;
            }
        }

        private void btnHepsiniSil_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            lblBilgi.Text = "Tüm Şehirler Kaldırıldı";
        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            string sehir=txtDegistir.Text;
            if (comboBox1.SelectedIndex==-1)
            {
                lblBilgi.Text = "Herhangi bir şehir bilgisi seçmediniz";
                lblBilgi.ForeColor = Color.Red;
            }
            else
            {
                if (string.IsNullOrEmpty(sehir))
                {
                    lblBilgi.Text = "Yazı Alanını Boş Bırakmayınız";
                    lblBilgi.ForeColor = Color.Red;
                    txtDegistir.Focus();
                }
                else 
                {
                    comboBox1.Items[comboBox1.SelectedIndex] = sehir;
                    comboBox1.SelectedIndex = -1;
                    txtDegistir.Clear();
                    lblBilgi.Text = " ";
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex==-1)
            {

            }
            else
            {
                txtDegistir.Text = comboBox1.Items[comboBox1.SelectedIndex].ToString();
            }
            
        }
    }
}
