#pragma checksum "C:\Users\User\Desktop\AspNetHomework\SEDC.Homework02.ProductApp\SEDC.Homework02.ProductApp\Views\product\Products.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "88d18dcd3d1c8c32370036d2ac57c553d877b953"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_product_Products), @"mvc.1.0.view", @"/Views/product/Products.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/product/Products.cshtml", typeof(AspNetCore.Views_product_Products))]
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
#line 1 "C:\Users\User\Desktop\AspNetHomework\SEDC.Homework02.ProductApp\SEDC.Homework02.ProductApp\Views\_ViewImports.cshtml"
using SEDC.Homework02.ProductApp;

#line default
#line hidden
#line 2 "C:\Users\User\Desktop\AspNetHomework\SEDC.Homework02.ProductApp\SEDC.Homework02.ProductApp\Views\_ViewImports.cshtml"
using SEDC.Homework02.ProductApp.Models;

#line default
#line hidden
#line 3 "C:\Users\User\Desktop\AspNetHomework\SEDC.Homework02.ProductApp\SEDC.Homework02.ProductApp\Views\_ViewImports.cshtml"
using SEDC.Homework02.ProductApp.Models.Domain;

#line default
#line hidden
#line 4 "C:\Users\User\Desktop\AspNetHomework\SEDC.Homework02.ProductApp\SEDC.Homework02.ProductApp\Views\_ViewImports.cshtml"
using SEDC.Homework02.ProductApp.Models.Enums;

#line default
#line hidden
#line 5 "C:\Users\User\Desktop\AspNetHomework\SEDC.Homework02.ProductApp\SEDC.Homework02.ProductApp\Views\_ViewImports.cshtml"
using SEDC.Homework02.ProductApp.Models.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88d18dcd3d1c8c32370036d2ac57c553d877b953", @"/Views/product/Products.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f5b0a62be3e45f89c2731a286553a28a1a55fea6", @"/Views/_ViewImports.cshtml")]
    public class Views_product_Products : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductListVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_seeProductDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateProduct", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\User\Desktop\AspNetHomework\SEDC.Homework02.ProductApp\SEDC.Homework02.ProductApp\Views\product\Products.cshtml"
  
    ViewData["Title"] = "Products";

#line default
#line hidden
            BeginContext(66, 27, true);
            WriteLiteral("\r\n<h2>Our products</h2>\r\n\r\n");
            EndContext();
#line 8 "C:\Users\User\Desktop\AspNetHomework\SEDC.Homework02.ProductApp\SEDC.Homework02.ProductApp\Views\product\Products.cshtml"
 if (ViewBag.Message != null)
{

#line default
#line hidden
            BeginContext(127, 45, true);
            WriteLiteral("    <div class=\" alert alert-info\">\r\n        ");
            EndContext();
            BeginContext(173, 15, false);
#line 11 "C:\Users\User\Desktop\AspNetHomework\SEDC.Homework02.ProductApp\SEDC.Homework02.ProductApp\Views\product\Products.cshtml"
   Write(ViewBag.Message);

#line default
#line hidden
            EndContext();
            BeginContext(188, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
#line 13 "C:\Users\User\Desktop\AspNetHomework\SEDC.Homework02.ProductApp\SEDC.Homework02.ProductApp\Views\product\Products.cshtml"
}

#line default
#line hidden
            BeginContext(205, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 15 "C:\Users\User\Desktop\AspNetHomework\SEDC.Homework02.ProductApp\SEDC.Homework02.ProductApp\Views\product\Products.cshtml"
 foreach (var product in Model.Products)
{

#line default
#line hidden
            BeginContext(252, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(256, 52, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d241801f78b44395b4ef3ca37f1bfb6a", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 17 "C:\Users\User\Desktop\AspNetHomework\SEDC.Homework02.ProductApp\SEDC.Homework02.ProductApp\Views\product\Products.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => product);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("for", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(308, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 18 "C:\Users\User\Desktop\AspNetHomework\SEDC.Homework02.ProductApp\SEDC.Homework02.ProductApp\Views\product\Products.cshtml"
}

#line default
#line hidden
            BeginContext(313, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(315, 97, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e249377ecb36409c8fd5fd197fa91b54", async() => {
                BeginContext(394, 14, true);
                WriteLiteral("Create Product");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(412, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductListVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
