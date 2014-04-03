using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using Patched.Models;

namespace Patched.Models.DAL.Mapper
{
    public class BachelorProjectMapper: EntityTypeConfiguration<BachelorProject>
    {
        HasKey(b => b.AssignmentID);
        ToTable("BachelorProject");
    }
}