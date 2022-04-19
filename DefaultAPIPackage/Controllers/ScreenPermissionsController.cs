using DefaultAPIPackage.API.Models;
using DefaultAPIPackage.DTOs;
using DefaultAPIPackage.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefaultAPIPackage.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ScreenPermissionsController : ControllerBase
    {
        private readonly IModulePermission _modulePermission;
        public ScreenPermissionsController(IModulePermission modulePermission)
        {
            _modulePermission = modulePermission;
        }

        [HttpPost("GetModulePermissions")]
        public async Task<IEnumerable<GetModuleAccessModel>> GetModulePermissions([FromBody] CommonModel model)
        {
            return await _modulePermission.GetModulePermissions(model);
        }
    }
}
