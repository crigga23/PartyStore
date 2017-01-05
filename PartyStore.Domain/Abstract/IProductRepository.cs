using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PartyStore.Domain.Entities;

namespace PartyStore.Domain.Abstract
{
    public interface IProductRepository
    {
        IQueryable<Product> Products { get; }
    }
}
