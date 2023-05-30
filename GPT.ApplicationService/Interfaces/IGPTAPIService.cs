using Core.Model.CoreEntity;
using GPT.ApplicationService.GPTProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPT.ApplicationService.Interfaces
{
    public interface IGPTAPIService
    {
        Task<List<string>> GenerateContentDaVinciAPI(GPTGenerateRequestModelDTO generateRequestModel);
        Task<List<string>> GenerateContentGptTurboAPI(List<GPTMessage> generateRequestModel);

        Task<List<string>> GenerateContentGpt4API(List<GPTMessage> generateRequestModel);
    }
}
