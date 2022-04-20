using Dapper;
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

        public async Task<ResponseModel> AddModulePermissions(CommonModel model)
        {
            AddModuleAccessModel requestModel = new AddModuleAccessModel();
            requestModel.TenantId = model.TenantId;
            requestModel.ScreenPermissions = JsonConvert.SerializeObject(model.ScreenPermissions);
            return await CommandAsync<ResponseModel>("sp_AddModulePermissions", requestModel);
        }

        public GetModuleAccessResponseModel GetModulePermissions(int tenantId)
        {
            GetModuleAccessResponseModel response = new GetModuleAccessResponseModel();
            var result = new List<ScreenPermission>();
            var param = new DynamicParameters();
            param.Add("@TenantId", tenantId);
            var res = CollectionsAsync<GetModuleAccessModel>("sp_GetModulePermissions", param).Result.ToList();
            var data = res[0].ScreenPermissions;
            if (data != null)
                result = JsonConvert.DeserializeObject<List<ScreenPermission>>(data);
            response.ScreenPermissions = result;
            return response; 
        }
    }
}
