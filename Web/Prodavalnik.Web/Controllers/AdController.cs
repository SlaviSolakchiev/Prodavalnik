namespace Prodavalnik.Web.Controllers
{
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using Prodavalnik.Data.Common.Repositories;
    using Prodavalnik.Data.Models;
    using Prodavalnik.Services.Data;
    using Prodavalnik.Web.ViewModels;

    public class AdController : BaseController
    {
        private readonly IGetAllCategoriesService getAllCategories;
        private readonly IDeletableEntityRepository<Ad> adsRepository;
        private readonly Microsoft.AspNetCore.Identity.UserManager<ApplicationUser> userManager;
        private readonly IRepository<Image> imagesRepository;

        public AdController(IGetAllCategoriesService getAllCategories, IDeletableEntityRepository<Ad> adsRepository, UserManager<ApplicationUser> userManager, IRepository<Image> imagesRepository)
        {
            this.getAllCategories = getAllCategories;
            this.adsRepository = adsRepository;
            this.userManager = userManager;
            this.imagesRepository = imagesRepository;
        }

        [HttpGet]
        public IActionResult CreateAd()
        {
            var viewModel = new CreateAdInputModel()
            {
                Categories = this.getAllCategories.GetAllCategories(),
            };
            return this.View(viewModel);
        }

        [HttpPost]
        public IActionResult CreateAd(CreateAdInputModel input)
        {
            if (this.ModelState.IsValid)
            {
                List<Image> photolist = new List<Image>();
            }

            return this.View();
        }
    }
}
