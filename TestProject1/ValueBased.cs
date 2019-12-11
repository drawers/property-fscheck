using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace TestProject1
{
    [TestFixture]
    public class ValueBased
    {
        private List<int> ints = new List<int> {4, 8, 7};

        [Test]
        public void TestForward()
        {
            Assert.AreEqual(8, ints.MyMax());
        }

        [Test]
        public void TestReverse()
        {
            Assert.AreEqual(8, ints.AsEnumerable()
                .Reverse()
                .MyMax());
        }
    }
}