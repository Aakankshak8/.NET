namespace _02Day_Inheritance1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Base baseobj = new Base();
            baseobj.method1();

            Derived derivedobj = new Derived();
            derivedobj.method2();
        }
    }
}