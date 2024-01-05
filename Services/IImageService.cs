using Microsoft.EntityFrameworkCore;
using VKStudio.Models;

namespace VKStudio.Services
{
    public class IImageService
    {
        private readonly StudioDBContext _dbContext = new StudioDBContext(new DbContextOptions<StudioDBContext>());

        public List<Image> GetVisibleImages()
        {
            return _dbContext.Images.Where(i => i.IsVisible).ToList();
        }

        public List<Image> GetUnvisibleImages()
        {
            return _dbContext.Images.Where(i => !i.IsVisible).ToList();
        }

        public List<Image> GetCutImages()
        {
            return _dbContext.Images.Where(i => i.Name.StartsWith("cut")).ToList();
        }

        public List<Image> GetDyedImages()
        {
            return _dbContext.Images.Where(i => i.Name.StartsWith("dyed")).ToList();
        }

        public List<Image> GetProdImages()
        {
            return _dbContext.Images.Where(i => i.Name.StartsWith("prod")).ToList();
        }

        public List<Image> GetVisibleCutImages()
        {
            return _dbContext.Images.Where(i => i.Name.StartsWith("cut") && i.IsVisible).ToList();
        }

        public List<Image> GetVisibleDyedImages()
        {
            return _dbContext.Images.Where(i => i.Name.StartsWith("dyed") && i.IsVisible).ToList();
        }

        public List<Image> GetVisibleProdImages()
        {
            return _dbContext.Images.Where(i => i.Name.StartsWith("prod") && i.IsVisible).ToList();
        }

        public bool ToggleImageVisibility(int imageId, bool isVisible)
        {
            var image = _dbContext.Images.FirstOrDefault(i => i.ID == imageId);

            if (image != null)
            {
                image.IsVisible = isVisible;
                _dbContext.SaveChanges();
                return true;
            }

            return false;
        }
    }
}