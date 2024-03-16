using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Helper
{
    public static class DataAccessConstants
    {
        //StoredProcedures Name
        public static string spUser_Get = "dbo.spUser_Get";
        public static string spUser_GetAll = "dbo.spUser_GetAll";
        public static string spUser_Insert = "dbo.spUser_Insert";
        public static string spUser_Update = "dbo.spUser_Update";
        public static string spUser_Delete = "dbo.spUser_Delete";
    }
}
