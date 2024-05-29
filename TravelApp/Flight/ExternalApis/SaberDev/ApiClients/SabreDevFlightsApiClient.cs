using Microsoft.Extensions.Options;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Web;
using TravelApp.Constants.Constants;
using TravelApp.Flight.ExternalApis.SaberDev.ApiDtos;
using TravelApp.Flight.ExternalApis.SaberDev.Mappers;
using TravelApp.Flight.FlightsQuery;
using TravelApp.InfraSetup.OptionsSetup;
using TravelApp.Shared;

namespace TravelApp.Flight.ExternalApis.SaberDev.ApiClients
{
    public class SabreDevFlightsApiClient : ISaberDevFlightsApiClient
    {
        private readonly HttpClient _saberDevHttpClient;

        public SabreDevFlightsApiClient(IHttpClientFactory httpClientFactory, IOptions<ApiToken> apiTokens)
        {
            _saberDevHttpClient = httpClientFactory.CreateClient(ConfigConstants.SabreDevApiName);
            _saberDevHttpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(
                AuthenticationConstants.Bearer, apiTokens.Value.SaberDevApi
            );
        }

        private static Uri BuildURI(string origin, string destination, DateTime departueDate, DateTime returnDate)
        {
            string relativePath = "v1/shop/flights";
            var query = HttpUtility.ParseQueryString(string.Empty);
            query["origin"] = origin;
            query["destination"] = destination;
            query["departuredate"] = departueDate.ToString("yyyy-MM-dd");
            query["returndate"] = returnDate.ToString("yyyy-MM-dd");
            Uri endpoint = new Uri($"{relativePath}?{query}", UriKind.Relative);
            return endpoint;
        }

        public async Task<Result<List<FlightsQueryResponse>?, BaseError>> GetSaberDevFlightQueryAsync(string origin, string destination, DateTime departueDate, DateTime returnDate)
        {
            try
            {
                Uri endpoint = BuildURI(origin, destination, departueDate, returnDate);

                var response = await _saberDevHttpClient.GetAsync(endpoint);


                if (response.IsSuccessStatusCode is false)
                {
                    throw new Exception("Some error occured, we are working on it");
                }

                var json = await response.Content.ReadAsStringAsync();
                var parsedRespone = JsonSerializer.Deserialize<SabreFlightApiResponse>(json);
                return FlightResponseMapper.MapToFlightsQueryResponse(parsedRespone);

            }
            catch (Exception ex)
            {
                return new BaseError("ErrorCallingAPI", "There was an error calling the api");
            }
        }
    }
}
