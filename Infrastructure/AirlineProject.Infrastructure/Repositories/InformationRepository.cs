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
   public class InformationRepository :RepositoryBase<Information>,IInformationRepository
    {
        public InformationRepository(AirlineContext context):base(context)
        {

        }
    }
}
