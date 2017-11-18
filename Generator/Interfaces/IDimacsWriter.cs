using Generator.Models;

namespace Generator.Interfaces
{
    interface IDimacsWriter
    {
        bool CreateDimacsFile(Dimacs dimacs, string fileName);
    }
}
