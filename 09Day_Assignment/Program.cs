using System;
using System.Linq;          


using _09Day_Assignment.Dal;
using _09Day_Assignment.Model;

namespace _09Day_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserDAL dAL = new UserDAL();
            while (true)
            {
                Console.WriteLine("1.Login");
                Console.WriteLine("2.Create User");
                Console.WriteLine("Enter Choice : ");
                int ch = Convert.ToInt32(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        Console.WriteLine("Enter Email: ");
                        String email = Console.ReadLine();
                        Console.WriteLine("Enter Password: ");
                        String password = Console.ReadLine();

                        var validUser = dAL.GetUserByEmailAndPassword(email, password);
                        if (validUser != null)
                            Console.WriteLine("Login successful");
                        else
                            Console.WriteLine("Invalid username or password");

                        break;

                    case 2: 
                        User user = new User();

                        Console.Write("Enter Email: ");
                        user.Email = Console.ReadLine();

                        
                        if (!user.Email.Contains("@gmail.com"))
                        {
                            Console.WriteLine("Invalid email! Email must be a gmail address.");
                            break;  
                        }

                        Console.Write("Enter Password: ");
                        user.Password = Console.ReadLine();

                        int rows = dAL.CreateUser(user);
                        Console.WriteLine(rows > 0
                            ? "User created successfully"
                            : "Error creating user");
                        break;


                }
            }
        }
    }
}