using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class Charges
    {
        public int ChargeId{ get; set; }
        public int CaseNo { get; set; }
        public string CaseDescription { get; set; }
        public string EmployerWit { get; set; }
        public string EmployeeWit { get; set; }
        public string Verdict { get; set; }
        public string Sanction { get; set; }
        public string Validation { get; set; }
        public string Status { get; set; }
    }
}
