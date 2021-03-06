#pragma checksum "D:\gitCode\crm\lsc\lsc.crm\Views\Ques\UserAnswerLogInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b986cfd32c6e1c5821a090d976c8f7824aaac53a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Ques_UserAnswerLogInfo), @"mvc.1.0.view", @"/Views/Ques/UserAnswerLogInfo.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Ques/UserAnswerLogInfo.cshtml", typeof(AspNetCore.Views_Ques_UserAnswerLogInfo))]
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
#line 1 "D:\gitCode\crm\lsc\lsc.crm\Views\Ques\UserAnswerLogInfo.cshtml"
using lsc.Model;

#line default
#line hidden
#line 2 "D:\gitCode\crm\lsc\lsc.crm\Views\Ques\UserAnswerLogInfo.cshtml"
using lsc.Model.Enume;

#line default
#line hidden
#line 3 "D:\gitCode\crm\lsc\lsc.crm\Views\Ques\UserAnswerLogInfo.cshtml"
using Microsoft.EntityFrameworkCore.Internal;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b986cfd32c6e1c5821a090d976c8f7824aaac53a", @"/Views/Ques/UserAnswerLogInfo.cshtml")]
    public class Views_Ques_UserAnswerLogInfo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<lsc.Model.UserQuestions>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/layui/jquery.validate.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/layui/jquery.form.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(127, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 6 "D:\gitCode\crm\lsc\lsc.crm\Views\Ques\UserAnswerLogInfo.cshtml"
  
    ViewData["Title"] = "答题详情";
    Layout = "~/Pages/_Layout.cshtml";

    List<Questions> questionses = ViewBag.questionses;
    List<Option> options = ViewBag.options;
    List<UserAnswer> userAnswers = ViewBag.userAnswers;
    bool isadmin = ViewBag.isadmin;

#line default
#line hidden
            BeginContext(406, 64, true);
            WriteLiteral("<blockquote class=\"layui-elem-quote\">\r\n    答题详情\r\n</blockquote>\r\n");
            EndContext();
#line 18 "D:\gitCode\crm\lsc\lsc.crm\Views\Ques\UserAnswerLogInfo.cshtml"
 if (Model != null)
{
    foreach (UserQuestions userQuestionse in Model)
    {
        if (questionses != null)
        {
            var question = questionses.FirstOrDefault(x => x.Id == userQuestionse.QuestionsId);


#line default
#line hidden
            BeginContext(698, 44, true);
            WriteLiteral("            <div class=\"layui-row manage-ti\"");
            EndContext();
            BeginWriteAttribute("id", "  id=\"", 742, "\"", 772, 1);
#line 26 "D:\gitCode\crm\lsc\lsc.crm\Views\Ques\UserAnswerLogInfo.cshtml"
WriteAttributeValue("", 748, userQuestionse.QIndex, 748, 24, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(773, 43, true);
            WriteLiteral(">\r\n                <form class=\"layui-form\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 816, "\"", 850, 2);
            WriteAttributeValue("", 821, "form_", 821, 5, true);
#line 27 "D:\gitCode\crm\lsc\lsc.crm\Views\Ques\UserAnswerLogInfo.cshtml"
WriteAttributeValue("", 826, userQuestionse.QIndex, 826, 24, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(851, 27, true);
            WriteLiteral(">\r\n                    <h3>");
            EndContext();
            BeginContext(880, 21, false);
#line 28 "D:\gitCode\crm\lsc\lsc.crm\Views\Ques\UserAnswerLogInfo.cshtml"
                    Write(userQuestionse.QIndex);

#line default
#line hidden
            EndContext();
            BeginContext(902, 1, true);
            WriteLiteral("、");
            EndContext();
            BeginContext(905, 40, false);
#line 28 "D:\gitCode\crm\lsc\lsc.crm\Views\Ques\UserAnswerLogInfo.cshtml"
                                             Write(question != null ? question.Content : "");

#line default
#line hidden
            EndContext();
            BeginContext(946, 7, true);
            WriteLiteral("</h3>\r\n");
            EndContext();
#line 29 "D:\gitCode\crm\lsc\lsc.crm\Views\Ques\UserAnswerLogInfo.cshtml"
                     if (question != null)
                    {
                        var optionList = options.Where(x => x.QuestionsId == userQuestionse.QuestionsId).OrderBy(x => x.ItemIndex);
                        string okopton = string.Empty;
                        if (optionList!=null)
                        {
                            var index = optionList.Where(x => x.IsOk).Select(x => x.ItemIndex);
                            if (index != null && index.Count() == 1)
                            {
                                okopton = index.FirstOrDefault();
                            }
                            else
                            {
                                okopton = index?.Join("、");
                            }
                           
                        }
                        switch (question.QuestionsType)
                        {
                            case QuestionsTypeEnum.ChoiceOne:
                                if (optionList != null)
                                {

#line default
#line hidden
            BeginContext(2031, 42, true);
            WriteLiteral("                                    <ul>\r\n");
            EndContext();
#line 52 "D:\gitCode\crm\lsc\lsc.crm\Views\Ques\UserAnswerLogInfo.cshtml"
                                         foreach (var op in optionList)
                                        {
                                            UserAnswer userAnswer = userAnswers?.FirstOrDefault(x => x.OptionId == op.Id);
                                            if (userAnswer != null)
                                            {

#line default
#line hidden
            BeginContext(2429, 87, true);
            WriteLiteral("                                                <li><input type=\"radio\" name=\"optionId\"");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 2516, "\"", 2553, 3);
#line 57 "D:\gitCode\crm\lsc\lsc.crm\Views\Ques\UserAnswerLogInfo.cshtml"
WriteAttributeValue("", 2524, op.ItemIndex, 2524, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 2539, "、", 2539, 1, true);
#line 57 "D:\gitCode\crm\lsc\lsc.crm\Views\Ques\UserAnswerLogInfo.cshtml"
WriteAttributeValue("", 2540, op.Content, 2540, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2554, 14, true);
            WriteLiteral(" checked><span");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 2568, "\"", 2613, 1);
#line 57 "D:\gitCode\crm\lsc\lsc.crm\Views\Ques\UserAnswerLogInfo.cshtml"
WriteAttributeValue("", 2576, userAnswer.Score==0?"color:red":"", 2576, 37, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2614, 2, true);
            WriteLiteral(">[");
            EndContext();
            BeginContext(2618, 16, false);
#line 57 "D:\gitCode\crm\lsc\lsc.crm\Views\Ques\UserAnswerLogInfo.cshtml"
                                                                                                                                                                                       Write(userAnswer.Score);

#line default
#line hidden
            EndContext();
            BeginContext(2635, 16, true);
            WriteLiteral("分]</span></li>\r\n");
            EndContext();
#line 58 "D:\gitCode\crm\lsc\lsc.crm\Views\Ques\UserAnswerLogInfo.cshtml"
                                            }
                                            else
                                            {

#line default
#line hidden
            BeginContext(2795, 98, true);
            WriteLiteral("                                                <li><input type=\"radio\" name=\"optionId\" data-oid=\"");
            EndContext();
            BeginContext(2895, 5, false);
#line 61 "D:\gitCode\crm\lsc\lsc.crm\Views\Ques\UserAnswerLogInfo.cshtml"
                                                                                              Write(op.Id);

#line default
#line hidden
            EndContext();
            BeginContext(2901, 1, true);
            WriteLiteral("\"");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 2902, "\"", 2939, 3);
#line 61 "D:\gitCode\crm\lsc\lsc.crm\Views\Ques\UserAnswerLogInfo.cshtml"
WriteAttributeValue("", 2910, op.ItemIndex, 2910, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 2925, "、", 2925, 1, true);
#line 61 "D:\gitCode\crm\lsc\lsc.crm\Views\Ques\UserAnswerLogInfo.cshtml"
WriteAttributeValue("", 2926, op.Content, 2926, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2940, 8, true);
            WriteLiteral("></li>\r\n");
            EndContext();
#line 62 "D:\gitCode\crm\lsc\lsc.crm\Views\Ques\UserAnswerLogInfo.cshtml"
                                            }
                                        }

#line default
#line hidden
            BeginContext(3038, 49, true);
            WriteLiteral("                                        <li>正确答案：");
            EndContext();
            BeginContext(3089, 7, false);
#line 64 "D:\gitCode\crm\lsc\lsc.crm\Views\Ques\UserAnswerLogInfo.cshtml"
                                             Write(okopton);

#line default
#line hidden
            EndContext();
            BeginContext(3097, 50, true);
            WriteLiteral("</li>\r\n                                    </ul>\r\n");
            EndContext();
#line 66 "D:\gitCode\crm\lsc\lsc.crm\Views\Ques\UserAnswerLogInfo.cshtml"
                                }
                                break;
                            case QuestionsTypeEnum.ChoiceMore:
                                if (optionList != null)
                                {

#line default
#line hidden
            BeginContext(3378, 42, true);
            WriteLiteral("                                    <ul>\r\n");
            EndContext();
#line 72 "D:\gitCode\crm\lsc\lsc.crm\Views\Ques\UserAnswerLogInfo.cshtml"
                                         foreach (var op in optionList)
                                        {
                                            UserAnswer userAnswer = userAnswers?.FirstOrDefault(x => x.OptionId == op.Id);
                                            if (userAnswer != null)
                                            {

#line default
#line hidden
            BeginContext(3776, 90, true);
            WriteLiteral("                                                <li><input type=\"checkbox\" name=\"optionId\"");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 3866, "\"", 3903, 3);
#line 77 "D:\gitCode\crm\lsc\lsc.crm\Views\Ques\UserAnswerLogInfo.cshtml"
WriteAttributeValue("", 3874, op.ItemIndex, 3874, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 3889, "、", 3889, 1, true);
#line 77 "D:\gitCode\crm\lsc\lsc.crm\Views\Ques\UserAnswerLogInfo.cshtml"
WriteAttributeValue("", 3890, op.Content, 3890, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3904, 33, true);
            WriteLiteral(" lay-skin=\"primary\" checked><span");
            EndContext();
            BeginWriteAttribute("style", "  style=\"", 3937, "\"", 3983, 1);
#line 77 "D:\gitCode\crm\lsc\lsc.crm\Views\Ques\UserAnswerLogInfo.cshtml"
WriteAttributeValue("", 3946, userAnswer.Score==0?"color:red":"", 3946, 37, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3984, 2, true);
            WriteLiteral(">[");
            EndContext();
            BeginContext(3988, 16, false);
#line 77 "D:\gitCode\crm\lsc\lsc.crm\Views\Ques\UserAnswerLogInfo.cshtml"
                                                                                                                                                                                                              Write(userAnswer.Score);

#line default
#line hidden
            EndContext();
            BeginContext(4005, 16, true);
            WriteLiteral("分]</span></li>\r\n");
            EndContext();
#line 78 "D:\gitCode\crm\lsc\lsc.crm\Views\Ques\UserAnswerLogInfo.cshtml"

                                            }
                                            else
                                            {

#line default
#line hidden
            BeginContext(4167, 101, true);
            WriteLiteral("                                                <li><input type=\"checkbox\" name=\"optionId\" data-oid=\"");
            EndContext();
            BeginContext(4270, 5, false);
#line 82 "D:\gitCode\crm\lsc\lsc.crm\Views\Ques\UserAnswerLogInfo.cshtml"
                                                                                                 Write(op.Id);

#line default
#line hidden
            EndContext();
            BeginContext(4276, 1, true);
            WriteLiteral("\"");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 4277, "\"", 4314, 3);
#line 82 "D:\gitCode\crm\lsc\lsc.crm\Views\Ques\UserAnswerLogInfo.cshtml"
WriteAttributeValue("", 4285, op.ItemIndex, 4285, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 4300, "、", 4300, 1, true);
#line 82 "D:\gitCode\crm\lsc\lsc.crm\Views\Ques\UserAnswerLogInfo.cshtml"
WriteAttributeValue("", 4301, op.Content, 4301, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4315, 27, true);
            WriteLiteral(" lay-skin=\"primary\"></li>\r\n");
            EndContext();
#line 83 "D:\gitCode\crm\lsc\lsc.crm\Views\Ques\UserAnswerLogInfo.cshtml"
                                            }

                                        }

#line default
#line hidden
            BeginContext(4434, 49, true);
            WriteLiteral("                                        <li>正确答案：");
            EndContext();
            BeginContext(4485, 7, false);
#line 86 "D:\gitCode\crm\lsc\lsc.crm\Views\Ques\UserAnswerLogInfo.cshtml"
                                             Write(okopton);

#line default
#line hidden
            EndContext();
            BeginContext(4493, 50, true);
            WriteLiteral("</li>\r\n                                    </ul>\r\n");
            EndContext();
#line 88 "D:\gitCode\crm\lsc\lsc.crm\Views\Ques\UserAnswerLogInfo.cshtml"
                                }
                                break;
                            case QuestionsTypeEnum.FillInTheBlanks:
                                UserAnswer userAn = userAnswers?.FirstOrDefault(x => x.QuestionId == question.Id);

#line default
#line hidden
            BeginContext(4803, 192, true);
            WriteLiteral("                                <div class=\"layui-form-item\">\r\n                                    <p style=\" padding-left: 30px; padding-top: 5px; \">\r\n                                        ");
            EndContext();
            BeginContext(4997, 36, false);
#line 94 "D:\gitCode\crm\lsc\lsc.crm\Views\Ques\UserAnswerLogInfo.cshtml"
                                    Write(userAn != null ? userAn.Content : "");

#line default
#line hidden
            EndContext();
            BeginContext(5034, 47, true);
            WriteLiteral("\r\n                                        <span");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 5081, "\"", 5123, 1);
#line 95 "D:\gitCode\crm\lsc\lsc.crm\Views\Ques\UserAnswerLogInfo.cshtml"
WriteAttributeValue("", 5089, userAn?.Score==0?"color:red":"", 5089, 34, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5124, 2, true);
            WriteLiteral(">【");
            EndContext();
            BeginContext(5128, 13, false);
#line 95 "D:\gitCode\crm\lsc\lsc.crm\Views\Ques\UserAnswerLogInfo.cshtml"
                                                                                      Write(userAn?.Score);

#line default
#line hidden
            EndContext();
            BeginContext(5142, 11, true);
            WriteLiteral("分】</span>\r\n");
            EndContext();
#line 96 "D:\gitCode\crm\lsc\lsc.crm\Views\Ques\UserAnswerLogInfo.cshtml"
                                         if (isadmin && userAn != null && userAn.Score == 0)
                                        {

#line default
#line hidden
            BeginContext(5290, 84, true);
            WriteLiteral("                                            <a href=\"javascript:;\" class=\"layui-btn\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 5374, "\"", 5408, 3);
            WriteAttributeValue("", 5384, "setScore(\'", 5384, 10, true);
#line 98 "D:\gitCode\crm\lsc\lsc.crm\Views\Ques\UserAnswerLogInfo.cshtml"
WriteAttributeValue("", 5394, userAn.Id, 5394, 12, false);

#line default
#line hidden
            WriteAttributeValue("", 5406, "\')", 5406, 2, true);
            EndWriteAttribute();
            BeginContext(5409, 11, true);
            WriteLiteral(">设置分数</a>\r\n");
            EndContext();
#line 99 "D:\gitCode\crm\lsc\lsc.crm\Views\Ques\UserAnswerLogInfo.cshtml"
                                        }

#line default
#line hidden
            BeginContext(5463, 82, true);
            WriteLiteral("                                    </p>\r\n                                </div>\r\n");
            EndContext();
#line 102 "D:\gitCode\crm\lsc\lsc.crm\Views\Ques\UserAnswerLogInfo.cshtml"
                                break;
                        }
                    }

#line default
#line hidden
            BeginContext(5635, 47, true);
            WriteLiteral("                </form>\r\n\r\n            </div>\r\n");
            EndContext();
#line 108 "D:\gitCode\crm\lsc\lsc.crm\Views\Ques\UserAnswerLogInfo.cshtml"
        }
    }
}

#line default
#line hidden
            DefineSection("Scripts", async() => {
                BeginContext(5720, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(5726, 50, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b986cfd32c6e1c5821a090d976c8f7824aaac53a21099", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5776, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(5782, 46, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b986cfd32c6e1c5821a090d976c8f7824aaac53a22355", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5828, 709, true);
                WriteLiteral(@"
    <script>
        var layer;
        layui.use('form',
            'element',
            'layer',
            function() {
                var form = layui.form;
                var element = layui.element;
                layer = layui.layer;
            });

        var setScore = function(id) {
            layer.prompt({ title: '请输入分数：', formType: 3 }, function (text, index) {
                layer.close(index);
                $.post('/Ques/SetAnswerScore', { score: text, id: id }, function (res) {
                    if (res.code === 1) {
                        window.location.reload();
                    }
                })
            });
        }
    </script>
");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<lsc.Model.UserQuestions>> Html { get; private set; }
    }
}
#pragma warning restore 1591
