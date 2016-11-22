using Microsoft.ServiceFabric.Services.Remoting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASFRemotingCore
{
    public interface IASFRemotingTest : IService
    {
        Task<string> HighFive();
    }
}
