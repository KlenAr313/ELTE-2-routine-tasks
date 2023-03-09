using LTM;

namespace TestLTM
{
    [TestClass]
    public class UnitTestLTM
    {
        [TestMethod]
        public void Create()
        {
            LTM.LTM c = new(3);

            Assert.AreEqual(c[0, 1], 0);
            Assert.AreEqual(c[1, 1], 0);
            Assert.AreEqual(c[2, 1], 0);
        }

        [TestMethod]
        public void Change()
        {
            LTM.LTM c = new(3);

            c[0, 0] = 1;
            c[1, 1] = 1;
            c[2, 2] = 1;

            Assert.ThrowsException<LTM.LTM.ReferenceToNullPartException>(() => c[0, 2] = 3);
            Assert.AreEqual(c[0, 2], 0);
            Assert.AreEqual(c[1, 1], 1);
        }

        [TestMethod]
        public void Add()
        {
            LTM.LTM a = new(3);
            LTM.LTM b = new(3);
            LTM.LTM c = new(2);
            LTM.LTM d;

            a[0, 0] = 1;
            a[1, 0] = 1;
            a[1, 1] = 1;
            a[2, 1] = 1;
            a[2, 2] = 1;

            b[0, 0] = 69;
            b[2, 0] = 1;
            b[2, 2] = 0;

            d = a + b;

            Assert.AreEqual(d[0, 0], 70);
            Assert.AreEqual(d[0, 2], 0);
            Assert.AreEqual(d[1, 0], 1);
            Assert.AreEqual(d[1, 1], 1);
            Assert.AreEqual(d[2, 0], 1);
            Assert.AreEqual(d[2, 1], 1);
            Assert.AreEqual(d[2, 2], 1);

            Assert.ThrowsException<LTM.LTM.DifferentSizeException>(() => a + c);
        }

        [TestMethod]
        public void Mul()
        {
            LTM.LTM a = new(3);
            LTM.LTM b = new(3);
            LTM.LTM c = new(2);
            LTM.LTM d;

            a[0, 0] = 1;
            a[1, 0] = 1;
            a[1, 1] = 1;
            a[2, 1] = 1;
            a[2, 2] = 1;

            b[0, 0] = 69;
            b[2, 0] = 1;
            b[2, 2] = 0;

            d = a * b;

            Assert.AreEqual(d[0, 0], 69);
            Assert.AreEqual(d[0, 2], 0);
            Assert.AreEqual(d[1, 0], 69);
            Assert.AreEqual(d[1, 1], 0);
            Assert.AreEqual(d[2, 0], 1);
            Assert.AreEqual(d[2, 2], 0);

            Assert.ThrowsException<LTM.LTM.DifferentSizeException>(() => a * c);
        }
    }
}