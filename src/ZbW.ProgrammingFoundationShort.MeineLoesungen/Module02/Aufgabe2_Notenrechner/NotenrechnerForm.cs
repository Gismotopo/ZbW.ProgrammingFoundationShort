namespace ZbW.ProgrammingFoundationShort.MeineLoesungen.Module02.Aufgabe2_Notenrechner;

/// <summary>
///   Aufgabe 2 – Notenrechner (⭐⭐ Mittel)
///   Bewertet eine Note von 1.0–6.0 mit Detailanzeige.
/// </summary>
public partial class NotenrechnerForm : Form
{
  public NotenrechnerForm()
  {
    InitializeComponent();
  }

  private void CmdBewerten_Click(object sender, EventArgs e)
  {
    if(!double.TryParse(TxtNote.Text, out double note) || double.IsNaN(note) || note < 1.0 || note > 6.0)
    {
      MessageBox.Show($"Ungültige eingabe \"{TxtNote.Text}\" \n Bitte Noten von 1.0 - 6.0 Eingeben!", "Ungültig", MessageBoxButtons.OK, MessageBoxIcon.Error);
      return;
    }

    string bewertung = note switch
    {
      > 5.5 => "Sehr gut",
      > 4.5 => "Gut",
      > 4.0 => "Genügend",
      _ => "Ungenügend"
    };

    if (ChkDetails.Checked)
    {
      LblErgebnis.Text = $"Note: {note} -> {bewertung}\nLeistung: ({(note - 1) / 5 * 100}%)";
    }
    else
    {
      LblErgebnis.Text = $"Note: {note} -> {bewertung}";
    }
  }
}
