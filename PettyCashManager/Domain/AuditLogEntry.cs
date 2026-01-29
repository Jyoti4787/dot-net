namespace PettyCashManager.Domain
{
    // AuditLogEntry represents an immutable audit record
    // Used for tracking who did what and when
    public class AuditLogEntry
    {
        // Time when the action occurred
        public DateTime Timestamp { get; } = DateTime.Now;

        // User who performed the action
        public string User { get; }

        // Action performed (Create, Approve, Reject, etc.)
        public string Action { get; }

        // Additional details about the action
        public string Details { get; }

        // Constructor sets all required audit information
        public AuditLogEntry(string user, string action, string details)
        {
            User = user;
            Action = action;
            Details = details;
        }
    }
}
