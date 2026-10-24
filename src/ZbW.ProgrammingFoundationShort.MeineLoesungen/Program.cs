namespace ZbW.ProgrammingFoundationShort.MeineLoesungen;

internal class Program
{
  [STAThread]
  private static void Main()
  {
    ApplicationConfiguration.Initialize();

    Application.Run(new ZbW.ProgrammingFoundationShort.MeineLoesungen.Module01.Aufgabe1_Bmi.BmiForm());
  }
}
