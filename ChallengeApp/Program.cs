using challangeApp;

var employee = new Employee();
Statistics st = new Statistics();

string answer;
char esc;

try
{
    Console.Clear();
    do
    {

        Console.WriteLine("////Welcome in my programm\n\n");
        Console.WriteLine("Choose option from Menu below");

        Console.WriteLine("Add grade - A");
        Console.WriteLine("Take a score  - B");
        Console.WriteLine("Statistics - C");
        // Console.WriteLine("Dodaj pracownika - D");
        Console.WriteLine("Clear screen - E");

        answer = Console.ReadLine();

        esc = answer[0];
        esc = char.ToUpper(esc);


        switch (esc)
        {
            case 'A':
                {
                    int IntClear = 8;

                    char[] TablChr;
                    double mydouble;


                    while (true)
                    {
                        IntClear--;

                        if (IntClear == 0) Console.Clear();

                        Console.WriteLine("Give a points or laetter's grade A-E\n");
                        Console.WriteLine("Escape from menu pressing --Q");

                        TablChr = (Console.ReadLine()).ToCharArray();
                        double.TryParse(TablChr, out mydouble);

                        if (char.IsLetter(TablChr[0]))
                        {
                            TablChr[0] = char.ToUpper(TablChr[0]);
                            if (TablChr[0] == 'Q')
                            {
                                break;
                            }
                            else if (char.IsLetter(TablChr[0]))
                            {
                                employee.AddGrade(TablChr[0]);

                            }
                        }
                        else
                        {
                            employee.AddGrade(mydouble);
                        }


                    }

                    break;
                }
            case 'B':
                {//60
                    employee.showAllGrades();
                    Console.ReadKey();
                    break;
                }
            case 'C':
                {//40
                    employee.getStatistics();
                    Console.ReadKey();
                    break;
                }
            case 'D':
                {//20

                    break;
                }
            case 'E':
                {
                    Console.Clear();
                    break;
                }
            default:
                {
                    // Console.WriteLine("wrong letter");

                    break;
                }
        }
    } while (esc != 'Q');
}

catch (Exception e)
{
    Console.WriteLine(e.ToString());
}
