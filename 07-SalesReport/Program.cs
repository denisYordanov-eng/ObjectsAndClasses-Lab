using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_SalesReport
{
    class Program
    {
        class Sale
        {
            public string Town { get; set; }
            public string Product { get; set; }
            public decimal Price { get; set; }
            public decimal Quantity { get; set; }
        }
        class SalesByCity
        {
            public string Town { get; set; }
            public decimal Sales { get; set; }
        }
        static void Main(string[] args)
        {
          var sales =  ReadSales();

            var salesByCity = calculateSalesByCity(sales);

            foreach (var s in salesByCity.OrderBy(a => a.Town))
            {
                Console.WriteLine($"{s.Town} -> {s.Sales:F2}");
            }
        }

        static List<SalesByCity> calculateSalesByCity(Sale[] sales)
        {
            Dictionary<string, decimal> salesByCity = new Dictionary<string, decimal>();

            foreach (var s in sales)
            {
                if (!salesByCity.ContainsKey(s.Town))
                {
                    salesByCity[s.Town] = 0;
                }
                salesByCity[s.Town] += s.Quantity * s.Price;
            }
                     var salesList =  salesByCity.Select(s => new SalesByCity()
            {
                Town = s.Key,
                Sales = s.Value
            })
                .ToList();
            return salesList;
        }

        static  Sale[] ReadSales()
        {
            int n = int.Parse(Console.ReadLine());
            
            Sale[] sales = new Sale[n];
            for (int i = 0; i < n; i++)
            {
                var inputLine = Console.ReadLine().Split(' ');
                var sale = new Sale();
                sale.Town = inputLine[0];
                sale.Product = inputLine[1];
                sale.Price = decimal.Parse(inputLine[2]);
                sale.Quantity = decimal.Parse(inputLine[3]);
                sales[i] = sale;
            }
            return sales;
        }
    }
}
