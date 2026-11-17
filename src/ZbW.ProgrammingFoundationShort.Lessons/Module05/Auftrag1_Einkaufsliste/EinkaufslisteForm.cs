namespace ZbW.ProgrammingFoundationShort.Lessons.Module05.Auftrag1_Einkaufsliste;

// ============================================================
// AUFTRAG 1 – Einkaufsliste (⭐ Einfach | ~15 Min.)
//
// Verwaltet eine Einkaufsliste mit List<string>.
//
// Anforderungen:
//   - TxtArtikel: Artikel eingeben
//   - CmdHinzufuegen: Zur Liste hinzufügen
//   - CmdEntfernen: Ausgewählten Artikel entfernen
//   - CmdAlleLoeschen: Alle löschen
//   - LblAnzahl: Anzahl anzeigen
// ============================================================

public partial class EinkaufslisteForm : Form
{
  // TODO 1: private List<string> _artikel = new();
  List<string> _artikel = new();
  public EinkaufslisteForm()
  {
    InitializeComponent();
  }

  private void CmdHinzufuegen_Click(object sender, EventArgs e)
  {
    // TODO 2: Leere Eingabe prüfen
    // TODO 3: _artikel.Add(TxtArtikel.Text.Trim())
    // TODO 4: ListBox aktualisieren, LblAnzahl setzen
    // TODO 5: TxtArtikel leeren und fokussieren

    string eingabe = TxtArtikel.Text;

    if (eingabe == "") { MessageBox.Show("Bitte gib ein Artikel ein!");return; };

    _artikel.Add(eingabe.Trim());

    AktualisiereListBox();

    TxtArtikel.Clear();
    TxtArtikel.Focus();
  }

  private void CmdEntfernen_Click(object sender, EventArgs e)
  {
    // TODO 6: SelectedIndex prüfen (>= 0)
    // TODO 7: _artikel.RemoveAt(LstArtikel.SelectedIndex)  – Index statt Text (Duplikate!)
    // TODO 8: ListBox aktualisieren

    if (LstArtikel.SelectedIndex >= 0)
    {
      _artikel.RemoveAt(LstArtikel.SelectedIndex);
    }
    AktualisiereListBox();
  }

  private void CmdAlleLoeschen_Click(object sender, EventArgs e)
  {
    // TODO 9: _artikel.Clear(), ListBox leeren, LblAnzahl = "0"
    _artikel.Clear();
    LstArtikel.Items.Clear();
    LblAnzahl.Text = "Artikel: 0";
  }

  private void AktualisiereListBox()
  {
    // TODO 10: LstArtikel.Items.Clear();
    //          foreach (string a in _artikel) LstArtikel.Items.Add(a);
    //          LblAnzahl.Text = $"Artikel: {_artikel.Count}";
    LstArtikel.Items.Clear();

    foreach(var a in _artikel)
    {
      LstArtikel.Items.Add(a);
    }

    LblAnzahl.Text = $"Artikel: {_artikel.Count}";
  }
}
