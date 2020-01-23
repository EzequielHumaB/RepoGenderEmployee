using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BlazorAPPGenderEmploy.Data;

namespace BlazorAPPGenderEmploy.Data
{
    public class Contexto:DbContext
    {
        public Contexto(DbContextOptions<Contexto> dbContextOptions)
         : base(dbContextOptions)
        {

        }


        public DbSet<EmployeInfo> employeInfos { get; set; }
    }
}
