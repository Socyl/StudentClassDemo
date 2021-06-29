using System;

namespace StudentClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Student molly = new Student("Molly Cat", 1234);
            Console.WriteLine("molly's ID number: {0}", molly.IdNumber);
            Console.WriteLine("molly's name: {0}", molly.Name);
            molly.Score1 = 100;
            molly.Score2 = 60;
            Console.WriteLine("mollys Average: {0}", molly.AverageScore);
            Console.WriteLine("mollys high: {0}",molly.HighScore);

            //Student bella = new Student("Bella");

            //Console.WriteLine("bella's ID number: {0}", bella.GetIdNumber());
            //Console.WriteLine("bella's name: {0}", bella.GetName());

            //Student kitkat = new Student(1234);

            //Console.WriteLine("kitkat's ID number: {0}", kitkat.GetIdNumber());
            //Console.WriteLine("kitkat's name: {0}", kitkat.GetName());
        }
    }
}
