using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment_number_1
{
    internal abstract class Book
    {
        private string _name;
        private int _id;
        private string _description;
        private double _price;
        int _quntaty;


        public Book()    
        {                                // defualt consturctor 
            _name = "";
            _id = 0;
            _description ="";
            _price = 0;
        }

        public Book(string name, int id, string description, double price)
        {
            _name = name;                                // perameterize consturctor 
            _id = id;
            _description = description;
            _price = price;
            _quntaty = 0;
        }

        public string Name { get => _name; set => _name = value; }   // properties or getter setter
        public int Id { get => _id; set => _id = value; }
        public string Description { get => _description; set => _description = value; }
        public double Price { get => _price; set => _price = value; }


        public virtual double CalculatePrice()   // overide function of calculate price
        {
            return this.Price;

        }

        public abstract void Display();       // abstract method of display
    }
}
