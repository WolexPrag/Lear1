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
            int count = 10;
            Random rand = new Random();
            for (int i = 0; i < count; i++)
            {
                Characteristics add = new Characteristics();
                add.characteristics.Add( new Health(100));
                add.characteristics.Add(new Damage(20));
                add.characteristics.Add(new Accuracy(0.5f));
                listCharacteristics.Add(add);
                       

            }
            for (int i = 0; i < count; i++)
            {
                PrintCharacteristics(listCharacteristics[i]);
                
            }
        }
        public static void PrintCharacteristics(Characteristics characteristics)
        {
            Console.WriteLine($"{characteristics.GetType()}" + " { ");
            for (int i = 0; i < characteristics.characteristics.Count; i++)
            {
                Console.Write($"{characteristics.characteristics[i].GetType()} = {characteristics.characteristics[i].value}");
                if(i+1 < characteristics.characteristics.Count)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine(" }");
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
            TestCharacteristics();

        }

    }
}
