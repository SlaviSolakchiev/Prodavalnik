namespace Prodavalnik.Services.Data
{
    using System.Collections.Generic;

    using Microsoft.AspNetCore.Mvc.Rendering;

    public interface IGetAllCategoriesService
    {
        IEnumerable<SelectListItem> GetAllCategories();
    }
}
