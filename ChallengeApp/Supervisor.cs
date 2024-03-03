using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challangeApp
{
    public class Supervisor : IEmployee
    {

        string name;
        string surname;
        public string sayHello => throw new NotImplementedException("This is to see again...");

        List<float> grades = new List<float>();


        public Supervisor()
        {
            this.name = this.surname = "no data";
        }

        public string Name
        {
            set { this.Name = value; }
            get { return this.Name; }
        }
        public string Surname
        {
            set { this.Surname = value; }
            get { return this.Surname; }
        }

        //---------------------------------------------------------------------
        public void AddGrade(string mystring)
        {
            if (mystring.Length > 0 && mystring.Length < 2)
            {
                this.AddGrade(mystring[0]);
            }
            else
            {
                float number;

                if (float.TryParse(mystring, out number))
                {
                    this.AddGrade(number);
                }
                else { throw new InvalidCastException("Conversion error"); }
            }

        }
        public void AddGrade(char letter)
        {
            letter = char.ToUpper(letter);

            switch (letter)
            {
                case 'A': { this.AddGrade(100); break; }
                case 'B': { this.AddGrade(80); break; }
                case 'C': { this.AddGrade(60); break; }
                case 'D': { this.AddGrade(40); break; }
                case 'E': { this.AddGrade(20); break; }
            }


        }
        public void AddGrade(float grade)
        {
            if (grade <= 100 && grade > 0)
            {

                this.grades.Add(grade);
            }
            else
            {
                throw new ArgumentException("\n\n\tNumber must be between 1-100\n");
            }
        }


        public void ShowGrades()
        {
            PrepareDatasForStatistic(this.grades);

            int i = 0;
            foreach (float grade in this.grades)
            {
                i++;
                Console.WriteLine($"Ocena {i} = {grade}");
            }
        }

        void PrepareDatasForStatistic(List<float> ListOfGrades)
        {
            Statistics st = new Statistics();
            /*
            this.Min = ListOfGrades.Min();
            this.Max = ListOfGrades.Max();
            this.Averrage = ListOfGrades.Sum() / ListOfGrades.Count();

            switch (this.Averrage)
            {
                case > 80: { this.letterGrade = "A"; break; }
                case > 60: { this.letterGrade = "B"; break; }
                case > 40: { this.letterGrade = "C"; break; }
                case > 20: { this.letterGrade = "D"; break; }
                case > 1: { this.letterGrade = "E"; break; }
            }
            */
        }






        public void DeleteGrades() { this.grades.Clear(); }

        public Statistics GetStatistics()
        {
            Statistics st = new Statistics();

            throw new NotImplementedException("To do");

            return st;
        }

        //-----------------------------------------------------------------------
    }
}
