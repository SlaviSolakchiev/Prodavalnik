namespace Prodavalnik.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Mvc.Rendering;
    using Prodavalnik.Data.Common.Repositories;
    using Prodavalnik.Data.Models;

    public class GetAllCategoriesService : IGetAllCategoriesService
    {
        private readonly IRepository<Category> categoriesRepository;

        public GetAllCategoriesService(IRepository<Category> categoriesRepository)
        {
            this.categoriesRepository = categoriesRepository;
        }

        public IEnumerable<SelectListItem> GetAllCategories()
        {
            var data = this.categoriesRepository.All().Select(x => new SelectListItem { Text = x.Name, Value = x.Id.ToString() }).ToList();
            return data;
        }

    }
}
