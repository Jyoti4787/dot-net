namespace UltraEnterpriseSDLC
{
    // CLASS: QualityMetric
    // Represents quality score of a release.
    // Used for ranking deployments.
    public class QualityMetric
    {
        // Metric name (e.g., Code Coverage)
        public string Name{get; }

        //numerical quality score
        public double Score{get; }

        //constructor
        public QualityMetric(string name, double score)
        {
            Name=name;
            Score=score;
        }
    }
}