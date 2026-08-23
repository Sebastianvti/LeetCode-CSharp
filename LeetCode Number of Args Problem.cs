using System;
using System.Runtime.Intrinsics.Arm;
using DivisblebyX = LeetCodeSeb.LeetCodeDivisible;

class Program 
{
    static void Main() 
    {
        Console.WriteLine("hello world");
        int[] ArrayofInts = { 1, 2, 3, 4, 5};
        int[] ArrayDivisbleXProblem = { 13, 10, 10 };

        DivisblebyX LeetCodeDivisble = new DivisblebyX();
        Console.WriteLine(LeetCodeDivisble.GetDivision(ArrayDivisbleXProblem, 5));


        CountArgs args = new CountArgs();
        Console.WriteLine(args.ArgCounter(ArrayofInts));
    }
}

public class CountArgs
{
    public int ArgCounter(params int[] Parameters)
    {
        int count = Parameters.Length;
        return count;
    }
 
}