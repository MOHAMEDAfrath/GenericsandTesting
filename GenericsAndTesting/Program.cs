using System;

namespace GenericsAndTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Generics and Testing!");
            int[] arr = { 52, 60, 225, 21, 55 };
            FindThreeNumbers<int> find = new FindThreeNumbers<int>(arr);
            find.MaxArray();

        }
    }
}
