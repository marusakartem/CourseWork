#pragma checksum "D:\!_DOCS\Desktop\Артем\Курсовая робота\2\Shop.Web\Views\Account\Profile.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "a858e3c52b3d23d2924cd110d39f0688949558fb59154ffbbbfe66cf3d9419f5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Profile), @"mvc.1.0.view", @"/Views/Account/Profile.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/Profile.cshtml", typeof(AspNetCore.Views_Account_Profile))]
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
#line 1 "D:\!_DOCS\Desktop\Артем\Курсовая робота\2\Shop.Web\Views\_ViewImports.cshtml"
using Shop.Web;

#line default
#line hidden
#line 2 "D:\!_DOCS\Desktop\Артем\Курсовая робота\2\Shop.Web\Views\_ViewImports.cshtml"
using Shop.Web.Models;

#line default
#line hidden
#line 2 "D:\!_DOCS\Desktop\Артем\Курсовая робота\2\Shop.Web\Views\Account\Profile.cshtml"
using System.Globalization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"a858e3c52b3d23d2924cd110d39f0688949558fb59154ffbbbfe66cf3d9419f5", @"/Views/Account/Profile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"051d21b7fd6ca2eaeaacf59afe11c4950e07ec28787593cff88f6fe0a5341170", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Profile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Shop.Web.Models.Account.AccountProfileModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary followbtn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Settings", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Food", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(81, 340, true);
            WriteLiteral(@"

<link href=""https://maxcdn.bootstrapcdn.com/font-awesome/4.3.0/css/font-awesome.min.css"" rel=""stylesheet"">


<div class=""container"">
    <div class=""row"">
        <div class=""col-md-12 text-center "">
            <div class=""panel"">
                <div class=""userprofile social "">
                    <div class=""userpic""> <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 421, "\"", 442, 1);
#line 13 "D:\!_DOCS\Desktop\Артем\Курсовая робота\2\Shop.Web\Views\Account\Profile.cshtml"
WriteAttributeValue("", 427, Model.ImageUrl, 427, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 443, "\"", 449, 0);
            EndWriteAttribute();
            BeginContext(450, 91, true);
            WriteLiteral(" class=\"userpicimg\" style=\"height:100%;\"> </div>\r\n                    <h3 class=\"username\">");
            EndContext();
            BeginContext(542, 15, false);
#line 14 "D:\!_DOCS\Desktop\Артем\Курсовая робота\2\Shop.Web\Views\Account\Profile.cshtml"
                                    Write(Model.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(557, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(559, 14, false);
#line 14 "D:\!_DOCS\Desktop\Артем\Курсовая робота\2\Shop.Web\Views\Account\Profile.cshtml"
                                                     Write(Model.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(573, 30, true);
            WriteLiteral("</h3>\r\n                    <p>");
            EndContext();
            BeginContext(605, 13, false);
#line 15 "D:\!_DOCS\Desktop\Артем\Курсовая робота\2\Shop.Web\Views\Account\Profile.cshtml"
                   Write(Model.Country);

#line default
#line hidden
            EndContext();
            BeginContext(619, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(622, 10, false);
#line 15 "D:\!_DOCS\Desktop\Артем\Курсовая робота\2\Shop.Web\Views\Account\Profile.cshtml"
                                    Write(Model.City);

#line default
#line hidden
            EndContext();
            BeginContext(633, 295, true);
            WriteLiteral(@"</p>
                </div>
                <div class=""col-md-12 border-top border-bottom"">
                    <ul class=""nav nav-pills pull-left countlist"" role=""tablist"">
                        <li role=""presentation"">
                            <h3>
                                ");
            EndContext();
            BeginContext(929, 19, false);
#line 21 "D:\!_DOCS\Desktop\Артем\Курсовая робота\2\Shop.Web\Views\Account\Profile.cshtml"
                           Write(Model.BalanceFormat);

#line default
#line hidden
            EndContext();
            BeginContext(948, 244, true);
            WriteLiteral("<br>\r\n                                <small>Balance</small>\r\n                            </h3>\r\n                        </li>\r\n                        <li role=\"presentation\">\r\n                            <h3>\r\n                                ");
            EndContext();
            BeginContext(1193, 16, false);
#line 27 "D:\!_DOCS\Desktop\Артем\Курсовая робота\2\Shop.Web\Views\Account\Profile.cshtml"
                           Write(Model.OrderCount);

#line default
#line hidden
            EndContext();
            BeginContext(1209, 250, true);
            WriteLiteral("<br>\r\n                                <small>Orders placed</small>\r\n                            </h3>\r\n                        </li>\r\n                        <li role=\"presentation\">\r\n                            <h3>\r\n                                ");
            EndContext();
            BeginContext(1460, 40, false);
#line 33 "D:\!_DOCS\Desktop\Артем\Курсовая робота\2\Shop.Web\Views\Account\Profile.cshtml"
                           Write(Model.MemberSince.ToString("dd/MM/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(1500, 160, true);
            WriteLiteral("<br>\r\n                                <small>Member since</small>\r\n                            </h3>\r\n                        </li>\r\n                    </ul>\r\n");
            EndContext();
#line 38 "D:\!_DOCS\Desktop\Артем\Курсовая робота\2\Shop.Web\Views\Account\Profile.cshtml"
                     if(User.IsInRole("Admin"))
                    {

#line default
#line hidden
            BeginContext(1732, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(1756, 128, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a858e3c52b3d23d2924cd110d39f0688949558fb59154ffbbbfe66cf3d9419f59932", async() => {
                BeginContext(1844, 36, true);
                WriteLiteral("Settings <i class=\"fas fa-cogs\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-userId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 40 "D:\!_DOCS\Desktop\Артем\Курсовая робота\2\Shop.Web\Views\Account\Profile.cshtml"
                                                                                         WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-userId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1884, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 41 "D:\!_DOCS\Desktop\Артем\Курсовая робота\2\Shop.Web\Views\Account\Profile.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(1958, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(1982, 99, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a858e3c52b3d23d2924cd110d39f0688949558fb59154ffbbbfe66cf3d9419f512787", async() => {
                BeginContext(2041, 36, true);
                WriteLiteral("Settings <i class=\"fas fa-cogs\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2081, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 45 "D:\!_DOCS\Desktop\Артем\Курсовая робота\2\Shop.Web\Views\Account\Profile.cshtml"
                    }

#line default
#line hidden
            BeginContext(2106, 283, true);
            WriteLiteral(@"                </div>
                <div class=""clearfix"" style=""background-color:#f8f8f8""></div>
            </div>
        </div>
        <!-- /.col-md-12 -->
        <div class=col-md-8>
            <div clas=""panel panel-default"">
                <p>Latest orders</p>
");
            EndContext();
#line 54 "D:\!_DOCS\Desktop\Артем\Курсовая робота\2\Shop.Web\Views\Account\Profile.cshtml"
                 if(Model.OrderCount == 0)
                {

#line default
#line hidden
            BeginContext(2452, 77, true);
            WriteLiteral("                    <p>It looks like you havn\'t ordered anything yet...</p>\r\n");
            EndContext();
#line 57 "D:\!_DOCS\Desktop\Артем\Курсовая робота\2\Shop.Web\Views\Account\Profile.cshtml"
                }

#line default
#line hidden
#line 58 "D:\!_DOCS\Desktop\Артем\Курсовая робота\2\Shop.Web\Views\Account\Profile.cshtml"
                 foreach(var item in Model.LatestOrders)
                {

#line default
#line hidden
            BeginContext(2625, 463, true);
            WriteLiteral(@"                    <div class=""col-md-8 col-sm-12 pull-left posttimeline"">
                        <div class=""panel-group"" id=""accordion"">
                            <div class=""panel panel-default"">
                                <div class=""panel-heading"" style=""background-color: rgba(248,248,248,0.7)"">
                                    <h4 class=""panel-title"">
                                        <p style=""color:rgb(62, 80, 89)"">Order Total: ");
            EndContext();
            BeginContext(3090, 21, false);
#line 65 "D:\!_DOCS\Desktop\Артем\Курсовая робота\2\Shop.Web\Views\Account\Profile.cshtml"
                                                                                  Write(item.OrderTotalFormat);

#line default
#line hidden
            EndContext();
            BeginContext(3112, 147, true);
            WriteLiteral("</p>\r\n                                        <div>\r\n                                            <a data-toggle=\"collapse\" data-parent=\"#accordion\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3259, "\"", 3295, 2);
            WriteAttributeValue("", 3266, "#collapse-", 3266, 10, true);
#line 67 "D:\!_DOCS\Desktop\Артем\Курсовая робота\2\Shop.Web\Views\Account\Profile.cshtml"
WriteAttributeValue("", 3276, item.GetHashCode(), 3276, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3296, 277, true);
            WriteLiteral(@">
                                                Details
                                            </a>
                                        </div>
                                    </h4>
                                </div>
                                <div");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 3573, "\"", 3606, 2);
            WriteAttributeValue("", 3578, "collapse-", 3578, 9, true);
#line 73 "D:\!_DOCS\Desktop\Артем\Курсовая робота\2\Shop.Web\Views\Account\Profile.cshtml"
WriteAttributeValue("", 3587, item.GetHashCode(), 3587, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3607, 806, true);
            WriteLiteral(@" class=""panel-collapse collapse"">
                                    <div class=""panel-body"">
                                        <table class=""table table-bordered table-striped table-hover table-dark"">
                                            <thead>
                                                <tr>
                                                    <th>Selected amount</th>
                                                    <th>Product</th>
                                                    <th class=""text-right"">Price</th>
                                                    <th class=""text-right"">Subtotal</th>
                                                </tr>
                                            </thead>
                                            <tbody>
");
            EndContext();
#line 85 "D:\!_DOCS\Desktop\Артем\Курсовая робота\2\Shop.Web\Views\Account\Profile.cshtml"
                                                 foreach (var line in item.OrderLines)
                                                {

#line default
#line hidden
            BeginContext(4552, 138, true);
            WriteLiteral("                                                    <tr>\r\n                                                        <td class=\"text-center\">");
            EndContext();
            BeginContext(4691, 11, false);
#line 88 "D:\!_DOCS\Desktop\Артем\Курсовая робота\2\Shop.Web\Views\Account\Profile.cshtml"
                                                                           Write(line.Amount);

#line default
#line hidden
            EndContext();
            BeginContext(4702, 85, true);
            WriteLiteral("</td>\r\n                                                        <td class=\"text-left\">");
            EndContext();
            BeginContext(4787, 115, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a858e3c52b3d23d2924cd110d39f0688949558fb59154ffbbbfe66cf3d9419f519723", async() => {
                BeginContext(4883, 14, false);
#line 89 "D:\!_DOCS\Desktop\Артем\Курсовая робота\2\Shop.Web\Views\Account\Profile.cshtml"
                                                                                                                                                                        Write(line.Food.Name);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 89 "D:\!_DOCS\Desktop\Артем\Курсовая робота\2\Shop.Web\Views\Account\Profile.cshtml"
                                                                                                                                                 WriteLiteral(line.Food.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4902, 86, true);
            WriteLiteral("</td>\r\n                                                        <td class=\"text-right\">");
            EndContext();
            BeginContext(4990, 67, false);
#line 90 "D:\!_DOCS\Desktop\Артем\Курсовая робота\2\Shop.Web\Views\Account\Profile.cshtml"
                                                                           Write(line.Price.ToString("c",CultureInfo.CreateSpecificCulture("en-US")));

#line default
#line hidden
            EndContext();
            BeginContext(5058, 148, true);
            WriteLiteral("</td>\r\n                                                        <td class=\"text-right\">\r\n                                                            ");
            EndContext();
            BeginContext(5208, 83, false);
#line 92 "D:\!_DOCS\Desktop\Артем\Курсовая робота\2\Shop.Web\Views\Account\Profile.cshtml"
                                                        Write((line.Amount * line.Price).ToString("c",CultureInfo.CreateSpecificCulture("en-US")));

#line default
#line hidden
            EndContext();
            BeginContext(5292, 124, true);
            WriteLiteral("\r\n                                                        </td>\r\n                                                    </tr>\r\n");
            EndContext();
#line 95 "D:\!_DOCS\Desktop\Артем\Курсовая робота\2\Shop.Web\Views\Account\Profile.cshtml"
                                                }

#line default
#line hidden
            BeginContext(5467, 394, true);
            WriteLiteral(@"                                            </tbody>
                                            <tfoot>
                                                <tr>
                                                    <td colspan=""3"" class=""text-right"">Total:</td>
                                                    <td class=""text-right"">
                                                        ");
            EndContext();
            BeginContext(5863, 21, false);
#line 101 "D:\!_DOCS\Desktop\Артем\Курсовая робота\2\Shop.Web\Views\Account\Profile.cshtml"
                                                    Write(item.OrderTotalFormat);

#line default
#line hidden
            EndContext();
            BeginContext(5885, 401, true);
            WriteLiteral(@"
                                                    </td>
                                                </tr>
                                            </tfoot>
                                        </table>
                                    </div>
                                </div>
                            </div>
                        </div> 
                    </div>
");
            EndContext();
#line 111 "D:\!_DOCS\Desktop\Артем\Курсовая робота\2\Shop.Web\Views\Account\Profile.cshtml"
                }

#line default
#line hidden
#line 112 "D:\!_DOCS\Desktop\Артем\Курсовая робота\2\Shop.Web\Views\Account\Profile.cshtml"
                 if(Model.OrderCount > Model.LatestOrders.Count())
                {
                    

#line default
#line hidden
#line 114 "D:\!_DOCS\Desktop\Артем\Курсовая робота\2\Shop.Web\Views\Account\Profile.cshtml"
                     if(User.IsInRole("Admin"))
                    {

#line default
#line hidden
            BeginContext(6464, 47, true);
            WriteLiteral("                        <a class=\"btn btn-info\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 6511, "\"", 6549, 2);
            WriteAttributeValue("", 6518, "/Order/Archive/page-1/", 6518, 22, true);
#line 116 "D:\!_DOCS\Desktop\Артем\Курсовая робота\2\Shop.Web\Views\Account\Profile.cshtml"
WriteAttributeValue("", 6540, Model.Id, 6540, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(6550, 11, true);
            WriteLiteral(">More</a>\r\n");
            EndContext();
#line 117 "D:\!_DOCS\Desktop\Артем\Курсовая робота\2\Shop.Web\Views\Account\Profile.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(6633, 88, true);
            WriteLiteral("                        <a class=\"btn btn-info\" href=\"/Order/Archive/page-1\" >More</a>\r\n");
            EndContext();
#line 121 "D:\!_DOCS\Desktop\Артем\Курсовая робота\2\Shop.Web\Views\Account\Profile.cshtml"
                    }

#line default
#line hidden
#line 121 "D:\!_DOCS\Desktop\Артем\Курсовая робота\2\Shop.Web\Views\Account\Profile.cshtml"
                     
                }

#line default
#line hidden
            BeginContext(6763, 297, true);
            WriteLiteral(@"            </div>
        </div>
        <div class=""col-md-4 col-sm-12 pull-right"">
            <div class=""panel panel-default"">
                <div class=""panel-heading"">
                    <h1 class=""page-header small"">Personal Details</h1>
                    <p class=""small"">Name: ");
            EndContext();
            BeginContext(7061, 15, false);
#line 129 "D:\!_DOCS\Desktop\Артем\Курсовая робота\2\Shop.Web\Views\Account\Profile.cshtml"
                                      Write(Model.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(7076, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(7078, 14, false);
#line 129 "D:\!_DOCS\Desktop\Артем\Курсовая робота\2\Shop.Web\Views\Account\Profile.cshtml"
                                                       Write(Model.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(7092, 50, true);
            WriteLiteral("</p>\r\n                    <p class=\"small\">Email: ");
            EndContext();
            BeginContext(7143, 11, false);
#line 130 "D:\!_DOCS\Desktop\Артем\Курсовая робота\2\Shop.Web\Views\Account\Profile.cshtml"
                                       Write(Model.Email);

#line default
#line hidden
            EndContext();
            BeginContext(7154, 49, true);
            WriteLiteral("</p>\r\n                    <p class=\"small\">Role: ");
            EndContext();
            BeginContext(7204, 10, false);
#line 131 "D:\!_DOCS\Desktop\Артем\Курсовая робота\2\Shop.Web\Views\Account\Profile.cshtml"
                                      Write(Model.Role);

#line default
#line hidden
            EndContext();
            BeginContext(7214, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 132 "D:\!_DOCS\Desktop\Артем\Курсовая робота\2\Shop.Web\Views\Account\Profile.cshtml"
                     if(!string.IsNullOrEmpty(Model.PhoneNumber))
                    {

#line default
#line hidden
            BeginContext(7310, 56, true);
            WriteLiteral("                        <p class=\"small\">Phone number : ");
            EndContext();
            BeginContext(7367, 17, false);
#line 134 "D:\!_DOCS\Desktop\Артем\Курсовая робота\2\Shop.Web\Views\Account\Profile.cshtml"
                                                   Write(Model.PhoneNumber);

#line default
#line hidden
            EndContext();
            BeginContext(7384, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 135 "D:\!_DOCS\Desktop\Артем\Курсовая робота\2\Shop.Web\Views\Account\Profile.cshtml"
                    }

#line default
#line hidden
            BeginContext(7413, 46, true);
            WriteLiteral("                    <p class=\"small\">Country: ");
            EndContext();
            BeginContext(7460, 13, false);
#line 136 "D:\!_DOCS\Desktop\Артем\Курсовая робота\2\Shop.Web\Views\Account\Profile.cshtml"
                                         Write(Model.Country);

#line default
#line hidden
            EndContext();
            BeginContext(7473, 49, true);
            WriteLiteral("</p>\r\n                    <p class=\"small\">City: ");
            EndContext();
            BeginContext(7523, 10, false);
#line 137 "D:\!_DOCS\Desktop\Артем\Курсовая робота\2\Shop.Web\Views\Account\Profile.cshtml"
                                      Write(Model.City);

#line default
#line hidden
            EndContext();
            BeginContext(7533, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 138 "D:\!_DOCS\Desktop\Артем\Курсовая робота\2\Shop.Web\Views\Account\Profile.cshtml"
                     if(!string.IsNullOrEmpty(Model.AddressLine1))
                    {

#line default
#line hidden
            BeginContext(7630, 52, true);
            WriteLiteral("                        <p class=\"small\">Address 1: ");
            EndContext();
            BeginContext(7683, 18, false);
#line 140 "D:\!_DOCS\Desktop\Артем\Курсовая робота\2\Shop.Web\Views\Account\Profile.cshtml"
                                               Write(Model.AddressLine1);

#line default
#line hidden
            EndContext();
            BeginContext(7701, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 141 "D:\!_DOCS\Desktop\Артем\Курсовая робота\2\Shop.Web\Views\Account\Profile.cshtml"
                    }

#line default
#line hidden
#line 142 "D:\!_DOCS\Desktop\Артем\Курсовая робота\2\Shop.Web\Views\Account\Profile.cshtml"
                     if(!string.IsNullOrEmpty(Model.AddressLine2))
                    {

#line default
#line hidden
            BeginContext(7821, 52, true);
            WriteLiteral("                        <p class=\"small\">Address 2: ");
            EndContext();
            BeginContext(7874, 18, false);
#line 144 "D:\!_DOCS\Desktop\Артем\Курсовая робота\2\Shop.Web\Views\Account\Profile.cshtml"
                                               Write(Model.AddressLine2);

#line default
#line hidden
            EndContext();
            BeginContext(7892, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 145 "D:\!_DOCS\Desktop\Артем\Курсовая робота\2\Shop.Web\Views\Account\Profile.cshtml"
                    }

#line default
#line hidden
            BeginContext(7921, 356, true);
            WriteLiteral(@"                </div>
            </div>
            <div class=""panel panel-default"">
                <div class=""panel-heading"">
                    <h1 class=""page-header small"">Most Popular</h1>
                    <p class=""page-subtitle small"">Most popular ordered products</p>
                </div>
                <div class=""col-md-12"">
");
            EndContext();
#line 154 "D:\!_DOCS\Desktop\Артем\Курсовая робота\2\Shop.Web\Views\Account\Profile.cshtml"
                     if(Model.MostPopularFoods.Count() == 0)
                    {

#line default
#line hidden
            BeginContext(8362, 81, true);
            WriteLiteral("                        <p>It looks like you havn\'t ordered anything yet...</p>\r\n");
            EndContext();
#line 157 "D:\!_DOCS\Desktop\Артем\Курсовая робота\2\Shop.Web\Views\Account\Profile.cshtml"
                    }

#line default
#line hidden
            BeginContext(8466, 45, true);
            WriteLiteral("                    <ul class=\"list-group\">\r\n");
            EndContext();
#line 159 "D:\!_DOCS\Desktop\Артем\Курсовая робота\2\Shop.Web\Views\Account\Profile.cshtml"
                         foreach(var food in Model.MostPopularFoods)
                        {

#line default
#line hidden
            BeginContext(8608, 56, true);
            WriteLiteral("                            <li class=\"list-group-item\">");
            EndContext();
            BeginContext(8664, 84, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a858e3c52b3d23d2924cd110d39f0688949558fb59154ffbbbfe66cf3d9419f534514", async() => {
                BeginContext(8734, 9, false);
#line 161 "D:\!_DOCS\Desktop\Артем\Курсовая робота\2\Shop.Web\Views\Account\Profile.cshtml"
                                                                                                                        Write(food.Name);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 161 "D:\!_DOCS\Desktop\Артем\Курсовая робота\2\Shop.Web\Views\Account\Profile.cshtml"
                                                                                                      WriteLiteral(food.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(8748, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 162 "D:\!_DOCS\Desktop\Артем\Курсовая робота\2\Shop.Web\Views\Account\Profile.cshtml"
                        }

#line default
#line hidden
            BeginContext(8782, 105, true);
            WriteLiteral("                    </ul>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Shop.Web.Models.Account.AccountProfileModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
