#pragma checksum "C:\Users\harshitbhardwaj\Desktop\Design_Patterns_Assignment\Book_reading_app\Book_reading_app\Views\BookEvent\EventDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "76b5493d2a95b297e06b313f8f56092eb683712d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BookEvent_EventDetails), @"mvc.1.0.view", @"/Views/BookEvent/EventDetails.cshtml")]
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
#line 1 "C:\Users\harshitbhardwaj\Desktop\Design_Patterns_Assignment\Book_reading_app\Book_reading_app\Views\_ViewImports.cshtml"
using Book_reading_app;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\harshitbhardwaj\Desktop\Design_Patterns_Assignment\Book_reading_app\Book_reading_app\Views\_ViewImports.cshtml"
using Book_reading_app.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\harshitbhardwaj\Desktop\Design_Patterns_Assignment\Book_reading_app\Book_reading_app\Views\_ViewImports.cshtml"
using Book_reading_app.Core.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\harshitbhardwaj\Desktop\Design_Patterns_Assignment\Book_reading_app\Book_reading_app\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\harshitbhardwaj\Desktop\Design_Patterns_Assignment\Book_reading_app\Book_reading_app\Views\_ViewImports.cshtml"
using Book_reading_app.AppDomain.Data_transfer_objects;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\harshitbhardwaj\Desktop\Design_Patterns_Assignment\Book_reading_app\Book_reading_app\Views\_ViewImports.cshtml"
using Book_reading_app.Core.Domain.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76b5493d2a95b297e06b313f8f56092eb683712d", @"/Views/BookEvent/EventDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75b1c6f7ae03fea5de64a12671a7fc6351df1f9e", @"/Views/_ViewImports.cshtml")]
    public class Views_BookEvent_EventDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BookEventModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/editIco-black.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("13"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("13"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "BookEvent", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditEvent", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary rounded-0"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/deleteIco.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("17"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("17"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteEvent", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-info alert-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\harshitbhardwaj\Desktop\Design_Patterns_Assignment\Book_reading_app\Book_reading_app\Views\BookEvent\EventDetails.cshtml"
  
    ViewData["Title"] = Model.Title;

    var user = await _userManager.GetUserAsync(User);
    var email = user != null ? user.Email : "";
    var TotalInvited = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<h1>Event Details</h1>\r\n<div class=\"mb-1\">\r\n");
#nullable restore
#line 16 "C:\Users\harshitbhardwaj\Desktop\Design_Patterns_Assignment\Book_reading_app\Book_reading_app\Views\BookEvent\EventDetails.cshtml"
     if (Model.Date > DateTime.Now)
    {
        if (email == Model.OrganisersEmail || email == "myadmin@bookevents.com")
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"mb-1 btn-group\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "76b5493d2a95b297e06b313f8f56092eb683712d10239", async() => {
                WriteLiteral("Edit Event ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "76b5493d2a95b297e06b313f8f56092eb683712d10502", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 21 "C:\Users\harshitbhardwaj\Desktop\Design_Patterns_Assignment\Book_reading_app\Book_reading_app\Views\BookEvent\EventDetails.cshtml"
                                                                       WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "76b5493d2a95b297e06b313f8f56092eb683712d14008", async() => {
                WriteLiteral("\r\n                    <button type=\"submit\" class=\"btn btn-danger rounded-0\">Delete Event ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "76b5493d2a95b297e06b313f8f56092eb683712d14359", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</button>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 23 "C:\Users\harshitbhardwaj\Desktop\Design_Patterns_Assignment\Book_reading_app\Book_reading_app\Views\BookEvent\EventDetails.cshtml"
                                                 WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n");
#nullable restore
#line 27 "C:\Users\harshitbhardwaj\Desktop\Design_Patterns_Assignment\Book_reading_app\Book_reading_app\Views\BookEvent\EventDetails.cshtml"
        }
    }
    else
    {


        

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Users\harshitbhardwaj\Desktop\Design_Patterns_Assignment\Book_reading_app\Book_reading_app\Views\BookEvent\EventDetails.cshtml"
         if (_signInManager.IsSignedIn(User))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""alert alert-secondary alert-dismissible fade show"" role=""alert"">
                <strong>Note:</strong> This is an event in past and hence can't be edited or deleted.
                <button type=""button"" class=""close"" data-dismiss=""alert"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
");
#nullable restore
#line 41 "C:\Users\harshitbhardwaj\Desktop\Design_Patterns_Assignment\Book_reading_app\Book_reading_app\Views\BookEvent\EventDetails.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "C:\Users\harshitbhardwaj\Desktop\Design_Patterns_Assignment\Book_reading_app\Book_reading_app\Views\BookEvent\EventDetails.cshtml"
         
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n<div class=\"row\">\r\n\r\n    <div class=\"col-md-8 col-sm-12\">\r\n        <table class=\"table table-bordered table-hover\">\r\n\r\n            <tr>\r\n                <td>Event</td>\r\n                <td>");
#nullable restore
#line 52 "C:\Users\harshitbhardwaj\Desktop\Design_Patterns_Assignment\Book_reading_app\Book_reading_app\Views\BookEvent\EventDetails.cshtml"
               Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n\r\n            <tr>\r\n                <td>Organiser</td>\r\n                <td>");
#nullable restore
#line 57 "C:\Users\harshitbhardwaj\Desktop\Design_Patterns_Assignment\Book_reading_app\Book_reading_app\Views\BookEvent\EventDetails.cshtml"
               Write(Model.OrganisersEmail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n\r\n            <tr>\r\n                <td>Event Type</td>\r\n");
#nullable restore
#line 62 "C:\Users\harshitbhardwaj\Desktop\Design_Patterns_Assignment\Book_reading_app\Book_reading_app\Views\BookEvent\EventDetails.cshtml"
                 if (Model.IsPrivateEvent)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>Private</td>\r\n");
#nullable restore
#line 65 "C:\Users\harshitbhardwaj\Desktop\Design_Patterns_Assignment\Book_reading_app\Book_reading_app\Views\BookEvent\EventDetails.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>Public</td>\r\n");
#nullable restore
#line 69 "C:\Users\harshitbhardwaj\Desktop\Design_Patterns_Assignment\Book_reading_app\Book_reading_app\Views\BookEvent\EventDetails.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tr>\r\n            <tr>\r\n                <td>Date</td>\r\n                <td>");
#nullable restore
#line 73 "C:\Users\harshitbhardwaj\Desktop\Design_Patterns_Assignment\Book_reading_app\Book_reading_app\Views\BookEvent\EventDetails.cshtml"
               Write(Model.Date.ToString().Substring(0, 10));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n\r\n            <tr>\r\n                <td>Location</td>\r\n                <td>");
#nullable restore
#line 78 "C:\Users\harshitbhardwaj\Desktop\Design_Patterns_Assignment\Book_reading_app\Book_reading_app\Views\BookEvent\EventDetails.cshtml"
               Write(Model.Location);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n\r\n            <tr>\r\n                <td>Start Time</td>\r\n                <td>");
#nullable restore
#line 83 "C:\Users\harshitbhardwaj\Desktop\Design_Patterns_Assignment\Book_reading_app\Book_reading_app\Views\BookEvent\EventDetails.cshtml"
               Write(Model.StartTime.ToString().Substring(10));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n\r\n");
#nullable restore
#line 86 "C:\Users\harshitbhardwaj\Desktop\Design_Patterns_Assignment\Book_reading_app\Book_reading_app\Views\BookEvent\EventDetails.cshtml"
             if (Model.DurationInHours != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>Duration</td>\r\n                    <td>");
#nullable restore
#line 90 "C:\Users\harshitbhardwaj\Desktop\Design_Patterns_Assignment\Book_reading_app\Book_reading_app\Views\BookEvent\EventDetails.cshtml"
                   Write(Model.DurationInHours);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Hrs.</td>\r\n                </tr>\r\n");
#nullable restore
#line 92 "C:\Users\harshitbhardwaj\Desktop\Design_Patterns_Assignment\Book_reading_app\Book_reading_app\Views\BookEvent\EventDetails.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 93 "C:\Users\harshitbhardwaj\Desktop\Design_Patterns_Assignment\Book_reading_app\Book_reading_app\Views\BookEvent\EventDetails.cshtml"
             if (Model.Description != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>Description</td>\r\n                    <td>");
#nullable restore
#line 97 "C:\Users\harshitbhardwaj\Desktop\Design_Patterns_Assignment\Book_reading_app\Book_reading_app\Views\BookEvent\EventDetails.cshtml"
                   Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 99 "C:\Users\harshitbhardwaj\Desktop\Design_Patterns_Assignment\Book_reading_app\Book_reading_app\Views\BookEvent\EventDetails.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 100 "C:\Users\harshitbhardwaj\Desktop\Design_Patterns_Assignment\Book_reading_app\Book_reading_app\Views\BookEvent\EventDetails.cshtml"
             if (Model.OtherDetails != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>Other Details</td>\r\n                    <td>");
#nullable restore
#line 104 "C:\Users\harshitbhardwaj\Desktop\Design_Patterns_Assignment\Book_reading_app\Book_reading_app\Views\BookEvent\EventDetails.cshtml"
                   Write(Model.OtherDetails);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 106 "C:\Users\harshitbhardwaj\Desktop\Design_Patterns_Assignment\Book_reading_app\Book_reading_app\Views\BookEvent\EventDetails.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 107 "C:\Users\harshitbhardwaj\Desktop\Design_Patterns_Assignment\Book_reading_app\Book_reading_app\Views\BookEvent\EventDetails.cshtml"
             if (Model.InviteByEmail != null && Model.InviteByEmail != "")
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 109 "C:\Users\harshitbhardwaj\Desktop\Design_Patterns_Assignment\Book_reading_app\Book_reading_app\Views\BookEvent\EventDetails.cshtml"
                 foreach (var i in Model.InviteByEmail)
                {
                    if (i == '@') { TotalInvited++; }

                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 115 "C:\Users\harshitbhardwaj\Desktop\Design_Patterns_Assignment\Book_reading_app\Book_reading_app\Views\BookEvent\EventDetails.cshtml"
                 if (email == Model.OrganisersEmail || email == "myadmin@bookevents.com")
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>People Invited</td>\r\n                        <td>");
#nullable restore
#line 119 "C:\Users\harshitbhardwaj\Desktop\Design_Patterns_Assignment\Book_reading_app\Book_reading_app\Views\BookEvent\EventDetails.cshtml"
                       Write(Model.InviteByEmail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n");
#nullable restore
#line 121 "C:\Users\harshitbhardwaj\Desktop\Design_Patterns_Assignment\Book_reading_app\Book_reading_app\Views\BookEvent\EventDetails.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 121 "C:\Users\harshitbhardwaj\Desktop\Design_Patterns_Assignment\Book_reading_app\Book_reading_app\Views\BookEvent\EventDetails.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <tr>\r\n                <td>Total People Invited</td>\r\n                <td>");
#nullable restore
#line 126 "C:\Users\harshitbhardwaj\Desktop\Design_Patterns_Assignment\Book_reading_app\Book_reading_app\Views\BookEvent\EventDetails.cshtml"
               Write(TotalInvited);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n\r\n\r\n\r\n        </table>\r\n\r\n\r\n    </div>\r\n\r\n    <div class=\"col-sm-12 col-md-4\">\r\n\r\n        <div class=\"col text-center\"><h3>Comments</h3></div>\r\n");
#nullable restore
#line 139 "C:\Users\harshitbhardwaj\Desktop\Design_Patterns_Assignment\Book_reading_app\Book_reading_app\Views\BookEvent\EventDetails.cshtml"
         if (signInManager.IsSignedIn(User))
        {

            

#line default
#line hidden
#nullable disable
#nullable restore
#line 142 "C:\Users\harshitbhardwaj\Desktop\Design_Patterns_Assignment\Book_reading_app\Book_reading_app\Views\BookEvent\EventDetails.cshtml"
             using (Html.BeginForm("PostCommentOnEvent", "Comment", new { EventId = Model.Id }, FormMethod.Post))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""d-flex flex-row mt-4 mb-4"">
                    <textarea class=""form-control mr-3  shadow-sm"" name=""comment"" id=""comment"" placeholder=""Write your comment here..."" required></textarea>
                    <button class=""btn btn-primary"" type=""submit"" value=""Post"" id=""submitComment"">Post Comment</button>
                </div>
");
#nullable restore
#line 148 "C:\Users\harshitbhardwaj\Desktop\Design_Patterns_Assignment\Book_reading_app\Book_reading_app\Views\BookEvent\EventDetails.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 148 "C:\Users\harshitbhardwaj\Desktop\Design_Patterns_Assignment\Book_reading_app\Book_reading_app\Views\BookEvent\EventDetails.cshtml"
             
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"alert alert-warning\" role=\"alert\">\r\n                You must ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "76b5493d2a95b297e06b313f8f56092eb683712d29778", async() => {
                WriteLiteral(" login ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_11.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_12.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_12);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_13);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" to post comments.\r\n            </div>\r\n");
#nullable restore
#line 155 "C:\Users\harshitbhardwaj\Desktop\Design_Patterns_Assignment\Book_reading_app\Book_reading_app\Views\BookEvent\EventDetails.cshtml"

        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 157 "C:\Users\harshitbhardwaj\Desktop\Design_Patterns_Assignment\Book_reading_app\Book_reading_app\Views\BookEvent\EventDetails.cshtml"
         if (@Model.Comments != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"list-group mt-2\">\r\n");
#nullable restore
#line 160 "C:\Users\harshitbhardwaj\Desktop\Design_Patterns_Assignment\Book_reading_app\Book_reading_app\Views\BookEvent\EventDetails.cshtml"
                 foreach (var comment in Model.Comments)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"mt-1 text-justify col-12 list-group-item-action border border-secondary rounded  bg-light\">\r\n                        <h6 class=\"mt-1 mb-0 text-info\"> ");
#nullable restore
#line 162 "C:\Users\harshitbhardwaj\Desktop\Design_Patterns_Assignment\Book_reading_app\Book_reading_app\Views\BookEvent\EventDetails.cshtml"
                                                    Write(comment.PostingUserEmail);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h6>\r\n                        <p class=\"m-0 text-muted\">\r\n                            <small>\r\n                                ");
#nullable restore
#line 165 "C:\Users\harshitbhardwaj\Desktop\Design_Patterns_Assignment\Book_reading_app\Book_reading_app\Views\BookEvent\EventDetails.cshtml"
                           Write(comment.TimeStamp.ToString().Substring(0, 10));

#line default
#line hidden
#nullable disable
            WriteLiteral(" / ");
#nullable restore
#line 165 "C:\Users\harshitbhardwaj\Desktop\Design_Patterns_Assignment\Book_reading_app\Book_reading_app\Views\BookEvent\EventDetails.cshtml"
                                                                            Write(comment.TimeStamp.ToString().Substring(10));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </small>\r\n                        </p>\r\n                        <p class=\"bg-white border border-secondary rounded p-1 h5 \">");
#nullable restore
#line 168 "C:\Users\harshitbhardwaj\Desktop\Design_Patterns_Assignment\Book_reading_app\Book_reading_app\Views\BookEvent\EventDetails.cshtml"
                                                                               Write(comment.Comment);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n");
#nullable restore
#line 170 "C:\Users\harshitbhardwaj\Desktop\Design_Patterns_Assignment\Book_reading_app\Book_reading_app\Views\BookEvent\EventDetails.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n");
#nullable restore
#line 172 "C:\Users\harshitbhardwaj\Desktop\Design_Patterns_Assignment\Book_reading_app\Book_reading_app\Views\BookEvent\EventDetails.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<ApplicationUser> _userManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<ApplicationUser> _signInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<ApplicationUser> signInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BookEventModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
