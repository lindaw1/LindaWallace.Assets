using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LindaWallace.Assets.App.Models
{
    public class AssetsViewModel
    {
        public int Id { get; set; }

        [Required, DisplayName("Tag #")]
        public string TagNumber { get; set; }

        [DisplayName("Asset Type")]
        public string AssetType { get; set; }

        [Required]
        public string Manufacturer { get; set; }

        //optional
        public string Model { get; set; }

        [Required]
        public string Description { get; set; }

        [Required, DisplayName("Serial Number")]
        public string SerialNumber { get; set; }
        
        
    }
}
