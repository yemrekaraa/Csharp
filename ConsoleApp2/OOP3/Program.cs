// See https://aka.ms/new-console-template for more information
using OOP3;

IKrediManager ihtiyacKrediManager = new IhtıyacKrediManager();
IKrediManager tasitKrediManager = new TasitKrediManager();
IKrediManager konutKredimanager = new KonutKrediManager();

BasvuruManager basvuruManager = new BasvuruManager();
//basvuruManager.BasvuruYap(ihtiyacKrediManager);

List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager, tasitKrediManager };

basvuruManager.KrediOnBilgilendirmesiYap(krediler);

