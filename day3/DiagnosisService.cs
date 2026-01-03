namespace Project2.Services
{
    class DiagnosisService
    {
        public void Evaluate(
            in int age,
            ref string condition,
            out string risk,
            int bp,
            int sugar,
            int cholesterol)
        {
            if (bp > 140 || sugar > 120 || cholesterol > 200)
            {
                condition = "Critical";
                risk = "High";
            }
            else
            {
                condition = "Stable";
                risk = "Low";
            }
        }
    }
}
