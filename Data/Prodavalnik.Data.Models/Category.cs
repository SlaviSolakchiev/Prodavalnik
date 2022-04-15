namespace Prodavalnik.Data.Models
{
    using System.Collections.Generic;

    using Prodavalnik.Data.Common.Models;

    public class Category : BaseDeletableModel<int>
    {
        public Category()
        {
            this.Ads = new HashSet<Ad>();
        }

        public string Name { get; set; }

        public virtual ICollection<Ad> Ads { get; set; }
    }
}
