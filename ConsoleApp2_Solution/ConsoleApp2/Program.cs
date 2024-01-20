using System;
using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using System.Net.Http;
using System.Text;

namespace ConsoleApp2route
{
    internal class Program
    {
        //public static void print()
        //{
        //    for (int i = 0; i < 10; i++)
        //    {
        //        Console.WriteLine("@");   
        //    }
        //}

        //public static void print(int count,string pattern)
        //{
        //    for (int i = 0; i < count; i++)
        //    {
        //        Console.WriteLine($"{pattern}");
        //    }
        //}

        public static void print(int count=10, string pattern="#")
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"{pattern}");
            }
        }

        //public static void swap(int x, int y)
        //{
        //    int temp = y;
        //    y = x;
        //    x= temp;
        //}
        public static void swap(ref int x,ref int y)
        {
            int temp = y;
            y = x;
            x = temp;
        }
        public static int sum(ref int[] arr)
        {
            int result = 0;
           //arr[0] = 100;
            arr = new int[] { 4 , 5, 6};
            for (int i = 0;i < arr?.Length;i++)
            {
                result += arr[i];
            }
            return result;
        }
        public static void summul(int x ,int y, out int sum,out int mul )
        {
             sum = x + y;
             mul =x * y;
        }
        public static int sum02(params int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++) 
                sum+= arr[i];
            return sum;
        }
        enum Grades
        {
            A, B, C, D, E, F //label
        }
        enum Gender
        {
            male, female
        }
        enum branches :byte
        {
            dokki, alex, masrcity, maddi, smartvillage, benisuef
        }
        [Flags] //sum of permission
        enum per :byte
        {
            execute =1, delete=2, write=4, read =8
        }
        static void Main()
        {
            #region string
            //string name1 = "ahmed";
            //string name2 = "omar";
            //name1 = name2;
            //Console.WriteLine(name1.GetHashCode());
            //Console.WriteLine(name2.GetHashCode());
            //name2 = "mai";
            //Console.WriteLine(name1);
            //Console.WriteLine(name1.GetHashCode());
            //Console.WriteLine(name2.GetHashCode());

            //string message = "hello ";
            //Console.WriteLine(message.GetHashCode());
            //message += "ahmed";
            //Console.WriteLine(message.GetHashCode());
            //Console.WriteLine(message);

            //StringBuilder stringBuilder = new StringBuilder();
            //stringBuilder.Append("hello ");
            //Console.WriteLine(stringBuilder.GetHashCode());
            //stringBuilder.Append("ahmed");
            //Console.WriteLine(stringBuilder.GetHashCode());
            //Console.WriteLine(stringBuilder);

            #endregion
            #region array
            //one d array   
            //int[] numbers;
            //numbers = new int[3];
            //numbers[0] = 1;
            //numbers[1] = 2;
            //numbers[2] = 3;
            //int[] nums = new int[3] { 1, 2, 3 };
            //int[] nums2 = new int[] { 1, 2, 3 };
            //int[] nums4 = { 1, 2, 3 };
            //Console.WriteLine($"size of arr = {numbers.Length}, the number of dimintial = {numbers.Rank}");

            //foreach (int number in nums4)
            //{
            //    Console.WriteLine(number);
            //}

            //int[] arry1 = { 1, 2, 3 };
            //int[] arry2 = { 1, 2, 3 };
            //Console.WriteLine(arry1.GetHashCode());
            //Console.WriteLine(arry2.GetHashCode());
            //arry1 = arry2;
            //Console.WriteLine(arry1.GetHashCode());
            //Console.WriteLine(arry2.GetHashCode());

            //int[] arry3 = { 1, 2, 3 };
            //int[] arry4 = { 4, 5, 6 };
            ////shallow copy
            //arry3 = (int[])arry4.Clone();
            //Console.WriteLine(arry3.GetHashCode());
            //Console.WriteLine(arry4.GetHashCode());

            //jugged array

            //two d array 
            //int[,] marks = new int[3, 5];
            //Console.WriteLine(marks.Length + "  " + marks.Rank);
            //Console.WriteLine(marks.GetLength(0)+"  "+marks.GetLength(1));

            //bool flag = false;
            //for (int i = 0; i < marks.GetLength(0); i++)
            //{
            //    Console.WriteLine($"please enter marks of student { i + 1}  ");
            //    for (int j = 0; j < marks.GetLength(1);/* j++ */)
            //    {
            //        Console.Write($"enter mark sub num { j + 1}  ");
            //        //marks[i, j] = int.Parse(Console.ReadLine());
            //        flag = int.TryParse(Console.ReadLine(),out marks[i,j]);
            //        //if (flag = true && marks[i,j]>0)
            //        //    j++;      
            //        j = flag = true && marks[i, j] > 0 ? ++j : j;

            //    }
            //    Console.WriteLine();
            //}

            // two d arry using one loop
            //int[,] mark = new int[3, 5];
            //for (int i = 0; i < mark.Length; i++)
            //{
            //    Console.WriteLine(mark[i / mark.GetLength(1), i % mark.GetLength(1)]);
            //}

            //int[] array4 = { 3, 2, 1 ,5};
            //int[] array5 = new int[4];
            //Array.Sort(array4);
            //foreach (int item in array4)
            //{
            //    Console.WriteLine(item);
            //}

            //array4.CopyTo(array5, 0);
            //foreach (int i in array5)
            //{
            //    Console.WriteLine(i);
            //}

            #endregion
            #region boxing , unboxing
            //// castimg between reference type and value type 
            //object o1 = new object();
            ////casting from value type (int ) to reference type (object)
            //// safe casting (Boxing)
            //int x = 4;
            //object o2 = x;
            ////casting from  reference type (object)  to value type (int ) 
            //// unsafe casting (unBoxing)
            //object o3 = 22;
            //int y = (int)o3;
            //Console.WriteLine(y);

            #endregion
            #region  null types
            //int? x = null;
            //x = 5;
            ////x allow enteger + null
            //int? y = 5;
            //// y allows integer only 
            //y = x ?? 0;
            //Console.WriteLine(y);

            #endregion
            #region null propagation operator
            //double x = default; //0
            //Console.WriteLine(x);

            //int[] arr = default; //null
            //for (int i = 0; (arr!= null) && (i < arr.Length); i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}

            //for (int i = 0; i < arr?.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}

            #endregion
            #region implictly typed local variable {var , dynamic}
            //var Data = "ahmed";
            ////comailer will detect the datatype of variable its intital value at compilation time

            ////variable declard with (var) must be intialized with value 
            //// can't intialized with null
            //// you can't change the datetype of variable declaed with var
            //dynamic date02 = "ahmed;
            //// in runtime 
            //// not must initialized 
            //// revers propperties (var) 
            //date02 = "null";
            //date02 = "amr";
            //date02 = 77;

            #endregion
            #region function
            //print();
            //print (5,"siii")
            //print();
            //print("$$")  // invalid
            //print(pattern: "$$");
            //Console.WriteLine("hello \\n qassem \\bshaban ");// two \\ two skip this condition
            //Console.WriteLine(@"hello \n qassem \bshaban ");// or ( @ ) mark
            //string folderpath = "U:\\back_end";

            //print (20,@"/*\");

            #endregion
            #region passing value type parameter
            //int a = 10;
            //int b = 20;
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            ////passing by value
            //swap(a, b);
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            ////passing by reference
            //swap(ref a, ref b);
            //Console.WriteLine(a);
            //Console.WriteLine(b);


            #endregion
            #region passing reference type parameter
            //int[] numbers = { 1, 2, 3 };
            ////numbers = default;
            ////int result = sum( numbers);
            //int result = sum (ref numbers);
            ////Console.WriteLine(result);
            //Console.WriteLine(numbers[0]);
            #endregion
            #region passing by out 
            //int a = 10, b = 20, sum, mul;
            //summul(a, b, out sum, out mul);
            //Console.WriteLine(sum);
            //Console.WriteLine(mul);
            ////descared
            //int k = 5, l = 6, sum, mul;
            //summul(k, l, out _, out mul);
            //Console.WriteLine(mul);

            #endregion
            #region params
            ////int[] arr = { 1, 2, 3, 4, 5 };
            ////int result = sum02(arr);
            ////Console.WriteLine(result);
            //int result02 = sum02(1, 2, 3, 4, 5);
            //Console.WriteLine(result02);
            #endregion
            #region enum
            //Grades G1 = Grades.A;
            //Console.WriteLine(G1);
            //Grades G2 = Grades.B;
            //Console.WriteLine(G2);
            //Grades G1 = (Grades)3;
            //Console.WriteLine(G1);
            //branches b1 = branches.benisuef;
            //Console.WriteLine(b1);
            //per p1 = per.execute;
            //Console.WriteLine(p1);
            //per myp = (per) 3; //excute + delete
            //Console.WriteLine(myp);
            //per p2 = (per) 7; // execute + delele + write
            //Console.WriteLine(p2);
            //myp ^= per.read;  // myp = myp ^ per.read;
            //Console.WriteLine(myp); //excute + delete + read
            //myp ^= per.read;  // myp = myp ^ per.read;
            //Console.WriteLine(myp);  //excute + delete
            //if ( myp & per.delete==per.delete)
            //    Console.WriteLine("myp has per delete");
            //else
            //    Console.WriteLine("myp hasn't per delete")

            #endregion
            #region access modifiers
            /* {access modifer types} 1-private 2- private protected 3-protected 
            4-internal 5- internal protected 6- public */ 
            
            //باقي ال access modefier in comman [typeA]
            #endregion

            Console.ReadLine();
        }
    }
}
