using FantasyNameGenerators;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FantasyNameGeneratorsTests
{
    [TestClass]
    public class ScientificCreatureNameGeneratorTest
    {
        [TestMethod]
        public void ScientificCreatureNameGeneratorTestShouldGenerateName()
        {
            var generator = new ScientificCreatureNameGenerator();
            string name1 = generator.Generate();
            Assert.IsFalse(string.IsNullOrEmpty(name1));
            string name2 = generator.Generate();
            Assert.IsFalse(string.IsNullOrEmpty(name2));
            Assert.AreNotEqual(name1, name2);
        }
    }
}