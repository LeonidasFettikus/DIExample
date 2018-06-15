using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace WebApplication2
{
    public class ClientService : HostedService
    {
        private CacheService _cache;

        public ClientService(CacheService cache)
        {
            _cache = cache;
        }
        protected override Task ExecuteAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
