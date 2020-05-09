using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayac = 0; // Global değişken olarak bilinen değişkenler aslında birer fielddir.

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = new Button();
            TextBox txt = new TextBox();

            MyClass myc = new MyClass(); // Bir class'ı kullanmak.
            myc.adi = "Negan"; // MyClass tipinden bir adet myc nesnesi oluşturuldu.
            myc.numarasi = 76;

            MyClass myc_2 = new MyClass();
            myc_2.adi = "Daryl";
            myc_2.numarasi = 98;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Ogrenci ogr = new Ogrenci();
            ogr.adi = txtAd.Text;
            ogr.soyadi = txtSoyad.Text;
            ogr.ogrenci_no = Convert.ToInt32(txtNo.Text);
            ogr.vize = Convert.ToSingle(txtVize.Text);
            ogr.final = Convert.ToSingle(txtFinal.Text);
        }
    }
}
/* OOP(Object Oriented Programming(Nesne Yönelimli Programlama)):
   Dünyanın en önemli programlama yaklaşımıdır. 
   Gündelik hayattaki varlıkların (nesnelerin) veya yaklaşımların programlama 
   diline modellenmesidir.
   OOP'nin temelini oluşturan varlıklar classlardır.
   Class: Birden fazla veya farklı veritiplerinin toplandığı genel bir çatıdır. Classlar bize
   kendimize ait veri tipleri oluşturmamızı sağlar.
   OOP'nin genel yaklaşıı şudur: Bir kere yaz her yerde kullan. Yani tekrar kullanabilmeyi
   arttırmaktır.
   Bir class eklemek için projeye sağ tıklayıp add new item diyerek class sekmesinden
   bir isim verilmelidir.
   new komutu instance almak için (ilgili classtan oluşan nesneyi(myc) ram üzerinde
   kullanılabilir hale getirmek) kullanılır.
*/