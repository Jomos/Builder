using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderClassLibrary
{
    public class JensenDirector:EducationDirector
    {
        public override IEducation Build(EducationBuilder builder)
        {
            builder.AssignTeacher();
            builder.InviteStudents();
            builder.ProcessStudentFeedback();
            return builder.Education;
        }
    }
}
