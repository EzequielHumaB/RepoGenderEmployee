using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorAPPGenderEmploy.Data
{
    public class Contexto
    {
        public Contexto(DbContextOptions<Contexto> dbContextOptions)
         : base(dbContextOptions)
        {

        }


        public DbSet<EmployeInfo> employeInfos { get; set; }
    }
}
