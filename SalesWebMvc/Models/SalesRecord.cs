using System;

namespace SalesWebMvc.Models
{
    public class SalesRecord
    {
        public int Id { get; private set; }
        public DateTime Date { get; private set; }
        public double Amount { get; private set; }
    }
}
