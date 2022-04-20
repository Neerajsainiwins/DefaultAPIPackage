using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefaultAPIPackage.DTOs
{
    public class CommonModel : GetModuleAccessResponseModel
    {
        public int TenantId { get; set; }
    }

    public class AddModuleAccessModel
    {
        public int TenantId { get; set; }
        public string ScreenPermissions { get; set; }
    }
}
