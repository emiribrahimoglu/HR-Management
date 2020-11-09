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
