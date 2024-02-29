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
                Console.WriteLine($"\n\n\t{grade} ---- It is not possible to convert this" +
                $" value to float from {grade.GetType()} ----\n\n");
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
        //-----------------------1---------ForEach------
        public Statistics getStatistics()
        {

            var statistics = new Statistics();

            Console.WriteLine("\n\tForEach\n");

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
        //--------------2--DoWhile----
        public Statistics getStatisticsDoWhile()
        {

            var statistics = new Statistics();
            int index = 0;

            Console.WriteLine("\n\n\tDo-While");
            do
            {
                statistics.Max = Math.Max(statistics.Max, grades[index]);
                statistics.Min = Math.Min(statistics.Min, grades[index]);
                statistics.Average += grades[index];
                index++;

            } while (index < this.grades.Count);

            //    statistics.Average = grades.Average();

            Console.Write($"\t{statistics.Average} / {grades.Count}");
            Console.Write($"\t{statistics.Average /= grades.Count}");

            return statistics;
        }
        //----------------------3---------While-----------
        public Statistics getStatisticsWhile()
        {

            var statistics = new Statistics();
            int index = 0;

            Console.Write("\tWhile\n");
            while (index != this.grades.Count)
            {
                statistics.Max = Math.Max(statistics.Max, grades[index]);
                statistics.Min = Math.Min(statistics.Min, grades[index]);
                statistics.Average += grades[index];
                index++;

            }

            //    statistics.Average = grades.Average();

            Console.Write($"\t{statistics.Average} / {grades.Count}");
            Console.Write($"\t{statistics.Average /= grades.Count}");

            return statistics;
        }
        //----------------------4---------for-----------
        public Statistics getStatisticsFor()
        {

            var statistics = new Statistics();

            Console.Write("\tFor\n");

            for (int index = 0; index < this.grades.Count; index++)
            {
                statistics.Max = Math.Max(statistics.Max, grades[index]);
                statistics.Min = Math.Min(statistics.Min, grades[index]);
                statistics.Average += grades[index];
            }

            //    statistics.Average = grades.Average();

            Console.Write($"\t{statistics.Average} / {grades.Count}");
            Console.Write($"\t{statistics.Average /= grades.Count}");

            return statistics;
        }
    }
}