using System.Collections.Generic;

namespace Generator.Models
{
    class GenerationModel
    {
        public int NoOfVariables { get; set; }
        public string FileName { get; set; }
        public GeneratorTypeEnum GeneratorType { get; set; }
        public int NoOfRepetitions { get; set; }
        public LengthOfClauseTypeEnum LengthOfClauseType { get; set; }
        public int LengthOfClauseValue { get; set; }
        public NoOfClausesTypeEnum NoOfClausesType { get; set; }
        public int NoOfClausesValue { get; set; }
        public double NegationPropability { get; set; }
    }
}
