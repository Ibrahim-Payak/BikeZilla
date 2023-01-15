using BikeZilla.AppDbContext;
using BikeZilla.Helper;
using BikeZilla.Models;
using cloudscribe.Pagination.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BikeZilla.Controllers
{
    [Authorize(Roles = Roles.Admin + "," + Roles.Executive)]
    public class MakeController : Controller /*Controller provide lot of helper class like JSON(), View(), File(), Content()*/
    {

        private readonly BikeDbContext _db;

        public MakeController(BikeDbContext db)
        {
            _db = db;
        }

        //CRUD operation
        public IActionResult Index1()
        {
            return View(_db.Makes.ToList()); /*as we are sending all list of makes*/
        }

        //use for pagination purpose
        public IActionResult Index(int pageNumber = 1, int pageSize = 1)
        {
            int excludePage = (pageNumber * pageSize) - pageSize;
            var makes = _db.Makes
                        .Skip(excludePage) //exlude earlier page record
                        .Take(pageSize); //exclude later page record

            var result = new PagedResult<Make>
            {
                //it doesn't track changes in object as we are including pagination info in bike object
                Data = makes.AsNoTracking().ToList(),
                TotalItems = _db.Makes.Count(),
                PageNumber = pageNumber,
                PageSize = pageSize
            };

            return View(result);
        }

        //get method
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Make make)
        {
            if (ModelState.IsValid)
            {
                _db.Add(make);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index)); //return to index page if valid
            }

            return View(make); //return create view, if not valid
        }

        //GET Method
        //public IActionResult Delete(int id)
        //{
        //    var make = _db.Makes.Find(id);
        //    if(make == null)
        //    {
        //        return NotFound();
        //    }

        //    _db.Remove(make);
        //    _db.SaveChanges();
        //    return RedirectToAction(nameof(Index));
        //}

        [HttpPost]
        public IActionResult Delete(int id)
        {
            var make = _db.Makes.Find(id);
            if(make == null)
            {
                return NotFound();
            }

            _db.Remove(make);
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        //2 Edit method: 
        //1) Get: retreive record when user click 
        //2) Post: update record

        public IActionResult Edit(int id)
        {
            Make make = _db.Makes.Find(id);
            if(make == null)
            {
                return NotFound();
            }
            return View(make);
        }

        [HttpPost]
        public IActionResult Edit(Make make)
        {
            if (ModelState.IsValid)
            {
                _db.Update(make);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(make);
        }
    }
}
