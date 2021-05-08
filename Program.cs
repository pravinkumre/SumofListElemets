using System;
using System.Collections.Generic;

namespace ConsoleApp14_SumofListElemets
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> lst1 = new List<int>();
            lst1.Add(1);
            lst1.Add(5);

            List<int> lst2 = new List<int>();
            lst2.Add(2);
            lst2.Add(4);
            lst2.Add(10);

            List<int> lst3 = new List<int>();
            lst3.Add(5);
            lst3.Add(3);
            lst3.Add(14);
            lst3.Add(4);
            lst3.Add(22);

            List<List<int>> queries = new List<List<int>>();
            queries.Add(lst1);  //o/p : 5+11 = 16
            queries.Add(lst2); //o/p : 15-4+10 = 21
            queries.Add(lst3); //o/p : 11+4+14+-4+22 = 47

            List<int> numbers = new List<int> { 3, 5, 15, 4, -4, 11, 2 };

            foreach (var aa in queries)
            {
                int sum = 0;

                foreach (var bb in aa)
                {
                    if (bb > numbers.Count)
                        sum += bb;
                    else
                        sum += numbers[bb];
                }

                Console.WriteLine(" sum : " + sum);
            }
        }
    }
}
