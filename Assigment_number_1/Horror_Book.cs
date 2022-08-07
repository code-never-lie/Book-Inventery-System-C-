using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment_number_1
{
    internal class Horror_Book:Book
    {
        private int Promotions;

        public Horror_Book(int promotions, string name, int id, string description, double price) : base(name, id, description, price)   // member initialization list
        {
            Promotions1 = promotions;
        }

        public int Promotions1 { get => Promotions; set => Promotions = value; }   // properties or getter setter



        public override double CalculatePrice()
        {
           if(Promotions == 1)
            {
                return this.Price;
            }
            return 0;

        }

        public override void Display()   // override method
        {
            Console.WriteLine("Promotions        =" + Promotions);
        }
    }
}
