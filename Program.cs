using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
namespace Lear1
{
    internal class Program
    {

        public static int cout = 0;
        public static void Main()
        {
            Stoper();
            Thread thread2 = new Thread(new ThreadStart(Writer));
            thread2.Name = "";
            thread2.Start();
            Thread.CurrentThread.Name = "";
            while (true) 
            {
                Writer();
            }


            /*Stoper();
            int countsName = 100;
            string names = "";
            Thread thread1 = new Thread(new ThreadStart(
                ()=>{
                        for (int i = 0; i < countsName; i++)
                        {
                            names += $"{GenName()}\n";
                        }
                    }
                ));
            thread1.Start();
            Console.WriteLine(names);
            Stoper();*/
        }
        public static void Writer()
        {
            Thread thread = Thread.CurrentThread;
            while (true)
            {
                cout++;
                Console.WriteLine($"([{MathF.Round(cout / 1900)}],{cout}) {thread.Name}");
            }
            
        }
        public static void Stoper()
        {
            string answer = ""; 
            for (int i = 0;answer.Equals("yes") == false; i++)
            {
                Console.Write("Continew: ");
                answer = Console.ReadLine();
            }
            
        }
        public static int RanRange(int min , int max)
        {
            return new Random().Next(min, max);
        }
        public static string GenName()
        {
            string retName = "";
            char[] vowel = { 'a','e','o','i','y'};
            char[] constantletters = { 'g', 'r', 'd', 'f', 'w','m', 'j', 'p','k','s'};
            byte hardcounter = 0;
            for (int i = 0; i < RanRange(3, 8); i++)
            {
                if (hardcounter > 1 || RanRange(0, 3) != 0)
                {
                    retName += vowel[RanRange(0, vowel.Length)];
                    hardcounter = 0;
                }
                else
                {
                    retName += constantletters[RanRange(0, constantletters.Length)];
                    hardcounter++;
                }
                if (i == 0) { retName = retName.ToUpper(); }
            }
            return retName;
        }

    }
}
