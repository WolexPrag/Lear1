using Learn1.Other.Tester;
using Learn1.Other.Chararcteristics;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
namespace Learn1
{
    internal class Program
    {
        public static void TF()
        {
            List<Characteristics> listCharacteristics = new List<Characteristics>();
            int count = 10000;
            Random rand = new Random();
            for (int i = 0; i < count; i++)
            {


            }
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine();
            }
        }
        public static void PrintTime(long time)
        {
            Console.WriteLine($"Time: {(time - time % 1000) / 1000} s, {time % 1000} ms");
        }
        public static void TestCharacteristics()
        {
            TestDelegate deleg = new TestDelegate(TF);
            Console.WriteLine("Start Test");
            long time = Tester.Test(deleg);
            long midlTime = Tester.MultipleTest(deleg);
            Console.WriteLine("End Test");
            PrintTime(time);
            PrintTime(midlTime);
        }
        
        public static void Main(string[] args)
        {

        }

    }
}
