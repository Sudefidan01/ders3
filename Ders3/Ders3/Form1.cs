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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Form elementim açıldığı an ne yapılmasını istiyorsak onları bu event in içerisine yazacağız
            //Buradaki kod satırları sadece form elementimin ilk açıldığı an tek sefer çalışır
            comboBox1.Items.Add("Topla");
            comboBox1.Items.Add("Çıkar");
            comboBox1.Items.Add("Çarp");
            comboBox1.Items.Add("Böl");

            comboBox1.SelectedIndex = 0; //Form Açıldığı Topla (0. indexteki elemanım) seçili olarak gelecek
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            //Textboxların boş olup olmadığını kontrol ediyoruz
            if (string.IsNullOrEmpty(txtSayi1.Text) || string.IsNullOrEmpty(txtSayi2.Text))
            {
                lblBilgi.Text = "Lütfen Gerekli Alanları Doldurun";
                lblBilgi.ForeColor = Color.Red;
                return;
            }
            //Textboxların içerisine sayısal değer girip girmediğini kontrol ediyoruz
            double sayi1 = 0, sayi2 = 0, sonuc = 0;
            try
            {
                sayi1=double.Parse(txtSayi1.Text);
    
            }
            catch 
            {
                lblBilgi.Text = "1.Sayıya Doğru Bir Değer Giriniz";
                lblBilgi.ForeColor= Color.Red;
                txtSayi1.Clear();
                txtSayi1.Focus();
                return;
                
            }

            try
            {
                sayi2 = double.Parse(txtSayi2.Text);
            }
            catch 
            {

                lblBilgi.Text = "2.Sayıya Doğru Bir Değer Giriniz";
                lblBilgi.ForeColor = Color.Red;
                txtSayi2.Clear();
                txtSayi2.Focus();
                return;
            }

            if (comboBox1.SelectedIndex==0)
            {
                sonuc = sayi1 + sayi2;
                lblBilgi.Text ="Sonuç = " + sonuc;
                lblBilgi.ForeColor = Color.Green;
                txtSayi1.Clear();
                txtSayi2.Clear();

            }
            else if (comboBox1.SelectedIndex==1)
            {
                sonuc = sayi1 - sayi2;
                lblBilgi.Text = "Sonuç = " + sonuc;
                lblBilgi.ForeColor = Color.Green;
                txtSayi1.Clear();
                txtSayi2.Clear();
            }
            else if (comboBox1.SelectedIndex==2)
            {
                sonuc = sayi1 * sayi2;
                lblBilgi.Text = "Sonuç = " + sonuc;
                lblBilgi.ForeColor = Color.Green;
                txtSayi1.Clear();
                txtSayi2.Clear();
              
            }
            else if (comboBox1.SelectedIndex==3)
            {
                sonuc = sayi1 / sayi2;
                lblBilgi.Text = "Sonuç = " + sonuc;
                lblBilgi.ForeColor = Color.Green;
                txtSayi1.Clear();
                txtSayi2.Clear();
            }
            else
            {
                lblBilgi.Text = "Yapmak İstediğiniz İşlemi Seçin";
                lblBilgi.ForeColor = Color.Red;
            }



        }
    }
}
