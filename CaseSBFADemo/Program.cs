using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Hosting;

namespace CaseSBFADemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FunctionsDebugger.Enable();

            var host = new HostBuilder()
                .ConfigureFunctionsWorkerDefaults()
                .Build();

            host.Run();
        }
    }
}
