using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace IK_Yonetimi
{
    public class Başvurular
    {
        public static Basvuran kok;
        
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
            }
            else
            {
                Basvuran eklenecek = new Basvuran(basvuranNo, ad, adres, tel, mail, dt, ydil, ehliyet, isyeriad, isyeriadres, pozisyon, calismasuresi, okulAd, bolum, baslangic, bitis, notort);
                PreorderEkle(Başvurular.kok, eklenecek);
            }
        }

        public static void PreorderEkle(Basvuran yKok, Basvuran eklenecek)
        {
            if (!yKok.bosmu)
            {
                if (eklenecek.basvuranNo <= yKok.basvuranNo)
                {
                    PreorderEkle(yKok.sol, eklenecek);
                }
                else
                {
                    PreorderEkle(yKok.sag, eklenecek);
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
                yKok = eklenecek;
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
        string isyeriad;
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
        string isyeriadres;
        public IsDeneyimiPozisyon sag;

        public IsDeneyimiAdres(string isyeriadres, string pozisyon, int calismasuresi)
        {
            this.isyeriadres = isyeriadres;
            sag = new IsDeneyimiPozisyon(pozisyon, calismasuresi);
        }
    }
    public class IsDeneyimiPozisyon
    {
        string pozisyon;
        public IsDeneyimiCalismaSuresi sag;

        public IsDeneyimiPozisyon(string pozisyon, int calismasuresi)
        {
            this.pozisyon = pozisyon;
            sag = new IsDeneyimiCalismaSuresi(calismasuresi);
        }
    }
    public class IsDeneyimiCalismaSuresi
    {
        int calismasuresi;

        public IsDeneyimiCalismaSuresi(int calismasuresi)
        {
            this.calismasuresi = calismasuresi;
        }
    }

    // eğitim

    public class EgitimDurumu
    {
        bool bosmu = true;
        string okulAd;
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
        string bolum;
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
        DateTime baslangic;
        DateTime bitis;
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
        double notort;
        public EgitimDurumuNotOrt(double notort)
        {
            this.notort = notort;
        }
    }

    public class EklenecekBasvuran
    {
        
    }
}
