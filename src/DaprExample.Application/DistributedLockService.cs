using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;
using Volo.Abp.DistributedLocking;

namespace DaprExample
{
    public class DistributedLockService : ITransientDependency
    {
        private readonly IAbpDistributedLock _distributedLock;

        public DistributedLockService(IAbpDistributedLock distributedLock)
        {
            _distributedLock = distributedLock;
        }

        public async Task MyMethodAsync()
        {
            await using var handle =
                         await _distributedLock.TryAcquireAsync("MyLockName");
            if (handle != null)
            {
                // your code that access the shared resource
            }
        }
    }
}
