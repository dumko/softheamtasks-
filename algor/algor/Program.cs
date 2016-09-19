using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace algor
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter the number");
            int num = int.Parse(Console.ReadLine());

            int i = 1;
            List<int> list = new List<int>();
            while (i <= Math.Sqrt(num))
            {
                if (num % i == 0)
                {
                    if (i != num / i)
                        list.Add(i);
                        list.Add(num / i);
                }

                 i++;
            }
            for (i = 0; i < list.Count(); i++)
            {
                Console.WriteLine(list[i]);
            }
            Console.ReadKey(true);
        }
    }
}
