using System.Drawing;

namespace TrainingProgramming.OOP
{
    public class Book
    {
        public string title;
        public string author;
        public int noOfPages;
        public bool isBorrowed;

        public Book(string title, string author)
        {
            this.title = title;
            this.author = author;
            isBorrowed = false;

        }

        public Book(string title, string author, int noOfPages, bool isBorrowed)
        {
            this.title=title;
            this.author = author;
            this.noOfPages=noOfPages;
            this.isBorrowed=isBorrowed;
        }

        public void BorrowBook()
        {
            //check if book is not borrowed already
            if (!isBorrowed)
            {
                isBorrowed = true;
                Console.WriteLine($"The book '{title}' has been borrowed.");
            }
            else
            {
                Console.WriteLine($"The book '{title}' is already borrowed");
            }
        }
        public void DisplayDetails()
        {

            Console.WriteLine($"The title of the book: {title}");
            Console.WriteLine($"The author of the book: {author}");
            Console.WriteLine($"The number of pages of the book: {noOfPages}");
            Console.WriteLine($"The book status: {isBorrowed}");
        }




        public void ReturnBook()
        {
            //check if book is indeed borrowed
            if (isBorrowed)
            {
                isBorrowed = false;
                Console.WriteLine($"The book '{title}' has been returned.");
            }
            else
            {
                Console.WriteLine($"The book '{title}' was not borrowed.");
            }
        }
    }
}
