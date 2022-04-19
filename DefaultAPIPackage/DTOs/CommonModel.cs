using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefaultAPIPackage.DTOs
{
    public class CommonModel : GetModuleAccessModel
    {
        public int TenantId { get; set; }
    }
}
