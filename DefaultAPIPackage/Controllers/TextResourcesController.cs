using DefaultAPIPackage.API.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace DefaultAPIPackage.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TextResourcesController : ControllerBase
    {
        private readonly DatabaseContext _dbContext;
        public TextResourcesController(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet("GetTextResourceKeyValues")]
        public IEnumerable<TextResourceKeyValue> GetTextResourceKeyValues()
        {
            return _dbContext.TextResourceKeyValues.ToList();
        }
    }
}
