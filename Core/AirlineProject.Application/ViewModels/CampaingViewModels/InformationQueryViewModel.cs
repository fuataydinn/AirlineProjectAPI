using AirlineProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineProject.Application.ViewModels.CampaingViewModels
{
    class InformationQueryViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string IdentityNumber { get; set; }
        public string Email { get; set; }
        public string Telepfone { get; set; }

        public int TicketId { get; set; }
        public ICollection<Ticket> Tickets { get; set; } 
    }
}
