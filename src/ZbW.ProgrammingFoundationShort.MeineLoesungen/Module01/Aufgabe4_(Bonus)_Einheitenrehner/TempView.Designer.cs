namespace ZbW.ProgrammingFoundationShort.MeineLoesungen.Module01.Aufgabe4__Bonus__Einheitenrehner
{
  partial class TempView
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
      btnCelsiusZuFahrenheit = new Button();
      lblFahrenheit = new Label();
      txtFahrenheit = new TextBox();
      lblCelsius = new Label();
      txtCelsius = new TextBox();
      lblHeader = new Label();
      SuspendLayout();
      // 
      // btnTxtClear
      // 
      btnTxtClear.BackColor = Color.Navy;
      btnTxtClear.Cursor = Cursors.Hand;
      btnTxtClear.FlatStyle = FlatStyle.Popup;
      btnTxtClear.ForeColor = Color.Silver;
      btnTxtClear.Location = new Point(156, 20);
      btnTxtClear.Name = "btnTxtClear";
      btnTxtClear.Size = new Size(121, 42);
      btnTxtClear.TabIndex = 26;
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
      btnMenuView.Location = new Point(21, 20);
      btnMenuView.Name = "btnMenuView";
      btnMenuView.Size = new Size(121, 42);
      btnMenuView.TabIndex = 25;
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
      btnPfundZuKg.Location = new Point(156, 237);
      btnPfundZuKg.Name = "btnPfundZuKg";
      btnPfundZuKg.Size = new Size(121, 42);
      btnPfundZuKg.TabIndex = 24;
      btnPfundZuKg.Text = "°Fahrenheit -> °C\r\nBerechnen";
      btnPfundZuKg.UseVisualStyleBackColor = false;
      btnPfundZuKg.Click += btnPfundZuKg_Click;
      // 
      // btnCelsiusZuFahrenheit
      // 
      btnCelsiusZuFahrenheit.BackColor = Color.Navy;
      btnCelsiusZuFahrenheit.Cursor = Cursors.Hand;
      btnCelsiusZuFahrenheit.FlatStyle = FlatStyle.Popup;
      btnCelsiusZuFahrenheit.ForeColor = Color.Silver;
      btnCelsiusZuFahrenheit.Location = new Point(21, 237);
      btnCelsiusZuFahrenheit.Name = "btnCelsiusZuFahrenheit";
      btnCelsiusZuFahrenheit.Size = new Size(121, 42);
      btnCelsiusZuFahrenheit.TabIndex = 23;
      btnCelsiusZuFahrenheit.Text = "°C ->°Fahrenheit\r\nBerechnen";
      btnCelsiusZuFahrenheit.UseVisualStyleBackColor = false;
      btnCelsiusZuFahrenheit.Click += btnCelsiusZuFahrenheit_Click;
      // 
      // lblFahrenheit
      // 
      lblFahrenheit.AutoSize = true;
      lblFahrenheit.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
      lblFahrenheit.Location = new Point(156, 185);
      lblFahrenheit.Name = "lblFahrenheit";
      lblFahrenheit.Size = new Size(124, 30);
      lblFahrenheit.TabIndex = 22;
      lblFahrenheit.Text = "° Fahrenheit";
      // 
      // txtFahrenheit
      // 
      txtFahrenheit.BackColor = SystemColors.HotTrack;
      txtFahrenheit.BorderStyle = BorderStyle.None;
      txtFahrenheit.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
      txtFahrenheit.ForeColor = Color.WhiteSmoke;
      txtFahrenheit.Location = new Point(21, 186);
      txtFahrenheit.Name = "txtFahrenheit";
      txtFahrenheit.Size = new Size(129, 28);
      txtFahrenheit.TabIndex = 21;
      txtFahrenheit.TextAlign = HorizontalAlignment.Center;
      // 
      // lblCelsius
      // 
      lblCelsius.AutoSize = true;
      lblCelsius.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
      lblCelsius.Location = new Point(156, 137);
      lblCelsius.Name = "lblCelsius";
      lblCelsius.Size = new Size(85, 30);
      lblCelsius.TabIndex = 20;
      lblCelsius.Text = "°Celsius";
      // 
      // txtCelsius
      // 
      txtCelsius.BackColor = SystemColors.HotTrack;
      txtCelsius.BorderStyle = BorderStyle.None;
      txtCelsius.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
      txtCelsius.ForeColor = Color.WhiteSmoke;
      txtCelsius.Location = new Point(21, 138);
      txtCelsius.Name = "txtCelsius";
      txtCelsius.Size = new Size(129, 28);
      txtCelsius.TabIndex = 19;
      txtCelsius.TextAlign = HorizontalAlignment.Center;
      // 
      // lblHeader
      // 
      lblHeader.AutoSize = true;
      lblHeader.Font = new Font("Segoe UI", 18F, FontStyle.Underline, GraphicsUnit.Point, 0);
      lblHeader.Location = new Point(21, 80);
      lblHeader.Name = "lblHeader";
      lblHeader.Size = new Size(261, 32);
      lblHeader.TabIndex = 18;
      lblHeader.Text = "Temperatur Umrechner";
      // 
      // TempView
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      BackColor = Color.Black;
      Controls.Add(btnTxtClear);
      Controls.Add(btnMenuView);
      Controls.Add(btnPfundZuKg);
      Controls.Add(btnCelsiusZuFahrenheit);
      Controls.Add(lblFahrenheit);
      Controls.Add(txtFahrenheit);
      Controls.Add(lblCelsius);
      Controls.Add(txtCelsius);
      Controls.Add(lblHeader);
      ForeColor = Color.WhiteSmoke;
      Name = "TempView";
      Size = new Size(317, 307);
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private Button btnTxtClear;
    private Button btnMenuView;
    private Button btnPfundZuKg;
    private Button btnCelsiusZuFahrenheit;
    private Label lblFahrenheit;
    private TextBox txtFahrenheit;
    private Label lblCelsius;
    private TextBox txtCelsius;
    private Label lblHeader;
  }
}
