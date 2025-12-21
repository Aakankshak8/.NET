using System.Reflection;

namespace _06Day_Reflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string assemblyPath = "D:\\IET\\.NET\\Solution1\\CMath\\bin\\Debug\\CMath.dll";

            Assembly asm = Assembly.LoadFrom(assemblyPath);

            Type[] allTypes = asm.GetTypes();

            for (int i = 0; i < allTypes.Length; i++)
            {
                Type type = allTypes[i];


                object dynamicallyCreatedObject = asm.CreateInstance(type.FullName);


                string methodSignature = "";

                MethodInfo[] allMethods = type.GetMethods();

                for (int j = 0; j < allMethods.Length; j++)
                {
                    MethodInfo method = allMethods[j];

                    methodSignature = method.ReturnType.ToString() + " " + method.Name + "(";

                    ParameterInfo[] allParameters = method.GetParameters();
                    for (int k = 0; k < allParameters.Length; k++)
                    {
                        ParameterInfo parameter = allParameters[k];

                        methodSignature = methodSignature + parameter.ParameterType.ToString() + " " + parameter.Name + ",";
                    }


                    object[] inputValues = new object[allParameters.Length];

                    for (int p = 0; p < allParameters.Length; p++)
                    {
                        ParameterInfo para = allParameters[p];
                        Console.WriteLine($"Enter value for {para.Name} of type = {para.ParameterType.ToString()}");

                        inputValues[p] = Convert.ChangeType(Console.ReadLine(), para.ParameterType);
                    }


                    methodSignature = methodSignature.TrimEnd(',') + ")";
                    Console.WriteLine(methodSignature);

                    object? result = type.InvokeMember(
                        method.Name,
                        BindingFlags.Public |
                        BindingFlags.Instance |
                        BindingFlags.InvokeMethod,
                        null,
                        dynamicallyCreatedObject,
                        inputValues
                        );
                    Console.WriteLine($"{method.Name} = {result}");
                }
            }
        
    }
    }
}