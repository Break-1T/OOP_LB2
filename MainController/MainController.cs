using System;

namespace MainController
{
    class Program
    {
        static void Main(string[] args)
        {
            Adress MyAdress = new Adress(93105,"Ukraine","Lisichansk","Kommunalnaya",35,25);
            MyAdress.ShowInfo();
            Console.WriteLine("------------------------------");
            Rectangle MyRectangle = new Rectangle(3488.466, 15.12);
            Console.WriteLine($"Perimeter: {MyRectangle.Perimeter}");
            Console.WriteLine($"Area: {MyRectangle.Area}");
            Console.WriteLine("------------------------------");
            Book MyBook = new Book("MyBook");
            MyBook.Show();
            Title MyTitle = new Title("MyTitle");
            MyTitle.Show();
            Author MyAuthor = new Author("MyAuthor");
            MyAuthor.Show();
            Content MyContent = new Content("MyContent");
            MyContent.Show();
            Console.WriteLine("------------------------------");
        }
    }
}
