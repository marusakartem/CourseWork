#pragma checksum "D:\!_DOCS\Desktop\Артем\Курсовая робота\2\Shop.Web\Views\Account\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0a6aa2f3605669b75fd964ec498ca69fed735695e286cc0ecb6a3e0fa232fe27"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Index), @"mvc.1.0.view", @"/Views/Account/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/Index.cshtml", typeof(AspNetCore.Views_Account_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"0a6aa2f3605669b75fd964ec498ca69fed735695e286cc0ecb6a3e0fa232fe27", @"/Views/Account/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"051d21b7fd6ca2eaeaacf59afe11c4950e07ec28787593cff88f6fe0a5341170", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Shop.Web.Models.Account.AccountIndexModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("homeSearch"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Search..."), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Search", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-lg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AdminProfile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(50, 156, true);
            WriteLiteral("\r\n<div class=\"container\">\r\n\t<div class=\"row\">\r\n\t\t<div class=\"col-md-12\" style=\"margin-top:32px\">\r\n\t\t\t<div class=\"col-md-6\" style=\"margin-bottom:32px\">\r\n\t\t\t\t");
            EndContext();
            BeginContext(206, 171, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0a6aa2f3605669b75fd964ec498ca69fed735695e286cc0ecb6a3e0fa232fe276874", async() => {
                BeginContext(271, 7, true);
                WriteLiteral("\r\n\t\t\t\t\t");
                EndContext();
                BeginContext(278, 86, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0a6aa2f3605669b75fd964ec498ca69fed735695e286cc0ecb6a3e0fa232fe277289", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 8 "D:\!_DOCS\Desktop\Артем\Курсовая робота\2\Shop.Web\Views\Account\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.SearchQuery);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(364, 6, true);
                WriteLiteral("\r\n\t\t\t\t");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(377, 13, true);
            WriteLiteral("\r\n\t\t\t</div>\r\n");
            EndContext();
#line 11 "D:\!_DOCS\Desktop\Артем\Курсовая робота\2\Shop.Web\Views\Account\Index.cshtml"
    if(!string.IsNullOrWhiteSpace(Model.SearchQuery))
			{

#line default
#line hidden
            BeginContext(451, 70, true);
            WriteLiteral("\t\t\t\t<div class=\"col-md-8\">\r\n\t\t\t\t\t<h3>Search Results</h3>\r\n\t\t\t\t\t<hr/>\r\n");
            EndContext();
#line 16 "D:\!_DOCS\Desktop\Артем\Курсовая робота\2\Shop.Web\Views\Account\Index.cshtml"
      if(!Model.Accounts.Any())
					{

#line default
#line hidden
            BeginContext(562, 87, true);
            WriteLiteral("\t\t\t\t\t\t<div>\r\n\t\t\t\t\t\t\t<h4>It looks like there is no search result...</h4>\r\n\t\t\t\t\t\t</div>\r\n");
            EndContext();
#line 21 "D:\!_DOCS\Desktop\Артем\Курсовая робота\2\Shop.Web\Views\Account\Index.cshtml"
					}

#line default
#line hidden
            BeginContext(657, 12, true);
            WriteLiteral("\t\t\t\t</div>\r\n");
            EndContext();
#line 23 "D:\!_DOCS\Desktop\Артем\Курсовая робота\2\Shop.Web\Views\Account\Index.cshtml"
			}
			else
			{
				

#line default
#line hidden
#line 26 "D:\!_DOCS\Desktop\Артем\Курсовая робота\2\Shop.Web\Views\Account\Index.cshtml"
     if(!Model.Accounts.Any())
				{

#line default
#line hidden
            BeginContext(729, 52, true);
            WriteLiteral("\t\t\t\t\t<p>It looks like there are no accounts...</p>\r\n");
            EndContext();
#line 29 "D:\!_DOCS\Desktop\Артем\Курсовая робота\2\Shop.Web\Views\Account\Index.cshtml"
				}

#line default
#line hidden
#line 29 "D:\!_DOCS\Desktop\Артем\Курсовая робота\2\Shop.Web\Views\Account\Index.cshtml"
     	
			}

#line default
#line hidden
#line 31 "D:\!_DOCS\Desktop\Артем\Курсовая робота\2\Shop.Web\Views\Account\Index.cshtml"
    foreach(var account in Model.Accounts)
			{

#line default
#line hidden
            BeginContext(845, 231, true);
            WriteLiteral("\t\t\t\t<div class=\"col-md-8 col-sm-12 pull-left posttimeline\">\r\n\t\t\t\t\t<div class=\"panel-group\" id=\"accordion\">\r\n\t\t\t\t\t\t<div class=\"panel panel-default\">\r\n\t\t\t\t\t\t\t<div class=\"panel-heading\">\r\n\t\t\t\t\t\t\t\t<h4 class=\"panel-title\">\r\n\t\t\t\t\t\t\t\t\t<p>");
            EndContext();
            BeginContext(1077, 17, false);
#line 38 "D:\!_DOCS\Desktop\Артем\Курсовая робота\2\Shop.Web\Views\Account\Index.cshtml"
       Write(account.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(1094, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(1096, 16, false);
#line 38 "D:\!_DOCS\Desktop\Артем\Курсовая робота\2\Shop.Web\Views\Account\Index.cshtml"
                          Write(account.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(1112, 82, true);
            WriteLiteral("</p>\r\n\t\t\t\t\t\t\t\t\t<div>\r\n\t\t\t\t\t\t\t\t\t\t<a data-toggle=\"collapse\" data-parent=\"#accordion\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1194, "\"", 1233, 2);
            WriteAttributeValue("", 1201, "#collapse-", 1201, 10, true);
#line 40 "D:\!_DOCS\Desktop\Артем\Курсовая робота\2\Shop.Web\Views\Account\Index.cshtml"
WriteAttributeValue("", 1211, account.GetHashCode(), 1211, 22, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1234, 97, true);
            WriteLiteral(">\r\n\t\t\t\t\t\t\t\t\t\t\tDetails\r\n\t\t\t\t\t\t\t\t\t\t</a>\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t</h4>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t<div");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1331, "\"", 1367, 2);
            WriteAttributeValue("", 1336, "collapse-", 1336, 9, true);
#line 46 "D:\!_DOCS\Desktop\Артем\Курсовая робота\2\Shop.Web\Views\Account\Index.cshtml"
WriteAttributeValue("", 1345, account.GetHashCode(), 1345, 22, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1368, 135, true);
            WriteLiteral(" class=\"panel-collapse collapse\">\r\n\t\t\t\t\t\t\t\t<div class=\"panel-body\">\r\n\t\t\t\t\t\t\t\t\t<div class=\"jumbotron\">\r\n\t\t\t\t\t\t\t\t\t\t<h2 class=\"display-4\">");
            EndContext();
            BeginContext(1504, 17, false);
#line 49 "D:\!_DOCS\Desktop\Артем\Курсовая робота\2\Shop.Web\Views\Account\Index.cshtml"
                           Write(account.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(1521, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(1523, 16, false);
#line 49 "D:\!_DOCS\Desktop\Артем\Курсовая робота\2\Shop.Web\Views\Account\Index.cshtml"
                                              Write(account.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(1539, 148, true);
            WriteLiteral("</h2>\r\n\t\t\t\t\t\t\t\t\t\t<ul class=\"nav nav-pills pull-left countlist\" role=\"tablist\">\r\n\t\t\t\t\t\t\t\t\t\t\t<li role=\"presentation\">\r\n\t\t\t\t\t\t\t\t\t\t\t\t<h3>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t");
            EndContext();
            BeginContext(1688, 21, false);
#line 53 "D:\!_DOCS\Desktop\Артем\Курсовая робота\2\Shop.Web\Views\Account\Index.cshtml"
        Write(account.BalanceFormat);

#line default
#line hidden
            EndContext();
            BeginContext(1709, 148, true);
            WriteLiteral("<br>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t<small>Balance</small>\r\n\t\t\t\t\t\t\t\t\t\t\t\t</h3>\r\n\t\t\t\t\t\t\t\t\t\t\t</li>\r\n\t\t\t\t\t\t\t\t\t\t\t<li role=\"presentation\">\r\n\t\t\t\t\t\t\t\t\t\t\t\t<h3>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t");
            EndContext();
            BeginContext(1858, 24, false);
#line 59 "D:\!_DOCS\Desktop\Артем\Курсовая робота\2\Shop.Web\Views\Account\Index.cshtml"
        Write(account.TotalSpentFormat);

#line default
#line hidden
            EndContext();
            BeginContext(1882, 152, true);
            WriteLiteral("<br>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t<small>Total Spent</small>\r\n\t\t\t\t\t\t\t\t\t\t\t\t</h3>\r\n\t\t\t\t\t\t\t\t\t\t\t</li>\r\n\t\t\t\t\t\t\t\t\t\t\t<li role=\"presentation\">\r\n\t\t\t\t\t\t\t\t\t\t\t\t<h3>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t");
            EndContext();
            BeginContext(2035, 18, false);
#line 65 "D:\!_DOCS\Desktop\Артем\Курсовая робота\2\Shop.Web\Views\Account\Index.cshtml"
        Write(account.OrderCount);

#line default
#line hidden
            EndContext();
            BeginContext(2053, 154, true);
            WriteLiteral("<br>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t<small>Orders placed</small>\r\n\t\t\t\t\t\t\t\t\t\t\t\t</h3>\r\n\t\t\t\t\t\t\t\t\t\t\t</li>\r\n\t\t\t\t\t\t\t\t\t\t\t<li role=\"presentation\">\r\n\t\t\t\t\t\t\t\t\t\t\t\t<h3>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t");
            EndContext();
            BeginContext(2208, 42, false);
#line 71 "D:\!_DOCS\Desktop\Артем\Курсовая робота\2\Shop.Web\Views\Account\Index.cshtml"
        Write(account.MemberSince.ToString("dd/MM/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(2250, 288, true);
            WriteLiteral(@"<br>
													<small>Member since</small>
												</h3>
											</li>
										</ul>
										<div class=""panel panel-default"">
											<div class=""panel-heading"">
												<h1 class=""page-header small"">Personal Details</h1>
												<p class=""small"">Email: ");
            EndContext();
            BeginContext(2539, 13, false);
#line 79 "D:\!_DOCS\Desktop\Артем\Курсовая робота\2\Shop.Web\Views\Account\Index.cshtml"
                               Write(account.Email);

#line default
#line hidden
            EndContext();
            BeginContext(2552, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 80 "D:\!_DOCS\Desktop\Артем\Курсовая робота\2\Shop.Web\Views\Account\Index.cshtml"
             if(!string.IsNullOrEmpty(account.PhoneNumber))
												{

#line default
#line hidden
            BeginContext(2634, 45, true);
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t\t\t\t<p class=\"small\">Phone number : ");
            EndContext();
            BeginContext(2680, 19, false);
#line 82 "D:\!_DOCS\Desktop\Артем\Курсовая робота\2\Shop.Web\Views\Account\Index.cshtml"
                                        Write(account.PhoneNumber);

#line default
#line hidden
            EndContext();
            BeginContext(2699, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 83 "D:\!_DOCS\Desktop\Артем\Курсовая робота\2\Shop.Web\Views\Account\Index.cshtml"
												}

#line default
#line hidden
            BeginContext(2720, 38, true);
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t\t\t<p class=\"small\">Country: ");
            EndContext();
            BeginContext(2759, 15, false);
#line 84 "D:\!_DOCS\Desktop\Артем\Курсовая робота\2\Shop.Web\Views\Account\Index.cshtml"
                                 Write(account.Country);

#line default
#line hidden
            EndContext();
            BeginContext(2774, 41, true);
            WriteLiteral("</p>\r\n\t\t\t\t\t\t\t\t\t\t\t\t<p class=\"small\">City: ");
            EndContext();
            BeginContext(2816, 12, false);
#line 85 "D:\!_DOCS\Desktop\Артем\Курсовая робота\2\Shop.Web\Views\Account\Index.cshtml"
                              Write(account.City);

#line default
#line hidden
            EndContext();
            BeginContext(2828, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 86 "D:\!_DOCS\Desktop\Артем\Курсовая робота\2\Shop.Web\Views\Account\Index.cshtml"
             if(!string.IsNullOrEmpty(account.AddressLine1))
												{

#line default
#line hidden
            BeginContext(2911, 41, true);
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t\t\t\t<p class=\"small\">Address 1: ");
            EndContext();
            BeginContext(2953, 20, false);
#line 88 "D:\!_DOCS\Desktop\Артем\Курсовая робота\2\Shop.Web\Views\Account\Index.cshtml"
                                    Write(account.AddressLine1);

#line default
#line hidden
            EndContext();
            BeginContext(2973, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 89 "D:\!_DOCS\Desktop\Артем\Курсовая робота\2\Shop.Web\Views\Account\Index.cshtml"
												}

#line default
#line hidden
#line 90 "D:\!_DOCS\Desktop\Артем\Курсовая робота\2\Shop.Web\Views\Account\Index.cshtml"
             if(!string.IsNullOrEmpty(account.AddressLine2))
												{

#line default
#line hidden
            BeginContext(3071, 41, true);
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t\t\t\t<p class=\"small\">Address 2: ");
            EndContext();
            BeginContext(3113, 20, false);
#line 92 "D:\!_DOCS\Desktop\Артем\Курсовая робота\2\Shop.Web\Views\Account\Index.cshtml"
                                    Write(account.AddressLine2);

#line default
#line hidden
            EndContext();
            BeginContext(3133, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 93 "D:\!_DOCS\Desktop\Артем\Курсовая робота\2\Shop.Web\Views\Account\Index.cshtml"
												}

#line default
#line hidden
            BeginContext(3154, 35, true);
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t\t\t<p class=\"small\">Role: ");
            EndContext();
            BeginContext(3190, 12, false);
#line 94 "D:\!_DOCS\Desktop\Артем\Курсовая робота\2\Shop.Web\Views\Account\Index.cshtml"
                              Write(account.Role);

#line default
#line hidden
            EndContext();
            BeginContext(3202, 53, true);
            WriteLiteral("</p>\r\n\t\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t\t");
            EndContext();
            BeginContext(3255, 147, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0a6aa2f3605669b75fd964ec498ca69fed735695e286cc0ecb6a3e0fa232fe2723069", async() => {
                BeginContext(3385, 13, true);
                WriteLiteral("Go to profile");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-userId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 97 "D:\!_DOCS\Desktop\Артем\Курсовая робота\2\Shop.Web\Views\Account\Index.cshtml"
                                                                                                                   WriteLiteral(account.Id);

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
            BeginContext(3402, 90, true);
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div> \r\n\t\t\t\t</div>\r\n");
            EndContext();
#line 104 "D:\!_DOCS\Desktop\Артем\Курсовая робота\2\Shop.Web\Views\Account\Index.cshtml"
			}

#line default
#line hidden
            BeginContext(3498, 25, true);
            WriteLiteral("\t\t</div>\r\n\t</div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Shop.Web.Models.Account.AccountIndexModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
