namespace _08Day_Properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Predicate Delegate
            Predicate<int> _even = x => x % 2 == 0;
            Predicate<int> _odd = x => x % 2 != 0;

            Console.WriteLine("enter a number: ");
            int no = Convert.ToInt32(Console.ReadLine());

            var evenresult = _even(no);
            var oddresult = _odd(no);
            Console.WriteLine($"for number : {no}--> evenresult : {evenresult}, oddresult : {oddresult}");
            #endregion

            #region Action DELEGATE
            //Action actionDel = new Action(delegate ()
            //{
            //    Console.WriteLine("Hello Hugh Jackman!");
            //});
            //actionDel();

            //Action del2 = delegate ()
            //{
            //    Console.WriteLine("Hello Tom Ellis!");
            //};
            //del2();

            //Action del3 = () =>
            //{
            //    Console.WriteLine("Hello Tom Ellis!");
            //};
            //del3();

            //Action del4 = () => Console.WriteLine("Hello Tom Holland!");
            //del4(); 
            #endregion

            #region Function Delegate
            //Func<int> func1 = delegate ()
            //                    {
            //                        return 1;
            //                    };
            //var result = func1();
            //Console.WriteLine(result);
            //Func<Double> func2 = delegate ()
            //{
            //    return 2;
            //};
            //var result1 = func2();
            //Console.WriteLine(result1);

            //Func<String> func3 = delegate ()
            //{
            //    return "Hello";
            //};
            //var result3 = func3();
            //Console.WriteLine(result3);   
            #endregion

            #region TResult Func<in T, out TResult>(T arg)
            //Func<int, bool> del5 = new Func<int, bool>(Check);

            //Func<int, bool> del = new Func<int, bool>(
            //                        delegate (int x)
            //                        {
            //                            return x % 2 == 0;
            //                        }
            //                     );

            //bool result = del(12);
            //Console.WriteLine(result);
            //Func<int, bool> del = new Func<int, bool>(x => x % 2 == 0);
            //bool result = del(12);
            //Console.WriteLine(result);

            //Predicate<int> _predicate1 = x => x % 2 == 0;
            //Predicate<int> _predicate2 = x => x % 2 != 0;
            //Predicate<int> _predicate3 = x => x == 12;
            //bool output = _predicate3(13);
            //Console.WriteLine(output);

            //Func<int, bool> del5 = new Func<int, bool>(_predicate3);
            //bool result2 = del5(12);
            //Console.WriteLine(result2); 
            #endregion

            //int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            #region In-built Where() Extension method

            //Console.WriteLine($"Sum = {arr.Sum()}");
            //Console.WriteLine($"Max = {arr.Max()}");

            //Predicate<int> _predicate1 = x => x == 5;
            //Func<int, bool> funcDel = new Func<int, bool>(_predicate1);

            //var result1 = arr.Where(funcDel);
            //foreach (var no in result1)
            //{
            //    Console.WriteLine(no);
            //}
            //-----------------------------------------
            //Predicate<int> _predicate2 = x => x % 2 == 0;
            //Func<int, bool> funcDel2 = new Func<int, bool>(_predicate2);

            ////var result2 = arr.Where(funcDel2);
            //var result2 = arr.Where(x => x % 2 == 0);

            //foreach (var no in result2)
            //{
            //    Console.WriteLine(no);
            //} 
            #endregion

            #region in-build Select() Extension Method
            //Func<int, int> func3 = new Func<int, int>(no => no * 2);
            ////var doubleArr = arr.Select(func3);
            //var doubleArr = arr.Select(no => no * 2);

            //foreach (int ele in doubleArr)
            //{
            //    Console.WriteLine(ele);
            //}
            #endregion

            //List<int> lstArr = arr.MySelect();

            ////Func<int, bool> predicate = x => x % 2 == 0;
            ////lstArr.MyWhere<int>(predicate);
            //var evenNumbers = lstArr.MyWhere<int>(x => x % 2 == 0);
            //foreach (var no in evenNumbers)
            //{
            //    Console.WriteLine(no);
            //}
            //var result = arr.MySelect().MyWhere<int>(x => x % 2 == 0);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
        }
        public static bool Check(int x)
        {
            return x % 2 == 0;
        }
    }
    public static class MyClass
    {
        public static List<T> MySelect<T>(this IEnumerable<T> source)
        {
            var list = new List<T>();
            foreach (var item in source)
            {
                list.Add(item);
            }
            return list;
        }

        public static IEnumerable<int> MyWhere<T>(this IEnumerable<int> source, Func<int, bool> predicate)
        {
            List<int> result = new List<int>();
            foreach (int no in source)
            {
                //if (no % 2 == 0)
                if (predicate(no))
                {
                    result.Add(no);
                }
            }
            return result;
        }
    }
}