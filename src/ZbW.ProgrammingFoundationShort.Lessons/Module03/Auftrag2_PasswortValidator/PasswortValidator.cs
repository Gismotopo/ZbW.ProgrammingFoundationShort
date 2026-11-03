namespace ZbW.ProgrammingFoundationShort.Lessons.Module03.Auftrag2_PasswortValidator;

// ============================================================
// AUFTRAG 2 – PasswortValidator (⭐⭐ Mittel | ~30 Min.)
//
// Validiert ein Passwort und fordert erneute Eingabe per do-while.
//
// Anforderungen:
//   - do-while-Schleife: solange Passwort ungültig
//   - gültig: mindestens 8 Zeichen UND mindestens eine Ziffer
//   - Ziffer mit foreach über die Zeichen + char.IsDigit(...) suchen
//   - Fehlermeldung: was fehlt
// ============================================================

public static class PasswortValidator
{
  public static void Start()
  {
    // TODO 1: string passwort; bool gueltig;
    //         do { ... } while (!gueltig);

    string pw;
    bool gueltig = false;

    Console.Write("Gib dein PW ein: ");

    do
    {

      // TODO 2: In der Schleife Passwort einlesen (Console.ReadLine() ?? "")

      pw = Console.ReadLine() ?? "";

      // TODO 3: bool hatZiffer = false;
      //         foreach (char zeichen in passwort) → char.IsDigit(zeichen) prüfen

      bool hatZiffer = false;

      foreach(char zeichen in pw)
      {
        if (char.IsDigit(zeichen)) { hatZiffer = true; break; }
      }

      // TODO 4: gueltig berechnen und konkrete Fehlermeldung ausgeben

      if(hatZiffer && pw.Length >= 8) { gueltig = true; break; }
      if (!hatZiffer) { Console.WriteLine("PW muss eine Zahl enthalten"); }
      if (pw.Length < 8) { Console.WriteLine("PW zu kurtz mind. 8 Zeichen"); }
      
      Console.Write("next try: ");

    } while (!gueltig);

    // TODO 5: Nach der Schleife Erfolgsmeldung ausgeben

    Console.WriteLine($"\"{pw}\" ist eing Gültiges Passwort");
  }
}
