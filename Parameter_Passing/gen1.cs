//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Parameter_Passing
//{
//    class myclass
//    {
//        internal void display<T>(T u)
//        {
//            Console.WriteLine(u);
//        }
//        internal void add<t>(t a, t b)
//        {
//            Console.WriteLine("Value of a is " + a);
//            Console.WriteLine("Value of b is " + b);
//        }
//    }
//    internal class program
//    {
//        static void Main(string[] args)
//        {
//            myclass obj = new myclass();
//            obj.display(30);
//            obj.display<string>("Nvidia");
//            obj.display<bool>(true);
//            obj.display<double>(3.90);
//            obj.add<int>(40, 60);
//            obj.add<double>(4.98, 6.89);
//            obj.add("hello", "user");
//            obj.add<bool>(true, false);
//        }
//    }
//}

