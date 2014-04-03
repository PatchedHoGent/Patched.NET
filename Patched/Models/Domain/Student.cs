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

        private HoGentAccount hogGentAccount;

        public String getHoGentAccount() { return hoGentAccount; }
        public void setHoGentAccount(String hoGentAccount) { this.hoGentAccount = hoGentAccount; }

        public Student() { }

    }
}