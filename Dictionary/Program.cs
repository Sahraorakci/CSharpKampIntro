using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            MyDictionary<int, string> musteriler = new MyDictionary<int, string>();
            musteriler.Add(1, "Alihan");
            musteriler.Add(2, "Ferhan");
            musteriler.Add(3, "İbrahim");

            for (int i = 0; i < musteriler.Count(); i++)
            {
                Console.WriteLine(musteriler.keys[i] + " " + musteriler.values[i]);
            }


            Console.WriteLine("Number of customers :" + musteriler.Count());
        }
    }
}
