using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMath
{
    public class Class1
    {

        public void add(int x, int y)
        {
            Console.WriteLine($"Addition is {x + y}");
        }
        private void sub(int x, int y)
        {
            Console.WriteLine($" Substraction is  {x - y}");
        }
        protected void mul(int x, int y)
        {
            Console.WriteLine($"Product is {x * y}");
        }
        internal void Div(int x, int y)
        {
            Console.WriteLine($"Div = {x / y}");
        }

        protected internal void Square(int x)
        {
            Console.WriteLine($"Square = {x * x}");
        }
    }
    public class AdvMath : Class1
    {

        public void adv_Wrapper()
        {
            base.Square(5);
            base.add(25, 56);
            base.Div(500, 10);
            base.mul(500, 10);
        }
    }
}
