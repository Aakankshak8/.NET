namespace _04Day_Property
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.Eid = 10;
            int id = employee.Eid;
            employee.Ename = "Aakanksha";
            String sname = employee.Ename;
            Console.WriteLine($"Eid = {id}");
            Console.WriteLine($"Ename = {sname}");

        }
    }

    public class Employee
    {
        private String _Ename;
        private int _Eid;

        public int Eid
        {
            set
            {
                _Eid = value;
            }
            get
            {

                return _Eid;

            }
        }

        public String Ename
        {
            set
            {
                _Ename = value;
            }
            get
            {
                return _Ename;
            }
        }
    }
}