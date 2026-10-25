using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ZbW.ProgrammingFoundationShort.MeineLoesungen.Module01.Aufgabe4__Bonus__Einheitenrehner
{
  public partial class MenuView : UserControl
  {
    public MainForm _mainForm;

    public MenuView(MainForm mainForm)
    {
      InitializeComponent();

      _mainForm = mainForm;
    }

    private void btnWeightView_Show(object sender, EventArgs e) => _mainForm.ShowWeightView();

    private void btnDistanceView_Show(object sender, EventArgs e) => _mainForm.ShowDistanceView();

    private void btnTempView_Show(object sender, EventArgs e) => _mainForm.ShowTempView();

  }
}
