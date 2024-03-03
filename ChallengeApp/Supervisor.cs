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

        float min;
        float max;
        float average;
        string letterGrade;

        public string sayHello => throw new NotImplementedException("This is to see again...");

        List<float> grades = new List<float>();


        public Supervisor()
        {
            this.name = this.surname = "no data";
        }

        public string Name
        {
            set { this.Name = value; }
            get { return this.name; }
        }
        public string Surname
        {
            set { this.Surname = value; }
            get { return this.surname; }
        }
        public string LetterGrade
        {
            set { this.letterGrade = value; }
            get { return this.letterGrade; }
        }
        public float Average
        {
            set { this.average = value; }
            get { return this.average; }
        }
        public float Min
        {
            set { this.min = value; }
            get { return this.min; }
        }
        public float Max
        {
            set { this.max = value; }
            get { return this.max; }
        }

        //---------------------------------------------------------------------
        public void AddGrade(string mystring)
        {
            char[] tmp=mystring.ToCharArray();

            if (tmp[0] =='-')
            {
                if (mystring.Length > 0 && mystring.Length <= 3)
                {
                    char[] txtchar = mystring.ToCharArray();
                    float number;
                    if (float.TryParse(txtchar, out number))
                    {
                        number=Math.Abs(number);
                        number -= (float)0.5;
                        this.AddGrade(number);
                    }

                }
            }
            else if (mystring.Length > 0 && mystring.Length <= 2)
            {
                char[] txtchar = mystring.ToCharArray();
                float number;
                if (float.TryParse(txtchar, out number)) this.AddGrade(number);
            }

            else
            {
                
                throw new Exception("Error inside supervisor class - conversion"); 
            }

        }
       
        public void AddGrade(char letter)
        {
            letter = char.ToUpper(letter);

            switch (letter)
            {
                case 'A': { this.AddGrade(10); break; }
                case 'B': { this.AddGrade(8); break; }
                case 'C': { this.AddGrade(6); break; }
                case 'D': { this.AddGrade(4); break; }
                case 'E': { this.AddGrade(2); break; }
            }


        }
       
        public void AddGrade(float grade)
        {
            if ((grade <= 10 && grade > 0)|| (grade >=- 10 && grade < 0))
            {

                this.grades.Add(grade);
            }
            else
            {
                throw new ArgumentException("\n\n\tNumber must be between (+/-)1-10\n");
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

        void PrepareDatasForStatistic(List<float> Grades)
        {
            this.Min = Grades.Min();
            this.Max = Grades.Max();
            this.Average = Grades.Sum() /Grades.Count();

            switch (this.Average)
            {
                case > 8: { this.letterGrade = "A"; break; }
                case > 6: { this.letterGrade = "B"; break; }
                case > 4: { this.letterGrade = "C"; break; }
                case > 2: { this.letterGrade = "D"; break; }
                case > 1: { this.letterGrade = "E"; break; }
            }
            
        }






        public void DeleteGrades() { this.grades.Clear(); }

        public Statistics GetStatistics()
        {
            PrepareDatasForStatistic(this.grades);

            Statistics st = new Statistics();
            st.Max= this.Max;
            st.Min= this.Min;
            st.Average = this.Average;
            st.LetterGrade= this.LetterGrade;
           

            return st;
        }

        //-----------------------------------------------------------------------
    }
}
