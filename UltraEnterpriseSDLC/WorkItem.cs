using System.Collections.Generic;
namespace UltraEnterpriseSDLC
{
    // CLASS: WorkItem
    // Represents a unit of work inside SDLC
    // such as feature, bug, or task.
    public class WorkItem
    {
        //unique identifier
        public int Id{get; }

        //descriptive name of work item
        public string Name{get; }

        // Current SDLC stage
        // This is writable because work progresses
        public SDLCStage Stage{get; set; }

        // Dependency IDs
        // HashSet automatically prevents duplicates
        public HashSet<int> DependencyIds{get; }

        // Constructor
        // Initializes work item and prepares
        // empty dependency collection.

        public WorkItem(int id, string name, SDLCStage stage)
        {
            Id=id;
            Name=name;
            Stage=stage;
            DependencyIds=new HashSet<int>();
        }

    }
}