using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // use for loop to access the array element
            string[] Names = new string[5] { "Edith", "Dinah", "Chris", "Moloko", "Phakamile" };
            
            for(int j = 0; j<+Names.Length; j++)
            {
                Console.WriteLine(Names[j]);
                
            }
            Console.ReadLine();

            // use while loop to access the array element
            int i = 0;
            while(i<Names.Length)
            {
                Console.WriteLine(Names[i]);
                i++;
            }
            Console.ReadLine();

        }
    }
}
