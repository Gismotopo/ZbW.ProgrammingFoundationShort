using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ZbW.ProgrammingFoundationShort.MeineLoesungen.Module01.Aufgabe4__Bonus__Einheitenrehner
{
  public partial class MainForm : Form
  {
    public MainForm()
    {
      InitializeComponent();

      ShowMenuView();
    }

    public void ShowUserControl(UserControl userControl)
    {
      panelContent.Controls.Clear();

      userControl.Dock = DockStyle.Fill;

      panelContent.Controls.Add(userControl);
    }

    public void ShowMenuView()
    {
      var menuView = new MenuView(this);
      FittingFormToView(control: menuView);
      ShowUserControl(userControl: menuView);
    }

    public void ShowDistanceView()
    {
      var distancView = new DistanceView(this);
      FittingFormToView(control: distancView);
      ShowUserControl(userControl: distancView);
    }

    public void ShowWeightView()
    {
      var weightView = new WeightView(this);
      FittingFormToView(control: weightView);
      ShowUserControl(userControl: weightView);
    }

    public void ShowTempView()
    {
      var tempView = new TempView(this);
      FittingFormToView(control: tempView);
      ShowUserControl(tempView);
    }


    private void FittingFormToView(Control control) => this.ClientSize = control.Size;

  }
}
