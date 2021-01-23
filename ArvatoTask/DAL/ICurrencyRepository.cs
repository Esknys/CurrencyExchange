using System;
using System.Threading.Tasks;
using ArvatoTask.Model;

namespace ArvatoTask.DAL
{
    public interface ICurrencyRepository
    {
        Task<bool> SaveCurrency(Currency inCurrency);
    }
}
