using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using Patched.Models.Domain;

namespace Patched.Models.DAL.Mapper
{
    public class CompanyMapper: EntityTypeConfiguration<Company>
    {
        public CompanyMapper()
        {
            HasKey(c => c.getUserID());
            ToTable("Company");
        }

    }
}