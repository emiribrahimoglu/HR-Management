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
        private void EnAzLisansFiltre(TumBasvuranlar tumBasvuranlar, FiltreUygulanmislar filtreUygulanmislar) //gelen filtreuygulanmislar1
        {
            if (tumBasvuranlar != null)
            {
                if (tumBasvuranlar.ad != null)
                {
                    if (tumBasvuranlar.egitimDurumu.enAzLisans == true)
                    {
                        //listBox1.Items.Add(tumBasvuranlar.ad);
                        filtreUygulanmislar.ad = tumBasvuranlar.ad;
                        filtreUygulanmislar.sag = new FiltreUygulanmislar();
                        EnAzLisansFiltre(tumBasvuranlar.sag, filtreUygulanmislar.sag);
                    }
                    else
                    {
                        EnAzLisansFiltre(tumBasvuranlar.sag, filtreUygulanmislar);
                    }
                }
            }
        }

        private void IngilizceBilenlerFiltre(TumBasvuranlar tumBasvuranlar, FiltreUygulanmislar filtreUygulanmislar) // gelen filtreuygulanmislar1
        {
            if (tumBasvuranlar != null)
            {
                if (tumBasvuranlar.ad != null)
                {
                    if (tumBasvuranlar.ydil.ToLower().Contains("en"))
                    {
                        filtreUygulanmislar.ad = tumBasvuranlar.ad;
                        filtreUygulanmislar.sag = new FiltreUygulanmislar();
                        IngilizceBilenlerFiltre(tumBasvuranlar.sag, filtreUygulanmislar.sag);
                    }
                    else
                    {
                        IngilizceBilenlerFiltre(tumBasvuranlar.sag, filtreUygulanmislar);
                    }
                }
            }
        }

        private void IngilizceBilenlerFiltre(TumBasvuranlar tumBasvuranlar, FiltreUygulanmislar filtreUygulanmamislar, FiltreUygulanmislar OncekiFiltreUygulanmislar)
        {
            if (tumBasvuranlar != null)
            {
                if (tumBasvuranlar.ad != null)
                {
                    if (tumBasvuranlar.ad == OncekiFiltreUygulanmislar.ad && tumBasvuranlar.ydil.ToLower().Contains("en"))
                    {
                        OncekiFiltreUygulanmislar.ad = tumBasvuranlar.ad;
                        filtreUygulanmamislar.sag = new FiltreUygulanmislar();
                        IngilizceBilenlerFiltre(tumBasvuranlar.sag, filtreUygulanmamislar.sag, OncekiFiltreUygulanmislar.sag);
                    }
                    else if (tumBasvuranlar.ad != OncekiFiltreUygulanmislar.ad)
                    {
                        IngilizceBilenlerFiltre(tumBasvuranlar.sag, filtreUygulanmamislar, OncekiFiltreUygulanmislar);
                    }
                    else
                    {
                        IngilizceBilenlerFiltre(tumBasvuranlar.sag, filtreUygulanmamislar, OncekiFiltreUygulanmislar.sag);
                    }
                }
            }
        }

        private void BirdenFazlaDilBilenler(TumBasvuranlar tumBasvuranlar, FiltreUygulanmislar filtreUygulanmislar) //gelen filtreuygulanmislar1
        {
            if (tumBasvuranlar != null)
            {
                if (tumBasvuranlar.ad != null)
                {
                    if (tumBasvuranlar.ydil.Length > 2)
                    {
                        filtreUygulanmislar.ad = tumBasvuranlar.ad;
                        filtreUygulanmislar.sag = new FiltreUygulanmislar();
                        BirdenFazlaDilBilenler(tumBasvuranlar.sag, filtreUygulanmislar.sag);
                    }
                    else
                    {
                        BirdenFazlaDilBilenler(tumBasvuranlar.sag, filtreUygulanmislar);
                    }
                }
            }
        }

        private void BirdenFazlaDilBilenler(TumBasvuranlar tumBasvuranlar, FiltreUygulanmislar filtreUygulanmamislar, FiltreUygulanmislar OncekiFiltreUygulanmislar)
        {
            if (tumBasvuranlar != null)
            {
                if (tumBasvuranlar.ad != null)
                {
                    if (tumBasvuranlar.ad == OncekiFiltreUygulanmislar.ad && tumBasvuranlar.ydil.Length > 2)
                    {
                        filtreUygulanmamislar.ad = tumBasvuranlar.ad;
                        filtreUygulanmamislar.sag = new FiltreUygulanmislar();
                        BirdenFazlaDilBilenler(tumBasvuranlar.sag, filtreUygulanmamislar.sag, OncekiFiltreUygulanmislar.sag);
                    }
                    else if (tumBasvuranlar.ad != OncekiFiltreUygulanmislar.ad)
                    {
                        BirdenFazlaDilBilenler(tumBasvuranlar.sag, filtreUygulanmamislar, OncekiFiltreUygulanmislar);
                    }
                    else
                    {
                        BirdenFazlaDilBilenler(tumBasvuranlar.sag, filtreUygulanmamislar, OncekiFiltreUygulanmislar.sag);
                    }
                }
            }
        }

        private void DeneyimsizlerFiltre(TumBasvuranlar tumBasvuranlar, FiltreUygulanmislar filtreUygulanmamislar) //gelen filtreuygulanmislar1
        {
            if (tumBasvuranlar != null)
            {
                if (tumBasvuranlar.ad != null)
                {
                    if (tumBasvuranlar.isDeneyimi.sag.sag.sag.calismasuresi == 0)
                    {
                        filtreUygulanmamislar.ad = tumBasvuranlar.ad;
                        filtreUygulanmamislar.sag = new FiltreUygulanmislar();
                        DeneyimsizlerFiltre(tumBasvuranlar.sag, filtreUygulanmamislar.sag);
                    }
                    else
                    {
                        DeneyimsizlerFiltre(tumBasvuranlar.sag, filtreUygulanmamislar);
                    }
                }
            }
        }

        private void DeneyimsizlerFiltre(TumBasvuranlar tumBasvuranlar, FiltreUygulanmislar filtreUygulanmamislar, FiltreUygulanmislar OncekiFiltreUygulanmislar) //gelen filtreuygulanmislar1
        {
            if (tumBasvuranlar != null)
            {
                if (tumBasvuranlar.ad != null)
                {
                    if (tumBasvuranlar.ad == OncekiFiltreUygulanmislar.ad && tumBasvuranlar.isDeneyimi.sag.sag.sag.calismasuresi == 0)
                    {
                        filtreUygulanmamislar.ad = tumBasvuranlar.ad;
                        filtreUygulanmamislar.sag = new FiltreUygulanmislar();
                        DeneyimsizlerFiltre(tumBasvuranlar.sag, filtreUygulanmamislar.sag, OncekiFiltreUygulanmislar.sag);
                    }
                    else if(tumBasvuranlar.ad != OncekiFiltreUygulanmislar.ad)
                    {
                        DeneyimsizlerFiltre(tumBasvuranlar.sag, filtreUygulanmamislar, OncekiFiltreUygulanmislar);
                    }
                    else
                    {
                        DeneyimsizlerFiltre(tumBasvuranlar.sag, filtreUygulanmamislar, OncekiFiltreUygulanmislar.sag);
                    }
                }
            }
        }

        private void IsDeneyimiFiltre(TumBasvuranlar tumBasvuranlar, FiltreUygulanmislar filtreUygulanmamislar) //gelen filtreuygulanmislar1
        {
            if (tumBasvuranlar != null)
            {
                if (tumBasvuranlar.ad != null)
                {
                    if (tumBasvuranlar.isDeneyimi.sag.sag.sag.calismasuresi / 12 >= Convert.ToInt32(mindeneyimTxt.Text))
                    {
                        filtreUygulanmamislar.ad = tumBasvuranlar.ad;
                        filtreUygulanmamislar.sag = new FiltreUygulanmislar();
                        IsDeneyimiFiltre(tumBasvuranlar.sag, filtreUygulanmamislar.sag);
                    }
                    else
                    {
                        IsDeneyimiFiltre(tumBasvuranlar.sag, filtreUygulanmamislar);
                    }
                }
            }
        }

        private void IsDeneyimiFiltre(TumBasvuranlar tumBasvuranlar, FiltreUygulanmislar filtreUygulanmamislar, FiltreUygulanmislar oncekiFiltreUygulanmislar)
        {
            if (tumBasvuranlar != null)
            {
                if (tumBasvuranlar.ad != null)
                {
                    if (tumBasvuranlar.ad == oncekiFiltreUygulanmislar.ad && tumBasvuranlar.isDeneyimi.sag.sag.sag.calismasuresi / 12 >= Convert.ToInt32(mindeneyimTxt.Text))
                    {
                        filtreUygulanmamislar.ad = tumBasvuranlar.ad;
                        filtreUygulanmamislar.sag = new FiltreUygulanmislar();
                        IsDeneyimiFiltre(tumBasvuranlar.sag, filtreUygulanmamislar.sag, oncekiFiltreUygulanmislar.sag);
                    }
                    else if (tumBasvuranlar.ad != oncekiFiltreUygulanmislar.ad)
                    {
                        IsDeneyimiFiltre(tumBasvuranlar.sag, filtreUygulanmamislar, oncekiFiltreUygulanmislar);
                    }
                    else
                    {
                        IsDeneyimiFiltre(tumBasvuranlar.sag, filtreUygulanmamislar, oncekiFiltreUygulanmislar.sag);
                    }
                }
            }
        }

        private void BelirliYasAltiFiltre(TumBasvuranlar tumBasvuranlar, FiltreUygulanmislar filtreUygulanmamislar)
        {
            if (tumBasvuranlar != null)
            {
                if (tumBasvuranlar.ad != null)
                {
                    if (DateTime.Now.Year - tumBasvuranlar.dt.Year < Convert.ToInt32(belirliyasaltiTxt.Text))
                    {
                        filtreUygulanmamislar.ad = tumBasvuranlar.ad;
                        filtreUygulanmamislar.sag = new FiltreUygulanmislar();
                        BelirliYasAltiFiltre(tumBasvuranlar.sag, filtreUygulanmamislar.sag);
                    }
                    else
                    {
                        BelirliYasAltiFiltre(tumBasvuranlar.sag, filtreUygulanmamislar);
                    }
                }
            }
        }

        private void BelirliYasAltiFiltre(TumBasvuranlar tumBasvuranlar, FiltreUygulanmislar filtreUygulanmamislar, FiltreUygulanmislar oncekiFiltreUygulanmislar)
        {
            if (tumBasvuranlar != null)
            {
                if (tumBasvuranlar.ad != null)
                {
                    if (tumBasvuranlar.ad == oncekiFiltreUygulanmislar.ad && DateTime.Now.Year - tumBasvuranlar.dt.Year < Convert.ToInt32(belirliyasaltiTxt.Text))
                    {
                        filtreUygulanmamislar.ad = tumBasvuranlar.ad;
                        filtreUygulanmamislar.sag = new FiltreUygulanmislar();
                        BelirliYasAltiFiltre(tumBasvuranlar.sag, filtreUygulanmamislar.sag, oncekiFiltreUygulanmislar.sag);
                    }
                    else if (tumBasvuranlar.ad != oncekiFiltreUygulanmislar.ad)
                    {
                        BelirliYasAltiFiltre(tumBasvuranlar.sag, filtreUygulanmamislar, oncekiFiltreUygulanmislar);
                    }
                    else
                    {
                        BelirliYasAltiFiltre(tumBasvuranlar.sag, filtreUygulanmamislar, oncekiFiltreUygulanmislar.sag);
                    }
                }
            }
        }

        private void EhliyetTipiFiltre(TumBasvuranlar tumBasvuranlar, FiltreUygulanmislar filtreUygulanmamislar)
        {
            if (tumBasvuranlar != null)
            {
                if (tumBasvuranlar.ad != null)
                {

                    if (tumBasvuranlar.ehliyet == ehliyetTxt.Text)
                    {
                        filtreUygulanmamislar.ad = tumBasvuranlar.ad;
                        filtreUygulanmamislar.sag = new FiltreUygulanmislar();
                        EhliyetTipiFiltre(tumBasvuranlar.sag, filtreUygulanmamislar.sag);
                    }
                    else
                    {
                        EhliyetTipiFiltre(tumBasvuranlar.sag, filtreUygulanmamislar);
                    }
                }
            }
        }

        private void EhliyetTipiFiltre(TumBasvuranlar tumBasvuranlar, FiltreUygulanmislar filtreUygulanmamislar, FiltreUygulanmislar oncekiFiltreUygulanmislar)
        {
            if (tumBasvuranlar != null)
            {
                if (tumBasvuranlar.ad != null)
                {
                    if (tumBasvuranlar.ad == oncekiFiltreUygulanmislar.ad && tumBasvuranlar.ehliyet == ehliyetTxt.Text)
                    {
                        filtreUygulanmamislar.ad = tumBasvuranlar.ad;
                        filtreUygulanmamislar.sag = new FiltreUygulanmislar();
                        EhliyetTipiFiltre(tumBasvuranlar.sag, filtreUygulanmamislar.sag, oncekiFiltreUygulanmislar.sag);
                    }
                    else if (tumBasvuranlar.ad != oncekiFiltreUygulanmislar.ad)
                    {
                        EhliyetTipiFiltre(tumBasvuranlar.sag, filtreUygulanmamislar, oncekiFiltreUygulanmislar);
                    }
                    else
                    {
                        EhliyetTipiFiltre(tumBasvuranlar.sag, filtreUygulanmamislar, oncekiFiltreUygulanmislar.sag);
                    }


                }
            }
        }

        private void FiltrelemeIslemi(TumBasvuranlar tumBasvuranlar, int filtreNum)
        {
            if (tumBasvuranlar != null)
            {
                if (tumBasvuranlar.ad != null)
                {
                    if (filtreNum == 1 && tumBasvuranlar.egitimDurumu.enAzLisans == true)
                    {
                        listBox1.Items.Add(tumBasvuranlar.ad);
                    }
                    else if (filtreNum == 2 && tumBasvuranlar.ydil.ToLower().Contains("en"))
                    {
                        listBox1.Items.Add(tumBasvuranlar.ad);
                    }
                    else if (filtreNum == 3 && tumBasvuranlar.ydil.Length > 2)
                    {
                        listBox1.Items.Add(tumBasvuranlar.ad);
                    }
                    else if (filtreNum == 4 && tumBasvuranlar.isDeneyimi.sag.sag.sag.calismasuresi == 0)
                    {
                        listBox1.Items.Add(tumBasvuranlar.ad);
                    }
                    else if (filtreNum == 5 && tumBasvuranlar.isDeneyimi.sag.sag.sag.calismasuresi / 12 >= Convert.ToInt32(mindeneyimTxt.Text))
                    {
                        listBox1.Items.Add(tumBasvuranlar.ad);
                    }
                    else if (filtreNum == 6 && DateTime.Now.Year - tumBasvuranlar.dt.Year < Convert.ToInt32(belirliyasaltiTxt.Text))
                    {
                        listBox1.Items.Add(tumBasvuranlar.ad);
                    }
                    else if (filtreNum == 7)
                    {
                        if (tumBasvuranlar.ehliyet == ehliyetTxt.Text)
                        {
                            listBox1.Items.Add(tumBasvuranlar.ad);
                        }
                        /*else if (tumBasvuranlar.ehliyet == "A1")
                        {
                            listBox1.Items.Add(tumBasvuranlar.ad);
                        }
                        else if (tumBasvuranlar.ehliyet == "A2")
                        {
                            listBox1.Items.Add(tumBasvuranlar.ad);
                        }
                        else if (tumBasvuranlar.ehliyet == "A")
                        {
                            listBox1.Items.Add(tumBasvuranlar.ad);
                        }
                        else if (tumBasvuranlar.ehliyet == "B1")
                        {
                            listBox1.Items.Add(tumBasvuranlar.ad);
                        }
                        else if (tumBasvuranlar.ehliyet == "B")
                        {
                            listBox1.Items.Add(tumBasvuranlar.ad);
                        }
                        else if (tumBasvuranlar.ehliyet == "BE")
                        {
                            listBox1.Items.Add(tumBasvuranlar.ad);
                        }
                        else if (tumBasvuranlar.ehliyet == "C1")
                        {
                            listBox1.Items.Add(tumBasvuranlar.ad);
                        }
                        else if (tumBasvuranlar.ehliyet == "C1E")
                        {
                            listBox1.Items.Add(tumBasvuranlar.ad);
                        }
                        else if (tumBasvuranlar.ehliyet == "C")
                        {
                            listBox1.Items.Add(tumBasvuranlar.ad);
                        }
                        else if (tumBasvuranlar.ehliyet == "CE")
                        {
                            listBox1.Items.Add(tumBasvuranlar.ad);
                        }
                        else if (tumBasvuranlar.ehliyet == "D1")
                        {
                            listBox1.Items.Add(tumBasvuranlar.ad);
                        }
                        else if (tumBasvuranlar.ehliyet == "D1E")
                        {
                            listBox1.Items.Add(tumBasvuranlar.ad);
                        }
                        else if (tumBasvuranlar.ehliyet == "D")
                        {
                            listBox1.Items.Add(tumBasvuranlar.ad);
                        }
                        else if (tumBasvuranlar.ehliyet == "DE")
                        {
                            listBox1.Items.Add(tumBasvuranlar.ad);
                        }
                        else if (tumBasvuranlar.ehliyet == "F")
                        {
                            listBox1.Items.Add(tumBasvuranlar.ad);
                        }
                        else if (tumBasvuranlar.ehliyet == "G")
                        {
                            listBox1.Items.Add(tumBasvuranlar.ad);
                        }*/
                    }
                    FiltrelemeIslemi(tumBasvuranlar.sag, filtreNum);
                }
            }
        }

        private void Filtrele()
        {
            if (secilenfiltrelerListBox.Items.Contains("En az lisans mezunu olanlar"))
            {
                //listBox1.Items.Clear();
                //FiltrelemeIslemi(Başvurular.tumBasvuranlar, 1);
                //listBox1.Items.Add("--- En Az Lisans Mezunu Olanlar ---");
                filtreUygulanmislar1 = new FiltreUygulanmislar();
                EnAzLisansFiltre(Başvurular.tumBasvuranlar, filtreUygulanmislar1);
                /*for (int i = 0; i < listBox1.Items.IndexOf("--- En Az Lisans Mezunu Olanlar ---"); i++)
                {
                    listBox1.Items.RemoveAt(i);
                }*/
            }
            if (secilenfiltrelerListBox.Items.Contains("İngilizce bilenler"))
            {
                //listBox1.Items.Clear();
                //FiltrelemeIslemi(Başvurular.tumBasvuranlar, 2);
                //listBox1.Items.Add("--- İngilizce Bilenler ---");
                if (filtreUygulanmislar1 != null)
                {
                    filtreUygulanmislar2 = new FiltreUygulanmislar();
                    IngilizceBilenlerFiltre(Başvurular.tumBasvuranlar, filtreUygulanmislar2, filtreUygulanmislar1);
                }
                else
                {
                    filtreUygulanmislar1 = new FiltreUygulanmislar();
                    IngilizceBilenlerFiltre(Başvurular.tumBasvuranlar, filtreUygulanmislar1);
                }
                /*for (int i = 0; i < listBox1.Items.IndexOf("--- İngilizce Bilenler ---"); i++)
                {
                    listBox1.Items.RemoveAt(i);
                }*/
            }
            if (secilenfiltrelerListBox.Items.Contains("Birden fazla yabancı dil bilenler"))
            {
                //listBox1.Items.Clear();
                //FiltrelemeIslemi(Başvurular.tumBasvuranlar, 3);
                //listBox1.Items.Add("--- Birden Fazla Yabancı Dil Bilenler ---");
                if (filtreUygulanmislar2 != null)
                {
                    filtreUygulanmislar3 = new FiltreUygulanmislar();
                    BirdenFazlaDilBilenler(Başvurular.tumBasvuranlar, filtreUygulanmislar3, filtreUygulanmislar2);
                }
                else if (filtreUygulanmislar1 != null)
                {
                    filtreUygulanmislar3 = new FiltreUygulanmislar();
                    BirdenFazlaDilBilenler(Başvurular.tumBasvuranlar, filtreUygulanmislar3, filtreUygulanmislar1);
                }
                else
                {
                    filtreUygulanmislar1 = new FiltreUygulanmislar();
                    BirdenFazlaDilBilenler(Başvurular.tumBasvuranlar, filtreUygulanmislar1);
                }
                /*for (int i = 0; i < listBox1.Items.IndexOf("--- Birden Fazla Yabancı Dil Bilenler ---"); i++)
                {
                    listBox1.Items.RemoveAt(i);
                }*/
            }
            if (secilenfiltrelerListBox.Items.Contains("Deneyimsizler"))
            {
                //listBox1.Items.Clear();
                //FiltrelemeIslemi(Başvurular.tumBasvuranlar, 4);
                //listBox1.Items.Add("--- Deneyimsizler ---");
                if (filtreUygulanmislar3 != null)
                {
                    filtreUygulanmislar4 = new FiltreUygulanmislar();
                    DeneyimsizlerFiltre(Başvurular.tumBasvuranlar, filtreUygulanmislar4, filtreUygulanmislar3);
                }
                else if (filtreUygulanmislar2 != null)
                {
                    filtreUygulanmislar4 = new FiltreUygulanmislar();
                    DeneyimsizlerFiltre(Başvurular.tumBasvuranlar, filtreUygulanmislar4, filtreUygulanmislar2);
                }
                else if (filtreUygulanmislar1 != null)
                {
                    filtreUygulanmislar4 = new FiltreUygulanmislar();
                    DeneyimsizlerFiltre(Başvurular.tumBasvuranlar, filtreUygulanmislar4, filtreUygulanmislar1);
                }
                else
                {
                    filtreUygulanmislar1 = new FiltreUygulanmislar();
                    DeneyimsizlerFiltre(Başvurular.tumBasvuranlar, filtreUygulanmislar1);
                }
                /*for (int i = 0; i < listBox1.Items.IndexOf("--- Deneyimsizler ---"); i++)
                {
                    listBox1.Items.RemoveAt(i);
                }*/
            }
            if (mindeneyimTxt.Text != "")
            {
                //listBox1.Items.Clear();
                //FiltrelemeIslemi(Başvurular.tumBasvuranlar, 5);
                //listBox1.Items.Add("--- Minimum İş Deneyimi " + mindeneyimTxt.Text + " Yıl ---");
                if (filtreUygulanmislar4 != null)
                {
                    filtreUygulanmislar5 = new FiltreUygulanmislar();
                    IsDeneyimiFiltre(Başvurular.tumBasvuranlar, filtreUygulanmislar5, filtreUygulanmislar4);
                }
                else if (filtreUygulanmislar3 != null)
                {
                    filtreUygulanmislar5 = new FiltreUygulanmislar();
                    IsDeneyimiFiltre(Başvurular.tumBasvuranlar, filtreUygulanmislar5, filtreUygulanmislar3);
                }
                else if (filtreUygulanmislar2 != null)
                {
                    filtreUygulanmislar5 = new FiltreUygulanmislar();
                    IsDeneyimiFiltre(Başvurular.tumBasvuranlar, filtreUygulanmislar5, filtreUygulanmislar2);
                }
                else if (filtreUygulanmislar1 != null)
                {
                    filtreUygulanmislar5 = new FiltreUygulanmislar();
                    IsDeneyimiFiltre(Başvurular.tumBasvuranlar, filtreUygulanmislar5, filtreUygulanmislar1);
                }
                else
                {
                    filtreUygulanmislar1 = new FiltreUygulanmislar();
                    IsDeneyimiFiltre(Başvurular.tumBasvuranlar, filtreUygulanmislar1);
                }
                /*for (int i = 0; i < listBox1.Items.IndexOf("--- Minimum İş Deneyimi " + mindeneyimTxt.Text + " Yıl ---"); i++)
                {
                    listBox1.Items.RemoveAt(i);
                }*/
            }
            if (belirliyasaltiTxt.Text != "")
            {
                //listBox1.Items.Clear();
                //FiltrelemeIslemi(Başvurular.tumBasvuranlar, 6);
                //listBox1.Items.Add("--- " + belirliyasaltiTxt.Text + " Yaşından Küçük Olanlar ---");
                if (filtreUygulanmislar5 != null)
                {
                    filtreUygulanmislar6 = new FiltreUygulanmislar();
                    BelirliYasAltiFiltre(Başvurular.tumBasvuranlar, filtreUygulanmislar6, filtreUygulanmislar5);
                }
                else if (filtreUygulanmislar4 != null)
                {
                    filtreUygulanmislar6 = new FiltreUygulanmislar();
                    BelirliYasAltiFiltre(Başvurular.tumBasvuranlar, filtreUygulanmislar6, filtreUygulanmislar4);
                }
                else if (filtreUygulanmislar3 != null)
                {
                    filtreUygulanmislar6 = new FiltreUygulanmislar();
                    BelirliYasAltiFiltre(Başvurular.tumBasvuranlar, filtreUygulanmislar6, filtreUygulanmislar3);
                }
                else if (filtreUygulanmislar2 != null)
                {
                    filtreUygulanmislar6 = new FiltreUygulanmislar();
                    BelirliYasAltiFiltre(Başvurular.tumBasvuranlar, filtreUygulanmislar6, filtreUygulanmislar2);
                }
                else if (filtreUygulanmislar1 != null)
                {
                    filtreUygulanmislar6 = new FiltreUygulanmislar();
                    BelirliYasAltiFiltre(Başvurular.tumBasvuranlar, filtreUygulanmislar6, filtreUygulanmislar1);
                }
                else
                {
                    filtreUygulanmislar1 = new FiltreUygulanmislar();
                    BelirliYasAltiFiltre(Başvurular.tumBasvuranlar, filtreUygulanmislar1);
                }
                /*for (int i = 0; i < listBox1.Items.IndexOf("--- " + belirliyasaltiTxt.Text + " Yaşından Küçük Olanlar ---"); i++)
                {
                    listBox1.Items.RemoveAt(i);
                }*/
            }
            if (ehliyetTxt.Text != "")
            {
                listBox1.Items.Clear();
                FiltrelemeIslemi(Başvurular.tumBasvuranlar, 7);
                goto Filtresonubypass;
                //listBox1.Items.Add("--- Ehliyet Tipi " + ehliyetTxt.Text + " Olanlar ---");
                /*if (filtreUygulanmislar6 != null)
                {
                    filtreUygulanmislar7 = new FiltreUygulanmislar();
                    EhliyetTipiFiltre(Başvurular.tumBasvuranlar, filtreUygulanmislar7, filtreUygulanmislar6);
                }
                else if (filtreUygulanmislar5 != null)
                {
                    filtreUygulanmislar7 = new FiltreUygulanmislar();
                    EhliyetTipiFiltre(Başvurular.tumBasvuranlar, filtreUygulanmislar7, filtreUygulanmislar5);
                }
                else if (filtreUygulanmislar4 != null)
                {
                    filtreUygulanmislar7 = new FiltreUygulanmislar();
                    EhliyetTipiFiltre(Başvurular.tumBasvuranlar, filtreUygulanmislar7, filtreUygulanmislar4);
                }
                else if (filtreUygulanmislar3 != null)
                {
                    filtreUygulanmislar7 = new FiltreUygulanmislar();
                    EhliyetTipiFiltre(Başvurular.tumBasvuranlar, filtreUygulanmislar7, filtreUygulanmislar3);
                }
                else if (filtreUygulanmislar2 != null)
                {
                    filtreUygulanmislar7 = new FiltreUygulanmislar();
                    EhliyetTipiFiltre(Başvurular.tumBasvuranlar, filtreUygulanmislar7, filtreUygulanmislar2);
                }
                else if (filtreUygulanmislar1 != null)
                {
                    filtreUygulanmislar7 = new FiltreUygulanmislar();
                    EhliyetTipiFiltre(Başvurular.tumBasvuranlar, filtreUygulanmislar7, filtreUygulanmislar1);
                }
                else
                {
                    filtreUygulanmislar1 = new FiltreUygulanmislar();
                    EhliyetTipiFiltre(Başvurular.tumBasvuranlar, filtreUygulanmislar1);
                }
                HangiFiltrelenmisDegiskeni();
                /*for (int i = 0; i < listBox1.Items.IndexOf("--- Ehliyet Tipi " + ehliyetTxt.Text + " Olanlar ---"); i++)
                {
                    listBox1.Items.RemoveAt(i);
                }*/
            }
            HangiFiltrelenmisDegiskeni();
            Filtresonubypass:;

        }

        private void FiltrelemeSonucGoster(FiltreUygulanmislar filtreUygulanmislar)
        {
            if (filtreUygulanmislar != null)
            {
                if (filtreUygulanmislar.ad != null)
                {
                    listBox1.Items.Add(filtreUygulanmislar.ad);
                    FiltrelemeSonucGoster(filtreUygulanmislar.sag);
                }
            }
            
        }

        private void HangiFiltrelenmisDegiskeni()
        {
            listBox1.Items.Clear();
            if (filtreUygulanmislar7 != null)
            {
                FiltrelemeSonucGoster(filtreUygulanmislar7);
            }
            else if (filtreUygulanmislar6 != null)
            {
                FiltrelemeSonucGoster(filtreUygulanmislar6);
            }
            else if (filtreUygulanmislar5 != null)
            {
                FiltrelemeSonucGoster(filtreUygulanmislar5);
            }
            else if (filtreUygulanmislar4 != null)
            {
                FiltrelemeSonucGoster(filtreUygulanmislar4);
            }
            else if (filtreUygulanmislar3 != null)
            {
                FiltrelemeSonucGoster(filtreUygulanmislar3);
            }
            else if (filtreUygulanmislar2 != null)
            {
                FiltrelemeSonucGoster(filtreUygulanmislar2);
            }
            else
            {
                FiltrelemeSonucGoster(filtreUygulanmislar1);
            }
            filtreUygulanmislar1 = null;
            filtreUygulanmislar2 = null;
            filtreUygulanmislar3 = null;
            filtreUygulanmislar4 = null;
            filtreUygulanmislar5 = null;
            filtreUygulanmislar6 = null;
            filtreUygulanmislar7 = null;
        }

        private void BasvuranlariListele(TumBasvuranlar tumBasvuranlar, FiltreUygulanmislar filtreUygulanmamislar)
        {
            if (tumBasvuranlar != null)
            {
                if (tumBasvuranlar.ad != null)
                {
                    listBox1.Items.Add(tumBasvuranlar.ad);
                    filtreUygulanmamislar.ad = tumBasvuranlar.ad;
                    filtreUygulanmamislar.sag = new FiltreUygulanmislar();
                    BasvuranlariListele(tumBasvuranlar.sag, filtreUygulanmamislar.sag);
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
                tumBasvuranlar = new FiltreUygulanmislar();
                listBox1.Items.Clear();
                BasvuranlariListele(Başvurular.tumBasvuranlar, tumBasvuranlar);
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

        private void secilenfiltrelerListBox_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Right)
                {
                    secilenfiltrelerListBox.Items.RemoveAt(secilenfiltrelerListBox.SelectedIndex);
                }
            }
            catch (Exception)
            { }
        }

        private void ehliyetTxt_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Ehliyet tipi filtresini diğer filtrelerle birlikte kullanmayınız!", ehliyetTxt);
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
        public FiltreUygulanmislar sag;
    }
}
