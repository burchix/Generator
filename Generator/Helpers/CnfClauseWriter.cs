using System.Collections.Generic;
using System.IO;

namespace Generator.Helpers
{
    public class CnfClauseWriter
    {
        public bool WriteProblemLine(StreamWriter file, int noOfClauses, int noOfVariables)
        {
            var problemLine = $"p cnf {noOfVariables} {noOfClauses}";
            file.WriteLine(problemLine);
            return true;
        }

        public bool WriteClause(StreamWriter file, List<int> clause)
        {
            var line = string.Join(" ", clause) + " 0";
            file.WriteLine(line);
            return true;
        }
    }
}
