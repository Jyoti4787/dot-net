using System;
using System.Collections.Generic;

namespace PettyCashManager.Infrastructure
{
    // ReportBuilder<T> is a generic helper to generate reports
    // It converts any collection of data into formatted text lines
    public class ReportBuilder<T>
    {
        // Builds a report by applying a formatter function to each item
        public IEnumerable<string> Build(
            IEnumerable<T> data,
            Func<T, string> formatter)
        {
            // Loop through each item in the collection
            foreach (var item in data)
            {
                // Convert item into a formatted string line
                yield return formatter(item);
            }
        }
    }
}
