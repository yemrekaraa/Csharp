// See https://aka.ms/new-console-template for more information
//string adi = "yemre";
//int yas = 22;

//Kurs kurs1=new Kurs();
//kurs1.KursAdi = "C#";
//kurs1.Egitmen = "yunus emre kara";
//kurs1.IzlenmeOranı = 68;

//Kurs kurs2 = new Kurs();
//kurs2.KursAdi = "Java";
//kurs2.Egitmen = "kerem";
//kurs2.IzlenmeOranı = 64;

//Kurs kurs3 = new Kurs();
//kurs3.KursAdi = "Python";
//kurs3.Egitmen = "Cemre";
//kurs3.IzlenmeOranı = 61;

//Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };

//foreach (var kurs in kurslar)
//{
//    Console.WriteLine(kurs.KursAdi);
//}
//class Kurs
//{
//    public string KursAdi { get; set; }
//    public string Egitmen { get; set; }
//    public int IzlenmeOranı { get; set; }
//}

//Product urun1 = new Product();

//urun1.UrunAdi = "Iphone 15 pro max";
//urun1.SaticiAdi = "Çağdaş iletişim";
//urun1.UrunFiyatı = 75000;

//Product urun2 = new Product();

//urun2.UrunAdi = "Lenovo ideapad gaming";
//urun2.SaticiAdi = "Vatan bilgisayar";
//urun2.UrunFiyatı = 25000;

//Product urun3 = new Product();

//urun3.UrunAdi = "Apple Wtch 8";
//urun3.SaticiAdi = "Can iletişim";
//urun3.UrunFiyatı = 30000;

//Product[] products=new Product[] {urun1,urun2,urun3};

//for (int i = 0; i < products.Length; i++)
//{
//    Console.WriteLine(products[i].UrunAdi);
//}
////foreach (var urunler in products)
////{
////    Console.WriteLine(urunler.UrunAdi);
////}
//class Product
//{
//    public string UrunAdi { get; set; }

//    public string SaticiAdi { get; set; }

//    public int UrunFiyatı { get; set; }
//}

Futbolcular futbolcu1 = new Futbolcular();
futbolcu1.Adi = "Talisca";
futbolcu1.Numarasi = 94;
futbolcu1.Yasi = 30;

Futbolcular futbolcu2 = new Futbolcular();
futbolcu2.Adi = "Mario Gomez";
futbolcu2.Numarasi = 9;
futbolcu2.Yasi = 35;

Futbolcular futbolcu3 = new Futbolcular();
futbolcu3.Adi = "Aboubakar";
futbolcu3.Numarasi = 10;
futbolcu3.Yasi = 32;

Futbolcular[] futbolculars = new Futbolcular[] {futbolcu1, futbolcu2, futbolcu3};

for (int i = 0; i < futbolculars.Length; i++) 
{
    Console.WriteLine(futbolculars[i].Adi);
}
class Futbolcular
{
    public string Adi { get; set; }
    public int Numarasi { get; set; }
    public int Yasi { get; set; }
}