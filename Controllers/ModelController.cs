using AutoMapper;
using BikeZilla.AppDbContext;
using BikeZilla.Controllers.Resources;
using BikeZilla.Helper;
using BikeZilla.Models;
using BikeZilla.Models.ViewModel;
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
    [Authorize(Roles = Roles.Admin+ "," +Roles.Executive)]
    public class ModelController : Controller
    {
        private readonly BikeDbContext _db;
        private readonly IMapper _mapper;

        [BindProperty]
        public ModelViewModel modelViewModel { get; set; }

        public ModelController(BikeDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
            modelViewModel = new ModelViewModel()
            {
                Makes = _db.Makes.ToList(),
                Model = new Models.Model()
            };
        }
        public IActionResult Index1()
        {
            //as we already have foregin key refrence to make in model entity, 
            //we can directly use eager loading to directly loading make in model

            var model = _db.Models.Include(m => m.Make); //to include all column of make table
            return View(model);
        }

        //use for pagination purpose
        public IActionResult Index(int pageNumber = 1, int pageSize = 1)
        {
            int excludePage = (pageNumber * pageSize) - pageSize;
            var models = _db.Models.Include(m => m.Make)
                        .Skip(excludePage) //exlude earlier page record
                        .Take(pageSize); //exclude later page record

            var result = new PagedResult<Model>
            {
                //it doesn't track changes in object as we are including pagination info in bike object
                Data = models.AsNoTracking().ToList(),
                TotalItems = _db.Makes.Count(),
                PageNumber = pageNumber,
                PageSize = pageSize
            };

            return View(result);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View(modelViewModel);
        }

        [HttpPost]
        public IActionResult Create(Model model)
        {
            if (ModelState.IsValid)
            {
                _db.Add(model);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(modelViewModel);
        }


        public IActionResult Edit(int id)
        {
            modelViewModel.Model = _db.Models.Include(m => m.Make).SingleOrDefault(m => m.Id == id);
            if(modelViewModel.Model == null)
            {
                return NotFound();
            }
            return View(modelViewModel);
        }

        //    we need to add below statement in view, since we are not maintaing id in controller
        //    <input hidden asp-for="Model.Id" />

        [HttpPost]
        public IActionResult Edit(Model model)
        {
            if (ModelState.IsValid)
            {
                _db.Update(model);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        //[HttpPost]
        //public IActionResult Edit() //parameter is not passing since BindProperty attribute is used
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _db.Update(modelViewModel.Model);
        //        _db.SaveChanges();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(modelViewModel);
        //}

        [HttpPost]
        public IActionResult Delete(int id)
        {
            var model = _db.Models.Find(id);
            if(model == null)
            {
                return NotFound();
            }
            _db.Remove(model);
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }


        [AllowAnonymous] //any one can access
        [HttpGet("api/models/{makeId}")] //return model data in json formate, variable enclosed in {}
        public IEnumerable<Model> Models(int makeId)
        {
            return _db.Models.ToList()
                .Where(m => m.MakeId == makeId); //filter from database
        }


        //here we are using ModelResource instead Model
        //[AllowAnonymous] 
        //[HttpGet("api/models")]
        //public IEnumerable<ModelResource> Models(int makeId)
        //{
        //    var models = _db.Models.ToList();

        //    //using linq query map all Model object into ModelResource object
        //    //this way we are creating service layer which only show ID and Name 
        //    //this way we can protect other data (Make)
        //    var modelResources = models
        //        .Select(m => new ModelResource()
        //        {
        //            Id = m.Id,
        //            Name = m.Name
        //        }).ToList();

        //    return modelResources;

        //    //here only 2 property present (Id & Name)
        //    //if there are more property present, it will be tedeious to do mapping manually 
        //    //we can also do mapping automatically using automapper
        //}


        //here we are using ModelResource instead Model
        [AllowAnonymous]
        [HttpGet("api/models")]
        public IEnumerable<ModelResource> Models1(int makeId)
        {
            var models = _db.Models.ToList();

            //configure automapper
            //when we put mapper controller, it will give profermance issue
            //it should be in starter class, use dependency injection
            //var configMap = new MapperConfiguration(m => m.CreateMap<Model, ModelResource>());

            //map the object
            //var mapper = new Mapper(configMap);
            //var modelResource = mapper.Map<List<Model>, List<ModelResource>>(models);


            ////-----------or------------------------////
            /////map the object
            var modelResource = _mapper.Map<List<Model>, List<ModelResource>>(models);

            return modelResource;
        }
    }
}
