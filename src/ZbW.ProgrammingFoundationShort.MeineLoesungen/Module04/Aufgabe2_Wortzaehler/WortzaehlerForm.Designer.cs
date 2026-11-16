namespace ZbW.ProgrammingFoundationShort.MeineLoesungen.Module04.Aufgabe2_Wortzaehler;

partial class WortzaehlerForm
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
    LblEingabe = new Label();
    TxtEingabe = new TextBox();
    CmdAnalysieren = new Button();
    LblErgebnis = new Label();
    SuspendLayout();
    // 
    // LblEingabe
    // 
    LblEingabe.AutoSize = true;
    LblEingabe.Location = new Point(12, 12);
    LblEingabe.Name = "LblEingabe";
    LblEingabe.Size = new Size(83, 15);
    LblEingabe.TabIndex = 0;
    LblEingabe.Text = "Text eingeben:";
    // 
    // TxtEingabe
    // 
    TxtEingabe.Location = new Point(12, 30);
    TxtEingabe.Multiline = true;
    TxtEingabe.Name = "TxtEingabe";
    TxtEingabe.ScrollBars = ScrollBars.Vertical;
    TxtEingabe.Size = new Size(420, 120);
    TxtEingabe.TabIndex = 1;
    // 
    // CmdAnalysieren
    // 
    CmdAnalysieren.Location = new Point(12, 160);
    CmdAnalysieren.Name = "CmdAnalysieren";
    CmdAnalysieren.Size = new Size(130, 28);
    CmdAnalysieren.TabIndex = 2;
    CmdAnalysieren.Text = "Analysieren";
    CmdAnalysieren.Click += CmdAnalysieren_Click;
    // 
    // LblErgebnis
    // 
    LblErgebnis.AutoSize = true;
    LblErgebnis.Location = new Point(12, 200);
    LblErgebnis.Name = "LblErgebnis";
    LblErgebnis.Size = new Size(0, 15);
    LblErgebnis.TabIndex = 3;
    // 
    // WortzaehlerForm
    // 
    AutoScaleDimensions = new SizeF(7F, 15F);
    AutoScaleMode = AutoScaleMode.Font;
    ClientSize = new Size(450, 280);
    Controls.Add(LblEingabe);
    Controls.Add(TxtEingabe);
    Controls.Add(CmdAnalysieren);
    Controls.Add(LblErgebnis);
    Name = "WortzaehlerForm";
    Text = "Wortzähler – Aufgabe 2";
    ResumeLayout(false);
    PerformLayout();
  }

  private Label LblEingabe;
  private TextBox TxtEingabe;
  private Button CmdAnalysieren;
  private Label LblErgebnis;
}
