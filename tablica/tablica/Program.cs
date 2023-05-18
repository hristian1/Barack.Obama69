using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace tablica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("колко реда = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("колко колони = ");
            int n1 = int.Parse(Console.ReadLine());

            int[,] a = new int [n,n1];
            for (int i = 0;i< n; i++)
            {
                double sr = 0;
                for (int j = 0; j < n1; j++)
                {
                    Console.Write("а[{0},{1}] = ",i,j);
                    a[i,j] = int.Parse(Console.ReadLine());
                    sr += a[i, j];
                }
                sr = sr / n1;
                Console.WriteLine(sr);
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n1; j++)
                {
                    Console.Write(a[i,j] + " ");
                     
                }
                Console.WriteLine();
            }
           

        }
    }
}
