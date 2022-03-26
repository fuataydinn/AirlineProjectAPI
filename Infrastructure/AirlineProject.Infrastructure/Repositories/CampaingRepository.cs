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
    public class CampaingRepository :RepositoryBase<Campaing>,ICampaingRepository
    {
        public CampaingRepository(AirlineContext context):base(context)
        {

        }
    }
}
