using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region value type
            //int x, y;
            //x = 5;
            //y = x;
            //x++;
            //Console.WriteLine(x);
            //Console.WriteLine(y);
            //Console.ReadLine();
            #endregion
            #region Reference type
            //point p1;
            //p1 = new point();
            //point p2 = new point();
            //p2 = p1;
            //p1.x = 5;
            //Console.WriteLine(p1.x);
            //Console.WriteLine(p2.x);

            #endregion
            #region object 
            //object o1 = new object();
            //object o2 = new object();
            //Console.WriteLine(o1.GetHashCode());
            //Console.WriteLine(o2.GetHashCode());

            //o2 =o1;
            //Console.WriteLine("after assignment");
            //Console.WriteLine(o1.GetHashCode());
            //Console.WriteLine(o2.GetHashCode());

            #endregion
            #region fractions and discard

            //float num1 = 434.434F;
            //decimal num2 = 837434.434m;
            ////Discard
            //long num3 = 1_000_000_000;
            #endregion
            #region value tybe casting
            //int x =10;
            //long y = x;//3-implicit casting
            //long num1 = 10;
            //int num2;
            //checked
            //{
            //   num2 = (int) num1; //2-explicit casting
            //}

            //double num3 = 323.233;
            //int num4 = (int)num3; //explicit casting
            //Console.WriteLine(num4);

            #endregion
            #region prase and Convert
            //Console.WriteLine("pls enter your name");
            //string Name = Console.ReadLine();
            //Console.WriteLine("pls enter your age");
            ////3-parse  :convert from string to any Built-in datatype
            //int Age = int.Parse(Console.ReadLine());
            //Console.WriteLine("pls enter your salary");
            //decimal salary = decimal.Parse(Console.ReadLine());
            //Console.WriteLine("Hello " + Name);
            //Console.WriteLine("your age is " + Age);
            //Console.WriteLine("your salary is " + salary);
            ////4 - convert  : convert from any datatype to any datatype
            //Console.WriteLine("pls enter your name");
            //string Name = Console.ReadLine();
            //Console.WriteLine("pls enter your age");
            //int Age = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("pls enter your salary");
            //decimal salary = Convert.ToDecimal(Console.ReadLine());
            //Console.WriteLine("Hello " + Name);
            //Console.WriteLine("your age is " + Age);
            //Console.WriteLine("your salary is " + salary);
            //Console.ReadLine();

            #endregion
            #region Unary Operator
            //int x = 10;
            //Console.WriteLine(++x); //prefix
            //int y = 10;
            //Console.WriteLine(y++); //postfix
            //Console.WriteLine(--x); //prefix
            //Console.WriteLine(y--); //postfix

            //int s = 5; int w = 10;
            //bool Flag = s > w ? true : false;
            //Console.WriteLine(  Flag);
            //Console.ReadLine();

            #endregion
            #region orders operations
            //int sum = 6 + 4 * 5;
            //Console.WriteLine(sum);
            ////1-unar operator
            ////2-round braces() الاقواس
            ////3-* / %
            ////4- + -
            //Console.ReadLine(); 
            #endregion
            #region string formatting
            ////int x = 4; int y = 2;
            //string message = "Equation :" + x + "+" + y + "= " + (x + y);
            ////string interpolation
            //message = string.Format("Equation : {0} + {1} = {2}", x, y, x + y);
            //// $ : string Manipulation operator
            //message =$"Equation : {x} + {y} = {x+y}";
            //Console.WriteLine(message);
            //Console.ReadLine();
            #endregion
            #region if && switch
            //Console.Write("pls enter the month number ");
            //int num = int.Parse(Console.ReadLine());
            //if (num==1) Console.WriteLine("JAN");
            //else if (num == 2) Console.WriteLine("FEB");
            //else if (num == 3) Console.WriteLine("Mar");
            //else Console.WriteLine("this month is not first Quarter");

            //switch (num)
            //{
            //    case 1:
            //        Console.WriteLine("JAN");
            //        break;
            //    case 2:
            //        Console.WriteLine("FEB");
            //        break; 
            //    case 3:
            //        Console.WriteLine("Mar");
            //        break;
            //    default:
            //        Console.WriteLine("this month is not first Quarter");
            //        break;
            //}
            //Console.ReadLine();
            #endregion
            #region Examle  
            //String لو عدد الحالات اكتر من 5 استخدم سوتش فى حاله///
            //Console.WriteLine("pls enter your name");
            //String name = Console.ReadLine();
            //if (name =="Ahmed")
            //    Console.WriteLine("Hello Ahmed");
            //else if (name == "Aya")
            //    Console.WriteLine("Hello Aya");
            //else if (name == "omar")
            //    Console.WriteLine("Hello omar");
            //else if (name == "mohamed")
            //    Console.WriteLine("Hello mohamed");
            //else if (name == "ali")
            //    Console.WriteLine("Hello ali");

            //switch (name) {
            //    case "Ahmed":
            //    case "ahmed":
            //        Console.WriteLine("Hello Ahmed");
            //        break;
            //    case "Aya":
            //        Console.WriteLine("Hello Aya");
            //        break;
            //    case "omar":
            //        Console.WriteLine("Hello omar");
            //        break;
            //    case "Ahmohameded":
            //        Console.WriteLine("Hello mohamed");
            //        break;
            //    case "ali":
            //        Console.WriteLine("Hello ali");
            //        break;
            //}
            //Console.ReadLine();
            #endregion


            Console.WriteLine("Enter First Number");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Scound Number");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("Pls Select Sign from this  ( +, -, *, /, %,Maxmam , Minmam) ");
            string s = Console.ReadLine();
            if (s == "+")
                Console.WriteLine($"x + y = {x + y}");
            else if (s == "-")
                Console.WriteLine($"x - y = {x - y}");
            else if (s == "*")
                Console.WriteLine($"x * y = {x * y}");
            else if (s == "/")
                Console.WriteLine($"x / y = {x / y}");
            else if (s == "%")
                Console.WriteLine($"x % y = {x % y}");
            else if (x > y)
                Console.WriteLine($" {x} is grater than {y}");
            else if (x < y)
                Console.WriteLine($" {x} is smaller than {y}");
        }
    }
    }
}