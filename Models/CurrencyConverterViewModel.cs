namespace CorencyConvertor.Models;

public class CurrencyConverterViewModel
{
    public string FromCurrency { get; set; }
    public string ToCurrency { get; set; }
    public decimal Amount { get; set; }
    public decimal ConvertedAmount { get; set; }
    public Dictionary<string, decimal> AvailableRates { get; set; }
}