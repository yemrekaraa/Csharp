using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Musteri
{
    internal class MusteriManager
    {
        public void Ekle1(MusteriOzellik musteri)
        {
            
           Console.WriteLine("Müşteri Eklendi : " + musteri.Ad);
        }
        public void Ekle2(MusteriOzellik musteri)
        {
            Console.WriteLine("Müşteri Silindi : "+ musteri.Ad);
        }
        
    }
}
