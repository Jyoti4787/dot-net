// Category is a business concept

// Domain layer holds business concepts


namespace PettyCashManager.Domain
{
    // Category represents FIXED types of expenses
    // Enum is used to avoid invalid or random category values
    public enum Category
    {
        // Office stationery like pens, papers, files
        Stationery,

        // Travel expenses like auto, bus, cab
        Travel,

        // Tea, coffee, snacks
        Refreshments,

        // Courier or postal charges
        Courier
    }
}

//I used an enum for expense categories because categories are fixed business values. 
//Using enum ensures type safety, avoids invalid inputs, and simplifies reporting.