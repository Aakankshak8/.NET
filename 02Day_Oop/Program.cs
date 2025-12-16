using System.Threading.Channels;
using static _02Day_Oop.Program;

namespace _02Day_Oop
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your choice of drink: 1-> Cold Drink  2->Soft Drink");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    IDrink drink = new SoftDrink();
                    drink.getDrink();
                    break;
                case 2:
                    IDrink drink1=new HotDrink();
                    drink1.getDrink();
                    break;
                default:
                    Console.WriteLine("Enter valid Input");
                    break;

            }

        }

        public interface IDrink {
            void getDrink();
        }
        public class SoftDrink : IDrink {
            public void getDrink()
            {

                Console.WriteLine("Enjoy your cold drink");
            }
        }
        public class HotDrink: IDrink {
            public void getDrink()
            {
                Console.WriteLine("Enjoy your soft drink");
            }
        }



    }
}