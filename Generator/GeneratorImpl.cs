using Generator.Models;
using System;
using System.Collections.Generic;
using System.IO;
using Troschuetz.Random.Generators;

namespace Generator
{
    interface IGeneratorImpl
    {
        int generate();
    }

    class GeneratorImpl : IGeneratorImpl
    {
        private AbstractGenerator _generator;
        private GenerationModel _generationModel;

        private const double negationPropability = 0.5;

        public GeneratorImpl(GenerationModel generationModel)
        {
            _generationModel = generationModel;
            _generator = getGenerator(generationModel.GeneratorType);
        }

        public int generate()
        {
            var successCount = 0;
            for (int i = 0; i < _generationModel.NoOfRepetitions; i++)
            {
                var randomClauseNumber = _generationModel.NoOfClausesType == NoOfClausesTypeEnum.Max;
                successCount += GenerateFormula(_generationModel.FileName + $".{i}.txt", _generationModel.NoOfClausesValue, randomClauseNumber);
            }
            return successCount;
        }

        private int GenerateFormula(string fileName, int clauseNumberIndicator, bool randomClauseNumber = false)
        {
            using (StreamWriter file = new StreamWriter(fileName))
            {
                try
                {
                    var clauseNumber = randomClauseNumber ? _generator.Next(1, clauseNumberIndicator + 1) : clauseNumberIndicator;
                    WriteFirstLine(file, clauseNumber, _generationModel.NoOfVariables);
                    for (int i = 0; i < clauseNumber; i++)
                    {
                        var randomLength = _generationModel.LengthOfClauseType != LengthOfClauseTypeEnum.Fixed;
                        var clause = GenerateClause(_generationModel.NoOfVariables, _generationModel.LengthOfClauseValue, randomLength);
                        WriteClause(file, clause);
                    }
                    return 1;
                }
                catch (Exception e)
                {
                    return 0;
                }
            }
        }

        private List<int> GenerateClause(int noOfVariables, int clauseLengthIndicator, bool randomClauseLength = false)
        {
            var clauseLength = randomClauseLength ? _generator.Next(1, clauseLengthIndicator + 1) : clauseLengthIndicator;
            var clause = new List<int>();
            for (int j = 0; j < clauseLength; j++)
            {
                var factor = _generator.NextDouble() > negationPropability ? 1 : -1;
                var variable = _generator.Next(1, noOfVariables + 1);
                clause.Add(variable * factor);
            }
            return clause;
        }

        private bool WriteFirstLine(StreamWriter file, int noOfClauses, int noOfVariables)
        {
            var problemLine = $"p cnf {noOfVariables} {noOfClauses}";
            file.WriteLine(problemLine);
            return true;
        }

        private bool WriteClause(StreamWriter file, List<int> clause)
        {
            var line = string.Join(" ", clause) + " 0";
            file.WriteLine(line);
            return true;
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
