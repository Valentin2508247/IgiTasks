#pragma checksum "C:\Users\ASUS\source\repos\Ssss\Ssss\Views\TagHelper\AnotherTask.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b68a4f9510fa8c16ed7ab785b98ded77ab50b1ca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TagHelper_AnotherTask), @"mvc.1.0.view", @"/Views/TagHelper/AnotherTask.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\ASUS\source\repos\Ssss\Ssss\Views\_ViewImports.cshtml"
using Ssss;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ASUS\source\repos\Ssss\Ssss\Views\_ViewImports.cshtml"
using Ssss.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b68a4f9510fa8c16ed7ab785b98ded77ab50b1ca", @"/Views/TagHelper/AnotherTask.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"98810102ba1f6ee44d74221be38aeeb5239a51a0", @"/Views/_ViewImports.cshtml")]
    public class Views_TagHelper_AnotherTask : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alternate-classes", "text1;text2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Ssss.TagHelpers.TableTagHelper __Ssss_TagHelpers_TableTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\ASUS\source\repos\Ssss\Ssss\Views\TagHelper\AnotherTask.cshtml"
  
    ViewData["Title"] = "AnotherTask";
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h6>Написать помощник тэга(при необходимости несколько)...</h6>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("table", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b68a4f9510fa8c16ed7ab785b98ded77ab50b1ca3642", async() => {
                WriteLiteral("\r\n    <tr><td>name</td><td>Dragon Knight</td></tr>\r\n    <tr><td>level</td><td>1</td></tr>\r\n    <tr><td>strength</td><td>19</td></tr>\r\n    <tr><td>agillity</td><td>19</td></tr>\r\n    <tr><td>intelligence</td><td>18</td></tr>\r\n");
            }
            );
            __Ssss_TagHelpers_TableTagHelper = CreateTagHelper<global::Ssss.TagHelpers.TableTagHelper>();
            __tagHelperExecutionContext.Add(__Ssss_TagHelpers_TableTagHelper);
            __Ssss_TagHelpers_TableTagHelper.AlternateClasses = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
