using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using Patched.Models.Domain;

namespace Patched.Models.DAL.Mapper
{
    public class ProjectMapper: EntityTypeConfiguration<Project>
    {
        public ProjectMapper()
        {
            HasKey(p => p.getAssignmentID());
            ToTable("Project");
        }
    }
}