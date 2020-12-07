#pragma checksum "D:\Student\ASP\Do-An\Do-An\Views\Home\CheckOut.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "20dc569b8047efb5024d4feceed4cf6cd57db44d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_CheckOut), @"mvc.1.0.view", @"/Views/Home/CheckOut.cshtml")]
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
#line 1 "D:\Student\ASP\Do-An\Do-An\Views\_ViewImports.cshtml"
using Do_An;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Student\ASP\Do-An\Do-An\Views\_ViewImports.cshtml"
using Do_An.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20dc569b8047efb5024d4feceed4cf6cd57db44d", @"/Views/Home/CheckOut.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c79fc3241034e73172b0940a02a4d7b7311c7998", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_CheckOut : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<section id=""cart_items"">
    <div class=""container"">
        <div class=""breadcrumbs"">
            <ol class=""breadcrumb"">
                <li><a href=""#"">Home</a></li>
                <li class=""active"">Check out</li>
            </ol>
        </div><!--/breadcrums-->

        <div class=""step-one"">
            <h2 class=""heading"">Step1</h2>
        </div>
        <div class=""checkout-options"">
            <h3>New User</h3>
            <p>Checkout options</p>
            <ul class=""nav"">
                <li>
                    <label><input type=""checkbox""> Register Account</label>
                </li>
                <li>
                    <label><input type=""checkbox""> Guest Checkout</label>
                </li>
                <li>
                    <a");
            BeginWriteAttribute("href", " href=\"", 774, "\"", 781, 0);
            EndWriteAttribute();
            WriteLiteral(@"><i class=""fa fa-times""></i>Cancel</a>
                </li>
            </ul>
        </div><!--/checkout-options-->

        <div class=""register-req"">
            <p>Please use Register And Checkout to easily get access to your order history, or use Checkout as Guest</p>
        </div><!--/register-req-->

        <div class=""shopper-informations"">
            <div class=""row"">
                <div class=""col-sm-3"">
                    <div class=""shopper-info"">
                        <p>Shopper Information</p>
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "20dc569b8047efb5024d4feceed4cf6cd57db44d4758", async() => {
                WriteLiteral(@"
                            <input type=""text"" placeholder=""Display Name"">
                            <input type=""text"" placeholder=""User Name"">
                            <input type=""password"" placeholder=""Password"">
                            <input type=""password"" placeholder=""Confirm password"">
                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                        <a class=\"btn btn-primary\"");
            BeginWriteAttribute("href", " href=\"", 1721, "\"", 1728, 0);
            EndWriteAttribute();
            WriteLiteral(">Get Quotes</a>\n                        <a class=\"btn btn-primary\"");
            BeginWriteAttribute("href", " href=\"", 1795, "\"", 1802, 0);
            EndWriteAttribute();
            WriteLiteral(@">Continue</a>
                    </div>
                </div>
                <div class=""col-sm-5 clearfix"">
                    <div class=""bill-to"">
                        <p>Bill To</p>
                        <div class=""form-one"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "20dc569b8047efb5024d4feceed4cf6cd57db44d7006", async() => {
                WriteLiteral(@"
                                <input type=""text"" placeholder=""Company Name"">
                                <input type=""text"" placeholder=""Email*"">
                                <input type=""text"" placeholder=""Title"">
                                <input type=""text"" placeholder=""First Name *"">
                                <input type=""text"" placeholder=""Middle Name"">
                                <input type=""text"" placeholder=""Last Name *"">
                                <input type=""text"" placeholder=""Address 1 *"">
                                <input type=""text"" placeholder=""Address 2"">
                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                        </div>\n                        <div class=\"form-two\">\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "20dc569b8047efb5024d4feceed4cf6cd57db44d9016", async() => {
                WriteLiteral("\n                                <input type=\"text\" placeholder=\"Zip / Postal Code *\">\n                                <select>\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "20dc569b8047efb5024d4feceed4cf6cd57db44d9441", async() => {
                    WriteLiteral("-- Country --");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "20dc569b8047efb5024d4feceed4cf6cd57db44d10496", async() => {
                    WriteLiteral("United States");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "20dc569b8047efb5024d4feceed4cf6cd57db44d11552", async() => {
                    WriteLiteral("Bangladesh");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "20dc569b8047efb5024d4feceed4cf6cd57db44d12605", async() => {
                    WriteLiteral("UK");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "20dc569b8047efb5024d4feceed4cf6cd57db44d13650", async() => {
                    WriteLiteral("India");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "20dc569b8047efb5024d4feceed4cf6cd57db44d14698", async() => {
                    WriteLiteral("Pakistan");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "20dc569b8047efb5024d4feceed4cf6cd57db44d15749", async() => {
                    WriteLiteral("Ucrane");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "20dc569b8047efb5024d4feceed4cf6cd57db44d16798", async() => {
                    WriteLiteral("Canada");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "20dc569b8047efb5024d4feceed4cf6cd57db44d17847", async() => {
                    WriteLiteral("Dubai");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                                </select>\n                                <select>\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "20dc569b8047efb5024d4feceed4cf6cd57db44d18980", async() => {
                    WriteLiteral("-- State / Province / Region --");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "20dc569b8047efb5024d4feceed4cf6cd57db44d20054", async() => {
                    WriteLiteral("United States");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "20dc569b8047efb5024d4feceed4cf6cd57db44d21110", async() => {
                    WriteLiteral("Bangladesh");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "20dc569b8047efb5024d4feceed4cf6cd57db44d22163", async() => {
                    WriteLiteral("UK");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "20dc569b8047efb5024d4feceed4cf6cd57db44d23208", async() => {
                    WriteLiteral("India");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "20dc569b8047efb5024d4feceed4cf6cd57db44d24256", async() => {
                    WriteLiteral("Pakistan");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "20dc569b8047efb5024d4feceed4cf6cd57db44d25307", async() => {
                    WriteLiteral("Ucrane");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "20dc569b8047efb5024d4feceed4cf6cd57db44d26356", async() => {
                    WriteLiteral("Canada");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "20dc569b8047efb5024d4feceed4cf6cd57db44d27405", async() => {
                    WriteLiteral("Dubai");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                </select>
                                <input type=""password"" placeholder=""Confirm password"">
                                <input type=""text"" placeholder=""Phone *"">
                                <input type=""text"" placeholder=""Mobile Phone"">
                                <input type=""text"" placeholder=""Fax"">
                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </div>
                    </div>
                </div>
                <div class=""col-sm-4"">
                    <div class=""order-message"">
                        <p>Shipping Order</p>
                        <textarea name=""message"" placeholder=""Notes about your order, Special Notes for Delivery"" rows=""16""></textarea>
                        <label><input type=""checkbox""> Shipping to bill address</label>
                    </div>
                </div>
            </div>
        </div>
        <div class=""review-payment"">
            <h2>Review & Payment</h2>
        </div>

        <div class=""table-responsive cart_info"">
            <table class=""table table-condensed"">
                <thead>
                    <tr class=""cart_menu"">
                        <td class=""image"">Item</td>
                        <td class=""description""></td>
                        <td class=""price"">Price</td>
                        <td class=""quantity"">Quantity</td>
                        <t");
            WriteLiteral("d class=\"total\">Total</td>\n                        <td></td>\n                    </tr>\n                </thead>\n                <tbody>\n                    <tr>\n                        <td class=\"cart_product\">\n                            <a");
            BeginWriteAttribute("href", " href=\"", 5828, "\"", 5835, 0);
            EndWriteAttribute();
            WriteLiteral("><img src=\"images/cart/one.png\"");
            BeginWriteAttribute("alt", " alt=\"", 5867, "\"", 5873, 0);
            EndWriteAttribute();
            WriteLiteral("></a>\n                        </td>\n                        <td class=\"cart_description\">\n                            <h4><a");
            BeginWriteAttribute("href", " href=\"", 5998, "\"", 6005, 0);
            EndWriteAttribute();
            WriteLiteral(@">Colorblock Scuba</a></h4>
                            <p>Web ID: 1089772</p>
                        </td>
                        <td class=""cart_price"">
                            <p>$59</p>
                        </td>
                        <td class=""cart_quantity"">
                            <div class=""cart_quantity_button"">
                                <a class=""cart_quantity_up""");
            BeginWriteAttribute("href", " href=\"", 6404, "\"", 6411, 0);
            EndWriteAttribute();
            WriteLiteral("> + </a>\n                                <input class=\"cart_quantity_input\" type=\"text\" name=\"quantity\" value=\"1\" autocomplete=\"off\" size=\"2\">\n                                <a class=\"cart_quantity_down\"");
            BeginWriteAttribute("href", " href=\"", 6616, "\"", 6623, 0);
            EndWriteAttribute();
            WriteLiteral(@"> - </a>
                            </div>
                        </td>
                        <td class=""cart_total"">
                            <p class=""cart_total_price"">$59</p>
                        </td>
                        <td class=""cart_delete"">
                            <a class=""cart_quantity_delete""");
            BeginWriteAttribute("href", " href=\"", 6948, "\"", 6955, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-times\"></i></a>\n                        </td>\n                    </tr>\n\n                    <tr>\n                        <td class=\"cart_product\">\n                            <a");
            BeginWriteAttribute("href", " href=\"", 7151, "\"", 7158, 0);
            EndWriteAttribute();
            WriteLiteral("><img src=\"images/cart/two.png\"");
            BeginWriteAttribute("alt", " alt=\"", 7190, "\"", 7196, 0);
            EndWriteAttribute();
            WriteLiteral("></a>\n                        </td>\n                        <td class=\"cart_description\">\n                            <h4><a");
            BeginWriteAttribute("href", " href=\"", 7321, "\"", 7328, 0);
            EndWriteAttribute();
            WriteLiteral(@">Colorblock Scuba</a></h4>
                            <p>Web ID: 1089772</p>
                        </td>
                        <td class=""cart_price"">
                            <p>$59</p>
                        </td>
                        <td class=""cart_quantity"">
                            <div class=""cart_quantity_button"">
                                <a class=""cart_quantity_up""");
            BeginWriteAttribute("href", " href=\"", 7727, "\"", 7734, 0);
            EndWriteAttribute();
            WriteLiteral("> + </a>\n                                <input class=\"cart_quantity_input\" type=\"text\" name=\"quantity\" value=\"1\" autocomplete=\"off\" size=\"2\">\n                                <a class=\"cart_quantity_down\"");
            BeginWriteAttribute("href", " href=\"", 7939, "\"", 7946, 0);
            EndWriteAttribute();
            WriteLiteral(@"> - </a>
                            </div>
                        </td>
                        <td class=""cart_total"">
                            <p class=""cart_total_price"">$59</p>
                        </td>
                        <td class=""cart_delete"">
                            <a class=""cart_quantity_delete""");
            BeginWriteAttribute("href", " href=\"", 8271, "\"", 8278, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-times\"></i></a>\n                        </td>\n                    </tr>\n                    <tr>\n                        <td class=\"cart_product\">\n                            <a");
            BeginWriteAttribute("href", " href=\"", 8473, "\"", 8480, 0);
            EndWriteAttribute();
            WriteLiteral("><img src=\"images/cart/three.png\"");
            BeginWriteAttribute("alt", " alt=\"", 8514, "\"", 8520, 0);
            EndWriteAttribute();
            WriteLiteral("></a>\n                        </td>\n                        <td class=\"cart_description\">\n                            <h4><a");
            BeginWriteAttribute("href", " href=\"", 8645, "\"", 8652, 0);
            EndWriteAttribute();
            WriteLiteral(@">Colorblock Scuba</a></h4>
                            <p>Web ID: 1089772</p>
                        </td>
                        <td class=""cart_price"">
                            <p>$59</p>
                        </td>
                        <td class=""cart_quantity"">
                            <div class=""cart_quantity_button"">
                                <a class=""cart_quantity_up""");
            BeginWriteAttribute("href", " href=\"", 9051, "\"", 9058, 0);
            EndWriteAttribute();
            WriteLiteral("> + </a>\n                                <input class=\"cart_quantity_input\" type=\"text\" name=\"quantity\" value=\"1\" autocomplete=\"off\" size=\"2\">\n                                <a class=\"cart_quantity_down\"");
            BeginWriteAttribute("href", " href=\"", 9263, "\"", 9270, 0);
            EndWriteAttribute();
            WriteLiteral(@"> - </a>
                            </div>
                        </td>
                        <td class=""cart_total"">
                            <p class=""cart_total_price"">$59</p>
                        </td>
                        <td class=""cart_delete"">
                            <a class=""cart_quantity_delete""");
            BeginWriteAttribute("href", " href=\"", 9595, "\"", 9602, 0);
            EndWriteAttribute();
            WriteLiteral(@"><i class=""fa fa-times""></i></a>
                        </td>
                    </tr>
                    <tr>
                        <td colspan=""4"">&nbsp;</td>
                        <td colspan=""2"">
                            <table class=""table table-condensed total-result"">
                                <tr>
                                    <td>Cart Sub Total</td>
                                    <td>$59</td>
                                </tr>
                                <tr>
                                    <td>Exo Tax</td>
                                    <td>$2</td>
                                </tr>
                                <tr class=""shipping-cost"">
                                    <td>Shipping Cost</td>
                                    <td>Free</td>
                                </tr>
                                <tr>
                                    <td>Total</td>
                                    <td><span>$61</span></td>
                      ");
            WriteLiteral(@"          </tr>
                            </table>
                        </td>
                    </tr>
                </tbody>
            </table>
        </div>
        <div class=""payment-options"">
            <span>
                <label><input type=""checkbox""> Direct Bank Transfer</label>
            </span>
            <span>
                <label><input type=""checkbox""> Check Payment</label>
            </span>
            <span>
                <label><input type=""checkbox""> Paypal</label>
            </span>
        </div>
    </div>
</section> <!--/#cart_items-->
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
