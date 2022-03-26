using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineProject.Application.ViewModels.CampaingViewModels
{
     public class CampaingQueryViewModel
    {
        //-- query sorgu neticesinde gelen veriler (GET)
        public int Id { get; set; }
        public string CampaingName { get; set; }
        public string Description { get; set; }
        public byte MounthlyPeriod { get; set; }
    }
}
