﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace SalesWebMvc.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Seller> Sellers { get; set; } = new List<Seller>();

        public Department()
        {

        }

        //public Department(int id, string name)
        //{
        //    Id = id;
        //    Name = name;
        //}

        public Department(string name)
        {
            //Id = id;
            Name = name;
        }

        public void AddSeller(Seller seller)
        {
            Sellers.Add(seller);
        }

        public double TotalSales(DateTime initial, DateTime final)
        {
            // pega a soma por vendedor, e soma o departamento inteiro
            return Sellers.Sum(seller => seller.TotalSales(initial, final));
        }

    }
}
