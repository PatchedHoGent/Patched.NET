using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Patched.Models.Domain;

namespace Patched.Models.Domain
{
    public class InternshipSupervisor : User
    {

        private int hoGentID;

        public int getHoGentID() { return hoGentID; }
        public void setHoGentID(int hoGentAccount) { this.hoGentID = hoGentID; }

        public InternshipSupervisor() { }

    }
}