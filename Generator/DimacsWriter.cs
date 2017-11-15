using Generator.Interafces;
using Generator.Models;
using System.IO;
using System.Linq;

namespace Generator
{
    class DimacsWriter : IDimacsWriter
    {
        public bool CreateDimacsFile(Dimacs dimacs, string fileName)
        {
            using (var file = new StreamWriter(fileName))
            {
                var problemLine = $"p cnf {dimacs.NoOfVariables} {dimacs.NoOfClauses}";
                var lines = dimacs.Clauses.Select(c => string.Join(" ", c) + " 0");

                file.WriteLine(problemLine);                
                foreach (string line in lines)
                {
                    file.WriteLine(line);
                }
                return true;
            }
        }
    }
}
