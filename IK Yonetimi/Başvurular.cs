using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IK_Yonetimi
{
    public class Başvurular
    {
        public static Basvuran kok;
        public static TumBasvuranlar tumBasvuranlar;

        public static void PreorderBilgiCek(Basvuran dugum, string ad)
        {
            if (dugum != null)
            {
                if (!dugum.bosmu)
                {
                    if (dugum.ad == ad)
                    {
                        BasvuranBilgileri.basvuranNo = dugum.basvuranNo;
                        BasvuranBilgileri.ad = dugum.ad;
                        BasvuranBilgileri.adres = dugum.adres;
                        BasvuranBilgileri.tel = dugum.tel;
                        BasvuranBilgileri.mail = dugum.mail;
                        BasvuranBilgileri.dt = dugum.dt;
                        BasvuranBilgileri.ydil = dugum.ydil;
                        BasvuranBilgileri.ehliyet = dugum.ehliyet;
                        BasvuranBilgileri.isDeneyimi = dugum.isDeneyimi;
                        BasvuranBilgileri.egitimDurumu = dugum.egitimDurumu;
                    }
                    PreorderBilgiCek(dugum.sol, ad);
                    PreorderBilgiCek(dugum.sag, ad);
                }
            }
        }

        public static void PreorderBilgileriSil(int basvuranno, string ad)
        {
            PreorderBilgileriSil(kok, basvuranno, ad);
        }

        public static void PreorderBilgileriSil(Basvuran dugum, int basvuranno, string ad)
        {
            if (dugum != null)
            {
                if (!dugum.bosmu)
                {
                    if (dugum.ad == ad && dugum.basvuranNo == basvuranno)
                    {
                        dugum.bosmu = true;
                        dugum.ad = "";
                        dugum.adres = "";
                        dugum.tel = 0;
                        dugum.mail = "";
                        dugum.dt = DateTime.MinValue;
                        dugum.isDeneyimi.isyeriad = "";
                        dugum.isDeneyimi.sag.isyeriadres = "";
                        dugum.isDeneyimi.sag.sag.pozisyon = "";
                        dugum.isDeneyimi.sag.sag.sag.calismasuresi = 0;
                        dugum.egitimDurumu.okulAd = "";
                        dugum.egitimDurumu.sag.bolum = "";
                        dugum.egitimDurumu.sag.sag.baslangic = DateTime.MinValue;
                        dugum.egitimDurumu.sag.sag.bitis = DateTime.MinValue;
                        dugum.egitimDurumu.sag.sag.sag.notort = 0;
                    }
                    PreorderBilgileriSil(dugum.sol, basvuranno, ad);
                    PreorderBilgileriSil(dugum.sag, basvuranno, ad);
                }
            }

        }

        public static void PreorderGuncelle(int basvuranno, string ad, string adres, double tel, string mail,
            DateTime dt, string ydil, string ehliyet, string isyeriad, string isyeriadres,
            string pozisyon, int calismasuresi, string okulAd, string bolum,
            DateTime baslangic, DateTime bitis, double notort)
        {
            PreorderGuncelle(kok, basvuranno, ad, adres, tel, mail, dt, ydil, ehliyet, isyeriad, isyeriadres, pozisyon, calismasuresi, okulAd, bolum,
            baslangic, bitis, notort);
        }

        public static void PreorderGuncelle(Basvuran dugum, int basvuranno, string ad, string adres, double tel, string mail,
            DateTime dt, string ydil, string ehliyet, string isyeriad, string isyeriadres,
            string pozisyon, int calismasuresi, string okulAd, string bolum,
            DateTime baslangic, DateTime bitis, double notort)
        {
            if (dugum != null)
            {
                if (!dugum.bosmu)
                {
                    if (dugum.ad == ad && dugum.basvuranNo == basvuranno)
                    {
                        dugum.ad = BasvuranBilgileri.ad;
                        dugum.adres = adres;
                        dugum.tel = tel;
                        dugum.mail = mail;
                        dugum.dt = dt;
                        dugum.ydil = ydil;
                        dugum.ehliyet = ehliyet;
                        dugum.isDeneyimi.isyeriad = isyeriad;
                        dugum.isDeneyimi.sag.isyeriadres = isyeriadres;
                        dugum.isDeneyimi.sag.sag.pozisyon = pozisyon;
                        dugum.isDeneyimi.sag.sag.sag.calismasuresi = calismasuresi;
                        dugum.egitimDurumu.okulAd = okulAd;
                        dugum.egitimDurumu.sag.bolum = bolum;
                        dugum.egitimDurumu.sag.sag.baslangic = baslangic;
                        dugum.egitimDurumu.sag.sag.bitis = bitis;
                        dugum.egitimDurumu.sag.sag.sag.notort = notort;
                    }
                    PreorderGuncelle(dugum.sol, basvuranno, ad, adres, tel, mail, dt, ydil, ehliyet, isyeriad, isyeriadres, pozisyon, calismasuresi, okulAd, bolum, 
                        baslangic, bitis, notort);
                    PreorderGuncelle(dugum.sag, basvuranno, ad, adres, tel, mail, dt, ydil, ehliyet, isyeriad, isyeriadres, pozisyon, calismasuresi, okulAd, bolum,
                        baslangic, bitis, notort);
                }
            }
        }

        public static void PreorderGiris(string ad, string tel)
        {
            if (kok != null)
            {
                if (!kok.bosmu)
                {
                    PreorderGiris(kok, ad, tel);
                }
                
            }
        }

        public static void PreorderGiris(Basvuran dugum, string ad, string tel)
        {
            if (dugum != null)
            {
                if (!dugum.bosmu)
                {
                    if (dugum.ad == ad && dugum.tel.ToString() == tel)
                    {
                        Giris.girisYap = true;
                    }
                    PreorderGiris(dugum.sol, ad, tel);
                    PreorderGiris(dugum.sag, ad, tel);
                }
            }
            
        }
        
        public static void PreorderEkle(int basvuranNo, string ad, string adres, double tel, string mail,
            DateTime dt, string ydil, string ehliyet, string isyeriad, string isyeriadres,
            string pozisyon, int calismasuresi, string okulAd, string bolum,
            DateTime baslangic, DateTime bitis, double notort)
        {
            /*En tepedeki kök boşsa direkt başvuran bilgisini ekle. Kök doluysa yeni başvurana belirlenen başvuranNo kökten büyük-küçük ise ona göre gezin, boş bulunan düğüme
             yerleştir.
             */
            if (Başvurular.kok == null)
            {
                //Gelen bilgilerden direkt olarak kökü doldur.
                Başvurular.kok = new Basvuran(basvuranNo, ad, adres, tel, mail, dt, ydil, ehliyet, isyeriad, isyeriadres, pozisyon, calismasuresi, okulAd, bolum, baslangic, bitis, notort);
                tumBasvuranlar = new TumBasvuranlar();
                MessageBox.Show(kok.basvuranNo + " - " + kok.ad);
            }
            else
            {
                Basvuran eklenecek = new Basvuran(basvuranNo, ad, adres, tel, mail, dt, ydil, ehliyet, isyeriad, isyeriadres, pozisyon, calismasuresi, okulAd, bolum, baslangic, bitis, notort);
                PreorderEkle(kok, eklenecek, kok, false);
            }
        }

        public static void PreorderEkle(Basvuran yKok, Basvuran eklenecek, Basvuran ebeveyn, bool solsag) //false sol, true sag
        {
            if (yKok != null)
            {
                if (!yKok.bosmu)
                {
                    if (eklenecek.basvuranNo <= yKok.basvuranNo)
                    {

                        PreorderEkle(yKok.sol, eklenecek, yKok, false);
                    }
                    else
                    {
                        PreorderEkle(yKok.sag, eklenecek, yKok, true);
                    }
                }
                else
                {
                    try
                    {
                        if (yKok.sol != null || yKok.sag != null)
                        {
                            eklenecek.sol = yKok.sol;
                            eklenecek.sag = yKok.sag;
                        }

                    }
                    catch (Exception)
                    { }
                    eklenecek.basvuranNo = yKok.basvuranNo; //Boşaltılmış düğümde hali hazırda basvuranno bulunduğu için onun değişmediğinden emin oluyoruz
                    yKok.ad = eklenecek.ad;
                    yKok.adres = eklenecek.adres;
                    yKok.tel = eklenecek.tel;
                    yKok.mail = eklenecek.mail;
                    yKok.dt = eklenecek.dt;
                    yKok.ydil = eklenecek.ydil;
                    yKok.ehliyet = eklenecek.ehliyet;
                    yKok.isDeneyimi = eklenecek.isDeneyimi;
                    yKok.egitimDurumu = eklenecek.egitimDurumu;
                    yKok.bosmu = false;
                    /*yKok = eklenecek;
                    if (solsag)
                    {
                        ebeveyn.sag = eklenecek;
                    }
                    else
                    {
                        ebeveyn.sol = eklenecek;
                    }*/
                    MessageBox.Show(yKok.basvuranNo + " - " + yKok.ad);
                }
            }
            else
            {
                try
                {
                    if (yKok != null)
                    {
                        if (yKok.sol != null || yKok.sag != null)
                        {
                            eklenecek.sol = yKok.sol;
                            eklenecek.sag = yKok.sag;
                        }
                    }
                }
                catch (Exception)
                { }
                yKok = eklenecek;
                if (solsag)
                {
                    ebeveyn.sag = eklenecek;
                }
                else
                {
                    ebeveyn.sol = eklenecek;
                }
                MessageBox.Show(yKok.basvuranNo + " - " + yKok.ad);
            }
            
        }
    }

    public class Basvuran
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
        public Basvuran sag;
        public Basvuran sol;


        public Basvuran(int basvuranNo, string ad, string adres, double tel, string mail, 
            DateTime dt, string ydil, string ehliyet, string isyeriad, string isyeriadres, 
            string pozisyon, int calismasuresi, string okulAd, string bolum, 
            DateTime baslangic, DateTime bitis, double notort)
        {
            if (bosmu)
            {
                //silme islemi olayını burda halledicez. (bos hücreler)
                this.basvuranNo = basvuranNo;
                this.ad = ad;
                this.adres = adres;
                this.tel = tel;
                this.mail = mail;
                this.dt = dt;
                this.ydil = ydil;
                this.ehliyet = ehliyet;
                this.isDeneyimi = new IsDeneyimi(isyeriad, isyeriadres, pozisyon, calismasuresi);
                this.egitimDurumu = new EgitimDurumu(okulAd,bolum,baslangic,bitis,notort);
                this.bosmu = false;
            }
        }

    }

    // isdeneyimi
    public class IsDeneyimi
    {
        bool bosmu = true;
        public string isyeriad;
        public IsDeneyimiAdres sag;

        public IsDeneyimi(string isyeriad, string isyeriadres, string pozisyon, int calismasuresi)
        {
            if (bosmu)
            {
                this.isyeriad = isyeriad;
                sag = new IsDeneyimiAdres(isyeriadres, pozisyon, calismasuresi);
                this.bosmu = false;
            }
        }
    }

    public class IsDeneyimiAdres
    {
        public string isyeriadres;
        public IsDeneyimiPozisyon sag;

        public IsDeneyimiAdres(string isyeriadres, string pozisyon, int calismasuresi)
        {
            this.isyeriadres = isyeriadres;
            sag = new IsDeneyimiPozisyon(pozisyon, calismasuresi);
        }
    }
    public class IsDeneyimiPozisyon
    {
        public string pozisyon;
        public IsDeneyimiCalismaSuresi sag;

        public IsDeneyimiPozisyon(string pozisyon, int calismasuresi)
        {
            this.pozisyon = pozisyon;
            sag = new IsDeneyimiCalismaSuresi(calismasuresi);
        }
    }
    public class IsDeneyimiCalismaSuresi
    {
        public int calismasuresi;

        public IsDeneyimiCalismaSuresi(int calismasuresi)
        {
            this.calismasuresi = calismasuresi;
        }
    }

    // eğitim

    public class EgitimDurumu
    {
        bool bosmu = true;
        public string okulAd;
        public EgitimDurumuBolumu sag;

        public EgitimDurumu(string okulAd, string bolum,
            DateTime baslangic, DateTime bitis, double notort)
        {
            if (bosmu)
            {
                this.okulAd = okulAd;
                sag = new EgitimDurumuBolumu(bolum, baslangic, bitis, notort);
                this.bosmu = false;
            }
        }
    }

    public class EgitimDurumuBolumu
    {
        public string bolum;
        public EgitimDurumuEgitimSuresi sag;

        public EgitimDurumuBolumu(string bolum,
            DateTime baslangic, DateTime bitis, double notort)
        {
            this.bolum = bolum;
            sag = new EgitimDurumuEgitimSuresi(baslangic, bitis, notort);
        }
    }

    public class EgitimDurumuEgitimSuresi
    {
        public DateTime baslangic;
        public DateTime bitis;
        public EgitimDurumuNotOrt sag;

        public EgitimDurumuEgitimSuresi(DateTime baslangic, DateTime bitis, double notort)
        {
            this.baslangic = baslangic;
            this.bitis = bitis;
            sag = new EgitimDurumuNotOrt(notort);
        }
    }
    public class EgitimDurumuNotOrt
    {
        public double notort;
        public EgitimDurumuNotOrt(double notort)
        {
            this.notort = notort;
        }
    }

    public class BasvuranAdlari
    {
        public string ad;
        public BasvuranAdlari sag;

        public BasvuranAdlari(string ad)
        {
            this.ad = ad;
        }
    }

}
