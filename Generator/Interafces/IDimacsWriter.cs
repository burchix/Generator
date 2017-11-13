using Generator.Models;

namespace Generator.Interafces
{
    interface IDimacsWriter
    {
        bool CreateDimacsFile(Dimacs dimacs, string fileName);
    }
}
