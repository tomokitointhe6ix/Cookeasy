#pragma checksum "H:\comp229\Assignment01Boot\Assignment01Boot\Assignment01\Views\Review\ReviewList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ed7a61f2b4e4f86e99826c66ef1701e93e125be"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Assignment01.Models.Review.Views_Review_ReviewList), @"mvc.1.0.view", @"/Views/Review/ReviewList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Review/ReviewList.cshtml", typeof(Assignment01.Models.Review.Views_Review_ReviewList))]
namespace Assignment01.Models.Review
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ed7a61f2b4e4f86e99826c66ef1701e93e125be", @"/Views/Review/ReviewList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8bd53c872fe8cea6b92397ad3f1217e635deb4f9", @"/Views/_ViewImports.cshtml")]
    public class Views_Review_ReviewList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Review1>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "H:\comp229\Assignment01Boot\Assignment01Boot\Assignment01\Views\Review\ReviewList.cshtml"
  
    ViewBag.Title = "Review List";
    Layout = "_LayoutReview";

#line default
#line hidden
            BeginContext(103, 119, true);
            WriteLiteral("\r\n<!-- Main -->\r\n<div id=\"main\">\r\n\r\n    <!-- Main Content -->\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n");
            EndContext();
#line 13 "H:\comp229\Assignment01Boot\Assignment01Boot\Assignment01\Views\Review\ReviewList.cshtml"
             foreach (var p in Model)
            {

#line default
#line hidden
            BeginContext(276, 105, true);
            WriteLiteral("            <div class=\"12u\">\r\n                <header>\r\n                    <h4 class=\"bold\">Review ID: ");
            EndContext();
            BeginContext(382, 10, false);
#line 17 "H:\comp229\Assignment01Boot\Assignment01Boot\Assignment01\Views\Review\ReviewList.cshtml"
                                           Write(p.ReviewId);

#line default
#line hidden
            EndContext();
            BeginContext(392, 438, true);
            WriteLiteral(@"</h4>
                    <!-- <h2>
                        if (TempData[""message""] != null)
                            {
                                TempData[""message""]
                            }
                        </h2> -->
                </header>
                <section>
                    <h3 class=""bold"">Rating:</h3>
                    <p>
                        <span class=""star5_rating"" data-rate=""");
            EndContext();
            BeginContext(831, 8, false);
#line 28 "H:\comp229\Assignment01Boot\Assignment01Boot\Assignment01\Views\Review\ReviewList.cshtml"
                                                         Write(p.Rating);

#line default
#line hidden
            EndContext();
            BeginContext(839, 166, true);
            WriteLiteral("\"></span>\r\n                    </p>\r\n                </section>\r\n                <section>\r\n                    <h3 class=\"bold\">Review:</h3>\r\n                    <p>");
            EndContext();
            BeginContext(1006, 12, false);
#line 33 "H:\comp229\Assignment01Boot\Assignment01Boot\Assignment01\Views\Review\ReviewList.cshtml"
                  Write(p.ReviewBody);

#line default
#line hidden
            EndContext();
            BeginContext(1018, 78, true);
            WriteLiteral("</p>\r\n                </section>\r\n            </div>\r\n                <hr />\r\n");
            EndContext();
#line 37 "H:\comp229\Assignment01Boot\Assignment01Boot\Assignment01\Views\Review\ReviewList.cshtml"
            }

#line default
#line hidden
            BeginContext(1111, 60, true);
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n<!-- /Main Content -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Review1>> Html { get; private set; }
    }
}
#pragma warning restore 1591