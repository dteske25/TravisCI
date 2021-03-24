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
        //Subtract
        [Test]
        public void Subtract_ValidWallin()
        {
            Assert.AreEqual(1, Program.Subtract("2", "1"));
            Assert.AreEqual(3, Program.Subtract("5", "2"));
            Assert.AreEqual(5, Program.Subtract("12", "7"));
        }
        [Test]
        public void Subtract_InvalidWallin()
        {
            Assert.Throws<FormatException>(() => Program.Subtract("1", "a"));
            Assert.Throws<FormatException>(() => Program.Subtract("a", "1"));
            Assert.Throws<FormatException>(() => Program.Subtract("a", "a"));
        }
        [Test]
        public void Subtract_NullWallin()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Subtract("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Subtract(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Subtract(null, null));
        }
        //Multiply
        [Test]
        public void Multiply_ValidWallin()
        {
            Assert.AreEqual(2, Program.Multiply("2", "1"));
            Assert.AreEqual(10, Program.Multiply("5", "2"));
            Assert.AreEqual(84, Program.Multiply("12", "7"));
        }
        [Test]
        public void Multiply_InvalidWallin()
        {
            Assert.Throws<FormatException>(() => Program.Multiply("1", "a"));
            Assert.Throws<FormatException>(() => Program.Multiply("a", "1"));
            Assert.Throws<FormatException>(() => Program.Multiply("a", "a"));
        }
        [Test]
        public void Multiply_NullWallin()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Multiply("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Multiply(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Multiply(null, null));
        }
        //Divide
        [Test]
        public void Divide_ValidWallin()
        {
            Assert.AreEqual(2, Program.Divide("2", "1"));
            Assert.AreEqual(3, Program.Divide("6", "2"));
            Assert.AreEqual(2, Program.Divide("12", "6"));
        }
        [Test]
        public void Divide_InvalidWallin()
        {
            Assert.Throws<FormatException>(() => Program.Divide("1", "a"));
            Assert.Throws<FormatException>(() => Program.Divide("a", "1"));
            Assert.Throws<FormatException>(() => Program.Divide("a", "a"));
        }
        [Test]
        public void Divide_NullWallin()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Divide("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Divide(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Divide(null, null));
        }
        //Power
        [Test]
        public void Power_ValidWallin()
        {
            Assert.AreEqual(2, Program.Power("2", "1"));
            Assert.AreEqual(25, Program.Power("5", "2"));
            Assert.AreEqual(1, Program.Power("1", "0"));
        }
        [Test]
        public void Power_InvalidWallin()
        {
            Assert.Throws<FormatException>(() => Program.Power("1", "a"));
            Assert.Throws<FormatException>(() => Program.Power("a", "1"));
            Assert.Throws<FormatException>(() => Program.Power("a", "a"));
        }
        [Test]
        public void Power_NullWallin()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Power("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Power(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Power(null, null));
        }
    }
}
