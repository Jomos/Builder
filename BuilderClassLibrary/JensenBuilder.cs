using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderClassLibrary
{
    public class JensenBuilder:EducationBuilder
    {
        public JensenBuilder()
        {
            Education = new JensenEducation();
        }
        public override void AssignTeacher()
        {
            Education.Teacher = "Jensen Teacher Assigned";
        }

        public override void InviteStudents()
        {
            Education.Student = "Jensen Student Invited";
        }

        public override void ProcessStudentFeedback()
        {
            Education.Feedback = "Jensen Student Feedback";
        }
    }
}
