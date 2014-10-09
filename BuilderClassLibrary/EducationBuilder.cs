using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderClassLibrary
{
    public abstract class EducationBuilder
    {
        public IEducation Education { get; set; }

        public virtual void AssignTeacher()
        {
            
        }

        public virtual void InviteStudents()
        {
            
        }

        public virtual void ProcessStudentFeedback()
        {
            
        }
    }
}
