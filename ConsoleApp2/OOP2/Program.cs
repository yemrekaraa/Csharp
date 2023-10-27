// See https://aka.ms/new-console-template for more information
using OOP2;

GercekMusteri musteri1 = new GercekMusteri();
musteri1.CustomerNumber = "1122";
musteri1.FirstName = "Emre";
musteri1.LastName = "Kara";
musteri1.TcNumber = "1510626";
musteri1.Id = 1;

//Kodlama.io

TuzelMusteri musteri2 = new TuzelMusteri();
musteri2.Id = 2;
musteri2.CustomerNumber = "1529";
musteri2.CompanyName = "kodlama.io";
musteri2.TaxNumber = "25229292";

//Gerçek Müşteri - Tüzel Müşteri
//SOLID

Customer musteri3 = new GercekMusteri();
Customer musteri4 = new TuzelMusteri();

CustomerManager customerManager =new CustomerManager();
customerManager.Add(musteri1);
customerManager.Add(musteri2);


