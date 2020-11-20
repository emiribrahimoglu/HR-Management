using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IK_Yonetimi
{
    public partial class Form1 : Form
    {
        public static string dosyaYolu;
        public Form1()
        {
            InitializeComponent();
        }

        public static void DosyayaYaz()
        {
            File.Create(dosyaYolu).Dispose();
            File.WriteAllText(dosyaYolu, "");
            Başvurular.PreorderAgaciDosyayaYaz(Başvurular.kok);
        }

        public static void DosyadanOku()
        {
            using (Başvurular.sr)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = ".txt Dosyaları (*.txt)|*.txt";
                sfd.Title = "Başvuranların bilgisinin okunacağı dosyayı seçin";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    Başvurular.sr = new StreamReader(sfd.FileName);
                }
                do
                {
                    Başvurular.PreorderAgaciDosyadanOku();
                } while (Başvurular.sr.ReadLine() != null);
            }
            Başvurular.sr.Close();
        }

        private void basvuranBtn_Click(object sender, EventArgs e)
        {
            Giris g1 = new Giris();
            g1.Show();
        }

        private void elemanbulanBtn_Click(object sender, EventArgs e)
        {
            ElemanArayanSirket e1 = new ElemanArayanSirket();
            e1.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = ".txt Dosyaları (*.txt)|*.txt";
            sfd.Title = "Başvuranların bilgisinin nerede tutulacağını/tutulduğunu seçin";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Form1.dosyaYolu = sfd.FileName;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DosyayaYaz();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DosyadanOku();
        }
    }
}
