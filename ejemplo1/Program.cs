using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Lista listanueva = new Lista();

            listanueva.InsertarI(40);
            listanueva.InsertarI(30);
            listanueva.InsertarI(20);
            listanueva.InsertarI(10);

            listanueva.InsertarP(220, 1);
            listanueva.InsertarF(9);

            listanueva.mostrar();
            Console.ReadKey();
        }
    }
}
