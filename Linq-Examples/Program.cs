using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Linq_Examples
{
  public class Program
  {
    public static void Main(string[] args)
    {
      LessThanFive();
      FilterElementsOnProperty();
      FilterElementsOnMultipleProperties();
      FilterElementBasedOnPosition();
      TransformWithSelect();
    }
    public static void FilterElementBasedOnPosition()
    {
      string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
      var shortDigits = digits.Where((digit, index) => digits.Length < index);
      Console.WriteLine("Short Digits:");
      foreach (var d in shortDigits)
      {
        Console.WriteLine($"The word {d} is shorter than value.");
      }

    }
    public static void FilterElementsOnMultipleProperties()
    {
      List<Product> products = GetProductList();
      var result = from product in products
                   where product.UnitsInStock == 0 && product.UnitPrice > 20
                   select product;
      Console.WriteLine("Sold out and bigger than 20 :");
      foreach (var prod in products)
      {
        Console.WriteLine(prod.ProductName);
      }
    }
    public static void FilterElementsOnProperty()
    {
      List<Product> products = GetProductList();
      var soldOut = from product in products
                    where product.UnitsInStock == 0
                    select product;

      Console.WriteLine("Sold Out Products :");
      foreach (var prod in products)
      {
        Console.WriteLine($"{prod.ProductName} is sold out.");
      }
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
    public static void TransformWithSelect()
    {
      int[] numbers = { 1, 2, 3, 4, 5, };
      string[] strings = { "one", "two", "three", "four", "five" };
      var textNums = from n in numbers
                     select strings[n];
      Console.WriteLine("Number strings:");
      foreach (var s in textNums)
      {
        Console.WriteLine(s);  
      }

    }

  }
}
