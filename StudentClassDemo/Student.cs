using System;
using System.Collections.Generic;
using System.Text;

namespace StudentClassDemo
{
    class Student
    {
        private string name;
        private int idNumber;
        //private double dNum;
        private double score1;
        private double score2;
        private double averageScore;


        public Student()
        {

        }

        public static void DoStuff()
        {
            Student molly = new Student();
            molly.name = "Molly";
            molly.idNumber = 43;
            //molly.dNum = 67.0;
            Console.WriteLine("Molly: {0}", molly.name);
            Console.WriteLine("Molly: {0}", molly.idNumber);
            //Console.WriteLine("Molly: {0}", molly.dNum);

            Student someStudent = new Student();
            Console.WriteLine("someStudent: {0}", someStudent.name);
            Console.WriteLine("someStudent: {0}", someStudent.idNumber);
            //Console.WriteLine("someStudent: {0}", someStudent.dNum);
        }



        public string GetName()
        {
            return name;
        }

        public void SetName(string newName)
        {
            name = newName;
        }

        public int GetIdNumber()
        {
            return this.idNumber;
        }

        public void SetIdNumber(int newIdNumber)
        {
            this.idNumber = newIdNumber;
        }

        public double GetScore1()
        {
            return this.score1;
        }

        public void SetScore1(double newScore1)
        {
            this.score1 = newScore1;
            UpdateAverageScore();
        }

        public double GetScore2()
        {
            return this.score2;
        }

        public void SetScore2(double newScore2)
        {
            this.score2 = newScore2;
            UpdateAverageScore();
        }

        public double GetAverageScore()
        {
            return averageScore;
        }

        private void UpdateAverageScore()
        {
            averageScore = (score1 + score2) / 2;
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
