using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace LindaWallace.Assets.App.Models
{
    public class AssetTypesViewModel
    {
        [DisplayName("Asset Type ID")]
        public int Id { get; set; }

        [DisplayName("Asset Type")]
        public string TypeName { get; set; }
    }
}
