using petShop;

namespace petShopTest
{
    [TestClass]
    public class InvoiceTest
    {
        [TestMethod]
        public void Construct()
        {
            Species species = Tarantula.Instance();
            Animal a = new Animal("byTN", "blue", 50, "young", species);
            List<Animal> list = new List<Animal>();
            list.Add(a);
            Partner partner = new Partner("Tardis", list);
            Invoice invoice = new Invoice("2022.05.31", a.realValue(), "sell", partner, a);

            Assert.IsNotNull(invoice);
            Assert.AreEqual(invoice.getType(), "sell");
            Assert.AreEqual(invoice.getPartner(), partner);
            Assert.AreEqual(invoice.getPrice(), 150);
        }
    }
}