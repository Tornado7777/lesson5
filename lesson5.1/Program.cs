using System;
using System.IO;
namespace lesson5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("В введите текст для записи в файел");
            string filename = "text.txt";
            string textWrite = Console.ReadLine();
            File.WriteAllText(filename, textWrite);
            Console.WriteLine($"В файел {filename} записан текст {textWrite}");
        }
    }
}
