﻿using DiazPC02.DOMAIN.Core.Entities;

namespace DiazPC02.DOMAIN.Core.Interfaces
{
    public interface ISupplierRepository
    {
        Task<bool> Delete(int id);
        Task<Supplier> GetSupplier(int id);
        Task<IEnumerable<Supplier>> GetSupplierByCountry(string country);
        Task<IEnumerable<Supplier>> GetSuppliers();
        Task<bool> Insert(Supplier supplier);
        Task<bool> Update(Supplier supplier);
    }
}