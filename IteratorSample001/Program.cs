using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorSample001
{
    class Program
    {
        static void Main(string[] args)
        {

            foreach (var item in Exec())
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }

        static IEnumerable<string> Exec()
        {
            yield return "A";
            yield return "B";
            yield return "C";
        }
    }
}
