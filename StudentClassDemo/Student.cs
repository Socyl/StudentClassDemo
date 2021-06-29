using System;
using System.Collections.Generic;
using System.Text;

namespace StudentClassDemo
{
    class Student
    {
        //private string name;
        //private int idNumber;
        //private double dNum;


        private double score1;
        private double score2;
        //private double averageScore;


        public Student():this("unknown",-1)
        {
            
        }

        public Student(int newIdNumber):this("unknown",newIdNumber)
        {
        }
        public Student(string newName):this(newName,-1)
        {
            
        }

        public Student(string newName, int newIdNumber)
        {
            this.Name = newName;
            this.IdNumber = newIdNumber;
        }
   // public static void DoStuff()
        //{
           // Student molly = new Student();
           // molly.name = "Molly";
            //molly.idNumber = 43;
            //molly.dNum = 67.0;
            //Console.WriteLine("Molly: {0}", molly.name);
            //Console.WriteLine("Molly: {0}", molly.idNumber);
            //Console.WriteLine("Molly: {0}", molly.dNum);

            //Student someStudent = new Student();
            //Console.WriteLine("someStudent: {0}", someStudent.name);
            //Console.WriteLine("someStudent: {0}", someStudent.idNumber);
            //Console.WriteLine("someStudent: {0}", someStudent.dNum);
        //}

        public string Name { get; set; }
        public int IdNumber { get; set; }

        public double Score1
        {
            get { return this.score1; }
            set { this.score1 = value;UpdateAverageScore(); }
        }
        public double Score2
        {
            get { return this.score2; }
            set { this.score2 = value; UpdateAverageScore(); }
        }

        public double HighScore
        {
            get
            {
                if (score1 > score2)
                {
                    return score1;
                }
                else
                {
                    return score2;
                }
            }
        }
        public double AverageScore { get; private set; }


        

        //public double GetAverageScore()
        //{
        //    return averageScore;
        //}

        private void UpdateAverageScore()
        {
            AverageScore = (score1 + score2) / 2;
        }

        public double GetHighScore()
        {
            if (score1 > score2)
            {
                return score1;
            }
            else
            {
                return score2;
            }
        }
    }


}
