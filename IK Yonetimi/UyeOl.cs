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
    public partial class UyeOl : Form
    {
        public UyeOl()
        {
            InitializeComponent();
        }

        private void uyeolBtn_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            int basvuranNo = rd.Next(10000,99999);
            Başvurular.PreorderEkle(basvuranNo, uyeadTxt.Text, uyeadresTxt.Text, Convert.ToDouble(uyetelTxt.Text), uyeepostaTxt.Text, dogumTarihi.Value,
                yabancidilTxt.Text, ehliyetTxt.Text, isyeriadTxt.Text, isyeriadresTxt.Text, isyeripozisyonTxt.Text, Convert.ToInt32(calismasuresiTxt.Text), okuladTxt.Text,
                bolumTxt.Text, egitimBaslangicTarihi.Value, egitimBitisTarihi.Value, Convert.ToDouble(notortTxt.Text));
        }
    }
}
