using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Patched.Models
{
    public class Student : User
    {

        private HoGentAccount hogGentAccount;

        public String getHoGentAccount() { return hoGentAccount; }
        public void setHoGentAccount(String hoGentAccount) { this.hoGentAccount = hoGentAccount; }

        public Student() { }

    }
}