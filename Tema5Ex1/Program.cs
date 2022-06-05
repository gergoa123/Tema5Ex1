using System;

//Scrieti un program care va afisa pozitia unui substring intr-un string, ambele
//siruri de caractere fiind citite de la tastatura
namespace Tema5Ex1
{
    class Program
    {
        int aux = 0;
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti string-ul!");
            string string1 = Console.ReadLine();
            Console.WriteLine("Introduceti stringul cautat");
            string string2 = Console.ReadLine();

            int aux = string1.IndexOf(string2);

            Console.WriteLine("Stringul cautat icepe pe indexul "  + aux);

        }
    }
}
