using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olio_Teht_v_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int sekunti;
            Console.Write("Anna sekunnit > ");
            sekunti = int.Parse(Console.ReadLine());
            
            int tunti = sekunti / 3600;
            int minuutti = sekunti / tunti / 60;
            int ylisekunti = sekunti / tunti / minuutti / 60;
            // ^ Laskee ensin tunnit, sitten sadat minuutit, sitten sekunnit.
            Console.WriteLine("Antamasi sekuntiaika voidaan ilmaista muodossa:");
            Console.WriteLine(tunti);
            Console.WriteLine("tuntia");
            Console.WriteLine(minuutti);
            Console.WriteLine("minuuttia");
            Console.WriteLine(ylisekunti);
            Console.WriteLine("sekuntia");
        }
    }
}
