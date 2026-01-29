namespace PettyCashManager.Domain
{
    // ReimbursementTransaction represents money added to the petty cash fund
    // Example: fund top-up by accountant
    public class ReimbursementTransaction : Transaction
    {
        // Reference number for tracking reimbursement
        public string ReferenceNumber { get; }

        // Constructor creates an auto-approved reimbursement transaction
        public ReimbursementTransaction(
            decimal amount,
            string referenceNumber,
            DateTime date,
            string narration,
            string createdBy)
            : base(amount, date, narration, createdBy)
        {
            ReferenceNumber = referenceNumber;

            // Reimbursements do not require approval
            Status = "Approved";
        }

        // Approval is not applicable for reimbursement
        public override void Approve(string approver)
        {
            // No action needed
        }

        // Rejection is not applicable for reimbursement
        public override void Reject(string approver)
        {
            // No action needed
        }
    }
}
