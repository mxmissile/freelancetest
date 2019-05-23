using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace Tests.TestingStuff
{
    public class TestDependencyResolver
    {
        private readonly IWebHost _webHost;

        public TestDependencyResolver(IWebHost webHost) => _webHost = webHost;

        public T GetService<T>()
        {
            using (var serviceScope = _webHost.Services.CreateScope())
            {
                var services = serviceScope.ServiceProvider;

                var scopedService = services.GetRequiredService<T>();
                return scopedService;
            }
        }
    }
}
