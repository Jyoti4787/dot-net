namespace PettyCashManager.Domain
{
    // ExpenseTransaction represents money spent from the petty cash fund
    // It is a specific type of Transaction
    public class ExpenseTransaction : Transaction
    {
        // Voucher number is mandatory proof for the expense
        public string VoucherNumber{get; }

        // Category of expense (Stationery, Travel, etc.)
        public Category Category{get; }

        // Stores who approved or rejected the expense
        public string ApprovedBy{get; private set; }

        // Constructor creates an expense transaction
        public ExpenseTransaction(
            decimal amount,
            Category category,
            string voucherNumber,
            DateTime date,
            string narration,
            string createdBy
        ):base(amount, date, narration, createdBy)
        {
            VoucherNumber=voucherNumber;
            Category=category;
        }

        // Approves the expense
        public override void Approve(string approver)
        {
            Status="Approved";
            ApprovedBy=approver;
        }

        // Rejects the expense
        public override void Reject(string approver)
        {
            Status="Rejected";
            ApprovedBy=approver;
        }
    }
}