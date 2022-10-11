using Proj_EF.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_EF.Context
{
    internal class ContactContext : DbContext
    {
        public DbSet<Person> Person { get; set; }
        public DbSet<Telephone> Telephones { get; set; }
    }
}
