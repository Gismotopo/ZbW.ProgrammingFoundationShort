namespace ZbW.ProgrammingFoundationShort.Lessons.Module05.Auftrag3_FilmarchivAuswertung;

// ============================================================
// AUFTRAG 3 – FilmarchivAuswertung (⭐⭐⭐ Erweitert | ~30 Min.)
//
// Wertet ein Filmarchiv mit Dictionary, foreach und if aus.
// LINQ ist nur Bonus und wird hier nicht vorausgesetzt.
//
// Anforderungen:
//   - Dictionary<string, int>: Film → Erscheinungsjahr
//   - Alle Filme mit foreach ausgeben
//   - Filme ab 2000 mit foreach + if ausgeben
//   - Frühstes/spätestes Jahr und Anzahl Filme nach 2010 zählen
//   - Bonus: Dieselben Auswertungen mit LINQ lösen
// ============================================================

public static class FilmarchivAuswertung
{
  public static Dictionary<string, int> _filme = new Dictionary<string, int>();
  public static void Start()
  {
    // TODO 1: Dictionary mit 8 Filmen anlegen
    //         "The Shawshank Redemption" → 1994, "The Dark Knight" → 2008, ...

    dicVorBefüllenAIListe();

    // TODO 2: Mit foreach und if auswerten:
    //         - Alle Filme ausgeben
    //         - Alle Filme ab 2000 ausgeben
    //         - Frühstes Erscheinungsjahr bestimmen
    //         - Spätestes Erscheinungsjahr bestimmen
    //         - Anzahl Filme nach 2010 zählen

    Console.WriteLine($"Alle Filme Ausgeben = (1) / Alle ab 2000 = (2) / Früstes,Spähtestes Erschienungsdatum = (3) / Anzahl nach 2010 = (4)");
    Console.Write("Wähle Ausgabe: ");

    if(!int.TryParse(Console.ReadLine() ?? "" , out int auswahl) || auswahl < 1 || auswahl > 4)
    {
      Console.WriteLine("Error");
    }
    else
    {
      switch (auswahl)
      {
        case 1:
          AlleAusgeben();
          break;

        case 2:
          AlleAb2000();
          break;

        case 3:
          FrühSpätesterFilm();
          break;

        case 4:
          Ab2010();
          break;

        default:
          Console.WriteLine("Error");
          break;
      }
    }

    

    // TODO 3: Ergebnisse ausgeben

    // BONUS: Dieselben Auswertungen zusätzlich mit LINQ formulieren.
  }

  private static void dicVorBefüllenAIListe()
  {
    _filme["Der Pate"] = 1972;
    _filme["Die Verurteilten"] = 1994;
    _filme["Pulp Fiction"] = 1994;
    _filme["Forrest Gump"] = 1994;
    _filme["Der Herr der Ringe: Die Gefährten"] = 2001;
    _filme["Der Herr der Ringe: Die zwei Türme"] = 2002;
    _filme["Der Herr der Ringe: Die Rückkehr des Königs"] = 2003;
    _filme["Inception"] = 2010;
    _filme["The Dark Knight"] = 2008;
    _filme["Matrix"] = 1999;
    _filme["Fight Club"] = 1999;
    _filme["Star Wars: Eine neue Hoffnung"] = 1977;
    _filme["Das Imperium schlägt zurück"] = 1980;
    _filme["Die Rückkehr der Jedi-Ritter"] = 1983;
    _filme["Zurück in die Zukunft"] = 1985;
    _filme["Terminator 2"] = 1991;
    _filme["Das Schweigen der Lämmer"] = 1991;
    _filme["Schindlers Liste"] = 1993;
    _filme["Jurassic Park"] = 1993;
    _filme["Der König der Löwen"] = 1994;
    _filme["Léon – Der Profi"] = 1994;
    _filme["Braveheart"] = 1995;
    _filme["Se7en"] = 1995;
    _filme["Toy Story"] = 1995;
    _filme["Titanic"] = 1997;
    _filme["Das fünfte Element"] = 1997;
    _filme["Das Leben ist schön"] = 1997;
    _filme["Gladiator"] = 2000;
    _filme["Memento"] = 2000;
    _filme["Chihiros Reise ins Zauberland"] = 2001;
    _filme["Harry Potter und der Stein der Weisen"] = 2001;
    _filme["Fluch der Karibik"] = 2003;
    _filme["Findet Nemo"] = 2003;
    _filme["Der Pianist"] = 2002;
    _filme["Departed – Unter Feinden"] = 2006;
    _filme["Prestige"] = 2006;
    _filme["WALL·E"] = 2008;
    _filme["Oben"] = 2009;
    _filme["Avatar"] = 2009;
    _filme["Interstellar"] = 2014;
    _filme["Mad Max: Fury Road"] = 2015;
    _filme["Der Marsianer"] = 2015;
    _filme["Django Unchained"] = 2012;
    _filme["Die Eiskönigin"] = 2013;
    _filme["Gravity"] = 2013;
    _filme["Whiplash"] = 2014;
    _filme["Parasite"] = 2019;
    _filme["Joker"] = 2019;
    _filme["Dune"] = 2021;
    _filme["Oppenheimer"] = 2023;
  }

  private static void AlleAusgeben()
  {
    Console.WriteLine("Alle Filme");
    Console.WriteLine();

    foreach(var pair in _filme)
    {
      Console.WriteLine($"{pair.Key} -> {pair.Value}");
    }
  }

  private static void AlleAb2000()
  {
    Console.WriteLine("Alle Filme ab 2000");
    Console.WriteLine();

    foreach (var pair in _filme.Where(pair => pair.Value >= 2000))
    {
      Console.WriteLine($"{pair.Key} -> {pair.Value}");
    }
  }

  private static void FrühSpätesterFilm()
  {
    Console.WriteLine($"Spähtestes Erscheinungsdatum: {_filme.Max(f => f.Value)}");
    Console.WriteLine($"Frühstes Erscheinungsdatum: {_filme.Min(f => f.Value)}");
       
  }

  private static void Ab2010()
  {
    Console.WriteLine("Alle ab 2010:");
    Console.WriteLine();

    foreach(KeyValuePair<string,int> pair in _filme.Where(KeyValuePair => KeyValuePair.Value >= 2010))
    {
      Console.WriteLine($"{pair.Key} -> {pair.Value}");
    }
  }
}
