namespace UltraEnterpriseSDLC
{
    // ENUM: SDLCStage
    // Represents the strict and ordered lifecycle  of a software work item.
    // The order of values defines how work progresses through the SDLC pipeline.

    public enum SDLCStage
    {
        Backlog,
        Requirement,
        Design,
        Development,
        CodeReview,
        Testing,
        UAT,
        Deployment,
        Maintenance
    }
}