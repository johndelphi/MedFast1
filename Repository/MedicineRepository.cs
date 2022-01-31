
using MedFast.Data;
using MedFast1.Models;
using Microsoft.EntityFrameworkCore;

namespace MedFast1.Repository;
public class MedicineRepository:IMedicineRepository
{
  private readonly ShopContext _medContext;
  public MedicineRepository(ShopContext shopContext )
  {
    _medContext = shopContext;
  }
  public async Task<List<MedicineModel>> GetAllDrugsAsync()
  {
    var records = await _medContext.Medicines.Select(m => new MedicineModel
    {
      Id = m.Id,
      Name = m.name,
      Price = m.Price
    }).ToListAsync();
    return records;
    
  }
}
