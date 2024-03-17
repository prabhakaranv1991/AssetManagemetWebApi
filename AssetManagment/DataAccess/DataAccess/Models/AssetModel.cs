using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class AssetModel
    {
        public int AssetId { get; set; }
        public string AssetName { get; set; }
        public string AssetSerialNumber { get; set; }
        public int AssetOwner { get; set; }
        public int ApprovedBy { get; set; }
        public string AssetType { get; set; }
    }
}
