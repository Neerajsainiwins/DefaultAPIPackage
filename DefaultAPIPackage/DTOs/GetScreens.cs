using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefaultAPIPackage.DTOs
{
    public class GetScreens
    {
        public bool IsOwner { get; set; }
        public int TenantId { get; set; }
    }
}
