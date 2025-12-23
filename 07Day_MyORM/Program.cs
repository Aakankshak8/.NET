using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Reflection;


namespace _07Day_MyORM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string asmPath = "D:\\IET\\.NET\\Solution1\\07Day_MyLib\\bin\\Debug\\07Day_MyLib.dll";

            Assembly asm = Assembly.LoadFrom(asmPath);
            Type[] allTypes = asm.GetTypes();

            foreach (Type type in allTypes)
            {
                string createTableQuery = "CREATE TABLE ";

                Attribute[] allAttributes = type.GetCustomAttributes().ToArray();

                foreach (Attribute attr in allAttributes)
                {
                    if (attr is TableAttribute tableAttr)
                    {
                        createTableQuery += tableAttr.TableName + " ( ";
                    }
                }

                PropertyInfo[] allProperties = type.GetProperties();

                foreach (PropertyInfo prop in allProperties)
                {
                    Attribute[] propAttr = prop.GetCustomAttributes().ToArray();

                    foreach (Attribute pAttr in propAttr)
                    {
                        if (pAttr is ColumnAttribute col)
                        {
                            createTableQuery += col.ColumnName + " " + col.ColumnType + ",";
                        }
                    }
                }

                createTableQuery = createTableQuery.TrimEnd(',') + " )";
                Console.WriteLine(createTableQuery);

                string filePath = "D:\\IET\\.NET\\Solution1\\07Day_MyORM\\SQLQuery\\CreateQuery.sql";
                File.AppendAllText(filePath, createTableQuery + Environment.NewLine);

                Console.WriteLine("Done.");
            }
        }
    }
}
