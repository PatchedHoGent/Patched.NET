using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Patched.Models
{
    public class InternshipMentor : User
    {

        private Company company;

        public Company getCompany(){return company;}
        public void setCompany() { this.company = company; }

        public InternshipMentor() { }

    }
}