//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Parameter_Passing
//{
//    internal class passingparameters
//    { 
//        class student
//        {
//            public void studentdisplay(int sid, string sname)
//            {
//                Console.WriteLine("student id is " + sid);
//                Console.WriteLine("student name is " + sname);
//            }
//            public void updateage(ref int age)
//            {
//                age += 1;
//                Console.WriteLine("student updatedage is " + age);
//            }
//            public void studentmarks(int m1, int m2, int m3, out int total)
//            {
//                total = m1 + m2 + m3;
//                Console.WriteLine("total marks is " + total);
//            }
//        }
//        class program
//        {
//            static void Main(string[] args)
//            {
//                student obj = new student();
//                obj.studentdisplay(3, "raju");
//                int age = 22;
//                obj.updateage(ref age);
//                int x;
//                obj.studentmarks(89, 99, 79, out x);
//            }
//        }
//    }
//}

