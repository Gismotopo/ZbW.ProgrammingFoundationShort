namespace ZbW.ProgrammingFoundationShort.MeineLoesungen.Module01.Aufgabe4__Bonus__Einheitenrehner
{
  partial class MenuView
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
      btnDistanceView = new Button();
      btnWeightView = new Button();
      btnTempView = new Button();
      SuspendLayout();
      // 
      // lblHeader
      // 
      lblHeader.AutoSize = true;
      lblHeader.Font = new Font("Segoe UI", 18F, FontStyle.Underline, GraphicsUnit.Point, 0);
      lblHeader.Location = new Point(25, 22);
      lblHeader.Name = "lblHeader";
      lblHeader.Size = new Size(195, 32);
      lblHeader.TabIndex = 0;
      lblHeader.Text = "Einheitenrechner";
      // 
      // btnDistanceView
      // 
      btnDistanceView.BackColor = Color.Navy;
      btnDistanceView.Cursor = Cursors.Hand;
      btnDistanceView.FlatStyle = FlatStyle.Popup;
      btnDistanceView.ForeColor = Color.Silver;
      btnDistanceView.Location = new Point(20, 71);
      btnDistanceView.Name = "btnDistanceView";
      btnDistanceView.Size = new Size(204, 57);
      btnDistanceView.TabIndex = 1;
      btnDistanceView.Text = "km <-> Meilen";
      btnDistanceView.UseVisualStyleBackColor = false;
      btnDistanceView.Click += btnDistanceView_Show;
      // 
      // btnWeightView
      // 
      btnWeightView.BackColor = Color.Navy;
      btnWeightView.Cursor = Cursors.Hand;
      btnWeightView.FlatStyle = FlatStyle.Popup;
      btnWeightView.ForeColor = Color.Silver;
      btnWeightView.Location = new Point(20, 145);
      btnWeightView.Name = "btnWeightView";
      btnWeightView.Size = new Size(204, 57);
      btnWeightView.TabIndex = 2;
      btnWeightView.Text = "kg <-> Pfund";
      btnWeightView.UseVisualStyleBackColor = false;
      btnWeightView.Click += btnWeightView_Show;
      // 
      // btnTempView
      // 
      btnTempView.BackColor = Color.Navy;
      btnTempView.Cursor = Cursors.Hand;
      btnTempView.FlatStyle = FlatStyle.Popup;
      btnTempView.ForeColor = Color.Silver;
      btnTempView.Location = new Point(20, 219);
      btnTempView.Name = "btnTempView";
      btnTempView.Size = new Size(204, 57);
      btnTempView.TabIndex = 3;
      btnTempView.Text = "°C <-> °F";
      btnTempView.UseVisualStyleBackColor = false;
      btnTempView.Click += btnTempView_Show;
      // 
      // MenuView
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      BackColor = Color.Black;
      Controls.Add(btnTempView);
      Controls.Add(btnWeightView);
      Controls.Add(btnDistanceView);
      Controls.Add(lblHeader);
      ForeColor = Color.WhiteSmoke;
      Name = "MenuView";
      Size = new Size(246, 307);
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private Label lblHeader;
    private Button btnDistanceView;
    private Button btnWeightView;
    private Button btnTempView;
  }
}
