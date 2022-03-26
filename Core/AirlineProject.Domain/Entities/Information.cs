using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineProject.Domain.Entities
{
    public class Information : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string IdentityNumber { get; set; }
        public string Email { get; set; }
        public string Telepfone { get; set; }

        public int TicketId { get; set; }
        public ICollection<Ticket> Tickets { get; set; } // Bir kisinin 1 den fazla bileti olabilir
    }
}
