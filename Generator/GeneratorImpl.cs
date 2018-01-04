using Generator.Helpers;
using Generator.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
        private CnfClauseWriter _clauseWriter;

        public GeneratorImpl(GenerationModel generationModel)
        {
            _generationModel = generationModel;
            _generator = GeneratorResolver.getGenerator(generationModel.GeneratorType);
            _clauseWriter = new CnfClauseWriter();
        }

        public int generate()
        {
            var successCount = 0;
            for (int i = 0; i < _generationModel.NoOfRepetitions; i++)
            {
                var randomClauseNumber = _generationModel.NoOfClausesType == NoOfClausesTypeEnum.Max;
                successCount += GenerateFormula(_generationModel.FileName + $".{i}.cnf", _generationModel.NoOfClausesValue, randomClauseNumber);
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
                    _clauseWriter.WriteProblemLine(file, clauseNumber, _generationModel.NoOfVariables);
                    for (int i = 0; i < clauseNumber; i++)
                    {
                        var randomLength = _generationModel.LengthOfClauseType != LengthOfClauseTypeEnum.Fixed;
                        var clause = GenerateClause(_generationModel.NoOfVariables, _generationModel.LengthOfClauseValue, randomLength);
                        _clauseWriter.WriteClause(file, clause);
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
            for (int i = 0, j = 0; i < clauseLength; i++)
            {
                var factor = _generator.NextDouble() > _generationModel.NegationPropability ? 1 : -1;
                var variable = _generator.Next(1, noOfVariables + 1) * factor;
                if (clause.Any(c => c == variable) && j < noOfVariables * 1000)
                {
                    i--;
                    j++;
                }
                else
                {
                    clause.Add(variable);
                    j = 0;
                }             
            }
            return clause;
        }
    }
}
