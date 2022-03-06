using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetGestionCours
{
    internal class Cours
    {
        private string courseName;
        private string courseStart;
        private string courseEnd;
        private string courseTiming;
        private string className;
        private int classID;

        public string CourseName { get { return courseName; } set { courseName = value; } }
        public string CourseStart { get { return courseStart; } set { courseStart = value; } }
        public string CourseEnd { get { return courseEnd; } set { courseEnd = value; } }
        public int ClassID { get { return classID; } set { classID = value;} }
        public string CourseTiming { get { return courseTiming; } set { courseTiming = value; } }
        public string ClassName { get { return className; } set { className = value; } }

    }
}
