using System;
using NUnit.Framework;

namespace TravisCILab
{
    [TestFixture]
    public class Math
    {
        [Test]
        public void Add_Valid()
        {
            Assert.AreEqual(3, Program.Add("1", "2"));
            Assert.AreEqual(5, Program.Add("3", "2"));
            Assert.AreEqual(12, Program.Add("5", "7"));
        }

        [Test]
        public void Add_Invalid()
        {
            Assert.Throws<FormatException>(() => Program.Add("1", "a"));
            Assert.Throws<FormatException>(() => Program.Add("a", "1"));
            Assert.Throws<FormatException>(() => Program.Add("a", "a"));
        }

        [Test]
        public void Add_Null()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Add("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Add(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Add(null, null));
        }

        // Implement 3 tests per operation, following a similar pattern as above
        [Test]
        public void Power_Valid()
        {
            Assert.AreEqual(4, Program.Power("2", "2"));
            Assert.AreEqual(1024, Program.Power("32", "2"));
            Assert.AreEqual(78125, Program.Subtract("5", "7"));
        }

        [Test]
        public void Subtract_Valid()
        {
            // Answer here is purposely wrong--it should be -1, but 10 was used instead.
            Assert.AreEqual(10, Program.Subtract("1", "2"));
            Assert.AreEqual(2, Program.Subtract("5", "3"));
            Assert.AreEqual(18, Program.Subtract("60", "42"));
        }

        [Test]
        public void Multiply_Valid()
        {
            Assert.AreEqual(35, Program.Multiply("7", "5"));
            Assert.AreEqual(5.5, Program.Multiply("2.75", "2"));
            Assert.AreEqual(2.5, Program.Multiply("5", "0.5"));
        }
    }
}
}
