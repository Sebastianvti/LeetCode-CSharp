using System;
using System.Runtime.Intrinsics.Arm;
using DivisblebyX = LeetCodeSeb.LeetCodeDivisible;
using DigitFrequency = LeetCodeSeb.Leetcode_DigitFreq;

class Program 
{
    static void Main() 
    {
        Console.WriteLine("hello world");
        int[] ArrayofInts = { 1, 2, 3, 4, 5};
        int[] ArrayDivisbleXProblem = { 13, 10, 10 };

        // Problem 1
        DivisblebyX LeetCodeDivisble = new DivisblebyX();
        Console.WriteLine(LeetCodeDivisble.GetDivision(ArrayDivisbleXProblem, 5));

        // Problem 2
        CountArgs args = new CountArgs();
        Console.WriteLine(args.ArgCounter(ArrayofInts));

        // Problem 3
        DigitFrequency LeetCodeProblem3 = new DigitFrequency();
        Console.WriteLine(LeetCodeProblem3.Score(4550));
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