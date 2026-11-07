using System;
using System.Collections.Generic;
using System.Text;

namespace ZbW.ProgrammingFoundationShort.MeineLoesungen.utils
{
  public static class InputHelper
  {
    public static T? GetInput<T>(string input) where T: struct
    {
      switch (typeof(T))
      {
        case Type typ when typ == typeof(int):
          {
            if (!int.TryParse(input, out int number))
            {
              return default(T);
            }
            return (T)(object)number;
          }

        case Type typ when typ == typeof(double):
          {
            if (!double.TryParse(input, out double number) || double.IsNaN(number))
            {
              return default(T);
            }
            return (T)(object)number;
          }

        case Type typ when typ == typeof(decimal):
          {
            if (!decimal.TryParse(input, out decimal number))
            {
              return default(T);
            }
            return (T)(object)number;
          }

        default:
          throw new NotSupportedException(
            $"Der Typ {typeof(T).Name} wird nicht unterstützt");
      }
    }
  }
}
