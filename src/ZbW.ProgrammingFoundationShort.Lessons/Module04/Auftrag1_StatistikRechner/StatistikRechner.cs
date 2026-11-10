using System.ComponentModel.DataAnnotations;

namespace ZbW.ProgrammingFoundationShort.Lessons.Module04.Auftrag1_StatistikRechner;

// ============================================================
// AUFTRAG 1 – StatistikRechner (⭐ Einfach | ~15 Min.)
//
// Liest 5 Zahlen ein und berechnet Minimum, Maximum, Durchschnitt.
//
// Anforderungen:
//   - int[5]-Array per Konsoleneingabe befüllen
//   - Methoden: Minimum(int[]), Maximum(int[]), Average(int[])
//   - Ergebnis ausgeben
// ============================================================

public static class StatistikRechner
{
  public static void Start()
  {
    // TODO 1: int[5]-Array deklarieren
    //         5 Zahlen einlesen und im Array speichern

    int[] numbers = new int[5];

    Console.WriteLine("Gib 5 Nummern ein (1,2,3,4,5)");
    
    for (int i = 0; i < 5; i++)
    {
      Console.Write($"Nummer {i + 1}: ");
      
      while (!int.TryParse(Console.ReadLine() ?? "", out numbers[i]))
      {
        Console.Write("Ungültig neuer Versuch: ");
      }      
    }

    // TODO 2: Methoden aufrufen und Ergebnis ausgeben
    //         Console.WriteLine($"Min: {Minimum(zahlen)}, Max: {Maximum(zahlen)}, Avg: {Average(zahlen):F2}");

    Console.WriteLine($"Min: {Minimum(numbers)}");
    Console.WriteLine($"Max: {Maximum(numbers)}");
    Console.WriteLine($"AVG: {Average(numbers)}");

  }

  public static int Minimum(int[] zahlen)=> zahlen.Min();
  

  public static int Maximum(int[] zahlen)
  {
    // TODO: Grösste Zahl finden (Schleife, kein LINQ)
    int bigNumber = int.MinValue;

    for (int i = 0; i < 5; i++)
    {
      if (zahlen[i] > bigNumber) { bigNumber = zahlen[i]; }
    }
    return bigNumber;    
  }

  public static double Average(int[] zahlen) =>Convert.ToDouble(zahlen.Sum()) / (zahlen.Length);
  // TODO: Durchschnitt berechnen (Summe / Länge)
    
}
