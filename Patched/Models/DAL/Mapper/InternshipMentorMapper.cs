using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using Patched.Models.Domain;

namespace Patched.Models.DAL.Mapper
{
    public class InternshipMentorMapper: EntityTypeConfiguration<InternshipMentor>
    {
        public InternshipMentorMapper
        //HasKey(i=>i.internshipMentorID);
        //ToTable("InternshipMentor");
        //HasOne(i=>i.company).WithMany().Map(i=>i.MapKey("CompanyID")).WillCascadeOnDelete(true);
    }
}