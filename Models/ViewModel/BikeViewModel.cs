﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BikeZilla.Models.ViewModel
{
    public class BikeViewModel
    {
        public Bike Bike { get; set; }
        public IEnumerable<Make> Makes { get; set; }
        public IEnumerable<Model> Models { get; set; }
        public IEnumerable<Currency> Currencies { get; set; }

        private List<Currency> currencyList = new List<Currency>();

        private List<Currency> createList()
        {
            currencyList.Add(new Currency("IND", "IND"));
            currencyList.Add(new Currency("DOL", "DOL"));
            currencyList.Add(new Currency("EUR", "EUR"));
            return currencyList;
        }

        public BikeViewModel()
        {
            Currencies = createList();

        }
    }

    public class Currency
    {
        public String Id { get; set; }
        public String Name { get; set; }

        public Currency(String id, String name)
        {
            Id = id;
            Name = name;
        }
    }
}
