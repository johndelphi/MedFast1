
using MedFast.Data;
using MedFast1.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace MedFast1.Repository;
public class ShopRepository : IShopRepository
{
    private readonly ShopContext _context;

    public ShopRepository(ShopContext context)
    {
        _context = context;
    }
    public async Task<List <ShopModel>> GetAllShopsAsync()
    {
        //logic to read from our database
        var records = await _context.Shop.Select(X => new ShopModel()
        {
            Id = X.Id,
            name = X.name,
            location = X.location,
            town = X.town,
            locationDescription = X.locationDescription,
            Image = X.Image



        }).ToListAsync();
        return records;

    }
}