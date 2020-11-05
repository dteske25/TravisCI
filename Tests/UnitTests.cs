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
        public void Subtract_Valid()
        {
            Assert.AreEqual(-1, Program.Subtract("1", "2"));
            Assert.AreEqual(1, Program.Subtract("3", "2"));
            Assert.AreEqual(-2, Program.Subtract("5", "7"));
        }

        [Test]
        public void Subtract_Invalid()
        {
            Assert.Throws<FormatException>(() => Program.Subtract("1", "a"));
            Assert.Throws<FormatException>(() => Program.Subtract("a", "1"));
            Assert.Throws<FormatException>(() => Program.Subtract("a", "a"));
        }

        [Test]
        public void Subtract_Null()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Subtract("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Subtract(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Subtract(null, null));
        }

        [Test]
        public void Multiply_Valid()
        {
            Assert.AreEqual(2, Program.Multiply("1", "2"));
            Assert.AreEqual(6, Program.Multiply("3", "2"));
            Assert.AreEqual(35, Program.Multiply("5", "7"));
        }

        [Test]
        public void Multiply_Invalid()
        {
            Assert.Throws<FormatException>(() => Program.Multiply("1", "a"));
            Assert.Throws<FormatException>(() => Program.Multiply("a", "1"));
            Assert.Throws<FormatException>(() => Program.Multiply("a", "a"));
        }

        [Test]
        public void Multiply_Null()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Multiply("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Multiply(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Multiply(null, null));
        }

        [Test]
        public void Divide_Valid()
        {
            Assert.AreEqual(0.5, Program.Divide("1", "2"));
            Assert.AreEqual(1, Program.Divide("3", "3"));
            Assert.AreEqual(3, Program.Divide("15", "5"));
        }

        [Test]
        public void Divide_Invalid()
        {
            Assert.Throws<FormatException>(() => Program.Divide("1", "a"));
            Assert.Throws<FormatException>(() => Program.Divide("a", "1"));
            Assert.Throws<FormatException>(() => Program.Divide("a", "a"));
        }

        [Test]
        public void Divide_Null()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Divide("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Divide(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Divide(null, null));
        }

        [Test]
        public void Power_Valid()
        {
            Assert.AreEqual(1, Program.Power("1", "2"));
            // Intentionally made fail
            Assert.AreEqual(19, Program.Power("3", "2"));
            Assert.AreEqual(78125, Program.Power("5", "7"));
        }

        [Test]
        public void Power_Invalid()
        {
            Assert.Throws<FormatException>(() => Program.Power("1", "a"));
            Assert.Throws<FormatException>(() => Program.Power("a", "1"));
            Assert.Throws<FormatException>(() => Program.Power("a", "a"));
        }

        [Test]
        public void Power_Null()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Power("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Power(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Power(null, null));
        }
    }
}
 9  TravisCI.sln 
@@ -1,12 +1,17 @@
﻿
Microsoft Visual Studio Solution File, Format Version 12.00
# Visual Studio 15
VisualStudioVersion = 15.0.27130.2036
# Visual Studio Version 16
VisualStudioVersion = 16.0.30611.23
MinimumVisualStudioVersion = 10.0.40219.1
Project("{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}") = "Console", "Console\Console.csproj", "{C5964EEF-DA27-4C98-B4D0-7F27767FE870}"
EndProject
Project("{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}") = "Tests", "Tests\Tests.csproj", "{C3F293D9-3D79-4280-9E67-9E51A00E94F3}"
EndProject
Project("{2150E333-8FDC-42A3-9474-1A3956D46DE8}") = "Solution Items", "Solution Items", "{69009F83-1EBE-49E1-9377-2C21A192F4BE}"
	ProjectSection(SolutionItems) = preProject
		.travis.yml = .travis.yml
	EndProjectSection
EndProject
Global
	GlobalSection(SolutionConfigurationPlatforms) = preSolution
		Debug|Any CPU = Debug|Any CPU
		Release|Any CPU = Release|Any CPU
	EndGlobalSection
	GlobalSection(ProjectConfigurationPlatforms) = postSolution
		{C5964EEF-DA27-4C98-B4D0-7F27767FE870}.Debug|Any CPU.ActiveCfg = Debug|Any CPU
		{C5964EEF-DA27-4C98-B4D0-7F27767FE870}.Debug|Any CPU.Build.0 = Debug|Any CPU
		{C5964EEF-DA27-4C98-B4D0-7F27767FE870}.Release|Any CPU.ActiveCfg = Release|Any CPU
		{C5964EEF-DA27-4C98-B4D0-7F27767FE870}.Release|Any CPU.Build.0 = Release|Any CPU
		{C3F293D9-3D79-4280-9E67-9E51A00E94F3}.Debug|Any CPU.ActiveCfg = Debug|Any CPU
		{C3F293D9-3D79-4280-9E67-9E51A00E94F3}.Debug|Any CPU.Build.0 = Debug|Any CPU
		{C3F293D9-3D79-4280-9E67-9E51A00E94F3}.Release|Any CPU.ActiveCfg = Release|Any CPU
		{C3F293D9-3D79-4280-9E67-9E51A00E94F3}.Release|Any CPU.Build.0 = Release|Any CPU
	EndGlobalSection
	GlobalSection(SolutionProperties) = preSolution
		HideSolutionNode = FALSE
	EndGlobalSection
	GlobalSection(ExtensibilityGlobals) = postSolution
		SolutionGuid = {BD5B13BD-7E0B-4CFB-9D52-7F4F72E49084}
	EndGlobalSection
EndGlobal
