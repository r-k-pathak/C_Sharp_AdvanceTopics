using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryAllocationStruct
{
    struct PairOfInts
    {
        public static int counter = 0;

        public int a;
        public int b;

        internal PairOfInts(int x, int y)
        {
            a = x;
            b = y;
            counter++;
        }
    }
    class Program
    {
        PairOfInts pair;
        string name;

        Program(ref PairOfInts p, string s, int x)
        {
            pair = p;
            name = s;
            pair.a += x;
        }

        static void Main()
        {
            PairOfInts z = new PairOfInts(1, 2);
            Console.WriteLine("struct Members a:{0},b:{1},c:{2}", z.a, z.b, PairOfInts.counter);
            Program t1 = new Program(ref z, "first", 1);
            Console.WriteLine("struct Members a:{0},b:{1},c:{2}", z.a, z.b, PairOfInts.counter);
            Program t2 = new Program(ref z, "second", 2);
            Console.WriteLine("struct Members a:{0},b:{1},c:{2}", z.a, z.b, PairOfInts.counter);
            Program t3 = null;
            Program t4 = t1;
            Console.WriteLine("struct Members a:{0},b:{1},c:{2}", z.a, z.b, PairOfInts.counter);
            
            Console.ReadLine();

            // XXX
        }
        
    }
    



  
}
