﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18051
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ChameleonForms.Templates
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    
    #line 1 "..\..\Templates\TwitterBootstrapHtmlHelpers.cshtml"
    using System.Web.Mvc;
    
    #line default
    #line hidden
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    
    #line 2 "..\..\Templates\TwitterBootstrapHtmlHelpers.cshtml"
    using Component.Config;
    
    #line default
    #line hidden
    
    #line 3 "..\..\Templates\TwitterBootstrapHtmlHelpers.cshtml"
    using Enums;
    
    #line default
    #line hidden
    
    #line 4 "..\..\Templates\TwitterBootstrapHtmlHelpers.cshtml"
    using Templates;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    public class TwitterBootstrapHtmlHelpers : System.Web.WebPages.HelperPage
    {

#line 10 "..\..\Templates\TwitterBootstrapHtmlHelpers.cshtml"
public static System.Web.WebPages.HelperResult EndForm() {
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 10 "..\..\Templates\TwitterBootstrapHtmlHelpers.cshtml"
                   


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    </form>\r\n");


#line 12 "..\..\Templates\TwitterBootstrapHtmlHelpers.cshtml"


#line default
#line hidden
});

#line 12 "..\..\Templates\TwitterBootstrapHtmlHelpers.cshtml"
}
#line default
#line hidden

#line 14 "..\..\Templates\TwitterBootstrapHtmlHelpers.cshtml"
public static System.Web.WebPages.HelperResult BeginSection(IHtmlString title, IHtmlString leadingHtml, HtmlAttributes htmlAttributes) {
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 14 "..\..\Templates\TwitterBootstrapHtmlHelpers.cshtml"
                                                                                                 


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    <fieldset");


#line 15 "..\..\Templates\TwitterBootstrapHtmlHelpers.cshtml"
WriteTo(__razor_helper_writer, htmlAttributes);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, ">\r\n");

WriteLiteralTo(__razor_helper_writer, "        <legend>");


#line 16 "..\..\Templates\TwitterBootstrapHtmlHelpers.cshtml"
WriteTo(__razor_helper_writer, title);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</legend>\r\n");

WriteLiteralTo(__razor_helper_writer, "        ");


#line 17 "..\..\Templates\TwitterBootstrapHtmlHelpers.cshtml"
WriteTo(__razor_helper_writer, leadingHtml);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\r\n");


#line 18 "..\..\Templates\TwitterBootstrapHtmlHelpers.cshtml"


#line default
#line hidden
});

#line 18 "..\..\Templates\TwitterBootstrapHtmlHelpers.cshtml"
}
#line default
#line hidden

#line 20 "..\..\Templates\TwitterBootstrapHtmlHelpers.cshtml"
public static System.Web.WebPages.HelperResult BeginNestedSection(IHtmlString title, IHtmlString leadingHtml, HtmlAttributes htmlAttributes)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 21 "..\..\Templates\TwitterBootstrapHtmlHelpers.cshtml"
 


#line default
#line hidden
});

#line 22 "..\..\Templates\TwitterBootstrapHtmlHelpers.cshtml"
}
#line default
#line hidden

#line 24 "..\..\Templates\TwitterBootstrapHtmlHelpers.cshtml"
public static System.Web.WebPages.HelperResult EndSection() {
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 24 "..\..\Templates\TwitterBootstrapHtmlHelpers.cshtml"
                      


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    </fieldset>\r\n");


#line 26 "..\..\Templates\TwitterBootstrapHtmlHelpers.cshtml"


#line default
#line hidden
});

#line 26 "..\..\Templates\TwitterBootstrapHtmlHelpers.cshtml"
}
#line default
#line hidden

#line 28 "..\..\Templates\TwitterBootstrapHtmlHelpers.cshtml"
public static System.Web.WebPages.HelperResult EndNestedSection() {
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 28 "..\..\Templates\TwitterBootstrapHtmlHelpers.cshtml"
                            


#line default
#line hidden
});

#line 29 "..\..\Templates\TwitterBootstrapHtmlHelpers.cshtml"
}
#line default
#line hidden

#line 31 "..\..\Templates\TwitterBootstrapHtmlHelpers.cshtml"
public static System.Web.WebPages.HelperResult GetPrependedHtml(IReadonlyFieldConfiguration fieldConfiguration) {
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 31 "..\..\Templates\TwitterBootstrapHtmlHelpers.cshtml"
                                                                          
    if (fieldConfiguration != null) {
        foreach (var html in fieldConfiguration.PrependedHtml) {

#line default
#line hidden

#line 33 "..\..\Templates\TwitterBootstrapHtmlHelpers.cshtml"
                                  WriteTo(__razor_helper_writer, html);


#line default
#line hidden

#line 33 "..\..\Templates\TwitterBootstrapHtmlHelpers.cshtml"
                                                                     }
    }


#line default
#line hidden
});

#line 35 "..\..\Templates\TwitterBootstrapHtmlHelpers.cshtml"
}
#line default
#line hidden

#line 37 "..\..\Templates\TwitterBootstrapHtmlHelpers.cshtml"
public static System.Web.WebPages.HelperResult GetAppendedHtml(IReadonlyFieldConfiguration fieldConfiguration) {
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 37 "..\..\Templates\TwitterBootstrapHtmlHelpers.cshtml"
                                                                         
    if (fieldConfiguration != null) {
        foreach (var html in fieldConfiguration.AppendedHtml) {

#line default
#line hidden

#line 39 "..\..\Templates\TwitterBootstrapHtmlHelpers.cshtml"
                                 WriteTo(__razor_helper_writer, html);


#line default
#line hidden

#line 39 "..\..\Templates\TwitterBootstrapHtmlHelpers.cshtml"
                                                                    }
    }


#line default
#line hidden
});

#line 41 "..\..\Templates\TwitterBootstrapHtmlHelpers.cshtml"
}
#line default
#line hidden

#line 43 "..\..\Templates\TwitterBootstrapHtmlHelpers.cshtml"
public static System.Web.WebPages.HelperResult GetHint(IReadonlyFieldConfiguration fieldConfiguration) {
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 43 "..\..\Templates\TwitterBootstrapHtmlHelpers.cshtml"
                                                                 
    if (fieldConfiguration != null && fieldConfiguration.Hint != null) {

#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "<span");

WriteLiteralTo(__razor_helper_writer, " class=\"help-block\"");

WriteLiteralTo(__razor_helper_writer, ">");


#line 44 "..\..\Templates\TwitterBootstrapHtmlHelpers.cshtml"
                                                                   WriteTo(__razor_helper_writer, fieldConfiguration.Hint);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</span>");


#line 44 "..\..\Templates\TwitterBootstrapHtmlHelpers.cshtml"
                                                                                                                                }


#line default
#line hidden
});

#line 45 "..\..\Templates\TwitterBootstrapHtmlHelpers.cshtml"
}
#line default
#line hidden

#line 47 "..\..\Templates\TwitterBootstrapHtmlHelpers.cshtml"
public static System.Web.WebPages.HelperResult BeginFieldInternal(IHtmlString labelHtml, IHtmlString elementHtml, IHtmlString validationHtml, IReadonlyFieldConfiguration fieldConfiguration, ModelMetadata fieldMetadata) {
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 47 "..\..\Templates\TwitterBootstrapHtmlHelpers.cshtml"
                                                                                                                                                                                     


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "            <div class=\"form-group\">\r\n");

WriteLiteralTo(__razor_helper_writer, "            ");


#line 49 "..\..\Templates\TwitterBootstrapHtmlHelpers.cshtml"
WriteTo(__razor_helper_writer, labelHtml);


#line default
#line hidden

#line 49 "..\..\Templates\TwitterBootstrapHtmlHelpers.cshtml"
WriteTo(__razor_helper_writer, new HtmlString(fieldMetadata != null && fieldMetadata.IsRequired ? " <em class=\"required\">*</em>" : ""));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\r\n");

WriteLiteralTo(__razor_helper_writer, "            ");


#line 50 "..\..\Templates\TwitterBootstrapHtmlHelpers.cshtml"
WriteTo(__razor_helper_writer, GetPrependedHtml(fieldConfiguration));


#line default
#line hidden

#line 50 "..\..\Templates\TwitterBootstrapHtmlHelpers.cshtml"
                     WriteTo(__razor_helper_writer, elementHtml);


#line default
#line hidden

#line 50 "..\..\Templates\TwitterBootstrapHtmlHelpers.cshtml"
                                 WriteTo(__razor_helper_writer, GetAppendedHtml(fieldConfiguration));


#line default
#line hidden

#line 50 "..\..\Templates\TwitterBootstrapHtmlHelpers.cshtml"
                                                                     WriteTo(__razor_helper_writer, GetHint(fieldConfiguration));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, " ");


#line 50 "..\..\Templates\TwitterBootstrapHtmlHelpers.cshtml"
                                                                                                  WriteTo(__razor_helper_writer, validationHtml);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\r\n");


#line 51 "..\..\Templates\TwitterBootstrapHtmlHelpers.cshtml"


#line default
#line hidden
});

#line 51 "..\..\Templates\TwitterBootstrapHtmlHelpers.cshtml"
}
#line default
#line hidden

#line 53 "..\..\Templates\TwitterBootstrapHtmlHelpers.cshtml"
public static System.Web.WebPages.HelperResult Field(IHtmlString labelHtml, IHtmlString elementHtml, IHtmlString validationHtml, ModelMetadata fieldMetadata, IReadonlyFieldConfiguration fieldConfiguration) {
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 53 "..\..\Templates\TwitterBootstrapHtmlHelpers.cshtml"
                                                                                                                                                                        


#line default
#line hidden

#line 54 "..\..\Templates\TwitterBootstrapHtmlHelpers.cshtml"
WriteTo(__razor_helper_writer, BeginFieldInternal(labelHtml, elementHtml, validationHtml, fieldConfiguration, fieldMetadata));


#line default
#line hidden

#line 54 "..\..\Templates\TwitterBootstrapHtmlHelpers.cshtml"
                                                                                              


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "            </div>\r\n");


#line 56 "..\..\Templates\TwitterBootstrapHtmlHelpers.cshtml"


#line default
#line hidden
});

#line 56 "..\..\Templates\TwitterBootstrapHtmlHelpers.cshtml"
}
#line default
#line hidden

#line 58 "..\..\Templates\TwitterBootstrapHtmlHelpers.cshtml"
public static System.Web.WebPages.HelperResult BeginField(IHtmlString labelHtml, IHtmlString elementHtml, IHtmlString validationHtml, ModelMetadata fieldMetadata, IReadonlyFieldConfiguration fieldConfiguration)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 59 "..\..\Templates\TwitterBootstrapHtmlHelpers.cshtml"
 


#line default
#line hidden

#line 60 "..\..\Templates\TwitterBootstrapHtmlHelpers.cshtml"
WriteTo(__razor_helper_writer, BeginFieldInternal(labelHtml, elementHtml, validationHtml, fieldConfiguration, fieldMetadata));


#line default
#line hidden

#line 60 "..\..\Templates\TwitterBootstrapHtmlHelpers.cshtml"
                                                                                              


#line default
#line hidden
});

#line 61 "..\..\Templates\TwitterBootstrapHtmlHelpers.cshtml"
}
#line default
#line hidden

#line 63 "..\..\Templates\TwitterBootstrapHtmlHelpers.cshtml"
public static System.Web.WebPages.HelperResult EndField() {
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 63 "..\..\Templates\TwitterBootstrapHtmlHelpers.cshtml"
                    


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "            </div>\r\n");


#line 65 "..\..\Templates\TwitterBootstrapHtmlHelpers.cshtml"


#line default
#line hidden
});

#line 65 "..\..\Templates\TwitterBootstrapHtmlHelpers.cshtml"
}
#line default
#line hidden

#line 67 "..\..\Templates\TwitterBootstrapHtmlHelpers.cshtml"
public static System.Web.WebPages.HelperResult BeginNavigation() {
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 67 "..\..\Templates\TwitterBootstrapHtmlHelpers.cshtml"
                           


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "        <div class=\"form_navigation\">\r\n");


#line 69 "..\..\Templates\TwitterBootstrapHtmlHelpers.cshtml"


#line default
#line hidden
});

#line 69 "..\..\Templates\TwitterBootstrapHtmlHelpers.cshtml"
}
#line default
#line hidden

#line 71 "..\..\Templates\TwitterBootstrapHtmlHelpers.cshtml"
public static System.Web.WebPages.HelperResult EndNavigation() {
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 71 "..\..\Templates\TwitterBootstrapHtmlHelpers.cshtml"
                         


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "        </div>\r\n");


#line 73 "..\..\Templates\TwitterBootstrapHtmlHelpers.cshtml"


#line default
#line hidden
});

#line 73 "..\..\Templates\TwitterBootstrapHtmlHelpers.cshtml"
}
#line default
#line hidden

#line 75 "..\..\Templates\TwitterBootstrapHtmlHelpers.cshtml"
public static System.Web.WebPages.HelperResult BeginMessage(TwitterAlertType messageType, IHtmlString heading) {
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 75 "..\..\Templates\TwitterBootstrapHtmlHelpers.cshtml"
                                                                         


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "      <div class=\"alert ");


#line 76 "..\..\Templates\TwitterBootstrapHtmlHelpers.cshtml"
WriteTo(__razor_helper_writer, string.Format("alert-{0}", messageType.ToString().ToLower()));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\">\r\n");


#line 77 "..\..\Templates\TwitterBootstrapHtmlHelpers.cshtml"
            if (heading != null)
            {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "          <p><strong>");


#line 79 "..\..\Templates\TwitterBootstrapHtmlHelpers.cshtml"
WriteTo(__razor_helper_writer, heading);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</strong></p>\r\n");


#line 80 "..\..\Templates\TwitterBootstrapHtmlHelpers.cshtml"
            }


#line default
#line hidden
});

#line 81 "..\..\Templates\TwitterBootstrapHtmlHelpers.cshtml"
}
#line default
#line hidden

#line 83 "..\..\Templates\TwitterBootstrapHtmlHelpers.cshtml"
public static System.Web.WebPages.HelperResult EndMessage() {
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 83 "..\..\Templates\TwitterBootstrapHtmlHelpers.cshtml"
                      


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "      </div>\r\n");


#line 85 "..\..\Templates\TwitterBootstrapHtmlHelpers.cshtml"


#line default
#line hidden
});

#line 85 "..\..\Templates\TwitterBootstrapHtmlHelpers.cshtml"
}
#line default
#line hidden

#line 87 "..\..\Templates\TwitterBootstrapHtmlHelpers.cshtml"
public static System.Web.WebPages.HelperResult MessageParagraph(IHtmlString paragraph) {
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 87 "..\..\Templates\TwitterBootstrapHtmlHelpers.cshtml"
                                                 


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    <p>\r\n");

WriteLiteralTo(__razor_helper_writer, "        ");


#line 89 "..\..\Templates\TwitterBootstrapHtmlHelpers.cshtml"
WriteTo(__razor_helper_writer, paragraph);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\r\n");

WriteLiteralTo(__razor_helper_writer, "    </p>\r\n");


#line 91 "..\..\Templates\TwitterBootstrapHtmlHelpers.cshtml"


#line default
#line hidden
});

#line 91 "..\..\Templates\TwitterBootstrapHtmlHelpers.cshtml"
}
#line default
#line hidden

#line 93 "..\..\Templates\TwitterBootstrapHtmlHelpers.cshtml"
public static System.Web.WebPages.HelperResult List(IEnumerable<IHtmlString> items) {
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 93 "..\..\Templates\TwitterBootstrapHtmlHelpers.cshtml"
                                              


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    <ul>\r\n");


#line 95 "..\..\Templates\TwitterBootstrapHtmlHelpers.cshtml"
foreach(var i in items) {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "        <li>");


#line 96 "..\..\Templates\TwitterBootstrapHtmlHelpers.cshtml"
WriteTo(__razor_helper_writer, i);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</li>\r\n");


#line 97 "..\..\Templates\TwitterBootstrapHtmlHelpers.cshtml"
}


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    </ul>\r\n");


#line 99 "..\..\Templates\TwitterBootstrapHtmlHelpers.cshtml"


#line default
#line hidden
});

#line 99 "..\..\Templates\TwitterBootstrapHtmlHelpers.cshtml"
}
#line default
#line hidden

    }
}
#pragma warning restore 1591
