using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeApp
{
    public class Employee
    {
        private string name;
        private string surname;
        

        private List<float> grades = new List<float>();
        public Employee() { }
        public Employee(string Name, string Surname)
        {
            this.name = Name;
            this.surname = Surname;
           
        }
        public string Name {
            get;
            private set; 
        }
        public string Surname
        {
            get;
            private set;
        }
        public void AddGrade(float grade)
        {
            this.grades.Add(grade);
        }
    }
}