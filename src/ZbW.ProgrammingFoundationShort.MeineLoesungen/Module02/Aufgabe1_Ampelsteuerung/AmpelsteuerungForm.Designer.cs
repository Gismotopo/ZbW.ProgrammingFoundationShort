namespace ZbW.ProgrammingFoundationShort.MeineLoesungen.Module02.Aufgabe1_Ampelsteuerung;

partial class AmpelsteuerungForm
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
    GrpFarbe = new GroupBox();
    RadRot = new RadioButton();
    RadGelb = new RadioButton();
    RadGruen = new RadioButton();
    CmdAnzeigen = new Button();
    LblMeldung = new Label();
    LblAmpel = new Label();
    GrpFarbe.SuspendLayout();
    SuspendLayout();
    // 
    // GrpFarbe
    // 
    GrpFarbe.Controls.Add(RadRot);
    GrpFarbe.Controls.Add(RadGelb);
    GrpFarbe.Controls.Add(RadGruen);
    GrpFarbe.Location = new Point(12, 12);
    GrpFarbe.Name = "GrpFarbe";
    GrpFarbe.Size = new Size(200, 100);
    GrpFarbe.TabIndex = 0;
    GrpFarbe.TabStop = false;
    GrpFarbe.Text = "Ampelfarbe";
    // 
    // RadRot
    // 
    RadRot.AutoSize = true;
    RadRot.Checked = true;
    RadRot.Location = new Point(10, 20);
    RadRot.Name = "RadRot";
    RadRot.Size = new Size(43, 19);
    RadRot.TabIndex = 0;
    RadRot.TabStop = true;
    RadRot.Text = "Rot";
    // 
    // RadGelb
    // 
    RadGelb.AutoSize = true;
    RadGelb.Location = new Point(10, 45);
    RadGelb.Name = "RadGelb";
    RadGelb.Size = new Size(49, 19);
    RadGelb.TabIndex = 1;
    RadGelb.Text = "Gelb";
    // 
    // RadGruen
    // 
    RadGruen.AutoSize = true;
    RadGruen.Location = new Point(10, 68);
    RadGruen.Name = "RadGruen";
    RadGruen.Size = new Size(51, 19);
    RadGruen.TabIndex = 2;
    RadGruen.Text = "Grün";
    // 
    // CmdAnzeigen
    // 
    CmdAnzeigen.Location = new Point(12, 120);
    CmdAnzeigen.Name = "CmdAnzeigen";
    CmdAnzeigen.Size = new Size(120, 28);
    CmdAnzeigen.TabIndex = 1;
    CmdAnzeigen.Text = "Anzeigen";
    CmdAnzeigen.Click += CmdAnzeigen_Click;
    // 
    // LblMeldung
    // 
    LblMeldung.AutoSize = true;
    LblMeldung.Location = new Point(12, 160);
    LblMeldung.Name = "LblMeldung";
    LblMeldung.Size = new Size(0, 15);
    LblMeldung.TabIndex = 2;
    // 
    // LblAmpel
    // 
    LblAmpel.BackColor = Color.Gray;
    LblAmpel.BorderStyle = BorderStyle.FixedSingle;
    LblAmpel.Location = new Point(220, 12);
    LblAmpel.Name = "LblAmpel";
    LblAmpel.Size = new Size(60, 60);
    LblAmpel.TabIndex = 3;
    // 
    // AmpelsteuerungForm
    // 
    AutoScaleDimensions = new SizeF(7F, 15F);
    AutoScaleMode = AutoScaleMode.Font;
    ClientSize = new Size(320, 200);
    Controls.Add(GrpFarbe);
    Controls.Add(CmdAnzeigen);
    Controls.Add(LblMeldung);
    Controls.Add(LblAmpel);
    Name = "AmpelsteuerungForm";
    Text = "Ampelsteuerung – Aufgabe 1";
    GrpFarbe.ResumeLayout(false);
    GrpFarbe.PerformLayout();
    ResumeLayout(false);
    PerformLayout();
  }

  private GroupBox GrpFarbe;
  private RadioButton RadRot;
  private RadioButton RadGelb;
  private RadioButton RadGruen;
  private Button CmdAnzeigen;
  private Label LblMeldung;
  private Label LblAmpel;
}
