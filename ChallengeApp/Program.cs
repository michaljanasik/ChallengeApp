using challangeApp;

using static System.Runtime.InteropServices.JavaScript.JSType;


Employee empl1 = new Employee();
Supervisor sup1 = new Supervisor();

string yourChoice = "Z";
string usrChoice = "no user";


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

void Start()
{
    RunMenu();


}

void RunMenu()
{
    string tmp = "Z";

    while ((tmp) != "Q")
    {                                   //all menus are giving Q to Esc
        tmp = "Z";
        tmp = MenuUsers();

    }
    if (usrChoice == "S" || usrChoice == "E")
    {
        tmp = "Z";
        while (tmp != "Q")
        {
            tmp = MenuUsers();
        }
    }
    usrChoice = "no user";
    yourChoice = "Z";


}

//--------------------------------------Menu for users ---------------------------------------

string MenuUsers()
{
    string key;

    Console.WriteLine("\n\tWelcome in my programm\n");
    Console.WriteLine($"\n\n Actually choosed user is: {usrChoice}.");
    Console.WriteLine("\n\nChoose the user:\n");
    Console.WriteLine("\tSupervaisor --------- S");
    Console.WriteLine("\tEmployee ------------ E    Statistics and other funcions are working only for Employee");
    Console.WriteLine("\n\t Manage user ------ M    To add grades and see statistics press M and follw subMenu");
    Console.WriteLine("\nClear screen -------- C");

    Console.WriteLine("\n\tQuit ---------------- Q\n");

    key = Console.ReadLine();

    if (key.Length > 0 && key.Length < 2)
    {
        if (char.IsAsciiLetterLower(key[0]))
        {
            char[] tmp = key.ToCharArray();
            tmp[0] = char.ToUpper(tmp[0]);
            key = tmp[0].ToString();
        }

    }
    else if (key.Length == 0)
    {
        throw new Exception("\nwrong datas\n");
    }
    switch (key)
    {
        case "S":
            usrChoice = "S";
            break;
        case "E":
            usrChoice = "E";
            break;
        case "Q":
            return key = "Q";
            break;
        case "M":
            if (usrChoice == "no user") {; }
            else { GetAnswerFromMenu(MenuInternal(), usrChoice); }
            return key = "Z";
            break;
        case "C":
            Console.Clear();
            break;
        default:
            Console.WriteLine("Choose other one person or escape by - Q");
            break;
    }
    return key;
}
//-------------------------------------Menu internal add/show datas-------------------
string MenuInternal()
{
    string key;


    Console.WriteLine("\n\tAdd grades ------ A");
    Console.WriteLine("\tShow grade table -- G");
    Console.WriteLine("\tShow statistics --- S");
    Console.WriteLine("\tDelate Grades ----- D");
    Console.WriteLine();
    Console.WriteLine("\tClear screen ------ C");

    Console.WriteLine("\n\tQuit -------------- Q\n");

    key = Console.ReadLine();

    if (key.Length > 0 && key.Length < 2)
    {

        if (char.IsAsciiLetterLower(key[0]))
        {
            char[] tmp = key.ToCharArray();
            tmp[0] = char.ToUpper(tmp[0]);
            key = tmp[0].ToString();
        }



    }
    else if (yourChoice.Length == 0)
    {
        throw new Exception("\nwrong datas\n");
    }

    return key;
}

//--------------------------Menu; elaborate answer-------------------------------------------------

void GetAnswerFromMenu(string yourChoice, string usrChoice)
{


    switch (usrChoice)
    {
        case "S":
            {
                switch (yourChoice)
                {
                    case "A": { AddData(); break; }
                    case "G": { ShowDatas(usrChoice); break; }
                    case "S": { ShowStatistics(sup1.GetStatistics()); break; }
                    case "D": { DeleteGrades(usrChoice); break; }


                    case "C": { Console.Clear(); break; }
                }
                break;
            }
        case "E":
            {
                switch (yourChoice)
                {
                    case "A": { AddData(); break; }
                    case "G": { ShowDatas(usrChoice); break; }
                    case "S": { ShowStatistics(empl1.GetStatistics()); break; }
                    case "D": { DeleteGrades(usrChoice); break; }
                    case "C": { Console.Clear(); GetAnswerFromMenu(MenuInternal(), usrChoice); break; }
                }

                break;
            }
        case "C": { GetAnswerFromMenu(MenuInternal(), usrChoice); break; }
        case "Q": break;
       
    }

}
//--------------------------------------Functions, the same for all users------------------------------

void AddData()
{
    while (true)
    {
        string dane;

        switch (usrChoice) {

            case "S":  
                 Console.WriteLine("\n Give number from -1 to -10 or from 1 to 10");
                  Console.WriteLine("Exit by pressed Q");
                break;
            case "E":
                Console.WriteLine("\nPodaj liczbe lub litere A-D\n");
                Console.WriteLine("Exit by pressed Q");

                break;    
         }
        dane = Console.ReadLine();
        dane = dane.ToUpper();
        
       if (dane[0] == 'Q') { GetAnswerFromMenu(MenuInternal(), usrChoice); break; }
        if (usrChoice == "S") { sup1.AddGrade(dane); }
        else if (usrChoice=="E") { empl1.AddGrade(dane); }
        

        Console.WriteLine("Added");

    }
}
//---------------------------------------------------------------------------

 void ShowDatas(string userChoise)
{
    if (userChoise == "S")
    {
        sup1.ShowGrades();

        Console.WriteLine($"Name: {sup1.Name}, Surname: {sup1.Surname}");
        Console.ReadKey();
        GetAnswerFromMenu(MenuInternal(), usrChoice);
    }
    else
    {

        empl1.ShowGrades();

        Console.WriteLine($"Name: {empl1.Name}, Surname: {empl1.Surname}," +
        $" Grade:{empl1.LetterGrade}, Average: {empl1.Averrage}");
        Console.ReadKey();
        GetAnswerFromMenu(MenuInternal(), usrChoice);
    }
}
//-----------------------------------------------------------
void ShowStatistics(Statistics stat)
{
    if (usrChoice == "S")
    {
        Console.WriteLine("\n Supervisor statistics:\n\n");
        Console.WriteLine($"\n\nMin = {stat.Min} Max = {stat.Max}  Average = {stat.Average} " +
            $" LetterGrade = {stat.LetterGrade}");
    }
    else if(usrChoice=="E")
    {
        Console.WriteLine("\n Employees statistics:\n\n");
        Console.WriteLine($"\n\nMin = {stat.Min} Max = {stat.Max}  Average = {stat.Average} " +
            $" LetterGrade = {stat.LetterGrade}");
    }
    Console.ReadKey();
    GetAnswerFromMenu(MenuInternal(), usrChoice);
}
//----------------------------------------------------------------------------------
void DeleteGrades(string userChoise)
{
    if (userChoise == "S") { sup1.DeleteGrades(); }
    else { empl1.DelateGrades(); }
}



//-----------------------------------------The end-----------------------------------------------
