using Locator.Models.Request;
using Locator.Models.ViewModels;

namespace Locator.utility.IPGeolocationServices
{
    public interface IIpGeoLocationService
    {
        public Task<(GeoLocationModel? model, string? errorMessage)> GetIpDetails(IPQueryRequestModel iPQueryRequestModel);
    }
}
