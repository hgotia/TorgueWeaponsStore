using System.Linq;

namespace Pistols.Models
{
    public interface IStoreRepository
    {
        IQueryable<Product> Products { get; }
    }
}