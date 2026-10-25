namespace ZbW.ProgrammingFoundationShort.MeineLoesungen.Module01.Aufgabe4__Bonus__Einheitenrehner
{
  partial class DistanceView
  {
    /// <summary> 
    /// Erforderliche Designervariable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary> 
    /// Verwendete Ressourcen bereinigen.
    /// </summary>
    /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Vom Komponenten-Designer generierter Code

    /// <summary> 
    /// Erforderliche Methode für die Designerunterstützung. 
    /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
    /// </summary>
    private void InitializeComponent()
    {
      lblHeader = new Label();
      txtKm = new TextBox();
      lblkm = new Label();
      txtMeilen = new TextBox();
      lblMeilen = new Label();
      btnKmZuMeilen = new Button();
      btnMeilenZuKm = new Button();
      btnMenuView = new Button();
      btnTxtClear = new Button();
      SuspendLayout();
      // 
      // lblHeader
      // 
      lblHeader.AutoSize = true;
      lblHeader.Font = new Font("Segoe UI", 18F, FontStyle.Underline, GraphicsUnit.Point, 0);
      lblHeader.Location = new Point(37, 78);
      lblHeader.Name = "lblHeader";
      lblHeader.Size = new Size(244, 32);
      lblHeader.TabIndex = 0;
      lblHeader.Text = "Distanzen Umrechner";
      // 
      // txtKm
      // 
      txtKm.BackColor = SystemColors.HotTrack;
      txtKm.BorderStyle = BorderStyle.None;
      txtKm.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
      txtKm.ForeColor = Color.WhiteSmoke;
      txtKm.Location = new Point(22, 134);
      txtKm.Name = "txtKm";
      txtKm.Size = new Size(129, 28);
      txtKm.TabIndex = 1;
      txtKm.TextAlign = HorizontalAlignment.Center;
      // 
      // lblkm
      // 
      lblkm.AutoSize = true;
      lblkm.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
      lblkm.Location = new Point(157, 133);
      lblkm.Name = "lblkm";
      lblkm.Size = new Size(135, 30);
      lblkm.TabIndex = 2;
      lblkm.Text = "km (z.B. 5.78)";
      // 
      // txtMeilen
      // 
      txtMeilen.BackColor = SystemColors.HotTrack;
      txtMeilen.BorderStyle = BorderStyle.None;
      txtMeilen.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
      txtMeilen.ForeColor = Color.WhiteSmoke;
      txtMeilen.Location = new Point(22, 182);
      txtMeilen.Name = "txtMeilen";
      txtMeilen.Size = new Size(129, 28);
      txtMeilen.TabIndex = 3;
      txtMeilen.TextAlign = HorizontalAlignment.Center;
      // 
      // lblMeilen
      // 
      lblMeilen.AutoSize = true;
      lblMeilen.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
      lblMeilen.Location = new Point(157, 181);
      lblMeilen.Name = "lblMeilen";
      lblMeilen.Size = new Size(159, 30);
      lblMeilen.TabIndex = 4;
      lblMeilen.Text = "Meilen (z.B. 6.5)";
      // 
      // btnKmZuMeilen
      // 
      btnKmZuMeilen.BackColor = Color.Navy;
      btnKmZuMeilen.Cursor = Cursors.Hand;
      btnKmZuMeilen.FlatStyle = FlatStyle.Popup;
      btnKmZuMeilen.ForeColor = Color.Silver;
      btnKmZuMeilen.Location = new Point(22, 233);
      btnKmZuMeilen.Name = "btnKmZuMeilen";
      btnKmZuMeilen.Size = new Size(121, 42);
      btnKmZuMeilen.TabIndex = 5;
      btnKmZuMeilen.Text = "km -> Meilen\r\nBerechnen";
      btnKmZuMeilen.UseVisualStyleBackColor = false;
      btnKmZuMeilen.Click += btnKmZuMeilen_Calculate;
      // 
      // btnMeilenZuKm
      // 
      btnMeilenZuKm.BackColor = Color.Navy;
      btnMeilenZuKm.Cursor = Cursors.Hand;
      btnMeilenZuKm.FlatStyle = FlatStyle.Popup;
      btnMeilenZuKm.ForeColor = Color.Silver;
      btnMeilenZuKm.Location = new Point(157, 233);
      btnMeilenZuKm.Name = "btnMeilenZuKm";
      btnMeilenZuKm.Size = new Size(121, 42);
      btnMeilenZuKm.TabIndex = 6;
      btnMeilenZuKm.Text = "Meilen -> km\r\nBerechnen";
      btnMeilenZuKm.UseVisualStyleBackColor = false;
      btnMeilenZuKm.Click += btnMeilenZuKm_Calculate;
      // 
      // btnMenuView
      // 
      btnMenuView.BackColor = Color.Navy;
      btnMenuView.Cursor = Cursors.Hand;
      btnMenuView.FlatStyle = FlatStyle.Popup;
      btnMenuView.ForeColor = Color.Silver;
      btnMenuView.Location = new Point(22, 16);
      btnMenuView.Name = "btnMenuView";
      btnMenuView.Size = new Size(121, 42);
      btnMenuView.TabIndex = 7;
      btnMenuView.Text = "Hauptmenu";
      btnMenuView.UseVisualStyleBackColor = false;
      btnMenuView.Click += btnMenuView_Show;
      // 
      // btnTxtClear
      // 
      btnTxtClear.BackColor = Color.Navy;
      btnTxtClear.Cursor = Cursors.Hand;
      btnTxtClear.FlatStyle = FlatStyle.Popup;
      btnTxtClear.ForeColor = Color.Silver;
      btnTxtClear.Location = new Point(157, 16);
      btnTxtClear.Name = "btnTxtClear";
      btnTxtClear.Size = new Size(121, 42);
      btnTxtClear.TabIndex = 8;
      btnTxtClear.Text = "Clear";
      btnTxtClear.UseVisualStyleBackColor = false;
      btnTxtClear.Click += btnTxtClear_Clear;
      // 
      // DistanceView
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      BackColor = Color.Black;
      Controls.Add(btnTxtClear);
      Controls.Add(btnMenuView);
      Controls.Add(btnMeilenZuKm);
      Controls.Add(btnKmZuMeilen);
      Controls.Add(lblMeilen);
      Controls.Add(txtMeilen);
      Controls.Add(lblkm);
      Controls.Add(txtKm);
      Controls.Add(lblHeader);
      ForeColor = Color.WhiteSmoke;
      Name = "DistanceView";
      Size = new Size(336, 315);
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private Label lblHeader;
    private TextBox txtKm;
    private Label lblkm;
    private TextBox txtMeilen;
    private Label lblMeilen;
    private Button btnKmZuMeilen;
    private Button btnMeilenZuKm;
    private Button btnMenuView;
    private Button btnTxtClear;
  }
}
