using Generator.Interafces;
using Generator.Models;
using System;
using System.Collections.Generic;
using Troschuetz.Random.Distributions;
using Troschuetz.Random.Distributions.Continuous;
using Troschuetz.Random.Distributions.Discrete;
using Troschuetz.Random.Generators;

namespace Generator
{
    class GeneratorImpl : IGeneratorImpl
    {
        private AbstractGenerator _generator;
        private AbstractDistribution _distribution;        

        public GeneratorImpl(GeneratorTypeEnum generatorType, ContinousDistributionEnum continousDistributionType, DiscreteDistributionEnum discreteDistributionType)
        {
            _generator = getGenerator(generatorType);
            _distribution = getDistribution(_generator, continousDistributionType, discreteDistributionType);
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
            for(int i = 0; i < noOfClauses; i++)
            {
                var clause = new List<int>();
                var clauseLength = maxLengthOfClause <= 0 ? -_generator.Next(1, 100) : _generator.Next(1, maxLengthOfClause + 1);
                for (int j = 0; j < clauseLength; j ++)
                {
                    var variable = _generator.Next(1, noOfVariables + 1);
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

        private AbstractDistribution getDistribution(AbstractGenerator generator, ContinousDistributionEnum contiousDistributionType, DiscreteDistributionEnum discreteDistributionType)
        {
            return contiousDistributionType == ContinousDistributionEnum.Unknown 
                ? getDiscreteDistribution(generator, discreteDistributionType) 
                : getContinousDistribution(generator, contiousDistributionType);
        }

        private AbstractDistribution getContinousDistribution(AbstractGenerator generator, ContinousDistributionEnum distributionType)
        {
            switch (distributionType)
            {
                case ContinousDistributionEnum.BetaDistribution:
                    return new BetaDistribution(generator);
                case ContinousDistributionEnum.BetaPrimeDistribution:
                    return new BetaPrimeDistribution(generator);
                case ContinousDistributionEnum.ChiDistribution:
                    return new ChiDistribution(generator);
                case ContinousDistributionEnum.ChiSquareDistribution:
                    return new ChiSquareDistribution(generator);

                    
            }
            throw new NotImplementedException();
        }

        private AbstractDistribution getDiscreteDistribution(AbstractGenerator generator, DiscreteDistributionEnum distributionType)
        {
            switch(distributionType)
            {
                case DiscreteDistributionEnum.BernoulliDistribution:
                    return new BernoulliDistribution(generator);
                    
            }
            throw new NotImplementedException();
        }
    }
}
