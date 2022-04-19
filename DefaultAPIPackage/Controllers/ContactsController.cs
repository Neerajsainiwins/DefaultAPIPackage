using DefaultAPIPackage.API.Models;
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
    public class ContactsController : ControllerBase
    {
        private readonly DatabaseContext _dbContext;
        public ContactsController(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet("ValidateRegisterEmail")]
        public bool ValidateRegisterEmail(string email)
        {
            var emailExist = _dbContext.CompanyInformations.Where(x => x.BusinessEmail == email).Count();
            if (emailExist > 0)
                return true;
            return false;
        }
    }
}
