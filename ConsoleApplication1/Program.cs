using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Item> items = new List<Item>();
            items.Add(new Item("Germany", 2005, 10000));
            items.Add(new Item("France", 2005, 15000));
            items.Add(new Item("Belgium", 2005, 16000));
            items.Add(new Item("Belgium", 2006, 1000));
            items.Add(new Item("France", 2008, 14000));
            items.Add(new Item("Netherlands", 2005, 20000));
            items.Add(new Item("Germany", 2010, 20000));
            items.Add(new Item("France", 2010, 210000));
            items.Add(new Item("Belgium", 2010, 18000));
            items.Add(new Item("Netherlands", 2010, 10000));

            var biggestIncrease = from i1 in items
                                  where i1.Year == 2010
                                  let country = i1.Country
                                  from i2 in items
                                  where i2.Year == 2005 && i2.Country.Equals(country)
                                  let diff = (i1.Amount - i2.Amount) / i2.Amount * 100
                                  let resullt = new { Country = country, Difference = diff }
                                  orderby resullt.Difference descending
                                  select resullt;

            foreach (var result in biggestIncrease)
            {
                StringBuilder sb = new StringBuilder(result.Country)
                    .Append(": ")
                    .Append(result.Difference >= 0 ? "+" : "")
                    .Append(result.Difference)
                    .Append("%\r\n");
                Console.WriteLine(sb.ToString());
            }
            Console.ReadLine();
        }
    }
}
