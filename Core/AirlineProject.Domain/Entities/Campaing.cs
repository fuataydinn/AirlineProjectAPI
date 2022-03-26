using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineProject.Domain.Entities
{
    public class Campaing : BaseEntity
    {
        public string CampaingName { get; set; }
        public string Description { get; set; }
        public byte MounthlyPeriod { get; set; }
        public DateTime ThePeriodOfValidity { get; set; }

    }
}
