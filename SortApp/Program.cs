using System;


namespace SortApp
{
    class Program
    {
        static ArrayClass ar;
        static Random random;
        static void Main(string[] args)
        {
            random = new Random(1);
            ar = new ArrayClass(10);
            Console.WriteLine("Начальный массив");
            ar.Print();

            BubleSort(ar);
            Console.ReadKey();
        }

        public static void NotBubleSort(ArrayClass a)
        {
            for(int i=0;i<a.Length;i++)
            {
                for (int j = 0; j < a.Length; j++)
                {
                    if (a[i] > a[j])
                        a.Swap(i, j);                    
                    a.Print(i * a.Length + j + 1);
                }
            }
        }
        public static void BubleSort(ArrayClass a)
        {
            bool swapped;
            int q = 0;
            do
            {
                swapped = false;
                for (int i = 1; i < a.Length; i++)
                {
                    if (a[i] < a[i - 1])
                    {
                        a.Swap(i, i - 1);
                        swapped = true;
                    }
                    a.Print(++q);
                }
            }
            while (swapped);
        }
        

    }
}
