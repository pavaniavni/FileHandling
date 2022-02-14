using System;
using System.IO;

namespace FileHandling
{
    class Program
    {
        static void Main1(string[] args)
        {   
            StreamWriter sw = new StreamWriter("C://Users//Pavani//source//repos//FileHandlings//sample.txt");
            sw.WriteLine("Writing The Data Into The File Name Sample.Text");
            sw.Flush();
            sw.Close();
            Console.WriteLine("Hello World!");
        }
    }
}