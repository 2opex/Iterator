using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var item in NextGalaxy)
            {

                Console.WriteLine(item.Name + Environment.NewLine + item.MegaLightYears + Environment.NewLine);
            }
            Console.ReadLine();
        }
        public static System.Collections.Generic.IEnumerable<Galaxy> NextGalaxy
        {
            get
            {
                yield return new Galaxy { Name = "Tadpole", MegaLightYears = 400 };
                yield return new Galaxy { Name = "Pinwheel", MegaLightYears = 25 };
                yield return new Galaxy { Name = "Milky Way", MegaLightYears = 0 };
                yield return new Galaxy { Name = "Andromeda", MegaLightYears = 3 };
            }
        }
        public class Galaxy
        {
            public String Name { get; set; }
            public int MegaLightYears { get; set; }
        }
    }
}
