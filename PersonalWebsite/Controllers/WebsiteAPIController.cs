using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PersonalWebsite.LocalModels;

namespace PersonalWebsite.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WebsiteAPIController : ControllerBase
    {

        [HttpGet]
        public WebsiteModel GetImage()
        {
            WebsiteModel model = new WebsiteModel();
            model.ImageURL = "PersonalWebsite/Siteart/b.JPG";
            return model;
        }


    }
}
