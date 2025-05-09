using CorencyConvertor.Models;
using CorencyConvertor.Services;
using Microsoft.AspNetCore.Mvc;

namespace CorencyConvertor.Controllers
{
    public class CurrencyController : Controller
    {

        private readonly ExchangeRateServices _exchangeRateServices;

        public CurrencyController(ExchangeRateServices exchangeRateServices)
        {
            _exchangeRateServices = exchangeRateServices;
        }


        public async Task<IActionResult> Index()
        {
            var data = await _exchangeRateServices.GetRateAsync("USD");

            var model = new CurrencyConverterViewModel
            {
                FromCurrency = "USD",
                ToCurrency = "EUR",
                Amount = 1,
                AvailableRates = data.conversion_rates
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Index(CurrencyConverterViewModel model)
        {
            var data = await _exchangeRateServices.GetRateAsync(model.FromCurrency);

            model.AvailableRates = data.conversion_rates;

            if (data.conversion_rates.TryGetValue(model.ToCurrency, out decimal rate))
            {
                model.ConvertedAmount = model.Amount * rate;
            }

            return View(model);
        }
    }
}
