using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharityNet.Domain.Entities
{
    public class Donation : DomainObject
    {
        public Account Account { get; set; }
        public CharityCampaign Campaign { get; set; }
        public int Amount { get; set; }
        public DateTime DateProcessed { get; set; }
    }
}
