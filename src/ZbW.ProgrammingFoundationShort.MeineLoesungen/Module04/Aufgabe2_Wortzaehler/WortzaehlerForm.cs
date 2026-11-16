using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;

namespace ZbW.ProgrammingFoundationShort.MeineLoesungen.Module04.Aufgabe2_Wortzaehler;

public partial class WortzaehlerForm : Form
{
  public WortzaehlerForm()
  {
    InitializeComponent();
  }

  private void CmdAnalysieren_Click(object sender, EventArgs e)
  {
    string text = TxtEingabe.Text;
    string[] words = TextToWords(text);

    LblErgebnis.Text = $"Wörter: {CountWords(words)} \n" +
                       $"Zeichen: {CountCharacters(text)}\n" +
                       $"Längstes Wort: {LongestWord(words)}\n";
  }

  private string[] TextToWords(string text) => text.Split(new char[] {' ', '\r', '\n','\t'}, StringSplitOptions.RemoveEmptyEntries);

  private int CountWords(string[] words) => words.Length;

  private int CountCharacters(string text) => text.Count(c => !char.IsWhiteSpace(c));

  private string LongestWord(string[] words)
  {
    return words.MaxBy(words => words.Length);
  }
}
