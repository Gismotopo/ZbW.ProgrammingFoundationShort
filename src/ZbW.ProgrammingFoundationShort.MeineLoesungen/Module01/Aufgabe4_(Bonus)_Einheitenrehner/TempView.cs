using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ZbW.ProgrammingFoundationShort.MeineLoesungen.Module01.Aufgabe4__Bonus__Einheitenrehner
{
  public partial class TempView : UserControl
  {
    private const double AbsoluteZero = -273.15;
    public MainForm _mainForm;
    public TempView(MainForm mainForm)
    {
      InitializeComponent();

      _mainForm = mainForm;

      _mainForm.CancelButton = btnMenuView;
    }

    private void btnMenuView_Show(object sender, EventArgs e) => _mainForm.ShowMenuView();

    private void btnTxtClear_Clear(object sender, EventArgs e)
    {
      txtCelsius.Clear();
      txtFahrenheit.Clear();
    }

    private void btnCelsiusZuFahrenheit_Click(object sender, EventArgs e)
    {
      if (!double.TryParse(txtCelsius.Text, out double celsius)) { MessageBox.Show("Ungültige eingabe bei Celsius", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

      if (celsius < AbsoluteZero) { MessageBox.Show("Wert ist Kleiner als Absolute 0 Punkt", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error); }

      double fahrenheit = celsius * 9 / 5 + 32;

      txtFahrenheit.Text = $"{fahrenheit:F2}";
    }

    private void btnPfundZuKg_Click(object sender, EventArgs e)
    {
      if (!double.TryParse(txtFahrenheit.Text, out double fahrenheit)) { MessageBox.Show("Ungültige eingabe bei Fahrenheit", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

      double celsius = (fahrenheit - 32) * 5 / 9;

      if (celsius < AbsoluteZero) { MessageBox.Show("Wert ist Kleiner als Absolute 0 Punkt", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error); }

      txtCelsius.Text = $"{celsius:F2}";
    }
  }
}
