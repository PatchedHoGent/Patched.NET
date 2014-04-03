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
        public InternshipMentorMapper()
        {
            HasKey(i => i.getUserID());
            ToTable("InternshipMentor");
            HasRequired(i => i.getCompany()).WithMany().Map(i => i.MapKey("userID")).WillCascadeOnDelete(true);
        }
    }
}