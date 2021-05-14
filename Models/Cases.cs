using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class Cases
    {
        public int CaseNo { get; set; }
        public string Chairman { get; set; }
        public string DateOfSitting { get; set; }
        public string Department { get; set; }
        public string EmployerRep { get; set; }
        public string EmployeeRep { get; set; }
        public string NotesFileName { get; set; }
        public string JobTitle { get; set; }
        public string Status { get; set; }
    }
}
