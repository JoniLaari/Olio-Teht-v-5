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
            int minuutti = sekunti % 60;
            int tunti = sekunti % 3600;
            Console.WriteLine("Antamasi sekuntiaika " tunti "tunti (a)", minuutti, "minuuttia");
            Console.WriteLine();
        }
    }
}
