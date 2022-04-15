namespace Prodavalnik.Services.Data
{
    using System.Threading.Tasks;

    using Prodavalnik.Web.ViewModels;

    public interface IAdService
    {
        Task CreateAsync(CreateAdInputModel input, string userId);
    }
}
