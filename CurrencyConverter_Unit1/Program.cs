using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter_Unit1
{
    class Program
    {
        static void Main(string[] args)
        {
            double x;
            double y;
            double z;
            
            Console.WriteLine("Please enter your first amount");

            string userInput1=Console.ReadLine();
            double.TryParse(userInput1, out x);

            Console.WriteLine("Please enter your second amount");

            string userInput2 = Console.ReadLine();
            double.TryParse(userInput2, out y);

            Console.WriteLine("Please enter your third amount");

            string userInput3 = Console.ReadLine();
            double.TryParse(userInput3, out z);

            Console.WriteLine($"Your total amount is { (x + y + z).ToString ("C")}");
            Console.WriteLine($"Your total amount is { (x + y + z).ToString("C0", new CultureInfo("ja-JP"))}");
            Console.WriteLine($"Your total amount is { (x + y + z).ToString("C", new CultureInfo("sv-SE"))}");
            Console.WriteLine($"Your total amount is { (x + y + z).ToString("C2", new CultureInfo("th-TH"))}");

            Console.WriteLine($"Your average is {((x+y+z)/3).ToString("C")}");

            Console.WriteLine($"Your largest amount is {Math.Max(x, Math.Max(y, z)).ToString("C")} ");
            Console.WriteLine($"Your lowest amount is {Math.Min(x, Math.Min(y, z)).ToString("C")} ");

            Console.ReadLine();
        }
    }
}
