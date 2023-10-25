using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections;
/* LINQ ( Language Integrated Query) (Dil Entegreli Sorgu)
* Enumarable Class= :IEnumarable <> Standart sorgu operatörlerini içerir. Sayılabilir.
* Queryable Class= IQueryable<> Standart sorgu operatörlerini içerir. Sorgulanabilir.
* Bir döngü içerisindeki (for, foreach gibi) nesneyi bulma işlemleri için avantaj sağlar.
* Derleme zamanında kontrolü kolaylaştırır.
* SQL den daha basit ve iyi düzenlenmiştir.
* XML, SQL, Entities gibi bağlantılarla kolay çalışabilir.
* Lambda ifadelerini destekler.
* Farklı tiplerdeki verileri, veri kaynaklarına uyum sağlar.
* Yeniden kullanılabilir sorgulama imkanları sunar.
* Dezavantaj olarak ise farklı dilleri desteklememesi verilebilir.
*/

//class ABC
//{
//static void Main ()
//{
//    IEnumerable<int> result = ((ParallelQuery<int>)ParallelEnumerable.Range(3, 20))
//        .Where(n => n % 5 == 0).Select(res => res);
//    Console.WriteLine("sayilar");
//    foreach(int sayilar in result)
//    {
//        Console.WriteLine(sayilar);
//    }

//}

//static void Main()
//{
//    IEnumerable<int> veri = ((ParallelQuery<int>)ParallelEnumerable.Range(
//        10, 30)).Where(i => i % 2 == 0).Select(deger => deger);
//    foreach(int cift in veri)
//    {
//        Console.WriteLine(cift);
//    }
//}

//static void Main()
//{
//    IEnumerable<int> veri = ((ParallelQuery<int>)(ParallelEnumerable.Range
//        (4,50)).Where(i => i % 2 == 1).Select(deger => deger));
//    foreach (int tek in veri)
//    {
//        Console.WriteLine(tek);
//    }
//}


//static void Main()
//{
//    int[] Yas = { 27, 24, 22, 24, 25, 27, 20, 23, 24, 22, 23, 26, 31 };
//    int toplam = Yas.Sum();
//    int ort = toplam / Yas.Length;

//    var oay = from yaslar in Yas where yaslar < ort select yaslar;
//    Console.WriteLine("Ortalama yaslar : " + ort);
//    Console.WriteLine("Ortalamanın altında kalan yaslar : ");
//    foreach (int i in oay)
//    {
//        Console.WriteLine(i + " ");
//    }

//    Console.WriteLine();

//}

//static void Main()
//{

//    List<string> veriler = new List<string>();
//    veriler.Add("Berfin");
//    veriler.Add("Pınar");
//    veriler.Add("Mira");
//    veriler.Add("Reyyan");
//    veriler.Add("Berk");
//    veriler.Add("Aleyna");
//    veriler.Add("Taha");

//    IEnumerable<string> sonuc = veriler.Where(ogrenciler => ogrenciler.Length > 4);
//    Console.WriteLine("İsmi 4 harften fazla olan öğrenciler: ");
//    foreach ( string ogradi in sonuc)
//    {
//        Console.WriteLine(ogradi);
//    }
//}




/****************************** SQL ----> LINQ **********************************
 * Select - From - Where -----------> From - Where - Select
 * Or: MusteriListesi
 * Select*                            from Isimler
 * From Isımler                       in MusteriListesi
 * Where ogradi                       where<string>.....
 */

//static void Main()
//{
//    List<string> veriler = new List<string>();
//    veriler.Add("Berfin");
//    veriler.Add("Pınar");
//    veriler.Add("Reyyan");
//    veriler.Add("Mira");
//    veriler.Add("Aleyna");
//    veriler.Add("Medine");
//    veriler.Add("Yunus");
//    veriler.Add("Taha");
//    veriler.Add("Özlem");
//    char arananHarf = 'R';


//    var harfleBaslayanlar = from veri in veriler
//                            where veri.StartsWith(arananHarf.ToString(), StringComparison.OrdinalIgnoreCase)
//                            select veri;

//    Console.WriteLine($"'{arananHarf}' harfi ile başlayan veriler:");
//    foreach (var item in harfleBaslayanlar)
//    {
//        Console.WriteLine(item);
//    }


//    char arananHarfIceren = 'r'; 
//    var harfIcerenler = from veri in veriler
//                        where veri.ToLower().Contains(arananHarfIceren)
//                        select veri;

//    Console.WriteLine($"\n'{arananHarfIceren}' harfini içeren veriler:");
//    foreach (var item in harfIcerenler)
//    {
//        Console.WriteLine(item);
//    }
//}


//public static void Main(string[] args)
//{
//    string[] isimler = { "rdfgjhf", "jfkh", "hvbjker", "yfhgbf" };
//    var Linq = from ad in isimler
//               where ad.Contains("r")
//               select ad;
//    foreach (var sayac in Linq)
//    {
//        Console.WriteLine(sayac);
//    }
//}


/* LINQ Filtreleme Operatörü
 * OfType = Filtreleme işlevini yerine getirir.
 * Tek bir sorgu ifadesinde birden fazla oftype kullanılabilir.
 */



//}

//public class Calısanlar
//{
//    public int cal_id
//    {
//        get; set;
//    }

//    public string cal_ad
//    {
//        get; set;
//    }
//    public string cal_cinsiyet
//    {
//        get; set;
//    }

//    public int cal_is_tarihi
//    {
//        get; set;
//    }

//    public int cal_maas
//    {
//        get; set;
//    }
    
//    public class ABC
//    {
//        static public void Main()
//        {
//            // Verileri ekleme
//            ArrayList liste = new ArrayList();
//            liste.Add("ÖZKAHRAMAN");
//            liste.Add(3);
//            liste.Add(new Calisanlar() { cal_id = 201, cal_ad = "Berfin", cal_maas = 25000, cal_cinsiyet = "Kadın", cal_is_tarihi = 8 });
//            liste.Add(new Calisanlar() { cal_id = 202, cal_ad = "Pınar",  cal_maas = 23000 ,cal_cinsiyet = "Kadın", cal_is_tarihi = 10 });
//            liste.Add(new Calisanlar() { cal_id = 203, cal_ad = "Mira",   cal_maas = 22000 ,cal_cinsiyet = "Kadın", cal_is_tarihi = 12 });
//            liste.Add(new Calisanlar() { cal_id = 204, cal_ad = "Reyyan", cal_maas = 21000 ,cal_cinsiyet = "Kadın", cal_is_tarihi = 13 });

//            // OfType Filtreleme
            
//            var xyz1 = from x1 in liste.OfType<string>()
//                       select x1;
//            foreach (var asd in xyz1)
//            {
//                Console.WriteLine(asd);
//            }

//            var xyz2 = from x2 in liste.OfType<Calisanlar>()
//                       select x2;
//            foreach (var asd2 in xyz2)
//            {
//                Console.WriteLine(asd2.cal_ad);
//            }

//            var xyz3 = from x3 in liste.OfType<Calisanlar>()
//                       select x3;
//            foreach (var asd3 in xyz3)
//            {
//                Console.WriteLine(asd3.cal_id);
//            }

//            var xyz4 = from x4 in liste.OfType<Calisanlar>()
//                       select x4;
//            foreach (var asd4 in xyz4)
//            {
//                Console.WriteLine(asd4.cal_maas);
//            }
        
            
        
        
//        }
//    }

//}




