using AutoMapper;
using Locator.Models.Request;
using Locator.Models.Response;
using Locator.Models.ViewModels;
using System.Net.Http.Json;

namespace Locator.utility.IPGeolocationServices
{
    public class IpGeoLocationService : IIpGeoLocationService
    {
        private readonly IHttpClientFactory _clientFactory;
        private readonly IMapper _mapper;

        public IpGeoLocationService(IHttpClientFactory clientFactory, IMapper mapper)
        {
            _clientFactory = clientFactory;
            _mapper = mapper;
        }
        public async Task<(GeoLocationModel? model, string? errorMessage)> GetIpDetails(IPQueryRequestModel iPQueryRequestModel)
        {
            try
            {
                var client = _clientFactory.CreateClient("ipgeolocation");
                string endpoint = Endpoint.GetIPDetails + $"?apiKey={iPQueryRequestModel.APIKey}&ip={iPQueryRequestModel.IP4Address}";

                var response = await client.GetAsync(endpoint);

                if (response.StatusCode == System.Net.HttpStatusCode.Locked) // Status code 423
                {
                    return (null, "The IP address is not public in internet");
                }

                response.EnsureSuccessStatusCode();
                var geoLocationResponse = await response.Content.ReadFromJsonAsync<GeoLocationResponse>();
                var geoLocationModel = _mapper.Map<GeoLocationModel>(geoLocationResponse);

                return (geoLocationModel, null);

            }
            catch (Exception ex) 
            {
                return (null, ex.Message);
            }

        }
    }
}
