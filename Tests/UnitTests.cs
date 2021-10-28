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

        [Test]
        public void Sub_ValidPham()
        {
            Assert.AreEqual(10, Program.Subtract("11", "1"));
            Assert.AreEqual(3, Program.Subtract("1", "-2"));
            Assert.AreEqual(-4, Program.Subtract("1", "5"));
        }

        [Test]
        public void Sub_InvalidPham()
        {
            Assert.Throws<FormatException>(() => Program.Subtract("10", "a"));
            Assert.Throws<FormatException>(() => Program.Subtract("'", "9"));
            Assert.Throws<FormatException>(() => Program.Subtract("||", "&&"));
        }

        [Test]
        public void Sub_NullPham()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Subtract("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Subtract(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Subtract(null, null));
        }

        [Test]
        public void Multi_ValidPham()
        {
            Assert.AreEqual(11, Program.Multiply("11", "1"));
            Assert.AreEqual(-70, Program.Multiply("35", "-2"));
            Assert.AreEqual(0, Program.Multiply("-64", "0"));
        }

        [Test]
        public void Multi_InvalidPham()
        {
            Assert.Throws<FormatException>(() => Program.Multiply("10", "a"));
            Assert.Throws<FormatException>(() => Program.Multiply("'", "9"));
            Assert.Throws<FormatException>(() => Program.Multiply("||", "&&"));
        }

        [Test]
        public void Multi_NullPham()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Multiply("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Multiply(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Multiply(null, null));
        }

        [Test]
        public void Div_ValidPham()
        {
            Assert.AreEqual(11, Program.Divide("11", "1"));
            Assert.AreEqual(-15.5, Program.Divide("31", "-2"));
            Assert.AreEqual(0.5, Program.Divide("4", "8"));
        }

        [Test]
        public void Div_InvalidPham()
        {
            Assert.Throws<FormatException>(() => Program.Divide("10", "a"));
            Assert.Throws<FormatException>(() => Program.Divide("'", "9"));
            Assert.Throws<FormatException>(() => Program.Divide("||", "&&"));
        }

        [Test]
        public void Div_NullPham()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Divide("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Divide(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Divide(null, null));
        }

        [Test]
        public void Pow_ValidPham()
        {
            Assert.AreEqual(11, Program.Power("20", "1"));
            Assert.AreEqual(4, Program.Power("16", "0.5"));
            Assert.AreEqual(0, Program.Power("0", "8"));
        }

        [Test]
        public void Pow_InvalidPham()
        {
            Assert.Throws<FormatException>(() => Program.Power("10", "a"));
            Assert.Throws<FormatException>(() => Program.Power("'", "9"));
            Assert.Throws<FormatException>(() => Program.Power("||", "&&"));
        }

        [Test]
        public void Pow_NullPham()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Power("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Power(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Power(null, null));
        }
    }
}
