using System;
namespace UltraEnterpriseSDLC
{
    // CLASS: AuditLog
    // Immutable audit record.
    // Ensures traceability and compliance.
    public class AuditLog
    {
        //time when action occured
        public DateTime Time{get; }

        //description of action
        public string Action{get; }

        // Constructor
        // Automatically records time and action description.
        public AuditLog(string action)
        {
            Time=DateTime.Now;
            Action=action;
        }
    }
}