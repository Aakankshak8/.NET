namespace _03Day_Sealed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AdvanceMath advanceMath = new AdvanceMath();
            advanceMath.square(10);
            AdvanceMath2 advanceMath2 = new AdvanceMath2();
            advanceMath2.square(12);

        }
    }

    public class AdvanceMath
    {
        public virtual void square(int x)
        {
            Console.WriteLine(x * x);
        }
    }

    public class AdvanceMath2 : AdvanceMath
    {
        public sealed override void square(int x)
        {
            Console.WriteLine(x * x * 100);
        }

    }

    public class MyMath : AdvanceMath2
    {

        //public override int square( int x)
        //{
        //    return x * x * 100;
        //}
    }

}