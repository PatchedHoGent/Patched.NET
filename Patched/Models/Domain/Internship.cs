using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Patched.Models;
using Patched.Models.Domain;

namespace Patched.Models.Domain
{
    public class Internship : Assignment
    {

        private enum type { };
        private int studentAmount;
        private InternshipSupervisor supervisor;
        private Array students;
        private InternshipMentor mentor;

        //public enum getType(){return type;}
        //public void setType(enum type){this.type=type;}
        public int getStudentAmount(){return studentAmount;}
        public void setStudentAmount(int studentAmount){this.studentAmount=studentAmount;}
        public InternshipSupervisor getSupervisor() {return supervisor;}
        public void setInternshipSupervisor(InternshipSupervisor supervisor) { this.supervisor = supervisor; }
        public Array getStudents() { return students; }
        public void setStudents(Array students) { this.students = students; }
        public InternshipMentor getMentor() { return mentor; }
        public void setMentor(InternshipMentor mentor) { this.mentor = mentor; }

    }
}