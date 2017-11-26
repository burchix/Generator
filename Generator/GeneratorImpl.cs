using Generator.Interfaces;
using Generator.Models;
using System;
using System.Collections.Generic;
using Troschuetz.Random;
using Troschuetz.Random.Distributions.Continuous;
using Troschuetz.Random.Distributions.Discrete;
using Troschuetz.Random.Generators;

namespace Generator
{
    class GeneratorImpl : IGeneratorImpl
    {
        private AbstractGenerator _generator;
        private IUniversalDistribution _distribution;        

        public GeneratorImpl(GeneratorTypeEnum generatorType, ContinousDistributionEnum continousDistributionType, DiscreteDistributionEnum discreteDistributionType)
        {
            _generator = getGenerator(generatorType);
            _distribution = getDistribution(_generator, continousDistributionType, discreteDistributionType);
        }

        public Dimacs generate(int noOfVariables = 0, int noOfClauses = 0, int maxLengthOfClause = 100)
        {
            Dimacs dimacs = new Dimacs();
            Random rng = new Random();
            dimacs.NoOfVariables = noOfVariables > 0 ? noOfVariables : rng.Next(1, 50001);
            dimacs.NoOfClauses = noOfClauses > 0 ? noOfClauses : rng.Next(1, 750000);
            dimacs.Clauses = GenerateClauses(dimacs.NoOfVariables, dimacs.NoOfClauses, maxLengthOfClause);
            return dimacs;
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
                    var variable = _distribution.NextRandom(1, noOfVariables + 1);
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

        private IUniversalDistribution getDistribution(AbstractGenerator generator, ContinousDistributionEnum contiousDistributionType, DiscreteDistributionEnum discreteDistributionType)
        {
            return contiousDistributionType == ContinousDistributionEnum.Unknown 
                ? getDiscreteDistribution(generator, discreteDistributionType)
                : getContinousDistribution(generator, contiousDistributionType);
        }

        private IUniversalDistribution getContinousDistribution(AbstractGenerator generator, ContinousDistributionEnum distributionType)
        {
            IContinuousDistribution distribution;
            switch (distributionType)
            {
                case ContinousDistributionEnum.BetaDistribution:
                    distribution = new BetaDistribution(generator);
                    break;
                case ContinousDistributionEnum.ChiSquareDistribution:
                    distribution = new ChiSquareDistribution(generator);
                    break;
                case ContinousDistributionEnum.CauchyDistribution:
                    distribution = new CauchyDistribution(generator);
                    break;
                case ContinousDistributionEnum.ErlangDistribution:
                    distribution = new ErlangDistribution(generator);
                    break;
                case ContinousDistributionEnum.ExponentialDistribution:
                    distribution = new ExponentialDistribution(generator);
                    break;
                case ContinousDistributionEnum.FisherSnedecorDistribution:
                    distribution = new FisherSnedecorDistribution(generator);
                    break;
                case ContinousDistributionEnum.FisherTrippettDistribution:
                    distribution = new FisherTippettDistribution(generator);
                    break;
                case ContinousDistributionEnum.GammaDistribution:
                    distribution = new GammaDistribution(generator);
                    break;
                case ContinousDistributionEnum.LaplaceDistribution:
                    distribution = new LaplaceDistribution(generator);
                    break;
                case ContinousDistributionEnum.LogisticDistribution:
                    distribution = new LogisticDistribution(generator);
                    break;
                case ContinousDistributionEnum.LognormalDistribution:
                    distribution = new LognormalDistribution(generator);
                    break;
                case ContinousDistributionEnum.NormalDistribution:
                    distribution = new NormalDistribution(generator);
                    break;
                case ContinousDistributionEnum.ParetoDistribution:
                    distribution = new ParetoDistribution(generator);
                    break;
                case ContinousDistributionEnum.RayleighDistribution:
                    distribution = new RayleighDistribution(generator);
                    break;
                case ContinousDistributionEnum.StudentsTDistribution:
                    distribution = new StudentsTDistribution(generator);
                    break;
                case ContinousDistributionEnum.WeibullDistribution:
                    distribution = new WeibullDistribution(generator);
                    break;
                default:
                    distribution = new NormalDistribution(generator);
                    break;
                    
            }
            return new ContinousDistributionWrapper(distribution);
        }

        private IUniversalDistribution getDiscreteDistribution(AbstractGenerator generator, DiscreteDistributionEnum distributionType)
        {
            IDiscreteDistribution distribution;
            switch(distributionType)
            {
                case DiscreteDistributionEnum.BinomialDistribution:
                    distribution = new BernoulliDistribution(generator);
                    break;
                case DiscreteDistributionEnum.CategoricalDistribution:
                    distribution = new CategoricalDistribution(generator);
                    break;
                case DiscreteDistributionEnum.DiscreteUniformDistribution:
                    distribution = new DiscreteUniformDistribution(generator, 1, 50000);
                    break;
                case DiscreteDistributionEnum.GeometricDistribution:
                    distribution = new GeometricDistribution(generator);
                    break;
                case DiscreteDistributionEnum.PoissonDistribution:
                    distribution = new PoissonDistribution(generator);
                    break;
                default:
                    distribution = new DiscreteUniformDistribution(generator);
                    break;
                    
            }
            return new DiscreteDistributionWrapper(distribution);
        }
    }
}
