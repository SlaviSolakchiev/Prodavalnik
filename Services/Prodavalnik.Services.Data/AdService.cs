namespace Prodavalnik.Services.Data
{
    using System.IO;
    using System.Threading.Tasks;

    using Prodavalnik.Data.Common.Repositories;
    using Prodavalnik.Data.Models;
    using Prodavalnik.Web.ViewModels;

    public class AdService : IAdService
    {
        private readonly IDeletableEntityRepository<Ad> adsRepository;

        public AdService(IDeletableEntityRepository<Ad> adsRepository)
        {
            this.adsRepository = adsRepository;
        }

        public async Task CreateAsync(CreateAdInputModel input, string userId)
        {
            var ad = new Ad()
            {
                CategoryId = input.CategoryId,
                Description = input.Description,
                Location = input.Location,
                Title = input.Title,
                AddedByUserId = userId,
            };

            await this.adsRepository.AddAsync(ad);


            // wwwroot/images/recipes/{id}.{ex}
            foreach (var image in input.Images)
            {
                var dbImage = new Image()
                {
                    AddedByUserId = userId,
                    FileExtension = Path.GetExtension(image.FileName),
                };
                ad.Images.Add(dbImage);
                var physicalPath = $"wwwroot/images/recipes/{dbImage.Id}.{dbImage.FileExtension }";
            }

            await this.adsRepository.AddAsync(ad);
            await this.adsRepository.SaveChangesAsync();
        }
    }
}
