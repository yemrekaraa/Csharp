// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information
string kategoriEtiketi = "kategori";
int ogrenciSayısı = 32000;
double faizOrani = 1.40;
bool sistemeGirisYapmisMi = false;
double dolarDun = 7.35;
double dolarBugun = 7.45;

if (dolarDun>dolarBugun)
{
    Console.WriteLine("Azalış oku");
}
else if (dolarDun<dolarBugun)
{
    Console.WriteLine("Artış oku");
}
else
{
    Console.WriteLine("Eşittir oku");
}
if (sistemeGirisYapmisMi == true)
{
    Console.WriteLine("Kullanıcı ayarları butonu");
}
else
{
    Console.WriteLine("Giriş yap butonu");
}
Console.WriteLine(kategoriEtiketi);
