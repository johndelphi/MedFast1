
using System.ComponentModel.DataAnnotations;

namespace MedFast1.Models;

public class MedicineModel
{

    public string Name { get; set; }

    public double Price { get; set; }

    public int Quantity { get; set; }

    public int Id { get; set; }

}
