namespace UltraEnterpriseSDLC
{
    // CLASS: Requirement
    // Sealed class ensures no inheritance.
    // Represents a business requirement coming from stakeholders.

    public sealed class Requirement
    {
        // Read-only ID
        // Uniquely identifies a requirement
        public int Id {get; }

        // Read-only title
        // Describes what the business wants
        public string Title{get; }


        // Read-only risk classification
        public RiskLevel Risk{get; }

         // Constructor
        // Assigns all incoming values to properties.
        // Once created, a requirement cannot change.
        public Requirement(int id, string title, RiskLevel risk)
        {
            Id=id;
            Title=title;
            Risk=risk;
        }
    }
}