using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LindaWallace.Assets.Domain
{
    public class Asset
    {
        public int Id { get; set; }

        [Required]
        public string TagNumber { get; set; }

        public int AssetTypeId { get; set; }
        
        [Required]
        public string Manufacturer { get; set; }

        //optional
        public string Model { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string SerialNumber { get; set; }

    }
}
