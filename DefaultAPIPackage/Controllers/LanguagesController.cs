using DefaultAPIPackage.API.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace DefaultAPIPackage.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LanguagesController : ControllerBase
    {
        private readonly DatabaseContext _dbContext;
        public LanguagesController(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet("GetLanguages")]
        public IEnumerable<Language> GetLanguages()
        {
            return _dbContext.Languages.ToList();
        }
    }
}
