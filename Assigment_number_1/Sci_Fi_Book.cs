namespace Assigment_number_1
{
    internal class Sci_Fi_Book : Book
    {

        private int _discount;

        public Sci_Fi_Book(int discount, string name, int id, string description, double price) : base(name, id, description, price)    // member initialization list
        {
            Discount = discount;
        }

        public int Discount { get => _discount; set => _discount = value; }  // properties or getter setter


        public override double CalculatePrice()
        {
            return this.Price = this.Price - (this.Price * this.Discount) / 100;

        }

        public override void Display()  // override method
        {
            Console.WriteLine("Discount        =" + Discount);
        }
    }
}
