using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderClassLibrary
{
    public class NackademinBuilder:EducationBuilder
    {
        public NackademinBuilder()
        {
            Education = new NackademinEducation();
        }
        public override void AssignTeacher()
        {
            Education.Teacher = "Nackademin Teacher Assigned";
        }

        public override void InviteStudents()
        {
            Education.Student = "Nackadem Student Invited";
        }

        public override void ProcessStudentFeedback()
        {
            Education.Feedback = "Nackademin Student Feedback";
        }
    }
}
