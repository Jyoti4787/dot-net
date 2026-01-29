using System;
using System.Collections.Generic;
using System.Linq;
using PettyCashManager.Domain;
using PettyCashManager.Infrastructure;

namespace PettyCashManager.Services
{
    // AuditService provides read-only access to audit logs
    // Used mainly by auditors and compliance checks
    public class AuditService
    {
        private readonly IRepository<AuditLogEntry> _auditRepo;

        // Constructor receives audit repository
        public AuditService(IRepository<AuditLogEntry> auditRepo)
        {
            _auditRepo = auditRepo;
        }

        // Returns all audit log entries
        public IEnumerable<AuditLogEntry> GetAll()
        {
            return _auditRepo.GetAll();
        }

        // Returns audit logs performed by a specific user
        public IEnumerable<AuditLogEntry> GetByUser(string user)
        {
            return _auditRepo.GetAll()
                .Where(a => a.User == user);
        }

        // Returns audit logs within a specific date range
        public IEnumerable<AuditLogEntry> GetByDateRange(
            DateTime from,
            DateTime to)
        {
            return _auditRepo.GetAll()
                .Where(a => a.Timestamp >= from && a.Timestamp <= to);
        }

        // Returns audit logs filtered by action keyword
        public IEnumerable<AuditLogEntry> GetByAction(string action)
        {
            return _auditRepo.GetAll()
                .Where(a => a.Action.Contains(action));
        }
    }
}
