using Microsoft.AspNetCore.Mvc.Formatters.Internal;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SalesWebMvc.Models
{
    public class Seller
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public double BaseSalary { get; set; }
        public List<SalesRecord> list { get; set; } = new List<SalesRecord>();
        public Department Department { get; set; }
        public int DepartmentId { get; set; }

        public Seller()
        {
        }
        public Seller(int id, string name, string email, DateTime birthdate, double basesalary, Department department)
        {
            Id = id;
            Name = name;
            Email = email;
            BirthDate = birthdate;
            BaseSalary = basesalary;
            Department = department;
        }

        public void AddSales(SalesRecord salesrecord)
        {
            list.Add(salesrecord);
        }

        public void RemoveSales(SalesRecord salesrecord)
        {
            list.Remove(salesrecord);
        }

        public double TotalSales(DateTime initial, DateTime final)
        {
            return list.Where(lista => lista.Date >= initial && lista.Date <= final).Sum(lista => lista.Amount);
        }
    }
}
