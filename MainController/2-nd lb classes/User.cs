using System;

namespace MainController._2_nd_lb_classes
{
    class User
    {
        public User(string login, string name, string lastName, int age)
        {
            Login = login;
            Name = name;
            LastName = lastName;
            Age = age;
        }

        public string Login { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        private string DateOfFilling = DateTime.Today.ToString("dd.MM.yyyy");

        public void ShowInfo()
        {
            Console.WriteLine($"Login: {Login}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Last Name: {LastName}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Date of filling: {DateOfFilling}");
        }
    }
}
