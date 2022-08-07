using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment_number_1
{
    internal class Storekeeper
    {
        private string _name;
        private Point_of_sale _inventory;
        List<Book> book = new List<Book>();
        public Storekeeper()
        {
            Name = "";
            
        }
        public Storekeeper(string name)
        {
            Name = name;
            _inventory = new Point_of_sale();
        }

        public string Name { get => _name; set => _name = value; }
           
        public void show_inventory()
        {
            Console.WriteLine("============================================================\n");
            Console.WriteLine("============================================================\n");
            Console.WriteLine("===========Well Come to Point Of Sale  System==========\n");
            Console.WriteLine("============================================================\n");
            Console.WriteLine("============================================================\n");
            Console.WriteLine("\n");
           
        }

 
        public void create_new_item()
        {

            Console.WriteLine("=================================\n");
            Console.WriteLine("===========Menu==================\n");
            Console.WriteLine("=================================\n");
            Console.WriteLine(" Press 1 to add Sci_Fi_Book\n");
            Console.WriteLine(" Press 2 to add Westerns_Book \n");
            Console.WriteLine(" Press 3 to add Classics_Book \n");
            Console.WriteLine(" Press 4 to add Horror_Book \n");
            Console.WriteLine(" Press 5 to add Historical_Book \n");
            int select = Convert.ToInt32(Console.ReadLine());
            if(select == 1) 
            {
                Console.WriteLine(" Enter the name of Sci_Fi_Book \n");
                string name = Console.ReadLine();
                Console.WriteLine(" Enter the id of Sci_Fi_Book \n");
                int id=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" Enter the description of Sci_Fi_Book \n");
                string description= Console.ReadLine();
                Console.WriteLine(" Enter the price of Sci_Fi_Book \n");
                double price= Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" Enter the Pecentage discount nof Sci_Fi_Book \n");
                int discount= Convert.ToInt32(Console.ReadLine());
                Sci_Fi_Book Sci_Fi_Book = new Sci_Fi_Book( discount,name, id,description,price);
                _inventory.add_in_Inventory(Sci_Fi_Book);
                Console.WriteLine(" Successfuly Added in Point_of_sale \n");
            }
            else if (select == 2)
            {
                Console.WriteLine(" Enter the name of Westerns_Book \n");
                string? name = Console.ReadLine();
                Console.WriteLine(" Enter the id of Westerns_Book \n");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" Enter the description of Westerns_Book \n");
                string? description = Console.ReadLine();
                Console.WriteLine(" Enter the price of Westerns_Book \n");
                double price = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" Enter the Pecentage tex nof Westerns_Book \n");
                int tex = Convert.ToInt32(Console.ReadLine());
                Westerns_Book Westerns_Book = new Westerns_Book(tex, name, id, description, price);
                _inventory.add_in_Inventory(Westerns_Book);
                Console.WriteLine(" Successfuly Added in Point_of_sale \n");
            }
           else  if (select == 3)
            {
                Console.WriteLine(" Enter the name of Classics_Book \n");
                string? name = Console.ReadLine();
                Console.WriteLine(" Enter the id of Classics_Book \n");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" Enter the description of Classics_Book \n");
                string? description = Console.ReadLine();
                Console.WriteLine(" Enter the price of Classics_Book \n");
                double price = Convert.ToInt32(Console.ReadLine());
               // Console.WriteLine(" Enter the expry date of Classics_Book \n");
                DateTime dateTime = new DateTime(17, 12, 2021);
                Classics_Book Classics_Book = new Classics_Book(dateTime, name, id, description, price);
                _inventory.add_in_Inventory(Classics_Book);
                Console.WriteLine(" Successfuly Added in Point_of_sale \n");
            }
            else if (select == 4)
            {
                Console.WriteLine(" Enter the name of Horror_Book \n");
                string? name = Console.ReadLine();
                Console.WriteLine(" Enter the id of  Horror_Book\n");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" Enter the description of Horror_Book \n");
                string? description = Console.ReadLine();
                Console.WriteLine(" Enter the price of Horror_Book \n");
                double price = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" Enter the  promotion of Horror_Book \n");
                int promotion = Convert.ToInt32(Console.ReadLine());
                Horror_Book Horror_Book = new Horror_Book(promotion, name, id, description, price);
                _inventory.add_in_Inventory(Horror_Book);
                Console.WriteLine(" Successfuly Added in Point_of_sale \n");
            }
            else if (select == 5)
            {
                Console.WriteLine(" Enter the name of Historical_Book \n");
                string? name = Console.ReadLine();
                Console.WriteLine(" Enter the id of Historical_Book \n");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" Enter the description of Historical_Book \n");
                string? description = Console.ReadLine();
                Console.WriteLine(" Enter the price of Historical_Book \n");
                double price = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" Enter the bundel offer nof Historical_Book \n");
                int bundel_offer = Convert.ToInt32(Console.ReadLine());
                Historical_Book Historical_Book =new Historical_Book(bundel_offer, name, id, description, price);
                _inventory.add_in_Inventory(Historical_Book);
                Console.WriteLine(" Successfuly Added in Point_of_sale \n");
            }
        }
         
        public void listupdate()
        {
            Console.WriteLine(" Press 1 to add Sci_Fi_Book\n");
            Console.WriteLine(" Press 2 to add Westerns_Book \n");
            Console.WriteLine(" Press 3 to add Classics_Book \n");
            Console.WriteLine(" Press 4 to add Horror_Book \n");
            Console.WriteLine(" Press 5 to add Historical_Book \n");
            int select = Convert.ToInt32(Console.ReadLine());
            if (select == 1)
            {
                Console.WriteLine(" Enter the name of Sci_Fi_Book \n");
                string? name = Console.ReadLine();
                Console.WriteLine(" Enter the id of Sci_Fi_Book \n");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" Enter the description of Sci_Fi_Book \n");
                string? description = Console.ReadLine();
                Console.WriteLine(" Enter the price of Sci_Fi_Book \n");
                double price = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" Enter the Pecentage discount nof Sci_Fi_Book \n");
                int discount = Convert.ToInt32(Console.ReadLine());
                Sci_Fi_Book Sci_Fi_Book = new Sci_Fi_Book(discount, name, id, description, price);
                _inventory.updateliste(Sci_Fi_Book);
                Console.WriteLine(" Successfuly updateliste in Point_of_sale \n");
            }
            else if (select == 2)
            {
                Console.WriteLine(" Enter the name of Westerns_Book \n");
                string? name = Console.ReadLine();
                Console.WriteLine(" Enter the id of Westerns_Book \n");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" Enter the description of Westerns_Book \n");
                string? description = Console.ReadLine();
                Console.WriteLine(" Enter the price of Westerns_Book \n");
                double price = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" Enter the Pecentage tex nof Westerns_Book \n");
                int tex = Convert.ToInt32(Console.ReadLine());
                Westerns_Book Westerns_Book = new Westerns_Book(tex, name, id, description, price);
                _inventory.updateliste(Westerns_Book);
                Console.WriteLine(" Successfuly updateliste in Point_of_sale \n");
            }
            else if (select == 3)
            {
                Console.WriteLine(" Enter the name of Classics_Book \n");
                string? name = Console.ReadLine();
                Console.WriteLine(" Enter the id of Classics_Book \n");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" Enter the description of Classics_Book \n");
                string? description = Console.ReadLine();
                Console.WriteLine(" Enter the price of Classics_Book \n");
                double price = Convert.ToInt32(Console.ReadLine());
                // Console.WriteLine(" Enter the expry date of Classics_Book \n");
                DateTime dateTime = new DateTime(17, 12, 2021);
                Classics_Book Classics_Book = new Classics_Book(dateTime, name, id, description, price);
                _inventory.updateliste(Classics_Book);
                Console.WriteLine(" Successfuly updateliste in Point_of_sale \n");
            }
            else if (select == 4)
            {
                Console.WriteLine(" Enter the name of Horror_Book \n");
                string? name = Console.ReadLine();
                Console.WriteLine(" Enter the id of  Horror_Book\n");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" Enter the description of Horror_Book \n");
                string? description = Console.ReadLine();
                Console.WriteLine(" Enter the price of Horror_Book \n");
                double price = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" Enter the  promotion of Horror_Book \n");
                int promotion = Convert.ToInt32(Console.ReadLine());
                Horror_Book Horror_Book = new Horror_Book(promotion, name, id, description, price);
                _inventory.updateliste(Horror_Book);
                Console.WriteLine(" Successfuly updateliste in Point_of_sale \n");
            }
            else if (select == 5)
            {
                Console.WriteLine(" Enter the name of Historical_Book \n");
                string? name = Console.ReadLine();
                Console.WriteLine(" Enter the id of Historical_Book \n");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" Enter the description of Historical_Book \n");
                string? description = Console.ReadLine();
                Console.WriteLine(" Enter the price of Historical_Book \n");
                double price = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" Enter the bundel offer nof Historical_Book \n");
                int bundel_offer = Convert.ToInt32(Console.ReadLine());
                Historical_Book Historical_Book = new Historical_Book(bundel_offer, name, id, description, price);
                _inventory.updateliste(Historical_Book);
                Console.WriteLine(" Successfuly updateliste in Point_of_sale \n");
            }
        }

        public void count_product()
        {
            int a=_inventory.count();
            Console.WriteLine(a);
        
        }

        public void display_product()
        {
            _inventory.show_all_item();
        }
        public void sale()
        {
            _inventory.sale_product();
        }
    }
}
