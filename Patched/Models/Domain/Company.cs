﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Patched.Models;

namespace Patched.Models.Domain
{
    public class Company : User
    {
        private int companyID;
        private String url;
        private String reachability;
        public String businessActivity;

        public String getUrl() { return url; }
        public void setURL(String url) { this.url = url; }
        public String getReachability() { return reachability; }
        public void setReachability(String reachability) { this.reachability = reachability; }
        public String getBusinessActivity() { return businessActivity; }
        public void setBusinessActivitiy(String businessActivity) { this.businessActivity = businessActivity; }

        public Company() { }

    }
}