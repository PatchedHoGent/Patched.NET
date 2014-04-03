using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using Patched.Models.Domain;

namespace Patched.Models.DAL.Mapper
{
    public class InternshipMapper: EntityTypeConfiguration<Internship>
    {

        public InternshipMapper(){
        HasKey(i => i.getAssignmentID());
        Property(i => i.getTitle()).IsRequired();
        ToTable("Internship");
        HasMany(i => i.getStudents()).Map(i => i.MapKey("hoGentID")).WillCascadeOnDelete(false);
        HasOptional(i=>i.getInternshipSupervisor()).WithMany().Map(i=>i.MapKey("hoGentID")).WillCascadeOnDelete(false);
        HasOptional(i=>i.getInternshipMentor()).WithMany().Map(i=>i.MapKey("userID")).WillCascadeOnDelete(false);}
    }
}