using System.Drawing.Drawing2D;
using System.Text;
using ZbW.ProgrammingFoundationShort.MeineLoesungen.utils;

namespace ZbW.ProgrammingFoundationShort.MeineLoesungen.Module04.Aufgabe3_MatrizenRechner;


public partial class MatrizenRechnerForm : Form
{
  private readonly TextBox[,,] _eingabefelder;
  private int[,,] matrixen = new int[2, 3, 3];
  private enum Matrix { A = 0, B = 1 }

  public MatrizenRechnerForm()
  {
    InitializeComponent();
    _eingabefelder = new TextBox[,,]
    {
      { { TxtA00, TxtA01, TxtA02 }, { TxtA10, TxtA11, TxtA12 }, { TxtA20, TxtA21, TxtA22 } },
      { { TxtB00, TxtB01, TxtB02 }, { TxtB10, TxtB11, TxtB12 }, { TxtB20, TxtB21, TxtB22 } }
    };
  }

  #region --- Methoden ---
  private void ReadMatrixAandB()
  {
    foreach (int matrix in Enum.GetValues<Matrix>())
    {
      for (int row = 0; row < 3; row++)
      {
        for (int col = 0; col < 3; col++)
        {
          int? feldInhalt = InputHelper.GetInput<int>(_eingabefelder[matrix, row, col].Text);

          if (!feldInhalt.HasValue)
          {
            MessageBox.Show($"Ungültige Eingabe bei \r\nMatrix: {(matrix == 0 ? 'A' : 'B')} | Zeilen Index: {row} | Spalten Index: {col}");
            return;
          }

          matrixen[matrix, row, col] = (int)feldInhalt;
        }
      }
    }
  }

  private int[,] AddMatrixes(int[,,] matrixen)
  {
    int[,] result = new int[3, 3];

    for (int row = 0; row < 3; row++)
    {
      for (int col = 0; col < 3; col++)
      {
        result[row, col] = matrixen[(int)Matrix.A, row, col] + matrixen[(int)Matrix.B, row, col];
      }
    }

    return result;
  }

  private int[,] Transpose(int[,,] matrixen, Matrix matrix = Matrix.A)
  {
    int[,] result = new int[3, 3];

    for (int row = 0; row < 3; row++)
    {
      for (int col = 0; col < 3; col++)
      {
        result[row, col] = matrixen[(int)matrix, col, row];
      }
    }

    return result;
  }

  private void ShowMatrix(int[,] matrix, string labelTxt)
  {
    LblErgebnis.Text = "";

    int maxElementLength = 0;

    for (int row = 0; row < 3; row++)
    {
      for (int col = 0; col < 3; col++)
      {
        if (matrix[row, col].ToString().Length > maxElementLength)
        {
          maxElementLength = matrix[row, col].ToString().Length;
        }
        else { continue; }
      }
    }

    StringBuilder sb = new StringBuilder();

    sb.AppendLine(labelTxt);
    sb.AppendLine();

    for (int row = 0; row < 3; row++)
    {
      sb.Append("|");

      for (int col = 0; col < 3; col++)
      {
        string element = $"{matrix[row, col]}";
        
        element = element.PadLeft((maxElementLength));        

        sb.Append($"{element}|");
      }

      sb.Append("\r\n");
    }

    LblErgebnis.Text = sb.ToString();
  }
  #endregion

  #region --- Buttons ---
  private void CmdAddieren_Click(object sender, EventArgs e)
  {
    ReadMatrixAandB();
    ShowMatrix(matrix: AddMatrixes(matrixen: matrixen), labelTxt: "Matrix A + Matrix B:");
  }

  private void CmdTransponieren_Click(object sender, EventArgs e)
  {
    ReadMatrixAandB();
    ShowMatrix(matrix: Transpose(matrixen: matrixen), labelTxt: "Matrix A Transpose:");
  }

  #endregion
}
