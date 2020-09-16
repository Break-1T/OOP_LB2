using MainController._2_nd_lb_classes;
using System;

namespace MainController
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new string('-', 30));
            Console.Write("Введите номер задания: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(new string('-', 30));
            switch (n) 
            {
                case 1:
                    #region 1-е Задание
                    Adress MyAdress = new Adress(93105, "Ukraine", "Lisichansk", "Kommunalnaya", 35, 25);
                    MyAdress.ShowInfo();
                    #endregion
                    break;
                case 2:
                    #region 2-е Задание
                    Rectangle MyRectangle = new Rectangle(3488.466, 15.12);

                    Console.WriteLine($"Perimeter: {MyRectangle.Perimeter}");
                    Console.WriteLine($"Area: {MyRectangle.Area}");
                    #endregion
                    break;
                case 3:
                    #region 3-е Задание
                    Book MyBook = new Book(
                        new Title("Полное руководство по C# 4.0"),
                        new Author("Герберт Шилдт"),
                        new Content("Руководство по программированию"));

                    MyBook.Show();
                    #endregion
                    break;
                case 5:
                    #region 5-е Задание
                    User MyUser = new User("User1234", "Taras", "Sergeevich", 18, "15.09.2020");
                    MyUser.ShowInfo();
                    #endregion
                    break;
                case 6:
                    #region 6-е Задание
                    Converter converter = new Converter(10, 10, 10, 28);
                    converter.ValueConverter();
                    #endregion
                    break;
                case 7:
                    #region 7-е Задание
                    Employee employee = new Employee("Иван", "Степанин");
                    employee.GetInfo();
                    #endregion
                    break;
                case 8:
                    #region 8-е Задание
                    Invoice invoice = new Invoice(16847, "Taras", "IBM");
                    invoice.Price();
                    #endregion
                    break;
                default:
                    return; 
            }
            Console.WriteLine(new string('-', 30));

        }
    }
}
