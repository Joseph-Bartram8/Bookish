using Bookish_dataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookish
{
    class Program
    {
        static void Main(string[] args)
        {
            LibraryRepository repository = new LibraryRepository();
            int answer = 0;

            while (answer == 0 || answer > 4)
            {
                try
                {
                    Console.WriteLine("Enter what you would like to do:\n");
                    Console.WriteLine("1.) print list of books\n2.)checkout book\n3.)checkin book\n4.)Exit");
                    answer = Convert.ToInt32(Console.ReadLine());
                    if (answer > 4 || answer <= 0)
                    {
                        Console.WriteLine("Incorrect value, please enter a value between 1 and 4!");
                    }
                    else
                    {
                        switch (answer)
                        {
                            case 1:
                                Console.WriteLine("The book table consists of: ");
                                foreach (var book in repository.GetAllBooks())
                                {
                                    Console.WriteLine("\n\n{0}, {1}, {2}\n", book.BookId, book.Title, book.Author);
                                }
                                answer = 0;
                                break;
                            case 3:
                                string User = "Joseph";
                                foreach (Book copy in repository.GetCopiesBorrowedByUser(User))
                                {
                                    Console.WriteLine(copy.BookId);
                                }
                                break;
                            case 4:
                                Console.WriteLine("Coming soon");
                                answer = 0;
                                break;
                            case 5:
                                Console.WriteLine("Press enter to exit the program: ");
                                Console.ReadLine();
                                break;
                        }
                    }
                    
                }
                catch
                {
                    Console.WriteLine("Incorrect value, please enter a number between 1 and 4!");
                    answer = 0;
                }
                
            }
            
            
            
        }
    }
}
