using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProcessPensionService.Model;
using ProcessPensionService.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace ProcessPensionService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ProcessPensionController : Controller
    {
        IProcessPensionMicroservice processPensionService;
        static HttpClient HttpClient = new HttpClient();
        static string BaseUrl = @"http://20.221.104.156/api/PensionerDetail/";
        private readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ProcessPensionController(IProcessPensionMicroservice processPensionService)
        {
            this.processPensionService = processPensionService;
        }

        [HttpPost]
        public async Task<ActionResult<ProcessPension>> GetProcessPensionDetail([FromBody]PensionerDetail inputpension)
        {
            try
            {
                PensionerDetail pensionerDetail = await HttpClient.GetFromJsonAsync<PensionerDetail>(BaseUrl + inputpension.Aadhar);
                ProcessPension pension = await processPensionService.GetProcessPension(pensionerDetail);
                log.Info("Got pensioner detail in process pension controller");
                return Ok(pension);
            }
            catch (Exception ex)
            {
                log.Info("not found");
                return NotFound(ex.Message);
            }
        }
    }
}
