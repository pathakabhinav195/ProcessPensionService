using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessPensionService.Model
{
    public class PensionerDetail
    {
        public String Aadhar { get; set; }
        public String Name { get; set; }
        public DateTime DOB { get; set; }
        public String PAN { get; set; }
        public decimal SalaryEarned { get; set; }
        public decimal Allowances { get; set; }
        public PensionType PensionType { get; set; }
        public String BankName { get; set; }
        public String AccountNumber { get; set; }
        public BankType BankType { get; set; }

    }
}
