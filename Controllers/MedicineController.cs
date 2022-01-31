using MedFast1.Repository;
using Microsoft.AspNetCore.Mvc;

namespace MedFast1.Controllers;
[Route("api/[controller]")]
[ApiController]
public class MedicineController : ControllerBase
{
  private readonly IMedicineRepository _medecineRepository;
  public MedicineController(IMedicineRepository medicinerepository)
  {
    _medecineRepository = medicinerepository;
  }
  [HttpGet]
    public async Task<IActionResult> GetAllDrugs()
  {
    var drugs = await _medecineRepository.GetAllDrugsAsync();
    return Ok(drugs);
  }
}