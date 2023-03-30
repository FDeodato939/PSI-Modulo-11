using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Streams
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteForFile();
            ReadForFile();
            Console.ReadLine();
        }

        public static void WriteForFile()
        {
            StreamWriter write = new StreamWriter(@"C:\Users\bun73\OneDrive\Ambiente de Trabalho\streams\readwrite\demo.txt");
            write.WriteLine("Teste2");
            write.Close();
        }

        public static void ReadForFile()
        {
            StreamReader reader = new StreamReader(@"C:\Users\bun73\OneDrive\Ambiente de Trabalho\streams\readwrite\demo.txt");
            Console.WriteLine(reader.ReadToEnd());
            reader.Close();
        }
    }
}