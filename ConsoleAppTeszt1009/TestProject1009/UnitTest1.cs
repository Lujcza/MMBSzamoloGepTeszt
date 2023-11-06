using ConsoleApp1009;
using System.Runtime.CompilerServices;

namespace TestProject1009{
    internal class Tests
    {
        static Egyenl t1 = new Egyenl("21+15");
        static Egyenl t2 = new Egyenl("1*68");
        static Egyenl t3 = new Egyenl("10/10");
        static Egyenl t4 = new Egyenl("60-5");
        static Egyenl t5 = new Egyenl("2115**82");
        static Egyenl t6 = new Egyenl("asd+fasd");
        [Test]
        public void Test1()
        {
            Assert.IsTrue(t1.IsMath());
            Assert.IsTrue(t1.solve() == 36);
        }
        [Test]
        public void Test2()
        {
            Assert.IsTrue(t2.IsMath());
            Assert.IsTrue(t2.solve() == 68);
        }
        [Test]
        public void Test3()
        {
            Assert.IsTrue(t3.IsMath());
            Assert.IsTrue(t3.solve() == 1);
        }
        [Test]
        public void Test4()
        {
            Assert.IsTrue(t4.IsMath());
            Assert.IsTrue(t4.solve() == 55);
        }
        [Test]
        public void Test5()
        {
            Assert.IsFalse(t5.IsMath());
            Assert.That(() => t5.solve(), Throws.Exception);
        }
        [Test]
        public void Test6()
        {
            Assert.IsFalse(t6.IsMath());
            Assert.That(() => t6.solve(), Throws.Exception);

        }
    }
}