using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_10_ErrorHandling.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class errorController : ControllerBase
    {  
        public IActionResult Error()
        {
            var _context = HttpContext.Features.Get<IExceptionHandlerFeature>();
            var stackTrace = _context.Error.StackTrace;
            var error = _context.Error.Message;

            return Problem();
        }
    }
}
