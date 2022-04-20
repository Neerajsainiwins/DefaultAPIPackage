using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefaultAPIPackage.DTOs
{
    public class GetModuleAccessModel
    {
        public string ScreenPermissions { get; set; }
    }
    public class GetModuleAccessResponseModel
    {
        public List<ScreenPermission> ScreenPermissions { get; set; }
    }

    public class ScreenPermission
    {
        public int ScreenId { get; set; }
        public string ScreenName { get; set; }
        public bool IsAccessible { get; set; }
    }

    public class ModuleAccessRequestModel
    {
        public int TenantId { get; set; }
        public string ScreenPermissions { get; set; }
    }
}
