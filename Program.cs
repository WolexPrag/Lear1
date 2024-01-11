using System;
using System.Collections.Generic;

namespace Learn1
{
    public class Node
    {
        public Node next;
        public string name;
    }
    internal class Program
    {
        public static string GetData()
        {
            char[] simbA = {'a','e','u' };
            char[] simbB = { 'b','d','z' };
            string ret = "";
            Random randomizer = new Random();
            int sizeData = 5;
            int countA = 0;
            for (int i = 0; i < sizeData; i++)
            {
                
                if(countA < 1)
                {
                    ret += simbA[randomizer.Next(0, simbB.Length - 1)];
                    countA++;
                }
                else
                {
                    ret += simbB[randomizer.Next(0, simbB.Length - 1)];
                    countA = 0;
                }

            }
            return ret;
        }
        public static Node Input(int count = 10)
        {
            List<Node> ret = new List<Node>(count);
            for (int i = 0; i < count; i++)
            {
                ret.Add(new Node() { name = GetData() }) ;
                if (i > 0)
                {
                    ret[i - 1].next = ret[i];
                }
            }
            return ret[0];
        }
        public static void Main(string[] args)
        {
            Node nodes = Input();
            for (int i = 0;; i++)
            {
                Console.WriteLine(nodes.name);

                
                nodes = nodes?.next;

            }
            
        }
    }
}
