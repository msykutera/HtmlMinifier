using NUglify;

namespace HtmlMinifier
{
    public class MinifyService : IMinifyService
    {
        public string Minify(string html)
        {
            var result = Uglify.Html(html);
            return result.Code;
        }
    }
}