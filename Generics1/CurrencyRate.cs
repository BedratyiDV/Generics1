using Generics1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class CurrencyRate<T>: CurrencyRateBase<T> where T : struct
    {
        public string Currency { get; set; }

        
        private List<CurrencyRateBase<T>> _changeHistory;

        public CurrencyRate(string currency, T buy, T sell)
        {
            Currency = currency;
            Buy = buy;
            Sell = sell;
            _changeHistory = new List<CurrencyRateBase<T>>();
            var newCurrencyRate = new CurrencyRateBase<T>();
            newCurrencyRate.Buy = Buy;
            newCurrencyRate.Sell = Sell;
            _changeHistory.Add(newCurrencyRate);

        }

        public void ChangeRate(T newBuy, T newSell)

        {
            Buy = newBuy;
            Sell = newSell;
            Console.WriteLine($"New {Currency} course values: Buy: {Buy} Sell: {Sell}");
            var newCurrencyRate = new CurrencyRateBase<T>();
            newCurrencyRate.Buy = Buy;
            newCurrencyRate.Sell = Sell;
            _changeHistory.Add(newCurrencyRate);
        }
        public void PrintHistory()
        {
            Console.WriteLine("Currency rate change history:");

            foreach (CurrencyRateBase<T> currency in _changeHistory)

            {
                Console.WriteLine($"{this.Currency}: Buy: {currency.Buy} Sell: {currency.Sell}");
            }


        }
    }
}
