using _07Day_BVSAttribute;
using System.Reflection;

namespace _07Day_MyApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string asmPath = @"C:\Users\IET\Desktop\.Net\Solution1\07Day_LyLib\bin\Debug\07Day_LyLib.dll";

            Assembly asm = Assembly.LoadFrom(asmPath);
            Type[] allTypes = asm.GetTypes();
            for (int i = 0; i < allTypes.Length; i++)
            {
                Type type = allTypes[i];
                //Console.WriteLine(type.Name);
                Attribute[] allAttributes = type.GetCustomAttributes().ToArray();
                for (int j = 0; j < allAttributes.Length; j++)
                {
                    Attribute attr = allAttributes[j];
                    if (attr is BonaventureSystemsAttribute)
                    {
                        BonaventureSystemsAttribute bvsAttr = attr as BonaventureSystemsAttribute;

                        Console.WriteLine($"Class {type.Name} is developed by {bvsAttr.DeveloperName} of (c) {bvsAttr.CompanyName}");
                    }

                    if (attr is SerializableAttribute)
                    {
                        Console.WriteLine($"Class {type.Name} is marked as Serializable");
                    }
                }
            }


        }
    }
}
    