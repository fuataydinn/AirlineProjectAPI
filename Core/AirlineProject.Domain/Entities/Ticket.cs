using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineProject.Domain.Entities
{
    public class Ticket : BaseEntity
    {
        public string WhereFrom { get; set; }
        public string ToWhere { get; set; }
        public DateTime DepartureDate { get; set; }
        public DateTime? DateOfReturn { get; set; }
        public string PassengerType { get; set; }

        public int InformationId { get; set; }
        public Information Information { get; set; } //Bir bileti 1 kisi alabilir
        public Campaing Campaing { get; set; }
    }
}
