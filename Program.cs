using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Working_With_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This willwrite same line");
            Console.WriteLine("This will \n wrap to next line");
            Console.WriteLine("This will \" print out the quotation mark.");

            string firstName = "Mokgadi";
            string lastName = "Thobejane";
            //concatination
            Console.WriteLine(firstName + " " + lastName);

            //function with strings
            Console.WriteLine(lastName.Length);
            //methods on strings
            Console.WriteLine(firstName.ToUpper());
            //method with a parameter eg the contains(), its case sensitive
            Console.WriteLine(lastName.Contains("Fu"));
            //access characters  using index 
            Console.WriteLine(firstName[0]);
            //indexOf will tell you iff the value is there and atwhat position
            Console.WriteLine("index of a is");
            Console.WriteLine(lastName.IndexOf('a'));// can use double qoutes too
            //suvstring, to grabfrom an index onwards
            Console.WriteLine(firstName.Substring(1));
            //you can also give index Nand length ie how many chars you wanna grab
            Console.WriteLine(firstName.Substring(1,2));
            Console.Read();
        }
    }
}
