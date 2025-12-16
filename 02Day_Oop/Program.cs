using System.Threading.Channels;
using static _02Day_Oop.Program;

namespace _02Day_Oop
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            #region MyRegion
            //Console.WriteLine("Enter your choice of drink: 1-> Cold Drink  2->Soft Drink");
            //int choice = Convert.ToInt32(Console.ReadLine());

            //switch (choice)
            //{
            //    case 1:
            //        IDrink drink = new SoftDrink();
            //        drink.getDrink();
            //        break;
            //    case 2:
            //        IDrink drink1=new HotDrink();
            //        drink1.getDrink();
            //        break;
            //    default:
            //        Console.WriteLine("Enter valid Input");
            //        break;

            //}

            #endregion

            MyMath myMath = new MyMath();
            myMath.Add(6, 3);
            myMath.Mult(6, 3);
            myMath.log("Hello");

            myMath.Div(6, 3);



        }

        #region MyRegion
        //public interface IDrink
        //{
        //    void getDrink();
        //}
        //public class SoftDrink : IDrink
        //{
        //    public void getDrink()
        //    {

        //        Console.WriteLine("Enjoy your cold drink");
        //    }
        //}
        //public class HotDrink : IDrink
        //{
        //    public void getDrink()
        //    {
        //        Console.WriteLine("Enjoy your soft drink");
        //    } 

        //}
        #endregion

        public interface IX
        {
            public void Add(int a, int b)
            {
                Console.WriteLine(a + ", " + b);
            }
            public void Sub(int a, int b)
            {
                Console.WriteLine(a - b);
            }
        }
        public interface IY
        {
            public void Add(int a, int b);
            public void Mult(int a, int b);

        }
        public interface IDemo
        {
            public void Div(int a, int b);

            public void log(String msg);

        }
        public class MyMath : IY, IDemo

        {
            public void Div(int a, int b)
            {
                Console.WriteLine(a / b);
            }
            public void log(String msg)
            {
                Console.WriteLine(msg);

            }

            public void Add(int a, int b)
            {
                Console.WriteLine(a + b);
            }
            public void Mult(int a, int b)
            {
                Console.WriteLine(a * b);
            }


        }



    }
}