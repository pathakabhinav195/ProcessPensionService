using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ProcessPensionService.Model
{
    public class ProcessPension
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int uid { get; set; }
        public string Aadhar { get; set; }
        public decimal PensionAmount { get; set; }
        public decimal BankServiceCharge { get; set; }

    }
}
