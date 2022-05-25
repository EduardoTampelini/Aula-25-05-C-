using System;
using System.Threading;

namespace Exemplo.CompartilharVariavelEstarica
{
    internal class Program
    {
        private static bool _isImprimir = true;

        static void Main(string[] args)
        {
            var threadUm = new Thread(ImprimirNome);
            var threadDois = new Thread(ImprimirNome);    

            threadUm.Start();
            threadDois.Start();

            Console.ReadLine();
        }

        private static void ImprimirNome()
        {
            if (!_isImprimir)
            {
                return;
            }
            _isImprimir = false;
            Console.WriteLine("Eduardo");
        }
    }
}
