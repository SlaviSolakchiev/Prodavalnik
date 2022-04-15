namespace Prodavalnik.Web.ViewModels
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc.Rendering;

    public class CreateAdInputModel
    {
        [Required]
        [MinLength(5)]
        public string Title { get; set; }

        [MinLength(5)]
        public string Description { get; set; }

        [Required]
        public int CategoryId { get; set; }

        [Required]
        [MinLength(3)]
        public string Location { get; set; }

        public IEnumerable<IFormFile> Images { get; set; }

        public virtual IEnumerable<SelectListItem> Categories { get; set; }
    }
}
