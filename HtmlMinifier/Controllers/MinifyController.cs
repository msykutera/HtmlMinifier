using Microsoft.AspNetCore.Mvc;

namespace HtmlMinifier.Controllers
{
    [Route("api/[controller]")]
    public class MinifyController : Controller
    {
        private readonly IMinifyService _minifyService;

        public MinifyController(IMinifyService minifyService)
        {
            _minifyService = minifyService;
        }

        [HttpPost]
        public string Minify([FromForm] MinifyRequest request)
        {
            var result = _minifyService.Minify(request.Html);
            return result;
        }
    }
}