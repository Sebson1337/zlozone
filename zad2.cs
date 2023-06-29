using System;

struct Student
{
    public string Imie;
    public string Nazwisko;
    public int RokStudiow;
}
struct Przedmiot
{
    public string Nazwa;
    public string Kod;
}
struct NauczycielAkademicki
{
    public string Imie;
    public string Nazwisko;
    public string StopienNaukowy;
}
class Program
{
    static void Main()
    {
        Student student1;
        student1.Imie = "Sebastian";
        student1.Nazwisko = "Ja";
        student1.RokStudiow = 1;
        Przedmiot przedmiot1;
        przedmiot1.Nazwa = "Cwiczenia";
        przedmiot1.Kod = "INF13234623";
        NauczycielAkademicki nauczyciel1;
        nauczyciel1.Imie = "Joanna";
        nauczyciel1.Nazwisko = "Kowalska";
        nauczyciel1.StopienNaukowy = "dr";
        Console.WriteLine("Student:");
        Console.WriteLine("Imię: " + student1.Imie);
        Console.WriteLine("Nazwisko: " + student1.Nazwisko);
        Console.WriteLine("Rok studiów: " + student1.RokStudiow);
        Console.WriteLine("\nPrzedmiot:");
        Console.WriteLine("Nazwa: " + przedmiot1.Nazwa);
        Console.WriteLine("Kod: " + przedmiot1.Kod);
        Console.WriteLine("\nNauczyciel akademicki:");
        Console.WriteLine("Imię: " + nauczyciel1.Imie);
        Console.WriteLine("Nazwisko: " + nauczyciel1.Nazwisko);
        Console.WriteLine("Stopień naukowy: " + nauczyciel1.StopienNaukowy);
        Console.ReadKey();
    }
}
