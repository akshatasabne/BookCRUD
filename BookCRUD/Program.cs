using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCRUD
{
   
public class Book
{
   
    static void Main(string[] args)
    {
        BookCRUD1 crud = new BookCRUD1();
        int option = 0;
        do
        {
            Console.WriteLine("1. Add Book details");
            Console.WriteLine("2. Update Book Detils");
            Console.WriteLine("3. Delete Book Details");
            Console.WriteLine("4.Display Book Details");
            int option1 = Convert.ToInt32(Console.ReadLine());
            switch (option1)
            {
                case 1:
                    Book1 b1 = new Book1();
                    Console.WriteLine("Enter id");
                    b1.id = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter name");
                    b1.name = Console.ReadLine();
                    Console.WriteLine("Enter author name");
                    b1.aname = Console.ReadLine();
                    Console.WriteLine("Enter Price");
                    b1.price = Convert.ToDouble(Console.ReadLine());
                    crud.AddBook(b1);

                    break;
                case 2:
                    Book1 b2 = new Book1();
                    Console.WriteLine("Enter id");
                    b2.id = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter name");
                    b2.name = Console.ReadLine();
                    Console.WriteLine("Enter author name");
                    b2.aname = Console.ReadLine();
                    Console.WriteLine("Enter Price");
                    b2.price = Convert.ToDouble(Console.ReadLine());
                    crud.AddBook(b2);
                    break;
                case 3:
                    Book1 b3 = new Book1();
                    Console.WriteLine("Enter id to remove");
                    int id = Convert.ToInt32(Console.ReadLine());
                    break;
                case 4:
                    List<Book1> list = new List<Book1>();
                    foreach (Book1 item in list)
                    {
                        Console.WriteLine($"{item.id} {item.name} {item.aname} {item.price}");


                        }
                    Console.WriteLine("Press 1 for continue ");
                    option = Convert.ToInt32(Console.ReadLine());
                    break;
            }



        } while (option == 1);
    }
}
}