using Microsoft.AspNetCore.Mvc;
using VKStudio.Services;

namespace VKStudio.Controllers
{
    public class ChoosePhotosController : Controller
    {
        private readonly IImageService _imageService;

        public ChoosePhotosController(IImageService imageService)
        {
            _imageService = imageService;
        }

        [HttpPost]
        public JsonResult ToggleImageVisibility(int imageId, bool isVisible)
        {
            bool result = _imageService.ToggleImageVisibility(imageId, isVisible);
            return Json(new { success = result });
        }
    }
}
