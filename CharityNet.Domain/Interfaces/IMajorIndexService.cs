using CharityNet.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharityNet.Domain.Interfaces
{
    public interface IMajorIndexService
    {
        Task<MajorIndex> GetMajorIndexAsync(MajorIndexType indexType);
    }
}
