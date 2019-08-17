    using Microsoft.AspNetCore.Razor.TagHelpers;

    namespace TagHelpersNotPurple
    {
        // You may need to install the Microsoft.AspNetCore.Razor.Runtime package into your project
        [HtmlTargetElement("p")]
        public class PTagHelper : TagHelper
        {
            public override void Process(TagHelperContext context, TagHelperOutput output)
            {
                output.Content.AppendHtml("...p tag helper...");

            }
        }
    }
