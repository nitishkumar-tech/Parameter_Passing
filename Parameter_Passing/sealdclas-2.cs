//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Parameter_Passing
//{
//   /* sealed*/ class ATM
//    {
//        protected double deposit;
//        public void DepositMoney(double amount)
//        {
//            deposit += amount;
//            Console.WriteLine("Money Deposited");
//        }
//    }

//    class SBI : ATM
//    {
//        public void Fetchaccount()
//        {
//            Console.WriteLine("avaliable balance is " + deposit);
//        }
//    }
//    internal class program
//    {
//        static void Main(string[] args)
//        {
//            SBI obj = new SBI();
//            obj.DepositMoney(3000);
//            obj.Fetchaccount();
//        }
//    }
//}