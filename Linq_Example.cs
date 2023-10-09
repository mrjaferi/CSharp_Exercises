using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq_Example
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Student> student = new List<Student>();

            student.Add(new Student("Mahboobeh", 95, 200));
            student.Add(new Student("Hooria", 95, 150));
            student.Add(new Student("Akbar", 73.5, 300));
            student.Add(new Student("Reza", 12, 40));
            student.Add(new Student("Yasin", 23, 500));

            var result_1 = student.OrderBy(x => x.Name).ToList();
            var result_2 = student.OrderByDescending(x => x.Donation).ToList();
            var result_3 = student.OrderByDescending(x => x.Donation).ThenBy(x => x.Name).ToList();
            var result_4 = student.Where(x => x.Donation > 200).ToList();
            var result_5 = student.Where(x => x.Donation > 200 && x.Average >= 50).ToList();
            var result_6 = student.Select(x => x.Name).ToList();
            var result_7 = student.Where(x => x.Donation > 200).Select(x => x.Name).ToList();
            var result_8 = student.Sum(x => x.Donation);
            var result_9 = student.Find(x => x.Donation > 200 && x.Average > 50 && x.Name.StartsWith("A"));
            var result_10 = student.Any(x => x.Donation > 200 && x.Average > 50 && x.Name.StartsWith("m"));

            // foreach (var st in result_8)
            // {
            // Console.WriteLine($"{st.Name} - {st.Average} - {st.Donation}");
            // }

            Console.WriteLine(result_10);
        }
    }

    public class Student
    {
        public string Name;
        public double Average;
        public double Donation;

        public Student(string name, double avg, double donation)
        {
            Name = name;
            Average = avg;
            Donation = donation;
        }
    }
}