namespace Day04_Delegates
{
    internal class Program
    {

        public delegate void AddDelegate(int x, int y);
        public delegate void SquareDel(int x);
        public delegate void sayHello();
        public delegate void sayHi();
        static void Main(string[] args)
        {
            CMath cMath = new CMath();
            AddDelegate addDelegate = new AddDelegate(cMath.Add);
            SquareDel square = new SquareDel(cMath.Square);

            MyClass myclass = new MyClass();
            sayHello del1 = new sayHello(myclass.sayHello);
            sayHi del2 = new sayHi(myclass.sayHi);


            addDelegate(5, 8);
            square(8);

        }
    }

    public class CMath
    {
        public void Add(int x, int y)
        {
            Console.WriteLine(x + y);
        }
        public void Square(int x)
        {
            Console.WriteLine(x);
        }
    }

    public class MyClass
    {

        public void sayHello()
        {
            Console.WriteLine("Hello");
        }
        public void sayHi()
        {
            Console.WriteLine("Hii");
        }
    }
}
 
