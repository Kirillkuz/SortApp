using System;
using System.Collections.Generic;
using System.Text;

namespace SortApp
{
    class ArrayClass
    {
        public int[] array { get; set; }
        public int Length
        {
            get { return array.Length; }            
        }
        
        private Random random;
        public ArrayClass(int leng)
        {
            array = new int[leng];
            random = new Random(1);
            ArrayGenerate();
        }
        public void Print()
        {

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0:D3} ", array[i]);
                if (i % 10 == 9)
                    Console.WriteLine();
            }
            Console.WriteLine();
            System.Threading.Thread.Sleep(100);
        }
        public void Print(int q)
        {
            Console.WriteLine("Иттерация №" + q.ToString());
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0:D3} ", array[i]);
                if (i % 10 == 9)
                    Console.WriteLine();
            }
            Console.WriteLine();
            System.Threading.Thread.Sleep(100);
        }
        public static void Print(int[] ar)
        {
            for (int i = 0; i < ar.Length; i++)
            {
                Console.Write("{0:C3}",ar[i]);
                if (i % 10 == 9)
                    Console.WriteLine();
            }
        }
        public void ArrayGenerate()
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 1000);
            }
        }
        public void Swap(int i, int j)
        {
            int a = array[i];
            array[i] = array[j];
            array[j] = a;
        }
        public int this[int i]
        {
            get
            {
                return array[i];
            }
        }
        
        
    }
}
