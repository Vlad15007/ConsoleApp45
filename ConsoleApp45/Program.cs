using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp45
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEnumerable myLis = Metod();

            foreach (var l in myLis)
            {
                Console.WriteLine(l);
            }
            Console.ReadKey();
        }

        static List<int> myList = new List<int> {-50, 5, 0, -1, 1, 2, 3 };


        static IEnumerable Metod()
        {
            foreach(int element in myList )
            {
                if(element < 2)
                {
                    yield return element;
                }
                
            }    
        }
    }
}
