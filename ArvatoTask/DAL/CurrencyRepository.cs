using System;
using System.Threading.Tasks;
using ArvatoTask.Model;

namespace ArvatoTask.DAL
{
    public class CurrencyRepository : ICurrencyRepository
    {

        private readonly CurrencyContext _db;

        public CurrencyRepository(CurrencyContext db)
        {
            _db = db;
        }

        public double GetEuroRate()
        {
            var currency1 = new Currency();
            currency1.Name = "USD";
            currency1.RateEuro = 1.218895;
            currency1.Date = "2021-01-13";

            return currency1.RateEuro;
        }

        public async Task<bool> SaveCurrency(Currency inCurrency)
        {
            try
            {
                var newCurrencyRow = new Currencies();
                newCurrencyRow.Id = inCurrency.Id;
                newCurrencyRow.Name = inCurrency.Name;
                newCurrencyRow.RateEuro = inCurrency.RateEuro;
                newCurrencyRow.Date = inCurrency.Date;

                _db.Currencies.Add(newCurrencyRow);
                await _db.SaveChangesAsync();
                return true;
            
            } catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }

        }

    }
}

