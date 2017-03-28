using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CheeseMVC.Models;
using CheeseMVC.ViewModels;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace CheeseMVC.Controllers
{
    public class CheeseController : Controller
    {
        static private Dictionary<string, string> Cheeses = new Dictionary<string, string>();
        // GET: /<controller>/
        public IActionResult Index()
        {
            List<Cheese> cheeses = CheeseData.GetAll();

            ViewBag.cheeses = CheeseData.GetAll();
            return View(cheeses);
        }

        public IActionResult Add()
        {
            AddCheeseViewModel addCheeseViewModel = new AddCheeseViewModel();
            return View(addCheeseViewModel);
        }

        [HttpPost]
        [Route("/Cheese/Add")]
        public IActionResult Add(AddCheeseViewModel addCheeseViewModel)
        {
            if (ModelState.IsValid)
            {
                //Add the new cheese
                Cheese newCheese = new Models.Cheese
                {
                    Name = addCheeseViewModel.Name,
                    Description = addCheeseViewModel.Description,
                    Type = addCheeseViewModel.Type
                };
                CheeseData.Add(newCheese);
                return Redirect("/Cheese");
            }
            return View(addCheeseViewModel);

        }
        [Route("/cheese/remove")]
        [HttpGet]
        public IActionResult Remove()
        {
            ViewBag.title = "Remove Cheeses";
            ViewBag.cheeses = CheeseData.GetAll();
            return View();
        }

        [Route("/cheese/remove")]
        [HttpPost]
        public IActionResult RemoveManyCheeses(int[] cheeseIds)
        {
            foreach (int submittedCheeseId in cheeseIds)
            {
                // remove cheese from cheeses by using LINQ to extract
                // the specific cheese by CheeseId
                CheeseData.Remove(submittedCheeseId);
            }

            return Redirect("/cheese");
        }

        [Route("/cheese/remove/{cheeseId}")]
        [HttpGet]
        public IActionResult RemoveSingleCheese(int cheeseId)
        {
            // remove cheese from cheeses by using LINQ to extract
            // the specific cheese by CheeseId
            CheeseData.Remove(cheeseId);

            return Redirect("/Cheese");
        }

        [Route("/Cheese/edit")]
        [HttpGet]
        public IActionResult Edit(int cheeseId)
        {
            ViewBag.error = "";
            ViewBag.cheese = CheeseData.GetById(cheeseId);
            return View();
        }

        [Route("/cheese/edit")]
        [HttpPost]
        public IActionResult Edit(int cheeseId, string name, string description)
        {
            Cheese cheese = CheeseData.GetById(cheeseId);
            cheese.Name = name;
            cheese.Description = description;
            return Redirect("/cheese");
        }
    }
}

