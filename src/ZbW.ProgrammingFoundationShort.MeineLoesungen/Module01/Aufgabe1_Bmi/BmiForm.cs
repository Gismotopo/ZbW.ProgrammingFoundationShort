namespace ZbW.ProgrammingFoundationShort.MeineLoesungen.Module01.Aufgabe1_Bmi;

public partial class BmiForm : Form
{
  public BmiForm()
  {
    InitializeComponent();
  }

//---Buttons---
  private void CmdBerechnen_Click(object sender, EventArgs e)
  {
    ShowResult();
  }
  
  //---Methoden---
  private (bool ok, double gewicht, double groesse) GetInput()
  {
    bool ok1 = double.TryParse(TxtGewicht.Text, out double gewicht);
    bool ok2 = double.TryParse(TxtGroesse.Text, out double groesse);

    return ((ok1 && ok2), gewicht, groesse);
  }
  private double Berrechnen()
  {
    var (ok, gewicht, groesse) = GetInput();

    if (!ok || gewicht <= 0 || groesse <= 0) { MessageBox.Show($"Die Eingabe war Ungültig :P", $"Fehler"); return 0; }
    ;

    return (gewicht / (groesse * groesse));
  }

  private void ShowResult() => LblErgebnis.Text = $"Ihr BMI beträgt {Berrechnen():F2}";
}
