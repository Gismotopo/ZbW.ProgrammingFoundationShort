using System.Text;
using ZbW.ProgrammingFoundationShort.MeineLoesungen.utils;

namespace ZbW.ProgrammingFoundationShort.MeineLoesungen.Module03.Aufgabe3_PasswortGenerator;


public partial class PasswortGeneratorForm : Form
{
  Random _random = new Random();


  public PasswortGeneratorForm()
  {
    InitializeComponent();
  }

  private void CmdGenerieren_Click(object sender, EventArgs e)
  {
    try
    {
      int? pwLength = InputHelper.GetInput<int>(TxtLaenge.Text);

      if (!pwLength.HasValue || pwLength > 32 || pwLength < 8) { MessageBox.Show("Bitte Gib eine Länge zwischen 8 und 32 ein"); return; }

      StringBuilder sb = new StringBuilder();

      if (ChkGross.Checked) { sb.Append("ABCDEFGHIJKLMNOPQRSTUVWXYZ"); }
      if (ChkKlein.Checked) { sb.Append("abcdefghijklmnopqrstuvwxyz"); }
      if (ChkZahlen.Checked) { sb.Append("0123456789"); }
      if (ChkSonder.Checked) { sb.Append("!@#$%^&*"); }

      string pool = sb.ToString();
      string password = "";
      
      for(int i = 0; i < pwLength; i++)
      {
        password += pool[_random.Next(pool.Length)];
      }

      LblPasswort.Text = password;

    }
    catch( Exception ex)
    {
      MessageBox.Show($"Fehler beim Generieren {ex.Message}");
    }
  }

  private void CmdKopieren_Click(object sender, EventArgs e)
  {
    if (LblPasswort.Text.Length > 0) { Clipboard.SetText(LblPasswort.Text); }   
  }
}
