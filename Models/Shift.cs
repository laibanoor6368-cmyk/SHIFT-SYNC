using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shift_Sync.Models
{
    // To represent Shift table column
    internal class Shift
    {
        public int ShiftID { get; set; }
        public string EmployeeName { get; set; }
        public string ShiftType { get; set; } // Morning evening,off

        public string ShiftDate { get; set; }//yyyy-MM-DD
        public string status { get; set; } // Assigned,pending, swapped
    }
}
