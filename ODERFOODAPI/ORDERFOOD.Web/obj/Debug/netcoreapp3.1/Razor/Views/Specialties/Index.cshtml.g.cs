#pragma checksum "E:\ODERFOODAPI\ORDERFOOD.Web\Views\Specialties\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fcb8655e851cfe60b78333410a1391337bf7ba0f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Specialties_Index), @"mvc.1.0.view", @"/Views/Specialties/Index.cshtml")]
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
#line 1 "E:\ODERFOODAPI\ORDERFOOD.Web\Views\_ViewImports.cshtml"
using ORDERFOOD.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\ODERFOODAPI\ORDERFOOD.Web\Views\_ViewImports.cshtml"
using ORDERFOOD.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fcb8655e851cfe60b78333410a1391337bf7ba0f", @"/Views/Specialties/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a1f761c6e1edd13754415c1ca42cf09563d3872", @"/Views/_ViewImports.cshtml")]
    public class Views_Specialties_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "OrderFood", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"<section class=""hero-wrap hero-wrap-2"" style=""background-image: url('images/bg_4.jpg');"" data-stellar-background-ratio=""0.5"">
    <div class=""overlay""></div>
    <div class=""container"">
        <div class=""row no-gutters slider-text align-items-center justify-content-center"">
            <div class=""col-md-9 ftco-animate text-center"">
                <h1 class=""mb-2 bread"">Specialties</h1>
                <p class=""breadcrumbs""><span class=""mr-2""><a href=""index.html"">Home <i class=""ion-ios-arrow-forward""></i></a></span> <span>Menu <i class=""ion-ios-arrow-forward""></i></span></p>
            </div>
        </div>
    </div>
</section>


<section class=""ftco-section"">
    <div class=""container"">
        <div class=""row justify-content-center mb-5 pb-2"">
            <div class=""col-md-7 text-center heading-section ftco-animate"">
                <span class=""subheading"">Specialties</span>
                <h2 class=""mb-4"">Our Menu</h2>
            </div>
        </div>
        <div class=""row""");
            WriteLiteral(">\r\n            <div class=\"col-md-6 col-lg-4 menu-wrap\">\r\n                <div class=\"heading-menu text-center ftco-animate\">\r\n                    <h3>Breakfast</h3>\r\n                </div>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fcb8655e851cfe60b78333410a1391337bf7ba0f4948", async() => {
                WriteLiteral(@"
                    <div class=""menus d-flex ftco-animate "">

                        <div class=""menu-img img"" style=""background-image: url(images/breakfast-1.jpg);""></div>
                        <div class=""text"">
                            <div class=""d-flex"">
                                <div class=""one-half"">
                                    <h3>Grilled Beef with potatoes</h3>
                                </div>
                                <div class=""one-forth"">
                                    <span class=""price"">$29</span>
                                </div>
                            </div>
                            <p><span>Meat</span>, <span>Potatoes</span>, <span>Rice</span>, <span>Tomatoe</span></p>
                        </div>
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                <div class=""menus d-flex ftco-animate"">
                    <div class=""menu-img img"" style=""background-image: url(images/breakfast-2.jpg);""></div>
                    <div class=""text"">
                        <div class=""d-flex"">
                            <div class=""one-half"">
                                <h3>Grilled Crab with Onion</h3>
                            </div>
                            <div class=""one-forth"">
                                <span class=""price"">$29</span>
                            </div>
                        </div>
                        <p><span>Meat</span>, <span>Potatoes</span>, <span>Rice</span>, <span>Tomatoe</span></p>
                    </div>
                </div>
               
            </div>

            <div class=""col-md-6 col-lg-4 menu-wrap"">
                <div class=""heading-menu text-center ftco-animate"">
                    <h3>Lunch</h3>
                </div>
                <div class=""menus d-flex f");
            WriteLiteral(@"tco-animate"">
                    <div class=""menu-img img"" style=""background-image: url(images/lunch-1.jpg);""></div>
                    <div class=""text"">
                        <div class=""d-flex"">
                            <div class=""one-half"">
                                <h3>Grilled Beef with potatoes</h3>
                            </div>
                            <div class=""one-forth"">
                                <span class=""price"">$29</span>
                            </div>
                        </div>
                        <p><span>Meat</span>, <span>Potatoes</span>, <span>Rice</span>, <span>Tomatoe</span></p>
                    </div>
                </div>
                <div class=""menus d-flex ftco-animate"">
                    <div class=""menu-img img"" style=""background-image: url(images/lunch-2.jpg);""></div>
                    <div class=""text"">
                        <div class=""d-flex"">
                            <div class=""one-half"">
          ");
            WriteLiteral(@"                      <h3>Grilled Crab with Onion</h3>
                            </div>
                            <div class=""one-forth"">
                                <span class=""price"">$29</span>
                            </div>
                        </div>
                        <p><span>Meat</span>, <span>Potatoes</span>, <span>Rice</span>, <span>Tomatoe</span></p>
                    </div>
                </div>
               
            </div>

            <div class=""col-md-6 col-lg-4 menu-wrap"">
                <div class=""heading-menu text-center ftco-animate"">
                    <h3>Dinner</h3>
                </div>
                <div class=""menus d-flex ftco-animate"">
                    <div class=""menu-img img"" style=""background-image: url(images/dinner-1.jpg);""></div>
                    <div class=""text"">
                        <div class=""d-flex"">
                            <div class=""one-half"">
                                <h3>Grilled Beef with po");
            WriteLiteral(@"tatoes</h3>
                            </div>
                            <div class=""one-forth"">
                                <span class=""price"">$29</span>
                            </div>
                        </div>
                        <p><span>Meat</span>, <span>Potatoes</span>, <span>Rice</span>, <span>Tomatoe</span></p>
                    </div>
                </div>
                <div class=""menus d-flex ftco-animate"">
                    <div class=""menu-img img"" style=""background-image: url(images/dinner-2.jpg);""></div>
                    <div class=""text"">
                        <div class=""d-flex"">
                            <div class=""one-half"">
                                <h3>Grilled Crab with Onion</h3>
                            </div>
                            <div class=""one-forth"">
                                <span class=""price"">$29</span>
                            </div>
                        </div>
                        <p><span>Mea");
            WriteLiteral(@"t</span>, <span>Potatoes</span>, <span>Rice</span>, <span>Tomatoe</span></p>
                    </div>
                </div>
               
            </div>

            <!--  -->
            <div class=""col-md-6 col-lg-4 menu-wrap"">
                <div class=""heading-menu text-center ftco-animate"">
                    <h3>Desserts</h3>
                </div>
                <div class=""menus d-flex ftco-animate"">
                    <div class=""menu-img img"" style=""background-image: url(images/dessert-1.jpg);""></div>
                    <div class=""text"">
                        <div class=""d-flex"">
                            <div class=""one-half"">
                                <h3>Grilled Beef with potatoes</h3>
                            </div>
                            <div class=""one-forth"">
                                <span class=""price"">$29</span>
                            </div>
                        </div>
                        <p><span>Meat</span>, <span>P");
            WriteLiteral(@"otatoes</span>, <span>Rice</span>, <span>Tomatoe</span></p>
                    </div>
                </div>
                <div class=""menus d-flex ftco-animate"">
                    <div class=""menu-img img"" style=""background-image: url(images/dessert-2.jpg);""></div>
                    <div class=""text"">
                        <div class=""d-flex"">
                            <div class=""one-half"">
                                <h3>Grilled Crab with Onion</h3>
                            </div>
                            <div class=""one-forth"">
                                <span class=""price"">$29</span>
                            </div>
                        </div>
                        <p><span>Meat</span>, <span>Potatoes</span>, <span>Rice</span>, <span>Tomatoe</span></p>
                    </div>
                </div>
                <div class=""menus d-flex ftco-animate"">
                    <div class=""menu-img img"" style=""background-image: url(images/dessert-3.jpg);"">");
            WriteLiteral(@"</div>
                    <div class=""text"">
                        <div class=""d-flex"">
                            <div class=""one-half"">
                                <h3>Grilled Crab with Onion</h3>
                            </div>
                            <div class=""one-forth"">
                                <span class=""price"">$29</span>
                            </div>
                        </div>
                        <p><span>Meat</span>, <span>Potatoes</span>, <span>Rice</span>, <span>Tomatoe</span></p>
                    </div>
                </div>
               
            </div>

            <div class=""col-md-6 col-lg-4 menu-wrap"">
                <div class=""heading-menu text-center ftco-animate"">
                    <h3>Wine Card</h3>
                </div>
                <div class=""menus d-flex ftco-animate"">
                    <div class=""menu-img img"" style=""background-image: url(images/wine-1.jpg);""></div>
                    <div class=""text""");
            WriteLiteral(@">
                        <div class=""d-flex"">
                            <div class=""one-half"">
                                <h3>Grilled Beef with potatoes</h3>
                            </div>
                            <div class=""one-forth"">
                                <span class=""price"">$29</span>
                            </div>
                        </div>
                        <p><span>Meat</span>, <span>Potatoes</span>, <span>Rice</span>, <span>Tomatoe</span></p>
                    </div>
                </div>
                <div class=""menus d-flex ftco-animate"">
                    <div class=""menu-img img"" style=""background-image: url(images/wine-2.jpg);""></div>
                    <div class=""text"">
                        <div class=""d-flex"">
                            <div class=""one-half"">
                                <h3>Grilled Crab with Onion</h3>
                            </div>
                            <div class=""one-forth"">
             ");
            WriteLiteral(@"                   <span class=""price"">$29</span>
                            </div>
                        </div>
                        <p><span>Meat</span>, <span>Potatoes</span>, <span>Rice</span>, <span>Tomatoe</span></p>
                    </div>
                </div>
                <div class=""menus d-flex ftco-animate"">
                    <div class=""menu-img img"" style=""background-image: url(images/wine-3.jpg);""></div>
                    <div class=""text"">
                        <div class=""d-flex"">
                            <div class=""one-half"">
                                <h3>Grilled Crab with Onion</h3>
                            </div>
                            <div class=""one-forth"">
                                <span class=""price"">$29</span>
                            </div>
                        </div>
                        <p><span>Meat</span>, <span>Potatoes</span>, <span>Rice</span>, <span>Tomatoe</span></p>
                    </div>
           ");
            WriteLiteral(@"     </div>
              
            </div>

            <div class=""col-md-6 col-lg-4 menu-wrap"">
                <div class=""heading-menu text-center ftco-animate"">
                    <h3>Drinks</h3>
                </div>
                <div class=""menus d-flex ftco-animate"">
                    <div class=""menu-img img"" style=""background-image: url(images/drink-1.jpg);""></div>
                    <div class=""text"">
                        <div class=""d-flex"">
                            <div class=""one-half"">
                                <h3>Grilled Beef with potatoes</h3>
                            </div>
                            <div class=""one-forth"">
                                <span class=""price"">$29</span>
                            </div>
                        </div>
                        <p><span>Meat</span>, <span>Potatoes</span>, <span>Rice</span>, <span>Tomatoe</span></p>
                    </div>
                </div>
                <div class=""menu");
            WriteLiteral(@"s d-flex ftco-animate"">
                    <div class=""menu-img img"" style=""background-image: url(images/drink-2.jpg);""></div>
                    <div class=""text"">
                        <div class=""d-flex"">
                            <div class=""one-half"">
                                <h3>Grilled Crab with Onion</h3>
                            </div>
                            <div class=""one-forth"">
                                <span class=""price"">$29</span>
                            </div>
                        </div>
                        <p><span>Meat</span>, <span>Potatoes</span>, <span>Rice</span>, <span>Tomatoe</span></p>
                    </div>
                </div>
                <div class=""menus d-flex ftco-animate"">
                    <div class=""menu-img img"" style=""background-image: url(images/drink-3.jpg);""></div>
                    <div class=""text"">
                        <div class=""d-flex"">
                            <div class=""one-half"">
   ");
            WriteLiteral(@"                             <h3>Grilled Crab with Onion</h3>
                            </div>
                            <div class=""one-forth"">
                                <span class=""price"">$29</span>
                            </div>
                        </div>
                        <p><span>Meat</span>, <span>Potatoes</span>, <span>Rice</span>, <span>Tomatoe</span></p>
                    </div>
                </div>
               
            </div>
        </div>
    </div>

</section>
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