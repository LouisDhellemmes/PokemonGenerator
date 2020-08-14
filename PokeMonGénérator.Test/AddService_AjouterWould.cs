using NUnit.Framework;
using PokeMonGénérator.Services;



namespace PokeMonGénérator.Test
{
    [TestFixture]
    public class AddService_AjouterWould 
    {
        AddService _addService;

        [SetUp]
        public void Setup()
        {
            _addService = new AddService();
        }

        [Test]
        public void Test1()
        {
            var result = _addService.Ajouter(3, 7);
            Assert.AreEqual(10,result);
        }
    }
}