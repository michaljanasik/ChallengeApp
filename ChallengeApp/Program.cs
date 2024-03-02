using challangeApp;

Employee empl = new Employee();


try
{
    Start();
}
catch (Exception ex)
{
    Console.WriteLine("\nMessages and errors:\n\t" + ex.Message + "\n\n");
    Console.WriteLine("//---------------------------------FULL MESSAGE IS:-----------------------------------");
    Console.WriteLine("\n\n" + ex + "\n\n");
    Console.WriteLine("//------------------------------------------------------------------------------------");
    Console.ReadKey();
}
finally
{
    Console.WriteLine("\n\n\t\tBye....");
}



//-----------------------------------------------------------
//----------------------definicje funkcji--------------------
//-----------------------------------------------------------

int Start()
{
    string yourChoise = "";

    while ((yourChoise) != "Q")
    {

        yourChoise = Menu();

        if (yourChoise.Length > 0 && yourChoise.Length < 2)
        {
            if (char.IsAsciiLetterLower(yourChoise[0]))
            {
                char[] tmp = yourChoise.ToCharArray();
                tmp[0] = char.ToUpper(tmp[0]);
                yourChoise = tmp[0].ToString();
            }
            else if (yourChoise.Length == 0)
            {
                yourChoise = Menu();
            }

        }

        ManageMenuChoise(yourChoise);
    }

    return 1;
}

string Menu()
{
    string key;

    Console.WriteLine("\n\tWelcome in my programm\n");
    Console.WriteLine("\tAdd grades -------- A");
    Console.WriteLine("\tShow grade table -- G");
    Console.WriteLine("\tShow statistics --- S");
    Console.WriteLine("\tDelate Grades --- S");
    Console.WriteLine();
    Console.WriteLine("\tClear screen ------ C");
    Console.WriteLine("\n\tQuit ---------------- Q\n");

    return key = Console.ReadLine();
}
void ManageMenuChoise(string MyChoose)
{
    switch (MyChoose)
    {
        case "A": { AddDataToEmployee(); break; }
        case "G": { ShowEmployeDatas(); break; }
        case "S": { ShowStatisyics(empl.GetStatistics()); break; }
        case "D": { DelateGrades(); break; }
        case "C": { Console.Clear(); break; }
    }

}

void AddDataToEmployee()
{
    while (true)
    {
        string dane;

        Console.WriteLine("\nPodaj liczbe lub litere A-D\n");
        Console.WriteLine("Exit by pressed Q");

        dane = Console.ReadLine();
        dane = dane.ToUpper();

        if (dane[0] == 'Q') { break; }

        empl.AddGrade(dane);

        Console.WriteLine("Added");

    }
}
void ShowEmployeDatas()
{
    empl.ShowGrades();
    Console.WriteLine($"Name: {empl.Name}, Surname: {empl.Surname}," +
        $" Grade:{empl.LetterGrade}, Average: {empl.Averrage}");
}
void ShowStatisyics(Statistics stat)
{
    Console.WriteLine($"\n\nMin = {stat.Min} Max = {stat.Max}  Average = {stat.Average}  LetterGrade = {stat.LetterGrade}");
}
void DelateGrades()
{
    empl.DelateGrades();
}


