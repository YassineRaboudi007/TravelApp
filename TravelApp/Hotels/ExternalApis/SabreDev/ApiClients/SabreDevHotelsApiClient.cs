using Microsoft.Extensions.Options;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Web;
using TravelApp.Constants.Constants;
using TravelApp.Flight.ExternalApis.SaberDev.Mappers;
using TravelApp.Flight.FlightsQuery;
using TravelApp.Hotels.ExternalApis.SabreDev.ApiDtos;
using TravelApp.Hotels.ExternalApis.SabreDev.Mappers;
using TravelApp.Hotels.HotelsQuery;
using TravelApp.InfraSetup.OptionsSetup;
using TravelApp.Shared;

namespace TravelApp.Hotels.ExternalApis.SabreDev.Services;

public class SaberDevHotelsApiClient : ISabreDevHotelsApiClient
{
    private readonly HttpClient _saberDevHttpClient;

    public SaberDevHotelsApiClient(IHttpClientFactory httpClientFactory, IOptions<ApiToken> apiTokens)
    {
        _saberDevHttpClient = httpClientFactory.CreateClient(ConfigConstants.SabreDevApiName);
        _saberDevHttpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(
            AuthenticationConstants.Bearer, apiTokens.Value.SaberDevApi
        );
    }

    public async Task<Result<SimplifiedHotelInfo, BaseError>> GetSabreHotelsSearchResultAsync(string airportCode, DateTime checkIn, DateTime checkOut)
    {
        string relativePath = "v5/get/hotelavail";
        SaberHotelsApiRequest request = new SaberHotelsApiRequest(airportCode, checkIn, checkOut);

        try
        {
            var response = await _saberDevHttpClient.PostAsJsonAsync(relativePath, request);

            if (response.IsSuccessStatusCode is false)
            {
                var y = await response.Content.ReadAsStringAsync();
                throw new Exception("Some error occured, we are working on it");
            }

            var json = await response.Content.ReadAsStringAsync();
            var parsedRespone = JsonSerializer.Deserialize<SaberHotelsApiResponse>(json);
            return SaberHotelsApiResponseMapper.MapToSimplifiedResponse(parsedRespone);

        }
        catch (Exception ex)
        {
            return new BaseError("ErrorCallingAPI", "There was an error calling the api");
        }
    }
}