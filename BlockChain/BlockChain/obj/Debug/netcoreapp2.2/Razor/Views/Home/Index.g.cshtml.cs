#pragma checksum "I:\data\MyProjects\GitHub\dotnet-core-blockchain\BlockChain\BlockChain\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b9c1d770606a9f93cd6f34ffc57e6ea31c03b74c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "I:\data\MyProjects\GitHub\dotnet-core-blockchain\BlockChain\BlockChain\Views\_ViewImports.cshtml"
using BlockChain;

#line default
#line hidden
#line 2 "I:\data\MyProjects\GitHub\dotnet-core-blockchain\BlockChain\BlockChain\Views\_ViewImports.cshtml"
using BlockChain.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9c1d770606a9f93cd6f34ffc57e6ea31c03b74c", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f01fe8973a7ff96578a512b188a8ab2031f331b5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 526, true);
            WriteLiteral(@"<!--  -->
<div class=""container"">

    <div class=""row"">
        <div class=""col-lg-12"">
            <div class=""card-body"">
                <h4 class=""card-title"">
                    Transactions to be added to the next block &nbsp;&nbsp;&nbsp;
                    <button type=""submit"" id=""refresh_transactions"" class=""btn btn-sq-xs btn-primary"">
                        <i class=""fa fa-refresh""></i>
                    </button>
                </h4>
            </div>
        </div>
    </div>

</div>
");
            EndContext();
#line 18 "I:\data\MyProjects\GitHub\dotnet-core-blockchain\BlockChain\BlockChain\Views\Home\Index.cshtml"
  
    var transactions = ViewBag.Transactions as List<Transaction>;

#line default
#line hidden
            BeginContext(600, 414, true);
            WriteLiteral(@"<!-- Unmined Transactions Table -->
<div class=""container"">
    <table id=""unmined_transactions_table"" class=""table table-striped table-bordered"" cellspacing=""0"" width=""100%"">
        <thead>
            <tr>
                <th>#</th>
                <th>Recipient Address</th>
                <th>Sender Address</th>
                <th>Amount</th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 33 "I:\data\MyProjects\GitHub\dotnet-core-blockchain\BlockChain\BlockChain\Views\Home\Index.cshtml"
              
                int i = 1;
            

#line default
#line hidden
            BeginContext(1073, 12, true);
            WriteLiteral("            ");
            EndContext();
#line 36 "I:\data\MyProjects\GitHub\dotnet-core-blockchain\BlockChain\BlockChain\Views\Home\Index.cshtml"
             foreach (var item in transactions)
            {

#line default
#line hidden
            BeginContext(1137, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(1184, 1, false);
#line 39 "I:\data\MyProjects\GitHub\dotnet-core-blockchain\BlockChain\BlockChain\Views\Home\Index.cshtml"
                   Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(1185, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1217, 14, false);
#line 40 "I:\data\MyProjects\GitHub\dotnet-core-blockchain\BlockChain\BlockChain\Views\Home\Index.cshtml"
                   Write(item.Recipient);

#line default
#line hidden
            EndContext();
            BeginContext(1231, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1263, 11, false);
#line 41 "I:\data\MyProjects\GitHub\dotnet-core-blockchain\BlockChain\BlockChain\Views\Home\Index.cshtml"
                   Write(item.Sender);

#line default
#line hidden
            EndContext();
            BeginContext(1274, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1306, 11, false);
#line 42 "I:\data\MyProjects\GitHub\dotnet-core-blockchain\BlockChain\BlockChain\Views\Home\Index.cshtml"
                   Write(item.Amount);

#line default
#line hidden
            EndContext();
            BeginContext(1317, 30, true);
            WriteLiteral("</td>\r\n                </tr>\r\n");
            EndContext();
#line 44 "I:\data\MyProjects\GitHub\dotnet-core-blockchain\BlockChain\BlockChain\Views\Home\Index.cshtml"
                i++;
            }

#line default
#line hidden
            BeginContext(1384, 85, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n\r\n    <div class=\"col-lg-12 text-center\">\r\n        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1469, "\"", 1502, 1);
#line 50 "I:\data\MyProjects\GitHub\dotnet-core-blockchain\BlockChain\BlockChain\Views\Home\Index.cshtml"
WriteAttributeValue("", 1476, Url.Action("Mine","Home"), 1476, 26, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1503, 601, true);
            WriteLiteral(@" id=""mine_button"" class=""btn btn-primary btn-lg"" value="""">Mine</a>
    </div>

</div>

<hr>

<div class=""container"">

    <div class=""row"">
        <div class=""col-lg-12"">
            <div class=""card-body"">
                <h4 class=""card-title"">
                    Transactions on the Blockchain &nbsp;&nbsp;&nbsp;
                    <button type=""submit"" id=""refresh_blockchain"" class=""btn btn-sq-xs btn-primary"">
                        <i class=""fa fa-refresh""></i>
                    </button>
                </h4>
            </div>
        </div>
    </div>

</div>
");
            EndContext();
#line 73 "I:\data\MyProjects\GitHub\dotnet-core-blockchain\BlockChain\BlockChain\Views\Home\Index.cshtml"
  
    var blocks = ViewBag.Blocks as List<Block>;

#line default
#line hidden
            BeginContext(2160, 492, true);
            WriteLiteral(@"<!-- Blockchain Transactions Table -->
<div class=""container"">
    <table id=""transactions_table"" class=""table table-striped table-bordered"" cellspacing=""0"" width="""">
        <thead>
            <tr>
                <th>#</th>
                <th width=""20%"">Recipient Address</th>
                <th width=""20%"">Sender Address</th>
                <th>Amount</th>
                <th>Date</th>
                <th>Block</th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 90 "I:\data\MyProjects\GitHub\dotnet-core-blockchain\BlockChain\BlockChain\Views\Home\Index.cshtml"
              
                int j = 1;
            

#line default
#line hidden
            BeginContext(2711, 12, true);
            WriteLiteral("            ");
            EndContext();
#line 93 "I:\data\MyProjects\GitHub\dotnet-core-blockchain\BlockChain\BlockChain\Views\Home\Index.cshtml"
             foreach (var block in blocks)
            {
                foreach (var item in block.Transactions)
                {

#line default
#line hidden
            BeginContext(2847, 54, true);
            WriteLiteral("                    <tr>\r\n                        <td>");
            EndContext();
            BeginContext(2902, 1, false);
#line 98 "I:\data\MyProjects\GitHub\dotnet-core-blockchain\BlockChain\BlockChain\Views\Home\Index.cshtml"
                       Write(j);

#line default
#line hidden
            EndContext();
            BeginContext(2903, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(2939, 14, false);
#line 99 "I:\data\MyProjects\GitHub\dotnet-core-blockchain\BlockChain\BlockChain\Views\Home\Index.cshtml"
                       Write(item.Recipient);

#line default
#line hidden
            EndContext();
            BeginContext(2953, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(2989, 11, false);
#line 100 "I:\data\MyProjects\GitHub\dotnet-core-blockchain\BlockChain\BlockChain\Views\Home\Index.cshtml"
                       Write(item.Sender);

#line default
#line hidden
            EndContext();
            BeginContext(3000, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(3036, 11, false);
#line 101 "I:\data\MyProjects\GitHub\dotnet-core-blockchain\BlockChain\BlockChain\Views\Home\Index.cshtml"
                       Write(item.Amount);

#line default
#line hidden
            EndContext();
            BeginContext(3047, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(3083, 15, false);
#line 102 "I:\data\MyProjects\GitHub\dotnet-core-blockchain\BlockChain\BlockChain\Views\Home\Index.cshtml"
                       Write(block.TimeStamp);

#line default
#line hidden
            EndContext();
            BeginContext(3098, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(3135, 15, false);
#line 103 "I:\data\MyProjects\GitHub\dotnet-core-blockchain\BlockChain\BlockChain\Views\Home\Index.cshtml"
                        Write(block.Index + 1);

#line default
#line hidden
            EndContext();
            BeginContext(3151, 34, true);
            WriteLiteral("</td>\r\n                    </tr>\r\n");
            EndContext();
#line 105 "I:\data\MyProjects\GitHub\dotnet-core-blockchain\BlockChain\BlockChain\Views\Home\Index.cshtml"
                    j++;
                }
            }

#line default
#line hidden
            BeginContext(3245, 1153, true);
            WriteLiteral(@"        </tbody>
    </table>
</div>

<!-- Bootstrap core JavaScript -->
<script src=""/static/vendor/jquery/jquery.min.js""></script>
<script src=""/static/vendor/bootstrap/js/bootstrap.bundle.min.js""></script>
<script type=""text/javascript"" src=""/static/vendor/DataTables/js/datatables.min.js""></script>
<script src=""/static/vendor/DataTables/js/ellipsis.js""></script>


<script>

        $(function () {


            $('#unmined_transactions_table').dataTable();

            $('#transactions_table').dataTable();


            $(""#refresh_transactions"").click(function () {

                window.location.reload();

            });


            $(""#refresh_blockchain"").click(function () {

                $.ajax({
                    url: ""/nodes/resolve"",
                    type: ""GET"",
                    success: function (response) {

                        window.location.reload();

                    },
                    error: function (error) {
                ");
            WriteLiteral("        console.log(error);\r\n                    }\r\n                });\r\n\r\n            });\r\n\r\n\r\n\r\n\r\n        })\r\n\r\n</script>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
