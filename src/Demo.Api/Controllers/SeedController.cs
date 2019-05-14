using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Demo.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SeedController : ControllerBase
    {
        private readonly IDocumentoService _documentService;

        public SeedController(IDocumentoService documentService)
        {
            _documentService = documentService;
        }

        [HttpGet]
        public async Task<IActionResult> Seed()
        {
            try
            {
                await _documentService.SeedAsync();
                return Ok("Documentos indexados com sucesso!");
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}