
var imie = "EWA";
var wiek = "30";
var plec = "K";


Console.WriteLine("Witam \n prosze o podaniu kilku danych:\n");
Console.WriteLine("Podaj imie\n"); ;
imie = Console.ReadLine().ToUpper();
Console.WriteLine("Podaj wiek\n");
wiek = Console.ReadLine();
Console.WriteLine("Podaj plec K/M");
plec = Console.ReadLine().ToUpper();

Console.Clear();
//Console.WriteLine("\n\n\n\tDane wprowadzone to: \n\t\t Twoie imie "+imie+" Twoj wiek: "+wiek+" Plec: "+plec);
try
{
    if (plec == "K" && Int16.Parse(wiek) < 30)
    {
        Console.Clear();
        Console.WriteLine("\n\t Kobieta ponizej 30 lat\n");
    }
    else if (imie == "EWA" && wiek == "30" && plec == "K")
    {
        Console.Clear();
        Console.WriteLine("\n\n\t Ewa lat 30\n");

    }
    else if (plec == "M" && Int16.Parse(wiek) < 30)
    {
        Console.Clear();
        Console.WriteLine("\nMezczyzna niepelnoletni\n");
    }
    else
    {
        Console.Clear();

    }

}
catch (Exception ex)
{
    Console.Clear();
    Console.Write("Dane wprowadzane zawieraly nieprawidlowe wartosci i wystapil blad systemowy:\n\n" + ex.Message.ToString());
    Console.WriteLine("\n\n\n\n\n\n");
}
