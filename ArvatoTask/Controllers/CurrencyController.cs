using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ArvatoTask.DAL;
using ArvatoTask.Model;
using Microsoft.AspNetCore.Mvc;

namespace ArvatoTask.Controllers
{
    [Route("[controller]")]
    public class CurrencyController : ControllerBase
    {
        private readonly ICurrencyRepository _db;

        public CurrencyController(ICurrencyRepository db)
        {
            _db = db;
        }

        [Route("getEuroRate")]
        public double GetEuroRate()
        {
            var currency1 = new Currency();
            currency1.Name = "USD";
            currency1.RateEuro = 1.218895;
            currency1.Date = "2021-01-13";

            return currency1.RateEuro;
        }

        [Route("saveCurrency")]
        public async Task<ActionResult> SaveCurrency(Currency inCurrency)
        {

            bool result = await _db.SaveCurrency(inCurrency);

            if (!result)
            {
                Console.WriteLine("Could not add currency");
            }
            return Ok("Currency added");


        }

    }
}