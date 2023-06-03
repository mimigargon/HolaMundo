using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolaMundo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce una frase (ej: Hola Mundo!): ");
            string sentence = Console.ReadLine();
            printSentence(sentence);
        }

        public static string printSentence (string newSentence)
        {
            Console.Write(newSentence);
            Console.Write("\n");
            return newSentence;
        }
    }
}
