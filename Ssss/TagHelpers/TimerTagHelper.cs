using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Ssss
{
    public class TimerTagHelper : TagHelper
    {
        public bool SecondsIncluded { get; set; }

        [ViewContext]
        [HtmlAttributeNotBound]
        public ViewContext ViewContext { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagMode = TagMode.StartTagAndEndTag;
            output.TagName = "div";    // заменяет тег <timer> тегом <div>
                                       // устанавливаем содержимое элемента
            string time = "";
            if (SecondsIncluded)
                time = DateTime.Now.ToString("HH:mm:ss");
            else
                time = DateTime.Now.ToString("HH:mm");
            output.Content.SetContent($"Текущее время: {time}");
            
        }
    }
}
