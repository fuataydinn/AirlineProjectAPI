using AirlineProject.Application.Interfaces.Repositories;
using AirlineProject.Domain.Entities;
using AirlineProject.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineProject.Infrastructure.Repositories
{
    public class TicketRepository :RepositoryBase<Ticket>,ITicketRepository
    {
        public TicketRepository(AirlineContext context):base(context)
        {

        }
    }
}
