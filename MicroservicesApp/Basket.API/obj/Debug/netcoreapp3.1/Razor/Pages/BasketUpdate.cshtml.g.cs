#pragma checksum "C:\Users\User\Desktop\C#\MicroservicesApp\MicroservicesApp\Basket.API\Pages\BasketUpdate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "378d35fb2783e58c11cc5a609398bce090f33452"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_BasketUpdate), @"mvc.1.0.razor-page", @"/Pages/BasketUpdate.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"378d35fb2783e58c11cc5a609398bce090f33452", @"/Pages/BasketUpdate.cshtml")]
    public class Pages_BasketUpdate : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\User\Desktop\C#\MicroservicesApp\MicroservicesApp\Basket.API\Pages\BasketUpdate.cshtml"
  
    ViewData["Title"] = "Update Basket";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>");
#nullable restore
#line 6 "C:\Users\User\Desktop\C#\MicroservicesApp\MicroservicesApp\Basket.API\Pages\BasketUpdate.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>

<form method=""post"">
    <div asp-validation-summary=""All""></div>
    <input asp-for=""basketCart.Id"" type=""hidden"" />
    <div>
        <label>Username</label>
        <div>
            <input asp-for=""basketCart.Username"" />
            <span asp-validation-for=""basketCart.Username""></span>
        </div>
    </div>
    <div>
        <label>Items</label>
        <div>
            <input asp-for=""basketCart.Items"" />
            <span asp-validation-for=""basketCart.Items""></span>
        </div>
    </div>
    <div>
        <label>Total Price</label>
        <div>
            <input asp-for=""basketCart.TotalPrice"" />
            <span asp-validation-for=""basketCart.TotalPrice""></span>
        </div>
    </div>
    <div>
        <input type=""submit"" value=""Save"" />
    </div>
</form>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Basket.API.Pages.BasketUpdateModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Basket.API.Pages.BasketUpdateModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Basket.API.Pages.BasketUpdateModel>)PageContext?.ViewData;
        public Basket.API.Pages.BasketUpdateModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591