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
        public static void TestFunction1()
        {
            List<Characteristics> listCharacteristics = new List<Characteristics>();
            int count = 1000;
            Random rand = new Random();
            for (int i = 0; i < count; i++)
            {
                Characteristics add = new Characteristics();

                add.characteristics.Add(new Health(i * 100));
                add.characteristics.Add(new Accuracy((float)1 / (float)count * rand.Next(i)));
                add.characteristics.Add(new Damage(
                    (float)add.characteristics[0].value / count * rand.Next(i) * (float)add.characteristics[1].value));

                listCharacteristics.Add(add);
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
                    Console.WriteLine(", ");
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
            TestDelegate deleg = new TestDelegate(TestFunction1);
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
