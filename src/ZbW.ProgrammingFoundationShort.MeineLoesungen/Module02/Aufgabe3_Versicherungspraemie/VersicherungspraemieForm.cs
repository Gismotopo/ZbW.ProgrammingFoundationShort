namespace ZbW.ProgrammingFoundationShort.MeineLoesungen.Module02.Aufgabe3_Versicherungspraemie;

public partial class VersicherungspraemieForm : Form
{
  private enum Insurance { Basis, Standart, Premium }

  public VersicherungspraemieForm()
  {
    InitializeComponent();
  }

  private void CmdBerechnen_Click(object sender, EventArgs e)
  {
    int age = GetAge();

    decimal basicPremium = age switch
    {
      > 65 => 350.00m,
      > 45 => 280.00m,
      > 24 => 200.00m,
      _ => 150.00m
    };

    decimal multiplier = ReadInsurance() switch
    {
      Insurance.Basis => 1.0m,
      Insurance.Standart => 1.4m,
      _ => 1.8m
    };

    decimal premium = (basicPremium * multiplier);

    if (ChkUnfall.Checked) {premium += 20; }
    
    LblErgebnis.Text = $"Alter: {age} \n" +
      $"Versicherung: {ReadInsurance().ToString()}\n" +
      $"Unfalldeckung: {(ChkUnfall.Checked ? "mit Unfalldeckung (+20 CHF)" : "ohne Unfalldeckung")}\n" +
      $"Prämie Total: {premium:F2} CHF";
  }

  private Insurance ReadInsurance()
  {
    if (RadBasis.Checked) { return Insurance.Basis; }
    else if (RadStandard.Checked) { return Insurance.Standart; }
    else { return Insurance.Premium; }
  }

  private int GetAge()
  {
    if (!int.TryParse(TxtAlter.Text, out int age) || age < 0)
    {
      MessageBox.Show("Ungültige Eingabe");
      return 0;
    }
    else { return age; }
  }    
}
