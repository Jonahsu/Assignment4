using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
             Saledetails sale = new Saledetails(1, 100, 15.5m, DateTime.Today, 5);
        }
    }
}
public class Saledetails
{
    private int SalesNo;
    private int ProductNo;
    private decimal Price;
    private DateTime DateOfSale;
    private int Qty;
    private decimal TotalAmount;

    public Saledetails(int salesNo, int productNo, decimal price, DateTime dateOfSale, int qty)
    {
        this.SalesNo = salesNo;
        this.ProductNo = productNo;
        this.Price = price;
        this.DateOfSale = dateOfSale;
        this.Qty = qty;
        Sales();
        ShowData();
    }

    private void Sales()
    {
        this.TotalAmount = Qty * Price;
    }

    public void ShowData()
    {
        Console.WriteLine("SalesNo: " + this.SalesNo);
        Console.WriteLine("ProductNo: " + this.ProductNo);
        Console.WriteLine("Price: " + this.Price);
        Console.WriteLine("DateOfSale: " + this.DateOfSale.ToShortDateString());
        Console.WriteLine("Qty: " + this.Qty);
        Console.WriteLine("TotalAmount: " + this.TotalAmount);
    }
}


