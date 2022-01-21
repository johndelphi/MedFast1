
using MedFast1.Models;

namespace MedFast1.Repository;
public interface IShopRepository
{
    Task<List<ShopModel>> GetAllShopsAsync();
}
