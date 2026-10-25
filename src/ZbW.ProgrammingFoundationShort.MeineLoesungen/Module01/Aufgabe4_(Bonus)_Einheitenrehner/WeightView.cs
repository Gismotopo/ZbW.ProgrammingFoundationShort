using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ZbW.ProgrammingFoundationShort.MeineLoesungen.Module01.Aufgabe4__Bonus__Einheitenrehner
{
  public partial class WeightView : UserControl
  {
    private const decimal KgProPfund = 0.45359237m;
    public MainForm _mainForm;
    public WeightView(MainForm mainForm)
    {
      InitializeComponent();

      _mainForm = mainForm;

      _mainForm.CancelButton = btnMenuView;
    }

    private void btnMenuView_Show(object sender, EventArgs e) => _mainForm.ShowMenuView();

    private void btnTxtClear_Clear(object sender, EventArgs e)
    {
      txtKg.Clear();
      txtPfund.Clear();
    }

    private void btnKgZuPfund_Calculate(object sender, EventArgs e)
    {
      if (!decimal.TryParse(txtKg.Text, out decimal kg))
      {
        MessageBox.Show($"Ungültige Eingabe Bei kg!\n\"{txtKg.Text}\"", "Error");
        txtKg.Clear();
        return;
      }

      txtPfund.Text = $"{Calculate(input: kg, inputIsKg: true):F2}";
    }

    private void btnPfundZuKg_Calculate(object sender, EventArgs e)
    {
      if (!decimal.TryParse(txtPfund.Text, out decimal pfund))
      {
        MessageBox.Show($"Ungültige Eingabe Bei Pfund!\n\"{txtPfund.Text}\"", "Error");
        txtPfund.Clear();
        return;
      }

      txtKg.Text = $"{Calculate(input: pfund, inputIsKg: false):F2}";
    }

    private decimal Calculate(decimal input, bool inputIsKg = true)
    {
      if (inputIsKg)
      {
        return (input / KgProPfund);
      }
      return (input * KgProPfund);
    }

    private void WeightView_Load(object sender, EventArgs e)
    {

    }
  }
}
