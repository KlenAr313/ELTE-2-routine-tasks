using petShop;
using System.Reflection.Metadata.Ecma335;

namespace petShopTest
{
    [TestClass]
    public class PatrnerTest
    {
        [TestMethod]
        public void Construct()
        {
            Species species = Tarantula.Instance();
            Animal a = new Animal("byTN", "blue", 50, "young", species);
            List<Animal> list = new List<Animal>();
            list.Add(a);
            Partner partner = new Partner("Tardis", list);

            Assert.IsNotNull(partner);
            Assert.AreEqual(partner.getName(), "Tardis");
            Assert.AreEqual(partner.animalCount(), 1);
        }

        [TestMethod]
        public void Sell()
        {
            Species species = Tarantula.Instance();
            Animal a = new Animal("byTN", "blue", 50, "young", species);
            List<Animal> list = new List<Animal>();
            list.Add(a);
            Partner partner = new Partner("Tardis", list);
            Animal b = partner.Sell("byTN");

            Assert.IsNotNull(b);
            Assert.AreEqual(a, b);
            Assert.AreEqual(partner.animalCount(), 0);
            Assert.AreEqual(b.getId(), "byTN");
        }

        [TestMethod]
        public void Buy() 
        {
            Species species = Tarantula.Instance();
            Animal a = new Animal("byTN", "blue", 50, "young", species);
            List<Animal> list = new List<Animal>();
            Partner partner = new Partner("Tardis", list);
            partner.Buy(a);

            Assert.IsNotNull(partner);
            Assert.AreEqual(partner.animalCount(), 1);
        }

        [TestMethod]
        public void SellError()
        {
            Species species = Tarantula.Instance();
            Animal a = new Animal("byTN", "blue", 50, "young", species);
            List<Animal> list = new List<Animal>();
            Partner partner = new Partner("Tardis", list);

            Assert.ThrowsException<Partner.PartnerUnableToSellAnimalException>(() => partner.Sell("byTN"));
        }

        [TestMethod]
        public void BuyError()
        {
            Species species = Tarantula.Instance();
            Animal a = new Animal("byTN", "blue", 50, "young", species);
            List<Animal> list = new List<Animal>();
            list.Add(a);
            Partner partner = new Partner("Tardis", list);

            Assert.ThrowsException<Partner.PartnerUnableToBuyAnimalException>(() => partner.Buy(a));
        }
    }
}