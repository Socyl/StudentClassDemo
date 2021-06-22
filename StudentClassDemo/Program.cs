using System;

namespace StudentClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Student molly = new Student();
            //molly.Name = "Molly the Cat";
            //Console.WriteLine(molly.Name);

            //molly.idNumber = 43;
            //Console.WriteLine(molly.IdNumber);

            Student.DoStuff();

            Student joe = new Student();
            joe.SetName("Joe Mama");

            string joesName = joe.GetName();
            Console.WriteLine("Joe's name is {0}", joesName);

            Student jane = new Student();
            jane.SetName("Janey");
            Console.WriteLine("Jane's name is {0}",jane.GetName());

            jane.SetScore1(100);
            jane.SetScore2(60);
            Console.WriteLine("Jane's average score is {0}", jane.GetAverageScore());

            jane.SetScore2(30);
            Console.WriteLine("Jane's new average score is {0}", jane.GetAverageScore());

            Console.WriteLine("Jane's high score is {0}", jane.GetHighScore());
            jane.SetScore2(110);
            Console.WriteLine("Jane's high score is {0}", jane.GetHighScore());


        }
    }
}
