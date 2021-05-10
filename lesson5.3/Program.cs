//Ввести с клавиатуры произвольный набор чисел (0...255) и записать их в бинарный файл.

using System;
using System.IO;

namespace lesson5._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ввеите набор чисел от 0 до 255 разделенный пробелом для записи в файел:");
            string NumberText = Console.ReadLine();
            string CurrentNum_Text = "0";
            byte [] CurrentNum = new byte [255] ;
            int j = 0;
            for (int i = 0; i < NumberText.Length; i++)
            {
                while (i < NumberText.Length)
                {
                    if (NumberText[i].ToString() == " ") break;
                    CurrentNum_Text = CurrentNum_Text + NumberText[i];
                    i++;
                }
                CurrentNum [j] = Convert.ToByte(CurrentNum_Text);
                j++;
                CurrentNum_Text = "0";
            }
            File.WriteAllBytes("byte.txt", CurrentNum);
        }
    }
}
