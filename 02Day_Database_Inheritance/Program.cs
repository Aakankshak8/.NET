using System;

namespace _02Day_Database_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Choice: 1 -> MySqlServer, 2 -> SqlServer");
            int ch = Convert.ToInt32(Console.ReadLine());

            DataFactory df = new DataFactory();
            IDatabase dbs = df.GetDatabase(ch);

            if (dbs == null)
            {
                Console.WriteLine("Invalid Database choice");
                return;
            }

            Console.WriteLine("Enter the Option: 1 -> Insert, 2 -> Delete, 3 -> Update");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    dbs.Insert();
                    break;

                case 2:
                    dbs.Delete();
                    break;

                case 3:
                    dbs.Update();
                    break;

                default:
                    Console.WriteLine("Enter Valid choice");
                    break;
            }
        }
    }

  
    public interface IDatabase
    {
        void Insert();
        void Update();
        void Delete();
    }


    public class DataFactory
    {
        public IDatabase GetDatabase(int db)
        {
            switch (db)
            {
                case 1:
                    return new MySqlServer();

                case 2:
                    return new SqlServer();

                default:
                    return null;
            }
        }
    }

  
    public class SqlServer : IDatabase
    {
        public void Insert()
        {
            Console.WriteLine("Inside Insert Of SqlServer");
        }

        public void Update()
        {
            Console.WriteLine("Inside Update Of SqlServer");
        }

        public void Delete()
        {
            Console.WriteLine("Inside Delete Of SqlServer");
        }
    }

 
    public class MySqlServer : IDatabase
    {
        public void Insert()
        {
            Console.WriteLine("Inside Insert Of MySqlServer");
        }

        public void Update()
        {
            Console.WriteLine("Inside Update Of MySqlServer");
        }

        public void Delete()
        {
            Console.WriteLine("Inside Delete Of MySqlServer");
        }
    }
}
