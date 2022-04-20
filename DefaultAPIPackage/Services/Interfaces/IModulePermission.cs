using DefaultAPIPackage.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefaultAPIPackage.Services
{
    public interface IModulePermission
    {
        GetModuleAccessResponseModel GetModulePermissions(int tenantId);
        Task<ResponseModel> AddModulePermissions(CommonModel model);
    }
}
