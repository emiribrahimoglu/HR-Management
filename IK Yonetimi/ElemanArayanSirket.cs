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
        private TumBasvuranlar filtrelenenBasvuranlar;
        private FiltreUygulanmislar tumBasvuranlar;
        private FiltreUygulanmislar filtreUygulanmislar1;
        private FiltreUygulanmislar filtreUygulanmislar2;
        private FiltreUygulanmislar filtreUygulanmislar3;
        private FiltreUygulanmislar filtreUygulanmislar4;
        private FiltreUygulanmislar filtreUygulanmislar5;
        private FiltreUygulanmislar filtreUygulanmislar6;
        private FiltreUygulanmislar filtreUygulanmislar7;
        
        public ElemanArayanSirket()
        {
            InitializeComponent();
        }
        /*
         * Her filtrede if-else if yapılarıyla üstteki nesnelerin null durumuna bakarak filtre uygulanmışların tekrar filtreye tabii tutulması sağlanacak.
         * Bunun için ilk uygulanacak filtrede tüm başvuranların adının bulunduğu bağlı listedeki isimlere filtre uygulanacak sonraki filtrelerde bir önceki
         * filtrenin kullandığı bağlı listedeki isimler üzerinde filtreleme işlemi uygulanacak. Son kullanılan filtreleme işleminde son bağlı listeye son
         * isimler girilecek. Sonrasında o isimler listbox'da gösterilecek.
         * */
        private void EnAzLisansFiltre(TumBasvuranlar tumBasvuranlar)
        {
            if (tumBasvuranlar != null)
            {
                if (tumBasvuranlar.ad != null)
                {
                    if (listBox1.Items.Contains(tumBasvuranlar.ad) && tumBasvuranlar.egitimDurumu.enAzLisans == true)
                    {
                        listBox1.Items.Add(tumBasvuranlar.ad);
                        EnAzLisansFiltre(tumBasvuranlar.sag);
                    }
                }
            }
        }

        private void IngilizceBilenlerFiltre(TumBasvuranlar tumBasvuranlar)
        {
            if (tumBasvuranlar != null)
            {
                if (tumBasvuranlar.ad != null)
                {
                    if (listBox1.Items.Contains(tumBasvuranlar.ad) && tumBasvuranlar.ydil.ToLower().Contains("en"))
                    {
                        listBox1.Items.Add(tumBasvuranlar.ad);
                        IngilizceBilenlerFiltre(tumBasvuranlar.sag);
                    }
                }
            }
        }

        private void BirdenFazlaDilBilenler(TumBasvuranlar tumBasvuranlar)
        {
            if (tumBasvuranlar != null)
            {
                if (tumBasvuranlar.ad != null)
                {
                    if (listBox1.Items.Contains(tumBasvuranlar.ad) && tumBasvuranlar.ydil.Length > 2)
                    {
                        listBox1.Items.Add(tumBasvuranlar.ad);
                        BirdenFazlaDilBilenler(tumBasvuranlar.sag);
                    }
                }
            }
        }

        private void DeneyimsizlerFiltre(TumBasvuranlar tumBasvuranlar)
        {
            if (tumBasvuranlar != null)
            {
                if (tumBasvuranlar.ad != null)
                {
                    if (listBox1.Items.Contains(tumBasvuranlar.ad) && tumBasvuranlar.isDeneyimi.sag.sag.sag.calismasuresi == 0)
                    {
                        listBox1.Items.Add(tumBasvuranlar.ad);
                        DeneyimsizlerFiltre(tumBasvuranlar.sag);
                    }
                }
            }
        }

        private void IsDeneyimiFiltre(TumBasvuranlar tumBasvuranlar)
        {
            if (tumBasvuranlar != null)
            {
                if (tumBasvuranlar.ad != null)
                {
                    if (listBox1.Items.Contains(tumBasvuranlar.ad) && tumBasvuranlar.isDeneyimi.sag.sag.sag.calismasuresi / 12 >= Convert.ToInt32(mindeneyimTxt.Text))
                    {
                        listBox1.Items.Add(tumBasvuranlar.ad);
                        IsDeneyimiFiltre(tumBasvuranlar.sag);
                    }
                }
            }
        }

        private void BelirliYasAltiFiltre(TumBasvuranlar tumBasvuranlar)
        {
            if (tumBasvuranlar != null)
            {
                if (tumBasvuranlar.ad != null)
                {
                    if (listBox1.Items.Contains(tumBasvuranlar.ad) && DateTime.Now.Year - tumBasvuranlar.dt.Year < Convert.ToInt32(belirliyasaltiTxt.Text))
                    {
                        listBox1.Items.Add(tumBasvuranlar.ad);
                        BelirliYasAltiFiltre(tumBasvuranlar.sag);
                    }
                }
            }
        }

        private void EhliyetTipiFiltre(TumBasvuranlar tumBasvuranlar)
        {
            if (tumBasvuranlar != null)
            {
                if (tumBasvuranlar.ad != null)
                {
                    if (listBox1.Items.Contains(tumBasvuranlar.ad) && tumBasvuranlar.ehliyet == "M")
                    {
                        listBox1.Items.Add(tumBasvuranlar.ad);
                        EhliyetTipiFiltre(tumBasvuranlar.sag);
                    }
                    else if (listBox1.Items.Contains(tumBasvuranlar.ad) && tumBasvuranlar.ehliyet == "A1")
                    {
                        listBox1.Items.Add(tumBasvuranlar.ad);
                        EhliyetTipiFiltre(tumBasvuranlar.sag);
                    }
                    else if (listBox1.Items.Contains(tumBasvuranlar.ad) && tumBasvuranlar.ehliyet == "A2")
                    {
                        listBox1.Items.Add(tumBasvuranlar.ad);
                        EhliyetTipiFiltre(tumBasvuranlar.sag);
                    }
                    else if (listBox1.Items.Contains(tumBasvuranlar.ad) && tumBasvuranlar.ehliyet == "A")
                    {
                        listBox1.Items.Add(tumBasvuranlar.ad);
                        EhliyetTipiFiltre(tumBasvuranlar.sag);
                    }
                    else if (listBox1.Items.Contains(tumBasvuranlar.ad) && tumBasvuranlar.ehliyet == "B1")
                    {
                        listBox1.Items.Add(tumBasvuranlar.ad);
                        EhliyetTipiFiltre(tumBasvuranlar.sag);
                    }
                    else if (listBox1.Items.Contains(tumBasvuranlar.ad) && tumBasvuranlar.ehliyet == "B")
                    {
                        listBox1.Items.Add(tumBasvuranlar.ad);
                        EhliyetTipiFiltre(tumBasvuranlar.sag);
                    }
                    else if (listBox1.Items.Contains(tumBasvuranlar.ad) && tumBasvuranlar.ehliyet == "BE")
                    {
                        listBox1.Items.Add(tumBasvuranlar.ad);
                        EhliyetTipiFiltre(tumBasvuranlar.sag);
                    }
                    else if (listBox1.Items.Contains(tumBasvuranlar.ad) && tumBasvuranlar.ehliyet == "C1")
                    {
                        listBox1.Items.Add(tumBasvuranlar.ad);
                        EhliyetTipiFiltre(tumBasvuranlar.sag);
                    }
                    else if (listBox1.Items.Contains(tumBasvuranlar.ad) && tumBasvuranlar.ehliyet == "C1E")
                    {
                        listBox1.Items.Add(tumBasvuranlar.ad);
                        EhliyetTipiFiltre(tumBasvuranlar.sag);
                    }
                    else if (listBox1.Items.Contains(tumBasvuranlar.ad) && tumBasvuranlar.ehliyet == "C")
                    {
                        listBox1.Items.Add(tumBasvuranlar.ad);
                        EhliyetTipiFiltre(tumBasvuranlar.sag);
                    }
                    else if (listBox1.Items.Contains(tumBasvuranlar.ad) && tumBasvuranlar.ehliyet == "CE")
                    {
                        listBox1.Items.Add(tumBasvuranlar.ad);
                        EhliyetTipiFiltre(tumBasvuranlar.sag);
                    }
                    else if (listBox1.Items.Contains(tumBasvuranlar.ad) && tumBasvuranlar.ehliyet == "D1")
                    {
                        listBox1.Items.Add(tumBasvuranlar.ad);
                        EhliyetTipiFiltre(tumBasvuranlar.sag);
                    }
                    else if (listBox1.Items.Contains(tumBasvuranlar.ad) && tumBasvuranlar.ehliyet == "D1E")
                    {
                        listBox1.Items.Add(tumBasvuranlar.ad);
                        EhliyetTipiFiltre(tumBasvuranlar.sag);
                    }
                    else if (listBox1.Items.Contains(tumBasvuranlar.ad) && tumBasvuranlar.ehliyet == "D")
                    {
                        listBox1.Items.Add(tumBasvuranlar.ad);
                        EhliyetTipiFiltre(tumBasvuranlar.sag);
                    }
                    else if (listBox1.Items.Contains(tumBasvuranlar.ad) && tumBasvuranlar.ehliyet == "DE")
                    {
                        listBox1.Items.Add(tumBasvuranlar.ad);
                        EhliyetTipiFiltre(tumBasvuranlar.sag);
                    }
                    else if (listBox1.Items.Contains(tumBasvuranlar.ad) && tumBasvuranlar.ehliyet == "F")
                    {
                        listBox1.Items.Add(tumBasvuranlar.ad);
                        EhliyetTipiFiltre(tumBasvuranlar.sag);
                    }
                    else if (listBox1.Items.Contains(tumBasvuranlar.ad) && tumBasvuranlar.ehliyet == "G")
                    {
                        listBox1.Items.Add(tumBasvuranlar.ad);
                        EhliyetTipiFiltre(tumBasvuranlar.sag);
                    }
                }
            }
        }

        private void Filtrele()
        {
            if (secilenfiltrelerListBox.Items.Contains("En az lisans mezunu olanlar"))
            {
                listBox1.Items.Add("--- En Az Lisans Mezunu Olanlar ---");
                EnAzLisansFiltre(Başvurular.tumBasvuranlar);
                for (int i = 0; i < listBox1.Items.IndexOf("--- En Az Lisans Mezunu Olanlar ---"); i++)
                {
                    listBox1.Items.RemoveAt(i);
                }
            }
            if (secilenfiltrelerListBox.Items.Contains("İngilizce bilenler"))
            {
                listBox1.Items.Add("--- İngilizce Bilenler ---");
                IngilizceBilenlerFiltre(Başvurular.tumBasvuranlar);
                for (int i = 0; i < listBox1.Items.IndexOf("--- İngilizce Bilenler ---"); i++)
                {
                    listBox1.Items.RemoveAt(i);
                }
            }
            if (secilenfiltrelerListBox.Items.Contains("Birden fazla yabancı dil bilenler"))
            {
                listBox1.Items.Add("--- Birden Fazla Yabancı Dil Bilenler ---");
                BirdenFazlaDilBilenler(Başvurular.tumBasvuranlar);
                for (int i = 0; i < listBox1.Items.IndexOf("--- Birden Fazla Yabancı Dil Bilenler ---"); i++)
                {
                    listBox1.Items.RemoveAt(i);
                }
            }
            if (secilenfiltrelerListBox.Items.Contains("Deneyimsizler"))
            {
                listBox1.Items.Add("--- Deneyimsizler ---");
                DeneyimsizlerFiltre(Başvurular.tumBasvuranlar);
                for (int i = 0; i < listBox1.Items.IndexOf("--- Deneyimsizler ---"); i++)
                {
                    listBox1.Items.RemoveAt(i);
                }
            }
            if (mindeneyimTxt.Text != "")
            {
                listBox1.Items.Add("--- Minimum İş Deneyimi " + mindeneyimTxt.Text + " Yıl ---");
                IsDeneyimiFiltre(Başvurular.tumBasvuranlar);
                for (int i = 0; i < listBox1.Items.IndexOf("--- Minimum İş Deneyimi " + mindeneyimTxt.Text + " Yıl ---"); i++)
                {
                    listBox1.Items.RemoveAt(i);
                }
            }
            if (belirliyasaltiTxt.Text != "")
            {
                listBox1.Items.Add("--- " + belirliyasaltiTxt.Text + " Yaşından Küçük Olanlar ---");
                BelirliYasAltiFiltre(Başvurular.tumBasvuranlar);
                for (int i = 0; i < listBox1.Items.IndexOf("--- " + belirliyasaltiTxt.Text + " Yaşından Küçük Olanlar ---"); i++)
                {
                    listBox1.Items.RemoveAt(i);
                }
            }
            if (ehliyetTxt.Text != "")
            {
                listBox1.Items.Add("--- Ehliyet Tipi " + ehliyetTxt.Text + " Olanlar ---");
                EhliyetTipiFiltre(Başvurular.tumBasvuranlar);
                for (int i = 0; i < listBox1.Items.IndexOf("--- Ehliyet Tipi " + ehliyetTxt.Text + " Olanlar ---"); i++)
                {
                    listBox1.Items.RemoveAt(i);
                }
            }

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

        private void IsimeGoreListele(TumBasvuranlar tumBasvuranlar)
        {
            if (textBox1.Text != "" && listBox1.Items.Count != 0)
            {
                if (listBox1.Items.Contains(textBox1.Text))
                {
                    listBox1.SelectedItem = textBox1.Text;
                }
            }
        }

        private void HerkesiListele()
        {
            if (Başvurular.kok != null)
            {
                TumBasvuranlar.BasvuranlariDepola(Başvurular.kok, Başvurular.tumBasvuranlar);
                BasvuranlariListele(Başvurular.tumBasvuranlar);
                filtrelenenBasvuranlar = Başvurular.tumBasvuranlar;
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
        }

        
        private void filtreleriuygulaBtn_Click(object sender, EventArgs e)
        {
            Filtrele();
        }

        private void ElemanArayanSirket_Load(object sender, EventArgs e)
        {
            HerkesiListele();
        }

        private void bilgigoruntuleBtn_Click(object sender, EventArgs e)
        {
            Başvurular.PreorderBilgiCek(Başvurular.kok, listBox1.SelectedItem.ToString());
            uyeadTxt.Text = BasvuranBilgileri.ad;
            uyeadresTxt.Text = BasvuranBilgileri.adres;
            uyetelTxt.Text = Convert.ToString(BasvuranBilgileri.tel);
            uyeepostaTxt.Text = BasvuranBilgileri.mail;
            dtPicker.Value = BasvuranBilgileri.dt;
            yabancidilTxt.Text = BasvuranBilgileri.ydil;
            textBox2.Text = BasvuranBilgileri.ehliyet;
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
            groupBox1.Visible = true;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            bilgigoruntuleBtn.Enabled = true;
        }

        private void adagorearaBtn_Click(object sender, EventArgs e)
        {
            IsimeGoreListele(Başvurular.tumBasvuranlar);
        }

        private void herkesiListeleBtn_Click(object sender, EventArgs e)
        {
            HerkesiListele();
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

    public class FiltreUygulanmislar
    {
        public string ad;
        public FiltreUygulanmislar sag = new FiltreUygulanmislar();
    }
}
