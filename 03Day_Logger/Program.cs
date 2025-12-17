namespace _03Day_Logger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter your Db choice. 1. SqlServer, 2. MySql Server, 3. Oracle Server");
                int dbChoice = Convert.ToInt32(Console.ReadLine());
                DataBaseFactory factory = new DataBaseFactory();
                DataBase someDatabaseObject = factory.GetSomeDatabase(dbChoice);
                Console.WriteLine("Enter db operation choice : 1. Insert, 2. Update, 3. Delete");
                int opChoice = Convert.ToInt32(Console.ReadLine());
                switch (opChoice)
                {
                    case 1:
                        someDatabaseObject.Insert();
                        break;
                    case 2:
                        someDatabaseObject.Update();
                        break;
                    case 3:
                        someDatabaseObject.Delete();
                        break;
                    default:
                        Console.WriteLine("Invalid Db operation Choice");
                        break;
                }

                Console.WriteLine("Do you want to continue? y/n");
                string ynChoice = Console.ReadLine();
                if (ynChoice == "n")
                {
                    break;
                }
            }
        }
    }

    public class DataBaseFactory
    {
        DataBase db = null;

        public DataBase GetSomeDatabase(int dbChoice)
        {
            switch (dbChoice)
            {
                case 1:
                    db = new SQLServer();
                    break;
                case 2:
                    db = new MySQLServer();
                    break;
                case 3:
                    db = new OracleServer();
                    break;
                default:
                    db = null;
                    break;
            }
            return db;
        }
    }
    public abstract class DataBase
    {
        public logger _logger = null;
        public DataBase()
        {
            _logger = logger.GetLogger();
        }
        protected abstract void DoInsert();
        protected abstract void DoUpdate();
        protected abstract void DoDelete();
        protected abstract string GetDataBaseName();

        public void Insert()
        {
            DoInsert();
            _logger.Log($"Insert From {GetDataBaseName()} done.");
        }
        public void Update()
        {
            DoUpdate();
            _logger.Log($"Update From {GetDataBaseName()} done.");
        }
        public void Delete()
        {
            DoDelete();
            _logger.Log($"Delete From {GetDataBaseName()} done.");
        }
    }

    public class MySQLServer : DataBase
    {
        protected override string GetDataBaseName()
        {
            return "MySQL Server";
        }
        protected override void DoDelete()
        {
            Console.WriteLine("Record Deleted in MySql Successfylly");

        }

        protected override void DoInsert()
        {
            Console.WriteLine("Record Inserted in MySql Successfylly");
        }

        protected override void DoUpdate()
        {
            Console.WriteLine("Record Updated in MySql Successfylly");
        }
    }

    public class SQLServer : DataBase
    {
        protected override string GetDataBaseName()
        {
            return "SQL Server";
        }
        protected override void DoDelete()
        {
            Console.WriteLine("Record Deleted in Sql Successfylly");

        }

        protected override void DoInsert()
        {
            Console.WriteLine("Record Inserted in Sql Successfylly");
        }

        protected override void DoUpdate()
        {
            Console.WriteLine("Record Updated in Sql Successfylly");
        }
    }

    public class OracleServer : DataBase
    {

        protected override void DoDelete()
        {
            Console.WriteLine("Record Deleted in Oracle Successfylly");

        }

        protected override void DoInsert()
        {
            Console.WriteLine("Record Inserted in Oracle Successfylly");
        }

        protected override void DoUpdate()
        {
            Console.WriteLine("Record Updated in Oracle Successfylly");
        }

        protected override string GetDataBaseName()
        {
            return "Oracle Server";
        }
    }


    public class logger
    {
        private static logger _logger = new logger();

        private logger()
        {
            Console.WriteLine("Logger Object is created for the first time!..");

        }

        public static logger GetLogger()
        {
            return _logger;
        }
        public void Log(string message)
        {

            Console.WriteLine("---Logged at {0}, message : {1}", DateTime.Now.ToString(), message);
        }
    }
    
}