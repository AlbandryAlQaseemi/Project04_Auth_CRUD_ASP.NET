#pragma checksum "C:\Users\Alban\source\repos\Coffee\Coffee\Views\Beans\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eb0879010a4bcbf9859801625e9b62e00851b895"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Beans_Index), @"mvc.1.0.view", @"/Views/Beans/Index.cshtml")]
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
#line 1 "C:\Users\Alban\source\repos\Coffee\Coffee\Views\_ViewImports.cshtml"
using Coffee;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Alban\source\repos\Coffee\Coffee\Views\_ViewImports.cshtml"
using Coffee.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb0879010a4bcbf9859801625e9b62e00851b895", @"/Views/Beans/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"339c788173a40e9bec207f55d81c92e5443ef456", @"/Views/_ViewImports.cshtml")]
    public class Views_Beans_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-bottom:80px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Alban\source\repos\Coffee\Coffee\Views\Beans\Index.cshtml"
  
    var Beans = (List<Bean>)ViewData["Beans"];


#line default
#line hidden
#nullable disable
            WriteLiteral("<h1 style=\"color:gray;margin-top:120px; text-align:center\">Coffee Beans</h1>\r\n\r\n<link href=\"https://fonts.googleapis.com/icon?family=Material+Icons\" rel=\"stylesheet\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eb0879010a4bcbf9859801625e9b62e00851b8953800", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 10 "C:\Users\Alban\source\repos\Coffee\Coffee\Views\Beans\Index.cshtml"
     foreach (var bean in Beans)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <div class=\"ml-3 mr-3 mt-5\" style=\"display: inline-table\">\r\n            <div class=\"card\" style=\"width: 15rem; text-align:center;\">\r\n                <img");
                BeginWriteAttribute("src", " src=\"", 464, "\"", 481, 1);
#nullable restore
#line 14 "C:\Users\Alban\source\repos\Coffee\Coffee\Views\Beans\Index.cshtml"
WriteAttributeValue("", 470, bean.Image, 470, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"card-img-top\" height=\"200\" width=\"20\" alt=\"...\">\r\n                <div class=\"card-body\">\r\n                    <h5 class=\"card-title\" style=\"text-align:center; color:darkblue\">\r\n                        ");
#nullable restore
#line 17 "C:\Users\Alban\source\repos\Coffee\Coffee\Views\Beans\Index.cshtml"
                   Write(bean.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </h5>\r\n                    <h5 class=\"card-title\">\r\n                        ");
#nullable restore
#line 20 "C:\Users\Alban\source\repos\Coffee\Coffee\Views\Beans\Index.cshtml"
                   Write(bean.Type);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </h5>\r\n                    <h5 class=\"card-title\">\r\n                        <i class=\"small material-icons\">flag</i>\r\n                        ");
#nullable restore
#line 24 "C:\Users\Alban\source\repos\Coffee\Coffee\Views\Beans\Index.cshtml"
                   Write(bean.Country);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </h5>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 29 "C:\Users\Alban\source\repos\Coffee\Coffee\Views\Beans\Index.cshtml"

    }

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
