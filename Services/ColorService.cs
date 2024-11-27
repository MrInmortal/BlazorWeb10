using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Tarea10.Models;

namespace Tarea10.Services
{
    public class ColorService
    {
        private readonly HttpClient _http;

        public ColorService(HttpClient http)
        {
            _http = http;
        }

        public async Task<ColorData> GetColorDataAsync()
        {
            return await _http.GetFromJsonAsync<ColorData>("api/colorin") ?? new ColorData();
        }

        public async Task SaveColorDataAsync(ColorData data)
        {
            await _http.PostAsJsonAsync("api/colorin", data);
        }
    }
}
