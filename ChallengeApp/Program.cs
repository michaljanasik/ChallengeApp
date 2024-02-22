using ChallengeApp;

using System.Diagnostics.Metrics;
using System.Runtime.CompilerServices;

Console.WriteLine("Pracownicy");
Console.WriteLine("");

List<User> users = new List<User>();

users.Add(new User("Adam", "Wróbel", 34));
users.Add(new User ("ewa", "Kowalska", 32));
users.Add(new User("Ada", "Wasik", 23));

users[0].AddScore(9);
users[0].AddScore(1);
users[0].AddScore(9);
users[0].AddScore(1);
users[0].AddScore(9);

users[1].AddScore(5);
users[1].AddScore(-1);
users[1].AddScore(10);
users[1].AddScore(10);
users[1].AddScore(10);

users[2].AddScore(1);
users[2].AddScore(1);
users[2].AddScore(2);
users[2].AddScore(1);
users[2].AddScore(10);

int[] temp;

Console.WriteLine("Employee1 scores\n");
temp = users[0].GetAllScores();
foreach (int t in temp)
{
    Console.Write(t + " ");

}

Console.WriteLine("\nEmployee2 scores\n");
temp = users[1].GetAllScores();
foreach (int t in temp)
{
    Console.Write(t + " ");

}

Console.WriteLine("\nEmployee3 scores\n");
temp = users[2].GetAllScores();
foreach (int t in temp)
{
    Console.Write(t + " ");

}


// searched employee with high score
int counter = users.Count();
int[] scores = new int[counter];
for (int i = 0; i < counter; i++)
{
    scores[i] = users[i].SumScore();
}
counter = Array.IndexOf(scores, scores.Max());
users[counter].ShowEmployee();

