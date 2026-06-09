//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Security.Authentication.ExtendedProtection.Configuration;
//using System.Security.Principal;
//using System.Text;
//using System.Threading.Tasks;

//namespace Parameter_Passing
//{
//    internal class Program
//    {
//        class student
//        {
//            int sid;
//            string sname;
//            int sage;
//            int total;
//            int avg;

           
//            public void studentdisplay( out int sid, string sname, int sage)
//            {
//                sid = 101;
//                Console.WriteLine("student id is " + sid);
//                Console.WriteLine("student name is " + sname);
//                Console.WriteLine("student age is " + sage);

//            }
//            public void marksdisplay( ref int m1,int m2,int m3)
//            {
                
//                total = m1 + m2 + m3;
//                avg = (m1 + m2 + m3) / 3;
//                if(avg >= 90)
//                {
//                    Console.WriteLine("Grade A");
//                }
//                else if (avg >= 80)
//                {
//                    Console.WriteLine("Grade B");
//                }
//                else if (avg >= 35)
//                {
//                    Console.WriteLine("Grade C");
//                }
//                else  
//                {
//                    Console.WriteLine("Grade F");
//                }
//            }

//        }
        
//        static void Main(string[] args)
//        {
//            student obj = new student();
//            int m1 = 85;
//            obj.marksdisplay(ref m1,90,90);
//            int sid=105;
//            obj.studentdisplay( out sid,"rama",17);
//        }
//    }
//}
