namespace ZbW.ProgrammingFoundationShort.MeineLoesungen.Module01.Aufgabe2_Waehrungsrechner;

partial class WaehrungsrechnerForm
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
    LblBetrag = new Label();
    TxtBetrag = new TextBox();
    CmdChfToEur = new Button();
    CmdEurToChf = new Button();
    LblErgebnis = new Label();
    LblKurs = new Label();
    SuspendLayout();
    // 
    // LblBetrag
    // 
    LblBetrag.AutoSize = true;
    LblBetrag.Location = new Point(12, 18);
    LblBetrag.Name = "LblBetrag";
    LblBetrag.Size = new Size(44, 15);
    LblBetrag.TabIndex = 0;
    LblBetrag.Text = "Betrag:";
    // 
    // TxtBetrag
    // 
    TxtBetrag.Location = new Point(80, 15);
    TxtBetrag.Name = "TxtBetrag";
    TxtBetrag.Size = new Size(120, 23);
    TxtBetrag.TabIndex = 1;
    // 
    // CmdChfToEur
    // 
    CmdChfToEur.Location = new Point(12, 55);
    CmdChfToEur.Name = "CmdChfToEur";
    CmdChfToEur.Size = new Size(130, 28);
    CmdChfToEur.TabIndex = 2;
    CmdChfToEur.Text = "CHF → EUR";
    CmdChfToEur.Click += CmdChfToEur_Click;
    // 
    // CmdEurToChf
    // 
    CmdEurToChf.Location = new Point(155, 55);
    CmdEurToChf.Name = "CmdEurToChf";
    CmdEurToChf.Size = new Size(130, 28);
    CmdEurToChf.TabIndex = 3;
    CmdEurToChf.Text = "EUR → CHF";
    CmdEurToChf.Click += CmdEurToChf_Click;
    // 
    // LblErgebnis
    // 
    LblErgebnis.AutoSize = true;
    LblErgebnis.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
    LblErgebnis.Location = new Point(12, 100);
    LblErgebnis.Name = "LblErgebnis";
    LblErgebnis.Size = new Size(0, 19);
    LblErgebnis.TabIndex = 4;
    // 
    // LblKurs
    // 
    LblKurs.AutoSize = true;
    LblKurs.ForeColor = SystemColors.GrayText;
    LblKurs.Location = new Point(12, 130);
    LblKurs.Name = "LblKurs";
    LblKurs.Size = new Size(127, 15);
    LblKurs.TabIndex = 5;
    LblKurs.Text = "Kurs: 1 EUR = 1.05 CHF";
    // 
    // WaehrungsrechnerForm
    // 
    AutoScaleDimensions = new SizeF(7F, 15F);
    AutoScaleMode = AutoScaleMode.Font;
    ClientSize = new Size(360, 160);
    Controls.Add(LblBetrag);
    Controls.Add(TxtBetrag);
    Controls.Add(CmdChfToEur);
    Controls.Add(CmdEurToChf);
    Controls.Add(LblErgebnis);
    Controls.Add(LblKurs);
    Name = "WaehrungsrechnerForm";
    Text = "Währungsrechner – Aufgabe 2";
    ResumeLayout(false);
    PerformLayout();
  }

  private Label LblBetrag;
  private TextBox TxtBetrag;
  private Button CmdChfToEur;
  private Button CmdEurToChf;
  private Label LblErgebnis;
  private Label LblKurs;
}
