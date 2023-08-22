using System;
using System.Collections.Generic;
using System.Linq;

namespace SalesWebMvc.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Seller> list { get; set; } = new List<Seller>();

        public Department()
        {
        }
        public Department(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public void AddSeller(Seller seller)
        {
            list.Add(seller);
        }

        public double TotalSales(DateTime initial, DateTime final)
        {
            return list.Sum(seller => seller.TotalSales(initial, final));
        }
    }
}
