using AirlineProject.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineProject.Infrastructure.Context
{
   public class AirlineContext :DbContext
    {
        public AirlineContext(DbContextOptions<AirlineContext>options):base(options)
        {

        }

        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Campaing> Campaings { get; set; }
        public DbSet<Information> Informations { get; set; }
    }
}
