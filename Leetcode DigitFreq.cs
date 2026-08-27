using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeSeb
{
    public class Leetcode_DigitFreq
    {
        private int CalculateScore(char[] CharArray, char CharValue) 
        {
            int Index = 0;
            int Result = 0;
            foreach (char c in CharArray) 
            {
                Console.WriteLine(c);
                if (c == CharValue) 
                {
                    Index++;
                }
            }

            int ToInt = CharValue - '0';

            Result = Index * ToInt;
            return Result;
        }
        public int Score(int ScoreValue) 
        {  
            int Result = 0;
            string SplitScore = ScoreValue.ToString();
            char[] ScoreArray = SplitScore.ToCharArray();

            Console.WriteLine(ScoreArray);

            foreach (char c in ScoreArray)
            {
                Result += CalculateScore(ScoreArray, c);
            }
            return Result; 
        }

    }
}
