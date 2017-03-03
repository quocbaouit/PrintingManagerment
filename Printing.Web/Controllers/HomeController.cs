using AutoMapper;
using PrintingManager.Data.Repositories;
using PrintingManager.Model;
using PrintingManager.Service;
using PrintingManager.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PrintingManager.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICategoryService categoryService;
        private readonly IGadgetService gadgetService;
        private readonly ICategoryRepository categorysRepository;
        public HomeController(ICategoryService categoryService, IGadgetService gadgetService,ICategoryRepository categorysRepository)
        {
            this.categoryService = categoryService;
            this.gadgetService = gadgetService;
            this.categorysRepository = categorysRepository;
        }

        // GET: Home
        public ActionResult Index()
        {
            //IEnumerable<CategoryViewModel> viewModelGadgets;
            //IEnumerable<Category> categories;
            //var a = categorysRepository.GetMany(x => x.CategoryID == 9).ToList();
            //categories = categoryService.GetCategories(category).ToList();

            //viewModelGadgets = Mapper.Map<IEnumerable<Category>, IEnumerable<CategoryViewModel>>(categories);
            return View();
        }

        public ActionResult Filter(string category, string gadgetName)
        {
            IEnumerable<GadgetViewModel> viewModelGadgets;
            IEnumerable<Gadget> gadgets;

            gadgets = gadgetService.GetCategoryGadgets(category, gadgetName);

            viewModelGadgets = Mapper.Map<IEnumerable<Gadget>, IEnumerable<GadgetViewModel>>(gadgets);

            return View(viewModelGadgets);
        }

        [HttpPost]
        public ActionResult Create(GadgetFormViewModel newGadget)
        {
            if (newGadget != null && newGadget.File != null)
            {
                var gadget = Mapper.Map<GadgetFormViewModel, Gadget>(newGadget);
                gadgetService.CreateGadget(gadget);

                string gadgetPicture = System.IO.Path.GetFileName(newGadget.File.FileName);
                string path = System.IO.Path.Combine(Server.MapPath("~/images/"), gadgetPicture);
                newGadget.File.SaveAs(path);

                gadgetService.SaveGadget();
            }

            var category = categoryService.GetCategory(newGadget.GadgetCategory);
            return RedirectToAction("Index", new { category = category.Name });
        }
    }
}