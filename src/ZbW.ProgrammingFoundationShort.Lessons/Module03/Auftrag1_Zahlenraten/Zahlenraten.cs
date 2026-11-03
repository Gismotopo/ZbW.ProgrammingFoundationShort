namespace ZbW.ProgrammingFoundationShort.Lessons.Module03.Auftrag1_Zahlenraten;

// ============================================================
// AUFTRAG 1 – Zahlenraten (⭐ Einfach | ~15 Min.)
//
// Das Programm generiert eine Zufallszahl und der Benutzer
// versucht sie zu erraten.
//
// Anforderungen:
//   - Random-Zahl zwischen 1 und 100 generieren
//   - while-Schleife bis geraten
//   - Hinweise: "Zu klein" / "Zu gross"
//   - Versuchszähler und Glückwunsch am Ende
// ============================================================

public static class Zahlenraten
{
  public static void Start()
  {
    // TODO 1: Random-Objekt erstellen, Zufallszahl 1-100 generieren
    var random = new Random();
    int geheimzahl = random.Next(1, 101);

    // TODO 2: Variablen für Versuchszähler und geraten-Flag

    int versuch = 0;
    bool geraten = true;

    // TODO 3: while-Schleife (!geraten)
    //         - Eingabe lesen
    //         - int.TryParse prüfen
    //         - Hinweis ausgeben (zu klein / zu gross / richtig)
    //         - Versuchszähler erhöhen

    Console.Write($"Zahl zwichen 1-100: ");

    while (geraten)
    {
      if (!int.TryParse(Console.ReadLine() ?? "", out int num) || num < 1 || num > 100)
      {
        Console.WriteLine("Ungültige Eingabe");        
      }
      else if (num == geheimzahl) { geraten = false; break; }
      else if (num > geheimzahl) { Console.WriteLine("zu hoch");}
      else { Console.WriteLine("zu tief"); }

      Console.Write("Next try: ");

      versuch += 1; ;
    }

    // TODO 4: Glückwunsch mit Anzahl Versuche ausgeben

    Console.WriteLine($"Glückwunsch du hast \"nur\" {versuch} versuche gebraucht");
  }
}



