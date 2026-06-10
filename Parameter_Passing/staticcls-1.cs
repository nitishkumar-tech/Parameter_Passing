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
            static int storage;
            static myclass()
            {
                iphonemodel = 18;
                iphoneram = 6;
                modelreleasedate = "September 2026";
                 int? storage;

                storage = null;

            }
            internal static void iphonedisplay()
            {
                Console.WriteLine("\n------ iPhone Details ------");
                Console.WriteLine("Iphone Model is " + iphonemodel);
                Console.WriteLine("Iphone baseRam is " + iphoneram);
                Console.WriteLine("Iphone model release date :" + modelreleasedate);
                Console.WriteLine("Iphone base storage  :" + storage);
            }
            internal static void storageupdate()
            {
                try
                {

                    if (storage == null)

                    {
                        Console.WriteLine("storage is not defined please pass the value");
                    }
                    else
                    {
                        Console.WriteLine("storage is " + storage);
                    }
                    Console.WriteLine("Enter Storage:");
                    storage = int.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine("error");
                }
            }

                internal static void ramupdate()
            {
            

               
                    if (iphoneram == 6)
                    {

                        while (iphoneram != 8 &&
                                iphoneram != 12)
                        {
                            Console.WriteLine("this base ram model not avaliable please select from following");
                            Console.WriteLine("8");
                            Console.WriteLine("12");

                            iphoneram = int.Parse(Console.ReadLine());

                            if (iphoneram != 8 &&
                                iphoneram != 12
                                                )
                            {
                                Console.WriteLine("Invalid RAM, Please select 8 or 12 only.");
                            }

                        }
                        Console.WriteLine("Updated RAM is " + iphoneram);
                    }
                
                

                    
            }
            static void Main(string[] args)
            {
                
                myclass.storageupdate();
                myclass.ramupdate();
                myclass.iphonedisplay();

            }
        }
    }
}
