using Generator.Models;

namespace Generator.Interafces
{
    interface IGeneratorImpl
    {
        Dimacs generate();
        Dimacs generate(int noOfVariables, int maxLength);
    }
}
