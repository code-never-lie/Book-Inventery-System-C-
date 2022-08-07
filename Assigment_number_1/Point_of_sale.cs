using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment_number_1
{
    internal class Point_of_sale
    {
        private List<Book> items;
        double totalPrice = 0;
        string check;
        public Point_of_sale()
        {
            items = new List<Book>();
        }

       
      
        public void add_in_Inventory (Book Book)
        {
            items.Add(Book);
           
        }
      
        public void show_all_item()
        {
            foreach (Book Book in items)
            {
                Console.WriteLine("==========================================\n");
                Console.WriteLine("Name        ="+Book.Name);
                Console.WriteLine("Id          ="+Book.Id);
                Console.WriteLine("Description ="+Book.Description);
                Console.WriteLine("Price       ="+Book.Price);
                Book.Display();
                Console.WriteLine("===========================================\n");
               

            }
        }
        public int count()
        {
            return items.Count();
        }
        public void updateliste(Book Book)
        {
            items.Append(Book);
        }

        public void sale_product()
        {
            foreach (Book Book in items)
            {
                Console.WriteLine("==========================================\n");
                Console.WriteLine("Name        =" + Book.Name);
                Console.WriteLine("Id          =" + Book.Id);
                Console.WriteLine("Description =" + Book.Description);
                Console.WriteLine("Price       =" + Book.Price);
                Book.Display();
                Console.WriteLine("===========================================\n");
                
                
            }
           
            do
            {
                Console.WriteLine("========Now Enter Name which Book want to sale===========\n");
                string name = Console.ReadLine();
                foreach (Book Book in items)
                {
                    double price;
                    if (Book.Name == name)
                    {
                        price = Book.CalculatePrice();
                        shoping_Total_price(price);
                        
                    }
                }
                
                Console.WriteLine("Do you want to sale anything Y/n");
                check = Console.ReadLine();
            } while (check == "Y" || check == "y");
            }

        public void shoping_Total_price(double price)
        {
            
            totalPrice = totalPrice+price;

            Console.WriteLine("You have to pay: " + totalPrice);

        }

    }

}
