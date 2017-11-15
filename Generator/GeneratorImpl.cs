using Generator.Interafces;
using Generator.Models;
using System;
using System.Collections.Generic;
using Troschuetz.Random.Generators;

namespace Generator
{
    class GeneratorImpl : IGeneratorImpl
    {
        private AbstractGenerator _generator;
        private GeneratorTypeEnum _generatorType;

        public GeneratorImpl(GeneratorTypeEnum generatorType)
        {
            _generatorType = generatorType;
        } 

        public Dimacs generate()
        {
            Dimacs dimacs = new Dimacs();
            Random rng = new Random();
            dimacs.NoOfVariables = rng.Next();
            dimacs.NoOfClauses = rng.Next();
            dimacs.Clauses = GenerateClauses(dimacs.NoOfVariables, dimacs.NoOfClauses);
            return dimacs;
        }

        public Dimacs generate(int noOfVariables, int maxLength)
        {
            Dimacs dimacs = new Dimacs();
            Random rng = new Random();
            dimacs.NoOfVariables = noOfVariables;
            dimacs.NoOfClauses = rng.Next(500000);
            dimacs.Clauses = GenerateClauses(dimacs.NoOfVariables, dimacs.NoOfClauses, maxLength);
            return dimacs;
        }

        List<List<int>> GenerateClauses(int noOfVariables, int noOfClauses, int maxLengthOfClause = 0)
        {
            var clauses = new List<List<int>>();
            var rng = getGenerator(_generatorType);
            for(int i = 0; i < noOfClauses; i++)
            {
                var clause = new List<int>();
                var clauseLength = maxLengthOfClause <= 0 ? rng.Next(1, 100) : rng.Next(1, maxLengthOfClause + 1);
                for (int j = 0; j < clauseLength; j ++)
                {
                    var variable = rng.Next(1, noOfVariables + 1);
                    clause.Add(variable);
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
    }
}
