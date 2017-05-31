using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ansh
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2 = 0;
            if (args == null)
            {
                Console.WriteLine("0"); // Check for null array
            }
            else
            {
                Console.Write("args length is ");
                Console.WriteLine(args.Length); // Write array length
                for (int i = 0; i < args.Length; i++) // Loop through array
                {
                    num1 = Convert.ToInt16(args[i]);
                    num2 = num2 + num1;
                }
                Console.Write("Sum is = " + num2);
            }
            Console.ReadLine();
        }
    }

    
}
