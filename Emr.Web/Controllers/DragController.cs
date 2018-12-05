using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Emr.Domain.Drags;
using Emr.Domain.Drags.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Emr.Web.Controllers
{
    [Route("api/drags")]
    [ApiController]
    [Authorize(Roles = "Admin")]
    public class DragController : Controller
    {
        private readonly IDragService _dragService;

        public DragController(IDragService dragService)
        {
            _dragService = dragService;
        }

        [HttpPost]
        public async Task<Guid> Create(DragInfo info)
        {
            return await _dragService.Create(info);
        }

        [HttpGet]
        public async Task<List<DragModel>> Get()
        {
            return await _dragService.Get();
        }

        [HttpDelete("{dragGuid}")]
        public async Task Delete(Guid dragGuid)
        {
            await _dragService.Delete(dragGuid);
        }
    }
}
