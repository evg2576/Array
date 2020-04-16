using System;
using ArrayObject;
using NUnit.Framework;

namespace Array.Tests
{
    [TestFixture]
    public class ArrayTasksTest
    {
        [Test]
        public void SimpleFalse()
        {
            Assert.IsTrue(false);
        }

        [Test]
        public void SimpleTrue()
        {
            Assert.IsTrue(true);
        }
    }
}
