using Generator.Interfaces;
using System;
using Troschuetz.Random;

namespace Generator.Models
{
    public class DiscreteDistributionWrapper : IDiscreteDistributionWrapper
    {
        private IDiscreteDistribution _distribution;

        public DiscreteDistributionWrapper(IDiscreteDistribution distribution)
        {
            _distribution = distribution;
        }

        public int NextRandom(int minValue, int maxValue)
        {
            var oldMax = _distribution.Maximum > Double.MaxValue / 2
                ? Double.MaxValue / 2
                : _distribution.Maximum;
            var oldMin = _distribution.Minimum > Double.MinValue / 2
                ? Double.MinValue / 2
                : _distribution.Minimum;
            var originalResult = _distribution.Next();
            var result = (originalResult - oldMin) / (oldMax - oldMin) * (maxValue - minValue) + minValue;
            return (int)result;
        }
    }
}
