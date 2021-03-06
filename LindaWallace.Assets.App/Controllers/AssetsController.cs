﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LindaWallace.Assets.App.Models;
using LindaWallace.Assets.BLL;
using LindaWallace.Assets.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace LindaWallace.Assets.App.Controllers
{
    public class AssetsController : Controller
    {
        // GET: Asset
        public ActionResult Index()
        {

            //get the model
            var assets = AssetManager.GetAll().
               Select(a => new AssetsViewModel
               {
                   AssetType = a.AssetType.Name,
                   Description = a.Description,
                   Manufacturer = a.Manufacturer,
                   Model = a.Model,
                   SerialNumber = a.SerialNumber,
                   TagNumber = a.TagNumber

               }).ToList();

            //pass the model to the view
            return View(assets);
           
        }

        // GET: Asset/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        // GET: Asset/Create
        public ActionResult Create()
        {
            //get Asset type from AssetTypeManager.  This will populate the dropdown list in the Create page
            var assetTypes = AssetTypeManager.GetAsKeyValuePairs();
            var list = new SelectList(assetTypes, "Id", "Name");
            ViewBag.AssetTypeId = list;


            return View();
        }

        // POST: Asset/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Asset asset)
        {
            try
            {
                // call the Method to add an asset - see Asset manager class
                AssetManager.Add(asset);          

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
 
        
        //// GET: Asset/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: Asset/Edit/5
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

        //// GET: Asset/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: Asset/Delete/5
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