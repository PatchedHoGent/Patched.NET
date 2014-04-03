using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Patched.Models.Domain
{
    public class User
    {

        private String username;
        private String password;
        private String adress;
        private String telephone;
        private String cellphone;

        public String getUsername() { return username; }
        public void setUsername(String username) { this.username = username; }
        public String getPassword() { return password; }
        public void setPassword(String password) { this.password = password; }
        public String getAdress() { return adress; }
        public void setAdress(String adress) { this.adress = adress; }
        public String getTelephone() { return telephone; }
        public void setTelephone(String telephone) { this.telephone = telephone; }
        public String getCellphone() { return cellphone; }
        public void setUsername(String cellphone) { this.cellphone = cellphone; }

        public User() { }

    }
}