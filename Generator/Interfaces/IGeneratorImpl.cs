using Generator.Models;

namespace Generator.Interfaces
{
    interface IGeneratorImpl
    {
        Dimacs generate(int noOfVariables, int noOfClauses, int maxLengthOfClause);
    }
}
