﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CONTRAVI.API.Controllers
{
    [Route("api/Trip")]
    [ApiController]
    public class TripController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> CreateTrip()
        {
            return Ok();
        }
    }
}
