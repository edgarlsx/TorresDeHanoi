using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TorresDeHanoi;

namespace TorresTesteApp
{
    class Program
    {
        static void Main(string[] args)
        {

            string inicio = DateTime.Now.ToString("dd-MM-yyyy hh:mm:sss");
            string numdiscos;

            Console.Write("Enter the number of discs: ");
            numdiscos = Console.ReadLine();

            TorreDeHanoi Hanoi = new TorreDeHanoi();
            Hanoi.numdiscos = Convert.ToInt32(numdiscos);
            Hanoi.incio = inicio;
            Hanoi.inicia();

            Hanoi.moveTorre(Hanoi.numdiscos, 1, 3, 2);
                //Console.WriteLine("Mover disco {0} da torre {1} para torre {2}", num, de, vai)

            Hanoi.finaliza();

            Console.ReadLine();


        }
    }
}
