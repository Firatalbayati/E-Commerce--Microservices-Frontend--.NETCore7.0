using ECommerce.Shared.Dtos;
using ECommerceMicroservicesFrontend.Models.Discounts;
using ECommerceMicroservicesFrontend.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace ECommerceMicroservicesFrontend.Services
{
    public class DiscountService : IDiscountService
    {
        private readonly HttpClient _httpClient;

        public DiscountService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<DiscountViewModel> GetDiscount(string discountCode)
        {

            var response = await _httpClient.GetAsync($"discounts/GetByCode?code={discountCode}");

            if (!response.IsSuccessStatusCode)
                return null;

            var discount = await response.Content.ReadFromJsonAsync<Response<DiscountViewModel>>();

            return discount.Data;
        }
    }
}
