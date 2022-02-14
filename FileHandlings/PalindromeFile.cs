using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandlings
{
    internal class PalindromeFile
    {
       static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter("C://Users//Pavani//source//repos//FileHandlings//palindrome.txt");
            sw.WriteLine("madam");
            sw.Flush();
            sw.Close();
            StreamReader sr = new StreamReader("C://Users//Pavani//source//repos//FileHandlings//palindrome.txt");
            string s = sr.ReadLine();
           
            string  revs = "";
            
            for (int i = s.Length - 1; i >= 0; i--) //String Reverse  
            {
                revs += s[i].ToString();
            }
            if (revs == s) // Checking whether string is palindrome or not  
            {
                Console.WriteLine("String is Palindrome \n Entered String Was {0} and reverse string is {1}", s, revs);
            }
            else
            {
                Console.WriteLine("String is not Palindrome \n Entered String Was {0} and reverse string is {1}", s, revs);
            }
            

        }
    }
}
