#pragma checksum "C:\Users\merve\Downloads\Semafor_Hospital_Registrastion_System\Semafor_Hospital_Registrastion_System\Semafor_Hospital_Registrastion_System\Views\Patient\DetailPatient.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a66e1ccca3b3a3589119cafd6f6c96019e2a57cd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Patient_DetailPatient), @"mvc.1.0.view", @"/Views/Patient/DetailPatient.cshtml")]
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
#line 1 "C:\Users\merve\Downloads\Semafor_Hospital_Registrastion_System\Semafor_Hospital_Registrastion_System\Semafor_Hospital_Registrastion_System\Views\_ViewImports.cshtml"
using Semafor_Hospital_Registrastion_System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\merve\Downloads\Semafor_Hospital_Registrastion_System\Semafor_Hospital_Registrastion_System\Semafor_Hospital_Registrastion_System\Views\_ViewImports.cshtml"
using Semafor_Hospital_Registrastion_System.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a66e1ccca3b3a3589119cafd6f6c96019e2a57cd", @"/Views/Patient/DetailPatient.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5abf251a929957363236e684ba0dd5c03b1257e6", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Patient_DetailPatient : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Patient>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("max-width: 120px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/user.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Profile"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("rounded-circle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Visit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SelectVisit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Patient", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeletePatient", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-right:10px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("confirmButton"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<main id=""main"" class=""main"">

   
    <section style=""padding:150px;min-height:100vh;"" class=""section-bg profile"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-xl-4"">

                    <div class=""card"">
                        <div class=""card-body profile-card pt-4 d-flex flex-column align-items-center"">

                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a66e1ccca3b3a3589119cafd6f6c96019e2a57cd9295", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
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
            WriteLiteral("\r\n                            <h2 style=\"color: #2c384e;\">");
#nullable restore
#line 15 "C:\Users\merve\Downloads\Semafor_Hospital_Registrastion_System\Semafor_Hospital_Registrastion_System\Semafor_Hospital_Registrastion_System\Views\Patient\DetailPatient.cshtml"
                                                   Write(Model.name_surname);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
                            <h3 style=""font-weight:normal; color: #2c384e;"">Patient</h3>

                        </div>
                    </div>

                </div>

                <div class=""col-xl-8"">

                    <div class=""card"">
                        <div class=""card-body pt-3"">
                            <!-- Bordered Tabs -->
                            <ul class=""nav nav-tabs nav-tabs-bordered"">

                                <li class=""nav-item"">
                                    <button class=""nav-link active"" data-bs-toggle=""tab"" data-bs-target=""#profile-overview"">Profile</button>
                                </li>

                                <li class=""nav-item"">
                                    <button class=""nav-link"" data-bs-toggle=""tab"" data-bs-target=""#profile-edit"">Visits</button>
                                </li>



                            </ul>
                            <div class=""tab-content pt-2"">

         ");
            WriteLiteral(@"                       <div class=""tab-pane fade show active profile-overview"" id=""profile-overview"">

                                    <h5 class=""card-title"">Profile Details</h5>

                                    <div class=""row"">
                                        <div class=""col-lg-3 col-md-4 label "">Full Name</div>
                                        <div class=""col-lg-9 col-md-8"">");
#nullable restore
#line 49 "C:\Users\merve\Downloads\Semafor_Hospital_Registrastion_System\Semafor_Hospital_Registrastion_System\Semafor_Hospital_Registrastion_System\Views\Patient\DetailPatient.cshtml"
                                                                  Write(Model.name_surname);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                                    </div>

                                    <div class=""row"">
                                        <div class=""col-lg-3 col-md-4 label"">Id Number</div>
                                        <div class=""col-lg-9 col-md-8"">");
#nullable restore
#line 54 "C:\Users\merve\Downloads\Semafor_Hospital_Registrastion_System\Semafor_Hospital_Registrastion_System\Semafor_Hospital_Registrastion_System\Views\Patient\DetailPatient.cshtml"
                                                                  Write(Model.id_no);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                                    </div>


                                    <div class=""row"">
                                        <div class=""col-lg-3 col-md-4 label"">Birth Date</div>
                                        <div class=""col-lg-9 col-md-8"">");
#nullable restore
#line 60 "C:\Users\merve\Downloads\Semafor_Hospital_Registrastion_System\Semafor_Hospital_Registrastion_System\Semafor_Hospital_Registrastion_System\Views\Patient\DetailPatient.cshtml"
                                                                  Write(Model.birth_date);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                                    </div>



                                </div>

                                <div class=""tab-pane fade profile-edit pt-3"" id=""profile-edit"">

                                    <table class=""table datatable"">

                                        <thead>
                                            <tr id=""table-edit"">

                                                <th scope=""col"">Id No</th>
                                                <th scope=""col"">Visit Date</th>
                                                <th scope=""col"">Doctor Name</th>
                                                <th scope=""col"">Visits</th>


                                            </tr>
                                        </thead>
                                        <tbody>

");
#nullable restore
#line 84 "C:\Users\merve\Downloads\Semafor_Hospital_Registrastion_System\Semafor_Hospital_Registrastion_System\Semafor_Hospital_Registrastion_System\Views\Patient\DetailPatient.cshtml"
                                              
                                                foreach (var visit in (List<Semafor_Hospital_Registrastion_System.Models.Visit>)ViewBag.visitPatient)
                                                {



#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <tr>\r\n                                                        <th>");
#nullable restore
#line 90 "C:\Users\merve\Downloads\Semafor_Hospital_Registrastion_System\Semafor_Hospital_Registrastion_System\Semafor_Hospital_Registrastion_System\Views\Patient\DetailPatient.cshtml"
                                                       Write(visit.patient_id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                                        <td>");
#nullable restore
#line 91 "C:\Users\merve\Downloads\Semafor_Hospital_Registrastion_System\Semafor_Hospital_Registrastion_System\Semafor_Hospital_Registrastion_System\Views\Patient\DetailPatient.cshtml"
                                                       Write(visit.visit_date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                        <td>");
#nullable restore
#line 92 "C:\Users\merve\Downloads\Semafor_Hospital_Registrastion_System\Semafor_Hospital_Registrastion_System\Semafor_Hospital_Registrastion_System\Views\Patient\DetailPatient.cshtml"
                                                       Write(visit.doctor_name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                        <td>\r\n                                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a66e1ccca3b3a3589119cafd6f6c96019e2a57cd17109", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-selectedVisitId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 94 "C:\Users\merve\Downloads\Semafor_Hospital_Registrastion_System\Semafor_Hospital_Registrastion_System\Semafor_Hospital_Registrastion_System\Views\Patient\DetailPatient.cshtml"
                                                                                                                             WriteLiteral(visit.visit_id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["selectedVisitId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-selectedVisitId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["selectedVisitId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                                                        </td>\r\n\r\n                                                    </tr>\r\n");
#nullable restore
#line 99 "C:\Users\merve\Downloads\Semafor_Hospital_Registrastion_System\Semafor_Hospital_Registrastion_System\Semafor_Hospital_Registrastion_System\Views\Patient\DetailPatient.cshtml"



                                                }
                                            

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        </tbody>
                                    </table>
                                    <!-- End Table with stripped rows -->


                                </div>




                            </div><!-- End Bordered Tabs -->

                        </div>
                    </div>

                </div>
            </div>
            <br />
            <br />



");
#nullable restore
#line 127 "C:\Users\merve\Downloads\Semafor_Hospital_Registrastion_System\Semafor_Hospital_Registrastion_System\Semafor_Hospital_Registrastion_System\Views\Patient\DetailPatient.cshtml"
             if (ViewBag.loginUser == "admin")
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a66e1ccca3b3a3589119cafd6f6c96019e2a57cd21119", async() => {
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a66e1ccca3b3a3589119cafd6f6c96019e2a57cd21398", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 130 "C:\Users\merve\Downloads\Semafor_Hospital_Registrastion_System\Semafor_Hospital_Registrastion_System\Semafor_Hospital_Registrastion_System\Views\Patient\DetailPatient.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.id);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                    <div id=""details_buttons"" style=""display: flex; justify-content: center;"">
                        <button id=""deleteButton"" class=""btn btn-danger"">Delete Patient</button>
                    </div>
                    <div id=""overlay"" class=""overlay"" style=""justify-content:center; display: none;"">
                        <div class=""alert-box"">
                            <p>Are you sure you want to delete this patient?</p>
                            <div style=""justify-content: center;"">
                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a66e1ccca3b3a3589119cafd6f6c96019e2a57cd23764", async() => {
                    WriteLiteral("Yes");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Controller = (string)__tagHelperAttribute_8.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_9.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-patient", "Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 138 "C:\Users\merve\Downloads\Semafor_Hospital_Registrastion_System\Semafor_Hospital_Registrastion_System\Semafor_Hospital_Registrastion_System\Views\Patient\DetailPatient.cshtml"
                                                                                                  WriteLiteral(Model);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["patient"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-patient", __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["patient"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                <button id=\"cancelButton\" class=\"btn btn-secondary\">Cancel</button>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                ");
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
            WriteLiteral("\r\n");
#nullable restore
#line 144 "C:\Users\merve\Downloads\Semafor_Hospital_Registrastion_System\Semafor_Hospital_Registrastion_System\Semafor_Hospital_Registrastion_System\Views\Patient\DetailPatient.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("          \r\n\r\n        </div>\r\n        \r\n    </section>\r\n</main>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a66e1ccca3b3a3589119cafd6f6c96019e2a57cd28278", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_12);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_13);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<script>

    document.getElementById('deleteButton').addEventListener('click', function (event) {
        event.preventDefault(); // Sayfanın yenilenmesini engelle
        showAlertBox();
    });
    function showOverlay() {
        document.getElementById('overlay').style.display = 'flex';
        document.getElementById('details_buttons').style.display = 'none';

    }

    // Overlay'ı gizlemek için
    function hideOverlay() {
        document.getElementById('overlay').style.display = 'none';
        document.getElementById('details_buttons').style.display = 'flex';

    }

    // Uyarı kutusunu göstermek için
    function showAlertBox() {
        showOverlay();
    }
    document.getElementById('deleteButton').addEventListener('click', function () {
        showAlertBox();
    });

    // Evet düğmesine tıklandığında yapılacak işlem
    document.getElementById('confirmButton').addEventListener('click', function () {
        // Silme işlemini gerçekleştirin
        // ..");
            WriteLiteral(@".
        window.location.href = ""/Patient/DeletePatient"";  // Yönlendirme işlemi

        hideOverlay();

    });

    // İptal düğmesine tıklandığında yapılacak işlem
    document.getElementById('cancelButton').addEventListener('click', function () {
        event.preventDefault(); // Sayfanın yenilenmesini engelle
        hideOverlay();
    });
</script>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Patient> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591