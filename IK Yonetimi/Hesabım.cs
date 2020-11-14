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
    public partial class Hesabım : Form
    {
        int basvuranNo;
        bool bilgiguncellendiMi = false; // Bütün nesnelerin changed olayında bunu false yapacağız!!!
        public Hesabım()
        {
            InitializeComponent();
        }

        private void Hesabım_Load(object sender, EventArgs e)
        {
            basvuranNo = BasvuranBilgileri.basvuranNo;
            uyeadTxt.Text = BasvuranBilgileri.ad;
            uyeadresTxt.Text = BasvuranBilgileri.adres;
            uyetelTxt.Text = Convert.ToString(BasvuranBilgileri.tel);
            uyeepostaTxt.Text = BasvuranBilgileri.mail;
            dtPicker.Value = BasvuranBilgileri.dt;
            yabancidilTxt.Text = BasvuranBilgileri.ydil;
            ehliyetTxt.Text = BasvuranBilgileri.ehliyet;
            isyeriadTxt.Text = BasvuranBilgileri.isDeneyimi.isyeriad;
            isyeriadresTxt.Text = BasvuranBilgileri.isDeneyimi.sag.isyeriadres;
            isyeripozisyonTxt.Text = BasvuranBilgileri.isDeneyimi.sag.sag.pozisyon;
            calismasuresiTxt.Text = BasvuranBilgileri.isDeneyimi.sag.sag.sag.calismasuresi.ToString();
            okuladTxt.Text = BasvuranBilgileri.egitimDurumu.okulAd;
            enAzLisans.Checked = BasvuranBilgileri.egitimDurumu.enAzLisans;
            bolumTxt.Text = BasvuranBilgileri.egitimDurumu.sag.bolum;
            baslangicPicker.Value = BasvuranBilgileri.egitimDurumu.sag.sag.baslangic;
            bitisPicker.Value = BasvuranBilgileri.egitimDurumu.sag.sag.bitis;
            notortTxt.Text = BasvuranBilgileri.egitimDurumu.sag.sag.sag.notort.ToString();
        }

        private void bilgiguncelleBtn_Click(object sender, EventArgs e)
        {
            Başvurular.PreorderGuncelle(basvuranNo, uyeadTxt.Text, uyeadresTxt.Text, Convert.ToDouble(uyetelTxt.Text), uyeepostaTxt.Text, dtPicker.Value,
                yabancidilTxt.Text, ehliyetTxt.Text, isyeriadTxt.Text, isyeriadresTxt.Text, isyeripozisyonTxt.Text, Convert.ToInt32(calismasuresiTxt.Text), okuladTxt.Text,
                bolumTxt.Text, baslangicPicker.Value, bitisPicker.Value, Convert.ToDouble(notortTxt.Text), enAzLisans.Checked);
            bilgiguncellendiMi = true;
        }

        private void bilgisilmeBtn_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bilgilerinizi silmek istediğinize emin misiniz?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                if (bilgiguncellendiMi)
                {
                    Başvurular.PreorderBilgileriSil(basvuranNo, uyeadTxt.Text);
                    this.Close();
                }
                else
                {
                    Başvurular.PreorderBilgileriSil(basvuranNo, BasvuranBilgileri.ad);
                    this.Close();
                }
                
            }
        }
    }

    public class BasvuranBilgileri
    {
        public static int basvuranNo;
        public static string ad;
        public static string adres;
        public static double tel;
        public static string mail;
        public static DateTime dt;
        public static string ydil;
        public static string ehliyet;
        public static IsDeneyimi isDeneyimi;
        public static EgitimDurumu egitimDurumu;
    }
}
