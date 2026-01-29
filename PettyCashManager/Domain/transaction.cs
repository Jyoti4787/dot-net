namespace PettyCashManager.Domain
{
    // Transaction is an abstract base class for all money movements
    // Examples: Expense, Reimbursement
    public abstract class Transaction
    {
        // Unique identifier for each transaction
        public Guid Id{ get; }=Guid.NewGuid();

        // Amount involved in the transaction
        // Protected setter allows child classes to control changes
        public decimal Amount{get; protected set; }

        //date of the transaction
        public DateTime Date{get; protected set; }

        //reason for the transaction
        public string Narration{get; protected set; }

        //Status of transaction: Pending, Approved, Rejected
        public string Status{get; protected set; }="Pending";

        //name of the user created the transaction
        public string CreatedBy{get; protected set; }

        //Protected constructor ensures only derived classes can create transactions 
        protected Transaction(decimal amount, DateTime date, string narration, string createdBy)
        {
            Amount = amount;
            Date = date;
            Narration = narration;
            CreatedBy = createdBy;
        }

        // Every transaction must support approval
        public abstract void Approve(string approver);

        // Every transaction must support rejection
        public abstract void Reject(string approver);
    }
}

//Transaction is an abstract base class representing any financial movement. 
//I used abstraction to capture common properties like amount, date, and status, 
//and polymorphism to enforce approval behavior in derived classes like Expense and Reimbursement.