using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using Patched.Models;

namespace Patched.Models.DAL.Mapper
{
    public class CompanyMapper: EntityTypeConfiguration<Company>
    {

        HasKey(c=>c.companyID);
        ToTable("Company");

    }
}