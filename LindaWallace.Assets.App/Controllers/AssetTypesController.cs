using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LindaWallace.Assets.App.Models;
using LindaWallace.Assets.BLL;
using LindaWallace.Assets.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LindaWallace.Assets.App.Controllers
{
    public class AssetTypesController : Controller
    {
        

        // GET: AssetTypes
        public ActionResult Index()
        {
            var assetTypes = AssetTypeManager.GetAll().
            Select(at => new AssetTypesViewModel
            {
                Id = at.Id,
                TypeName = at.Name,

            }).ToList();

            return View(assetTypes);
        }

 

        // GET: AssetTypes/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        //GET: AssetTypes/Create
        public ActionResult Create()
        {
          

            return View();
        }

        // POST: AssetTypes/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(AssetType assetType)
        {
            try
            {
                
                // call the Method to add an assetType - see AssetType manager class
                AssetTypeManager.Add(assetType);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        //// GET: AssetTypes/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: AssetTypes/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add update logic here

        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: AssetTypes/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: AssetTypes/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add delete logic here

        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}