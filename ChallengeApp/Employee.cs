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
        string letterGrade;
        float averrage, min, max;

        List<float> grades = new List<float>();

        public Employee()
        {
            this.name = "abc";
            this.surname = "abc";
            this.letterGrade = "F";
            this.averrage = 0;
        }
        public Employee(string name, string surname)
        {

        }

        public string Name
        {
            get { return this.name; }
            private set { this.name = value; }
        }
        public string Surname
        {
            get { return this.surname; }
            private set { this.surname = value; }
        }
        public string LetterGrade
        {
            set { this.letterGrade = value; }
            get { return this.letterGrade; }
        }
        public float Averrage
        {
            set { this.averrage = value; }
            get { return this.averrage; }
        }
        public float Min
        {
            set { this.averrage = value; }
            get { return this.averrage; }
        }
        public float Max
        {
            set { this.averrage = value; }
            get { return this.averrage; }
        }
        //---------------------------------------


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
        //-----------------------------------------------------------------------------------------------------------
        public void DelateGrades()
        {
            this.grades.Clear();
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

        }
        public Statistics GetStatistics()
        {
            Statistics st = new Statistics();

            PrepareDatasForStatistic(this.grades);
            st.Min = this.Min;
            st.Max = this.Max;
            st.Average = this.Averrage;
            st.LetterGrade = this.LetterGrade;

            return st;
        }
    }
}