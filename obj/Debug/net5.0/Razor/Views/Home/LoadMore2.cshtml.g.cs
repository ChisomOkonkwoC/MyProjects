#pragma checksum "C:\Users\hp\Desktop\Ecommerce\Views\Home\LoadMore2.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "035be407a7f6593af88d63b8e9ac16f0f46af8e9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_LoadMore2), @"mvc.1.0.view", @"/Views/Home/LoadMore2.cshtml")]
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
#line 1 "C:\Users\hp\Desktop\Ecommerce\Views\_ViewImports.cshtml"
using Ecommerce;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hp\Desktop\Ecommerce\Views\_ViewImports.cshtml"
using Ecommerce.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"035be407a7f6593af88d63b8e9ac16f0f46af8e9", @"/Views/Home/LoadMore2.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6bbcd7c65731fc074a835809e73fcf2cf9014c29", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_LoadMore2 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Ecommerce.ViewModel.UserProductViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\hp\Desktop\Ecommerce\Views\Home\LoadMore2.cshtml"
  
    ViewBag.Title = "Load More";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""review-nav-container"">
         <ul class=""review-nav"">
       <li><a href=""#"" class=""active"">Home</a></li>
       <li>/</li>
       <li><a href=""#"" style=""color: #262626;"">Hot Deals</a></li>
         </ul>

       </div>

       <div class=""hot-deals-container"">
         <div class=""hot-deals"" >
           <h3>Hot deals</h3>
           <div class=""numbers"">
           <li><a href=""#"">Nike</a></li>
          <p>15</p>
          </div>
          <div class=""numbers"">
           <li><a href=""#"">Air Max</a></li>
           <p>9</p>
          </div>
          <div class=""numbers"">
           <li><a href=""#"">Nike</a></li>
          <p>13</p>
          </div>
          <div class=""numbers"">
           <li><a href=""#"">Adidas</a></li>
           <p>14</p>
          </div>
          <div class=""numbers"">
           <li><a href=""#"">Vans</a></li>
          <p>12</p>
          </div>
          <div class=""numbers"">
           <li><a href=""#"">All Stars</a></li>
           <p>3");
            WriteLiteral(@"2</p>
          </div>
          <div class=""numbers"">
           <li><a href=""#"">Adidas</a></li>
           <p>11</p>
          </div>
          </div>
    <div class=""addidas-wrapper"">
      <div class=""addidas-container"">
          <div class=""addidas-text"">
              <h3>Addidas Men Running Sneakers</h3>
              <p>Performance and design. Taken right to the edge.</p>
              <a");
            BeginWriteAttribute("href", " href=\"", 1526, "\"", 1533, 0);
            EndWriteAttribute();
            WriteLiteral(">Shop Now</a>\r\n          </div>\r\n          <div class=\"addidas-img\">\r\n              <img src=\"images/shoes-shoe-png-transparent-shoe-images-pluspng-17 1.png\"");
            BeginWriteAttribute("alt", " alt=\"", 1691, "\"", 1697, 0);
            EndWriteAttribute();
            WriteLiteral(@" width=""500px"" >
  
          </div>
  
      </div>
      <div class=""arrangement"">
        <ul class=""sorting"">
        <li><a href=""#""> 13 items</a></li>
        <li><a href=""#"">Sort By</a></li>
        <li><a href=""#"">Name</a></li>
        <li><a href=""#""><i class=""fa fa-caret-down""></i></a></li>
        <li><a href=""#"">Show</a></li>
        <li><a href=""#"">12</a></li>
        <li><a href=""#""><i class=""fa fa-caret-down""></i></a></i></li>
        <div class=""bars"">
          <li><a href=""#""><i class=""fas fa-bars""></i></a></li>
          <li><a href=""#""><i class=""fas fa-grip-horizontal""></i></a></li>
        </div>
      </ul>

      </div>
  </div>
</div>

    
");
#nullable restore
#line 79 "C:\Users\hp\Desktop\Ecommerce\Views\Home\LoadMore2.cshtml"
         foreach(var product in Model.Paginate(Model.Products))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"loadmore-wrapper\">\r\n            <div class=\"loadmore-item\">\r\n              <div class=\"img-item\">\r\n                    <img");
            BeginWriteAttribute("src", " src=", 2619, "", 2645, 1);
#nullable restore
#line 84 "C:\Users\hp\Desktop\Ecommerce\Views\Home\LoadMore2.cshtml"
WriteAttributeValue("", 2624, product.ProductImage, 2624, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 2645, "\"", 2651, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                </div>
                <div class=""item-text"">
                <h3>Louis Vitton Express</h3>
                <p class=""stars  reviews"">
                    <span class=""fa fa-star checked""></span>
                    <span class=""fa fa-star checked""></span>
                    <span class=""fa fa-star checked""></span>
                    <span class=""fa fa-star""></span>
                    <span class=""fa fa-star""></span>
                    <span style=""color:#262626 ;""> 0 reviews</span>
                     <a href=""#"">submit a review</a>
                  </p>
                  <hr>
                  <div class=""load-price"">
                    <p >$");
#nullable restore
#line 99 "C:\Users\hp\Desktop\Ecommerce\Views\Home\LoadMore2.cshtml"
                    Write(product.UnitPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p>$");
#nullable restore
#line 100 "C:\Users\hp\Desktop\Ecommerce\Views\Home\LoadMore2.cshtml"
                   Write(product.DiscountedUnitPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p>");
#nullable restore
#line 101 "C:\Users\hp\Desktop\Ecommerce\Views\Home\LoadMore2.cshtml"
                  Write(product.PercentOff);

#line default
#line hidden
#nullable disable
            WriteLiteral("% Off</p>\r\n                  </div>\r\n        \r\n                  <p class=\"desc\"><strong>Description</strong> <br>");
#nullable restore
#line 104 "C:\Users\hp\Desktop\Ecommerce\Views\Home\LoadMore2.cshtml"
                                                              Write(product.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>


                  <div class=""cart"">
                    <a href=""#""><i class=""fas fa-shopping-cart""></i> Add to cart</a>
                    <a href=""#""><i class=""far fa-heart""></i></a>
                </div>

                </div>
           </div>
           <hr>
           
        </div>  
");
#nullable restore
#line 117 "C:\Users\hp\Desktop\Ecommerce\Views\Home\LoadMore2.cshtml"
        }   

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"pagination\">\r\n");
#nullable restore
#line 119 "C:\Users\hp\Desktop\Ecommerce\Views\Home\LoadMore2.cshtml"
     for(int i = 1; i <= Model.PageCount(Model.Products); i++)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <span");
            BeginWriteAttribute("class", " class=\"", 4052, "\"", 4112, 1);
#nullable restore
#line 121 "C:\Users\hp\Desktop\Ecommerce\Views\Home\LoadMore2.cshtml"
WriteAttributeValue("", 4060, i == Model.CurrentPage ? "index-active" : "index", 4060, 52, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 4130, "\"", 4177, 1);
#nullable restore
#line 122 "C:\Users\hp\Desktop\Ecommerce\Views\Home\LoadMore2.cshtml"
WriteAttributeValue("", 4137, Url.Action("LoadMore2", new {page = i}), 4137, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 122 "C:\Users\hp\Desktop\Ecommerce\Views\Home\LoadMore2.cshtml"
                                                          Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></span>\r\n");
#nullable restore
#line 123 "C:\Users\hp\Desktop\Ecommerce\Views\Home\LoadMore2.cshtml"
        Model.CurrentPage++;
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Ecommerce.ViewModel.UserProductViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
