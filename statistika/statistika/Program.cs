using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace statistika
{
    internal class Program
    {
        static void Main()
        {
            
            person a = new person();
            
            Console.Write("въведи име = ");
            a.Name = (Console.ReadLine());
            Console.Write("въведи години = ");
            a.Age = int.Parse(Console.ReadLine());
            Console.WriteLine("Името ти е " + a.Name + " и си на " + a.Age);

            person b = new person();

            Console.Write("въведи име = ");
            b.Name = (Console.ReadLine());
            Console.Write("въведи години = ");
            b.Age = int.Parse(Console.ReadLine());
            Console.WriteLine("Името ти е " + b.Name + " и си на " + b.Age);

            person c = new person();

            Console.Write("въведи име = ");
            c.Name = (Console.ReadLine());
            Console.Write("въведи години = ");
            c.Age = int.Parse(Console.ReadLine());

            Console.WriteLine("Името ти е " + c.Name + " и си на " + c.Age);
            //int[] a1 = new int[0];
            //int n = 3;

            //for (int i = 0; i < n; i++)
            //{

            // Console.WriteLine(a1);

            //}

        }
    }
}
