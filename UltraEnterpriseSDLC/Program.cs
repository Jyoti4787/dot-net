using UltraEnterpriseSDLC;
class Program
{
    static void Main()
    {
        var engine=new EnterpriseSDLCEngine();

        engine.AddRequirement("Single Sign-On", RiskLevel.High);
        engine.AddRequirement("Fraud Detection", RiskLevel.Critical);

        var design = engine.CreateWorkItem("SSO Design", SDLCStage.Design);
        var dev = engine.CreateWorkItem("SSO Development", SDLCStage.Development);
        var test = engine.CreateWorkItem("SSO Testing", SDLCStage.Testing);

        engine.AddDependency(dev.Id, design.Id);
        engine.AddDependency(test.Id, dev.Id);

        engine.RegisterTestSuite("SSO-Regression");
        engine.RegisterTestSuite("SSO-Security");

        engine.PlanStage(SDLCStage.Design);
        engine.ExecuteNext();
        engine.ExecuteNext();

        engine.DeployRelease("v3.4.1");

        engine.RecordQualityMetric("Code Coverage", 91.7);
        engine.RecordQualityMetric("Security Score", 97.3);

        engine.RollbackRelease();

        engine.PrintAuditLedger();
        engine.PrintReleaseScoreboard();
    }
}


