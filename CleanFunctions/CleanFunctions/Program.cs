using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CleanFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var result = FileProcess.GetDataFromFile("ABC.txt");
        }

        static string[] words = { "Adana", "Yozgat", "Bilecik", "Ankara" };

        static void Write()
        {
            foreach (var word in words)
            {
                WriteToConsole(word, firstLetter:"A");
            }
        }

        private static void WriteToConsole(string word, string firstLetter)
        {
            if (word.StartsWith(firstLetter))
            {
                Console.WriteLine(word);
            }
        }

        static bool isEven(int number)
        {
            return number % 2 == 0;
          
        }
    }

    public static class FileProcess
    {
        public static List<string> GetDataFromFile(string path)
        {
            if (string.IsNullOrEmpty(path))
            {
                throw new ArgumentNullException(path);
            }
            if (!File.Exists(path))
            {
                throw new FileNotFoundException($"{path} diye bir dosya yok!");
            }
            return File.ReadAllLines(path).ToList();
        }

    }
}
