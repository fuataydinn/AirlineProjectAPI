using AirlineProject.Application.Interfaces.ServiceInterfaces;
using AirlineProject.Application.ViewModels.CampaingViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AirlineProject.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]s")]
    public class CampaingController : ControllerBase
    {
        private readonly ICampaingService _campaingService;

        public CampaingController(ICampaingService campaingService)
        {
            _campaingService = campaingService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _campaingService.GetAll());
        }


        [HttpGet("id")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await _campaingService.GetById(id));
        }
        [HttpPost]
        public IActionResult Create([FromBody] CampaingCommandViewModel model)
        {
            if (_campaingService.Create(model))
            {
                return Ok();
            }
            return BadRequest();
        }
        [HttpPut("id")]
        public IActionResult Update([FromBody] CampaingCommandViewModel model,int id)
        {
            if (_campaingService.Update(model,id))
            {
                return Ok();
            }
            return BadRequest();
        }
        [HttpDelete("id")]
        public IActionResult Delete(int id)
        {
            if (_campaingService.Delete(id))
            {
                return Ok();
            }
            return BadRequest();
        }
    }
}
