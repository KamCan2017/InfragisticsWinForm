﻿using Domain.Database;
using Domain.Database.Interfaces;
using Domain.Database.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Suppliers.Logic
{
    public class SuppplierLogic
    {
        private readonly ISupplierRepository _supplierRepository;

        public SuppplierLogic()
        {
            _supplierRepository = new SupplierRepository();
        }

        public async Task<IEnumerable<Supplier>> LoadSuppliers()
        {
            return await _supplierRepository.FindAllAsync();
        }
    }
}
