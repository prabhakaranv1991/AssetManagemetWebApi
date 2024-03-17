using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class TimeSheetModel
    {
        public int EmpId { get; set; }
        public DateTime LoginTime { get; set; }
        public DateTime LogoutTime { get; set;}
    }
}
