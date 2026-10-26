using LinQ01.DataSources;
using LinQ01.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Xml.Linq;
namespace LinQ01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1. Get all products from the "Seafood" category. Print each product's name and price.MyRegion
            //var query = from p in Source.ProductList
            //            where p.Category == "Seafood"
            //            select new { p.ProductName , p.UnitPrice };

            //foreach (var p in query) 
            //{
            //    Console.WriteLine($"ProductName: {p.ProductName},  Price: {p.UnitPrice:C2}");
            //}
            #endregion

            #region Q2. Get a list of only the product names from ProductList. Print each name
            //var query02 = from p in Source.ProductList
            //             select p.ProductName;

            //foreach (var p in query02) 
            //{
            //    Console.WriteLine($"Product Name: {p}");
            //}
            #endregion

            #region Q3. Sort all products by UnitPrice (ascending). Print each product's name and price

            //var query = Source.ProductList.OrderBy(p => p.UnitPrice);

            //foreach (var p in query)
            //    Console.WriteLine($"{p.ProductName} - {p.UnitPrice:F2}");

            #endregion

            #region Q4. Get all products where UnitPrice is between 10 and 30

            //var query = from p in Source.ProductList
            //            where p.UnitPrice >= 10 && p.UnitPrice <= 30
            //            select p;
            //foreach (var p in query)
            //    Console.WriteLine($"{p.ProductName} - {p.UnitPrice:F2}");
            #endregion

            #region Q5. Get all products that are in stock (UnitsInStock > 0) and belong to the "Spices & Condiments" category
            //var query = Source.ProductList
            //    .Where(p => p.UnitsInStock > 0 && p.Category == "Spices & Condiments");

            //foreach (var p in query)
            //    Console.WriteLine(p);

            #endregion

            #region Q6 Create a new anonymous type with three properties:
            // Name → the product name
            // Price → the unit price
            // StockStatus → a string: "Available" if UnitsInStock > 0, otherwise "Out of Stock"
            // Print the result.

            //var query = Source.ProductList
            //    .Select(p => new
            //{
            //    Name = p.ProductName,
            //    Price = p.UnitPrice,
            //    StockStatus = p.UnitsInStock > 0 ? "Available" : "Out of Stock"
            //});
            //foreach (var item in query)
            //    Console.WriteLine($"{item.Name} | {item.Price:F2} | {item.StockStatus}");

            #endregion

            #region Q7 Print each product's name along with its position (1-based) in the list. Expected format: 1. Chai, 2. Chang, etc.

            //var query = Source.ProductList
            //    .Select((p, index) => $"{index + 1}. {p.ProductName}");

            //foreach (var p in query)
            //    Console.WriteLine(p);

            #endregion

            #region Q8 Sort ProductList by Category ascending, then within each category, sort by UnitPrice descending

            //var query = Source.ProductList
            //                   .OrderBy(p => p.Category)
            //                   .ThenByDescending(p => p.UnitPrice);
            //foreach (var p in query)
            //    Console.WriteLine($"{p.Category,-22} {p.ProductName,-30} {p.UnitPrice:F2}");

            #endregion

            #region Q9 Get all products from the "Beverages" category, sorted by UnitsInStock descending. Print name and stock.
            //var query = Source.ProductList
            //                 .Where(p => p.Category == "Beverages")
            //                 .OrderByDescending(p => p.UnitsInStock);
            //foreach (var p in query)
            //    Console.WriteLine($"{p.ProductName} - Stock: {p.UnitsInStock}");

            #endregion

            #region Q10 Using QUERY SYNTAX with a compound from clause, list all orders placed in 1997 or later showing CustomerID and OrderDate

            //var query = from c in Source.CustomerList
            //             from o in c.Orders
            //             where o.OrderDate.Year >= 1997
            //             select new { c.CustomerID, o.OrderDate };

            //foreach (var item in query)
            //    Console.WriteLine($"{item.CustomerID} - {item.OrderDate:yyyy-MM-dd}");

            #endregion

            #region Q11 Show position number alongside ProductName

            //var query = Source.ProductList
            //    .Select((p, index) => new
            //{
            //    Position = index + 1,
            //    p.ProductName
            //});
            //foreach (var item in query)
            //    Console.WriteLine($"{item.Position,3}  {item.ProductName}");

            #endregion

            #region Q12 Sort first by-word length and then by a case-insensitive sort of the words in an array.
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var query = Arr.OrderBy(w => w.Length)
            //                .ThenBy(w => w, StringComparer.OrdinalIgnoreCase);

            //foreach (var w in query)
            //    Console.WriteLine(w);

            #endregion

            #region Q13 Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array.

            //string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            
            //var query = digits.Where(d => d[1] == 'i').Reverse();
            
            //foreach (var d in query)
            //    Console.WriteLine(d);
            #endregion
        }
    }
}
