// See https://aka.ms/new-console-template for more information
//Dont repeat yourself - DRY - Clean Code - Best Practice

using Metotlar;


Urun urun1 = new Urun();
urun1.Adi = "Elma";
urun1.Fiyati = 25;
urun1.Aciklama = "Amasya";

Urun urun2 = new Urun();
urun2.Adi = "Kalem";
urun2.Fiyati = 45;
urun2.Aciklama = "Adel Kalem";

Urun urun3 = new Urun();
urun3.Adi = "İncir";
urun3.Fiyati = 50;
urun3.Aciklama = "Taze İncir";

Urun[] urunler=new Urun[] {urun1, urun2, urun3};

foreach(Urun urun in urunler) 
{
    Console.WriteLine(urun.Adi);
    Console.WriteLine(urun.Aciklama);
    Console.WriteLine(urun.Fiyati);
    Console.WriteLine("----------------");
}

Console.WriteLine("------Metotlar--------");
//instance - örnek
//encapsulation
SepetManager sepetManeager = new SepetManager();
sepetManeager.Ekle(urun1);
sepetManeager.Ekle(urun2);

sepetManeager.Ekle2("Elma", "Amasya Elması", 25);
sepetManeager.Ekle2("Kalem", "Adel Kalem", 45);
sepetManeager.Ekle2("İncir", "Taze İncir", 50);
