namespace ZbW.ProgrammingFoundationShort.Lessons.Module04.Auftrag2_NotenVerwaltung;

// ============================================================
// AUFTRAG 2 – NotenVerwaltung (⭐⭐ Mittel | ~30 Min.)
//
// Verwaltet bis zu 10 Noten in einem double[]-Array.
//
// Anforderungen:
//   - TxtNote: Note (1.0–6.0) eingeben, CmdHinzufuegen: Note ins Array
//   - Zähler _anzahl für belegte Plätze, Button deaktivieren, wenn voll
//   - Methoden MIT Parametern: Average/Best/Worst(double[] noten, int anzahl)
//   - LblNoten: Noten sortiert als Komma-Liste (Kopie mit Array.Copy, dann Array.Sort)
//   - LblStats: Durchschnitt, beste und schlechteste Note
// ============================================================

public partial class NotenVerwaltungForm : Form
{
  // TODO 1: Felder deklarieren
  //         private double[] _noten = new double[10];
  //         private int _anzahl = 0;

  private double[] _noten = new double[10];
  private int _anzahl = 0;

  public NotenVerwaltungForm()
  {
    InitializeComponent();
    this.AcceptButton = CmdHinzufuegen;
  }

  private void CmdHinzufuegen_Click(object sender, EventArgs e)
  {
    // TODO 2: Note validieren (double.TryParse, 1.0–6.0)

    if (!double.TryParse(TxtNote.Text, out double note) || note < 1.0 || note > 6.0)
    {
      MessageBox.Show("Ungültige eingabe");
      return;
    }

    // TODO 3: Note ins Array schreiben und _anzahl erhöhen

    _noten[_anzahl] = note;

    _anzahl++;

    TxtNote.Clear();
    TxtNote.Focus();

    // TODO 4: Wenn voll: CmdHinzufuegen.Enabled = false;

    if (_anzahl == 10) { CmdHinzufuegen.Enabled = false; }

    // TODO 5: Anzeige aktualisieren (sortierte Kopie + Statistik)

    double[] copy = new double[_anzahl];

    Array.Copy(_noten, copy, copy.Length);

    Array.Sort(copy);

    LblNoten.Text = $"Noten: {string.Join(", ", copy)}";
    if (_anzahl > 1)
    {
      LblStats.Text = $"AVG: {Average(noten: copy, anzahl: _anzahl):F2} \n" +
                      $"Best: {Best(noten: copy, anzahl: _anzahl)} \n" +
                      $"Worst: {Worst(noten: copy, anzahl: _anzahl)}";
    }
  }

  private double Average(double[] noten, int anzahl) => noten.Average();
  // TODO: Durchschnitt der ersten "anzahl" Noten

  private double Best(double[] noten, int anzahl) => noten.Max();
  // TODO: Höchste Note finden

  private double Worst(double[] noten, int anzahl) => noten.Min();
  // TODO: Niedrigste Note finden
}
