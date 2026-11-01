namespace ZbW.ProgrammingFoundationShort.MeineLoesungen.Module02.Aufgabe4_TaschenrechnerVerlauf;

partial class TaschenrechnerVerlaufForm
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
    GrpOp = new GroupBox();
    RadPlus = new RadioButton();
    RadMinus = new RadioButton();
    RadMal = new RadioButton();
    RadDiv = new RadioButton();
    CmdBerechnen = new Button();
    LblErgebnis = new Label();
    LblVerlauf = new Label();
    TxtVerlauf = new TextBox();
    GrpOp.SuspendLayout();
    SuspendLayout();
    // 
    // LblZahl1
    // 
    LblZahl1.AutoSize = true;
    LblZahl1.Location = new Point(12, 20);
    LblZahl1.Name = "LblZahl1";
    LblZahl1.Size = new Size(42, 15);
    LblZahl1.TabIndex = 0;
    LblZahl1.Text = "Zahl 1:";
    // 
    // TxtZahl1
    // 
    TxtZahl1.Location = new Point(90, 17);
    TxtZahl1.Name = "TxtZahl1";
    TxtZahl1.Size = new Size(100, 23);
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
    TxtZahl2.Location = new Point(90, 47);
    TxtZahl2.Name = "TxtZahl2";
    TxtZahl2.Size = new Size(100, 23);
    TxtZahl2.TabIndex = 3;
    // 
    // GrpOp
    // 
    GrpOp.Controls.Add(RadPlus);
    GrpOp.Controls.Add(RadMinus);
    GrpOp.Controls.Add(RadMal);
    GrpOp.Controls.Add(RadDiv);
    GrpOp.Location = new Point(12, 80);
    GrpOp.Name = "GrpOp";
    GrpOp.Size = new Size(280, 40);
    GrpOp.TabIndex = 4;
    GrpOp.TabStop = false;
    GrpOp.Text = "Operation";
    // 
    // RadPlus
    // 
    RadPlus.AutoSize = true;
    RadPlus.Checked = true;
    RadPlus.Location = new Point(10, 15);
    RadPlus.Name = "RadPlus";
    RadPlus.Size = new Size(33, 19);
    RadPlus.TabIndex = 0;
    RadPlus.TabStop = true;
    RadPlus.Text = "+";
    // 
    // RadMinus
    // 
    RadMinus.AutoSize = true;
    RadMinus.Location = new Point(60, 15);
    RadMinus.Name = "RadMinus";
    RadMinus.Size = new Size(30, 19);
    RadMinus.TabIndex = 1;
    RadMinus.Text = "-";
    // 
    // RadMal
    // 
    RadMal.AutoSize = true;
    RadMal.Location = new Point(110, 15);
    RadMal.Name = "RadMal";
    RadMal.Size = new Size(33, 19);
    RadMal.TabIndex = 2;
    RadMal.Text = "×";
    // 
    // RadDiv
    // 
    RadDiv.AutoSize = true;
    RadDiv.Location = new Point(160, 15);
    RadDiv.Name = "RadDiv";
    RadDiv.Size = new Size(33, 19);
    RadDiv.TabIndex = 3;
    RadDiv.Text = "÷";
    // 
    // CmdBerechnen
    // 
    CmdBerechnen.Location = new Point(12, 130);
    CmdBerechnen.Name = "CmdBerechnen";
    CmdBerechnen.Size = new Size(120, 28);
    CmdBerechnen.TabIndex = 5;
    CmdBerechnen.Text = "Berechnen";
    CmdBerechnen.Click += CmdBerechnen_Click;
    // 
    // LblErgebnis
    // 
    LblErgebnis.AutoSize = true;
    LblErgebnis.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
    LblErgebnis.Location = new Point(145, 135);
    LblErgebnis.Name = "LblErgebnis";
    LblErgebnis.Size = new Size(0, 20);
    LblErgebnis.TabIndex = 6;
    // 
    // LblVerlauf
    // 
    LblVerlauf.AutoSize = true;
    LblVerlauf.Location = new Point(12, 170);
    LblVerlauf.Name = "LblVerlauf";
    LblVerlauf.Size = new Size(46, 15);
    LblVerlauf.TabIndex = 7;
    LblVerlauf.Text = "Verlauf:";
    // 
    // TxtVerlauf
    // 
    TxtVerlauf.Location = new Point(12, 188);
    TxtVerlauf.Multiline = true;
    TxtVerlauf.Name = "TxtVerlauf";
    TxtVerlauf.ReadOnly = true;
    TxtVerlauf.ScrollBars = ScrollBars.Vertical;
    TxtVerlauf.Size = new Size(360, 120);
    TxtVerlauf.TabIndex = 8;
    // 
    // TaschenrechnerVerlaufForm
    // 
    AutoScaleDimensions = new SizeF(7F, 15F);
    AutoScaleMode = AutoScaleMode.Font;
    ClientSize = new Size(390, 325);
    Controls.Add(LblZahl1);
    Controls.Add(TxtZahl1);
    Controls.Add(LblZahl2);
    Controls.Add(TxtZahl2);
    Controls.Add(GrpOp);
    Controls.Add(CmdBerechnen);
    Controls.Add(LblErgebnis);
    Controls.Add(LblVerlauf);
    Controls.Add(TxtVerlauf);
    Name = "TaschenrechnerVerlaufForm";
    Text = "Taschenrechner mit Verlauf – Aufgabe 4";
    GrpOp.ResumeLayout(false);
    GrpOp.PerformLayout();
    ResumeLayout(false);
    PerformLayout();
  }

  private Label LblZahl1;
  private TextBox TxtZahl1;
  private Label LblZahl2;
  private TextBox TxtZahl2;
  private GroupBox GrpOp;
  private RadioButton RadPlus;
  private RadioButton RadMinus;
  private RadioButton RadMal;
  private RadioButton RadDiv;
  private Button CmdBerechnen;
  private Label LblErgebnis;
  private Label LblVerlauf;
  private TextBox TxtVerlauf;
}
