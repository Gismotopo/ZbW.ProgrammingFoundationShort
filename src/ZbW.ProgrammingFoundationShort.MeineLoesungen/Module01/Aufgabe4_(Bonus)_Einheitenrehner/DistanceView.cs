using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ZbW.ProgrammingFoundationShort.MeineLoesungen.Module01.Aufgabe4__Bonus__Einheitenrehner
{
  public partial class DistanceView : UserControl
  {
    private const decimal KmProMeilen = 1.609344m;
    public MainForm _mainForm;
    public DistanceView(MainForm mainForm)
    {
      InitializeComponent();

      _mainForm = mainForm;

      _mainForm.CancelButton = btnMenuView;

    }

    //---Buttons---

    private void btnMenuView_Show(object sender, EventArgs e) => _mainForm.ShowMenuView();

    private void btnTxtClear_Clear(object sender, EventArgs e)
    {
      txtKm.Clear();
      txtMeilen.Clear();
    }

    private void btnKmZuMeilen_Calculate(object sender, EventArgs e)
    {
      if (!decimal.TryParse(txtKm.Text, out decimal km))
      {
        MessageBox.Show($"Ungültige eingabe bei km! \n\"{txtKm.Text}\"", $"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        txtKm.Clear();
        return;
      }

      txtMeilen.Text = $"{Calculate(input: km, inputIsKm: true):F2}";
    }

    private void btnMeilenZuKm_Calculate(object sender, EventArgs e)
    {
      if (!decimal.TryParse(txtMeilen.Text, out decimal meilen))
      {
        MessageBox.Show($"Ungültige eingabe bei Meilen! \n\"{txtMeilen.Text}\"", $"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        txtMeilen.Clear();
        return;
      }

      txtKm.Text = $"{Calculate(input: meilen, inputIsKm: false):F2}";
    }

    //---Methoden---
    private decimal  Calculate(decimal input, bool inputIsKm = true)
    {
      if (inputIsKm)
      {
        return (input / KmProMeilen);
      }
      return (input * KmProMeilen);
    }

    
  }
}
