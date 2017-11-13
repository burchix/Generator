using System.Collections.Generic;

namespace Generator.Models
{
    class Dimacs
    {
        public int NoOfVariables { get; set; }
        public int NoOfClauses { get; set; }
        public List<List<int>> Clauses { get; set; }
    }
}
