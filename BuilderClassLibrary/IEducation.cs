using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderClassLibrary
{
    public interface IEducation
    {
        string Teacher { get; set; }
        string Student { get; set; }
        string Feedback { get; set; }
    }
}
