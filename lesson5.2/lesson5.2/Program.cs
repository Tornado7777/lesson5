/*Написать программу, которая при старте дописывает текущее время в файл «startup.txt».
 */
using System;
using System.IO;

namespace lesson5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = "startup.txt";
            DateTime date_now = DateTime.Now;
            File.AppendAllText(filename, date_now.ToString("dd.MM.yyyy HH.mm.ss"));
            File.AppendAllText(filename, Environment.NewLine);
        }
    }
}
