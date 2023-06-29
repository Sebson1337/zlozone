using System;

enum Plec
{
    mezczyzna,
    kobieta
}

struct Student
{
    public string Nazwisko;
    public int NrAlbumu;
    public double Ocena;
    public Plec Plec;
}
class Program
{
    static void Main()
    {
        Student[] grupaStudentow = new Student[5];

        for (int i = 0; i < grupaStudentow.Length; i++)
        {
            Console.WriteLine("Wprowadź informacje" + (i + 1) + ":");
            WypelnijStudenta(ref grupaStudentow[i]);
            Console.WriteLine();
        }

        Console.WriteLine("Informacje o studentach:");
        WyswietlStudentow(grupaStudentow);

        double srednia = ObliczSrednia(grupaStudentow);
        Console.WriteLine("Średnia ocen w grupie: " + srednia);

        Console.ReadKey();
    }

    static void WypelnijStudenta(ref Student student)
    {
        Console.Write("Nazwisko: ");
        student.Nazwisko = Console.ReadLine();

        Console.Write("Nr albumu: ");
        student.NrAlbumu = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ocena: ");
        student.Ocena = Ogranicz(Convert.ToDouble(Console.ReadLine()));
        //zeby to zadzialalo trzeba wpisac dokladnie mezczyna lub kobieta
        Console.Write("Płeć mezczyna/kobieta (wpisane musi byc dokladnie): ");
        student.Plec = (Plec)Enum.Parse(typeof(Plec), Console.ReadLine(), true);
    }

    static void WyswietlStudentow(Student[] grupaStudentow)
    {
        foreach (var student in grupaStudentow)
        {
            Console.WriteLine("Nazwisko: " + student.Nazwisko +
                              ", Nr albumu: " + student.NrAlbumu +
                              ", Ocena: " + student.Ocena.ToString("0.0") +
                              ", Płeć: " + student.Plec);
        }
    }
     static double ObliczSrednia(Student[] grupaStudentow)
    {
        double sumaOcen = 0;
        foreach (var student in grupaStudentow)
        {
            sumaOcen += student.Ocena;
        }

        if (grupaStudentow.Length > 0)
        {
            return sumaOcen / grupaStudentow.Length;
        }
        else
        {
            return 0;
        }
    }
     static double Ogranicz(double ocena)
    {
        if (ocena < 2.0)
        {
            return 2.0;
        }
        else if (ocena > 5.0)
        {
            return 5.0;
        }
        else
        {
            return ocena;
        }
    }
}