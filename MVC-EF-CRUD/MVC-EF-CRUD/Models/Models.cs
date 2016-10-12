using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVC_EF_CRUD.Models
{
    //Normally broken down in different files.  Planet.CS etc. 

    public class Planet
    {
        public int PlanetID { get; set; }
        public string Name { get; set; }
    }

    public class PlanetContext : DbContext
    {
        public DbSet<Planet> Planets { get; set; }
    }
}