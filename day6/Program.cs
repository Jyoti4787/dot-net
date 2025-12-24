using System;

// STRUCT
// struct StockPrice
// {
//     public string StockSymbol;
//     public double Price;
// }

// // CLASS
// class Trade
// {
//     public int TradeId;
//     public string StockSymbol;
//     public int Quantity;
// }

// class Program
// {
//     static void Main()
//     {
//         // Create StockPrice object
//         StockPrice sp1;
//         sp1.StockSymbol = "TCS";
//         sp1.Price = 3500.50;

//         // Copy struct object
//         StockPrice sp2 = sp1;

//         // Create Trade object
//         Trade t1 = new Trade();
//         t1.TradeId = 101;
//         t1.StockSymbol = "TCS";
//         t1.Quantity = 10;

//         // Copy class object
//         Trade t2 = t1;

//         // Output
//         Console.WriteLine("StockPrice Objects:");
//         Console.WriteLine("SP1: " + sp1.StockSymbol + " - " + sp1.Price);
//         Console.WriteLine("SP2: " + sp2.StockSymbol + " - " + sp2.Price);

//         Console.WriteLine("Trade Objects:");
//         Console.WriteLine("T1: " + t1.TradeId + " " + t1.StockSymbol + " " + t1.Quantity);
//         Console.WriteLine("T2: " + t2.TradeId + " " + t2.StockSymbol + " " + t2.Quantity);
//     }
// }

using System;

class Program
{
    public static void Main()
    {
        TradeRepository<EquityTrade> repository = new TradeRepository<EquityTrade>();

        EquityTrade t1 = new EquityTrade
        {
            TradeId = 1,
            StockSymbol = "AAPL",
            Quantity = 100,
            MarketPrice = 150.50
        };

        TradeProcessor.ProcessTrade(t1);

        double tradeValue1 = t1.CalculateTradeValue();
        double brokerage1 = tradeValue1.CalculateBrokerage(0.001);
        double gst1 = tradeValue1.CalculateGst(0.00018);

        Console.WriteLine($"Trade Value: {tradeValue1}");
        Console.WriteLine($"Brokerage: {brokerage1}");
        Console.WriteLine($"GST: {gst1}");
        Console.WriteLine(
            $"TradeId: {t1.TradeId}, Symbol: {t1.StockSymbol}, Qty: {t1.Quantity}"
        );
        Console.WriteLine();

        repository.AddTrade(t1);

        EquityTrade t2 = new EquityTrade
        {
            TradeId = 2,
            StockSymbol = "MSFT",
            Quantity = 50,
            MarketPrice = null
        };

        TradeProcessor.ProcessTrade(t2);

        double tradeValue2 = t2.CalculateTradeValue();
        double brokerage2 = tradeValue2.CalculateBrokerage(0.001);
        double gst2 = tradeValue2.CalculateGst(0.00018);

        Console.WriteLine($"Trade Value: {tradeValue2}");
        Console.WriteLine($"Brokerage: {brokerage2}");
        Console.WriteLine($"GST: {gst2}");
        Console.WriteLine(
            $"TradeId: {t2.TradeId}, Symbol: {t2.StockSymbol}, Qty: {t2.Quantity}"
        );
        Console.WriteLine();

        repository.AddTrade(t2);

        TradeAnalytics.DisplayAnalytics();
    }
}