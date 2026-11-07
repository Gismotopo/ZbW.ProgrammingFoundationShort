namespace ZbW.ProgrammingFoundationShort.MeineLoesungen.Module03.Aufgabe1_Multiplikationstabelle;

partial class MultiplikationstabelleForm
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
    LblZahl = new Label();
    TxtZahl = new TextBox();
    ChkRueckwaerts = new CheckBox();
    CmdAnzeigen = new Button();
    TxtAusgabe = new TextBox();
    SuspendLayout();
    // 
    // LblZahl
    // 
    LblZahl.AutoSize = true;
    LblZahl.Location = new Point(12, 20);
    LblZahl.Name = "LblZahl";
    LblZahl.Size = new Size(68, 15);
    LblZahl.TabIndex = 0;
    LblZahl.Text = "Zahl (1–10):";
    // 
    // TxtZahl
    // 
    TxtZahl.Location = new Point(120, 17);
    TxtZahl.Name = "TxtZahl";
    TxtZahl.Size = new Size(60, 23);
    TxtZahl.TabIndex = 1;
    // 
    // ChkRueckwaerts
    // 
    ChkRueckwaerts.AutoSize = true;
    ChkRueckwaerts.Location = new Point(12, 50);
    ChkRueckwaerts.Name = "ChkRueckwaerts";
    ChkRueckwaerts.Size = new Size(125, 19);
    ChkRueckwaerts.TabIndex = 2;
    ChkRueckwaerts.Text = "Rückwärts (10 → 1)";
    // 
    // CmdAnzeigen
    // 
    CmdAnzeigen.Location = new Point(12, 80);
    CmdAnzeigen.Name = "CmdAnzeigen";
    CmdAnzeigen.Size = new Size(120, 28);
    CmdAnzeigen.TabIndex = 3;
    CmdAnzeigen.Text = "Anzeigen";
    CmdAnzeigen.Click += CmdAnzeigen_Click;
    // 
    // TxtAusgabe
    // 
    TxtAusgabe.Font = new Font("Courier New", 10F);
    TxtAusgabe.Location = new Point(12, 120);
    TxtAusgabe.Multiline = true;
    TxtAusgabe.Name = "TxtAusgabe";
    TxtAusgabe.ReadOnly = true;
    TxtAusgabe.ScrollBars = ScrollBars.Vertical;
    TxtAusgabe.Size = new Size(200, 200);
    TxtAusgabe.TabIndex = 4;
    // 
    // MultiplikationstabelleForm
    // 
    AutoScaleDimensions = new SizeF(7F, 15F);
    AutoScaleMode = AutoScaleMode.Font;
    ClientSize = new Size(240, 335);
    Controls.Add(LblZahl);
    Controls.Add(TxtZahl);
    Controls.Add(ChkRueckwaerts);
    Controls.Add(CmdAnzeigen);
    Controls.Add(TxtAusgabe);
    Name = "MultiplikationstabelleForm";
    Text = "Multiplikationstabelle – Aufgabe 1";
    ResumeLayout(false);
    PerformLayout();
  }

  private Label LblZahl;
  private TextBox TxtZahl;
  private CheckBox ChkRueckwaerts;
  private Button CmdAnzeigen;
  private TextBox TxtAusgabe;
}
