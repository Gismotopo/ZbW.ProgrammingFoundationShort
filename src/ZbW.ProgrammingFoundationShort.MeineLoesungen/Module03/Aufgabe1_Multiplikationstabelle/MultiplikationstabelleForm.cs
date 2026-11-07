using System.Diagnostics;
using System.Text;

namespace ZbW.ProgrammingFoundationShort.MeineLoesungen.Module03.Aufgabe1_Multiplikationstabelle;

public partial class MultiplikationstabelleForm : Form
{
  public MultiplikationstabelleForm()
  {
    InitializeComponent();
  }

  private void CmdAnzeigen_Click(object sender, EventArgs e)
  {
    if (GetInput() is int number)
    {
      string[] results = new string[10];

      for (int count = 1; count <= 10; count++)
      {
        results[count - 1] = $"{count,2} * {(number >= 9 ? $"{number}" : $"{number:2}")} = {count * number,3}";
      }

      StringBuilder sb = new StringBuilder();

      sb.AppendLine("--- Lösung ---");
      sb.AppendLine(string.Join(Environment.NewLine, results));

      if (ChkRueckwaerts.Checked)
      {
        sb.AppendLine("--- Reverse ---");
        sb.AppendLine(string.Join(Environment.NewLine, results.AsEnumerable().Reverse()));
      }

      TxtAusgabe.Text = sb.ToString();
    }
  }

  //--- Methoden ---
  private int? GetInput()
  {
    if (!int.TryParse(TxtZahl.Text, out int number) || number > 10 || number < 1)
    {
      MessageBox.Show($"Ungültige Eingabe \"{TxtZahl.Text}\"! \n Bitte nur Zahlen von 1 - 10 Eingeben",
        "Eingabe Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
      return null;
    }
    return number;
  }  
}
