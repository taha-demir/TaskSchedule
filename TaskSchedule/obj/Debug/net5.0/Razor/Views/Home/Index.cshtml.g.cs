#pragma checksum "C:\Users\Şahin\Downloads\TaskSchedule\TaskSchedule\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ce757ad3f00492fb58788e1affa652458b7477f9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Şahin\Downloads\TaskSchedule\TaskSchedule\Views\_ViewImports.cshtml"
using TaskSchedule;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Şahin\Downloads\TaskSchedule\TaskSchedule\Views\_ViewImports.cshtml"
using TaskSchedule.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce757ad3f00492fb58788e1affa652458b7477f9", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bdc2c33d527da40686e49bd8cfc1e60554d5e3f1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Schedule>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Şahin\Downloads\TaskSchedule\TaskSchedule\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!-- Latest compiled and minified CSS -->
<link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css"">

<!-- jQuery library -->
<script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.6.0/jquery.min.js""></script>

<!-- Latest compiled JavaScript -->
<script src=""https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js""></script>
<div class=""text-center"" style=""margin-left: 45px;"">
    <h1 class=""display-4"" style=""margin-left: 162px;"">HAFTALIK PLAN</h1>
    <div class=""container"" style=""margin-left: 40px;"">
        <button class=""btn btn-info"" onclick=""refresh()"" id=""update"">
            YENİDEN PLANLA
        </button>
    </div>


    <br />
    <br />
    <br />
    <table class=""table table-hover table-bordered table-striped"" id=""plan"" style=""height: 450px;"">
        <tr>
            <th style="" background-color: #5bc0deb5; margin-left: 45px;"">Gün</th>
");
#nullable restore
#line 28 "C:\Users\Şahin\Downloads\TaskSchedule\TaskSchedule\Views\Home\Index.cshtml"
             for (int i = 0; i < 6; i++)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <th style=\" background-color: #5bc0deb5;\">Kişi</th>\r\n                <th style=\" background-color: #5bc0deb5;\">Görev</th>\r\n                <th style=\" background-color: #5bc0deb5;\">Zorluk</th>\r\n");
#nullable restore
#line 33 "C:\Users\Şahin\Downloads\TaskSchedule\TaskSchedule\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tr>\r\n\r\n        <tr>\r\n            <td style=\" background-color: #5bc0deb5;\"> <b>1. Gün </b></td>\r\n");
#nullable restore
#line 38 "C:\Users\Şahin\Downloads\TaskSchedule\TaskSchedule\Views\Home\Index.cshtml"
             for (int i = 0; i < 6; i++)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td style=\"background-color: #5bc0de40;\">\r\n                    ");
#nullable restore
#line 41 "C:\Users\Şahin\Downloads\TaskSchedule\TaskSchedule\Views\Home\Index.cshtml"
               Write(Model.FirstDay[i].Employee.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 42 "C:\Users\Şahin\Downloads\TaskSchedule\TaskSchedule\Views\Home\Index.cshtml"
               Write(Model.FirstDay[i].Employee.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>");
#nullable restore
#line 44 "C:\Users\Şahin\Downloads\TaskSchedule\TaskSchedule\Views\Home\Index.cshtml"
               Write(Model.FirstDay[i].Task.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 45 "C:\Users\Şahin\Downloads\TaskSchedule\TaskSchedule\Views\Home\Index.cshtml"
               Write(Model.FirstDay[i].Task.Score);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 46 "C:\Users\Şahin\Downloads\TaskSchedule\TaskSchedule\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tr>\r\n\r\n        <tr>\r\n            <td style=\" background-color: #5bc0deb5;\"> <b>2. Gün</b></td>\r\n");
#nullable restore
#line 51 "C:\Users\Şahin\Downloads\TaskSchedule\TaskSchedule\Views\Home\Index.cshtml"
             for (int i = 0; i < 6; i++)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td style=\"background-color: #5bc0de40;\">\r\n                    ");
#nullable restore
#line 54 "C:\Users\Şahin\Downloads\TaskSchedule\TaskSchedule\Views\Home\Index.cshtml"
               Write(Model.SecondDay[i].Employee.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 55 "C:\Users\Şahin\Downloads\TaskSchedule\TaskSchedule\Views\Home\Index.cshtml"
               Write(Model.SecondDay[i].Employee.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>");
#nullable restore
#line 57 "C:\Users\Şahin\Downloads\TaskSchedule\TaskSchedule\Views\Home\Index.cshtml"
               Write(Model.SecondDay[i].Task.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 58 "C:\Users\Şahin\Downloads\TaskSchedule\TaskSchedule\Views\Home\Index.cshtml"
               Write(Model.SecondDay[i].Task.Score);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 59 "C:\Users\Şahin\Downloads\TaskSchedule\TaskSchedule\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tr>\r\n\r\n        <tr>\r\n            <td style=\" background-color: #5bc0deb5;\"> <b>3. Gün</b></td>\r\n");
#nullable restore
#line 64 "C:\Users\Şahin\Downloads\TaskSchedule\TaskSchedule\Views\Home\Index.cshtml"
             for (int i = 0; i < 6; i++)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td style=\"background-color: #5bc0de40;\">\r\n                    ");
#nullable restore
#line 67 "C:\Users\Şahin\Downloads\TaskSchedule\TaskSchedule\Views\Home\Index.cshtml"
               Write(Model.ThirdDay[i].Employee.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 68 "C:\Users\Şahin\Downloads\TaskSchedule\TaskSchedule\Views\Home\Index.cshtml"
               Write(Model.ThirdDay[i].Employee.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>");
#nullable restore
#line 70 "C:\Users\Şahin\Downloads\TaskSchedule\TaskSchedule\Views\Home\Index.cshtml"
               Write(Model.ThirdDay[i].Task.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 71 "C:\Users\Şahin\Downloads\TaskSchedule\TaskSchedule\Views\Home\Index.cshtml"
               Write(Model.ThirdDay[i].Task.Score);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 72 "C:\Users\Şahin\Downloads\TaskSchedule\TaskSchedule\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tr>\r\n\r\n        <tr>\r\n            <td style=\" background-color: #5bc0deb5;\"> <b>4. Gün</b></td>\r\n");
#nullable restore
#line 77 "C:\Users\Şahin\Downloads\TaskSchedule\TaskSchedule\Views\Home\Index.cshtml"
             for (int i = 0; i < 6; i++)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td style=\"background-color: #5bc0de40;\">\r\n                    ");
#nullable restore
#line 80 "C:\Users\Şahin\Downloads\TaskSchedule\TaskSchedule\Views\Home\Index.cshtml"
               Write(Model.FourthDay[i].Employee.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 81 "C:\Users\Şahin\Downloads\TaskSchedule\TaskSchedule\Views\Home\Index.cshtml"
               Write(Model.FourthDay[i].Employee.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>");
#nullable restore
#line 83 "C:\Users\Şahin\Downloads\TaskSchedule\TaskSchedule\Views\Home\Index.cshtml"
               Write(Model.FourthDay[i].Task.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 84 "C:\Users\Şahin\Downloads\TaskSchedule\TaskSchedule\Views\Home\Index.cshtml"
               Write(Model.FourthDay[i].Task.Score);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 85 "C:\Users\Şahin\Downloads\TaskSchedule\TaskSchedule\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tr>\r\n\r\n        <tr>\r\n            <td style=\" background-color: #5bc0deb5;\"> <b>5. Gün</b></td>\r\n");
#nullable restore
#line 90 "C:\Users\Şahin\Downloads\TaskSchedule\TaskSchedule\Views\Home\Index.cshtml"
             for (int i = 0; i < 6; i++)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td style=\"background-color: #5bc0de40;\">\r\n                    ");
#nullable restore
#line 93 "C:\Users\Şahin\Downloads\TaskSchedule\TaskSchedule\Views\Home\Index.cshtml"
               Write(Model.FifthDay[i].Employee.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 94 "C:\Users\Şahin\Downloads\TaskSchedule\TaskSchedule\Views\Home\Index.cshtml"
               Write(Model.FifthDay[i].Employee.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>");
#nullable restore
#line 96 "C:\Users\Şahin\Downloads\TaskSchedule\TaskSchedule\Views\Home\Index.cshtml"
               Write(Model.FifthDay[i].Task.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 97 "C:\Users\Şahin\Downloads\TaskSchedule\TaskSchedule\Views\Home\Index.cshtml"
               Write(Model.FifthDay[i].Task.Score);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 98 "C:\Users\Şahin\Downloads\TaskSchedule\TaskSchedule\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </tr>
    </table>

    <br />
    <br />
    <br />

    <br />
    <br />
    <br />
</div>


<script>


    function myFunction() {

        const update = document.getElementById(""update"");
        update.style.visibility = ""visible"";
        const visible = element.style.visibility;

    }

    function refresh() {
        reloadP()
    }

    window.onload = function () {
        var reloading = sessionStorage.getItem(""reloading"");
        if (reloading) {
            sessionStorage.removeItem(""reloading"");
            myFunction();
        }
    }

    function reloadP() {
        sessionStorage.setItem(""reloading"", ""true"");
        document.location.reload();
    }
</script>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Schedule> Html { get; private set; }
    }
}
#pragma warning restore 1591
