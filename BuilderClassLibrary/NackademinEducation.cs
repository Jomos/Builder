using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderClassLibrary
{
    public class NackademinEducation:IEducation
    {
        public string Teacher { get; set; }

        public string Student { get; set; }

        public string Feedback { get; set; }
    }
}
