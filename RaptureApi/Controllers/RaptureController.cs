using System;
using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using RaptureApi.Services;
using RaptureApi.ViewModels;

namespace RaptureApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RaptureController : ControllerBase
    { 
        private readonly IRaptureService service;
        private readonly IMapper mapper;

        public RaptureController(IRaptureService raptureService, IMapper autoMapper)
        {
            service = raptureService;
            mapper = autoMapper;
        }

        [HttpGet]
        [Route("[action]")]
        public ActionResult<IEnumerable<RaptureDetailsViewModel>> GetAllRaptures()
        {
            var allRaptures = service.GetAllRaptures();
            var viewModel = mapper.Map<IEnumerable<RaptureDetailsViewModel>>(allRaptures);
            return Ok(viewModel);
        }

        [HttpGet]
        [Route("[action]")]
        public ActionResult<IEnumerable<RaptureDetailsViewModel>> GetSurvivedRaptures(DateTime dateOfBirth)
        {
            var survivedRaptures = service.GetSurvivedRaptures(dateOfBirth);
            var viewModel = mapper.Map<IEnumerable<RaptureDetailsViewModel>>(survivedRaptures);
            return Ok(viewModel);
        }

        [HttpGet]
        [Route("[action]")]
        public ActionResult<RaptureDetailsViewModel> GetNextRapture()
        {
            var nextRapture = service.GetNextRapture();
            var viewModel = mapper.Map<RaptureDetailsViewModel>(nextRapture);
            return Ok(viewModel);
        }
    }
}
