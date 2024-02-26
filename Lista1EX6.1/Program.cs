using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1EX6._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float a;
            Console.WriteLine("Digite um Número: ");
            a = float.Parse(Console.ReadLine());
            float b = a / 4;
            if (a == (int)b * 4) { Console.WriteLine("Número Inválido"); }
            else { Console.WriteLine("O Número " + a + " é Válido"); }
            Console.ReadKey();  
        }
    }
}
