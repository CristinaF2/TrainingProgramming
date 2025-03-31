
namespace TrainingProgramming.OOP
{
    public class BookTest
    {
        [Test]
        public void TestMethod()
        {
            Book book = new Book("Pe aripile vantului", "Silviu Petrescu");
            book.DisplayDetails();
            Console.WriteLine();
            //borrow book
            book.BorrowBook();
            Console.WriteLine();
            //borrow again the same book -not possible
            book.BorrowBook();
            Console.WriteLine();
            //return book
            book.ReturnBook();
            Console.WriteLine();
            //book again the book
            book.BorrowBook();
            Console.WriteLine();

            Book book2 = new Book("Alba ca zapada", "Marin Petrescu", 269, true);
            book2.DisplayDetails();
            Console.WriteLine();
            //try to book a borrowed book
            book2.BorrowBook();
            Console.WriteLine();
            //return book
            book2.ReturnBook();
            Console.WriteLine();
            //borrow the book
            book2.BorrowBook();
            Console.WriteLine();

            Book book3 = new Book("Skyfall", "Ioana Petrescu", 111, false);
            book3.DisplayDetails();
            Console.WriteLine();
            //returneaza o carte ce nu a fost imprumutata
            book3.ReturnBook();
            Console.WriteLine();
        }


    }
}
