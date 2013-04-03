﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18010
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LibraryViewProject.Views.Account
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "1.5.4.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Account/Register.cshtml")]
    public partial class Register : System.Web.Mvc.WebViewPage<LibraryViewProject.Models.RegisterModel>
    {
        public Register()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\Account\Register.cshtml"
  
    ViewBag.Title = "Register";

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<h2>Create a New Account</h2>\r\n<p>\r\n    Use the form below to create a new ac" +
"count. \r\n</p>\r\n<p>\r\n    Passwords are required to be a minimum of ");

            
            #line 12 "..\..\Views\Account\Register.cshtml"
                                         Write(Membership.MinRequiredPasswordLength);

            
            #line default
            #line hidden
WriteLiteral(" characters in length.\r\n</p>\r\n\r\n<script");

WriteAttribute("src", Tuple.Create(" src=\"", 311), Tuple.Create("\"", 365)
            
            #line 15 "..\..\Views\Account\Register.cshtml"
, Tuple.Create(Tuple.Create("", 317), Tuple.Create<System.Object, System.Int32>(Url.Content("~/Scripts/jquery.validate.min.js")
            
            #line default
            #line hidden
, 317), false)
);

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral("></script>\r\n<script");

WriteAttribute("src", Tuple.Create(" src=\"", 408), Tuple.Create("\"", 474)
            
            #line 16 "..\..\Views\Account\Register.cshtml"
, Tuple.Create(Tuple.Create("", 414), Tuple.Create<System.Object, System.Int32>(Url.Content("~/Scripts/jquery.validate.unobtrusive.min.js")
            
            #line default
            #line hidden
, 414), false)
);

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral("></script>\r\n\r\n");

            
            #line 18 "..\..\Views\Account\Register.cshtml"
 using (Html.BeginForm()) {
    
            
            #line default
            #line hidden
            
            #line 19 "..\..\Views\Account\Register.cshtml"
Write(Html.ValidationSummary(true, "Account creation was unsuccessful. Please correct the errors and try again."));

            
            #line default
            #line hidden
            
            #line 19 "..\..\Views\Account\Register.cshtml"
                                                                                                                

            
            #line default
            #line hidden
WriteLiteral("    <div>\r\n        <fieldset>\r\n            <legend>Account Information</legend>\r\n" +
"\r\n            <div");

WriteLiteral(" class=\"editor-label\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 25 "..\..\Views\Account\Register.cshtml"
           Write(Html.LabelFor(m => m.UserName));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"editor-field\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 28 "..\..\Views\Account\Register.cshtml"
           Write(Html.TextBoxFor(m => m.UserName));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 29 "..\..\Views\Account\Register.cshtml"
           Write(Html.ValidationMessageFor(m => m.UserName));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n\r\n            <div");

WriteLiteral(" class=\"editor-label\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 33 "..\..\Views\Account\Register.cshtml"
           Write(Html.LabelFor(m => m.Email));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"editor-field\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 36 "..\..\Views\Account\Register.cshtml"
           Write(Html.TextBoxFor(m => m.Email));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 37 "..\..\Views\Account\Register.cshtml"
           Write(Html.ValidationMessageFor(m => m.Email));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n\r\n            <div");

WriteLiteral(" class=\"editor-label\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 41 "..\..\Views\Account\Register.cshtml"
           Write(Html.LabelFor(m => m.Password));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"editor-field\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 44 "..\..\Views\Account\Register.cshtml"
           Write(Html.PasswordFor(m => m.Password));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 45 "..\..\Views\Account\Register.cshtml"
           Write(Html.ValidationMessageFor(m => m.Password));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n\r\n            <div");

WriteLiteral(" class=\"editor-label\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 49 "..\..\Views\Account\Register.cshtml"
           Write(Html.LabelFor(m => m.ConfirmPassword));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"editor-field\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 52 "..\..\Views\Account\Register.cshtml"
           Write(Html.PasswordFor(m => m.ConfirmPassword));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 53 "..\..\Views\Account\Register.cshtml"
           Write(Html.ValidationMessageFor(m => m.ConfirmPassword));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n\r\n            <p>\r\n                <input");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" value=\"Register\"");

WriteLiteral(" />\r\n            </p>\r\n        </fieldset>\r\n    </div>\r\n");

            
            #line 61 "..\..\Views\Account\Register.cshtml"
}

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
