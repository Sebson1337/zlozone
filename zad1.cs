using System;

public enum DniTygodnia
{
    Poniedziałek,
    Wtorek,
    Środa,
    Czwartek,
    Piątek,
    Sobota,
    Niedziela
}

public enum EtapyPrania
{
    WłożenieUbrań,
    WybórProgramu,
    DodanieDetergentu,
    RozpoczęciePrania,
    Płukanie,
    Wirowanie,
    ZakończeniePrania
}

public enum Posiłki
{
    Śniadanie,
    DrugieŚniadanie,
    Obiad,
    Podwieczorek,
    Kolacja
}

public enum BierekSzachowy
{
    Pionek,
    Skoczek,
    Goniec,
    Wieża,
    Hetman,
    Król
}

class Program
{
    static void Main()
    {
        DniTygodnia dzien = DniTygodnia.Wtorek;
        EtapyPrania etap = EtapyPrania.RozpoczęciePrania;
        Posiłki posilek = Posiłki.Obiad;
        BierekSzachowy bierka = BierekSzachowy.Skoczek;

        Console.WriteLine("Dzień tygodnia: " + dzien);
        Console.WriteLine("Etap prania: " + etap);
        Console.WriteLine("Posiłek: " + posilek);
        Console.WriteLine("Bierka szachowa: " + bierka);

        Console.ReadKey();
    }
}