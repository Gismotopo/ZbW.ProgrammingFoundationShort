namespace ZbW.ProgrammingFoundationShort.MeineLoesungen.Module02.Aufgabe1_Ampelsteuerung;

/// <summary>
///   Aufgabe 1 – Ampelsteuerung (⭐ Einfach)
///   Zeigt die Ampelfarbe und Bedeutung per switch-case an.
/// </summary>

public partial class AmpelsteuerungForm : Form
{

  private enum TrafficLightColor { Red, Yellow, Green};

  public AmpelsteuerungForm()
  {
    InitializeComponent();
  }

  private void CmdAnzeigen_Click(object sender, EventArgs e)
  {
    (Color farbe, string text) light = GetLight() switch
    {
      TrafficLightColor.Red => ( Color.Red, "Anhalten!"),
      TrafficLightColor.Yellow => (Color.Yellow, "Vollgas!! das Reicht noch"),
      _ => (Color.Green, "Freie Fahrt"),      
    };

    LblAmpel.BackColor = light.farbe;
    LblMeldung.Text = light.text;
  }

  private TrafficLightColor GetLight()
  {
    if (RadRot.Checked) {return TrafficLightColor.Red; }
    else if (RadGelb.Checked) { return TrafficLightColor.Yellow; }
    else { return TrafficLightColor.Green; }
  }    
}
