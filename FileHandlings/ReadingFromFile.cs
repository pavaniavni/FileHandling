using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandlings 
{
    internal class ReadingFromFile
    {
        public static void Main2(string[] args)
        {
            StreamReader sr = new StreamReader("C://Users//Pavani//source//repos//FileHandlings//sample.txt");

            //this is used to specify from where to start reading input stream
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            string str = sr.ReadLine();

            while (str != null)
            {
                Console.WriteLine(str);
                str = sr.ReadLine();
            }
            sr.Close();
        }
    }
}
