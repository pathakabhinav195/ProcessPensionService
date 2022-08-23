using ProcessPensionService.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProcessPensionService.Repo
{
    public interface IProcessPensionMicroservice
    {
        Task<ProcessPension> GetProcessPension(PensionerDetail pensioner);
    }
}
