using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace RaisingIt.RecruitmentTest.Domain.Campaigns
{
    public class CampaignClient : ICampaignClient
    {
        public async Task<Campaign[]> ListCampaigns()
        {
            return await ClientHelpers.BaseUrl
                                .AppendPathSegment("campaigns")
                                .GetJsonAsync<Campaign[]>();
        }
    }
}