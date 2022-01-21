using MedFast1.Repository;
using Microsoft.AspNetCore.Mvc;

namespace MedFast1.Controllers;
public class ShopsController : Controller
{
    private readonly IShopRepository _shopRepository;

    public ShopsController(IShopRepository shopRepository)
    {
        _shopRepository = shopRepository;
    }
    [HttpGet("")]
    public async Task<IActionResult> GetAllshops()
    {
        var shops = await _shopRepository.GetAllShopsAsync();
        return Ok(shops);
    }
}
