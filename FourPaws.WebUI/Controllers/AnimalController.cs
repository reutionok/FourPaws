using FourPaws.Domain.Abstract;
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

        public AnimalController(IAnimalRepository repo )
        {
            repository = repo;
           
        }

        public ViewResult List()
        {
            return View(repository.Animals);
        }
    }
   
 }
