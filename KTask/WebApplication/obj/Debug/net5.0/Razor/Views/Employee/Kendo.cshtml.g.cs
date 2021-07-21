#pragma checksum "C:\Users\fazil\Desktop\KendoTask\KTask\WebApplication\Views\Employee\Kendo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d07270f7a325e71e08dccf16c99c8fa2cc9e8180"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_Kendo), @"mvc.1.0.view", @"/Views/Employee/Kendo.cshtml")]
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
#line 1 "C:\Users\fazil\Desktop\KendoTask\KTask\WebApplication\Views\_ViewImports.cshtml"
using WebApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\fazil\Desktop\KendoTask\KTask\WebApplication\Views\_ViewImports.cshtml"
using WebApplication.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d07270f7a325e71e08dccf16c99c8fa2cc9e8180", @"/Views/Employee/Kendo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa0ef8da47a84ffb33e8bc853509aa4fa5703a26", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_Kendo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div id=""fixtureGrid"">
<script>
    var crudServiceBaseUrl = ""/Umbraco/Surface/Kendo/"";
    debugger
    const kendoDataSource = new kendo.data.DataSource({
        transport: {
            read: {
                url: crudServiceBaseUrl + ""Kendo"",
                dataType: ""json"",
                type: ""POST""
            },
            //update: {
            //    url: crudServiceBaseUrl + ""UpdateFixturesKendoGrid"",
            //    dataType: ""json"",
            //    type: ""POST"",
            //    complete: function () {
            //        $(""#fixtureGrid"").data(""kendoGrid"").dataSource.read();
            //        $('#fixtureGrid').data(""kendoGrid"").refresh();
            //    }
            //},
            //destroy: {
            //    url: crudServiceBaseUrl + ""DeleteFixturesKendoGrid"",
            //    dataType: ""json"",
            //    type: ""POST"",
            //    complete: function () {
            //        $(""#fixtureGrid"").data(""kendoGrid"").dataSource.read();
");
            WriteLiteral(@"            //        $('#fixtureGrid').data(""kendoGrid"").refresh();
            //    }
            //},
            //create: {
            //    url: crudServiceBaseUrl + ""CreateFixturesKendoGrid"",
            //    dataType: ""json"",
            //    type: ""POST""
            //},
            //parameterMap: function(options, operation) {
            //    if (operation !== ""read"" && options.models) {
            //        return { models: window.kendo.stringify(options.models) };
            //    }
            //    return options;
            //}
        },
        serverPaging: true,
        pageSize: 5,
        schema: {
            data: ""EmpClass"",
            model: {
                id: ""Id"",
                fields: {
                    Id:          { editable: false, nullable: true },
                    //HomeTeam:           { editable: false },
                    //Opponent:           { editable: false }
            }
}
        }
    });
   $(""#fixtureGrid"").kendo");
            WriteLiteral(@"Grid({
        dataSource: kendoDataSource,
        sortable: true,
        scrollable: true,
        filterable: true,
        resizable: true,
        pageable: {
            alwaysVisible: true,
            refresh: true,
            pageSizes: [5, 10, 20, 30, 40, 50, 60, 70, 80, 90, 100],
            buttonCount: 5,
            skip: 0,
            take: 10
        },
        columns: [
            { field: ""Id"", title: ""EmployeeId"" }],
            //{ field: ""HomeTeam"", title: ""Home Team""},
            //{ field: ""Opponent"", title: ""Opponent""},
            //{ command: [""edit"",""destroy""], title: ""&nbsp;"", width:""180px""}],
        editable: ""popup""
    });
});
</script>
</div>");
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
