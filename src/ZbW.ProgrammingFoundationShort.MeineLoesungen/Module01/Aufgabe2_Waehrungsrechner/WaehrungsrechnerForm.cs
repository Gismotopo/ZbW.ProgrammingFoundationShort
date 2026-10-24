namespace ZbW.ProgrammingFoundationShort.MeineLoesungen.Module01.Aufgabe2_Waehrungsrechner;


public partial class WaehrungsrechnerForm : Form
{
  const decimal ChfPerEur = 1.05m;

  public WaehrungsrechnerForm()
  {
    InitializeComponent();
  }
  //---Buttons---
  private void CmdChfToEur_Click(object sender, EventArgs e)
  {
    ShowResult(true);
  }

  private void CmdEurToChf_Click(object sender, EventArgs e)
  {
    ShowResult(false);
  }

  //---Methoden---
  private (bool ok, decimal eingabe) GetInput()
  {
    bool ok = decimal.TryParse(TxtBetrag.Text, out decimal betrag);

    return (ok, betrag);
  }

  private decimal Calculate(bool chfZuEur = true)
  {
    var (ok, betrag) = GetInput();

    if (!ok) { ShowError(0); return 0; }

    if (betrag <= 0) { ShowError(1); return 0; }

    if (chfZuEur)
    {
      return (betrag / ChfPerEur);
    }
    else
    {
      return (betrag * ChfPerEur);
    }
  }

  private void ShowResult(bool chfZuEur = true)
  {
    if (chfZuEur)
    {
      LblErgebnis.Text = $"{TxtBetrag.Text} CHF = {Calculate():F2} EUR";
    }
    else
    {
      LblErgebnis.Text = $"{TxtBetrag.Text} EUR = {Calculate(chfZuEur = false):F2} CHF";
    }
  }
  private void ShowError(int error)
  {
    string[] errors =
    {
      $"Eingabe ungültig",
      $"Wert darf nicht NEGATIV sein!"
    };

    MessageBox.Show($"{errors[error]}", $"Fehler");
  }

}
