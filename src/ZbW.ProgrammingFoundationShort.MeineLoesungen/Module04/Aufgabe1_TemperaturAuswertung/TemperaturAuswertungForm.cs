using ZbW.ProgrammingFoundationShort.MeineLoesungen.utils;

namespace ZbW.ProgrammingFoundationShort.MeineLoesungen.Module04.Aufgabe1_TemperaturAuswertung;

public partial class TemperaturAuswertungForm : Form
{
  private readonly TextBox[] _eingabefelder;

  private double[] temperatur = new double[7];
  public TemperaturAuswertungForm()
  {
    InitializeComponent();

    _eingabefelder = new TextBox[] 
    {
      TxtMo,
      TxtDi,
      TxtMi,
      TxtDo,
      TxtFr,
      TxtSa,
      TxtSo
    };
  }

  private void CmdAuswerten_Click(object sender, EventArgs e)
  {
    ReadInput();

    LblDurchschnitt.Text = $"AVG: {Average(temperatur):F2}";
    LblMax.Text = $"Max: {Maximum(temperatur):F}";
    LblMin.Text = $"Min: {Minimum(temperatur):F}";
  }

  private void ReadInput()
  {
    double? day;
    int counter = 0;

    foreach(TextBox feld in _eingabefelder)
    {
      day = InputHelper.GetInput<double>(feld.Text);

      if (!day.HasValue)
      {
        MessageBox.Show($"Ungültige eingabe \"{feld.Text}\" bei {feld.Name}");
        counter++;
        return;
      }

      temperatur[counter] = Convert.ToDouble(day);
      counter++;
    }
  }

  private double Average(double[] values) => values.Average();

  private double Maximum(double[] values) => values.Max();

  private double Minimum(double[] values) => values.Min();
}
