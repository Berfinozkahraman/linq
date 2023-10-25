//using System;
//using System.Linq;
//using System.Collections.Generic;

//public class Calisan
//{
//    public int cal_id { get; set; }
//    public string cal_name { get; set; }
//    public string cal_cinsiyet { get; set; }
//    public string cal_year { get; set; }
//    public int cal_maas { get; set; }
//}

//public class ABCD
//{
//    static public void Main()
//    {
//        List<Calisan> cal = new List<Calisan>()
//        {
//            new Calisan(){cal_id=209,cal_name="Berfin", cal_cinsiyet="Kadın",
//            cal_year="5", cal_maas= 20000},
//            new Calisan(){cal_id=209,cal_name="Mira", cal_cinsiyet="Kadın",
//            cal_year="5", cal_maas= 22000},
//            new Calisan(){cal_id=209,cal_name="Reyyan", cal_cinsiyet="Kadın",
//            cal_year="5", cal_maas= 24000},
//            new Calisan(){cal_id=209,cal_name="Aleyna", cal_cinsiyet="Kadın",
//            cal_year="5", cal_maas= 26000},
//             new Calisan(){cal_id=209,cal_name="Pınar", cal_cinsiyet="Kadın",
//            cal_year="5", cal_maas= 28000}
//        };


//        var x1 = cal.Where(a => a.cal_maas > 22000).Where;// main metodunda kullanmak istersek .where yazarak kullanırız
//        foreach (var x in x1)
//        {
//            Console.WriteLine("Çalışan Maaşı: {0}", x.cal_name);
//        }




//    }
//}