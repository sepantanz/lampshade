#pragma checksum "E:\Tutorials\DotNet\Projects\Atriya\Lampshade\Lampshade\ServiceHost\Pages\Shared\Components\Slide\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1ce332cd3820d2628ba7b764052b4475c7edac81"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ServiceHost.Pages.Shared.Components.Slide.Pages_Shared_Components_Slide_Default), @"mvc.1.0.view", @"/Pages/Shared/Components/Slide/Default.cshtml")]
namespace ServiceHost.Pages.Shared.Components.Slide
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
#line 1 "E:\Tutorials\DotNet\Projects\Atriya\Lampshade\Lampshade\ServiceHost\Pages\_ViewImports.cshtml"
using ServiceHost;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ce332cd3820d2628ba7b764052b4475c7edac81", @"/Pages/Shared/Components/Slide/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"49bdd27e8b016acb3c031a38b8da4d14315ca499", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Shared_Components_Slide_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<_01_LampshadeQuery.Contracts.Slide.SlideQueryModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""hero-slider-area section-space"">
    <div class=""container wide"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <!--=======  hero slider wrapper  =======-->

                <div class=""hero-slider-wrapper"">
                    <div class=""ht-slick-slider"" data-slick-setting='{
                    ""slidesToShow"": 1,
                    ""slidesToScroll"": 1,
                    ""arrows"": true,
                    ""dots"": true,
                    ""autoplay"": true,
                    ""autoplaySpeed"": 5000,
                    ""speed"": 1000,
                    ""fade"": true,
                    ""infinite"": true,
                    ""prevArrow"": {""buttonClass"": ""slick-prev"", ""iconClass"": ""ion-chevron-left"" },
                    ""nextArrow"": {""buttonClass"": ""slick-next"", ""iconClass"": ""ion-chevron-right"" }
                }' data-slick-responsive='[
                    {""breakpoint"":1501, ""settings"": {""slidesToShow"": 1} },
                    {""bre");
            WriteLiteral(@"akpoint"":1199, ""settings"": {""slidesToShow"": 1, ""arrows"": false} },
                    {""breakpoint"":991, ""settings"": {""slidesToShow"": 1, ""arrows"": false} },
                    {""breakpoint"":767, ""settings"": {""slidesToShow"": 1, ""arrows"": false} },
                    {""breakpoint"":575, ""settings"": {""slidesToShow"": 1, ""arrows"": false} },
                    {""breakpoint"":479, ""settings"": {""slidesToShow"": 1, ""arrows"": false} }
                ]'>

");
#nullable restore
#line 31 "E:\Tutorials\DotNet\Projects\Atriya\Lampshade\Lampshade\ServiceHost\Pages\Shared\Components\Slide\Default.cshtml"
                         foreach (var slide in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"single-slider-item\">\r\n                                <div class=\"hero-slider-item-wrapper\">\r\n                                    <div class=\"container\">\r\n                                        <img");
            BeginWriteAttribute("src", " src=\"", 1868, "\"", 1888, 1);
#nullable restore
#line 36 "E:\Tutorials\DotNet\Projects\Atriya\Lampshade\Lampshade\ServiceHost\Pages\Shared\Components\Slide\Default.cshtml"
WriteAttributeValue("", 1874, slide.Picture, 1874, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1889, "\"", 1912, 1);
#nullable restore
#line 36 "E:\Tutorials\DotNet\Projects\Atriya\Lampshade\Lampshade\ServiceHost\Pages\Shared\Components\Slide\Default.cshtml"
WriteAttributeValue("", 1895, slide.PictureAlt, 1895, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 1913, "\"", 1940, 1);
#nullable restore
#line 36 "E:\Tutorials\DotNet\Projects\Atriya\Lampshade\Lampshade\ServiceHost\Pages\Shared\Components\Slide\Default.cshtml"
WriteAttributeValue("", 1921, slide.PictureTitle, 1921, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
                                        <div class=""row"">
                                            <div class=""col-lg-12"">
                                                <div class=""hero-slider-content hero-slider-content--left-space"">
                                                    <p class=""slider-title slider-title--big-light"">");
#nullable restore
#line 40 "E:\Tutorials\DotNet\Projects\Atriya\Lampshade\Lampshade\ServiceHost\Pages\Shared\Components\Slide\Default.cshtml"
                                                                                               Write(slide.Heading);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                                    <p class=\"slider-title slider-title--big-bold\">");
#nullable restore
#line 41 "E:\Tutorials\DotNet\Projects\Atriya\Lampshade\Lampshade\ServiceHost\Pages\Shared\Components\Slide\Default.cshtml"
                                                                                              Write(slide.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                                    <p class=\"slider-title slider-title--small\">\r\n                                                        ");
#nullable restore
#line 43 "E:\Tutorials\DotNet\Projects\Atriya\Lampshade\Lampshade\ServiceHost\Pages\Shared\Components\Slide\Default.cshtml"
                                                   Write(slide.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                    </p>\r\n                                                    <a class=\"hero-slider-button\"");
            BeginWriteAttribute("href", " href=\"", 2732, "\"", 2750, 1);
#nullable restore
#line 45 "E:\Tutorials\DotNet\Projects\Atriya\Lampshade\Lampshade\ServiceHost\Pages\Shared\Components\Slide\Default.cshtml"
WriteAttributeValue("", 2739, slide.Link, 2739, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                        ");
#nullable restore
#line 46 "E:\Tutorials\DotNet\Projects\Atriya\Lampshade\Lampshade\ServiceHost\Pages\Shared\Components\Slide\Default.cshtml"
                                                   Write(slide.BtnText);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" <i class=""ion-ios-plus-empty""></i>
                                                    </a>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                           </div>
");
#nullable restore
#line 54 "E:\Tutorials\DotNet\Projects\Atriya\Lampshade\Lampshade\ServiceHost\Pages\Shared\Components\Slide\Default.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n\r\n                <!--=======  End of hero slider wrapper  =======-->\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<_01_LampshadeQuery.Contracts.Slide.SlideQueryModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591