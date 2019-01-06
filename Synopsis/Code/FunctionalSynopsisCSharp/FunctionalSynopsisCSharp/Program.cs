using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalSynopsisCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaration Variable
            int count = 0;
            string originalText, text2, pathFile = @"C:\Users\Mi PC\workspaceFP\FunctionalSynopsisCSharp\FunctionalSynopsisCSharp\Prueba\SynopsisFile.txt";
            char[] vocals = { 'a', 'e', 'i','o','u'};
            
            //Create, write or overwrite the File
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(pathFile, false))
            {
                file.WriteLine("This is a default message -> C# IS LOVE");
            }

            //Read the File and Count the vocals
            originalText = System.IO.File.ReadAllText(pathFile);
            text2 = originalText.ToLower();

            count = text2.Count(x => vocals.Contains(x));
            
            Console.WriteLine("THE FILE WAS CREATED\n");

            Console.WriteLine(originalText);
            Console.WriteLine("VOCALS -> {0}\n", count);

            /*Delete the File
            if (File.Exists(pathFile))
            {
                File.Delete(pathFile);
                Console.WriteLine("FILE WAS DELETED...");
            }
            */

            Console.WriteLine("PLEASE PRESS ANY KEY TO EXIT...");
            Console.ReadKey();
        }
    }
}
