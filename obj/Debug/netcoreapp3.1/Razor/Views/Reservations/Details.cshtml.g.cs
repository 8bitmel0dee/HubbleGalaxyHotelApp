#pragma checksum "C:\Users\newforce\Workspace\HubbleGalaxyHotelApp\HubbleGalaxyHotelApp\Views\Reservations\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "15c2517fdf42275fc76cd5912c6b1d5b420f8b25"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Reservations_Details), @"mvc.1.0.view", @"/Views/Reservations/Details.cshtml")]
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
#line 1 "C:\Users\newforce\Workspace\HubbleGalaxyHotelApp\HubbleGalaxyHotelApp\Views\_ViewImports.cshtml"
using HubbleGalaxyHotelApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\newforce\Workspace\HubbleGalaxyHotelApp\HubbleGalaxyHotelApp\Views\_ViewImports.cshtml"
using HubbleGalaxyHotelApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"15c2517fdf42275fc76cd5912c6b1d5b420f8b25", @"/Views/Reservations/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d547e90031fb0e71c0e569a279cbb82358a9021d", @"/Views/_ViewImports.cshtml")]
    public class Views_Reservations_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HubbleGalaxyHotelApp.Models.Reservation>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-lg text-center float-left"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("body-reservation-details d-flex flex-column"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\newforce\Workspace\HubbleGalaxyHotelApp\HubbleGalaxyHotelApp\Views\Reservations\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "15c2517fdf42275fc76cd5912c6b1d5b420f8b255055", async() => {
                WriteLiteral("\r\n\r\n\r\n");
                WriteLiteral("\r\n");
#nullable restore
#line 20 "C:\Users\newforce\Workspace\HubbleGalaxyHotelApp\HubbleGalaxyHotelApp\Views\Reservations\Details.cshtml"
            
            // Created variables with End Date / Start Date / Price per Night data to calculate grand total
            
                var EndDate = Model.EndDate;
                var StartDate = Model.StartDate;
                var PricePerNight = Model.Room.PricePerNight;

            // Created variable to calculate length of stay 

                var LengthOfStay = (EndDate - StartDate);

            // Calculate num of nights * Price per night to get grand total

                var NumNights = String.Format("{0} night/s", LengthOfStay.Days);
                var CalculateTotal = LengthOfStay.Days * PricePerNight;
        

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
                WriteLiteral("\r\n        <div class=\"card bg-dark text-white border-white float-left\" \r\n             style=\r\n                    \"width: 25rem; \r\n                     margin-bottom: 35px;\">\r\n\r\n            <img class=\"card-img-top\"");
                BeginWriteAttribute("src", " src=\"", 1468, "\"", 1521, 1);
#nullable restore
#line 44 "C:\Users\newforce\Workspace\HubbleGalaxyHotelApp\HubbleGalaxyHotelApp\Views\Reservations\Details.cshtml"
WriteAttributeValue("", 1474, Html.DisplayFor(model => model.Room.RoomImage), 1474, 47, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" alt=\"RoomImage\">\r\n\r\n            <div class=\"card-body text-center border-top\">\r\n                <h1 class=\"card-title\" \r\n                    style=\r\n                         \"text-shadow: 2px 2px #000000;\"> \r\n                                ");
#nullable restore
#line 50 "C:\Users\newforce\Workspace\HubbleGalaxyHotelApp\HubbleGalaxyHotelApp\Views\Reservations\Details.cshtml"
                           Write(Html.DisplayFor(model => model.Room.RoomName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </h1>\r\n\r\n                <p class=\"card-text-start-date\" \r\n                   style=\r\n                        \"font-size: 25px; \r\n                         text-shadow: 2px 2px #000000;\">\r\n                              Start Date: ");
#nullable restore
#line 57 "C:\Users\newforce\Workspace\HubbleGalaxyHotelApp\HubbleGalaxyHotelApp\Views\Reservations\Details.cshtml"
                                     Write(Html.DisplayFor(model => model.StartDate));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </p>\r\n\r\n                <p class=\"card-text-end-date\" \r\n                   style=\r\n                        \"font-size: 25px; \r\n                         text-shadow: 2px 2px #000000;\"> \r\n                              End Date: ");
#nullable restore
#line 64 "C:\Users\newforce\Workspace\HubbleGalaxyHotelApp\HubbleGalaxyHotelApp\Views\Reservations\Details.cshtml"
                                   Write(Html.DisplayFor(model => model.EndDate));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </p>\r\n\r\n                <p class=\"number-nights\" \r\n                   style=\r\n                        \"font-size: 30px; \r\n                         text-shadow: 2px 2px #000000\">\r\n                              ");
#nullable restore
#line 71 "C:\Users\newforce\Workspace\HubbleGalaxyHotelApp\HubbleGalaxyHotelApp\Views\Reservations\Details.cshtml"
                         Write(NumNights);

#line default
#line hidden
#nullable disable
                WriteLiteral("  $");
#nullable restore
#line 71 "C:\Users\newforce\Workspace\HubbleGalaxyHotelApp\HubbleGalaxyHotelApp\Views\Reservations\Details.cshtml"
                                      Write(CalculateTotal);

#line default
#line hidden
#nullable disable
                WriteLiteral(".00\r\n                </p>\r\n\r\n            </div>\r\n        </div>\r\n\r\n        \r\n");
                WriteLiteral(@"
        <div class=""youtube-video-spaceshuttle-liftoff float-right border-white"" 
             style=
                  ""margin-bottom: 35px;"">

           <iframe width=""560""
                   height=""315""
                   src=""https://www.youtube.com/embed/OnoNITE-CLc""
                   frameborder=""1""
                   allowfullscreen>

           </iframe>
        </div>

        <div class=""youtube-video-bowie-space-oddity float-right border-white"" 
             style=
                  ""margin-bottom: 35px;"">

             <iframe width=""560"" 
                     height=""315"" 
                     src=""https://www.youtube.com/embed/iYYRH4apXDo"" 
                     frameborder=""1"" 
                     allow=""accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture"" 
                     allowfullscreen>

             </iframe>
        </div>

");
                WriteLiteral("\r\n             ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "15c2517fdf42275fc76cd5912c6b1d5b420f8b2510567", async() => {
                    WriteLiteral("Back to Home Page");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        \r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "style", 11, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 279, "background-image:", 279, 17, true);
            AddHtmlAttributeValue(" ", 296, "url(\'", 297, 6, true);
#nullable restore
#line 12 "C:\Users\newforce\Workspace\HubbleGalaxyHotelApp\HubbleGalaxyHotelApp\Views\Reservations\Details.cshtml"
AddHtmlAttributeValue("", 302, Url.Content("https://i.imgur.com/nWnkCsx.jpg"), 302, 47, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 349, "\');", 349, 3, true);
            AddHtmlAttributeValue("\r\n                 ", 352, "background-size:", 371, 35, true);
            AddHtmlAttributeValue(" ", 387, "auto;", 388, 6, true);
            AddHtmlAttributeValue(" \r\n                 ", 393, "background-position:", 413, 40, true);
            AddHtmlAttributeValue(" ", 433, "right", 434, 6, true);
            AddHtmlAttributeValue(" ", 439, "center;", 440, 8, true);
            AddHtmlAttributeValue(" \r\n                 ", 447, "min-height:", 467, 31, true);
            AddHtmlAttributeValue(" ", 478, "100vh;", 479, 7, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HubbleGalaxyHotelApp.Models.Reservation> Html { get; private set; }
    }
}
#pragma warning restore 1591
