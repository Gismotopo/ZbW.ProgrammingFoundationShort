namespace ZbW.ProgrammingFoundationShort.Lessons.Module02.Auftrag1_Notenrechner;

// ============================================================
// AUFTRAG 1 – Notenrechner (⭐ Einfach | ~15 Min.)
//
// Berechne eine Note anhand von Punkten mittels if/else-Kette.
//
// Anforderungen:
//   - TxtPunkte: Punktezahl (0–100) einlesen
//   - if/else-Kette:
//       90–100 → Note 6 / "Sehr gut"
//       75–89  → Note 5 / "Gut"
//       60–74  → Note 4 / "Genügend"
//       < 60   → Note 3 / "Ungenügend"
//   - Ergebnis in LblNote und LblBewertung anzeigen
// ============================================================

public partial class NotenrechnerForm : Form
{
  public NotenrechnerForm()
  {
    InitializeComponent();
  }

  private void CmdBerechnen_Click(object sender, EventArgs e)
  {
    // TODO 1: Punkte aus TxtPunkte lesen (int.TryParse)
    //         Bei ungültiger Eingabe: MessageBox anzeigen und return

    if (!int.TryParse(TxtPunkte.Text, out int points) || points > 101 || points < 0) { MessageBox.Show($"Eingabe \"{TxtPunkte.Text}\" ist ungültig \n Punkte im Berreich 0-100", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

    // TODO 2: if/else-Kette für Noten
    //         90-100 → Note 6 / "Sehr gut"
    //         75-89  → Note 5 / "Gut"
    //         60-74  → Note 4 / "Genügend"
    //         < 60   → Note 3 / "Ungenügend"



    var (note, bewertung)= NoteBewertung(points: points);



    // TODO 3: LblNote.Text und LblBewertung.Text setzen

    LblNote.Text = $"{note}";
    LblBewertung.Text = $"{bewertung}";

  }

  private (int note, string bewertung) NoteBewertung(int points)
  {
    if (points >= 90) { return (6, "Sehr gut"); }
    if (points >= 75) { return (5, "Gut"); }
    if (points >= 60) { return (4, "Genügend"); }
    else { return (3, "Ungenügend"); }
  }
}
