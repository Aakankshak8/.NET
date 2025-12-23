using _07Day_PartialClass;

namespace _07Day_PartialClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CMath cMath = new CMath();
            cMath.Add(7, 3);
            cMath.Mul(6, 3);



            #region Nullable Types [ ? = Nullable operator]
            // when database/anyone: returns null value for value type containers of c# (like int, double, bool, char, datetime etc) then it will create problem.
           // hence we need to create nullable type variables: nullable<t> name = null;
            string name = null;
            //int deptid = null; {error }

            int? deptid = null;
            //int? deptid = 232323;
            if (deptid.HasValue)
            {
                Console.WriteLine(deptid.Value);
            }
            else
            {
                Console.WriteLine("deptid = null");
            }


            Nullable<int> dept = null;
            //Nullable<int> dept = 1234;

            if (dept != null)
            {
                Console.WriteLine(dept.Value);
            }
            else
            {
                Console.WriteLine("dEPT IS NULLL");
            } 
            #endregion

            #region ObjectInitializer{}
            ////// We can initialize objects while declaring it using {} brackets, internally at backend - compiler will generate combinations of overloaded 
            /////constrctors syntaxes for us. This will keep our class clean and readable.
            //Demo demo = new Demo() { _id=100};

            //Console.WriteLine(demo._id);

            //Demo demo1 = new Demo() { _name = "Hugh Jackman", _id = 111 };
            //Console.WriteLine(demo1._name + " " + demo1._id);

            //Console.WriteLine("Enter name:");
            //string nm = Console.ReadLine();
            //Console.WriteLine("Enter description:");
            //string des = Console.ReadLine();

            //Demo demo2 = new Demo() { _name = nm, _description = des };

            //Console.WriteLine($"Name = {demo2._name}, Description= {demo2._description}"); 
            #endregion

            #region CollectionObjects
            //int[] arr= new int[3] { 1,2,3};
            //foreach (int  a in arr)
            //{
            //    Console.Write(a+" ");
            //}

            //string[] names = new string[] { "Timothy", "John", "Charlie", "Peter Parker" };
            //foreach (string ele in names)
            //{
            //    Console.WriteLine(ele);
            //}
            //// Collection Initializer Syntax combined with Object Initializer Syntax
            //List<Demo> listDemoObjects = new List<Demo>() {
            //    new Demo(){ _id = 1, _name= "Hugh Jackman", _description="Australian Actor"},
            //     new Demo(){ _id = 2, _name= "Tom Ellis", _description="Wellish Actor"},
            //};

            //foreach (Demo dm in listDemoObjects)
            //{
            //    Console.WriteLine($"Id= {dm._id}, Name = {dm._name}, Description = {dm._description}");
            //} 
            #endregion

            #region Auto-Properties
            ////Emp emp = new Emp() { EId = 101 };

            //Emp emp = new Emp()
            //{
            //    EId = 101,
            //    EName = "Hugh Jackman",
            //    isActive = true,
            //    Salary = 50000,
            //    DOJ = DateTime.Now,
            //    Projects = new List<string>() { "ORM", "Database Integration APIs", "Asp.Net MVC Core based application" }
            //};
            //Console.WriteLine($"DOJ = {emp.DOJ.ToString()}");
            //foreach (string str in emp.Projects)
            //{
            //    Console.WriteLine(str);
            //} 
            #endregion

            #region ImplicitType
            ////Test obj = new Test();
            ////Emp emp = obj.GetSomething(2) as Emp;

            ////int value = Convert.ToInt32(obj.GetSomething(1));

            ////object num = obj.GetSomething(null);
            ////if (num == null)
            ////{ }

            //// Implicit type is getting definitaion at compile time only
            //// A Temparory container

            //var i = 100;
            //var str = "Hello";

            //var emp = new Emp();

            ////var v1; // defination: unknown-> copiler error
            ////object obj;
            ////int j;

            //Test obj1 = new Test();
            //Console.WriteLine("Enter choice");
            //int ch = Convert.ToInt32(Console.ReadLine());
            //var result = obj1.GetSomething(ch);

            #endregion

            #region AnonymousTypes
            //Emp emp = new Emp() { EId = 1, EName = "Hugh Jackman" };
            //var emp2 = new Emp() { EId = 2, EName = "Tom Ellis" };
            //Console.WriteLine(emp2.GetType().ToString());
            //var emp3 = new Holder() { Id = 101, Name = "Timothy", Address = "LA" };
            //Console.WriteLine(emp3.GetType().ToString());

            //var emp4 = new Holder() { Id = 101, Address = "LA", Name = "Timothy" };
            //Console.WriteLine(emp4.GetType().ToString());

            // Anonymous Type :  a class without name
            //var v1 = new { Id = 101, Name = "John", Address = "Patna" };
            //Console.WriteLine(v1.GetType().ToString());

            //var v2 = new { Id = 102, Name = "Tony", Address = "Shivaji Nagar" };
            //Console.WriteLine(v2.GetType().ToString());

            //var v3 = new { Id = 102, Address = "Shivaji Nagar", Name = "Tony" };
            //Console.WriteLine(v3.GetType().ToString());

            //var v4 = new { Id = 102, Address = true, Name = "Tony" };
            //Console.WriteLine(v4.GetType().ToString());

            //// Complie time error: bcoz Anonymous Types properties are read-only.
            ////v4.Address = "Pune"; 
            //Console.WriteLine(v4.Address);

            //Console.WriteLine("Enter value for Id");
            //int id = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter value for name");
            //string nm = Console.ReadLine();

            //var v5 = new { CId = id, CName = nm };
            //Console.WriteLine($"You Entered : CId= {v5.CId}, Name= {v5.CName}"); 
            #endregion

        }
    }


    public class Holder
    {
        public int? Id { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
    }
    public class Test
    {
        //public void Demo(var ch)
        //{ 
        //}
        public object GetSomething(Nullable<int> choice)
        {
            if (choice == 1)
            {
                return 100;
            }
            else if (choice == 2)
            {
                return new Emp() { EId = 1, EName = "Timothy", isActive = false };
            }
            else
            {
                return null;
            }
        }
    }
    public class Emp
    {
        //private int _Id;

        //public int EId
        //{
        //    get { return _Id; }
        //    set { _Id = value; }
        //}
        // If there is a scenario where names of the private members does not matter: then we go for auto-property syntax: where compiler generates : Private Memebrs along with getter and setter methods for us. And we use or communicate with the help of public properties.
        // Please note: we can not do any kind of validations or changes using property syntax or by using private memeber names
        // Consider this as a temporary holder classes

        public int EId { get; set; }
        public string EName { get; set; }
        public bool isActive { get; set; }
        public double Salary { get; set; }
        public DateTime DOJ { get; set; }
        public List<string> Projects { get; set; }
        public Demo demo { get; set; }

    }
    public class Demo
    {
        public int _id;
        public string _name;
        public string _description;

        #region Mannually ctor writing code based on combinations of private fields initialization.
        public Demo()
        {

        }
        public Demo(int id)
        {
            _id = id;
        }
        public Demo(string nm)
        {
            _name = nm;
        }
        public Demo(int id, string nm)
        {
            _id = id;
            _name = nm;
        }
        public Demo(int id, string nm, string des)
        {
            _id = id;
            _name = nm;
            _description = des;
        }
        #endregion
    }
}