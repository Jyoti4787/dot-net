using System;
using System.Linq;
using PettyCashManager.Domain;
using PettyCashManager.Infrastructure;
using PettyCashManager.Services;

class Program
{
    static void Main()
    {
        // 1. Create fund
        var fund = new PettyCashFund("Office Petty Cash", 5000);

        // 2. Create repositories
        var transactionRepo = new InMemoryRepository<Transaction>();
        var auditRepo = new InMemoryRepository<AuditLogEntry>();

        // 3. Create services
        var fundService = new FundService(fund, transactionRepo, auditRepo);
        var approvalService = new ApprovalWorkflowService(fund, auditRepo);
        var auditService = new AuditService(auditRepo);

        // 4. Menu loop
        while (true)
        {
            Console.WriteLine("\n--- PETTY CASH MANAGER ---");
            Console.WriteLine("1. Add Expense");
            Console.WriteLine("2. Approve Expense");
            Console.WriteLine("3. Add Reimbursement");
            Console.WriteLine("4. View Balance");
            Console.WriteLine("5. View Transactions");
            Console.WriteLine("6. View Audit Logs");
            Console.WriteLine("7. Exit");

            Console.Write("Choose option: ");
            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    // Add Expense
                    Console.Write("Amount: ");
                    var amount = decimal.Parse(Console.ReadLine());

                    Console.Write("Voucher No: ");
                    var voucher = Console.ReadLine();

                    var result = fundService.AddExpense(
                        amount,
                        Category.Stationery,
                        voucher,
                        DateTime.Today,
                        "Office expense",
                        "Jyoti");

                    Console.WriteLine(result.Message);
                    break;

                case "2":
                    // Approve first pending expense
                    var expense = transactionRepo.GetAll()
                        .OfType<ExpenseTransaction>()
                        .FirstOrDefault(e => e.Status == "Pending");

                    if (expense == null)
                    {
                        Console.WriteLine("No pending expenses");
                        break;
                    }

                    var approveResult = approvalService.ApproveExpense(
                        expense,
                        "Ujjwal",
                        Role.Approver);

                    Console.WriteLine(approveResult.Message);
                    break;

                case "3":
                    // Add Reimbursement
                    Console.Write("Amount: ");
                    var topup = decimal.Parse(Console.ReadLine());

                    var reimbResult = fundService.AddReimbursement(
                        topup,
                        "REF001",
                        DateTime.Today,
                        "Fund top-up",
                        "Accountant");

                    Console.WriteLine(reimbResult.Message);
                    break;

                case "4":
                    // View Balance
                    Console.WriteLine($"Current Balance: ₹{fund.Balance}");
                    break;

                case "5":
                    // View Transactions
                    foreach (var t in transactionRepo.GetAll())
                    {
                        Console.WriteLine(
                            $"{t.Date:d} | {t.Amount} | {t.Status} | {t.Narration}");
                    }
                    break;

                case "6":
                    // View Audit Logs
                    foreach (var log in auditService.GetAll())
                    {
                        Console.WriteLine(
                            $"{log.Timestamp} | {log.User} | {log.Action} | {log.Details}");
                    }
                    break;

                case "7":
                    return;

                default:
                    Console.WriteLine("Invalid option");
                    break;
            }
        }
    }
}
