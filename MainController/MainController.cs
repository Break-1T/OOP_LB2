using MainController._2_nd_lb_classes;
using System;

namespace MainController
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------------------");

            Adress MyAdress = new Adress(93105,"Ukraine","Lisichansk","Kommunalnaya",35,25);
            MyAdress.ShowInfo();

            Console.WriteLine("------------------------------");

            Rectangle MyRectangle = new Rectangle(3488.466, 15.12);

            Console.WriteLine($"Perimeter: {MyRectangle.Perimeter}");
            Console.WriteLine($"Area: {MyRectangle.Area}");

            Console.WriteLine("------------------------------");

            Book MyBook = new Book(
                new Title("Полное руководство по C# 4.0"),
                new Author("Герберт Шилдт"),
                new Content("Руководство по программированию"));

            MyBook.Show();

            Console.WriteLine("------------------------------");

            User MyUser = new User("User1234","Taras","Sergeevich",18);
            MyUser.ShowInfo();

            Console.WriteLine("------------------------------");

        }
    }
}
