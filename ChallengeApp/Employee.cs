using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challangeApp
{
    public class Employee
    {
        string name;
        string surname;

        object objGrade;


        private List<float> grades = new List<float>();


        //--------------------------------------------------------
        public Employee() {; }
        public Employee(string Name, string Surname)
        {
            this.name = Name;
            this.surname = Surname;
        }
        //-------------------------------------

        public void AddGrade(float grade)
        {


            if (grade >= 1 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else if (grade < 0 && grade >= -100)
            {
                this.grades.Add(grade);
            }
            else
            {
                Console.WriteLine($"May add 1-100 only\t\tOne of Yours values is {grade}\n");
            }
        }


        public void AddGrade(string grade)
        {
            float value;

            if (float.TryParse(grade, out value))
            {
                AddGrade(value);

            }
            else
            {
                Console.WriteLine($"\n\n\t{grade} ----  It is not possible to convert this" +
                $" value to float from {grade.GetType()}----\n\n");
            }
        }

        public void AddGrade(double grade)
        {

            grade = Math.Round(grade);
            float value = (float)grade;

            AddGrade(value);

        }

        public void AddGrade(int grade)
        {

            float value = (float)grade;

            AddGrade(value);

        }
        public void showAllGrades()
        {
            List<float> tmpList = this.grades;
            //Console.Clear();
            Console.WriteLine("Emploees grades:\n");
            int i = 0;
            foreach (float element in tmpList)
            {
                i++;
                Console.WriteLine($"element {i}= {element},");


            }

        }
        //----------------------------
        //-----statistics    

        public Statistics getStatistics()
        {

            var statistics = new Statistics();


            foreach (float grade in this.grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }

            //    statistics.Average = grades.Average();

            Console.Write($"\t{statistics.Average} / {grades.Count}");
            Console.Write($"\t{statistics.Average /= grades.Count}");

            return statistics;
        }
        //------------------------------------------------------------------------
        // helping functions

        object getLineLikeAnObject() { return (object)Console.ReadLine(); }
        // void addGradeInfo(){Console.WriteLine("\n\ngive me the number from (+/-) 1-100\n\n");}

    }
}