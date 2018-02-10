using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Text;

namespace Cibertec.Web.TagHelpers
{
    // You may need to install the Microsoft.AspNetCore.Razor.Runtime package into your project
    [HtmlTargetElement("Person")]
    public class PersonTagHelper : TagHelper
    {
        [HtmlAttributeName("descripcion")]
        public string descripcion { get; set; }
        [HtmlAttributeName("stock")]
        public int Stock { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            var sb = new StringBuilder();
            sb.AppendFormat("<div>");
            sb.AppendFormat("<h3>:{0}</h3>", this.descripcion);
            sb.AppendFormat("<p>Stock:{0}</p>", this.Stock);

            output.PreContent.SetContent(sb.ToString());
            output.PreContent.SetContent("</div>");
        }
    }
}
