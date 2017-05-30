using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miles_to_Kilometers
{
    class Miles_to_Kilometers
    {
        static void Main(string[] args)
        {
            var a = double.Parse(Console.ReadLine());

            var convert = a * 1.60934;

            Console.WriteLine("{0:F2}", convert);
        }
    }
}
