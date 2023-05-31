using Core.Model.CoreEntity;
using GPT.ApplicationService.GPTProduct;
using GPT.ApplicationService.Interfaces;
using GPT.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace GPT.Controllers
{
    //[Authorize(Roles = UserRoles.Admin)]
    [Route("api/[controller]")]
    [ApiController]
    public class GptController : ControllerBase
    {

        private readonly IGPTProductService _adProduct;
        public GptController(IGPTProductService adProduct)
        {
            _adProduct = adProduct;
        }

        [HttpPost("ExtractDataGptTurbo")]
        [Authorize]
        //  [AuthorizeByApiKey]
        public async Task<ActionResult<GPTProductResponseModel>> GenerateContentGptTurbo([FromBody] List<GPTMessage> aDGenerateRequestModel)
        {
            try
            {

                var response = await _adProduct.GenerateContentGptTurbo(aDGenerateRequestModel);

                return response;
            }
            catch (System.Exception ex)
            {

                return null;
            }

        }

        [HttpPost("ExtractDataGpt4")]
        [Authorize]
        //[AuthorizeByApiKey]
        public async Task<ActionResult<GPTProductResponseModel>> GenerateContentGpt4([FromBody] List<GPTMessage> aDGenerateRequestModel)
        {
            try
            {

                var response = await _adProduct.GenerateContentGpt4(aDGenerateRequestModel);

                return response;
            }
            catch (System.Exception ex)
            {

                return null;
            }

        }

        [HttpPost("ExtractDataDavinci")]
        [Authorize]
        // [AuthorizeByApiKey]
        public async Task<ActionResult<GPTProductResponseModel>> GenerateContentDaVinci([FromBody] CustomerRequestModel aDGenerateRequestModel)
        {
            try
            {

                var response = await _adProduct.GenerateContentDaVinci(aDGenerateRequestModel);

                return response;
            }
            catch (System.Exception ex)
            {

                return null;
            }

        }

    }
}
