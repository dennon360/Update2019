using System;

namespace SalesWebMvc.Models
{
    public class Seller
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Email { get; private set; }
        public DateTime BirthDate { get; private set; }
        public double BaseSalary { get; private set; }

    }
}
