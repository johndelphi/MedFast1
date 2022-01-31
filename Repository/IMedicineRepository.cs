
using MedFast1.Models;

namespace MedFast1.Repository;
public class IMedicineRepository
{
 public  Task<List<MedicineModel>> GetAllDrugsAsync();
}
