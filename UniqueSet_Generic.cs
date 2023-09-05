using System;

namespace UniqueSet_Generic
{
    class Program
    {
        static void Main(string[] args)
        {

            UniqueSet<int> numbers = new UniqueSet<int>();
            numbers.Add(10);
            numbers.Add(20);
            numbers.Add(30);
            numbers.Add(20);

            numbers.PrintSet();
        }
    }

    class UniqueSet<T>
    {
        private HashSet<T> set = new HashSet<T>();

        public void Add(T item)
        {
            if (!set.Contains(item))
            {
                set.Add(item);
            }
        }

        public void PrintSet()
        {
            foreach (T item in set)
            {
                Console.WriteLine(item);
            }
        }
    }
}