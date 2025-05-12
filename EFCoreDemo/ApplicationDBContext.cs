using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreDemo
{
    
    
    public class ApplicationDBContext:DbContext
    {
        string sql = "Data Source=LAPTOP-638L95FC;Initial Catalog=sample;Integrated Security=True;Connect Timeout=30;Encrypt=False";

public DbSet<Student> students { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(sql);
        }


    }
}
