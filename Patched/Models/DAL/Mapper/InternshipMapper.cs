using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using Patched.Models;

namespace Patched.Models.DAL.Mapper
{
    public class InternshipMapper: EntityTypeConfiguration<Internship>
    {
        HasKey(i => i.AssignmentID);
        Property(i => i.title).IsRequired();
        ToTable("Internship");
        HasMany(i => i.students).Map(i => i.MapKey("hoGentID")).WillCascadeOnDelete(false);
        HasOne(i=>i.internshipSupervisor).WithMany().Map(i=>i.MapKey("hoGentID")).WillCascadeOnDelete(false);
        HasOne(if=>i.innternshipMentor).WithMany().Map(i=>i.MapKey("internshipMentorID").WillCascadeOnDelete(false);;
    }
}