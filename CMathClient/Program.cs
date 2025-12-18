using _04Day_CMathh;

namespace CMathClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                CMath cmath = new CMath();
                cmath.Add(5, 12);
                AdvMath adv = new AdvMath();
                adv.Add(5, 13);
                adv.Adv_WrapperMethod();

            }
        }
    }
}