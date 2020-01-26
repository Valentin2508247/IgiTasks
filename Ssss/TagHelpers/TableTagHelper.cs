using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ssss.TagHelpers
{
    [HtmlTargetElement("table", Attributes = "alternate-classes")]
    public class TableTagHelper : TagHelper
    {
        public string AlternateClasses { get; set; } 
        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            string[] strs = AlternateClasses.Split(";");
            string first = strs[0];
            string second = strs[1];

            string str = "\"";
            string str2 = @"""";
            string str3 = " \u0022 ";

            string str4 = "";
            

            string pattern = @"<tr>.+?</tr>";
            Regex regex = new Regex(pattern);

            string innerText = (await output.GetChildContentAsync()).GetContent();
            MatchCollection collection = regex.Matches(innerText);
            string[] rows = (from i in collection select i.Value).ToArray();
            for (int i = 0; i < rows.Length; i++)
            {
                string _class;
                if (i % 2 == 1)
                {
                    _class = first;
                }
                else
                {
                    _class = second;
                }
                rows[i] = $"<tr class=\"{_class}\"" + rows[i].Substring(3);
            }
            string newInnerText = String.Concat(rows);
            output.Content.SetHtmlContent(newInnerText);  
        }

    }
}
