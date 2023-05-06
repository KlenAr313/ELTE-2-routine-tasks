using System.Threading.Tasks.Dataflow;

namespace _4szorg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Card jCard = new Card("1234-2345-3456-4567", "6656");
            Card pCard = new Card("9876-8765-7654-6543", "1111");

            Client jhon = new Client(jCard, "6656", 1);
            Client paul = new Client(pCard, "1111", 1);

            Invoice jInvoice = new Invoice("1234-5432", 200, jCard);
            Invoice pInvoice = new Invoice("9876-5678", 20, pCard);
            List<Invoice> invoices = new List<Invoice> { jInvoice, pInvoice };

            Bank noname = new Bank(invoices);
            List<Bank> banks = new List<Bank> { noname };

            List<Card> nonameBankCards = new List<Card> { jCard, pCard };
            List<List<Card>> cardsToBank = new List<List<Card>> { nonameBankCards };

            Center center = new Center(banks, cardsToBank);

            ATM atm = new ATM("220A Baker Street", center);

            try
            {
                Console.WriteLine($"Chash with Jhon: {jhon.getHave()}");
                Console.WriteLine($"Money on Jhon's invoice: {jInvoice.GetBalance()}");
                jhon.setNeed(100);
                jhon.useATM(atm);
                Console.WriteLine($"Chash with Jhon after transactions: {jhon.getHave()}");
                Console.WriteLine($"Money on Jhon's invoice after transactions: {jInvoice.GetBalance()}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                Console.WriteLine($"Chash with Paul: {paul.getHave()}");
                Console.WriteLine($"Money on Paul's invoice: {pInvoice.GetBalance()}");
                paul.setNeed(50);
                paul.useATM(atm);
                Console.WriteLine($"Chash with Paul after transactions: {paul.getHave()}");
                Console.WriteLine($"Money on Paul's invoice after transactions: {pInvoice.GetBalance()}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}