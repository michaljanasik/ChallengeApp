// zad5, zliczanie wystapienia cyfr w liczbie


int[] counters = new int[58];//ascii 48=0 - 58=9
string cypherStr;

Console.WriteLine("\n\n Zliczamy wystąpienie cyfr w liczbie, podaj swoją\t\n");
cypherStr = Console.ReadLine();
Console.Clear();
Console.WriteLine($"Twoja liczba to {cypherStr}\n");
Console.WriteLine($"Składa sie z {cypherStr.Length} znaków");
Console.WriteLine($"Ilość znaków:\n");

foreach (char c in cypherStr)
{
    int index = (int)c;

    Console.Write(c + " ");

    counters[index] = counters[index] + 1;
}
Console.WriteLine();

for (int index = 48; index < 58; index++)
{
    Console.WriteLine($"liczba {index - 48} wystepuje {counters[index]}");

}