using System;
using System.Linq;

namespace _31._01._2023
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //var result = Sum(7, 13, 20);
            //Console.WriteLine(result);


            //ShowSum(19, 46);


            //int[] numbers = { 4, 6, 23, 47, 50 };
            //var sumOfArr = Sumarr(numbers);
            //Console.WriteLine(sumOfArr);


            4-cu proqram. ?


            //int[] nums = { 4, 6, 23, 47, 50 };
            //var maxNum = Highestnumber(nums);
            //Console.WriteLine(maxNum);


            //Highestnumber(8, 9, 10);


            //var reverse = Reverse("Xususi");
            //Console.WriteLine(reverse);


            //var sumdig = Sumdigits(168);
            //Console.WriteLine(sumdig);

        }


        //static int Sum(int A, int B, int C)
        //{
        //    var result = A + B + C;
        //    return result;
        //}


        //static void ShowSum(int x, int y)
        //{
        //    var result = x + y;
        //    Console.WriteLine(result);
        //}


        //static int Sumarr(int[] nums)
        //{
        //    int sum = 0;
        //    for (int i = 0; i < nums.Length; i++)
        //    {
        //        sum += nums[i];
        //    }
        //    return sum;
        //}


        static void Sumarr(int[] nums)
        {
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }
            Console.WriteLine(sum);
        }


        //static int Highestnumber(int[] nums)
        //{
        //    int maxNum = nums.Max(z => z);
        //    return maxNum;
        //}


        //static void Highestnumber(int a, int b, int c)
        //{
        //    if (a > b && a > c)
        //    {
        //        Console.WriteLine(a);
        //    }
        //    else if (b > a && b > c)
        //    {
        //        Console.WriteLine(b);
        //    }
        //    else if (c > b && c > a)
        //    {
        //        Console.WriteLine(c);
        //    }
        //    else
        //    {
        //        Console.WriteLine("Hamsi ve ya 2si beraberdi");
        //    }
        //    Console.WriteLine();
        //}


        //static string Reverse(string str)
        //{
        //    string newStr = "";
        //    for (int i = str.Length - 1; i >= 0; i--)
        //    {
        //        newStr += str[i];
        //    }
        //    return newStr;
        //}


        //static int Sumdigits(int Z)
        //{
        //    int sum = 0;
        //    while (Z > 0)
        //    {
        //        sum += Z % 10;
        //        Z = (Z - Z % 10) / 10;
        //    }
        //     return sum;
        //}
    }
}
