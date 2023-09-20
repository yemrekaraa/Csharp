// See https://aka.ms/new-console-template for more information
//aray-dizi
string[] kurslar = new string[] {"Yazılım geliştirme kampı",
    "Programlamaya başlangıç için temel kurslar","java","python" }; 

for (int i = 0; i <kurslar.Length; i++)
{
    Console.WriteLine(kurslar[i]);
}

Console.WriteLine("for bitti");
//foreach ile dizi yazımı
foreach (string kurs in kurslar)
{
    Console.WriteLine(kurs);
}

Console.WriteLine("sayfa sonu - footor");
Console.ReadLine();