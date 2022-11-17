using System.Threading.Tasks;

namespace DaprExample
{
    public interface IDaprEventBus
    {
        Task DoItAsync();
    }
}
