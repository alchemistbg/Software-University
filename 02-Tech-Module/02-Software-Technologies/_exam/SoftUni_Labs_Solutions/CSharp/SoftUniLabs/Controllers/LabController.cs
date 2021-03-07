using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SoftUniLabs.Data;
using SoftUniLabs.Models;

namespace SoftUniLabs.Controllers
{
    public class LabController : Controller
    {
        private readonly LabDbContext context;

        public LabController(LabDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        [Route("/")]
        public IActionResult Index()
        {
			List<Lab> labs = context.Labs.ToList();
			return View(labs);
		}

        [HttpGet]
        [Route("/create")]
        public IActionResult Create()
        {
			return View();
		}

        [HttpPost]
        [Route("/create")]
        public IActionResult Create(Lab lab)
        {
			context.Labs.Add(lab);
			context.SaveChanges();
			return Redirect("/");
		}

        [HttpGet]
        [Route("/edit/{id}")]
        public IActionResult Edit(int id)
        {
			Lab lab = context.Labs.Find(id);
			return View(lab);
		}

        [HttpPost]
        [Route("/edit/{id}")]
        public IActionResult Edit(Lab lab)
        {
			context.Labs.Update(lab);
			context.SaveChanges();
			return Redirect("/");
		}

        [HttpGet]
        [Route("/delete/{id}")]
        public IActionResult Delete(int id)
        {
			Lab lab = context.Labs.Find(id);
			return View(lab);
		}

        [HttpPost]
        [Route("/delete/{id}")]
        public IActionResult Delete(Lab lab)
        {
			context.Labs.Remove(lab);
			context.SaveChanges();
			return Redirect("/");
		}
    }
}
