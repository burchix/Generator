
using Generator.Interfaces;
using Generator.Models;
using System;
using System.Collections.Generic;
using System.IO;
using Troschuetz.Random.Generators;

namespace Generator
{
    class GeneratorImpl : IGeneratorImpl
    {
        private AbstractGenerator _generator;      

        public GeneratorImpl(GeneratorTypeEnum generatorType)
        {
            _generator = getGenerator(generatorType);
        }

        public Dimacs generate(int noOfVariables = 0, int noOfClauses = 0, int maxLengthOfClause = 100)
        {
            Dimacs dimacs = new Dimacs();
            Random rng = new Random();
            dimacs.NoOfVariables = noOfVariables > 0 ? noOfVariables : rng.Next(1, 50001);
            dimacs.NoOfClauses = noOfClauses > 0 ? noOfClauses : rng.Next(1, 750000);
            dimacs.Clauses = GenerateClauses(dimacs.NoOfVariables, dimacs.NoOfClauses, maxLengthOfClause);
            WriteFormula(dimacs, "filename");
            return dimacs;
        }

        private void WriteFormula(Dimacs dimacs, string fileName)
        {
            using (var file = new StreamWriter(fileName))
            {
                WrtiteFirstLine(file, dimacs.NoOfClauses, dimacs.NoOfVariables);
                dimacs.Clauses.ForEach(c =>
                {
                    WriteClause(file, c);
                });
            }
        }

        List<List<int>> GenerateClauses(int noOfVariables, int noOfClauses, int maxLengthOfClause)
        {
            var random = new Random();
            var clauses = new List<List<int>>();
            for(int i = 0; i < noOfClauses; i++)
            {
                var clause = new List<int>();
                var clauseLength = random.Next(1, maxLengthOfClause + 1);
                for (int j = 0; j < clauseLength; j ++)
                {
                    var factor = random.NextDouble() > 0.5 ? 1 : -1;
                    var variable = _generator.Next(1, noOfVariables + 1);
                    clause.Add(variable * factor);
                }
                clauses.Add(clause);
            }
            return clauses;
        }

        private AbstractGenerator getGenerator(GeneratorTypeEnum _generatorType)
        {
            switch (_generatorType)
            {               
                case GeneratorTypeEnum.Alf:
                    return new ALFGenerator();
                case GeneratorTypeEnum.Mt:
                    return new MT19937Generator();
                case GeneratorTypeEnum.XorShift:
                    return new XorShift128Generator();
                default:
                    return new StandardGenerator();
            }
        }

        public bool WrtiteFirstLine(StreamWriter file, int noOfClauses, int noOfVariables)
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
