using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ApiTest.Models
{
    public class Context
    {
        public DbSet<Employee> Employees { get; set; }
    }
}