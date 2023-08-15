using System;
using System.Collections.Generic;
using System.Linq;
namespace Lear1
{
    internal class Program
    {
        public static void Main()
        {
            List<int> arr = new List<int>() { 3, -1, 1, -3,-5 };
            Console.WriteLine(Solve(arr));
         
        }
        public static int Solve(List<int> arr)
        {
            return arr.Distinct().Sum();
        }
        public static bool Cheak1(List<int> chekenList, int numberH)
        {
            for(int i = 0; i < chekenList.Count;i++)
            {
                if (chekenList[i] == numberH)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool Cheak2(List<int> chekenList, int numberH)
        {
            for (int i = 0; i < chekenList.Count; i++)
            {
                if (chekenList[i]*-1 == numberH)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
