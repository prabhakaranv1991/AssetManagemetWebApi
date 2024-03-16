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

        #region Users
        public static string spUser_Get = "dbo.spUser_Get";
        public static string spUser_GetAll = "dbo.spUser_GetAll";
        public static string spUser_Insert = "dbo.spUser_Insert";
        public static string spUser_Update = "dbo.spUser_Update";
        public static string spUser_Delete = "dbo.spUser_Delete";
        #endregion

        #region Roles
        public static string spRole_Get = "dbo.spRole_Get";
        public static string spRole_GetAll = "dbo.spRole_GetAll";
        public static string spRole_Insert = "dbo.spRole_Insert";
        public static string spRole_Update = "dbo.spRole_Update";
        public static string spRole_Delete = "dbo.spRole_Delete";
        #endregion
    }
}
