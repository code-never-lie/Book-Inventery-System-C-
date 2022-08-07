
using Assigment_number_1;

Console.WriteLine("Enter the Storekeeper Name ");
string name=Console.ReadLine();
Storekeeper storekeeper = new Storekeeper(name);
storekeeper.show_inventory();
char again;
do 
{
    Console.WriteLine("Enter 1 for create Book in Point_of_sale ");
    Console.WriteLine("Enter 2 for updatelist of Book in Point_of_sale "); 
    Console.WriteLine("Enter 3 for display_product of Book in Point_of_sale ");
    Console.WriteLine("Enter 4 for count_product of Book in Point_of_sale ");
    Console.WriteLine("Enter 5 for sale of Book from Point_of_sale ");
    Console.WriteLine("Enter 6 for Exite Programe");
    int count = Convert.ToInt32(Console.ReadLine());
    switch (count)
    {
        case 1:
            storekeeper.create_new_item();
            break;
        case 2:
            storekeeper.listupdate();
            break;   
        case 3:
            storekeeper.display_product();
            break;
        case 4:
            storekeeper.count_product();
            break;
        case 5:
            storekeeper.sale();
            break;
        case 6:
            System.Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Invalid Input ");
            break;
    }
    Console.WriteLine("Do you want run again Programm press Y/y  ");
    again = Console.ReadLine()[0];
} while (again =='Y'|| again=='y');



