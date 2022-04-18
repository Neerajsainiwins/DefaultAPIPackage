using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefaultAPIPackage.DTOs
{
    public class GetScreens
    {
        public bool IsSuperAdmin { get; set; }
        public int TenantId { get; set; }
    }
}
