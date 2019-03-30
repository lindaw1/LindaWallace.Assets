using LindaWallace.Assets.Data;
using LindaWallace.Assets.Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LindaWallace.Assets.BLL
{
    public class AssetManager
    {

        
        public static List<Asset> GetAll()
        {
            var context = new AssetsContext();
            var assets = context.Assets.ToList();
            return assets;
        }

        public static void Add(Asset asset)
        {
            var context = new AssetsContext();
            context.Assets.Add(asset);
            context.SaveChanges();
        }

    }
}
