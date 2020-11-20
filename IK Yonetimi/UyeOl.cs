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
            int basvuranNo = rd.Next(10000,99999); // Belirlenen aralıkta rastgele bir başvuranNo değeri tutuluyor. Ağaçta sağ-sol için belirleyici faktör.
            Başvurular.PreorderEkle(basvuranNo, uyeadTxt.Text, uyeadresTxt.Text, Convert.ToDouble(uyetelTxt.Text), uyeepostaTxt.Text, dogumTarihi.Value,
                yabancidilTxt.Text, ehliyetTxt.Text, isyeriadTxt.Text, isyeriadresTxt.Text, isyeripozisyonTxt.Text, Convert.ToInt32(calismasuresiTxt.Text), okuladTxt.Text,
                bolumTxt.Text, egitimBaslangicTarihi.Value, egitimBitisTarihi.Value, Convert.ToDouble(notortTxt.Text), enAzLisans.Checked);
            this.Close();
        }

        private void uyetelTxt_Validating(object sender, CancelEventArgs e)
        {
            double deger;
            if (!double.TryParse(uyetelTxt.Text, out deger))
            {
                errorProvider1.SetError(uyetelTxt, "Sadece rakam bulundurmalıdır!");
            }
        }

        private void calismasuresiTxt_Validating(object sender, CancelEventArgs e)
        {
            int deger;
            if (!int.TryParse(calismasuresiTxt.Text, out deger))
            {
                errorProvider2.SetError(calismasuresiTxt, "Sadece rakam bulundurmalıdır!");
            }
        }

        private void notortTxt_Validating(object sender, CancelEventArgs e)
        {
            double deger;
            if (!double.TryParse(notortTxt.Text, out deger))
            {
                errorProvider3.SetError(notortTxt, "Sadece rakam bulundurmalıdır! (Nokta işareti yardımıyıla ondalıklı sayı olabilir)");
            }
        }

        private void uyetelTxt_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void calismasuresiTxt_TextChanged(object sender, EventArgs e)
        {
            errorProvider2.Clear();
        }

        private void notortTxt_TextChanged(object sender, EventArgs e)
        {
            errorProvider3.Clear();
        }
    }
}
