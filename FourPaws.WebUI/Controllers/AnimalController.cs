using FourPaws.Domain.Abstract;
using FourPaws.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FourPaws.WebUI.Controllers
{
    public class AnimalController : Controller
    {
        private IAnimalRepository repository;
        public int pageSize = 6;

        public AnimalController(IAnimalRepository repo )
        {
            repository = repo;
           
        }

        public ViewResult List(int page = 1)
        {
            AnimalListViewModel model = new AnimalListViewModel
            {
               Animals = repository.Animals
                    .OrderBy(an => an.AnimalId)
                    .Skip((page - 1) * pageSize)
                    .Take(pageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = pageSize,
                    TotalItems = repository.Animals.Count()
                }
            };
            return View(model);
        }
    }
   
 }
