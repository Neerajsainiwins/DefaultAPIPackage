using DefaultAPIPackage.API.Models;
using DefaultAPIPackage.DTOs;
using DefaultAPIPackage.Models.Entities;
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
    public class ScreensController : ControllerBase
    {
        private readonly DatabaseContext _dbContext;
        public ScreensController(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet("GetScreens")]
        public IEnumerable<Screen> GetScreens([FromQuery] GetScreens model)
        {
            IEnumerable<Screen> screens = new List<Screen>();
            if (model.IsSuperAdmin == true)
            {
                screens = _dbContext.Screens.ToList();
            }
            else
            {
                screens = (from ts in _dbContext.TenantScreens
                           join s in _dbContext.Screens on ts.ScreenId equals s.Id
                           where ts.TenantId == model.TenantId
                           select new Screen
                           {
                               Id = ts.ScreenId,
                               ScreenName = s.ScreenName
                           }).ToList();
            }
            return screens;
        }
    }
}
