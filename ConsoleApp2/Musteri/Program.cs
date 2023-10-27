// See https://aka.ms/new-console-template for more information
using Musteri;

//Console.WriteLine("Hello, World!");
MusteriOzellik musteri1 =new MusteriOzellik();
musteri1.Ad = "Ahmet";
musteri1.Id = 1;
musteri1.Acıklama = "İlk müşteri";
musteri1.Harcama = 2.650;

MusteriOzellik musteri2 = new MusteriOzellik();
musteri2.Ad = "Ebru";
musteri2.Id = 2;
musteri2.Acıklama = "En az harcama yapan müşteri";
musteri2.Harcama = 1.650;

MusteriOzellik musteri3 = new MusteriOzellik();
musteri3.Ad = "Veli";
musteri3.Id = 3;
musteri3.Acıklama = "En çok harcama yapan müşteri";
musteri3.Harcama = 3.650;

//MusteriOzellik[] musteriler = new MusteriOzellik[] {musteri1,musteri2,musteri3};
//for (int i = 0; i < musteriler.Length; i++)
//{
//    Console.WriteLine(musteri1.Ad);
//    Console.WriteLine(musteri2.Ad);
//    Console.WriteLine(musteri3.Ad);
//    Console.WriteLine("------------------");
//}
MusteriManager musteriManager = new MusteriManager();
musteriManager.Ekle1(musteri1);
musteriManager.Ekle1(musteri2);
musteriManager.Ekle2(musteri3);

Console.ReadKey();