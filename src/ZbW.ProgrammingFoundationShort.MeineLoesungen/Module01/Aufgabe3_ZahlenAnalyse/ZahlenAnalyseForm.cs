namespace ZbW.ProgrammingFoundationShort.MeineLoesungen.Module01.Aufgabe3_ZahlenAnalyse;

public partial class ZahlenAnalyseForm : Form
{
  public ZahlenAnalyseForm()
  {
    InitializeComponent();
  }

//---Buttons---
  private void CmdAnalysieren_Click(object sender, EventArgs e)
  {
    ShowResult();
  }

  //---Methoden---

  private (bool ok, int[] input) GetInput()
  {
    bool ok1 = int.TryParse(TxtZahl1.Text, out int num1);
    bool ok2 = int.TryParse(TxtZahl2.Text, out int num2);
    bool ok3 = int.TryParse(TxtZahl3.Text, out int num3);

    List<string> errors = new List<string>();

    if (!ok1) { errors.Add($"Zahl 1: \"{TxtZahl1.Text}\""); }
    if (!ok2) { errors.Add($"Zahl 2: \"{TxtZahl2.Text}\""); }
    if (!ok3) { errors.Add($"Zahl 3: \"{TxtZahl3.Text}\""); }

    if (errors.Count > 0)
    {
      MessageBox.Show($"Eingabe(n) ungültig:\n{string.Join("\n", errors)}", $"Ungültige Eingabe", MessageBoxButtons.OK, MessageBoxIcon.Error);

      return (false, Array.Empty<int>());
    }

    int[] input = new int[] { num1, num2, num3 };

    return ((ok1 && ok2 && ok3), input);
  }

  private (int sum, double averange, int max, int min, string even) Calculate()
  {
    var (ok, input) = GetInput();

    if (!ok) { return (0, 0, 0, 0, "ungerade"); }

    int sum = input.Sum();
    double ave = input.Average();
    int max = input.Max();
    int min = input.Min();

    if (sum % 2 == 0) { return (sum, ave, max, min, "gerade"); }
    else { return (sum, ave, max, min, "ungerade"); }
  }

  private void ShowResult()
  {
    var (sum, ave, max, min, even) = Calculate();

    LblSumme.Text = $"Summe: {sum}";
    LblDurchschnitt.Text = $"Durchschnitt: {ave:F2}";
    LblGroesste.Text = $"Grösste: {max}";
    LblKleinste.Text = $"Kleinste: {min}";
    LblGerade.Text = $"Summe ist :{even}";
  } 
}
