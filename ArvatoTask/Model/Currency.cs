using System;
using System.ComponentModel.DataAnnotations;

namespace ArvatoTask.Model
{
    public class Currency
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public double RateEuro { get; set; }
        public string Date { get; set; }
    }
}
