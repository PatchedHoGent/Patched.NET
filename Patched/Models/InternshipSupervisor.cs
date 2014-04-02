using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Patched.Models
{
    public class InternshipSupervisor : User
    {

        private HoGentAccount hogGentAccount;

        public String getHoGentAccount() { return hoGentAccount; }
        public void setHoGentAccount(String hoGentAccount) { this.hoGentAccount = hoGentAccount; }

        public InternShipSupervisor() { }

    }
}