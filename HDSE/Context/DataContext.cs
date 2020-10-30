using HDSE.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HDSE.Context
{
    public class DataContext :DbContext
    {
        public DataContext() : base("T1907AEntities")
        {

        }
        public  DbSet<Employee> employees { get; set; }
       
    }
    
}