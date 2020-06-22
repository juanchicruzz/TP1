using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Multihilo
{
    class PruebaHilos1
    {
        public void procesarThreads()
        {
            DateTime tiempo1 = DateTime.Now;
             
             
            Thread t = new Thread(escribirX);
            t.Start();
            Thread t2 = new Thread(escribirY);
            t2.Start();
            while (t.IsAlive == true || t2.IsAlive == true) { }
            DateTime tiempo2 = DateTime.Now;
            TimeSpan total = new TimeSpan(tiempo2.Ticks - tiempo1.Ticks);
            Console.WriteLine();
            Console.WriteLine("Tiempo de procesamiento: " + total.TotalSeconds.ToString());
            Console.ReadKey(); 
        }
        public void procesar()
        {
            DateTime tiempo1 = DateTime.Now;
            escribirX();
            escribirY();
            DateTime tiempo2 = DateTime.Now;
            TimeSpan total = new TimeSpan(tiempo2.Ticks - tiempo1.Ticks);
            Console.WriteLine();
            Console.WriteLine("Tiempo de procesamiento: " + total.TotalSeconds.ToString());
            Console.ReadKey();
        }
        public void escribirX()
        {
            escribirLetra('X');
        }
        public void escribirY()
        {
            escribirLetra('Y');
        }

        public void escribirLetra(char letra)
        {
            for (int i = 0; i < 1000; i++) { Console.Write(letra); };
        }
    }
}
