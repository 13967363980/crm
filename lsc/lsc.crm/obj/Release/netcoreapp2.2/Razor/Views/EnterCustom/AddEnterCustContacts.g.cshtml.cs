#pragma checksum "D:\gitCode\crm\lsc\lsc.crm\Views\EnterCustom\AddEnterCustContacts.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3d4a8a8235a3bf7f8ee5b309142b79d239b1acdb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_EnterCustom_AddEnterCustContacts), @"mvc.1.0.view", @"/Views/EnterCustom/AddEnterCustContacts.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/EnterCustom/AddEnterCustContacts.cshtml", typeof(AspNetCore.Views_EnterCustom_AddEnterCustContacts))]
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
#line 1 "D:\gitCode\crm\lsc\lsc.crm\Views\EnterCustom\AddEnterCustContacts.cshtml"
using lsc.Common;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d4a8a8235a3bf7f8ee5b309142b79d239b1acdb", @"/Views/EnterCustom/AddEnterCustContacts.cshtml")]
    public class Views_EnterCustom_AddEnterCustContacts : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<lsc.Model.EnterCustContacts>
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
            BeginContext(55, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "D:\gitCode\crm\lsc\lsc.crm\Views\EnterCustom\AddEnterCustContacts.cshtml"
  
    ViewData["Title"] = "客户联系人";
    Layout = "~/Pages/_LayoutNone.cshtml";
    int type = ViewBag.type;
    if (type!=0)
    {
        Layout = "~/Pages/_Layout.cshtml"; 
    }
    //if (Model!=null)
    //{
    //    Layout = "~/Pages/_LayoutNone.cshtml";
    // }

#line default
#line hidden
            BeginContext(342, 418, true);
            WriteLiteral(@"<blockquote class=""layui-elem-quote"">
    添加客户联系人信息
</blockquote>
<div class=""manage-form-container"">
    <form class=""layui-form"" method=""post"" id=""addform"" action=""/EnterCustom/SaveEnterCustContacts"">
        <div class=""layui-form-item"">
            <label class=""layui-form-label"">姓名</label>
            <div class=""layui-input-block"">
                <input type=""text"" class=""layui-input layui-form-text""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 760, "\"", 798, 1);
#line 25 "D:\gitCode\crm\lsc\lsc.crm\Views\EnterCustom\AddEnterCustContacts.cshtml"
WriteAttributeValue("", 768, Model!=null ? Model.Name:"", 768, 30, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(799, 301, true);
            WriteLiteral(@" name=""Name""  placeholder=""请输入名称"" autocomplete=""off"" />
            </div>
        </div>
        <div class=""layui-form-item"">
            <label class=""layui-form-label"">性别</label>
            <div class=""layui-input-block"">
                <input type=""radio"" name=""sex"" value=""1"" title=""男""  ");
            EndContext();
            BeginContext(1102, 68, false);
#line 31 "D:\gitCode\crm\lsc\lsc.crm\Views\EnterCustom\AddEnterCustContacts.cshtml"
                                                                Write(Model!=null && Model.Sex == lsc.Model.Enume.SexEnum.Man?"checked":"");

#line default
#line hidden
            EndContext();
            BeginContext(1171, 70, true);
            WriteLiteral(">\r\n                <input type=\"radio\" name=\"sex\" value=\"2\" title=\"女\" ");
            EndContext();
            BeginContext(1243, 70, false);
#line 32 "D:\gitCode\crm\lsc\lsc.crm\Views\EnterCustom\AddEnterCustContacts.cshtml"
                                                               Write(Model!=null && Model.Sex == lsc.Model.Enume.SexEnum.Woman?"checked":"");

#line default
#line hidden
            EndContext();
            BeginContext(1314, 251, true);
            WriteLiteral(">\r\n            </div>\r\n        </div>\r\n        <div class=\"layui-form-item\">\r\n            <label class=\"layui-form-label\">负责业务</label>\r\n            <div class=\"layui-input-block\">\r\n                <input type=\"text\" class=\"layui-input layui-form-text\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1565, "\"", 1607, 1);
#line 38 "D:\gitCode\crm\lsc\lsc.crm\Views\EnterCustom\AddEnterCustContacts.cshtml"
WriteAttributeValue("", 1573, Model!=null ? Model.Business:"", 1573, 34, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1608, 309, true);
            WriteLiteral(@" name=""Business"" placeholder=""请输入负责业务"" autocomplete=""off""  />
            </div>
        </div>
        <div class=""layui-form-item"">
            <label class=""layui-form-label"">部门</label>
            <div class=""layui-input-block"">
                <input type=""text"" class=""layui-input layui-form-text""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1917, "\"", 1963, 1);
#line 44 "D:\gitCode\crm\lsc\lsc.crm\Views\EnterCustom\AddEnterCustContacts.cshtml"
WriteAttributeValue("", 1925, Model!=null ? Model.Department : "", 1925, 38, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1964, 313, true);
            WriteLiteral(@" name=""Department"" placeholder=""请输入联系人所在部门"" autocomplete=""off"" />
            </div>
        </div>
        <div class=""layui-form-item"">
            <label class=""layui-form-label"">职务</label>
            <div class=""layui-input-block"">
                <input type=""text"" class=""layui-input layui-form-text""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2277, "\"", 2317, 1);
#line 50 "D:\gitCode\crm\lsc\lsc.crm\Views\EnterCustom\AddEnterCustContacts.cshtml"
WriteAttributeValue("", 2285, Model!=null ? Model.Duties:"", 2285, 32, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2318, 336, true);
            WriteLiteral(@" name=""Duties"" placeholder=""请输入联系人职务"" autocomplete=""off"" />
            </div>
        </div>
        <div class=""layui-form-item"">
            <label class=""layui-form-label"">手机号</label>
            <div class=""layui-input-block"">
                <input type=""text"" class=""layui-input layui-form-text"" onchange=""telonchanged()""  ");
            EndContext();
            BeginContext(2656, 57, false);
#line 56 "D:\gitCode\crm\lsc\lsc.crm\Views\EnterCustom\AddEnterCustContacts.cshtml"
                                                                                              Write(Model!=null&& !Model.Telephone.IsNull() ? "readonly" : "");

#line default
#line hidden
            EndContext();
            BeginContext(2714, 8, true);
            WriteLiteral(" value=\"");
            EndContext();
            BeginContext(2724, 32, false);
#line 56 "D:\gitCode\crm\lsc\lsc.crm\Views\EnterCustom\AddEnterCustContacts.cshtml"
                                                                                                                                                                  Write(Model!=null ? Model.Telephone:"");

#line default
#line hidden
            EndContext();
            BeginContext(2757, 353, true);
            WriteLiteral(@""" name=""Telephone"" id=""Telephone"" placeholder=""请输入手机号"" autocomplete=""off"" />
            </div>
        </div>
        <div class=""layui-form-item"">
            <label class=""layui-form-label"">固定电话</label>
            <div class=""layui-input-block"">
                <input type=""text"" class=""layui-input layui-form-text"" onchange=""phonechanged()"" ");
            EndContext();
            BeginContext(3112, 56, false);
#line 62 "D:\gitCode\crm\lsc\lsc.crm\Views\EnterCustom\AddEnterCustContacts.cshtml"
                                                                                             Write(Model!=null&& !Model.Landline.IsNull() ? "readonly" : "");

#line default
#line hidden
            EndContext();
            BeginContext(3169, 8, true);
            WriteLiteral(" value=\"");
            EndContext();
            BeginContext(3179, 31, false);
#line 62 "D:\gitCode\crm\lsc\lsc.crm\Views\EnterCustom\AddEnterCustContacts.cshtml"
                                                                                                                                                                Write(Model!=null ? Model.Landline:"");

#line default
#line hidden
            EndContext();
            BeginContext(3211, 335, true);
            WriteLiteral(@""" name=""Landline"" placeholder=""请输入手机号"" autocomplete=""off"" />
            </div>
        </div>
        <div class=""layui-form-item"">
            <label class=""layui-form-label"">邮箱</label>
            <div class=""layui-input-block"">
                <input type=""email"" class=""layui-input layui-form-text"" onchange=""emailchanged()""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 3546, "\"", 3585, 1);
#line 68 "D:\gitCode\crm\lsc\lsc.crm\Views\EnterCustom\AddEnterCustContacts.cshtml"
WriteAttributeValue("", 3554, Model!=null ? Model.Email:"", 3554, 31, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3586, 338, true);
            WriteLiteral(@" name=""Email"" id=""Email"" placeholder=""请输入邮箱"" autocomplete=""off""  />
            </div>
        </div>
        <div class=""layui-form-item"">
            <label class=""layui-form-label"">QQ</label>
            <div class=""layui-input-block"">
                <input type=""text"" class=""layui-input layui-form-text"" onchange=""qqchanged()""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 3924, "\"", 3960, 1);
#line 74 "D:\gitCode\crm\lsc\lsc.crm\Views\EnterCustom\AddEnterCustContacts.cshtml"
WriteAttributeValue("", 3932, Model!=null ? Model.QQ:"", 3932, 28, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3961, 332, true);
            WriteLiteral(@"  name=""QQ"" placeholder=""请输入QQ号"" autocomplete=""off""  />
            </div>
        </div>
        <div class=""layui-form-item"">
            <label class=""layui-form-label"">微信号</label>
            <div class=""layui-input-block"">
                <input type=""text"" class=""layui-input layui-form-text"" onchange=""wechartchanged()""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 4293, "\"", 4334, 1);
#line 80 "D:\gitCode\crm\lsc\lsc.crm\Views\EnterCustom\AddEnterCustContacts.cshtml"
WriteAttributeValue("", 4301, Model!=null ? Model.WeChart:"", 4301, 33, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4335, 306, true);
            WriteLiteral(@" name=""WeChart"" placeholder=""请输入微信号"" autocomplete=""off"" />
            </div>
        </div>
        <div class=""layui-form-item"">
            <label class=""layui-form-label"">住址</label>
            <div class=""layui-input-block"">
                <input type=""text"" class=""layui-input layui-form-text""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 4641, "\"", 4682, 1);
#line 86 "D:\gitCode\crm\lsc\lsc.crm\Views\EnterCustom\AddEnterCustContacts.cshtml"
WriteAttributeValue("", 4649, Model!=null ? Model.Address:"", 4649, 33, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4683, 317, true);
            WriteLiteral(@" name=""Address"" placeholder=""请输入住址"" autocomplete=""off"" />
            </div>
        </div>
        <div class=""layui-form-item"">
            <label class=""layui-form-label"">备注</label>
            <div class=""layui-input-block"">
                <textarea name=""Rem"" class=""layui-form-text layui-input"" rows=""4"">");
            EndContext();
            BeginContext(5002, 26, false);
#line 92 "D:\gitCode\crm\lsc\lsc.crm\Views\EnterCustom\AddEnterCustContacts.cshtml"
                                                                              Write(Model!=null ? Model.Rem:"");

#line default
#line hidden
            EndContext();
            BeginContext(5029, 245, true);
            WriteLiteral("</textarea>\r\n            </div>\r\n        </div>\r\n        <div class=\"layui-form-label\">\r\n            <div class=\"layui-input-block\"><button class=\"layui-btn\" lay-submit lay-filter=\"*\">提交</button></div>\r\n            <input type=\"hidden\" name=\"ID\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 5274, "\"", 5322, 1);
#line 97 "D:\gitCode\crm\lsc\lsc.crm\Views\EnterCustom\AddEnterCustContacts.cshtml"
WriteAttributeValue("", 5282, Model!=null ? Model.ID.ToString() :"", 5282, 40, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5323, 56, true);
            WriteLiteral(" />\r\n            <input type=\"hidden\" name=\"EnterCustID\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 5379, "\"", 5452, 1);
#line 98 "D:\gitCode\crm\lsc\lsc.crm\Views\EnterCustom\AddEnterCustContacts.cshtml"
WriteAttributeValue("", 5387, Model!=null ? Model.EnterCustID.ToString():ViewBag.EnterCustID, 5387, 65, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5453, 63, true);
            WriteLiteral(" />\r\n            <input type=\"hidden\" name=\"mobile\" id=\"mobile\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 5516, "\"", 5574, 1);
#line 99 "D:\gitCode\crm\lsc\lsc.crm\Views\EnterCustom\AddEnterCustContacts.cshtml"
WriteAttributeValue("", 5524, Model!=null ? Model.Telephone+Model.Landline:"", 5524, 50, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5575, 63, true);
            WriteLiteral(" />\r\n            <input type=\"hidden\" name=\"emails\" id=\"emails\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 5638, "\"", 5700, 1);
#line 100 "D:\gitCode\crm\lsc\lsc.crm\Views\EnterCustom\AddEnterCustContacts.cshtml"
WriteAttributeValue("", 5646, Model!=null ? Model.QQ+Model.Email+Model.WeChart:"", 5646, 54, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5701, 46, true);
            WriteLiteral(" />\r\n            <input type=\"hidden\" name=\"t\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 5747, "\"", 5770, 1);
#line 101 "D:\gitCode\crm\lsc\lsc.crm\Views\EnterCustom\AddEnterCustContacts.cshtml"
WriteAttributeValue("", 5755, ViewBag.type, 5755, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5771, 42, true);
            WriteLiteral(" />\r\n        </div>\r\n    </form>\r\n</div>\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(5830, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(5836, 50, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3d4a8a8235a3bf7f8ee5b309142b79d239b1acdb17758", async() => {
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
                BeginContext(5886, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(5892, 46, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3d4a8a8235a3bf7f8ee5b309142b79d239b1acdb19014", async() => {
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
                BeginContext(5938, 3832, true);
                WriteLiteral(@"
    <script type=""text/javascript"">
        var form, layer
        layui.use(['form', 'element', 'layer'],
            function() {
                form = layui.form
                layer = layui.layer
            })
        jQuery.validator.addMethod(""isPhone"",
            function(value, element) {
                var length = value.length;
                var mobile = /^(((13[0-9]{1})|(15[0-9]{1})|(18[0-9]{1})|(17[0-9]{1}))+\d{8})$/;
                return this.optional(element) || (length == 11 && mobile.test(value));
            },
            ""请填写正确的手机号码"");

        jQuery.validator.addMethod(""isTel"",
            function(value, element) {
                var length = value.length;
                var phone = /^\d{3,4}-\d{7,8}$/;
                return this.optional(element) || (phone.test(value));
            },
            ""请填写正确的固定电话"");

        jQuery.validator.addMethod(""isQQ"",
            function(value, element) {
                var length = value.length;
           ");
                WriteLiteral(@"     var qq = /^[1-9][0-9]{4,9}$/;
                return this.optional(element) || (qq.test(value));
            },
            ""请填写正确的QQ号"");
        $('#addform').validate({
            ignore: """",
            rules: {
                Name: {
                    required: true,
                    maxlength: 64
                },
                sex: {
                    required: true
                },
                Telephone: {
                    isPhone: true
                },
                Landline: {
                    isTel: true
                },
                mobile: {
                    required: true
                },
                Email: {
                    email: true
                },
                QQ: {
                    isQQ: true
                },
                emails: {
                    required: true
                }
            },
            messages: {
                Name: {
                    required: ""请输入联系人名称"",
    ");
                WriteLiteral(@"                maxlength: ""联系人名称最多64个字""
                },
                sex: {
                    required: ""请选择性别""
                },
                Telephone: {
                    isPhone: ""请输入正确格式的手机号""
                },
                Landline: {
                    Landline: ""请输入正确格式的固定电话号""
                },
                mobile: {
                    required: ""手机号和固话号至少填一个""
                },
                Email: {
                    email: ""请输入正确格式的邮箱""
                },
                QQ: {
                    isQQ: ""请输入正确的QQ号""
                },
                emails: {
                    required: ""邮箱、QQ、微信号至少填写一个""
                }
            },
            errorPlacement: function(error, element) {
                console.log(element)
                if (element.attr(""name"") == ""mobile"") {
                    error.insertAfter(""#Telephone"");
                } else if (element.attr(""name"") == ""emails"") {
                    error.insertAfter(""#Email"")");
                WriteLiteral(@";
                } else {
                    error.insertAfter(element);
                }
            },
            submitHandler: function(form) {
                //layer.load(0, { shade: false })
                $(form).ajaxSubmit(function(res) {
                    if (res.code === 1) {
                        layer.msg('保存成功', { icon: 6 });
                        var t = Number($(""input[name='t']"").val());
                        if (t === 0) {
                            var index = parent.layer.getFrameIndex(window.name); //先得到当前iframe层的索引
                            parent.layer.close(index); //再执行关闭
                        } else {
                            window.location = '/EnterCustom/AddEnterCustPhaseLog?types=1&id=");
                EndContext();
                BeginContext(9772, 62, false);
#line 214 "D:\gitCode\crm\lsc\lsc.crm\Views\EnterCustom\AddEnterCustContacts.cshtml"
                                                                                        Write(Model!=null ? Model.EnterCustID.ToString():ViewBag.EnterCustID);

#line default
#line hidden
                EndContext();
                BeginContext(9835, 1320, true);
                WriteLiteral(@"';
                        }
                    } else {
                        layer.msg('保存失败', { icon: 5 });
                    }
                });
            }
        });
        var telonchanged = function() {
            console.log($(""input[name='Telephone']"").val());
            $(""#mobile"").val($(""input[name='Telephone']"").val() + $(""input[name='Landline']"").val());
        }
        var phonechanged = function() {
            $(""#mobile"").val($(""input[name='Telephone']"").val() + $(""input[name='Landline']"").val());
        }
        var emailchanged = function() {
            var values = $(""input[name='Email']"").val() +
                $(""input[name='QQ']"").val() +
                $(""input[name='WeChart']"").val();
            $(""#emails"").val(values);
        }
        var qqchanged = function() {
            var values = $(""input[name='Email']"").val() +
                $(""input[name='QQ']"").val() +
                $(""input[name='WeChart']"").val();
            $(""#ema");
                WriteLiteral(@"ils"").val(values);
        }
        var wechartchanged = function() {
            var values = $(""input[name='Email']"").val() +
                $(""input[name='QQ']"").val() +
                $(""input[name='WeChart']"").val();
            $(""#emails"").val(values);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<lsc.Model.EnterCustContacts> Html { get; private set; }
    }
}
#pragma warning restore 1591
