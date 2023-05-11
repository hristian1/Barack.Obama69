using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biraria
{
    internal class Program
    {
        static void Main()
        {
            biraria a = new biraria();
            Console.Write("kolko dushi ste = ");
            a.Dushi = int.Parse(Console.ReadLine());
            Console.Write("въведи ID = ");
            a.Id  = int.Parse(Console.ReadLine());
            Console.Write("избрал си бира = ");
            a.Bira = (Console.ReadLine());
            Console.Write("избери колочество = ");
            a.Kolichestvo = int.Parse(Console.ReadLine());
            Console.Write("колко ще струва = ");
            a.Cena= double.Parse(Console.ReadLine());
            //Console.WriteLine("избраната поръчка е с клиентски номер " + a.Id + " избраната бира е " + a.Bira + " бирите са " + a.Kolichestvo + " и цената е " + a.Cena * a.Kolichestvo + "лв.");
            Console.WriteLine("     избрана поръчка:");
            Console.WriteLine("                клиентси номер" + a.Id);
            Console.WriteLine("                избрал бира" + a.Bira);
            Console.WriteLine("                бройки" + a.Kolichestvo);
            Console.WriteLine("                ед.цена" + a.Cena);




            Console.Write("колко души сте = ");
            int countpeople=int.Parse(Console.ReadLine());
            List<string> biri = new List<string>() {"ариана","пиринско","каменица","амстел","бургаско","хайникен","туборк","корона","стела"};
            Console.WriteLine("какво ще пием? ");
            Console.WriteLine("нашето меню е :");
            for(int i = 0; i < biri.Count;i++)
            {
                Console.WriteLine((i + 1) + ". " + biri[i]);
            }
            Console.Write("какво ще пием? = ");
            Console.ReadLine();

        }
    }
}
