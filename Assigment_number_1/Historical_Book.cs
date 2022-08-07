using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment_number_1
{
    internal class Historical_Book:Book
    {
        private int Bundle_offers;

        public Historical_Book(int bundle_offers, string name, int id, string description, double price) : base(name, id, description, price)   // member initialization list
        {
            Bundle_offers1 = bundle_offers;
        }

        public int Bundle_offers1 { get => Bundle_offers; set => Bundle_offers = value; }  // properties or getter setter

        public override double CalculatePrice()
        {
            if (Bundle_offers == 1)
            {
                return this.Price/2;
            }
            else
            {
                return this.Price;
            }

        }
        public override void Display()  // override method
        {
            Console.WriteLine("Bundle_offers        =" + Bundle_offers);
        }
    }
}
