using System;
using System.Linq;
using System.Collections.Generic;
using LinQ01.Models;
using LinQ01.DataSources;
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
        }
    }
}
