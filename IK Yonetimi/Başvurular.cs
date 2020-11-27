using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IK_Yonetimi
{
    public class Başvurular //Başvuru yapan kişilerle ilgili tüm işlemlerin yapıldığı sınıf yapısı.
    {
        public static Basvuran kok; //Kök sabittir ve her yerden rahatça ulaşılmalıdır.
        public static TumBasvuranlar tumBasvuranlar; // İçi boşaltılmış düğümler dışında tüm geçerli düğümlerin ve içindeki bilgilerin tutulduğu bağlı liste.
        public static StreamReader sr; //Dosyadan veri akışı

        public static void PreorderAgaciDosyadanOku()
        {
            int basvuranNo;
            bool bosmu;
            string ad;
            string adres;
            double tel;
            string mail;
            DateTime dt;
            string ydil;
            string ehliyet;
            string isyeriad;
            string isyeriadres;
            string pozisyon;
            int calismasuresi;
            string okulAd;
            string bolum;
            DateTime baslangic;
            DateTime bitis;
            double notort;
            bool enAzLisans;
            if (Başvurular.kok == null)
            {
                basvuranNo = Convert.ToInt32(sr.ReadLine());
                bosmu = Convert.ToBoolean(sr.ReadLine());
                ad = sr.ReadLine();
                adres = sr.ReadLine();
                tel = Convert.ToDouble(sr.ReadLine());
                mail = sr.ReadLine();
                dt = Convert.ToDateTime(sr.ReadLine());
                ydil = sr.ReadLine();
                ehliyet = sr.ReadLine();
                isyeriad = sr.ReadLine();
                isyeriadres = sr.ReadLine();
                pozisyon = sr.ReadLine();
                calismasuresi = Convert.ToInt32(sr.ReadLine());
                okulAd = sr.ReadLine();
                bolum = sr.ReadLine();
                baslangic = Convert.ToDateTime(sr.ReadLine());
                bitis = Convert.ToDateTime(sr.ReadLine());
                notort = Convert.ToDouble(sr.ReadLine());
                enAzLisans = Convert.ToBoolean(sr.ReadLine());

                //Gelen bilgilerden direkt olarak kökü doldur.
                Başvurular.kok = new Basvuran(basvuranNo, ad, adres, tel, mail, dt, 
                    ydil, ehliyet, isyeriad, isyeriadres, pozisyon, calismasuresi, 
                    okulAd, bolum, baslangic, bitis, notort, enAzLisans);
                tumBasvuranlar = new TumBasvuranlar();
                MessageBox.Show(kok.basvuranNo + " - " + kok.ad);
            }
            else
            {
                basvuranNo = Convert.ToInt32(sr.ReadLine());
                bosmu = Convert.ToBoolean(sr.ReadLine());
                ad = sr.ReadLine();
                adres = sr.ReadLine();
                tel = Convert.ToDouble(sr.ReadLine());
                mail = sr.ReadLine();
                dt = Convert.ToDateTime(sr.ReadLine());
                ydil = sr.ReadLine();
                ehliyet = sr.ReadLine();
                isyeriad = sr.ReadLine();
                isyeriadres = sr.ReadLine();
                pozisyon = sr.ReadLine();
                calismasuresi = Convert.ToInt32(sr.ReadLine());
                okulAd = sr.ReadLine();
                bolum = sr.ReadLine();
                baslangic = Convert.ToDateTime(sr.ReadLine());
                bitis = Convert.ToDateTime(sr.ReadLine());
                notort = Convert.ToDouble(sr.ReadLine());
                enAzLisans = Convert.ToBoolean(sr.ReadLine());

                //Kök boş değil dolayısıyla gezinti işlemi başlanacak ve uygun olan boş dala yeni düğüm eklenecek.
                if (basvuranNo != 0)
                {
                    Basvuran eklenecek = new Basvuran(basvuranNo, ad, adres, tel, mail, dt, ydil, ehliyet, isyeriad, isyeriadres, pozisyon, calismasuresi, okulAd, bolum, baslangic, bitis, notort, enAzLisans);
                    PreorderEkle(kok, eklenecek, kok, false);
                }
                
            }
        }

        public static void IstenilenBasvuranlariDosyayaYaz(TumBasvuranlar dugum, string ad, string dosyaYolu)
        {
            if (dugum != null)
            {
                if (dugum.ad == ad)
                {
                    using (StreamWriter sw = File.AppendText(dosyaYolu))
                    {
                        sw.WriteLine("Başvuran Numarası: "+ dugum.basvuranNo.ToString());
                        //sw.WriteLine("Bilgilerin silinip silinmediği: "+dugum.bosmu.ToString());
                        sw.WriteLine("Başvuranın Adı: "+dugum.ad);
                        sw.WriteLine("Başvuranın Adresi: "+dugum.adres);
                        sw.WriteLine("Başvuranın Telefon Numarası: "+dugum.tel.ToString());
                        sw.WriteLine("Başvuranın Mail Adresi: "+dugum.mail.ToString());
                        sw.WriteLine("Başvuranın Doğum Tarihi: "+dugum.dt.Date.ToShortDateString());
                        sw.WriteLine("Başvuranın Bildiği Yabancı Diller: "+dugum.ydil);
                        sw.WriteLine("Başvuranın Ehliyet Tipi: "+dugum.ehliyet);
                        sw.WriteLine("Başvuranın Çalıştığı İşyerinin Adı: "+dugum.isDeneyimi.isyeriad);
                        sw.WriteLine("Başvuranın Çalıştığı İşyerinin Adresi: "+dugum.isDeneyimi.sag.isyeriadres);
                        sw.WriteLine("Başvuranın Çalıştığı İşyerindeki Pozisyonu: "+dugum.isDeneyimi.sag.sag.pozisyon);
                        sw.WriteLine("Başvuranın Çalıştığı İşyerindeki Çalışma Süresi: "+dugum.isDeneyimi.sag.sag.sag.calismasuresi.ToString() + " Ay");
                        sw.WriteLine("Başvuranın Okuduğu Okulun Adı: "+dugum.egitimDurumu.okulAd);
                        sw.WriteLine("Başvuranın Okuduğu Bölüm: "+dugum.egitimDurumu.sag.bolum);
                        sw.WriteLine("Başvuranın Okula Başlama Tarihi: "+dugum.egitimDurumu.sag.sag.baslangic.Date.ToShortDateString());
                        sw.WriteLine("Başvuranın Okulu Bitirme Tarihi: "+dugum.egitimDurumu.sag.sag.bitis.Date.ToShortDateString());
                        sw.WriteLine("Başvuranın Okulu Bitirdiği Not Ortalaması: "+dugum.egitimDurumu.sag.sag.sag.notort.ToString());
                        if (dugum.egitimDurumu.enAzLisans)
                        {
                            sw.WriteLine("Başvuranın En Az Lisans Mezunu Mu? --> " + "Evet");
                        }
                        else
                        {
                            sw.WriteLine("Başvuranın En Az Lisans Mezunu Mu? --> " + "Hayır");
                        }
                        //sw.WriteLine("Başvuranın En Az Lisans Mezunu Mu? --> "+dugum.egitimDurumu.enAzLisans.ToString());
                        sw.WriteLine("///////////////////////////////////");
                    }
                }
                else
                {
                    //IstenilenBasvuranlariDosyayaYaz(dugum.sol, ad, dosyaYolu);
                    IstenilenBasvuranlariDosyayaYaz(dugum.sag, ad, dosyaYolu);
                }
            }
        }
        public static void PreorderAgaciDosyayaYaz(Basvuran dugum)
        {
            if (dugum != null)
            {
                using (StreamWriter sw = File.AppendText(Form1.dosyaYolu))
                {
                    sw.WriteLine(dugum.basvuranNo.ToString());
                    sw.WriteLine(dugum.bosmu.ToString());
                    sw.WriteLine(dugum.ad);
                    sw.WriteLine(dugum.adres);
                    sw.WriteLine(dugum.tel.ToString());
                    sw.WriteLine(dugum.mail);
                    sw.WriteLine(dugum.dt.ToString());
                    sw.WriteLine(dugum.ydil);
                    sw.WriteLine(dugum.ehliyet);
                    sw.WriteLine(dugum.isDeneyimi.isyeriad);
                    sw.WriteLine(dugum.isDeneyimi.sag.isyeriadres);
                    sw.WriteLine(dugum.isDeneyimi.sag.sag.pozisyon);
                    sw.WriteLine(dugum.isDeneyimi.sag.sag.sag.calismasuresi.ToString());
                    sw.WriteLine(dugum.egitimDurumu.okulAd);
                    sw.WriteLine(dugum.egitimDurumu.sag.bolum);
                    sw.WriteLine(dugum.egitimDurumu.sag.sag.baslangic.ToString());
                    sw.WriteLine(dugum.egitimDurumu.sag.sag.bitis.ToString());
                    sw.WriteLine(dugum.egitimDurumu.sag.sag.sag.notort.ToString());
                    sw.WriteLine(dugum.egitimDurumu.enAzLisans.ToString());
                    sw.WriteLine("///////////////////////////////////");
                }
                PreorderAgaciDosyayaYaz(dugum.sol);
                PreorderAgaciDosyayaYaz(dugum.sag);
            }
        }

        // Başvuran kişinin bilgilerini görebilmesi için başka sınıftaki değişkenlere atama yapıldığı yer. 
        // Bilgilerini görmek istediğinde buradaki fonksiyon çalışıyor.
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
                else
                {
                    PreorderBilgiCek(dugum.sol, ad);
                    PreorderBilgiCek(dugum.sag, ad);
                }
            }
        }

        public static void PreorderBilgileriSil(int basvuranno, string ad) //Asıl fonksiyon için basamak görevi
        {
            PreorderBilgileriSil(kok, basvuranno, ad);
        }

        // Başvuran bilgilerini silmek istediğinde bilgilerinin bulunduğu düğümü silmek zor olacağından onun yerine bilgilerini boşaltıyoruz, pratikte aynı iş.
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
                        dugum.ydil = "";
                        dugum.ehliyet = "";
                        dugum.isDeneyimi.isyeriad = "";
                        dugum.isDeneyimi.sag.isyeriadres = "";
                        dugum.isDeneyimi.sag.sag.pozisyon = "";
                        dugum.isDeneyimi.sag.sag.sag.calismasuresi = 0;
                        dugum.egitimDurumu.okulAd = "";
                        dugum.egitimDurumu.enAzLisans = false;
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

        // Alttaki asıl güncelleme fonksiyonu için bir basamak görevi görüyor.
        public static void PreorderGuncelle(int basvuranno, string ad, string adres, double tel, string mail,
            DateTime dt, string ydil, string ehliyet, string isyeriad, string isyeriadres,
            string pozisyon, int calismasuresi, string okulAd, string bolum,
            DateTime baslangic, DateTime bitis, double notort, bool enAzLisans)
        {
            PreorderGuncelle(kok, basvuranno, ad, adres, tel, mail, dt, ydil, ehliyet, isyeriad, isyeriadres, pozisyon, calismasuresi, okulAd, bolum,
            baslangic, bitis, notort, enAzLisans);
        }

        // Başvuran kişi bilgilerini güncellemek istediği zaman öncelikle gezinerek ağaçtaki yeri bulunuyor, sonrasında bilgileri güncelleniyor.
        public static void PreorderGuncelle(Basvuran dugum, int basvuranno, string ad, string adres, double tel, string mail,
            DateTime dt, string ydil, string ehliyet, string isyeriad, string isyeriadres,
            string pozisyon, int calismasuresi, string okulAd, string bolum,
            DateTime baslangic, DateTime bitis, double notort, bool enAzLisans)
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
                        dugum.egitimDurumu.enAzLisans = enAzLisans;
                        dugum.egitimDurumu.sag.bolum = bolum;
                        dugum.egitimDurumu.sag.sag.baslangic = baslangic;
                        dugum.egitimDurumu.sag.sag.bitis = bitis;
                        dugum.egitimDurumu.sag.sag.sag.notort = notort;
                    }
                    PreorderGuncelle(dugum.sol, basvuranno, ad, adres, tel, mail, dt, ydil, ehliyet, isyeriad, isyeriadres, pozisyon, calismasuresi, okulAd, bolum, 
                        baslangic, bitis, notort, enAzLisans);
                    PreorderGuncelle(dugum.sag, basvuranno, ad, adres, tel, mail, dt, ydil, ehliyet, isyeriad, isyeriadres, pozisyon, calismasuresi, okulAd, bolum,
                        baslangic, bitis, notort, enAzLisans);
                }
            }
        }

        public static void PreorderGiris(string ad, string tel) // Bir alttaki fonksiyon için buradan oraya sekme görevi görüyor
        {
            if (kok != null)
            {
                if (!kok.bosmu)
                {
                    PreorderGiris(kok, ad, tel);
                }
                
            }
        }

        public static void PreorderGiris(Basvuran dugum, string ad, string tel) // Girilen giriş bilgileri doğru mu diye PreOrder gezintisiyle kontrol ediliyor
        {
            if (dugum != null) // Gezintide denk geline düğüm tamamen boş mu değil mi (Üzerinde kontrol yapabilir miyiz?)
            {
                if (!dugum.bosmu) // İçindeki bilgiler bir kullanıcıya aitti de kullanıcının isteği üzerine silinmiş mi?
                {
                    //girilen bilgiler doğruysa giriş bu komut çağrıldığı yere geri döndüğünde true yaptığı bool sayesinde giriş işlemi yapılacak
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
            DateTime baslangic, DateTime bitis, double notort, bool enAzLisans)
        {
            /*En tepedeki kök boşsa direkt başvuran bilgisini ekle. Kök doluysa yeni başvurana belirlenen başvuranNo kökten büyük-küçük ise ona göre gezin, boş bulunan düğüme
             yerleştir.
             */
            if (Başvurular.kok == null)
            {
                //Gelen bilgilerden direkt olarak kökü doldur.
                Başvurular.kok = new Basvuran(basvuranNo, ad, adres, tel, mail, dt, ydil, ehliyet, isyeriad, isyeriadres, pozisyon, calismasuresi, okulAd, bolum, baslangic, bitis, notort, enAzLisans);
                tumBasvuranlar = new TumBasvuranlar();
                MessageBox.Show(kok.basvuranNo + " - " + kok.ad);
            }
            else
            {
                // Kök boş değil dolayısıyla gezinti işlemi başlanacak ve uygun olan boş dala yeni düğüm eklenecek.
                Basvuran eklenecek = new Basvuran(basvuranNo, ad, adres, tel, mail, dt, ydil, ehliyet, isyeriad, isyeriadres, pozisyon, calismasuresi, okulAd, bolum, baslangic, bitis, notort, enAzLisans);
                PreorderEkle(kok, eklenecek, kok, false);
            }
        }

        public static void PreorderEkle(Basvuran yKok, Basvuran eklenecek, Basvuran ebeveyn, bool solsag) //false sol, true sag ve bool gönderilmesinin sebebi ebeveyn düğümün ne tarafına ekleneceğini bilmek için
        {
            if (yKok != null) //Gezinti sırasında denk geldiğimiz düğümün tamamen boş olmadığından emin oluyoruz ki kontrol sırasında program çökmesin
            {
                if (!yKok.bosmu) // Gezinti sırasında denk geldiğimiz düğümün içindeki bilgilerin silinip silinmediğine bakıyoruz boş değilse gezintiye devam
                {
                    if (eklenecek.basvuranNo <= yKok.basvuranNo)
                    {

                        PreorderEkle(yKok.sol, eklenecek, yKok, false); //yKok gezintide denk gelinen düğüm olduğundan ebeveyn olarak onu gönderiyoruz
                    }
                    else
                    {
                        PreorderEkle(yKok.sag, eklenecek, yKok, true); //yKok gezintide denk gelinen düğüm olduğundan ebeveyn olarak onu gönderiyoruz
                    }
                }
                else // Düğüm boş gözüküyorsa ama null değilse sağında ve solunda da null olmayan kök varsa diye bulunduğumuz düğümden aşağısını ekliyoruz
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
                    yKok.ad = eklenecek.ad; // birisi bilgilerini sildiği için bu düğüm boş kaldığından bilgileri değiştiriyoruz
                    yKok.adres = eklenecek.adres;
                    yKok.tel = eklenecek.tel;
                    yKok.mail = eklenecek.mail;
                    yKok.dt = eklenecek.dt;
                    yKok.ydil = eklenecek.ydil;
                    yKok.ehliyet = eklenecek.ehliyet;
                    yKok.isDeneyimi = eklenecek.isDeneyimi;
                    yKok.egitimDurumu = eklenecek.egitimDurumu;
                    yKok.bosmu = false;
                    //MessageBox.Show(yKok.basvuranNo + " - " + yKok.ad);
                }
            }
            else // Gezinti sırasında denk gelinen düğüme daha önce hiç bir düğüm eklenmediyse program buraya geliyor
            {
                try
                {
                    if (yKok != null)
                    {
                        if (yKok.sol != null || yKok.sag != null) //mevcut null düğümün solu sağı da null ama önlem amaçlı yine de eşitliyoruz.
                        {
                            eklenecek.sol = yKok.sol;
                            eklenecek.sag = yKok.sag;
                        }
                    }
                }
                catch (Exception)
                { }
                yKok = eklenecek;
                if (solsag) //Bulunduğumuz null düğüm bir üst düğümün solu mu sağı mı ona bakıp ekleme işlemini yapıyoruz.
                {
                    ebeveyn.sag = eklenecek;
                }
                else
                {
                    ebeveyn.sol = eklenecek;
                }
                //MessageBox.Show(yKok.basvuranNo + " - " + yKok.ad);
            }
            
        }
    }

    //Buradan itibaren ağaç yapısının bulunduğu, ağaç yapısında her bir düğümde bulunan bilgi ve değişkenlerin oluşturulup belleğe eklendiği yer.
    public class Basvuran
    {
        public bool bosmu = true; // bilgi silme işleminden sonra arada kalan düğümün herhangi birisine ait bilgi taşımayacağı için boş olduğunu anlayıp anlamama
        public int basvuranNo; // Ağaç yapısında sola mı yoksa sağa mı ekleneceğini anlamamızı sağlayan bir değişken
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

        // Bağlı listelere girilecek bilgiler dahil tüm bilgiler bu kurucuya geliyor, bu kurucuda ilgili olanlar eklenip geri kalan bilgilerin "tamamı"
        // sırasıyla bağlı listelere eklenmesi için onların kurucu fonksiyonlarına gönderiliyor. Bilgiler kurucu fonksiyonundan kurucu fonksiyonuna gönderliliyor
        // Ta ki tüm bilgiler eklenene kadar.
        public Basvuran(int basvuranNo, string ad, string adres, double tel, string mail, 
            DateTime dt, string ydil, string ehliyet, string isyeriad, string isyeriadres, 
            string pozisyon, int calismasuresi, string okulAd, string bolum, 
            DateTime baslangic, DateTime bitis, double notort, bool enAzLisans)
        {
            if (bosmu)
            {
                this.basvuranNo = basvuranNo;
                this.ad = ad;
                this.adres = adres;
                this.tel = tel;
                this.mail = mail;
                this.dt = dt;
                this.ydil = ydil;
                this.ehliyet = ehliyet;
                this.isDeneyimi = new IsDeneyimi(isyeriad, isyeriadres, pozisyon, calismasuresi);
                this.egitimDurumu = new EgitimDurumu(okulAd,bolum,baslangic,bitis,notort, enAzLisans);
                this.bosmu = false;
            }
        }

    }

    // isdeneyimi bağlı listesinin başlangıç noktası, aşağıya doğru adım adım tüm bilgiler taşınacak ve eklenecek
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

    // eğitim bağlı listesinin başlangıç noktası, aşağıya doğru adım adım tüm bilgiler taşınacak ve eklenecek

    public class EgitimDurumu
    {
        bool bosmu = true;
        public bool enAzLisans;
        public string okulAd;
        public EgitimDurumuBolumu sag;

        public EgitimDurumu(string okulAd, string bolum,
            DateTime baslangic, DateTime bitis, double notort, bool enAzLisans)
        {
            if (bosmu)
            {
                this.okulAd = okulAd;
                this.enAzLisans = enAzLisans;
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

}
