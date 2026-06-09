using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameter_Passing
{
    internal class staticcls_1
    {
        static class myclass
        {
           private static int iphonemodel;
            static int iphoneram;
            private static string modelreleasedate;
            static string storage;
            static myclass()
            {
                iphonemodel = 18;
                iphoneram = 12;
                modelreleasedate = "September 2026";
                storage = string.Empty;

            }
            internal static void iphonedisplay()
            {
            DisplayModel:
                Console.WriteLine("Iphone Model is " + iphonemodel);
                Console.WriteLine("Iphone baseRam is " + iphoneram);
                Console.WriteLine("Iphone model release date :" + modelreleasedate);
                Console.WriteLine("Iphone base storage  :" + storage);

                if (string.IsNullOrEmpty(storage))

                {
                    Console.WriteLine("storage is not defined please pass the value");
                }
                else
                {
                    Console.WriteLine("storage is " + storage);
                }
                if (iphoneram == 12)
                {

                    do
                    {
                        Console.WriteLine("this base ram model not avaliable please select from following");
                        Console.WriteLine("32");
                        Console.WriteLine("64");
                        Console.WriteLine("128");

                        iphoneram = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("updated ram is " + iphoneram);
                        goto DisplayModel;
                        

                    } while (iphonemodel != 16 &&
                             iphonemodel != 17 &&
                             iphonemodel != 18);

                }
            }

            static void Main(string[] args)
            {
                myclass.iphonedisplay();
            }
        }
    }
}
