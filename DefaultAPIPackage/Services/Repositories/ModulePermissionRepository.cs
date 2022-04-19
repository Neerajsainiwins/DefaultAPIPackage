using DefaultAPIPackage.API.Models;
using DefaultAPIPackage.Dapper;
using DefaultAPIPackage.DTOs;
using DefaultAPIPackage.Models.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefaultAPIPackage.Services
{
    public class ModulePermissionRepository : GenericRepository<Screen>, IModulePermission
    {
        private readonly DatabaseContext _dbContext;
        public ModulePermissionRepository(DatabaseContext dbContext) : base (dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<IEnumerable<GetModuleAccessModel>> GetModulePermissions(CommonModel model)
        {
            ModuleAccessRequestModel requestModel = new ModuleAccessRequestModel();
            requestModel.TenantId = model.TenantId;
            requestModel.ScreenPermissions = JsonConvert.SerializeObject(model.ScreenPermissions);
            var result = await CollectionsAsync<GetModuleAccessModel>("sp_GetModulePermissions", requestModel);
            return result; 
        }
    }
}
