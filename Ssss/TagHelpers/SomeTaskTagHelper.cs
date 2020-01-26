using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ssss.Models;
using System.Reflection;

namespace Ssss.TagHelpers
{
    [HtmlTargetElement("data-display", Attributes ="model")]
    public class SomeTaskTagHelper : TagHelper
    {
        public object Model { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "table";
            output.TagMode = TagMode.StartTagAndEndTag;
            Type type = Model.GetType();
            foreach (PropertyInfo property in type.GetProperties())
            {
                string name = property.Name;
                string str = property.GetValue(Model).ToString();
                output.Content.AppendHtml($"<tr><td>{name}</td><td>{str}</td></tr>");
            }
        }
    }
}
