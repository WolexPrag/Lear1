using System;
using System.Threading;
using System.Collections.Generic;
using System.Transactions;
using System.Collections;
using System.Numerics;
using System.Linq;

namespace Learn1
{
   
    internal class Program
    {

        public static void Main(string[] args)
        {
            List<Block> blocks = new List<Block>(10);
            blocks.Add(new Block() { id = 9});
            blocks.Add(new Block() { id = 1});
            blocks.Add(new Block() { id = 3});
            blocks.Add(new Block() { id = 2});
            blocks.Add(new Block() { id = 5});
            blocks.Add(new Block() { id = 1});
            blocks.Add(new Block() { id = 5});
            blocks.Add(new Block() { id = 324});
            blocks.Add(new Block() { id = 0});
            blocks.Add(new Block() { id = -67});
            for (int i = 0; i < blocks.Count; i++)
            {
                Console.WriteLine($"{blocks[i].id}");
            }
            
            blocks = blocks.GroupBy(x => x.id == 1).Select(x=> x.First()).ToList();
            Console.WriteLine("======================");
            for (int i = 0; i < blocks.Count; i++)
            {
                Console.WriteLine($"{blocks[i].id}");
            }
        }
        
    }
    public class Block
    {
        public int id;
    }  
}
