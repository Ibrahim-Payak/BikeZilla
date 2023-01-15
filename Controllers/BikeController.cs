using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BikeZilla.AppDbContext;
using BikeZilla.Models;
using BikeZilla.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.IO; //various ip/op operation
using Microsoft.AspNetCore.Hosting.Internal; //contains a method, which access a physical path
using cloudscribe.Pagination.Models; //to pass pagination info along with bike object
using Microsoft.AspNetCore.Authorization;
using BikeZilla.Helper;

namespace BikeZilla.Controllers
{
    [Authorize(Roles = Roles.Admin +","+ Roles.Executive)]
    public class BikeController : Controller
    {
        public readonly BikeDbContext _db;
        public readonly HostingEnvironment hostingEnvironment;

        [BindProperty]
        public BikeViewModel BikeViewModel { get; set; }

        public BikeController(BikeDbContext db, HostingEnvironment hostingEnvironment)
        {
            _db = db;
            this.hostingEnvironment = hostingEnvironment;
            BikeViewModel = new BikeViewModel()
            {
                Makes = _db.Makes.ToList(),
                Models = _db.Models.ToList(),
                Bike = new Models.Bike()
            };
        }

        //ex Index method
        public IActionResult Index1()
        {
            //as we already have foregin key refrence to make in model entity, 
            //we can directly use eager loading to directly loading make in model

            var bikes = _db.Bikes.Include(m => m.Make).Include(m => m.Model); //to include all column of make and model table
            return View(bikes.ToList());
        }

        //use for pagination purpose
        [AllowAnonymous]
        public IActionResult Index(string searchString, string sortOrder, int pageNumber = 1, int pageSize = 3)
        {
            //to preserved current sort order
            ViewBag.currentSortOrder = sortOrder;

            //to keep search value present in search box
            ViewBag.currentSearch = searchString;
            //to toggle b/w two value
            ViewBag.sortOrderParam = String.IsNullOrEmpty(sortOrder) ? "price_desc" : "";
            int excludePage = (pageNumber * pageSize) - pageSize;
            var bikes = from d in _db.Bikes.Include(m => m.Make).Include(m => m.Model) //to include all column of make and model table
                        select d;

            var bikeCount = bikes.Count();
            //searching logic
            if (!String.IsNullOrEmpty(searchString))
            {
                bikes = bikes.Where(b => b.Make.Name.Contains(searchString) || b.Model.Name.Contains(searchString)); //filtering make and model
                             
                //change count according to result found
                bikeCount = bikes.Count();
            }


            //sorting logic
            switch (sortOrder)
            {
                case "price_desc":
                    bikes = bikes.OrderByDescending(m => m.Price);
                    break;
                default:
                    bikes = bikes.OrderBy(m => m.Price);
                    break;
            }

            //pagination logic
            bikes = bikes    
                .Skip(excludePage) //exlude earlier page record
                .Take(pageSize); //exclude later page record

            var result = new PagedResult<Bike>
            {
                //it doesn't track changes in object as we are including pagination info in bike object
                Data = bikes.AsNoTracking().ToList(),
                TotalItems = bikeCount,
                PageNumber = pageNumber,
                PageSize = pageSize
            };

            return View(result);
        }

        public IActionResult Create()
        {
            return View(BikeViewModel);
        }

        [HttpPost]
        public IActionResult Create(Bike bike)
        {
            if (!ModelState.IsValid)
            {
                //to not throwing error when nothing slect from dropdown and click on create button
                BikeViewModel.Makes = _db.Makes.ToList();
                BikeViewModel.Models = _db.Models.ToList();
                return View(BikeViewModel);
            }
            _db.Add(bike);
            //save image logic
            ImageUpload(bike);

            _db.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Edit(int id)
        {
            BikeViewModel.Bike = _db.Bikes.SingleOrDefault(m => m.Id == id);

            //to show model associated to make 
            BikeViewModel.Models = _db.Models.Where(m => m.MakeId == BikeViewModel.Bike.MakeId);

            if (BikeViewModel.Bike == null)
            {
                return NotFound();
            }
            return View(BikeViewModel);
        }

        //    we need to add below statement in view, since we are not maintaing id in controller
        //    <input hidden asp-for="Model.Id" />

        [HttpPost]
        public IActionResult Edit(Bike bike)
        {
            if (!ModelState.IsValid)
            {
                //to not throwing error when nothing slect from dropdown and click on create button
                BikeViewModel.Makes = _db.Makes.ToList();
                BikeViewModel.Models = _db.Models.ToList();
                return View(BikeViewModel);
            }
            _db.Update(bike);
            //save image logic
            ImageUpload(bike);

            _db.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            var bike = _db.Bikes.Find(id);
            if (bike == null)
            {
                return NotFound();
            }
            _db.Remove(bike);
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        private void ImageUpload(Bike bike)
        {
            //Save Bike Image Logic//
            //we are writing save image logic after save changes so we can get Id of this record from db
            //get the bike id for which we are uploading Image from database
            var bikeId = bike.Id;

            //get wwwrootpath to save file on server
            var wwwrootpath = hostingEnvironment.WebRootPath;

            //get reference of DBSet for bike we just saved in database
            var savedBike = _db.Bikes.Find(bikeId);

            //get uploaded file
            var file = HttpContext.Request.Form.Files;

            //upload file on server and save image path of user uploaded file
            if (file.Count != 0)
            {
                //image path, where we are uploading our image
                var imagePath = @"images\bike\";
                //get extension of file
                var extension = Path.GetExtension(file[0].FileName);
                //save in database
                var relativePath = imagePath + bikeId + extension;
                //physical path on server
                var absolutePath = Path.Combine(wwwrootpath, relativePath);

                //using Stream class we can upload received file on server
                using (var fileStream = new FileStream(absolutePath, FileMode.Create))
                {
                    file[0].CopyTo(fileStream);
                }

                //save image path to database
                savedBike.ImagePath = relativePath;
            }
        }

        public IActionResult View(int id)
        {
            BikeViewModel.Bike = _db.Bikes.SingleOrDefault(m => m.Id == id);            

            if (BikeViewModel.Bike == null)
            {
                return NotFound();
            }
            return View(BikeViewModel);
        }
    }
}