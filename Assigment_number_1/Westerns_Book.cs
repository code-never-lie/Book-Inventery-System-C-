using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment_number_1
{
    internal class Westerns_Book:Book
    {
        private double _taxRate;

        public Westerns_Book(double taxRate, string name, int id, string description, double price) : base(name, id, description, price)   // member initialization list
        {
            TaxRate = taxRate;
        }

        public double TaxRate { get => _taxRate; set => _taxRate = value; }  // properties or getter setter


        public override double CalculatePrice()  // override method
        {
            return this.Price = this.Price + (this.Price * this._taxRate) / 100;

        }

        public override void Display()  // override method
        {
            Console.WriteLine("TaxRate        =" + _taxRate);

        }
    }
}
