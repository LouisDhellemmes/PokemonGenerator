using System.Linq;
using NUnit.Framework;
using PokeMonGénérator.Services;

namespace PokeMonGénérator.Test
{
    [TestFixture]
    public class NatureGeneratorService_GetByIdWould
    {
        NatureGeneratorService _natureGeneratorService;
        private static readonly string[] testList = { "Adamant", "Bashful", "Bold", "Brave", "Calm", "Careful", "Docile", "Gentle", "Hardy", "Hasty", "Impish", "Jolly", "Lax", "Lonely", "Mild", "Modest", "Naive", "Naughty", "Quiet ", "Quirky", "Rash", "Relaxed", "Sassy", "Serious", "Timid"};
        
        [SetUp]
        public void Setup()
        {
            _natureGeneratorService = new NatureGeneratorService();
        }

        [Test]
        [TestCase(0)]
        [TestCase(1)]
        public void TestGetById(int id)
        {
            string nature = _natureGeneratorService.GetById(id);
            Assert.IsNotNull(nature);
            Assert.AreEqual(testList[id],nature);
        }

        [TestCase]
        [TestCase]
        public void TestGetRandom()
        {
            string nature = _natureGeneratorService.GetRandom();
            Assert.IsNotNull(nature);
            Assert.IsTrue(testList.Contains(nature));
        }
    }
}
