using Polly;
using Polly.Extensions.Http;
using TravelApp.Flight.ExternalApis.SaberDev.ApiClients;
using TravelApp.Flight.FlightsQuery;
using TravelApp.Hotels.ExternalApis.SabreDev.Services;
using TravelApp.Hotels.HotelsQuery;

namespace TravelApp.InfraSetup
{
    public static class DependencyInjection
    {
        private static int MaxRetryCount = 3;
        public static void ConfigureServices(this IServiceCollection services)
        {
            RegisterSaberApiServices(services);

            services.AddHttpClient(ConfigConstants.SabreDevApiName, client =>
            {
                client.BaseAddress = new Uri("https://api.cert.platform.sabre.com/");
                client.Timeout = TimeSpan.FromSeconds(10);
            })
            .AddPolicyHandler(GetRetryPolicy())
            .AddPolicyHandler(GetCircuitBreakerPolicy());
        }

        private static void RegisterSaberApiServices(IServiceCollection services)
        {
            services.AddScoped<IFlightsQueryService, FlightsQueryService>();
            services.AddScoped<ISaberDevFlightsApiClient, SabreDevFlightsApiClient>();

            services.AddScoped<ISabreDevHotelsApiClient, SaberDevHotelsApiClient>();
            services.AddScoped<IHotelsQueryService, HotelsQueryService>();
        }

        private static IAsyncPolicy<HttpResponseMessage> GetRetryPolicy()
        {
            return HttpPolicyExtensions
                .HandleTransientHttpError()
                .WaitAndRetryAsync(3, retryAttempt => TimeSpan.FromSeconds(Math.Pow(1, MaxRetryCount)));
        }

        private static IAsyncPolicy<HttpResponseMessage> GetCircuitBreakerPolicy()
        {
            return HttpPolicyExtensions
                .HandleTransientHttpError()
                .CircuitBreakerAsync(5, TimeSpan.FromSeconds(30));
        }
    }
}
