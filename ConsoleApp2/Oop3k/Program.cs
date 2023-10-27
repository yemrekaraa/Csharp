// See https://aka.ms/new-console-template for more information
using Oop3k;
using System.Collections.Generic;

IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
KonutKrediManager konutKrediManager=new KonutKrediManager();
TasitKrediManager tasitKrediManager=new TasitKrediManager();

ILoggerService databaseLoggerService=new DatabaseLoggerService();
ILoggerService fileLoggerService=new FileLoggerService();

BasvuruManager basvuruManager =new BasvuruManager();
basvuruManager.BasvuruYap(konutKrediManager, new DatabaseLoggerService());

List<IKrediManager> krediler =new List<IKrediManager>() {ihtiyacKrediManager };
//basvuruManager.KrediOnBilgilendirmesiYap(krediler);

