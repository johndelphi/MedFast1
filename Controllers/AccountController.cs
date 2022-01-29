using MedFast1.Repository;
using Microsoft.AspNetCore.Mvc;

namespace MedFast1.Controllers;
[Route("api/[controller]")]
[ApiController]
public class AccountController : ControllerBase
{
  private readonly IAccountRepostory _accountRepository;

  public AccountController(IAccountRepostory accountRepository)
  {
    _accountRepository = accountRepository;
  }
}
