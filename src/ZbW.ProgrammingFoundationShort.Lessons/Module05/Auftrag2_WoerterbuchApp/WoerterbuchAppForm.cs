namespace ZbW.ProgrammingFoundationShort.Lessons.Module05.Auftrag2_WoerterbuchApp;

// ============================================================
// AUFTRAG 2 – WoerterbuchApp (⭐⭐ Mittel | ~30 Min.)
//
// Übersetzungs-App mit Dictionary<string,string>.
//
// Anforderungen:
//   - 5 Wörter vorausfüllen (Deutsch → Englisch)
//   - TxtSuche + CmdNachschlagen: TryGetValue für Übersetzung
//   - TxtKeyNeu + TxtValueNeu + CmdHinzufuegen: ContainsKey-Prüfung
//   - LstEintraege: alle Einträge anzeigen
// ============================================================

public partial class WoerterbuchAppForm : Form
{
  // TODO 1: private Dictionary<string, string> _woerterbuch = new();
  private Dictionary<string, string> _woerterbuch = new();

  public WoerterbuchAppForm()
  {
    InitializeComponent();
    // TODO 2: 5 Wörter vorab einfügen (z.B. Hund → Dog, Katze → Cat...)
    // TODO 3: AktualisiereListBox() aufrufen

    _woerterbuch.Add(key: "Hund", value: "Dog");
    _woerterbuch.Add(key: "Katze", value: "Cat");
    _woerterbuch.Add(key: "Auto", value: "Car");
    _woerterbuch.Add(key: "Wurtzel", value: "root");
    _woerterbuch.Add(key: "Haus", value: "house");

    AktualisiereListBox();
  }

  private void CmdNachschlagen_Click(object sender, EventArgs e)
  {
    // TODO 4: TryGetValue für TxtSuche.Text
    //         Gefunden: LblErgebnis anzeigen
    //         Nicht gefunden: "Kein Eintrag für..."

    if(_woerterbuch.TryGetValue(TxtSuche.Text, out string value))
    {
      LblErgebnis.Text = $"Gefunden: {TxtSuche.Text} -> {value}";           
    }
    else { LblErgebnis.Text = $"Nicht gefunden: \"Kein Eintrag für {TxtSuche.Text}\""; }
  }

  private void CmdHinzufuegen_Click(object sender, EventArgs e)
  {
    // TODO 5: Leere Felder prüfen
    // TODO 6: ContainsKey-Prüfung → Überschreiben bestätigen
    // TODO 7: _woerterbuch[key] = value;
    // TODO 8: AktualisiereListBox()

    if (TxtKeyNeu.Text == "") { return; }
    if (TxtValueNeu.Text == "") { return; }

    if (_woerterbuch.ContainsKey(TxtKeyNeu.Text))
    {
      if(MessageBox.Show("Berreits enthalten überschreiben?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
      {
        _woerterbuch[TxtKeyNeu.Text] = TxtValueNeu.Text;
      }
    }
    else
    {
      _woerterbuch[TxtKeyNeu.Text] = TxtValueNeu.Text;
    }
    AktualisiereListBox();
  }

  private void AktualisiereListBox()
  {
    // TODO 9: LstEintraege befüllen aus _woerterbuch
    LstEintraege.Items.Clear();

    foreach(var pair in _woerterbuch)
    {
      LstEintraege.Items.Add($"{pair.Key} -> {pair.Value}");
    }

  }
}
