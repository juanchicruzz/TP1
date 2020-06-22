using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Multihilo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*PruebaHilos1 P = new PruebaHilos1();
            P.procesar();
            P.procesarThreads();
            */

            //PruebaAsinc();
            //PruenaNoAsinc();
        }

        private static void PruebaAsinc()
        {
            while (true)
            {
                // Empieza proceso async.
                EjemploAsinc();
                // input usuario.
                string result = Console.ReadLine();
                Console.WriteLine("Texto input: " + result);
            }
        }
        private static void PruebaNoAsinc()
        {
            while (true)
            {
                
            }
        }



        static async void EjemploAsinc()
        {
            // Este metodo se ejecuta asincronico.
            int t = await Task.Run(() => Allocate());
            Console.WriteLine("Digitos: " + t);
        }
        static void Ejemplo() 
        {
            int t = Allocate();
            Console.WriteLine("Digitos: " + t);
        }

        static int Allocate()
        {
            // Un proceso que tarda para probar el tiempo.
            int size = 0;
            for (int z = 0; z < 100; z++)
            {
                for (int i = 0; i < 1000000; i++)
                {
                    string value = i.ToString();
                    size += value.Length;
                }
            }
            return size;
        }
    }


}

