using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharityNet.Domain.Models
{
    // Temporary class for easier API access. Will be substituted with Nonprofit / Fundraiser classes
    public enum MajorIndexType {  DowJones, Nasdaq, SP500 };
    public class MajorIndex
    {
        public double Price { get; set; }
        public double Changes { get; set; }
        public MajorIndexType Type { get; set; }
    }
}
