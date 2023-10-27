// See https://aka.ms/new-console-template for more information

//dizilere sonradan eleman eklmesi yapılmaz
//string[] isimler = new string[] {"engin","murat","kerem","halil" };
//Console.WriteLine(isimler[0]);
//Console.WriteLine(isimler[1]);
//Console.WriteLine(isimler[2]);
//Console.WriteLine(isimler[3]);


List<string> isimler2 = new List<string> { "Engin","murat","kerem","halil"};
Console.WriteLine(isimler2[0]);
Console.WriteLine(isimler2[1]);
Console.WriteLine(isimler2[2]);
Console.WriteLine(isimler2[3]);
isimler2.Add("ilker"); //İSİMLER LİSTİNE BÖYLE ELEMAN EKLEYEBİLİRİZ
Console.WriteLine(isimler2[4]);
Console.WriteLine(isimler2[0]);