#pragma checksum "C:\Users\Alban\source\repos\Coffee\Coffee\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cfe7bf13add1e47da200de1076be11bd6e3db6e8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cfe7bf13add1e47da200de1076be11bd6e3db6e8", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"339c788173a40e9bec207f55d81c92e5443ef456", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_info", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Alban\source\repos\Coffee\Coffee\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("<style>\r\n    .w3-third img {\r\n        margin-bottom: 10px;\r\n        opacity: 0.8;\r\n        cursor: pointer;\r\n    }\r\n        .w3-third img:hover {\r\n            opacity: 1\r\n        }\r\n</style>\r\n<!-- Page content -->\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "cfe7bf13add1e47da200de1076be11bd6e3db6e83734", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<div class=""container "" style="" margin-bottom: 6px; opacity: 0.8; cursor: pointer "">
    <div class=""row "">

        <div class=""col w3-third"" style=""margin-top:100px; margin-left:200px"">
            <a href=""/Beans/Index""> <img src=""https://images.unsplash.com/photo-1615324606662-5d6d2ae148f0?ixid=MnwxMjA3fDB8MHxzZWFyY2h8NXx8Y29mZmVlJTIwcGFzc2lvbiUyMG1vcm5pbmd8ZW58MHx8MHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=700&q=60"" style=""width:300px; height:200px""");
            BeginWriteAttribute("alt", " alt=\"", 750, "\"", 756, 0);
            EndWriteAttribute();
            WriteLiteral(@"></a>
            <h1 class=""w3-xxlarge"" style=""color:gray"">Beans</h1>

        </div>
        <div class=""col w3-third"" style=""margin-top:100px; margin-right:150px"">
            <a href=""/Roasteries/Index""> <img src=""https://images.unsplash.com/photo-1497935586351-b67a49e012bf?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1051&q=80"" style=""width: 300px; height: 200px""");
            BeginWriteAttribute("alt", " alt=\"", 1175, "\"", 1181, 0);
            EndWriteAttribute();
            WriteLiteral(@"></a>
            <h1 class=""w3-xxlarge"" style=""color:gray"">Roasteries</h1>

        </div>

        <div class=""col w3-third"" style=""margin-top:15px; margin-left:200px"">
            <a href=""/Tools/Index"">   <img src=""https://images.unsplash.com/photo-1583555968749-e08f34583c76?ixid=MnwxMjA3fDB8MHxzZWFyY2h8NjJ8fGNvZmZlZSUyMHBhc3Npb24lMjBtb3JuaW5nfGVufDB8fDB8fA%3D%3D&ixlib=rb-1.2.1&auto=format&fit=crop&w=700&q=60"" style=""width: 300px; height: 200px""");
            BeginWriteAttribute("alt", " alt=\"", 1641, "\"", 1647, 0);
            EndWriteAttribute();
            WriteLiteral(@"></a>
            <h1 class=""w3-xxlarge"" style=""color:gray"">Barista Tools</h1>

        </div>
        <div class=""col w3-third"" style=""margin-top:15px; margin-right:150px"">
            <a href=""/Recommendations/Index"">  <img src=""https://images.unsplash.com/photo-1591037541477-8c6b74aac7ff?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8NjF8fGNvZmZlZSUyMHBhc3Npb24lMjBtb3JuaW5nfGVufDB8fDB8fA%3D%3D&auto=format&fit=crop&w=700&q=60"" style=""width:300px; height:200px""");
            BeginWriteAttribute("alt", " alt=\"", 2116, "\"", 2122, 0);
            EndWriteAttribute();
            WriteLiteral(@"></a>
            <h1 class=""w3-xxlarge"" style=""color:gray"">Recommendations</h1>

        </div>
    </div>
</div>


<!-- About Section -->
<div class=""w3-row w3-padding-64"" id=""about"">
    <div class=""w3-col m6 w3-padding-large w3-hide-small"">
        <img src=""https://images.unsplash.com/photo-1509042239860-f550ce710b93?ixid=MnwxMjA3fDB8MHxwaG90by1yZWxhdGVkfDR8fHxlbnwwfHx8fA%3D%3D&ixlib=rb-1.2.1&auto=format&fit=crop&w=700&q=60"" class=""w3-round w3-image w3-opacity-min""");
            BeginWriteAttribute("alt", " alt=\"", 2608, "\"", 2614, 0);
            EndWriteAttribute();
            WriteLiteral(@" width=""500"" height=""600"">
    </div>

    <div class=""w3-col m6 w3-padding-large"">
        <h1 class=""w3-center"">About Coffee</h1><br>
        <h5 class=""w3-center"">In mid-1600's</h5>
        <p class=""w3-large"">
            Coffee grown worldwide can trace its heritage back centuries to the ancient coffee forests on the Ethiopian plateau. There, legend says the goat herder Kaldi first discovered the potential of these beloved beans.

            The story goes that that Kaldi discovered coffee after he noticed that after eating the berries from a certain tree, his goats became so energetic that they did not want to sleep at night.

            Kaldi reported his findings to the abbot of the local monastery, who made a drink with the berries and found that it kept him alert through the long hours of evening prayer. The abbot shared his discovery with the other monks at the monastery, and knowledge of the energizing berries began to spread.

            As word moved east and coffee reached the A");
            WriteLiteral(@"rabian peninsula, it began a journey which would bring these beans across the globe.
        </p>
        <p class=""w3-large w3-text-grey w3-hide-medium font-italic"">""Coffee - the favorite drink of the civilized world."" - Thomas Jefferson</p>
    </div>
</div>
</div>

");
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
