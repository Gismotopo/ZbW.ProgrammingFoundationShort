namespace ZbW.ProgrammingFoundationShort.MeineLoesungen.Module01.Aufgabe3_ZahlenAnalyse;

partial class ZahlenAnalyseForm
{
  private System.ComponentModel.IContainer components = null;

  protected override void Dispose(bool disposing)
  {
    if (disposing && (components != null))
      components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    LblZahl1 = new Label();
    TxtZahl1 = new TextBox();
    LblZahl2 = new Label();
    TxtZahl2 = new TextBox();
    LblZahl3 = new Label();
    TxtZahl3 = new TextBox();
    CmdAnalysieren = new Button();
    LblSumme = new Label();
    LblDurchschnitt = new Label();
    LblGroesste = new Label();
    LblKleinste = new Label();
    LblGerade = new Label();
    SuspendLayout();
    // 
    // LblZahl1
    // 
    LblZahl1.AutoSize = true;
    LblZahl1.Location = new Point(12, 18);
    LblZahl1.Name = "LblZahl1";
    LblZahl1.Size = new Size(42, 15);
    LblZahl1.TabIndex = 0;
    LblZahl1.Text = "Zahl 1:";
    // 
    // TxtZahl1
    // 
    TxtZahl1.Location = new Point(80, 15);
    TxtZahl1.Name = "TxtZahl1";
    TxtZahl1.Size = new Size(80, 23);
    TxtZahl1.TabIndex = 1;
    // 
    // LblZahl2
    // 
    LblZahl2.AutoSize = true;
    LblZahl2.Location = new Point(12, 50);
    LblZahl2.Name = "LblZahl2";
    LblZahl2.Size = new Size(42, 15);
    LblZahl2.TabIndex = 2;
    LblZahl2.Text = "Zahl 2:";
    // 
    // TxtZahl2
    // 
    TxtZahl2.Location = new Point(80, 47);
    TxtZahl2.Name = "TxtZahl2";
    TxtZahl2.Size = new Size(80, 23);
    TxtZahl2.TabIndex = 3;
    // 
    // LblZahl3
    // 
    LblZahl3.AutoSize = true;
    LblZahl3.Location = new Point(12, 82);
    LblZahl3.Name = "LblZahl3";
    LblZahl3.Size = new Size(42, 15);
    LblZahl3.TabIndex = 4;
    LblZahl3.Text = "Zahl 3:";
    // 
    // TxtZahl3
    // 
    TxtZahl3.Location = new Point(80, 79);
    TxtZahl3.Name = "TxtZahl3";
    TxtZahl3.Size = new Size(80, 23);
    TxtZahl3.TabIndex = 5;
    // 
    // CmdAnalysieren
    // 
    CmdAnalysieren.Location = new Point(80, 117);
    CmdAnalysieren.Name = "CmdAnalysieren";
    CmdAnalysieren.Size = new Size(130, 28);
    CmdAnalysieren.TabIndex = 6;
    CmdAnalysieren.Text = "Analysieren";
    CmdAnalysieren.Click += CmdAnalysieren_Click;
    // 
    // LblSumme
    // 
    LblSumme.AutoSize = true;
    LblSumme.Location = new Point(12, 146);
    LblSumme.Name = "LblSumme";
    LblSumme.Size = new Size(0, 15);
    LblSumme.TabIndex = 7;
    // 
    // LblDurchschnitt
    // 
    LblDurchschnitt.AutoSize = true;
    LblDurchschnitt.Location = new Point(12, 161);
    LblDurchschnitt.Name = "LblDurchschnitt";
    LblDurchschnitt.Size = new Size(0, 15);
    LblDurchschnitt.TabIndex = 8;
    // 
    // LblGroesste
    // 
    LblGroesste.AutoSize = true;
    LblGroesste.Location = new Point(12, 176);
    LblGroesste.Name = "LblGroesste";
    LblGroesste.Size = new Size(0, 15);
    LblGroesste.TabIndex = 9;
    // 
    // LblKleinste
    // 
    LblKleinste.AutoSize = true;
    LblKleinste.Location = new Point(12, 191);
    LblKleinste.Name = "LblKleinste";
    LblKleinste.Size = new Size(0, 15);
    LblKleinste.TabIndex = 10;
    // 
    // LblGerade
    // 
    LblGerade.AutoSize = true;
    LblGerade.Location = new Point(12, 206);
    LblGerade.Name = "LblGerade";
    LblGerade.Size = new Size(0, 15);
    LblGerade.TabIndex = 11;
    // 
    // ZahlenAnalyseForm
    // 
    AutoScaleDimensions = new SizeF(7F, 15F);
    AutoScaleMode = AutoScaleMode.Font;
    ClientSize = new Size(320, 330);
    Controls.Add(LblZahl1);
    Controls.Add(TxtZahl1);
    Controls.Add(LblZahl2);
    Controls.Add(TxtZahl2);
    Controls.Add(LblZahl3);
    Controls.Add(TxtZahl3);
    Controls.Add(CmdAnalysieren);
    Controls.Add(LblSumme);
    Controls.Add(LblDurchschnitt);
    Controls.Add(LblGroesste);
    Controls.Add(LblKleinste);
    Controls.Add(LblGerade);
    Name = "ZahlenAnalyseForm";
    Text = "Zahlen-Analyse – Aufgabe 3";
    ResumeLayout(false);
    PerformLayout();
  }

  private Label LblZahl1;
  private TextBox TxtZahl1;
  private Label LblZahl2;
  private TextBox TxtZahl2;
  private Label LblZahl3;
  private TextBox TxtZahl3;
  private Button CmdAnalysieren;
  private Label LblSumme;
  private Label LblDurchschnitt;
  private Label LblGroesste;
  private Label LblKleinste;
  private Label LblGerade;
}
