using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace DonorDashboard.Common
{
    public class SessionController : ControllerBase
    {
        [HttpGet("/CheckSession")]
        public IActionResult CheckSession()
        {
            bool sessionExpired = HttpContext.Session.GetString("UserId") == null;
            bool sessionAboutToExpire = false; // You can implement logic to check if the session is about to expire

            // Return JSON response indicating session status
            return Ok(new { sessionExpired, sessionAboutToExpire });
        }
    }
}
