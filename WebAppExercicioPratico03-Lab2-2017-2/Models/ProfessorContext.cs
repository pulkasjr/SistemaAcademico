﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebAppExercicioPratico03_Lab2_2017_2.Models
{
    public class ProfessorContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public ProfessorContext() : base("name=ProfessorContext")
        {
        }

        public System.Data.Entity.DbSet<WebAppExercicioPratico03_Lab2_2017_2.Models.Professor> Professors { get; set; }

        public System.Data.Entity.DbSet<WebAppExercicioPratico03_Lab2_2017_2.Models.NivelEnsino> NivelEnsinoes { get; set; }
    }
}