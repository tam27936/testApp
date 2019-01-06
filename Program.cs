using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testApp1
{
    public class foo
    {
        public int value1;
        public static double bar(double x, double y)
        {
            return x / y;
        }
        public foo() { value1 = 20; }
        
    }

    class FooBar
    {
        string i,s;
        public FooBar()
        {
            i = 1.ToString();
        }

        public FooBar(int x) : this()
        {
            s = i;
            if (x == Convert.ToInt32(s))
            {
                Console.WriteLine("5555555555");
            }
        }
    }

    class Program
    {
        public static void KeyNumber()
        {
            string[,] a = new string[3, 3] { { "1", "2", "3" }, { "4", "5", "6" }, { "7", "8", "9" } };
            var p = Console.ReadLine();


            int b = 1, c = 1;
            while (p != "")
            {
                switch (p)
                {
                    case "W":
                    case "w":
                        b = (b - 1 < 0) ? b : b - 1;
                        Console.WriteLine(a[b, c]);
                        break;
                    case "S":
                    case "s":
                        b = (b + 1 > 2) ? b : b + 1;
                        Console.WriteLine(a[b, c]);
                        break;
                    case "A":
                    case "a":
                        c = (c - 1 < 0) ? c : c - 1;
                        Console.WriteLine(a[b, c]);
                        break;
                    case "D":
                    case "d":
                        c = (c + 1 > 2) ? c : c + 1;
                        Console.WriteLine(a[b, c]);
                        break;
                    case "q": Environment.Exit(0); break;
                }
                p = Console.ReadLine();
            }
        }

        public static void ResultNumber()
        {
            string conin_str;

            do
            {
                int conin = 0;
                Console.Write("Enter a number (1000 - 9999) and enter -1 for exit program :");
                conin_str = Console.ReadLine();
                conin_str = conin_str.Trim();

                try
                {
                    if (int.TryParse(conin_str, out conin) && conin > 999)
                    {
                        if (conin_str.Length > 4)
                            Console.WriteLine("please enter 4 number only");

                        else
                        {
                            char[] reverCha = conin_str.ToArray();
                            Array.Reverse(reverCha);
                            string revert_Conin = new string(reverCha);
                            Console.WriteLine("Reverse number : " + revert_Conin);

                            Console.WriteLine(conin_str + " - " 
                                              + revert_Conin + " = " 
                                              + (conin - int.Parse(revert_Conin)).ToString());
                        }
                    }
                    else
                        Console.WriteLine("Please enter numbers between (1000 - 9999) only");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error exception :" + ex.Message);
                }
            } while (conin_str != "-1");
        }

        static void Main(string[] args)
        {
            //Console.WriteLine(foo.bar(53.0, 19.0));


            //const string filePath = "D:\\New folder (4)\\testApp1\\testApp1\\Program.cs";
            //Print(filePath);

            //del a = x => x + x;
            //int d = a(34);


            //int[] array = { 1, 3, 5, 7, 9 };

            //var result = from element in array
            //             let v = element * 100
            //             where v >= 500
            //             select v;

            //foreach (var element in result)
            //    Console.WriteLine(element);

            

            Console.ReadKey();
        }

        public static void ArrayIntToArraySting()
        {
            int[] intarray = { 198, 200, 354, 14, 540 };
            Array.Sort(intarray);
            string[] stringarray = new string[intarray.Length];

            for (int i = 0; i < intarray.Length; i++)
            {
                stringarray[i] = intarray[i].ToString();
            }

            string a = string.Join("", stringarray);
            string b = string.Concat(stringarray); //ใช้แบบนี้ก็ได้
            Console.WriteLine(b);
        }

        public static async Task await_async()
        {
            async Task<int> com()
            {
                return await Task.Run<int>(() =>
                {
                    double x = 2;
                    for (int i = 1; i < 100000000; i++)
                        x += Math.Sqrt(x) / i;
                    return (int)x;

                });
            }

            var task = com();
            Console.WriteLine(task.Result);
            Console.WriteLine();

            var task1 = com();
            var task2 = com();
            task1.Wait(); task2.Wait(); // run ทั้ง 2 โดยไม่ต้องรอ 
            await Task.WhenAll(task1, task2); // การรอ 2 งาน สำเร็จด้วยจุดเดียว
        }

        public static void RunTask() //ทำงานได้ในแบบพร้อมๆกันโดยไม่ต้องรอ
        {
            int ComplexCalculation()
            {
                double x = 2;
                for (int i = 1; i < 100000000; i++)
                    x += Math.Sqrt(x) / i;
                return (int)x;
            }

            Task<int> ComplexCalculationAsync()
            {
                return Task.Run(() => ComplexCalculation());
            }

            Task<int> task = ComplexCalculationAsync();
            var awaiter = task.GetAwaiter();
            awaiter.OnCompleted(() =>
            {
                int result = awaiter.GetResult();
                Console.WriteLine(result);
            });
        }

        delegate int del(int i); //delegate เป็นตัวแปร reference type เป็น pointer ของ method 

        private static void Reverse()
        {
            string a = Console.ReadLine();
            char[] b = a.ToArray();
            Array.Reverse(b);
            string c = new string(b);
            Console.WriteLine(c);
        }

        private static void Pyramid()
        {
            string a = Console.ReadLine();
            int Number;
            do
            {

                int b = Convert.ToInt32(a);
                for (int i = 1; i <= b; i++)
                {
                    for (Number = 1; Number <= i; Number++)
                        Console.Write(Number + " ");

                    Console.WriteLine();
                }
                Console.WriteLine();
                a = Console.ReadLine();

            } while (a != "0");
        }

        private static void Print(string a)
        {
            using (var reader = new StreamReader(path : a))
            {
                string s = "";

                while ((s = reader.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
        }

        
    }
   
}
