using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment_number_1
{
    internal class Classics_Book:Book
    {
        private DateTime _expDate;

        public Classics_Book(DateTime expDate, string name, int id, string description, double price) : base(name, id, description, price)   // member initialization list
        {
            ExpDate = expDate;
        }

        public DateTime ExpDate { get => _expDate; set => _expDate = value; } // properties or getter setter

        public override double CalculatePrice()
        {
            return this.Price;

        }
        public override void Display()    // override method
        {
            Console.WriteLine("ExpDate        =" + _expDate);
        }
    }
}
