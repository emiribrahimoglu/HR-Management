using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IK_Yonetimi
{
    class Başvurular
    {
        
    }

    public class Basvuran
    {
        bool bosmu = true;
        int basvuranNo;
        string ad;
        string adres;
        double tel;
        string mail;
        DateTime dt;
        string ydil;
        string ehliyet;
        public IsDeneyimi isDeneyimi;
        public EgitimDurumu egitimDurumu;
        public Basvuran sag;
        public Basvuran sol;


        public Basvuran(string ad, string adres, double tel, string mail, 
            DateTime dt, string ydil, string ehliyet, string isyeriad, string isyeriadres, 
            string pozisyon, int calismasuresi, string okulAd, string bolum, 
            DateTime baslangic, DateTime bitis, double notort)
        {
            if (bosmu)
            {
                //silme islemi olayını burda halledicez. (bos hücreler)
                Random rd = new Random();
                this.basvuranNo = rd.Next(10000,99999);
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
}
