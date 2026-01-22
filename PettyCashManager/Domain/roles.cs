// Person	       What they can do
// Employee	       Request expense
// Manager	       Approve / Reject
// Accountant	   Add money
// Auditor	       Check logs
//role is creted to control actions.

namespace PettyCashManager.Domain
{
    // Role defines WHAT a user is allowed to do in the system
    // Enum is used to restrict users to valid roles only

    public enum Role
    {
        // Can create expense requests
        Requester,

        // Can approve or reject expenses
        Approver,

        // Can add money (reimbursement / top-up)
        Accountant,

        // Can view audit logs for compliance
        Auditor

    }
}

// modeled user responsibilities using a Role enum to clearly separate permissions like requesting, approving, accounting, and auditing.
// This prevents unauthorized actions and keeps the business rules explicit.