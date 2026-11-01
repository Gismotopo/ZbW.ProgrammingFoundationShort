namespace ZbW.ProgrammingFoundationShort.MeineLoesungen.Module02.Aufgabe4_TaschenrechnerVerlauf;


public partial class TaschenrechnerVerlaufForm : Form
{
  public TaschenrechnerVerlaufForm()
  {
    InitializeComponent();
  }

  private void CmdBerechnen_Click(object sender, EventArgs e)
  {
    var (valid, calculation, result,negativ) = Calculate();

    if (!valid) { return; }

    LblErgebnis.Text = $" = {result}";

    TxtVerlauf.Text += $"{calculation} = {result} {(negativ ? "(negativ)" : "")}\r\n";
  }

  private (decimal? num1, decimal? num2) GetNumbers()
  {
    if (!decimal.TryParse(TxtZahl1.Text, out decimal num1))
    {
      MessageBox.Show("Zahl 1 Ungültige eingabe");
      return (null, null);
    }
    if (!decimal.TryParse(TxtZahl2.Text, out decimal num2))
    {
      MessageBox.Show("Zahl 2 Ungültige eingabe");
      return (null, null);
    }
    return (num1, num2);
  }

  private char ReadOperator()
  {
    if (RadPlus.Checked) { return '+'; }
    else if (RadMinus.Checked) { return '-'; }
    else if (RadMal.Checked) { return '*'; }
    else { return '/'; }
  }

  private (bool valid, string calculation, decimal? result, bool negative) Calculate()
  {
    var (num1, num2) = GetNumbers();
    char op = ReadOperator();

    if (!num1.HasValue || !num2.HasValue || num2 == 0 && op == '/')
    {
      if (num2 == 0 && op == '/') { MessageBox.Show("Durch 0 Teilen nicht möglich!"); }
      return (valid: false, "Ungültig",0,negative: false);
    }

    decimal? result = 0;
    string calculation = "";
    bool negative = false;
    
    switch (op)
    {
      case '+':
        result = num1 + num2;
        calculation = $"{num1} + {num2}";
        break;
      case '-':
        result = num1 - num2;
        calculation = $"{num1} - {num2}";
        break;
      case '*':
        result = num1 * num2;
        calculation = $"{num1} * {num2}";
        break;
      case '/':
        result = num1 / num2;
        calculation = $"{num1} / {num2}";
        break;
    };

    if (result < 0) { negative = true; }

    return (valid: true, calculation, result, negative);    
  }
}
