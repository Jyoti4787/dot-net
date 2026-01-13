using System;
using System.Collections.Generic;
using System.Linq;

namespace UltraEnterpriseSDLC
{
    // Core SDLC orchestration engine
    public class EnterpriseSDLCEngine
    {
        // Stores business requirements
        private List<Requirement> _requirements;

        // WorkItem lookup by ID
        private Dictionary<int, WorkItem> _workItemRegistry;

        //SDLC stage board
        private SortedDictionary<SDLCStage, List<WorkItem>> _stageBoard;

        //FIFO execution queue
        private Queue<WorkItem> _executionQueue;

        //LIFO rollback history
        private Stack<BuildSnapshot> _rollbackStack;

        //unique taste suites
        private HashSet<string> _uniqueTestSuites;

        //immutable audit ledger
        private LinkedList<AuditLog> _auditLedger;

        //sorted release quality scoreboard
        private SortedList<double, QualityMetric> _releaseScoreBoard;

        private int _requirementCounter;
        private int _workItemCounter;

        // Constructor initializes all structures
        public EnterpriseSDLCEngine(){
            _requirements=new List<Requirement>();
            _workItemRegistry=new Dictionary<int, WorkItem>();
            _stageBoard=new SortedDictionary<SDLCStage, List<WorkItem>>();

            foreach (SDLCStage stage in Enum.GetValues(typeof(SDLCStage)))_stageBoard[stage]=new List<WorkItem>();

            _executionQueue= new Queue<WorkItem>();
            _rollbackStack= new Stack<BuildSnapshot>();
            _uniqueTestSuites= new HashSet<string>();
            _auditLedger= new LinkedList<AuditLog>();
            _releaseScoreBoard= new SortedList<double, QualityMetric>();
        }
        public void AddRequirement(string title, RiskLevel level)
        {
            var req = new Requirement(_requirementCounter++, title, level);
            _requirements.Add(req);
            _auditLedger.AddLast(new AuditLog($"Requirement added: {title} ({level})"));
        }

        public WorkItem CreateWorkItem(string name, SDLCStage stage)
        {
            var item = new WorkItem(_workItemCounter++, name, stage);
            _workItemRegistry[item.Id] = item;
            _stageBoard[stage].Add(item);
            _auditLedger.AddLast(new AuditLog($"WorkItem created: {name} at stage {stage}"));
            return item;
        }

        public void AddDependency(int workItemId, int dependsOnId)
        {
            if (_workItemRegistry.ContainsKey(workItemId) &&
                _workItemRegistry.ContainsKey(dependsOnId))
            {
                _workItemRegistry[workItemId].DependencyIds.Add(dependsOnId);
                _auditLedger.AddLast(
                    new AuditLog($"Dependency added: {workItemId} depends on {dependsOnId}")
                );
            }
        }

        public void PlanStage(SDLCStage stage)
        {
            var eligible =
                _stageBoard[stage]
                .Where(w =>
                    w.DependencyIds.All(d =>
                        _workItemRegistry[d].Stage > stage))
                .ToList();

            foreach (var item in eligible)
                _executionQueue.Enqueue(item);

            _auditLedger.AddLast(new AuditLog($"Stage planned: {stage}"));
        }

        public void ExecuteNext()
        {
            if (_executionQueue.Count == 0) return;

            var item = _executionQueue.Dequeue();
            var oldStage = item.Stage;

            item.Stage = (SDLCStage)((int)item.Stage + 1);
            _stageBoard[oldStage].Remove(item);
            _stageBoard[item.Stage].Add(item);

            _auditLedger.AddLast(
                new AuditLog($"WorkItem {item.Id}: {oldStage} → {item.Stage}")
            );
        }

        public void RegisterTestSuite(string suiteId)
        {
            _uniqueTestSuites.Add(suiteId);
            _auditLedger.AddLast(new AuditLog($"Test suite registered: {suiteId}"));
        }

        public void DeployRelease(string version)
        {
            _rollbackStack.Push(new BuildSnapshot(version));
            _auditLedger.AddLast(new AuditLog($"Release deployed: {version}"));
        }

        public void RollbackRelease()
        {
            if (_rollbackStack.Count == 0) return;

            var snap = _rollbackStack.Pop();
            _auditLedger.AddLast(new AuditLog($"Rollback to version {snap.Version}"));
        }

        public void RecordQualityMetric(string metricName, double score)
        {
            if (!_releaseScoreBoard.ContainsKey(score))
                _releaseScoreBoard.Add(score, new QualityMetric(metricName, score));
        }

        public void PrintAuditLedger()
        {
            Console.WriteLine("\n--- AUDIT LEDGER ---");
            foreach (var log in _auditLedger)
                Console.WriteLine($"{log.Time} | {log.Action}");
        }

        public void PrintReleaseScoreboard()
        {
            Console.WriteLine("\n--- RELEASE SCOREBOARD ---");
            foreach (var entry in _releaseScoreBoard.Reverse())
                Console.WriteLine($"{entry.Value.Name} : {entry.Key:F2}");
        }

    }
}