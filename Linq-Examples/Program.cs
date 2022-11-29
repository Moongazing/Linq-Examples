using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq_Examples
{
  public class Program
  {
    public static void Main(string[] args)
    {
      LessThanFive();
     



    }
    public static void LessThanFive()
    {
      List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

      var lowNumbers = from num in numbers
                       where num < 5
                       select num;

      Console.WriteLine("Numbers < 5 : ");
      foreach (var x in lowNumbers)
      {
        Console.WriteLine(x);
      }
    }

  }
}
