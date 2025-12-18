namespace _04Day_EventDelegators
{

    public delegate void MyHandler(int mrk);
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your marks");

            Student student = new Student();

            student._Fail += student.student_Fail;
            student._Pass += student.student_Pass;

            int marks = Convert.ToInt32(Console.ReadLine());

            student.marks = marks;
        }
    }

    public class Student
    {
        public event MyHandler _Pass;
        public event MyHandler _Fail;

        private int _marks;

        public int marks
        {
            set
            {
                _marks = value;

                if (_marks > 40)
                    _Pass(_marks);
                else
                    _Fail(_marks);
            }
            get { return _marks; }
        }

        public void student_Pass(int marks)
        {
            Console.WriteLine($"Congratulations!!! You have passed with {marks} marks!");
        }

        public void student_Fail(int marks)
        {
            Console.WriteLine($"Congratulations!!!, you have failed with {marks} marks.");
        }
    }
    }
