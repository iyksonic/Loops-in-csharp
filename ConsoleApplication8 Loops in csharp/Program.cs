using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8_Loops_in_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //For Loop
            for (int i = 1; i <= 12; i++){
                Console.WriteLine("7 x {0} = {1}", i, 7 * i);

                
            }
            Console.WriteLine();

            //While Loop
            int j = 1;

            while(j <= 12)
            {
                Console.WriteLine("8 x {0} = {1}", j, 8 * j);
            
               j++;
            }

            Console.WriteLine();

            //Do While Loop
            int k = 1;

            do
            {
                Console.WriteLine("9 x {0} = {1}", k, 9 * k);
                k++;
            } while (k <= 12);

            Console.ReadLine();
        }
    }
}
