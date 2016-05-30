using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Item
    {
        public String Country { get; set; }

        public int Year { get; set; }

        public Decimal Amount { get; set; }

        public Item(String country, int year, Decimal amount)
        {
            this.Country = country;
            this.Year = year;
            this.Amount = amount;
        }

        public Item() {}
    }
}
