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
      TakeElement();
      NestedTakePartitions();
      TakeWhile();
      CompareTwoSequencesForEquality();
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
      int[] numbers = { 3, 2, 1, 5, 4, };
      string[] strings = { "one", "two", "three", "four", "five" };
      var textNums = from n in numbers
                     select strings[n];
      Console.WriteLine("Number strings:");
      foreach (var s in textNums)
      {
        Console.WriteLine(s);
      }

    }
    public static void TakeElement()
    {
      int[] numbers = { 2, 3, 4, 6, 7, 5, 0, 8, 9, 1 };
      var first_ThreeNumber = numbers.Take(3);
      Console.WriteLine("First 3 Numbers:");
      foreach (var n in first_ThreeNumber)
      {
        Console.WriteLine(n);
      }

    }
    public static void NestedTakePartitions()
    {
      List<Customer> customers = GetCustomerList();
      var first3WAOrders = (
        from c in customers
        from o in c.Orders
        where c.Region == "WA"
        select (c.CustomerId, o.OrderId, o.OrderDate)).Take(3);

      Console.WriteLine("First 3 orders in WA");
      foreach (var order in first3WAOrders)
      {
        Console.WriteLine(order);
      }
    }
    public static void TakeWhile()
    {
      int[] numbers = { 5, 6, 7, 2, 3, 4, 1, 0 };
      var firstNumbersLessThanSix = numbers.TakeWhile(n => n < 6);
      Console.WriteLine("First Numbers Less Than Six");
      foreach (var num in firstNumbersLessThanSix)
      {
        Console.WriteLine(num);
      }
    }
    public static void CompareTwoSequencesForEquality()
    {
      var wordsA = new string[] { "cheery", "apple", "blueberry" };
      var wordsB = new string[] { "cheery", "apple", "blueberry" };

      bool IsMatch = wordsA.SequenceEqual(wordsB);
      Console.WriteLine($"The Sequences Match : {IsMatch}");

    }

  }
}
