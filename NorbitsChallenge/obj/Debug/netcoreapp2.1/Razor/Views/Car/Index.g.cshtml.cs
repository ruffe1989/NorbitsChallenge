#pragma checksum "C:\Users\rolfi\Documents\MEGA\Koding\NorbitsChallenge-master\NorbitsChallenge\Views\Car\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "77697c05a73e10e4703c80b57f46ec53edad2f9c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Car_Index), @"mvc.1.0.view", @"/Views/Car/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Car/Index.cshtml", typeof(AspNetCore.Views_Car_Index))]
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
#line 1 "C:\Users\rolfi\Documents\MEGA\Koding\NorbitsChallenge-master\NorbitsChallenge\Views\_ViewImports.cshtml"
using NorbitsChallenge;

#line default
#line hidden
#line 2 "C:\Users\rolfi\Documents\MEGA\Koding\NorbitsChallenge-master\NorbitsChallenge\Views\_ViewImports.cshtml"
using NorbitsChallenge.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"77697c05a73e10e4703c80b57f46ec53edad2f9c", @"/Views/Car/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e65fe826c4f99cba2350d04008acb3da07bb983", @"/Views/_ViewImports.cshtml")]
    public class Views_Car_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CarViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ShowSingelCar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax", new global::Microsoft.AspNetCore.Html.HtmlString("true"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-method", new global::Microsoft.AspNetCore.Html.HtmlString("POST"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-success", new global::Microsoft.AspNetCore.Html.HtmlString("onSuccess"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteCar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-success", new global::Microsoft.AspNetCore.Html.HtmlString("deleteCar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(21, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\rolfi\Documents\MEGA\Koding\NorbitsChallenge-master\NorbitsChallenge\Views\Car\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(64, 90, true);
            WriteLiteral("\r\n<h2 class=\"text-center\">Oversikt over biler:</h2>\r\n\r\n<h3>Søk etter info om bil:</h3>\r\n\r\n");
            EndContext();
            BeginContext(154, 233, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9896829fa60c4ac387049cdf4dbcd89d", async() => {
                BeginContext(258, 122, true);
                WriteLiteral("\r\n    <input type=\"text\" name=\"licensePlate\" placeholder=\"Skriv inn reg. nr\" />\r\n    <input type=\"submit\" value=\"Søk\" />\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(387, 869, true);
            WriteLiteral(@"


    <table class=""table hidden table table-striped table-bordered"" id=""carInfo"">
        <thead>
            <tr>
                <th scope=""col"">Reg. nr:</th>
                <th scope=""col"">Beskrivelse:</th>
                <th scope=""col"">Modell:</th>
                <th scope=""col"">Merke:</th>
                <th scope=""col"">Antall dekk:</th>
            </tr>
        </thead>
        <tbody>
                <tr>
                    <th scope=""row""><div id=""licensePlate""></div></th>
                    <td><div id=""description""></div></td>
                    <td><div id=""model""></div></td>
                    <td><div id=""brand""></div></td>
                    <td><div id=""tireCount""></div></td>
                </tr>

          
        </tbody>
    </table>
<hr/>
<h3>Oversikt over alle biler registert på verkstedet:</h3>
");
            EndContext();
            BeginContext(1256, 1029, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a44ea97eacba4c5abf4cefd00b5475b9", async() => {
                BeginContext(1281, 387, true);
                WriteLiteral(@"
    <table class=""table table-striped table-bordered"">
        <thead>
            <tr>
                <th scope=""col"">Reg. nr:</th>
                <th scope=""col"">Beskrivelse:</th>
                <th scope=""col"">Modell:</th>
                <th scope=""col"">Merke:</th>
                <th scope=""col"">Antall dekk:</th>
            </tr>
        </thead>
        <tbody>
");
                EndContext();
#line 53 "C:\Users\rolfi\Documents\MEGA\Koding\NorbitsChallenge-master\NorbitsChallenge\Views\Car\Index.cshtml"
             foreach (var car in Model.Cars)
            {

#line default
#line hidden
                BeginContext(1729, 58, true);
                WriteLiteral("                <tr>\r\n                    <th scope=\"row\">");
                EndContext();
                BeginContext(1788, 16, false);
#line 56 "C:\Users\rolfi\Documents\MEGA\Koding\NorbitsChallenge-master\NorbitsChallenge\Views\Car\Index.cshtml"
                               Write(car.LicensePlate);

#line default
#line hidden
                EndContext();
                BeginContext(1804, 31, true);
                WriteLiteral("</th>\r\n                    <td>");
                EndContext();
                BeginContext(1836, 15, false);
#line 57 "C:\Users\rolfi\Documents\MEGA\Koding\NorbitsChallenge-master\NorbitsChallenge\Views\Car\Index.cshtml"
                   Write(car.Description);

#line default
#line hidden
                EndContext();
                BeginContext(1851, 31, true);
                WriteLiteral("</td>\r\n                    <td>");
                EndContext();
                BeginContext(1883, 9, false);
#line 58 "C:\Users\rolfi\Documents\MEGA\Koding\NorbitsChallenge-master\NorbitsChallenge\Views\Car\Index.cshtml"
                   Write(car.Model);

#line default
#line hidden
                EndContext();
                BeginContext(1892, 31, true);
                WriteLiteral("</td>\r\n                    <td>");
                EndContext();
                BeginContext(1924, 9, false);
#line 59 "C:\Users\rolfi\Documents\MEGA\Koding\NorbitsChallenge-master\NorbitsChallenge\Views\Car\Index.cshtml"
                   Write(car.Brand);

#line default
#line hidden
                EndContext();
                BeginContext(1933, 31, true);
                WriteLiteral("</td>\r\n                    <td>");
                EndContext();
                BeginContext(1965, 13, false);
#line 60 "C:\Users\rolfi\Documents\MEGA\Koding\NorbitsChallenge-master\NorbitsChallenge\Views\Car\Index.cshtml"
                   Write(car.TireCount);

#line default
#line hidden
                EndContext();
                BeginContext(1978, 31, true);
                WriteLiteral("</td>\r\n                    <td>");
                EndContext();
                BeginContext(2010, 189, false);
#line 61 "C:\Users\rolfi\Documents\MEGA\Koding\NorbitsChallenge-master\NorbitsChallenge\Views\Car\Index.cshtml"
                   Write(Html.ActionLink("Slett", "DeleteCar",
                       new { id = @car.LicensePlate }, 
                       new {onclick= "return confirm('Er du sikker på at du vil slette?');"}));

#line default
#line hidden
                EndContext();
                BeginContext(2199, 30, true);
                WriteLiteral("</td>\r\n                </tr>\r\n");
                EndContext();
#line 65 "C:\Users\rolfi\Documents\MEGA\Koding\NorbitsChallenge-master\NorbitsChallenge\Views\Car\Index.cshtml"

            }

#line default
#line hidden
                BeginContext(2246, 32, true);
                WriteLiteral("        </tbody>\r\n    </table>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2285, 40, true);
            WriteLiteral("\r\n\r\n<h3>Slett en bil i databasen:</h3>\r\n");
            EndContext();
            BeginContext(2325, 237, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fe368a57f36e42d1a8acfc3f72a871f2", async() => {
                BeginContext(2425, 130, true);
                WriteLiteral("\r\n    <input type=\"text\" name=\"licensePlate\" placeholder=\"Skriv inn reg. nr\" />\r\n    <input type=\"submit\" value=\"Slett bil\" />\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2562, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2589, 628, true);
                WriteLiteral(@"
    <script type=""text/javascript"">
        function onSuccess(data) {
            var licensePlate = data[0].licensePlate;
            var description = data[1];
            var model = data[2];
            var brand = data[3];
            var tireCount = data[4];
            console.log(licensePlate)
            $('#licensePlate').text(licensePlate);
            $('#description').text(description);
            $('#model').text(model);
            $('#brand').text(brand);
            $('#tireCount').text(tireCount);
            $('#carInfo').removeClass('hidden');
            
        }
    </script>
");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CarViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
