using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharityNet.Domain.Models
{
    public class Root
    {
        public Data Data { get; set; }
    }

    public class Data
    {
        public Nonprofit Nonprofit { get; set; }
    }

    public class Nonprofit
    {
        public string Name { get; set; }
        public string LocationAddress { get; set; }
    }
}
