using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp28
{
    class Program
    {
        private static bool kon(int[] array, int x)
        {
            int a;
            for (int i = 0; i < array.Length; i++)
            {
                a = array[i];
                for (int j = i+1; j < array.Length-1; j++)
                {
                    if(array[i] + array[j] == x)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        static void Main(string[] args)
        {
            Console.Write("Брой елеметни: ");
            int n = Convert.ToInt32((Console.ReadLine()));
            Console.Write("Сума на елементите: ");
            int x = Convert.ToInt32((Console.ReadLine()));;
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Въведи елементите {i}: ");
                int c = Convert.ToInt32(Console.ReadLine());
                array[i] = c;
            }
            if (kon(array, x))
            {
                Console.WriteLine($"има сума {x}");
            }
            else
            {
                Console.WriteLine($"няма сума {x}");
            }
    }
}
   }
