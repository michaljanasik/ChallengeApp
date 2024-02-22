using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeApp
{
    public class User
    {
        private string name;
        private string surname;
        private int age;

        private List<int> scores = new List<int>();
        public User() { }
        public User(string Name, string Surname, int Age)
        {
            this.name = Name;
            this.surname = Surname;
            this.age = Age;
        }
        public void AddScore(int Score)
        {
            if (Score >= 1 && Score <= 10)
            {
                this.scores.Add(Score);
            }
            else if (Score < 0 && Score >= -10)
            {
                this.scores.Add(Score);
            }
            else
            {
                Console.WriteLine("Can add 1-10 only\n");
            }
        }
        public int[] GetAllScores()
        {
            return this.scores.ToArray();
        }
        public int SumScore()
        {
            return this.scores.Sum();
        }
        public void ShowEmployee()
        {
            Console.WriteLine($"\n\nImie {this.name} Nazwisko {this.surname} wiek {this.age} punkty {this.SumScore()}\t");
        }
    }
}