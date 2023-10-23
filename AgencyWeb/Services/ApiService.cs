using AgencyWeb.Common;
using AgencyWeb.Common.Enums;
using AgencyWeb.Common.Utilities;
using AgencyWeb.Dtos.ApiResponse;
using AgencyWeb.Dtos.Configuration;
using AgencyWeb.Models;
using Microsoft.Extensions.Options;
using System.Net.Http;

namespace AgencyWeb.Services
{
    public class ApiService : IApiService
    {
        private readonly ApiConfig _apiConfig;
        private readonly IHttpClientService _httpClient;

        public ApiService(IHttpClientService httpClient, IOptionsMonitor<ApiConfig> optionsMonitor)
        {
            _apiConfig = optionsMonitor.CurrentValue;
            _httpClient = httpClient;
        }

        //public List<ChungLoaiDTO> GetListChungLoai()
        //{
        //    List<ChungLoaiDTO>? chungLoaiList = new List<ChungLoaiDTO>();
        //    HttpResponseMessage response = httpClient.GetAsync(httpClient.BaseAddress + "/chung-loai/doc-danh-sach").Result;

        //    if (response.IsSuccessStatusCode)
        //    {
        //        string data = response.Content.ReadAsStringAsync().Result;
        //        chungLoaiList = JsonConvert.DeserializeObject<List<ChungLoaiDTO>>(data);
        //    }

        //    return chungLoaiList;
        //}

        public List<SysRolesModel> GetRoleListApi()
        {
            return SampleData.roleList;
        }

        public List<UserTypeModel> GetUserTypeListApi()
        {
            return SampleData.userTypeList;
        }

        public List<SysUsersModelExt> GetUserListApi()
        {
            return SampleData.userList;
        }

        public List<SysRolesModel> GetRolesForUserApi()
        {
            return SampleData.roleListForUser;
        }

        public List<ProductModel> GetProductListApi()
        {
            return SampleData.productList;
        }

        public List<PayModeModel> GetPayModeListApi()
        {
            return SampleData.paymodeList;
        }

        public List<RiderModel> GetRiderListApi(int productId)
        {
            return SampleData.riderList.Where(w => w.ProductID == productId).ToList();
        }

        public List<CustomerModel> GetCustomerListApi()
        {
            return SampleData.customerList;
        }

        public List<NationalityModel> GetNationalityListApi()
        {
            return SampleData.nationalityList;
        }

        public List<QuotationModel> GetQuotationListApi()
        {
            return SampleData.quotationList;
        }

        public List<RiderByCustomerModel> GetRiderByCustomerListApi()
        {
            return SampleData.riderByCustomerList;
        }

        public List<QuotationInformationModel> GetQuotationInformationApi()
        {
            return SampleData.quotationInformationList;
        }

        public List<FinancialAnalysisModel> GetFinancialAnalysisListApi()
        {
            return SampleData.financialAnalysisList;
        }

        public List<FinancialPlanModel> GetFinancialPlanListApi()
        {
            return SampleData.financialPlanList;
        }

        public List<eApplicationModel> GeteApplicationListApi()
        {
            return SampleData.eAppList;
        }

        public List<GenderModel> GetGenderListApi()
        {
            return SampleData.genderList;
        }

        public List<MarriageStatusModel> GetMarriageStatusListApi()
        {
            return SampleData.marriageStatusList;
        }

        public List<CityProvinceModel> GetCityProvinceListApi()
        {
            return SampleData.cityList;
        }

        public List<CertiTypeModel> GetCertiTypeListApi()
        {
            return SampleData.certiTypeList;
        }

        public List<RelationshipModel> GetRelationListApi()
        {
            return SampleData.relationshipList;
        }

        public List<PolicyModel> GetPolicyListApi()
        {
            return SampleData.policyList;
        }

        public List<OrderPaymentByCustomerModel> GetOrderPaymentByCustomerListApi()
        {
            return SampleData.OrderPaymentByCustomerList;
        }

        public List<PaymentMethodModel> GetPaymentMethodListApi()
        {
            return SampleData.paymentMethodList;
        }

        public List<FinancialReportModel> GetFinancialConsultingListApi()
        {
            return SampleData.listFinalcialReport;
        }

        public List<DocumentModel> GetDocumentListApi()
        {
            return SampleData.listDocument;
        }

        public List<DocumenteAppModel> GetDocumenteAppListApi()
        {
            return SampleData.listDocumenteApp;
        }



        //AgencyWeb Portal

        public List<FrequentlyUsedFunctionModel> GetFrequentlyUsedFunctionListApi()
        {
            return SampleData.frequentlyUsedFunctionList;
        }


        public List<SchedulerModel> GetSchedulerListApi()
        {
            return SampleData.schedulerList;
        }

        public List<AgentModel> GetAgentListApi()
        {
            return SampleData.agentList;
        }

        public List<DocumentModel> GetDocumenteListApi()
        {
            return SampleData.listDocumentPersonal;
        }

        public List<CandidateModel> GetCandidateListApi()
        {
            return SampleData.listCandidate;
        }

        public async Task<List<SysMenusResponseModel>> GetMenuListApi(MenuSourceType type)
        {
            List<SysMenusResponseModel> response = null;
            int result = (int)ResponseCode.Error;
            var uriCore = String.Concat(_apiConfig.BaseAddress, UrlApiProvider.getMenuActive) + "/" + (int)type;

            (response, result) = await _httpClient.Get<List<SysMenusResponseModel>>(uriCore);

            return await Task.FromResult(response);
        }
    }
}
