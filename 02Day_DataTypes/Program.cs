namespace _02Day_DataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Object ob1 = new Object();
            double d = 13.54;

            int x = 13;
            ob1 = x;
            Console.WriteLine(ob1);
            x = Convert.ToInt32(d);
            ob1 = x;
            Console.WriteLine(ob1);

            String str = Convert.ToString(ob1);
            Console.WriteLine(str);
            char c = 'A';
            Console.WriteLine("x : {0} d : {1} c:{2}", x, d, c);
        }
    }
}