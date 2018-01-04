using Generator.Models;
using Troschuetz.Random.Generators;

namespace Generator.Helpers
{
    static class GeneratorResolver
    {
        public static AbstractGenerator getGenerator(GeneratorTypeEnum _generatorType)
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
