using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var item in FilterWithoutYield2)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
        public static List<int> Data
        {
            get
            {
                return new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };
            }
        }
        public static IEnumerable<int> FilterWithoutYield1
        {
            get
            {
                var result = new List<int>();
                foreach (var i in Data)
                {
                    if (i > 4)
                        result.Add(i);
                }
                return result;
            }
        }
        public static IEnumerable<int> FilterWithoutYield2
        {
            get
            {
                foreach (var i in Data)
                {
                    if (i > 4)
                        yield return i;
                }
            }
        }
    }
}
