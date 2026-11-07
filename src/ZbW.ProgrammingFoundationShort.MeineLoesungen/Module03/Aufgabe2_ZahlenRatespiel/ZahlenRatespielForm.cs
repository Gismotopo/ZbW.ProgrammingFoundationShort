namespace ZbW.ProgrammingFoundationShort.MeineLoesungen.Module03.Aufgabe2_ZahlenRatespiel;


public partial class ZahlenRatespielForm : Form
{
  private Random _random = new Random();

  private int _rNumber;
  private int _attempts;
  private enum Result { TooLow, TooHigh, Correct}
  
  public ZahlenRatespielForm()
  {
    InitializeComponent();
    NewGame();    
  }
  private void CmdNeuSpiel_Click(object sender, EventArgs e) => NewGame();

  private void CmdRaten_Click(object sender, EventArgs e)
  {
    if (GetInput() is int number)
    {
      Result status;

      if (number < _rNumber) { status = Result.TooLow; }
      else if (number > _rNumber) {  status = Result.TooHigh; }
      else {  status = Result.Correct; }

      _attempts += 1;
      LblVersuche.Text = $"Versuche: {_attempts}";

      switch (status)
      {
        case Result.TooLow:
          LblHinweis.Text = "zu tief";          
          break;

        case Result.TooHigh:
          LblHinweis.Text = "zu hoch";
          break;

        case Result.Correct:
          LblHinweis.Text = "Richtig";
          MessageBox.Show($"Richtig \ndu hast {_attempts} Versuche gebrauch","Gratulation",
            MessageBoxButtons.OK);
          break;
      }      
    }
  }

  //--- Methoden ---
  private int? GetInput()
  {
    if (!int.TryParse(TxtVermutung.Text, out int number) || number > 100 || number < 1)
    {
      MessageBox.Show($"Ungültige Eingabe \"{TxtVermutung.Text}\"! \n Bitte nur Zahlen von 1 - 100 Eingeben",
        "Eingabe Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
      return null;
    }
    return number;
  }

  private void NewGame()
  {
    TxtVermutung.Clear();
    _rNumber = _random.Next(1, 101);
    _attempts = 0;
    LblHinweis.Text = "Ihgendwo zwichen 1 und 100 🤔";
    LblVersuche.Text = $"Veruche: {_attempts}";
  }  
}
