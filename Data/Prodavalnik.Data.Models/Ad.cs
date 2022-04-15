﻿namespace Prodavalnik.Data.Models
{
    using System.Collections.Generic;

    using Prodavalnik.Data.Common.Models;

    public class Ad : BaseDeletableModel<string>
    {
        public Ad()
        {
            this.Images = new HashSet<Image>();
        }

        public string Title { get; set; }

        public string Description { get; set; }

        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }

        public string AddedByUserId { get; set; }

        public virtual ApplicationUser AddedByUser { get; set; }

        public virtual ICollection<Image> Images { get; set; }

        public string Location { get; set; }
    }

}
