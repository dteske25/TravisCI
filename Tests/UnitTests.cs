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

        // Subtraction
        [Test]
        public void Subtract_ValidLe() {
            Assert.AreEqual(1, Program.Subtract("2", "1"));
            Assert.AreEqual(1, Program.Subtract("3", "2"));
            Assert.AreEqual(2, Program.Subtract("7", "5"));
        }
        [Test]
        public void Subtract_InvalidLe() {
            Assert.Throws<FormatException>(() => Program.Subtract("1", "a"));
            Assert.Throws<FormatException>(() => Program.Subtract("a", "1"));
            Assert.Throws<FormatException>(() => Program.Subtract("a", "a"));
        }
        [Test]
        public void Subtract_NullLe() {
            Assert.Throws<ArgumentNullException>(() => Program.Subtract("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Subtract(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Subtract(null, null));
        }

        // Multiplication
        [Test]
        public void Multiply_ValidLe() {
            Assert.AreEqual(2, Program.Multiply("2", "1"));
            Assert.AreEqual(6, Program.Multiply("3", "2"));
            Assert.AreEqual(35, Program.Multiply("7", "5"));
        }
        [Test]
        public void Multiply_InvalidLe() {
            Assert.Throws<FormatException>(() => Program.Multiply("1", "a"));
            Assert.Throws<FormatException>(() => Program.Multiply("a", "1"));
            Assert.Throws<FormatException>(() => Program.Multiply("a", "a"));
        }
        [Test]
        public void Multiply_NullLe() {
            Assert.Throws<ArgumentNullException>(() => Program.Multiply("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Multiply(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Multiply(null, null));
        }

        // Division
        [Test]
        public void Divide_ValidLe() {
            Assert.AreEqual(1, Program.Divide("2", "1"));
            Assert.AreEqual(2, Program.Divide("2", "2"));
            Assert.AreEqual(5, Program.Divide("20", "4"));
        }
        [Test]
        public void Divide_InvalidLe() {
            Assert.Throws<FormatException>(() => Program.Divide("1", "a"));
            Assert.Throws<FormatException>(() => Program.Divide("a", "1"));
            Assert.Throws<FormatException>(() => Program.Divide("a", "a"));
        }
        [Test]
        public void Divide_NullLe() {
            Assert.Throws<ArgumentNullException>(() => Program.Divide("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Divide(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Divide(null, null));
        }
        // Power
        [Test]
        public void Power_ValidLe() {
            Assert.AreEqual(2, Program.Power("2", "1"));
            Assert.AreEqual(9, Program.Power("3", "2"));
            Assert.AreEqual(16807, Program.Power("7", "5"));
        }
        [Test]
        public void Power_InvalidLe() {
            Assert.Throws<FormatException>(() => Program.Power("1", "a"));
            Assert.Throws<FormatException>(() => Program.Power("a", "1"));
            Assert.Throws<FormatException>(() => Program.Power("a", "a"));
        }
        [Test]
        public void Power_NullLe() {
            Assert.Throws<ArgumentNullException>(() => Program.Power("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Power(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Power(null, null));
        }
    }
}
