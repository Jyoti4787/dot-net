using System;
using PettyCashManager.Domain;
using PettyCashManager.Infrastructure;

namespace PettyCashManager.Services
{
    // FundService handles all petty cash fund related business rules
    public class FundService
    {
        private readonly PettyCashFund _fund;
        private readonly IRepository<Transaction> _transactionRepo;
        private readonly IRepository<AuditLogEntry> _auditRepo;

        // Constructor receives dependencies (dependency injection)
        public FundService(
            PettyCashFund fund,
            IRepository<Transaction> transactionRepo,
            IRepository<AuditLogEntry> auditRepo)
        {
            _fund = fund;
            _transactionRepo = transactionRepo;
            _auditRepo = auditRepo;
        }

        // Creates a new expense transaction (Pending approval)
        public Result<ExpenseTransaction> AddExpense(
            decimal amount,
            Category category,
            string voucherNo,
            DateTime date,
            string narration,
            string createdBy)
        {
            // Validation rules
            if (amount <= 0)
                return Result<ExpenseTransaction>.Fail("Amount must be greater than zero");

            if (string.IsNullOrWhiteSpace(voucherNo))
                return Result<ExpenseTransaction>.Fail("Voucher number is required");

            // Create expense
            var expense = new ExpenseTransaction(
                amount, category, voucherNo, date, narration, createdBy);

            // Store transaction
            _transactionRepo.Add(expense);

            // Audit log
            _auditRepo.Add(new AuditLogEntry(
                createdBy,
                "Create Expense",
                $"Expense voucher {voucherNo} created"));

            return Result<ExpenseTransaction>.Ok(expense, "Expense created successfully");
        }

        // Adds money to the petty cash fund (Reimbursement / Top-up)
        public Result<ReimbursementTransaction> AddReimbursement(
            decimal amount,
            string referenceNo,
            DateTime date,
            string narration,
            string createdBy)
        {
            // Validation rule
            if (amount <= 0)
                return Result<ReimbursementTransaction>.Fail("Amount must be greater than zero");

            // Create reimbursement transaction
            var reimbursement = new ReimbursementTransaction(
                amount, referenceNo, date, narration, createdBy);

            // Increase fund balance immediately
            _fund.Increase(amount);

            // Store transaction
            _transactionRepo.Add(reimbursement);

            // Audit log
            _auditRepo.Add(new AuditLogEntry(
                createdBy,
                "Add Reimbursement",
                $"Reimbursement {referenceNo} added, Amount {amount}"));

            return Result<ReimbursementTransaction>.Ok(
                reimbursement, "Reimbursement added successfully");
        }
    }
}
