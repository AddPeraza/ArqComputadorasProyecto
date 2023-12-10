using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ArqComputadorasProyecto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var limit = 5_000_000;
               
            var numeros = Enumerable.Range(0, limit).ToList();

            var watch = Stopwatch.StartNew();
            var numerosPrimosForeach = ListaNumerosPrimos(numeros);
            watch.Stop();

           // var watchForParallel = Stopwatch.StartNew();
           // var numeroPrimoParallelForeach = ListaNumerosPrimosParallel(numeros);
           //watchForParallel.Stop();

            Console.WriteLine($"foreach clasico | Total de numeros primos :{numerosPrimosForeach.Count} | Tiempo Total : {watch.ElapsedMilliseconds} ms");
          
            //Console.WriteLine($"foreach Parallel | Total de numeros primos :{numeroPrimoParallelForeach.} | Tiempo Total : {watchForParallel.ElapsedMilliseconds} ms");
            Console.ReadLine();
        }

        private static IList<int> ListaNumerosPrimos(IList<int> numeros) => numeros.Where(EsPrimo).ToList();

        private static bool EsPrimo(int numeros)
        {
            if (numeros < 2)
                return false;

            for (var divisor = 2; divisor <= Math.Sqrt(numeros); divisor++)

            {
                if (numeros % divisor == 0)
                    return false;
            }
            return true;    
        }
    }
}




