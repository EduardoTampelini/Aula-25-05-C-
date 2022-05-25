using System;
using System.Threading;

namespace Exemplo.Threads
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chamada sincrona!");

            EscreverData();

            Console.WriteLine("Chamada por thread!");

            Thread threadUm = new Thread(EscreverData);
            
            threadUm.Start();

            Console.WriteLine($"Código da Thread Primaria: {Thread.CurrentThread.ManagedThreadId}");

            Console.WriteLine($"Código da Thread secundaria: {threadUm.ManagedThreadId}");

            Thread threadDois=new Thread(EscreverNome);

            threadDois.Start();

            //Console.WriteLine($"Codigo da Thread Nome: {threadDois.ManagedThreadId}");

            //Console.ReadLine(); 
        }

        //metodo sincrono
        private static void EscreverData()
        {

            Console.WriteLine($"Data hora: {DateTime.Now}");
        }
        private static void EscreverNome() 
        {
            Console.WriteLine("Digite seu nome");
             string nome = Console.ReadLine();

            Console.WriteLine($"nome é {nome}");


        }
    }
}
