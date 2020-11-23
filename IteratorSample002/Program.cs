using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorSample002
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var item in Exec())
            {
                Console.WriteLine(item);

            }

            var enumerator = Request();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }

            enumerator.Reset();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }

            Console.ReadLine();
        }

        static IEnumerable<string> Exec()
        {
            return new MyClass();
        }

        static IEnumerator<string> Request()
        {
            return Exec().GetEnumerator();
        }
    }
}
