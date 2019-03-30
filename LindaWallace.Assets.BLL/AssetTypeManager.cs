using LindaWallace.Assets.Data;
using LindaWallace.Assets.Domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LindaWallace.Assets.BLL
{
    public class AssetTypeManager
    {
        public static void Add(AssetType assetType)
        {
            var context = new AssetsContext();
            context.AssetTypes.Add(assetType);
            context.SaveChanges();
        }
        public static List<AssetType> GetAll()
        {
            var context = new AssetsContext();
            var assetTypes = context.AssetTypes.ToList();
            return assetTypes;
        }
        public static IList GetAsKeyValuePairs()
        {
            var context = new AssetsContext();
            var types = context.AssetTypes.Select(at => new
            {
                at.Id,
                at.Name
            }).ToList();
            return types;
    
        }
    }
}
