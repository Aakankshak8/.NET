namespace _02Day_Inheritance2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animals animals = new Cats();
            animals.color = "White";
            animals.limbs = 4;
            animals.name = "Persian Cat";
            Cats cats = new Cats();
            cats.age = 9;
            Console.WriteLine(animals.color);
            Console.WriteLine("{1} has {0} limbs", animals.limbs, animals.name);
            Console.WriteLine(cats.age);
        }
    }
}