using ChallengeApp;

using System.Diagnostics.Metrics;
using System.Runtime.CompilerServices;

Console.WriteLine("Pracownicy");
Console.WriteLine("");

List<Employee> employees = new List<Employee>();

employees.Add(new Employee("Adam", "Wróbel", 34));
employees.Add(new Employee("ewa", "Kowalska", 32));
employees.Add(new Employee("Ada", "Wasik", 23));

employees[0].AddScore(9);
employees[0].AddScore(1);
employees[0].AddScore(9);
employees[0].AddScore(1);
employees[0].AddScore(9);

employees[1].AddScore(4);
employees[1].AddScore(1);
employees[1].AddScore(10);
employees[1].AddScore(10);
employees[1].AddScore(1);

employees[2].AddScore(1);
employees[2].AddScore(1);
employees[2].AddScore(2);
employees[2].AddScore(1);
employees[2].AddScore(10);

int[] temp;

Console.WriteLine("Employee1 scores\n");
temp = employees[0].GetAllScores();
foreach (int t in temp)
{
    Console.Write(t + " ");

}

Console.WriteLine("\nEmployee2 scores\n");
temp = employees[1].GetAllScores();
foreach (int t in temp)
{
    Console.Write(t + " ");

}

Console.WriteLine("\nEmployee3 scores\n");
temp = employees[2].GetAllScores();
foreach (int t in temp)
{
    Console.Write(t + " ");

}


// searched employee with high score
int counter = employees.Count();
int[] scores = new int[counter];
for (int i = 0; i < counter; i++)
{
    scores[i] = employees[i].SumScore();
}
counter = Array.IndexOf(scores, scores.Max());
employees[counter].ShowEmployee();

