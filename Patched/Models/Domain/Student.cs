using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Patched.Models;
using Patched.Models.Domain;

namespace Patched.Models.Domain
{
    public class Student : User
    {

        private int hoGentID;

        public int getHoGentID() { return hoGentID; }
        public void setHoGentID(int hoGentID) { this.hoGentID = hoGentID; }

        public Student() { }

    }
}