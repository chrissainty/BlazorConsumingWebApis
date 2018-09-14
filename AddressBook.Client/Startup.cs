using Microsoft.AspNetCore.Blazor.Browser.Http;
using Microsoft.AspNetCore.Blazor.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace AddressBook.Client
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
        }

        public void Configure(IBlazorApplicationBuilder app)
        {
            BrowserHttpMessageHandler.DefaultCredentials = FetchCredentialsOption.Omit;

            app.AddComponent<App>("app");
        }
    }
}
