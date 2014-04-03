using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Patched.Models.Domain
{
    public class Assignment
    {
        private int assignmentID;
        private String title;
        private Company company;
        private String description;
        private String schoolYear;
        private int semester;
        private DateTime dateAdded;
        private enum status {Goedgekeurd, Afgekeurd };

        public int getAssignmentID() { return assignmentID; }
        public void setAssignmentID() { this.assignmentID = assignmentID; }
        public void setTitle(String title){this.title=title;}
        public String getTitle(){return title;}
        public void setCompany(Company company){this.company=company;}
        public Company getCompany(){return company;}
        public void setDescription(String title){this.description=description;}
        public String getDescription(){return description;}
        public void setSchoolYear(String schoolYear){this.schoolYear=schoolYear;}
        public String getSchoolYear(){return schoolYear;}
        public void setDateAdded(DateTime dateAdded){this.dateAdded=dateAdded;}
        public DateTime getDateAdded(){return dateAdded;}
        //public void setStatus(enum title){this.title=title;}
        //public enum getStatus(){return status;}

        public Assignment(){}


    }
}