using HR.LeaveManagement.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Domain
{
    public class LeaveRequest : BaseEntity
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public LeaveType? LeaveType { get; set; }
        public int LeaveTypeId { get; set; }
        public DateTime DateRequest { get; set; }
        public string? RequestComments { get; set; }
        public bool? Aproved { get; set; }
        public bool Cancelled { get; set; }
        public string? RequestingEmployeeId { get; set; }

    }
}
