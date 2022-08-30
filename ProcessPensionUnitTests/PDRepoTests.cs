using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ProcessPensionService.Model;
using ProcessPensionService.Repo;

namespace ProcessPensionUnitTests
{
    internal class PDRepoTests
    {
        private ProcessPensionMicroservice _service = new ProcessPensionMicroservice();

        [SetUp]
        public void Setup() { }

        [Test]
        public async Task GetProcessPension_Success()
        {
            
            PensionerDetail pensionerDetail = new PensionerDetail();
            pensionerDetail.Aadhar = "871401014562";
            pensionerDetail.Name = "Abhinav Pathak";
            pensionerDetail.BankName = "KOTAK";
            pensionerDetail.AccountNumber = "11331313122121";
            pensionerDetail.BankType = (BankType)1;
            pensionerDetail.Allowances = 8524.00M;
            pensionerDetail.SalaryEarned = 28000.00m;
            pensionerDetail.PensionType = (PensionType)1;



            ProcessPension pension = await _service.GetProcessPension(pensionerDetail);

            Assert.AreEqual(pensionerDetail.Aadhar, pension.Aadhar);
        }
    }
}
