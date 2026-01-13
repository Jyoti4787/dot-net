namespace UltraEnterpriseSDLC
{
    // ENUM: RiskLevel
    // This enum represents how risky a business requirement is for the organization.
    
    // The order is important because higher values represent higher business impact.
 
    public enum RiskLevel
    {
        Low,        // Minimal business risk
        Medium,     // Moderate business impact
        High,       // High risk, needs attention
        Critical    // Mission-critical requirement
    }
}
