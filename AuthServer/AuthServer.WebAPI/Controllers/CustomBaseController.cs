using CoreLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace AuthServer.WebAPI.Controllers
{
    public class CustomBaseController : ControllerBase
    {
      public IActionResult ActionResultInstance<T>(Response<T> response) where T : class
        {
            return new ObjectResult(response)
            {
                StatusCode = response.StatusCode,
            };
        }
    }
}
