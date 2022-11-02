using OopUppgift;

namespace OopUppgiftTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void NoSpecialOffers()
        {
            Checkout checkout = new Checkout();
            checkout.AddItem(1);
            checkout.AddItem(1);
            checkout.AddItem(2, 2);
            Assert.AreEqual(checkout.Sum(), 24.95m*2+59*2);
        }

        [TestMethod]
        public void CoffeeOffer()
        {
            Checkout checkout = new Checkout();
            checkout.AddItem(1);
            checkout.AddItem(4);
            checkout.AddItem(4);
            Assert.AreEqual(checkout.Sum(), 24.95m+40);
        }

        [TestMethod]
        public void ToothpasteOffer()
        {
            Checkout checkout = new Checkout();
            checkout.AddItem(1);
            checkout.AddItem(1);
            checkout.AddItem(1);
            Assert.AreEqual(checkout.Sum(), 24.95m*2);
        }

        [TestMethod]
        public void ApplesOffer()
        {
            Checkout checkout = new Checkout();
            checkout.AddItem(7, 2);
            checkout.AddItem(5, 5);
            Assert.AreEqual(checkout.Sum(), 93 * 2 + 5*16.95m);
        }

        [TestMethod]
        public void ApplesNoOffer()
        {
            Checkout checkout = new Checkout();
            checkout.AddItem(7, 1);
            checkout.AddItem(5, 5);
            Assert.AreEqual(checkout.Sum(), 93 * 1 + 5 * 32.95m);
        }
    }
}