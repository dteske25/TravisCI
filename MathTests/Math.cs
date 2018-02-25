using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TravisCILab
{
    [TestClass]
    public class Math
    {
        [TestMethod]
        public void Add_Valid()
        {
            Assert.AreEqual(3, Program.Add("1", "2"));
            Assert.AreEqual(5, Program.Add("3", "2"));
            Assert.AreEqual(12, Program.Add("5", "7"));
        }

        [TestMethod]
        public void Add_Invalid()
        {
            Assert.ThrowsException<FormatException>(() => Program.Add("1", "a"));
            Assert.ThrowsException<FormatException>(() => Program.Add("a", "1"));
            Assert.ThrowsException<FormatException>(() => Program.Add("a", "a"));
        }

        [TestMethod]
        public void Add_Null()
        {
            Assert.ThrowsException<ArgumentNullException>(() => Program.Add("1", null));
            Assert.ThrowsException<ArgumentNullException>(() => Program.Add(null, "1"));
            Assert.ThrowsException<ArgumentNullException>(() => Program.Add(null, null));
        }

        // Implement 3 tests per operation, following a similar pattern as above
    }
}
