namespace ZbW.ProgrammingFoundationShort.MeineLoesungen.Module01.Aufgabe4__Bonus__Einheitenrehner
{
  partial class WeightView
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
      btnTxtClear = new Button();
      btnMenuView = new Button();
      btnPfundZuKg = new Button();
      btnKgZuPfund = new Button();
      lblPfund = new Label();
      txtPfund = new TextBox();
      lblkg = new Label();
      txtKg = new TextBox();
      lblHeader = new Label();
      SuspendLayout();
      // 
      // btnTxtClear
      // 
      btnTxtClear.BackColor = Color.Navy;
      btnTxtClear.Cursor = Cursors.Hand;
      btnTxtClear.FlatStyle = FlatStyle.Popup;
      btnTxtClear.ForeColor = Color.Silver;
      btnTxtClear.Location = new Point(155, 17);
      btnTxtClear.Name = "btnTxtClear";
      btnTxtClear.Size = new Size(121, 42);
      btnTxtClear.TabIndex = 17;
      btnTxtClear.Text = "Clear";
      btnTxtClear.UseVisualStyleBackColor = false;
      btnTxtClear.Click += btnTxtClear_Clear;
      // 
      // btnMenuView
      // 
      btnMenuView.BackColor = Color.Navy;
      btnMenuView.Cursor = Cursors.Hand;
      btnMenuView.FlatStyle = FlatStyle.Popup;
      btnMenuView.ForeColor = Color.Silver;
      btnMenuView.Location = new Point(20, 17);
      btnMenuView.Name = "btnMenuView";
      btnMenuView.Size = new Size(121, 42);
      btnMenuView.TabIndex = 16;
      btnMenuView.Text = "Hauptmenu";
      btnMenuView.UseVisualStyleBackColor = false;
      btnMenuView.Click += btnMenuView_Show;
      // 
      // btnPfundZuKg
      // 
      btnPfundZuKg.BackColor = Color.Navy;
      btnPfundZuKg.Cursor = Cursors.Hand;
      btnPfundZuKg.FlatStyle = FlatStyle.Popup;
      btnPfundZuKg.ForeColor = Color.Silver;
      btnPfundZuKg.Location = new Point(155, 234);
      btnPfundZuKg.Name = "btnPfundZuKg";
      btnPfundZuKg.Size = new Size(121, 42);
      btnPfundZuKg.TabIndex = 15;
      btnPfundZuKg.Text = "Pfund -> kg\r\nBerechnen";
      btnPfundZuKg.UseVisualStyleBackColor = false;
      btnPfundZuKg.Click += btnPfundZuKg_Calculate;
      // 
      // btnKgZuPfund
      // 
      btnKgZuPfund.BackColor = Color.Navy;
      btnKgZuPfund.Cursor = Cursors.Hand;
      btnKgZuPfund.FlatStyle = FlatStyle.Popup;
      btnKgZuPfund.ForeColor = Color.Silver;
      btnKgZuPfund.Location = new Point(20, 234);
      btnKgZuPfund.Name = "btnKgZuPfund";
      btnKgZuPfund.Size = new Size(121, 42);
      btnKgZuPfund.TabIndex = 14;
      btnKgZuPfund.Text = "kg -> Pfund\r\nBerechnen";
      btnKgZuPfund.UseVisualStyleBackColor = false;
      btnKgZuPfund.Click += btnKgZuPfund_Calculate;
      // 
      // lblPfund
      // 
      lblPfund.AutoSize = true;
      lblPfund.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
      lblPfund.Location = new Point(155, 182);
      lblPfund.Name = "lblPfund";
      lblPfund.Size = new Size(151, 30);
      lblPfund.TabIndex = 13;
      lblPfund.Text = "Pfund (z.B. 6.5)";
      // 
      // txtPfund
      // 
      txtPfund.BackColor = SystemColors.HotTrack;
      txtPfund.BorderStyle = BorderStyle.None;
      txtPfund.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
      txtPfund.ForeColor = Color.WhiteSmoke;
      txtPfund.Location = new Point(20, 183);
      txtPfund.Name = "txtPfund";
      txtPfund.Size = new Size(129, 28);
      txtPfund.TabIndex = 12;
      txtPfund.TextAlign = HorizontalAlignment.Center;
      // 
      // lblkg
      // 
      lblkg.AutoSize = true;
      lblkg.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
      lblkg.Location = new Point(155, 134);
      lblkg.Name = "lblkg";
      lblkg.Size = new Size(129, 30);
      lblkg.TabIndex = 11;
      lblkg.Text = "kg (z.B. 5.78)";
      // 
      // txtKg
      // 
      txtKg.BackColor = SystemColors.HotTrack;
      txtKg.BorderStyle = BorderStyle.None;
      txtKg.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
      txtKg.ForeColor = Color.WhiteSmoke;
      txtKg.Location = new Point(20, 135);
      txtKg.Name = "txtKg";
      txtKg.Size = new Size(129, 28);
      txtKg.TabIndex = 10;
      txtKg.TextAlign = HorizontalAlignment.Center;
      // 
      // lblHeader
      // 
      lblHeader.AutoSize = true;
      lblHeader.Font = new Font("Segoe UI", 18F, FontStyle.Underline, GraphicsUnit.Point, 0);
      lblHeader.Location = new Point(35, 79);
      lblHeader.Name = "lblHeader";
      lblHeader.Size = new Size(224, 32);
      lblHeader.TabIndex = 9;
      lblHeader.Text = "Gewicht Umrechner";
      // 
      // WeightView
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      BackColor = Color.Black;
      Controls.Add(btnTxtClear);
      Controls.Add(btnMenuView);
      Controls.Add(btnPfundZuKg);
      Controls.Add(btnKgZuPfund);
      Controls.Add(lblPfund);
      Controls.Add(txtPfund);
      Controls.Add(lblkg);
      Controls.Add(txtKg);
      Controls.Add(lblHeader);
      ForeColor = Color.WhiteSmoke;
      Name = "WeightView";
      Size = new Size(320, 311);
      Load += WeightView_Load;
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private Button btnTxtClear;
    private Button btnMenuView;
    private Button btnPfundZuKg;
    private Button btnKgZuPfund;
    private Label lblPfund;
    private TextBox txtPfund;
    private Label lblkg;
    private TextBox txtKg;
    private Label lblHeader;
  }
}
