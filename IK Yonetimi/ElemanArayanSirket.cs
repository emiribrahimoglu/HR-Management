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
         * Her filtrede if-else if yapılarıyla üstteki nesnelerin null durumuna bakarak filtre uygulanmışların tekrar filtreye tabii tutulması sağlanıyor.
         * Bunun için ilk uygulanan filtrede tüm başvuranların adının bulunduğu bağlı listedeki isimlere filtre uygulandı sonraki filtrelerde bir önceki
         * filtrenin kullandığı bağlı listedeki isimler üzerinde filtreleme işlemi uygulanıyor. Son kullanılan filtreleme işleminde son bağlı listeye son
         * isimler giriliyor. Sonrasında o isimler listbox'da gösteriliyor.
         * */

        // Aşağıda ilk sıradaki uygulanacak filtre olduğundan ilkten başka yerde uygulanması imkansız olduğundan bunun diğer varyasyonu yok.
        private void EnAzLisansFiltre(TumBasvuranlar tumBasvuranlar, FiltreUygulanmislar filtreUygulanmislar) //gelen filtreuygulanmislar1
        {
            if (tumBasvuranlar != null)
            {
                if (tumBasvuranlar.ad != null)
                {
                    if (tumBasvuranlar.egitimDurumu.enAzLisans == true)
                    {
                        filtreUygulanmislar.ad = tumBasvuranlar.ad;
                        filtreUygulanmislar.sag = new FiltreUygulanmislar(); // null hatası almamak için yapılan atama. Null iken ad'ı eşitleyemiyoruz.
                        EnAzLisansFiltre(tumBasvuranlar.sag, filtreUygulanmislar.sag);
                    }
                    else
                    {
                        // Filtrelenenlerin eklendiği bu yapıya ekleme yapılmadan sonraki başvurana geçileceğinden sağ tarafa geçmiyoruz.
                        EnAzLisansFiltre(tumBasvuranlar.sag, filtreUygulanmislar);
                    }
                }
            }
        }

        // İlk uygulanan filtreyse kendisi, bu fonksiyon çalışıyor. Üsttekinin bir kopyası diyebiliriz.
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

        // Kendisi ilk uygulanan filtre değilse kendisinden önceki filtre sonuçlarındaki isimler arasında filtre yapılacağı için bu fonksiyon çalışıyor.
        private void IngilizceBilenlerFiltre(TumBasvuranlar tumBasvuranlar, FiltreUygulanmislar filtreUygulanmamislar, FiltreUygulanmislar OncekiFiltreUygulanmislar)
        {
            if (tumBasvuranlar != null)
            {
                if (tumBasvuranlar.ad != null)
                {
                    if (tumBasvuranlar.ad == OncekiFiltreUygulanmislar.ad && tumBasvuranlar.ydil.ToLower().Contains("en"))
                    {
                        OncekiFiltreUygulanmislar.ad = tumBasvuranlar.ad;
                        filtreUygulanmamislar.sag = new FiltreUygulanmislar(); //null değişken üzerinde eşitleme ataması yapamazsın hatasını önlemek için.
                        IngilizceBilenlerFiltre(tumBasvuranlar.sag, filtreUygulanmamislar.sag, OncekiFiltreUygulanmislar.sag);
                    }
                    else if (tumBasvuranlar.ad != OncekiFiltreUygulanmislar.ad) // filtre koşulunu sağlamadığı için değil de isim farkından ise...
                    {
                        IngilizceBilenlerFiltre(tumBasvuranlar.sag, filtreUygulanmamislar, OncekiFiltreUygulanmislar); // başvuranlarda gezinmeye devam, diğerlerinde gezinme yok.
                    }
                    else // filtre koşulunu sağlamadı adlar aynı, o halde önceki filtre sonucu ve tüm başvuranlarda gezinme devam, diğerinde değil.
                    {
                        IngilizceBilenlerFiltre(tumBasvuranlar.sag, filtreUygulanmamislar, OncekiFiltreUygulanmislar.sag);
                    }
                }
            }
        }

        // Kendisi ilk uygulanan filtre ise çalışan fonksiyon.
        private void BirdenFazlaDilBilenler(TumBasvuranlar tumBasvuranlar, FiltreUygulanmislar filtreUygulanmislar) //gelen filtreuygulanmislar1
        {
            if (tumBasvuranlar != null)
            {
                if (tumBasvuranlar.ad != null)
                {
                    if (tumBasvuranlar.ydil.Length > 3)
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

        // Kendisi ilk uygulanacak filtre değilse çalışacak fonksiyon.
        private void BirdenFazlaDilBilenler(TumBasvuranlar tumBasvuranlar, FiltreUygulanmislar filtreUygulanmamislar, FiltreUygulanmislar OncekiFiltreUygulanmislar)
        {
            if (tumBasvuranlar != null)
            {
                if (tumBasvuranlar.ad != null)
                {
                    if (tumBasvuranlar.ad == OncekiFiltreUygulanmislar.ad && tumBasvuranlar.ydil.Length > 3)
                    {
                        filtreUygulanmamislar.ad = tumBasvuranlar.ad;
                        filtreUygulanmamislar.sag = new FiltreUygulanmislar();
                        BirdenFazlaDilBilenler(tumBasvuranlar.sag, filtreUygulanmamislar.sag, OncekiFiltreUygulanmislar.sag);
                    }
                    else if (tumBasvuranlar.ad != OncekiFiltreUygulanmislar.ad) // adlar farklıysa adlar aynı olana kadar gezin
                    {
                        BirdenFazlaDilBilenler(tumBasvuranlar.sag, filtreUygulanmamislar, OncekiFiltreUygulanmislar);
                    }
                    else // Gezinildi, adlar aynı ama koşul sağlanmadı o zaman hem önceki filtre sonuçları hem de tüm başvuranlarda sonraki şahısa devam.
                    {
                        BirdenFazlaDilBilenler(tumBasvuranlar.sag, filtreUygulanmamislar, OncekiFiltreUygulanmislar.sag);
                    }
                }
            }
        }

        // Kendisi ilk uygulanan filtre ise çalışan fonksiyon.
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

        // Kendisi ilk uygulanan filtre değilse çalışan fonksiyon.
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
                    else if(tumBasvuranlar.ad != OncekiFiltreUygulanmislar.ad) // adlar farklıysa aynı olana kadar gezin
                    {
                        DeneyimsizlerFiltre(tumBasvuranlar.sag, filtreUygulanmamislar, OncekiFiltreUygulanmislar);
                    }
                    else // Gezinildi, adlar aynı ama koşul sağlanmadı o zaman hem önceki filtre sonuçları hem de tüm başvuranlarda sonraki şahısa devam.
                    {
                        DeneyimsizlerFiltre(tumBasvuranlar.sag, filtreUygulanmamislar, OncekiFiltreUygulanmislar.sag);
                    }
                }
            }
        }

        // Kendisi ilk uygulanan filtre ise çalışan fonksiyon.
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

        // Kendisi ilk uygulanan filtre değilse çalışan fonksiyon.
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
                    else if (tumBasvuranlar.ad != oncekiFiltreUygulanmislar.ad) // adlar farklıysa gezintiye devam
                    {
                        IsDeneyimiFiltre(tumBasvuranlar.sag, filtreUygulanmamislar, oncekiFiltreUygulanmislar);
                    }
                    else // Gezinti sonrası aynı ad ama koşul sağlanmıyorsa sonraki başvuranlarla kontrol yapılıyor
                    {
                        IsDeneyimiFiltre(tumBasvuranlar.sag, filtreUygulanmamislar, oncekiFiltreUygulanmislar.sag);
                    }
                }
            }
        }

        // Kendisi ilk uygulanan filtre ise çalışan fonksiyon.
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

        // Kendisi ilk uygulanan filtre değilse çalışan fonksiyon.
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
                    else if (tumBasvuranlar.ad != oncekiFiltreUygulanmislar.ad) // Adlar aynı değil, tüm başvuranlarda gezintiye devam
                    {
                        BelirliYasAltiFiltre(tumBasvuranlar.sag, filtreUygulanmamislar, oncekiFiltreUygulanmislar);
                    }
                    else // Adlar aynı koşul sağlanmadı, o zaman sıradaki başvuranlara geçiliyor.
                    {
                        BelirliYasAltiFiltre(tumBasvuranlar.sag, filtreUygulanmamislar, oncekiFiltreUygulanmislar.sag);
                    }
                }
            }
        }

        /*private void EhliyetTipiFiltre(TumBasvuranlar tumBasvuranlar, FiltreUygulanmislar filtreUygulanmamislar)
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
        }*/

        // Şu an sadece Ehliyet filtresinin yapıldığı fonksiyon.
        private void FiltrelemeIslemi(TumBasvuranlar tumBasvuranlar, int filtreNum)
        {
            if (tumBasvuranlar != null)
            {
                if (tumBasvuranlar.ad != null)
                {
                    /*if (filtreNum == 1 && tumBasvuranlar.egitimDurumu.enAzLisans == true)
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
                    }*/
                    if (filtreNum == 7)
                    {
                        if (tumBasvuranlar.ehliyet == ehliyetTxt.Text)
                        {
                            listBox1.Items.Add(tumBasvuranlar.ad);
                        }
                    }
                    FiltrelemeIslemi(tumBasvuranlar.sag, filtreNum);
                }
            }
        }

        // Bütün null kontrollerinin nedeni kendisinden önce yapılan filtreleme var mı diye bakıp onun sonuçları üzerine tekrar filtreleme yapılıyor olması
        private void Filtrele()
        {
            if (secilenfiltrelerListBox.Items.Contains("En az lisans mezunu olanlar"))
            {
                filtreUygulanmislar1 = new FiltreUygulanmislar();
                EnAzLisansFiltre(Başvurular.tumBasvuranlar, filtreUygulanmislar1);
            }
            if (secilenfiltrelerListBox.Items.Contains("İngilizce bilenler"))
            {
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
            }
            if (secilenfiltrelerListBox.Items.Contains("Birden fazla yabancı dil bilenler"))
            {
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
            }
            if (secilenfiltrelerListBox.Items.Contains("Deneyimsizler"))
            {
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
            }
            if (mindeneyimTxt.Text != "")
            {
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
            }
            if (belirliyasaltiTxt.Text != "")
            {
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
            }
            if (ehliyetTxt.Text != "")
            {
                listBox1.Items.Clear();
                FiltrelemeIslemi(Başvurular.tumBasvuranlar, 7); //Üstteki fonksiyonda ehliyet filtresinin numarası 7
                goto Filtresonubypass; // Ehliyet filtresi sadece tek yapılabiliyor, önceki filtreleme sonuçlarını kontrol etmeye gerek yok.
            }
            HangiFiltrelenmisDegiskeni();
            Filtresonubypass:;

        }

        // Buraya gelen filtre sonuçlarının depolandığı sınıf yapısındaki isimler listeye yazılıyor.
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

        // En son yapılan filtre hangisiyse, oradaki isimler istenilen sonuçlar olacağı için ona göre kontrol ediliyor.
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
            // Bellekte çok yer kaplamalarına gerek kalmadı, filtre işlemleri sonuçlandı. Null'a çevriliyor ki diğer filtrelemelere hazır olsun.
            filtreUygulanmislar1 = null;
            filtreUygulanmislar2 = null;
            filtreUygulanmislar3 = null;
            filtreUygulanmislar4 = null;
            filtreUygulanmislar5 = null;
            filtreUygulanmislar6 = null;
            filtreUygulanmislar7 = null;
        }

        // Bilgileri geçerli olan (silinmiş olmayan) herkesi listelemeyi sağlayan fonksiyon.
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

        // Bilgileri geçerli olan herkes arasında aranan isim var mı yok mu arayan fonksiyon.
        private void IsimeGoreListele(TumBasvuranlar tumBasvuranlar)
        {
            if (textBox1.Text != "" && listBox1.Items.Count != 0)
            {
                if (listBox1.Items.Contains(textBox1.Text))
                {
                    listBox1.SelectedItem = textBox1.Text;
                }
                else
                {
                    MessageBox.Show("Aranılan isim bulunamadı");
                }
            }
        }

        private void HerkesiListele()
        {
            if (Başvurular.kok != null)
            {
                TumBasvuranlar.BasvuranlariDepola(Başvurular.kok, Başvurular.tumBasvuranlar);
                listBox1.Items.Clear();
                BasvuranlariListele(Başvurular.tumBasvuranlar);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
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

        // Başvuranların bilgileri görüntülenmek istendiği zaman bilgiler ilgili yerlere doldurulup gösteriliyor.
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

    // Bilgileri silinmemiş olan, bilgileri bulunan tüm başvuranların bilgilerinin kolay erişim için tutulduğu yapı.
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

    // Filtre sonuçlarında filtreyi sağlayanların adlarının tutulduğu yapı.
    public class FiltreUygulanmislar
    {
        public string ad;
        public FiltreUygulanmislar sag;
    }
}
