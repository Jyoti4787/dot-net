namespace PettyCashManager.Domain
{
    // User is a base (abstract) class representing any person using the system
    // We never create User directly, only specific role-based users
    public abstract class User
    {
        // Name of the user (used for audit and tracking)
        public string Name{ get; } 

        // Role of the user (Requester, Approver, Accountant, Auditor)
        public Role Role{ get; }

        // Protected constructor ensures only derived classes can create users
        protected User(string Name,Role role)
        {
            Name=name;
            Role=role;
        }

    }
}

//designed User as an abstract base class because a generic user has no behavior by itself.
// Only role-specific users like Requester or Approver make sense. 
//This enforces role-based access and clean OOP design.