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
            string expectedTeacher = "Nackademin Teacher Assigned";
            string expectedStudent = "Nackadem Student Invited";
            string expectedFeedback = "Nackademin Student Feedback";
            //Act
            var actualTeacher = director.Build(builder).Teacher;
            var actualStudent = director.Build(builder).Student;
            var actualFeedback = director.Build(builder).Feedback;
            //Assert
            Assert.AreEqual(expectedTeacher, actualTeacher);
            Assert.AreEqual(expectedStudent, actualStudent);
            Assert.AreEqual(expectedFeedback, actualFeedback);

        }

        [TestMethod]
        public void EducationJensenTest()
        {
            //Arrange
            var builder = new JensenBuilder();
            var director = new JensenDirector();
            string expectedTeacher = "Jensen Teacher Assigned";
            string expectedStudent = "Jensen Student Invited";
            string expectedFeedback = "Jensen Student Feedback";
            //Act
            var actualTeacher = director.Build(builder).Teacher;
            var actualStudent = director.Build(builder).Student;
            var actualFeedback = director.Build(builder).Feedback;
            //Assert
            Assert.AreEqual(expectedTeacher, actualTeacher);
            Assert.AreEqual(expectedStudent, actualStudent);
            Assert.AreEqual(expectedFeedback, actualFeedback);
        }
    }
}
