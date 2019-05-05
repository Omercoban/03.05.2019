using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3._5._19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //random ürettik
        Random salla = new Random();

        double boy, kilo, endeks;
        

        int sayac = 0;
        //isimler dizisi oluşturduk
        string[] isimler = new string[] { "ömer", "EZGİİİ", "eda", "faruk", "bilal", "merve", "fatma", "ömer faruk", "kadir" };

        string[] soyisimler = new string[] { "Çoban", "Ertuğal", "Arslan", "Yılmaz", "Çelik", "Öz", "Üstün", "asdf" };
        
        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {


                dataGridView1.Rows.Add();

                int isim, soyisim;
                
               


                isim = salla.Next(0, isimler.Length);

                soyisim = salla.Next(0, soyisimler.Length);

                dataGridView1.Rows[i].Cells[0].Value = isimler[isim];
                dataGridView1.Rows[i].Cells[1].Value = soyisimler[soyisim];
                dataGridView1.Rows[i].Cells[2].Value = salla.Next(1, 100);

                kilo = salla.Next(35, 250);
                boy = salla.Next(130, 250);
                boy = boy / 100;

                dataGridView1.Rows[i].Cells[3].Value = boy.ToString();//boy
                dataGridView1.Rows[i].Cells[4].Value = kilo.ToString();//kilo

              endeks= kilo / (boy * boy);
                dataGridView1.Rows[i].Cells[5].Value = endeks.ToString();// kitle endeksi

                //oluşturulan isim ve soyisimleri rastgele şekilde datagrid in içine attık 
                //ödev= boy kilo eklensin ve vücut kitle endeksini hesaplatacaz






            }
        }
    }
}
