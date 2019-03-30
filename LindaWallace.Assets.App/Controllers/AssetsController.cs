using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LindaWallace.Assets.App.Models;
using LindaWallace.Assets.BLL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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
                   AssetTypeId = a.AssetTypeId,
                   Description = a.Description,
                   Manufacturer = a.Manufacturer,
                   SerialNumber = a.SerialNumber,
                   TagNumber = a.TagNumber





                   //Address = rp.Address,
                   //City = rp.City,
                   //Id = rp.Id,
                   //OwnerName = rp.Owner.Name,
                   //PostalCode = rp.PostalCode,
                   //PropertyStyle = rp.PropertyType.Style,
                   //Province = rp.Province,
                   //RentAmount = rp.Rent.ToString()
               }).ToList();

            //pass the model to the view
            return View(assets);
           
        }

        // GET: Asset/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Asset/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Asset/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Asset/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Asset/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Asset/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Asset/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}