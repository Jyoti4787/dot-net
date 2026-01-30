using System;
using System.Collections.Generic;

class ECommerceDiscount
{
    static void Main()
    {
        Console.WriteLine("=== E-COMMERCE DISCOUNT CALCULATOR ===\n");
        
        // Sample data: CustomerType, PurchaseAmount
        List<(char, double)> purchases = new List<(char, double)>
        {
            ('R', 150.00),  // Regular, > $100
            ('R', 80.00),   // Regular, < $100
            ('P', 120.00),  // Premium
            ('V', 250.00),  // VIP, > $200
            ('V', 180.00),  // VIP, < $200
            ('R', 500.00)   // Regular, large purchase
        };
        
        foreach (var purchase in purchases)
        {
            ProcessPurchase(purchase.Item1, purchase.Item2);
            Console.WriteLine("------------------------");
        }
    }
    
    static void ProcessPurchase(char customerType, double purchaseAmount)
{
    string customerName = GetCustomerTypeName(customerType);

    double discountRate = CalculateDiscountRate(customerType, purchaseAmount);
    double discountAmount = purchaseAmount * discountRate;
    double finalPrice = purchaseAmount - discountAmount;

    Console.WriteLine($"Customer Type: {customerName}");
    Console.WriteLine($"Original Price: ${purchaseAmount:F2}");
    Console.WriteLine($"Discount Applied: {discountRate:P0}");
    Console.WriteLine($"Discount Amount: ${discountAmount:F2}");
    Console.WriteLine($"Final Price: ${finalPrice:F2}");
}

    
    static double CalculateDiscountRate(char customerType, double purchaseAmount)
{
    switch (customerType)
    {
        case 'R':
            if (purchaseAmount > 100)
                return 0.05;
            return 0.0;

        case 'P':
            return 0.10;

        case 'V':
            if (purchaseAmount > 200)
                return 0.20;   // 15% + extra 5%
            return 0.15;

        default:
            return 0.0;
    }
}

    
    static string GetCustomerTypeName(char customerType)
    {
        return customerType switch
        {
            'R' => "Regular",
            'P' => "Premium",
            'V' => "VIP",
            _ => "Unknown"
        };
    }
}