using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using Patched.Models.Domain;

namespace Patched.Models.DAL.Mapper
{
    public class StudentMapper: EntityTypeConfiguration<Student>
    {
        public StudentMapper(){
        HasKey(s=>s.getUserID());
        ToTable("Student");}
        
    }
}