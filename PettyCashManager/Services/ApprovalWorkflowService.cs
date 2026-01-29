using PettyCashManager.Domain;
using PettyCashManager.Infrastructure;

namespace PettyCashManager.Services
{
    // Handles approval and rejection of expense transactions
    public class ApprovalWorkflowService
    {
        private readonly PettyCashFund _fund;
        private readonly IRepository<AuditLogEntry> _auditRepo;

        // Constructor receives required dependencies
        public ApprovalWorkflowService(
            PettyCashFund fund,
            IRepository<AuditLogEntry> auditRepo)
        {
            _fund = fund;
            _auditRepo = auditRepo;
        }

        // Approves a pending expense transaction
        public Result<bool> ApproveExpense(
            ExpenseTransaction expense,
            string approverName,
            Role approverRole)
        {
            // Rule: Only approvers can approve
            if (approverRole != Role.Approver)
                return Result<bool>.Fail("Only approvers can approve expenses");

            // Rule: Requester cannot approve own expense
            if (expense.CreatedBy == approverName)
                return Result<bool>.Fail("Requester cannot approve own expense");

            // Rule: Expense must be pending
            if (expense.Status != "Pending")
                return Result<bool>.Fail("Expense already processed");

            // Rule: Fund must have sufficient balance
            if (_fund.Balance < expense.Amount)
                return Result<bool>.Fail("Insufficient fund balance");

            // Approve expense and reduce fund balance
            expense.Approve(approverName);
            _fund.Decrease(expense.Amount);

            // Audit log
            _auditRepo.Add(new AuditLogEntry(
                approverName,
                "Approve Expense",
                $"Expense voucher {expense.VoucherNumber} approved"));

            return Result<bool>.Ok(true, "Expense approved successfully");
        }

        // Rejects a pending expense transaction
        public Result<bool> RejectExpense(
            ExpenseTransaction expense,
            string approverName,
            Role approverRole)
        {
            // Rule: Only approvers can reject
            if (approverRole != Role.Approver)
                return Result<bool>.Fail("Only approvers can reject expenses");

            // Rule: Expense must be pending
            if (expense.Status != "Pending")
                return Result<bool>.Fail("Expense already processed");

            // Reject expense (no balance change)
            expense.Reject(approverName);

            // Audit log
            _auditRepo.Add(new AuditLogEntry(
                approverName,
                "Reject Expense",
                $"Expense voucher {expense.VoucherNumber} rejected"));

            return Result<bool>.Ok(true, "Expense rejected successfully");
        }
    }
}
