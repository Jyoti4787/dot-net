using System;
namespace UltraEnterpriseSDLC
{
    // CLASS: BuildSnapshot
    // Represents a deployed build.
    // Used for rollback operations.
    public class BuildSnapshot
    {
        //release version 
        public string Version{get; set; }

        //deployment time
        public DateTime Timestamp{get; set; }

        // Constructor
        // Captures version and system time at deployment moment.
        public BuildSnapshot(string version)
        {
            Version=version;
            Timestamp=DateTime.Now;
        }

    }
}