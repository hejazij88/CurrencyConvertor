# 💱 Currency Converter Web App (ASP.NET Core MVC)

A simple web-based currency converter built with ASP.NET Core MVC.  
It uses a public exchange rate API to convert amounts between different currencies.

---

## 🛠 Features

- Convert currency between any two supported currencies
- Fetch real-time exchange rates using a public API
- Clean and simple UI using Razor Views
- Built using modern ASP.NET Core MVC pattern

---

## 🚀 Technologies Used

- ASP.NET Core MVC (.NET 6+)
- HttpClient for API calls
- ExchangeRate-API (https://www.exchangerate-api.com)
- Razor View Engine
- Bootstrap (optional for styling)

---

## 📦 Setup Instructions

### 1. Clone the repository

```bash
git clone https://github.com/yourusername/currency-converter.git
cd currency-converter
2. Get an API Key
Go to https://www.exchangerate-api.com

Sign up and get a free API key

Replace YOUR_API_KEY in ExchangeRateService.cs with your actual key:

csharp
Copy
Edit
var response = await _httpClient.GetAsync("https://v6.exchangerate-api.com/v6/YOUR_API_KEY/latest/" + baseCurrency);
3. Run the project
bash
Copy
Edit
dotnet run
Then open your browser and go to:
👉 https://localhost:5001/Currency

📁 Project Structure
pgsql
Copy
Edit
CurrencyConverter/
├── Controllers/
│   └── CurrencyController.cs
├── Models/
│   ├── CurrencyConverterViewModel.cs
│   └── ExchangeRateResponse.cs
├── Services/
│   └── ExchangeRateService.cs
├── Views/
│   └── Currency/
│       └── Index.cshtml
├── Program.cs
└── README.md
🖼 Screenshot
Add a screenshot here of the form with sample conversion result.

⚠️ Disclaimer
This app is for educational purposes only. Exchange rates may not be accurate for financial use. Always verify data with official sources.
