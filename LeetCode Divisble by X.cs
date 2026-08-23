using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeSeb
{
    public class LeetCodeDivisible
    {
        private decimal ReduceTotal(decimal Val)
        {
            Val--;
            return Val;
        }
        private bool _HasDecimal(decimal Val, int Division) 
        {  
            bool isNotWhole =  (Val / Division % 1 != 0);
            return isNotWhole;
        }

        public decimal GetDivision(int[] IndexPool, int K)
        {

            int LoopSum = 0;
            int LargestNumber = 0;
            decimal Total = 0;
            

            foreach (int num in IndexPool)
            {
                if (num > LargestNumber) 
                {
                    LargestNumber = num;
                }
    
                Total += num;
            }

            while (_HasDecimal(Total, K))
            {
                Console.WriteLine("Looping.");
                LoopSum++;
                Total = ReduceTotal(Total);
            }


            return LoopSum;
        }

    }
}
