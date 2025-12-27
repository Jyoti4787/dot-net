//MediSure Clinic: Simple Patient Billing 

// using System;

// class PatientBill
// {
//     public string? BillId { get; set; }
//     public string? PatientName { get; set; }
//     public bool HasInsurance { get; set; }

//     public decimal ConsultationFee { get; set; }
//     public decimal LabCharges { get; set; }
//     public decimal MedicineCharges { get; set; }

//     public decimal GrossAmount { get; set; }
//     public decimal DiscountAmount { get; set; }
//     public decimal FinalPayable { get; set; }
// }

// class BillingService
// {
//     public static PatientBill? LastBill;
//     public static bool HasLastBill = false;
//     public static void CreateNewBill()
//     {
//         PatientBill bill = new PatientBill();

//         // Bill ID validation
//         while (true)
//         {
//             Console.Write("Enter Bill Id: ");
//             bill.BillId = Console.ReadLine();

//             if (!string.IsNullOrWhiteSpace(bill.BillId))
//                 break;

//             Console.WriteLine("Bill Id cannot be empty.");
//         }

//         // Patient Name validation (NO NUMBERS ALLOWED)
//         while (true)
//         {
//             Console.Write("Enter Patient Name: ");
//             string nameInput = Console.ReadLine();

//             bool isValid = true;

//             if (string.IsNullOrWhiteSpace(nameInput))
//             {
//                 isValid = false;
//             }
//             else
//             {
//                 foreach (char c in nameInput)
//                 {
//                     if (!char.IsLetter(c) && c != ' ')
//                     {
//                         isValid = false;
//                         break;
//                     }
//                 }
//             }

//             if (isValid)
//             {
//                 bill.PatientName = nameInput;
//                 break;
//             }
//             else
//             {
//                 Console.WriteLine("Invalid name. Only alphabets and spaces are allowed.");
//             }
//         }

//         // Insurance input
//         while (true)
//         {
//             Console.Write("Is the patient insured? (Y/N): ");
//             string input = Console.ReadLine()!.ToUpper();

//             if (input == "Y")
//             {
//                 bill.HasInsurance = true;
//                 break;
//             }
//             else if (input == "N")
//             {
//                 bill.HasInsurance = false;
//                 break;
//             }
//             else
//             {
//                 Console.WriteLine("Please enter Y or N only.");
//             }
//         }

//         // Fees
//         bill.ConsultationFee = ReadDecimal("Enter Consultation Fee: ", true);
//         bill.LabCharges = ReadDecimal("Enter Lab Charges: ", false);
//         bill.MedicineCharges = ReadDecimal("Enter Medicine Charges: ", false);

//         // Calculations
//         bill.GrossAmount = bill.ConsultationFee + bill.LabCharges + bill.MedicineCharges;

//         if (bill.HasInsurance)
//             bill.DiscountAmount = bill.GrossAmount * 0.10m;
//         else
//             bill.DiscountAmount = 0;

//         bill.FinalPayable = bill.GrossAmount - bill.DiscountAmount;

//         // Store last bill
//         LastBill = bill;
//         HasLastBill = true;

//         // Output
//         Console.WriteLine("\nBill created successfully.");
//         Console.WriteLine($"Gross Amount: {bill.GrossAmount:F2}");
//         Console.WriteLine($"Discount Amount: {bill.DiscountAmount:F2}");
//         Console.WriteLine($"Final Payable: {bill.FinalPayable:F2}");
//         Console.WriteLine("----------------------------");
//     }

//     //  VIEW LAST BILL 
//     public static void ViewLastBill()
//     {
//         if (!HasLastBill || LastBill == null)
//         {
//             Console.WriteLine("No bill available. Please create a new bill first.");
//             return;
//         }

//         Console.WriteLine(" Last Bill");
//         Console.WriteLine($"BillId: {LastBill.BillId}");
//         Console.WriteLine($"Patient: {LastBill.PatientName}");
//         Console.WriteLine($"Insured: {(LastBill.HasInsurance ? "Yes" : "No")}");
//         Console.WriteLine($"Consultation Fee: {LastBill.ConsultationFee:F2}");
//         Console.WriteLine($"Lab Charges: {LastBill.LabCharges:F2}");
//         Console.WriteLine($"Medicine Charges: {LastBill.MedicineCharges:F2}");
//         Console.WriteLine($"Gross Amount: {LastBill.GrossAmount:F2}");
//         Console.WriteLine($"Discount Amount: {LastBill.DiscountAmount:F2}");
//         Console.WriteLine($"Final Payable: {LastBill.FinalPayable:F2}");
//         Console.WriteLine("--------------------------------");
//         Console.WriteLine("----------------------------------");
//     }

//     //  CLEAR BILL 
//     public static void ClearLastBill()
//     {
//         LastBill = null;
//         HasLastBill = false;
//         Console.WriteLine("Last bill cleared.");
//     }

//     // DECIMAL INPUT HELPER 
//     private static decimal ReadDecimal(string message, bool mustBePositive)
//     {
//         decimal value;

//         while (true)
//         {
//             Console.Write(message);
//             bool valid = decimal.TryParse(Console.ReadLine(), out value);

//             if (!valid)
//             {
//                 Console.WriteLine("Invalid number. Try again.");
//                 continue;
//             }

//             if (mustBePositive && value <= 0)
//             {
//                 Console.WriteLine("Value must be greater than 0.");
//                 continue;
//             }

//             if (!mustBePositive && value < 0)
//             {
//                 Console.WriteLine("Value cannot be negative.");
//                 continue;
//             }

//             return value;
//         }
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         bool running = true;

//         while (running)
//         {
//             Console.WriteLine("MediSure Clinic Billing");
//             Console.WriteLine("1. Create New Bill (Enter Patient Details)");
//             Console.WriteLine("2. View Last Bill");
//             Console.WriteLine("3. Clear Last Bill");
//             Console.WriteLine("4. Exit");
//             Console.Write("Enter your option: ");

//             string choice = Console.ReadLine()!;

//             switch (choice)
//             {
//                 case "1":
//                     BillingService.CreateNewBill();
//                     break;

//                 case "2":
//                     BillingService.ViewLastBill();
//                     break;

//                 case "3":
//                     BillingService.ClearLastBill();
//                     break;

//                 case "4":
//                     Console.WriteLine("\nThank you. Application closed normally.");
//                     running = false;
//                     break;

//                 default:
//                     Console.WriteLine("Invalid option. Please choose between 1 and 4.");
//                     break;
//             }
//         }
//     }
// }




//QuickMart Traders: Profit Calculator 

using System;

class SaleTransaction
{
    public string? InvoiceNo { get; set; }
    public string? CustomerName { get; set; }
    public string? ItemName { get; set; }
    public int Quantity { get; set; }

    public decimal PurchaseAmount { get; set; }
    public decimal SellingAmount { get; set; }

    public string? ProfitOrLossStatus { get; set; }
    public decimal ProfitOrLossAmount { get; set; }
    public decimal ProfitMarginPercent { get; set; }
}

class TransactionService
{
    public static SaleTransaction? LastTransaction;
    public static bool HasLastTransaction = false;
    public static void CreateNewTransaction()
    {
        SaleTransaction tx = new SaleTransaction();
        while (true)
        {
            Console.Write("Enter Invoice No: ");
            tx.InvoiceNo = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(tx.InvoiceNo))
                break;

            Console.WriteLine("Invoice No cannot be empty.");
        }
        tx.CustomerName = ReadName("Enter Customer Name: ");
        tx.ItemName = ReadName("Enter Item Name: ");
        while (true)
        {
            Console.Write("Enter Quantity: ");
            bool ok = int.TryParse(Console.ReadLine(), out int q);

            if (ok && q > 0)
            {
                tx.Quantity = q;
                break;
            }

            Console.WriteLine("Quantity must be greater than 0.");
        }
        tx.PurchaseAmount = ReadDecimal("Enter Purchase Amount (total): ", true);
        tx.SellingAmount = ReadDecimal("Enter Selling Amount (total): ", false);

        CalculateProfitLoss(tx);

        LastTransaction = tx;
        HasLastTransaction = true;

        Console.WriteLine("\nTransaction saved successfully.");
        Console.WriteLine($"Status: {tx.ProfitOrLossStatus}");
        Console.WriteLine($"Profit/Loss Amount: {tx.ProfitOrLossAmount:F2}");
        Console.WriteLine($"Profit Margin (%): {tx.ProfitMarginPercent:F2}");
        Console.WriteLine("------------------------------------------------------");
    }
    public static void ViewLastTransaction()
    {
        if (!HasLastTransaction || LastTransaction == null)
        {
            Console.WriteLine("No transaction available. Please create a new transaction first.");
            return;
        }

        Console.WriteLine("\nLast Transaction ");
        Console.WriteLine($"InvoiceNo: {LastTransaction.InvoiceNo}");
        Console.WriteLine($"Customer: {LastTransaction.CustomerName}");
        Console.WriteLine($"Item: {LastTransaction.ItemName}");
        Console.WriteLine($"Quantity: {LastTransaction.Quantity}");
        Console.WriteLine($"Purchase Amount: {LastTransaction.PurchaseAmount:F2}");
        Console.WriteLine($"Selling Amount: {LastTransaction.SellingAmount:F2}");
        Console.WriteLine($"Status: {LastTransaction.ProfitOrLossStatus}");
        Console.WriteLine($"Profit/Loss Amount: {LastTransaction.ProfitOrLossAmount:F2}");
        Console.WriteLine($"Profit Margin (%): {LastTransaction.ProfitMarginPercent:F2}");
        Console.WriteLine("--------------------------------------------");
        Console.WriteLine("---------------------------------");
    }
    public static void RecalculateProfitLoss()
    {
        if (!HasLastTransaction || LastTransaction == null)
        {
            Console.WriteLine("No transaction available. Please create a new transaction first.");
            return;
        }

        CalculateProfitLoss(LastTransaction);

        Console.WriteLine("\nRecalculated Profit/Loss:");
        Console.WriteLine($"Status: {LastTransaction.ProfitOrLossStatus}");
        Console.WriteLine($"Profit/Loss Amount: {LastTransaction.ProfitOrLossAmount:F2}");
        Console.WriteLine($"Profit Margin (%): {LastTransaction.ProfitMarginPercent:F2}");
        Console.WriteLine("------------------------------------------------------");
    }
    private static void CalculateProfitLoss(SaleTransaction t)
    {
        if (t.SellingAmount > t.PurchaseAmount)
        {
            t.ProfitOrLossStatus = "PROFIT";
            t.ProfitOrLossAmount = t.SellingAmount - t.PurchaseAmount;
        }
        else if (t.SellingAmount < t.PurchaseAmount)
        {
            t.ProfitOrLossStatus = "LOSS";
            t.ProfitOrLossAmount = t.PurchaseAmount - t.SellingAmount;
        }
        else
        {
            t.ProfitOrLossStatus = "BREAK-EVEN";
            t.ProfitOrLossAmount = 0;
        }

        t.ProfitMarginPercent =
            (t.ProfitOrLossAmount / t.PurchaseAmount) * 100;
    }
    private static string ReadName(string message)
    {
        while (true)
        {
            Console.Write(message);
            string input = Console.ReadLine();

            bool valid = true;

            if (string.IsNullOrWhiteSpace(input))
            {
                valid = false;
            }
            else
            {
                foreach (char c in input)
                {
                    if (!char.IsLetter(c) && c != ' ')
                    {
                        valid = false;
                        break;
                    }
                }
            }

            if (valid)
                return input;

            Console.WriteLine("Invalid input. Only alphabets and spaces are allowed.");
        }
    }
    private static decimal ReadDecimal(string message, bool mustBePositive)
    {
        decimal value;

        while (true)
        {
            Console.Write(message);
            bool ok = decimal.TryParse(Console.ReadLine(), out value);

            if (!ok)
            {
                Console.WriteLine("Invalid number. Try again.");
                continue;
            }

            if (mustBePositive && value <= 0)
            {
                Console.WriteLine("Value must be greater than 0.");
                continue;
            }

            if (!mustBePositive && value < 0)
            {
                Console.WriteLine("Value cannot be negative.");
                continue;
            }

            return value;
        }
    }
}

class Program
{
    static void Main()
    {
        bool running = true;

        while (running)
        {
            Console.WriteLine("\nQuickMart Traders ");
            Console.WriteLine("1. Create New Transaction (Enter Purchase & Selling Details)");
            Console.WriteLine("2. View Last Transaction");
            Console.WriteLine("3. Calculate Profit/Loss (Recompute & Print)");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your option: ");

            string choice = Console.ReadLine()!;

            switch (choice)
            {
                case "1":
                    TransactionService.CreateNewTransaction();
                    break;
                case "2":
                    TransactionService.ViewLastTransaction();
                    break;
                case "3":
                    TransactionService.RecalculateProfitLoss();
                    break;
                case "4":
                    Console.WriteLine("\nThank you. Application closed normally.");
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid option. Please select between 1 and 4.");
                    break;
            }
        }
    }
}





