namespace ZbW.ProgrammingFoundationShort.Lessons.Module02.Auftrag2_WochentageApp;

partial class WochentageAppForm
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
    LblWochentag = new Label();
    CmbWochentag = new ComboBox();
    CmdAnzeigen = new Button();
    LblErgebnis = new Label();
    SuspendLayout();
    // 
    // LblWochentag
    // 
    LblWochentag.AutoSize = true;
    LblWochentag.Location = new Point(22, 43);
    LblWochentag.Margin = new Padding(6, 0, 6, 0);
    LblWochentag.Name = "LblWochentag";
    LblWochentag.Size = new Size(140, 32);
    LblWochentag.TabIndex = 0;
    LblWochentag.Text = "Wochentag:";
    // 
    // CmbWochentag
    // 
    CmbWochentag.DropDownStyle = ComboBoxStyle.DropDownList;
    CmbWochentag.Items.AddRange(new object[] { "Montag", "Dienstag", "Mittwoch", "Donnerstag", "Freitag", "Samstag", "Sontag" });
    CmbWochentag.Location = new Point(223, 36);
    CmbWochentag.Margin = new Padding(6);
    CmbWochentag.Name = "CmbWochentag";
    CmbWochentag.Size = new Size(275, 40);
    CmbWochentag.TabIndex = 1;
    CmbWochentag.Tag = "";
    // 
    // CmdAnzeigen
    // 
    CmdAnzeigen.Location = new Point(223, 107);
    CmdAnzeigen.Margin = new Padding(6);
    CmdAnzeigen.Name = "CmdAnzeigen";
    CmdAnzeigen.Size = new Size(223, 60);
    CmdAnzeigen.TabIndex = 2;
    CmdAnzeigen.Text = "Anzeigen";
    CmdAnzeigen.Click += CmdAnzeigen_Click;
    // 
    // LblErgebnis
    // 
    LblErgebnis.AutoSize = true;
    LblErgebnis.Location = new Point(22, 192);
    LblErgebnis.Margin = new Padding(6, 0, 6, 0);
    LblErgebnis.Name = "LblErgebnis";
    LblErgebnis.Size = new Size(0, 32);
    LblErgebnis.TabIndex = 3;
    // 
    // WochentageAppForm
    // 
    AutoScaleDimensions = new SizeF(13F, 32F);
    AutoScaleMode = AutoScaleMode.Font;
    ClientSize = new Size(594, 277);
    Controls.Add(LblWochentag);
    Controls.Add(CmbWochentag);
    Controls.Add(CmdAnzeigen);
    Controls.Add(LblErgebnis);
    Margin = new Padding(6);
    Name = "WochentageAppForm";
    Text = "WochentageApp – Auftrag 2";
    ResumeLayout(false);
    PerformLayout();
  }

  private Label LblWochentag;
  private ComboBox CmbWochentag;
  private Button CmdAnzeigen;
  private Label LblErgebnis;
}
