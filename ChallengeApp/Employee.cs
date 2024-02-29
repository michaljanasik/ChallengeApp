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
        char letterGrade;

        private List<float> grades = new List<float>();


        /*--------------------constructors----------------------------------*/
        public Employee() { this.name = this.surname = ""; this.letterGrade = 'N'; }
        public Employee(string Name, string Surname)
        {
            this.name = Name;
            this.surname = Surname;
        }
        /*--------------------------Show--------------------*/
        public void showAllGrades()
        {
            List<float> tmpList = this.grades;

            setUpLetterGradeFromGrades(this.grades);
            Console.WriteLine("Emploees grades:\n");
            int i = 0;
            foreach (float element in tmpList)
            {
                i++;
                Console.WriteLine($"element {i}= {element},");
            }

        }
        //-------------------------------------
        /*---------------------AddGrade------------------------------------*/
        //-------------------float----------------------------------------------
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
                Console.ReadKey();
            }

        }
        //-----------------------------char------------------------------
        public void AddGrade(char grade)
        {
            grade = char.ToUpper(grade);

            if (char.IsBetween(grade, 'A', 'E'))
            {

                this.letterGrade = grade;

                switch (grade)
                {
                    case 'A':
                        {

                            this.grades.Add(81);
                            break;
                        }
                    case 'B':
                        {

                            this.grades.Add(61);
                            break;
                        }
                    case 'C':
                        {

                            this.grades.Add(41);
                            break;
                        }
                    case 'D':
                        {

                            this.grades.Add(21);
                            break;
                        }
                    case 'E':
                        {

                            this.grades.Add(1);
                            break;
                        }
                    default:
                        {

                            break;
                        }
                }
            }

        }
        //-----------------------------string-----------------------------

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
                Console.ReadLine();
            }
        }
        //----------------------double----------------------------
        public void AddGrade(double grade)
        {

            grade = Math.Round(grade);
            float value = (float)grade;

            AddGrade(value);

        }
        //-------------------------------------int-----------------------
        public void AddGrade(int grade)
        {

            float value = (float)grade;

            AddGrade(value);

        }
        /*----------------------------end of adgrade-------------------------*/
        //--------------------------------------------------------------------

        /*--------------------config grades----------------------------------*/
        public void setUpLetterGradeFromGrades(List<float> mygrades)
        {
            if (mygrades.Count > 0)
            {
                float AvgScore = mygrades.Average();

                if (AvgScore >= 80 && AvgScore <= 100)
                {
                    this.letterGrade = 'A';
                }
                else if (AvgScore >= 60 && AvgScore < 80)
                {
                    this.letterGrade = 'B';
                }
                else if (AvgScore >= 40 && AvgScore < 60)
                {
                    this.letterGrade = 'C';
                }
                else if (AvgScore >= 20 && AvgScore < 40)
                {
                    this.letterGrade = 'D';
                }
                else if (AvgScore >= 1 && AvgScore < 20)
                {
                    this.letterGrade = 'E';
                }
            }
        }

        //----------------------------
        /*-----statistics-----------------------*/
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
            Console.WriteLine($"Min: {statistics.Min}  Max: {statistics.Max}\n");
            Console.Write($"\t{statistics.Average} / {grades.Count} =");
            Console.Write($"\tAverage{statistics.Average /= grades.Count}");
            Console.Write($"\tletterGrade: {this.letterGrade}");

            return statistics;
        }
    }
}