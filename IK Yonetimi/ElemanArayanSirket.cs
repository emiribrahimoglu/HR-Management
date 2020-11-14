using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IK_Yonetimi
{
    public partial class ElemanArayanSirket : Form
    {
        
        public ElemanArayanSirket()
        {
            InitializeComponent();
        }

        private void BasvuranlariListele(TumBasvuranlar tumBasvuranlar)
        {
            if (tumBasvuranlar != null)
            {
                if (tumBasvuranlar.ad != null)
                {
                    listBox1.Items.Add(tumBasvuranlar.ad);
                    BasvuranlariListele(tumBasvuranlar.sag);
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //uygulamak istediğimiz filtreler listboxta tutuldu. 
        //buradan alınarak filtreleri uygulama işleminde kullanılacaklar.
        private void filtreekleBtn_Click(object sender, EventArgs e)
        {
            secilenfiltrelerListBox.Items.Add(comboBox1.SelectedItem);
            secilenfiltrelerListBox.Items.Add(mindeneyimTxt.Text);
            secilenfiltrelerListBox.Items.Add(belirliyasaltiTxt.Text);
            secilenfiltrelerListBox.Items.Add(ehliyetTxt.Text);
        }

        
        private void filtreleriuygulaBtn_Click(object sender, EventArgs e)
        {

        }

        private void ElemanArayanSirket_Load(object sender, EventArgs e)
        {
            if (Başvurular.kok != null)
            {
                TumBasvuranlar.BasvuranlariDepola(Başvurular.kok, Başvurular.tumBasvuranlar);
                BasvuranlariListele(Başvurular.tumBasvuranlar);
            }
        }
    }

    public class TumBasvuranlar
    {
        public bool bosmu = true;
        public int basvuranNo;
        public string ad;
        public string adres;
        public double tel;
        public string mail;
        public DateTime dt;
        public string ydil;
        public string ehliyet;
        public IsDeneyimi isDeneyimi;
        public EgitimDurumu egitimDurumu;
        public TumBasvuranlar sag;

        public TumBasvuranlar()
        {
            bosmu = false;
        }

        public static void BasvuranlariDepola(Basvuran dugum, TumBasvuranlar tumBasvuranlar)
        {
            if (dugum != null)
            {
                if (!dugum.bosmu)
                {
                    tumBasvuranlar.bosmu = dugum.bosmu;
                    tumBasvuranlar.basvuranNo = dugum.basvuranNo;
                    tumBasvuranlar.ad = dugum.ad;
                    tumBasvuranlar.adres = dugum.adres;
                    tumBasvuranlar.tel = dugum.tel;
                    tumBasvuranlar.dt = dugum.dt;
                    tumBasvuranlar.ydil = dugum.ydil;
                    tumBasvuranlar.ehliyet = dugum.ehliyet;
                    tumBasvuranlar.isDeneyimi = dugum.isDeneyimi;
                    tumBasvuranlar.egitimDurumu = dugum.egitimDurumu;
                    tumBasvuranlar.sag = new TumBasvuranlar();
                    BasvuranlariDepola(dugum.sol, tumBasvuranlar.sag);
                    BasvuranlariDepola(dugum.sag, tumBasvuranlar.sag);

                }
                else
                {
                    BasvuranlariDepola(dugum.sol, tumBasvuranlar);
                    BasvuranlariDepola(dugum.sag, tumBasvuranlar);
                }
            }
        }
    }
}
