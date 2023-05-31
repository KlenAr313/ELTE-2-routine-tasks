using petShop;
using System.Reflection.Metadata.Ecma335;

namespace petShopTest
{
    [TestClass]
    public class ShopTest
    {
        [TestMethod]
        public void Construct()
        {
            Species species = Tarantula.Instance();
            Animal a = new Animal("byTN", "blue", 50, "young", species);
            List<Animal> list = new List<Animal>(); 
            Partner partner = new Partner("Tardis", list);
            List<Partner> partners = new List<Partner>();
            partners.Add(partner);
            List<Invoice> invoices = new List<Invoice>();
            List<Animal> animals = new List<Animal>();
            animals.Add(a);
            Shop shop = new Shop("Eidos", invoices, partners, animals);

            Assert.IsNotNull(shop);
            Assert.AreEqual(shop.Name, "Eidos");
            Assert.AreEqual(shop.invoiceCount(), 0);
            Assert.AreEqual(shop.animalCount(), 1);
            Assert.AreEqual(shop.partnerCount(), 1);
        }

        [TestMethod]
        public void Sell()
        {
            Species species = Tarantula.Instance();
            Animal a = new Animal("byTN", "blue", 50, "young", species);
            List<Animal> list = new List<Animal>();
            Partner partner = new Partner("Tardis", list);
            List<Partner> partners = new List<Partner>();
            partners.Add(partner);
            List<Invoice> invoices = new List<Invoice>();
            List<Animal> animals = new List<Animal>();
            animals.Add(a);
            Shop shop = new Shop("Eidos", invoices, partners, animals);
            shop.Sell("byTN", "Tardis");

            Assert.IsNotNull(shop);
            Assert.AreEqual(shop.invoiceCount(), 1);
            Assert.AreEqual(shop.animalCount(), 0);
            Assert.AreEqual(shop.partnerCount(), 1);
            Assert.AreEqual(partner.animalCount(), 1);

        }

        [TestMethod]
        public void Buy()
        {
            Species species = Tarantula.Instance();
            Animal a = new Animal("byTN", "blue", 50, "young", species);
            List<Animal> animals = new List<Animal>();
            animals.Add(a);
            Partner partner = new Partner("Tardis", animals);
            List<Partner> partners = new List<Partner>();
            partners.Add(partner);
            List<Invoice> invoices = new List<Invoice>();
            List<Animal> list = new List<Animal>();
            Shop shop = new Shop("Eidos", invoices, partners, list);
            shop.Buy("byTN", "Tardis");

            Assert.IsNotNull(shop);
            Assert.AreEqual(shop.invoiceCount(), 1);
            Assert.AreEqual(shop.animalCount(), 1);
            Assert.AreEqual(shop.partnerCount(), 1);
            Assert.AreEqual(partner.animalCount(), 0);

        }

        [TestMethod]
        public void SellError()
        {
            Species species = Tarantula.Instance();
            Animal a = new Animal("byTN", "blue", 50, "young", species);
            List<Animal> animals = new List<Animal>();
            animals.Add(a);
            Partner partner = new Partner("Tardis", animals);
            List<Partner> partners = new List<Partner>();
            partners.Add(partner);
            List<Invoice> invoices = new List<Invoice>();
            List<Animal> list = new List<Animal>();
            Shop shop = new Shop("Eidos", invoices, partners, list);
            
            Assert.IsNotNull(shop);
            Assert.ThrowsException<Shop.ShopUnableToSellAnimalException>(() => shop.Sell("byTN", "Tardis"));

            Assert.AreEqual(shop.invoiceCount(), 0);
            Assert.AreEqual(shop.animalCount(), 0);
            Assert.AreEqual(shop.partnerCount(), 1);
            Assert.AreEqual(partner.animalCount(), 1);
        }

        [TestMethod]
        public void BuyError()
        {
            Species species = Tarantula.Instance();
            Animal a = new Animal("byTN", "blue", 50, "young", species);
            List<Animal> list = new List<Animal>();
            Partner partner = new Partner("Tardis", list);
            List<Partner> partners = new List<Partner>();
            //partners.Add(partner);
            List<Invoice> invoices = new List<Invoice>();
            List<Animal> animals = new List<Animal>();
            animals.Add(a);
            Shop shop = new Shop("Eidos", invoices, partners, animals);

            Assert.IsNotNull(shop);
            Assert.ThrowsException<Shop.ShopUnableToBuyFromPartnerException>(() => shop.Buy("byTN", "Tardis"));

            Assert.AreEqual(shop.invoiceCount(), 0);
            Assert.AreEqual(shop.animalCount(), 1);
            Assert.AreEqual(shop.partnerCount(), 0);
            Assert.AreEqual(partner.animalCount(), 0);

        }
    }
}