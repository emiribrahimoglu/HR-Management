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
        public Hesabım()
        {
            InitializeComponent();
        }

        private void Hesabım_Load(object sender, EventArgs e)
        {
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
            bolumTxt.Text = BasvuranBilgileri.egitimDurumu.sag.bolum;
            baslangicPicker.Value = BasvuranBilgileri.egitimDurumu.sag.sag.baslangic;
            bitisPicker.Value = BasvuranBilgileri.egitimDurumu.sag.sag.bitis;
            notortTxt.Text = BasvuranBilgileri.egitimDurumu.sag.sag.sag.notort.ToString();

            

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
