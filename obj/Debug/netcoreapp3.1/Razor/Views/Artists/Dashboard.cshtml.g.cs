#pragma checksum "C:\Users\Peter Snider\Documents\Coding_Dojo-Main\Coding_Dojo\CSharp\CSharp_Project\Comission\Views\Artists\Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f2503ba5a1bd5f304ff7068ef4210ca10f3a9c50"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Artists_Dashboard), @"mvc.1.0.view", @"/Views/Artists/Dashboard.cshtml")]
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
#line 1 "C:\Users\Peter Snider\Documents\Coding_Dojo-Main\Coding_Dojo\CSharp\CSharp_Project\Comission\Views\_ViewImports.cshtml"
using Comission;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Peter Snider\Documents\Coding_Dojo-Main\Coding_Dojo\CSharp\CSharp_Project\Comission\Views\_ViewImports.cshtml"
using Comission.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Peter Snider\Documents\Coding_Dojo-Main\Coding_Dojo\CSharp\CSharp_Project\Comission\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2503ba5a1bd5f304ff7068ef4210ca10f3a9c50", @"/Views/Artists/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c27156c7b4d74d439eb5f704c30ef036b47fe4e", @"/Views/_ViewImports.cshtml")]
    public class Views_Artists_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Artists", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ArtistsContracts", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-center text-light"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Peter Snider\Documents\Coding_Dojo-Main\Coding_Dojo\CSharp\CSharp_Project\Comission\Views\Artists\Dashboard.cshtml"
  
    ViewData["Title"] = "Creator Dashboard";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container"">
    <h1 class=""Display-1 text-center py-5 card bg-light shadow"">Welcome to your Dashboard, User 123</h1>

    <div class=""row justify-content-around border rounded"" style="" margin:0px; background-image: url('https://thevirtualinstructor.com/blog/wp-content/uploads/2013/08/understanding-abstract-art.jpg'); width: 100%; height:auto; background-size: 100% 100%; background-repeat: no-repeat; "">

        <div class=""card my-5"" style=""width: 26rem; height: 30rem; "">
            <div class=""card-body text-center"">
                <h1 class=""card-title display-4"">Upload to Your Portfolio</h1>

                <a href=""/testNewPiece"" class=""btn btn-link"">Click Here</a>
            </div>

        </div>
        <div class=""card my-5"" style=""width: 26rem; height: 30rem; "">
            <div class=""card-body text-center"">
                <h1 class=""card-title display-4"">Your Art</h1>
                <hr>

                <div id=""carouselExampleControls"" class=""carousel slide d");
            WriteLiteral(@"-flex align-items-center"" style=""height:16rem;"" data-ride=""carousel"">
                    <div class=""carousel-inner"">
                        <div class=""carousel-item active"">
                            <img class=""d-block w-100"" src=""https://kajabi-storefronts-production.kajabi-cdn.com/kajabi-storefronts-production/blogs/14045/images/33UgWImcQxmQCGC5uEN6_1.jpeg"" alt=""First slide"">
                        </div>
                        <div class=""carousel-item"">
                            <img class=""d-block w-100"" src=""https://impressionistarts.com/static/cb92095d51eb64f83f7329bc0c391992/14b42/art-thefts-monet-sunrise.jpg"" alt=""Second slide"">
                        </div>
                        <div class=""carousel-item"">
                            <img class=""d-block w-100"" src=""https://s32625.pcdn.co/wp-content/uploads/2018/06/MMarino_Boats-on-the-Seine-1024x674.jpg.webp"" alt=""Third slide"">
                        </div>
                    </div>
                    <a class=""carousel-");
            WriteLiteral(@"control-prev"" href=""#carouselExampleControls"" role=""button"" data-slide=""prev"">
                        <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
                        <span class=""sr-only"">Previous</span>
                    </a>
                    <a class=""carousel-control-next"" href=""#carouselExampleControls"" role=""button"" data-slide=""next"">
                        <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
                        <span class=""sr-only"">Next</span>
                    </a>
                </div>
                <hr>
                <p class=""card-text lead""></p>
                <a href=""/allPieces"" class=""btn btn-link"">Go to whole portfolio</a>
            </div>

        </div>
    </div>
    <br>

    <div class=""row justify-content-around border rounded"" style="" margin:0px; background-image: url('https://images.unsplash.com/photo-1533134755454-9549758f0e06?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8N3x8YmxhY2slMjBhb");
            WriteLiteral(@"mQlMjB3aGl0ZSUyMGFic3RyYWN0fGVufDB8fDB8fA%3D%3D&auto=format&fit=crop&w=500&q=60'); width: 100%; height:auto; background-size: 100% 100%; background-repeat: no-repeat; "">

        <div class=""d-flex align-items-center justify-content-center"" style=""width: 45rem; height: 10rem; "">
            <h1 class=""card-title display-6 text-light text-center"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f2503ba5a1bd5f304ff7068ef4210ca10f3a9c508299", async() => {
                WriteLiteral("Your Contracts");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</h1>
        </div>
    </div>

    <br>
    
    <div class=""row justify-content-around border rounded"" style="" margin:0px; background-image: url('https://impressionistarts.com/static/af88b9a7c619dd73f948729d93ae5ea2/14b42/art-thefts-monet-charing-cross-bridge.jpg'); width: 100%; height:auto; background-size: 100% 100%; background-repeat: no-repeat; "">

        <div class=""card my-5"" style=""width: 45rem; height: 30rem; "">
            <div class=""card-body text-center"">
                <h1 class=""card-title display-4"">Featured Bids</h1>
                <div class=""d-flex justify-content-center"">
                    <div class=""text-left px-2"">
                        <p class=""card-text lead"">Colorful, Impressionist, Oil Painting</p>
                        <hr>
                        <p class=""card-text lead"">Dark, Abstract, Water-Color Painting</p>
                        <hr>
                        <p class=""card-text lead"">Light, Modern, Acrylic Painting</p>
                        <h");
            WriteLiteral(@"r>
                        <p class=""card-text lead"">Make ME whatever YOU want!!</p>
                        <hr>
                    </div>
                    <div class=""text-left px-2"">
                        <p class=""card-text lead"">$400.00</p> 
                        <hr>
                        <p class=""card-text lead"">$200.00</p>
                        <hr>
                        <p class=""card-text lead"">$350.00</p>
                        <hr>
                        <p class=""card-text lead"">Quote Pending</p>
                        <hr>
                    </div>
                    <div class=""text-left px-2"">
                        <a");
            BeginWriteAttribute("href", " href=\"", 5285, "\"", 5292, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"card-text lead\">Details</a>\r\n                        <hr>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 5386, "\"", 5393, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"card-text lead\">Details</a>\r\n                        <hr>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 5487, "\"", 5494, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"card-text lead\">Details</a>\r\n                        <hr>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 5588, "\"", 5595, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"card-text lead\">Details</a>\r\n                        <hr>\r\n                    </div>\r\n                </div>\r\n\r\n            </div>\r\n\r\n        </div>\r\n\r\n\r\n\r\n    </div>\r\n\r\n</div>");
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
