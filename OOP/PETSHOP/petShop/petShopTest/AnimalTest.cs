using petShop;

namespace petShopTest
{
    [TestClass]
    public class AnimalTest
    {
        [TestMethod]
        public void Construct()
        {
            Species species = Tarantula.Instance();
            Animal a = new Animal("byTN", "blue", 50, "young", species);

            Assert.IsNotNull(a);
            Assert.AreEqual(a.speciesName, "tarantula");
            Assert.AreEqual(a.age, "young");
        }

        [TestMethod]
        public void GetMethods()
        {
            Species species = Tarantula.Instance();
            Animal a = new Animal("byTN", "blue", 50, "young", species);

            Assert.AreEqual(a.getId(), "byTN");
            Assert.AreEqual(a.getColour(), "blue");

            Assert.AreEqual(a.realValue(), 150);
        }
    }
}