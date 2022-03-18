#pragma checksum "C:\Users\muham\source\repos\NewsApplication\NewsApp\Views\News\AddNew.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bba46c8a20f58ce3225b50f04544de522945874a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_News_AddNew), @"mvc.1.0.view", @"/Views/News/AddNew.cshtml")]
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
#line 1 "C:\Users\muham\source\repos\NewsApplication\NewsApp\Views\_ViewImports.cshtml"
using NewsApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\muham\source\repos\NewsApplication\NewsApp\Views\_ViewImports.cshtml"
using NewsApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bba46c8a20f58ce3225b50f04544de522945874a", @"/Views/News/AddNew.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee3bfdea42c54347df92675d2462c147d0ad7987", @"/Views/_ViewImports.cshtml")]
    public class Views_News_AddNew : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<RepositoryLayer.Models.School>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("disabled", new global::Microsoft.AspNetCore.Html.HtmlString("disabled"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-localize", new global::Microsoft.AspNetCore.Html.HtmlString("add-news-language.placeholder"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-localize", new global::Microsoft.AspNetCore.Html.HtmlString("add-news-language.rtol"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-localize", new global::Microsoft.AspNetCore.Html.HtmlString("add-news-language.ltor"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\muham\source\repos\NewsApplication\NewsApp\Views\News\AddNew.cshtml"
  
    ViewData["Title"] = "Add News";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row form-group"">
    <div class=""col-2"">
        <label for=""sel1"" data-localize=""add-news-type.self"">News Type:</label>
    </div>
    <div class=""col-10"">
        <div class=""custom-control custom-radio custom-control-inline"">
            <input type=""radio"" class=""custom-control-input"" id=""rdbNewsTypePublic"" name=""rdbNewsType"" checked=""checked"" value=""1"">
            <label class=""custom-control-label"" for=""rdbNewsTypePublic"" data-localize=""add-news-type.public"">Public</label>
        </div>

        <!-- Default inline 2-->
        <div class=""custom-control custom-radio custom-control-inline"">
            <input type=""radio"" class=""custom-control-input"" id=""rdbNewsTypePrivate"" name=""rdbNewsType"" value=""2"">
            <label class=""custom-control-label"" for=""rdbNewsTypePrivate"" data-localize=""add-news-type.private"">Private</label>
        </div>
    </div>
</div>

<div class=""row form-group"">
    <div class=""col-2"">
        <label for=""sel1"" data-localize=""add-news-schoo");
            WriteLiteral(@"l.self"">School:</label>
    </div>
    <div class=""col-10"">
        <div class=""row"">
            <div class=""col-3"">
                <label class=""form-check-label"" >
                    <input type=""checkbox"" class=""form-check-input"" value=""0"" id=""chkSelectAllSchools"" ><p data-localize=""add-news-school.value"">All School</p>
                </label>
            </div>
");
#nullable restore
#line 35 "C:\Users\muham\source\repos\NewsApplication\NewsApp\Views\News\AddNew.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-3\">\r\n                    <label class=\"form-check-label\">\r\n                        <input type=\"checkbox\" class=\"form-check-input chkSelectedSchools\"");
            BeginWriteAttribute("value", " value=\"", 1738, "\"", 1760, 1);
#nullable restore
#line 39 "C:\Users\muham\source\repos\NewsApplication\NewsApp\Views\News\AddNew.cshtml"
WriteAttributeValue("", 1746, item.SchoolId, 1746, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 39 "C:\Users\muham\source\repos\NewsApplication\NewsApp\Views\News\AddNew.cshtml"
                                                                                                             Write(item.SchoolName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </label>\r\n                </div>\r\n");
#nullable restore
#line 42 "C:\Users\muham\source\repos\NewsApplication\NewsApp\Views\News\AddNew.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>
    </div>
</div>

<div class=""row form-group"">
    <div class=""col-2"">
        <label for=""sel1"" data-localize=""add-news-title.self"">News Title:</label>
    </div>
    <div class=""col-10"">
        <input type=""text"" class=""form-control"" id=""txtNewsTitle"" aria-describedby=""divNewsTitleValidation"">
        <div id=""divNewsTitleValidation"" class=""invalid-feedback"" data-localize=""add-news-title.error"">
            This field is mandetory
        </div>
    </div>
</div>

<div class=""row form-group"">
    <div class=""col-2"">
        <label for=""sel1"" data-localize=""add-news-text.self"">News Text:</label>
    </div>
    <div class=""col-10"">
        <textarea id=""txtNewsText""></textarea>
    </div>
</div>

<div class=""row form-group"">
    <div class=""col-2"">
        <label for=""sel1""  data-localize=""add-news-picture.self"">News Picture:</label>
    </div>
    <div class=""col-10"">
        <input type=""file"" id=""fileNewsPicture"" accept=""image/*"">
    </div>
</div>

<div c");
            WriteLiteral(@"lass=""row form-group"">
    <div class=""col-2"">
        <label for=""sel1""  data-localize=""add-news-attachments.self"">News Attachments:</label>
    </div>
    <div class=""col-10"">
        <input type=""file"" id=""fileNewsAttachments"" onchange=""readAttachments(this);"" multiple=""multiple"" accept="".doc,.docx,application/msword,application/vnd.openxmlformats-officedocument.wordprocessingml.document,application/vnd.ms-powerpoint, application/vnd.openxmlformats-officedocument.presentationml.slideshow, application/vnd.openxmlformats-officedocument.presentationml.presentation"">
    </div>
</div>

<div class=""row form-group"">
    <div class=""col-2"">
        <label for=""sel1"" data-localize=""add-news-language.self"">News Language:</label>
    </div>
    <div class=""col-10"">
        <select class=""form-select form-control"" id=""ddlSelectLanguage"" aria-describedby=""divNewsLanguageValidation"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bba46c8a20f58ce3225b50f04544de522945874a10588", async() => {
                WriteLiteral("Select any language");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bba46c8a20f58ce3225b50f04544de522945874a12250", async() => {
                WriteLiteral("RTL");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bba46c8a20f58ce3225b50f04544de522945874a13502", async() => {
                WriteLiteral("LTR");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </select>
        <div id=""divNewsLanguageValidation"" class=""invalid-feedback"" data-localize=""add-news-language.error"">
            This field is mandetory
        </div>
    </div>
</div>

<div class=""row form-group"">
    <div class=""col-2"">
        <label for=""sel1"" data-localize=""add-news-expiry-date.self"">Expiry Date :</label>
    </div>
    <div class=""col-10"">
        <div class=""form-group"">
            <input type='text' class=""form-control"" id='dateNewsExpiry' aria-describedby=""divNewsDateValidation"" />
            <div id=""divNewsDateValidation"" class=""invalid-feedback""  data-localize=""add-news-expiry-date.error"">
                Must be greater than Current date
            </div>
        </div>
    </div>
</div>

<div>
    <button type=""button"" class=""btn btn-primary"" id=""btnSaveNews"" data-localize=""add-news-save.self"">Save</button>
</div>



    <script src=""https://cdn.tiny.cloud/1/no-api-key/tinymce/5/tinymce.min.js"" referrerpolicy=""origin""></script>


  ");
            WriteLiteral(@"  <script>

        $(function () {

            tinymce.init({
                selector: '#txtNewsText',  // change this value according to your HTML
            });

            //tinymce.init({
            //    selector: '#txtNewsText',
            //    toolbar: 'language',
            //    content_langs: [
            //        { title: 'English', code: 'en' },
            //        { title: 'Arabic', code: 'ar' },
            //    ],
            //    directionality: 'rtl'
            //});

            $('#dateNewsExpiry').datetimepicker();

            $('#chkSelectAllSchools').change(function () {
                $('.chkSelectedSchools').prop(""checked"", $(this).is("":checked""));
            });

            $('#txtNewsTitle').change(function () {
                $(this).removeClass('is-invalid');
            });

            $('#ddlSelectLanguage').change(function () {
                $(this).removeClass('is-invalid');
                if (parseInt($(this).val())== 2) {");
            WriteLiteral(@"
                    tinymce.remove('#txtNewsText');
                    tinymce.init({
                        selector: '#txtNewsText',  // change this value according to your HTML
                        language: 'ar',
                        language_url: '/lang/ar.js',
                        directionality: 'rtl'
                    });
                }
                else {
                    tinymce.remove('#txtNewsText');
                    tinymce.init({
                        selector: '#txtNewsText',  // change this value according to your HTML
                    });
                }

            });

            $(""#dateNewsExpiry"").on(""dp.change"", function (e) {
                $('#dateNewsExpiry').removeClass('is-invalid');
            });

            $('.chkSelectedSchools').change(function () {
                if ($('.chkSelectedSchools:checked').length == $('.chkSelectedSchools').length) {
                    $('#chkSelectAllSchools').prop(""checked"", true);
");
            WriteLiteral(@"                }
                else {
                    $('#chkSelectAllSchools').prop(""checked"", false);
                }
            });

            $('#fileNewsPicture').on('change', function (e) {
                let file = null;
                file = e.target.files[0];
                news_picture = file;
            });

            $('#btnSaveNews').click(function () {
                $('#txtNewsTitle').removeClass('is-invalid');
                $('#ddlSelectLanguage').removeClass('is-invalid');
                $('#dateNewsExpiry').removeClass('is-invalid');
                let is_valid = true;
                let news_title = $('#txtNewsTitle').val();
                if (news_title == '') {
                    $('#txtNewsTitle').addClass('is-invalid');
                    is_valid = false;
                }
                let news_language = parseInt($('#ddlSelectLanguage').val());
                if (isNaN(news_language) || news_language == 0) {
                    $(");
            WriteLiteral(@"'#ddlSelectLanguage').addClass('is-invalid');
                    is_valid = false;
                }

                let expiry_date = $('#dateNewsExpiry').val();
                let parsed_time = null;
                if (expiry_date != '') {
                    let current_time = moment();
                    let parsed_time = moment(expiry_date);
                    if (parsed_time < current_time) {
                        $('#dateNewsExpiry').addClass('is-invalid');
                        is_valid = false;
                    }
                }
                news_text = tinyMCE.editors[$('#txtNewsText').attr('id')].getContent();
                news_type = parseInt($('input[name=rdbNewsType]:checked').val());
                let selected_schools = [];
                $("".chkSelectedSchools:checked"").each(function (index) {
                    selected_schools.push(parseInt($(this).val()));
                });
                if (is_valid) {
                    if (window.FormDat");
            WriteLiteral(@"a !== undefined) {
                        // Create FormData object  
                        var fileData = new FormData();
 
                        if (news_picture != null) {
                            fileData.append('F'+news_picture.name, news_picture);
                        }

                        for (var i = 0; i < NewsAttachments.length; i++) {
                            fileData.append(NewsAttachments[i].file_name, NewsAttachments[i].file_obj);
                        }
                     
                        // Adding one more key to FormData object  
                        fileData.append('ExipiryTime', expiry_date);
                        fileData.append('NewsText', news_text);
                        fileData.append('NewsTitle', news_title);
                        fileData.append('LanguageDir', news_language);
                        fileData.append('NewsType', news_type);
                        fileData.append('SelectedSchools', selected_schools.join());

");
            WriteLiteral(@"                        $.ajax({
                            url: '/News/AddNews',
                            type: ""POST"",
                            contentType: false, // Not to set any content header  
                            processData: false, // Not to process data  
                            data: fileData,
                            success: function (result) {
                                let Converter = $('#arabicConverter').text();
                                if (Converter == 'EN') {
                                    alertify
                                        .confirm('أخبار', ""اضيف بنجاح."", function () {
                                            window.location.href = '/';
                                        }, function () {
                                            $('#txtNewsTitle').val('');
                                            tinyMCE.editors[$('#txtNewsText').attr('id')].setContent('');
                                        }).set('label");
            WriteLiteral(@"s', { ok: 'نعم', cancel: 'أضف آخر' });
                                }
                                else {
                                    alertify
                                        .confirm('News', ""Added successfully."", function () {
                                            window.location.href = '/';
                                        }, function () {
                                            $('#txtNewsTitle').val('');
                                            tinyMCE.editors[$('#txtNewsText').attr('id')].setContent('');
                                        }).set('labels', { ok: 'Ok', cancel: 'Add Another' });
                                }
                            },
                            error: function (err) {
                                alert(err.statusText);
                            }
                        });
                    } else {
                        alert(""FormData is not supported."");
                    } 
         ");
            WriteLiteral(@"       }
            });

        });

        var news_picture = null;

        var NewsAttachments = [];

        function readAttachments(input) {
            NewsAttachments = [];
            if (input.files && input.files[0]) {
                for (var i = 0; i < input.files.length; i++) {
                    let attachment_object = new Object();
                    attachment_object.file_obj = input.files[i];
                    attachment_object.file_name = 'A' + input.files[i].name;
                    NewsAttachments.push(attachment_object);
                }
            }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<RepositoryLayer.Models.School>> Html { get; private set; }
    }
}
#pragma warning restore 1591
