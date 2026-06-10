using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameter_Passing
{
    class student
    {
        public void studentdisplay<T, K>(T sid, K sname)
        {
            Console.WriteLine("student id is " + sid);
            Console.WriteLine("student name is " + sname);
        }
        public void updateage<T>(ref T age)
        {
            age = (dynamic)age + 1;
            Console.WriteLine("student updatedage is " + age);
        }
        public void studentmarks<T>(T m1, T m2, T m3, out T total)
        {
            total = (dynamic)m1 + (dynamic)m2 + (dynamic)m3;
            Console.WriteLine("total marks is " + total);
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            student obj = new student();
            obj.studentdisplay(3, "raju");
            int age = 22;
            obj.updateage(ref age);
            int x;
            obj.studentmarks(89, 99, 79, out x);
        }
    }
}

