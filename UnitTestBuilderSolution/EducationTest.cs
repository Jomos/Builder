using System;
using BuilderClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestBuilderSolution
{
    [TestClass]
    public class EducationTest
    {
        [TestMethod]
        public void EducationNackademinTest()
        {
            //Arrange
            var builder = new NackademinBuilder();
            var director = new NackademinDirector();
            string expected = "Nackademin Teacher Assigned";
            //Act
            var actual = director.Build(builder).Teacher;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void EducationJensenTest()
        {
            //Arrange
            var builder = new JensenBuilder();
            var director = new JensenDirector();
            string expected = "Jensen Teacher Assigned";
            //Act
            var actual = director.Build(builder).Teacher;
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
