[assembly: JetBrains.UI.Icons.CompiledIcons.CompiledIconsPackAttribute(IconNames=new string[] {
        "Js2OptionPage",
        "AspNetOptionPage",
        "CssOptionPage",
        "JsOptionPage"}, IconPackResourceIdentification="JetBrains.ReSharper.Features.Web;component/resources/FeaturesWebOptionsIcons/Them" +
    "edIcons.FeaturesWebOptions.Generated.Xaml")]
[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]
[assembly: System.Windows.Markup.XmlnsDefinitionAttribute("urn:shemas-jetbrains-com:ui-application-icons-features-web-options", "JetBrains.ReSharper.Features.Web.Resources")]

namespace JetBrains.ReSharper.Features.Web.Intellisense.QUnitHack
{
    
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.JavaScript.LanguageImpl.JavaScriptLanguage))]
    public class ExtraItemsForQUnitCompletion : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ItemsProviderOfSpecificContext<JetBrains.ReSharper.Feature.Services.JavaScript.CodeCompletion.JavaScriptCodeCompletionContext>
    {
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.JavaScript.CodeCompletion.JavaScriptCodeCompletionContext context) { }
        protected override void TransformItems(JetBrains.ReSharper.Feature.Services.JavaScript.CodeCompletion.JavaScriptCodeCompletionContext context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector) { }
    }
}
namespace JetBrains.ReSharper.Features.Web.JavaScriptDaemonInWeb
{
    
    [JetBrains.ProjectModel.ProjectFileTypeAttribute(typeof(JetBrains.ProjectModel.HtmlProjectFileType))]
    public class HtmlInspectionsProcessFactory : JetBrains.ReSharper.Daemon.JavaScript.Stages.InspectionsStage.JavaScriptInspectionsProcessFactory
    {
        public override JetBrains.ReSharper.Daemon.IDaemonStageProcess CreateInspectionsProcess(JetBrains.ReSharper.Daemon.IDaemonProcess process, JetBrains.Application.Settings.IContextBoundSettingsStore settings, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptFile file) { }
    }
    public class InspectionsProcessInHtml : JetBrains.ReSharper.Daemon.JavaScript.Stages.InspectionsStage.InspectionsProcess
    {
        public InspectionsProcessInHtml(JetBrains.ReSharper.Daemon.IDaemonProcess process, JetBrains.Application.Settings.IContextBoundSettingsStore settings, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptFile file) { }
        protected override void AddThisInGlobalContextWarning(JetBrains.ReSharper.Psi.JavaScript.Tree.IThisExpression thisExpression, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer) { }
    }
}
namespace JetBrains.ReSharper.Features.Web.JavaScriptXmlDocReferenceToFile.QuickFixes
{
    
    [JetBrains.ReSharper.Feature.Services.Bulbs.QuickFixAttribute()]
    public class JavaScriptFileReferenceImportFix : JetBrains.ReSharper.Intentions.Html.QuickFixes.Import.HtmlImportPathQuickFix
    {
        public JavaScriptFileReferenceImportFix(JetBrains.ReSharper.Daemon.JavaScript.Stages.ErrorInXmlDocReferenceWarning pathReferecne) { }
    }
}
namespace JetBrains.ReSharper.Features.Web.Options.Asp
{
    
    [JetBrains.UI.Options.OptionsPageAttribute("AspContextActions", "Context Actions", typeof(JetBrains.ReSharper.Daemon.Src.Bulbs.Resources.BulbThemedIcons.ContextAction), HelpKeyword="Reference__Options__Languages__ASP_NET__Context_Actions", ParentId="Aspx")]
    public class AspContextActionsPage : JetBrains.ReSharper.Intentions.Options.ContextActionsPageBase
    {
        [JetBrains.Annotations.PublicAPIAttribute()]
        public const string PID = "AspContextActions";
        public AspContextActionsPage(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionTable contextActionTable, JetBrains.UI.Application.UIApplication uiApplication, JetBrains.Application.Interop.NativeHook.IWindowsHookManager windowsHookManager, JetBrains.ActionManagement.IActionManager actionManager, JetBrains.UI.Options.OptionsSettingsSmartContext smartContext, JetBrains.Threading.IThreading threading) { }
        public override string Id { get; }
    }
    [JetBrains.UI.Options.OptionsPageAttribute("Aspx.Editor", "Editor & Formatting", typeof(JetBrains.ReSharper.Features.Intellisense.Resources.FeaturesIntellisenseThemedIcons.EditorOptionsPage), HelpKeyword="Reference__Options__Languages__ASP_NET__Editor", ParentId="Aspx", Sequence=0D)]
    public class AspEditorPage : JetBrains.ReSharper.Features.Web.Options.Html.HtmlEditorBasePage<JetBrains.ReSharper.Feature.Services.Asp.Options.AspTypingAssistSettings>
    {
        [JetBrains.Annotations.PublicAPIAttribute()]
        public const string PID = "Aspx.Editor";
        public AspEditorPage(JetBrains.DataFlow.Lifetime lifetime, JetBrains.UI.Application.IUIApplication environment, JetBrains.UI.Options.OptionsSettingsSmartContext settings) { }
    }
    [JetBrains.UI.Options.OptionsPageAttribute("Asp.MVC", "MVC", typeof(JetBrains.Resources.Icons.PsiFeaturesUnsortedOptionsThemedIcons.MvcOptionsPage), HelpKeyword="Reference__Options__Languages__ASP_NET__Other", ParentId="Aspx")]
    public class AspMvcOptionsPage : JetBrains.UI.Options.Helpers.AStackPanelOptionsPage3
    {
        [JetBrains.Annotations.PublicAPIAttribute()]
        public const string PID = "Asp.MVC";
        public AspMvcOptionsPage(JetBrains.DataFlow.Lifetime lifetime, JetBrains.UI.Application.IUIApplication environment, JetBrains.UI.Options.OptionsSettingsSmartContext settings) { }
    }
    [JetBrains.UI.Options.OptionsPageAttribute("Asp.Naming", "Web Naming Style", typeof(JetBrains.ReSharper.Features.Environment.Src.Options.FeaturesEnvironmentOptionsThemedIcons.NamingConvention), HelpKeyword="Reference__Options__Languages__ASP_NET__Web_Naming_Style", ParentId="Aspx", Sequence=1D)]
    public class AspNamingOptionsPage : JetBrains.ReSharper.Features.Environment.Options.Naming.CustomNamingOptionsPage<JetBrains.ReSharper.Psi.Web.Naming.WebNamingSettingsKey>
    {
        [JetBrains.Annotations.PublicAPIAttribute()]
        public const string PID = "Asp.Naming";
        public AspNamingOptionsPage(JetBrains.DataFlow.Lifetime lifetime, JetBrains.UI.Options.OptionsSettingsSmartContext settings, JetBrains.ReSharper.Psi.Naming.Elements.INamedElementsManager namedElementsManager, JetBrains.UI.Icons.IThemedIconManager iconman) { }
        public override string Id { get; }
    }
    [JetBrains.UI.Options.OptionsPageAttribute("Aspx", "ASP.NET", typeof(JetBrains.ReSharper.Features.Web.Resources.FeaturesWebOptionsThemedIcons.AspNetOptionPage), HelpKeyword="Reference__Options__Languages__ASP_NET", ParentId="CodeEditing", Sequence=11D)]
    public class AspxPage : JetBrains.UI.Options.IOptionsPage
    {
        public const string PID = "Aspx";
        public JetBrains.UI.CrossFramework.EitherControl Control { get; }
        public string Id { get; }
        public bool OnOk() { }
        public bool ValidatePage() { }
    }
}
namespace JetBrains.ReSharper.Features.Web.Options.CSS
{
    
    [JetBrains.UI.Options.OptionsPageAttribute("CssCodeStyle", "Formatting Style", typeof(JetBrains.ReSharper.Features.Environment.Src.Options.FeaturesEnvironmentOptionsThemedIcons.CodeStyle), HelpKeyword="Reference__Options__Languages__CSS__Formatting_Style", ParentId="CSS", Sequence=1D)]
    public class CssCodeStylePage : JetBrains.UI.Options.IOptionsPage
    {
        public const string PID = "CssCodeStyle";
        public JetBrains.UI.CrossFramework.EitherControl Control { get; }
        public string Id { get; }
        public bool OnOk() { }
        public bool ValidatePage() { }
    }
    [JetBrains.UI.Options.OptionsPageAttribute("CssContextActions", "Context Actions", typeof(JetBrains.ReSharper.Daemon.Src.Bulbs.Resources.BulbThemedIcons.ContextAction), HelpKeyword="Reference__Options__Languages__CSS__Context_Actions", ParentId="CSS")]
    public class CssContextActionsPage : JetBrains.ReSharper.Intentions.Options.ContextActionsPageBase
    {
        public const string PID = "CssContextActions";
        public CssContextActionsPage(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionTable contextActionTable, JetBrains.UI.Application.UIApplication uiApplication, JetBrains.Application.Interop.NativeHook.IWindowsHookManager windowsHookManager, JetBrains.ActionManagement.IActionManager actionManager, JetBrains.UI.Options.OptionsSettingsSmartContext smartContext, JetBrains.Threading.IThreading threading) { }
        public override string Id { get; }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class CssFormatterCodeLayoutPageScheme
    {
        public CssFormatterCodeLayoutPageScheme(JetBrains.Application.Settings.ISettingsStore settingsStore) { }
        public JetBrains.ReSharper.Features.Environment.Options.CodeStyle.CodeStyleDefNew CodeStyleDef { get; }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class CssFormatterLineBreaksPageScheme
    {
        public CssFormatterLineBreaksPageScheme(JetBrains.Application.Settings.ISettingsStore settingsStore) { }
        public JetBrains.ReSharper.Features.Environment.Options.CodeStyle.CodeStyleDefNew CodeStyleDef { get; }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class CssFormatterSpacesPageScheme
    {
        public CssFormatterSpacesPageScheme(JetBrains.Application.Settings.ISettingsStore settingsStore) { }
        public JetBrains.ReSharper.Features.Environment.Options.CodeStyle.CodeStyleDefNew CodeStyleDef { get; }
    }
    [JetBrains.UI.Options.OptionsPageAttribute("CssInspectionSettings", "Inspections", typeof(JetBrains.ReSharper.Features.Environment.Src.Options.FeaturesEnvironmentOptionsThemedIcons.CodeInspections), HelpKeyword="Reference__Options__Languages__CSS__Inspections", ParentId="CSS", Sequence=0.5D)]
    public class CssInspectionOptionsPage : JetBrains.UI.Options.Helpers.AStackPanelOptionsPage3
    {
        public const string PID = "CssInspectionSettings";
        public CssInspectionOptionsPage(JetBrains.DataFlow.Lifetime lifetime, JetBrains.UI.Application.UIApplication uiApplication, JetBrains.UI.Options.OptionsSettingsSmartContext context, JetBrains.ReSharper.Psi.Css.Definitions.CssDefinitions cssDefinitions, JetBrains.Application.Env.Components.ProductSettingsLocation productSettingsLocation) { }
    }
    public class CssNamingOptionsPage : JetBrains.ReSharper.Features.Environment.Options.Naming.CustomNamingOptionsPage<JetBrains.ReSharper.Psi.Css.Naming.CssNamingSettingsKey>
    {
        [JetBrains.Annotations.PublicAPIAttribute()]
        public const string PID = "CSS.Naming";
        public CssNamingOptionsPage(JetBrains.DataFlow.Lifetime lifetime, JetBrains.UI.Options.OptionsSettingsSmartContext settings, JetBrains.ReSharper.Psi.Naming.Elements.INamedElementsManager namedElementsManager, JetBrains.UI.Icons.IThemedIconManager iconman) { }
        public override string Id { get; }
    }
    [JetBrains.UI.Options.OptionsPageAttribute("CSS", "CSS", typeof(JetBrains.ReSharper.Features.Web.Resources.FeaturesWebOptionsThemedIcons.CssOptionPage), HelpKeyword="Reference__Options__Languages__CSS", ParentId="CodeEditing", Sequence=16D)]
    public class CssOptionsPage : JetBrains.UI.Options.IOptionsPage
    {
        public const string PID = "CSS";
        public JetBrains.UI.CrossFramework.EitherControl Control { get; }
        public string Id { get; }
        public bool OnOk() { }
        public bool ValidatePage() { }
    }
}
namespace JetBrains.ReSharper.Features.Web.Options.Html
{
    
    [JetBrains.UI.Options.OptionsPageAttribute("HtmlCodeStyle", "Formatting Style", typeof(JetBrains.ReSharper.Features.Environment.Src.Options.FeaturesEnvironmentOptionsThemedIcons.CodeStyle), HelpKeyword="Reference__Options__Languages__HTML__Formatting_Style", ParentId="HTML", Sequence=1D)]
    public class HtmlCodeStylePage : JetBrains.ReSharper.Features.Environment.Options.CodeStyle.Impl.CodeStylePageWithPreviewOnSettingsKey
    {
        public const string PID = "HtmlCodeStyle";
        public HtmlCodeStylePage(JetBrains.Application.Components.IComponentContainer container, JetBrains.DataFlow.Lifetime lifetime, JetBrains.UI.Application.IUIApplication environment, JetBrains.UI.Options.OptionsSettingsSmartContext smartContext, JetBrains.UI.WindowManagement.WindowFrame windowFrame, JetBrains.ReSharper.Features.Web.Options.Html.HtmlCodeStylePageScheme scheme, JetBrains.TextControl.DocumentMarkup.IDocumentMarkupManager documentMarkupManager, JetBrains.ReSharper.Features.Environment.Options.CodeStyle.Impl.CodeStyleTreeLoader settingsTreeLoader, JetBrains.ReSharper.Features.Common.Options.FakeSolutionProvider fakeSolutionProvider, JetBrains.ProjectModel.FileTypes.IProjectFileTypeServices projectFileTypeServices, JetBrains.ProjectModel.ISolution solution = null) { }
        public override string Id { get; }
        protected override JetBrains.ReSharper.OptionPages.CodeStyle.Impl.CodeStylePreview CreateCodeStylePreview(JetBrains.TextControl.DocumentMarkup.IDocumentMarkupManager documentMarkupManager, JetBrains.UI.WindowManagement.WindowFrame windowFrame, JetBrains.ProjectModel.ISolution solution, JetBrains.ProjectModel.FileTypes.IProjectFileTypeServices projectFileTypeServices) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class HtmlCodeStylePageScheme
    {
        public HtmlCodeStylePageScheme(JetBrains.Application.Settings.ISettingsStore settingsStore) { }
        public JetBrains.ReSharper.Features.Environment.Options.CodeStyle.CodeStyleDefNew CodeStyleDef { get; }
    }
    [JetBrains.UI.Options.OptionsPageAttribute("HtmlContextActions", "Context Actions", typeof(JetBrains.ReSharper.Daemon.Src.Bulbs.Resources.BulbThemedIcons.ContextAction), HelpKeyword="Reference__Options__Languages__HTML__Context_Actions", ParentId="HTML")]
    public class HtmlContextActionsPage : JetBrains.ReSharper.Intentions.Options.ContextActionsPageBase
    {
        [JetBrains.Annotations.PublicAPIAttribute()]
        public const string PID = "HtmlContextActions";
        public HtmlContextActionsPage(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionTable contextActionTable, JetBrains.UI.Application.UIApplication uiApplication, JetBrains.Application.Interop.NativeHook.IWindowsHookManager windowsHookManager, JetBrains.ActionManagement.IActionManager actionManager, JetBrains.UI.Options.OptionsSettingsSmartContext smartContext, JetBrains.Threading.IThreading threading) { }
        public override string Id { get; }
    }
    public abstract class HtmlEditorBasePage<TSettings> : JetBrains.UI.Options.Helpers.AStackPanelOptionsPage3
        where TSettings : JetBrains.ReSharper.Feature.Services.Html.Options.HtmlTypingAssistSettings
    {
        protected HtmlEditorBasePage(JetBrains.DataFlow.Lifetime lifetime, JetBrains.UI.Application.IUIApplication environment, string pid, JetBrains.UI.Options.OptionsSettingsSmartContext settings) { }
    }
    [JetBrains.UI.Options.OptionsPageAttribute("Html.Editor", "Editor", typeof(JetBrains.ReSharper.Features.Intellisense.Resources.FeaturesIntellisenseThemedIcons.EditorOptionsPage), HelpKeyword="Reference__Options__Languages__HTML__Editor", ParentId="HTML", Sequence=0D)]
    public class HtmlEditorPage : JetBrains.ReSharper.Features.Web.Options.Html.HtmlEditorBasePage<JetBrains.ReSharper.Feature.Services.Html.Options.HtmlTypingAssistSettings>
    {
        [JetBrains.Annotations.PublicAPIAttribute()]
        public const string PID = "Html.Editor";
        public HtmlEditorPage(JetBrains.DataFlow.Lifetime lifetime, JetBrains.UI.Application.IUIApplication environment, JetBrains.UI.Options.OptionsSettingsSmartContext settings) { }
    }
    [JetBrains.UI.Options.OptionsPageAttribute("Html.Others", "Other", typeof(JetBrains.Resources.Icons.PsiFeaturesUnsortedOptionsThemedIcons.Others), HelpKeyword="Reference__Options__Languages__HTML__Other", ParentId="HTML")]
    public class HtmlOthersOptionsPage : JetBrains.UI.Options.Helpers.AStackPanelOptionsPage3
    {
        [JetBrains.Annotations.PublicAPIAttribute()]
        public const string PID = "Html.Others";
        public HtmlOthersOptionsPage(JetBrains.DataFlow.Lifetime lifetime, JetBrains.UI.Application.IUIApplication environment, JetBrains.UI.Options.OptionsSettingsSmartContext settings, JetBrains.UI.Application.UIApplication uiApplication, JetBrains.Application.Interop.NativeHook.IWindowsHookManager hookManager, JetBrains.CommonControls.Validation.FormValidators formValidators) { }
        public override bool OnOk() { }
    }
    [JetBrains.UI.Options.OptionsPageAttribute("HTML", "HTML", typeof(JetBrains.IDE.Resources.IdeThemedIcons.HtmlDocument), HelpKeyword="Reference__Options__Languages__HTML", ParentId="CodeEditing", Sequence=10D)]
    public class HtmlPage : JetBrains.UI.Options.IOptionsPage
    {
        public const string PID = "HTML";
        public JetBrains.UI.CrossFramework.EitherControl Control { get; }
        public string Id { get; }
        public bool OnOk() { }
        public bool ValidatePage() { }
    }
}
namespace JetBrains.ReSharper.Features.Web.Options.JavaScript
{
    
    [JetBrains.Application.ShellComponentAttribute()]
    public class BracesPageScheme
    {
        public BracesPageScheme(JetBrains.Application.Settings.ISettingsStore settingsStore) { }
        public JetBrains.ReSharper.Features.Environment.Options.CodeStyle.CodeStyleDefNew BracesStyle { get; }
    }
    public class static JavaScriptCodeStyleDefSpaces { }
    [JetBrains.UI.Options.OptionsPageAttribute("JavaScriptCodeStyle", "Formatting Style", typeof(JetBrains.ReSharper.Features.Environment.Src.Options.FeaturesEnvironmentOptionsThemedIcons.CodeStyle), HelpKeyword="Reference__Options__Languages__JavaScript__Formatting_Style", ParentId="JavaScript", Sequence=1D)]
    public class JavaScriptCodeStylePage : JetBrains.UI.Options.IOptionsPage
    {
        public const string PID = "JavaScriptCodeStyle";
        public JetBrains.UI.CrossFramework.EitherControl Control { get; }
        public string Id { get; }
        public bool OnOk() { }
        public bool ValidatePage() { }
    }
    [JetBrains.UI.Options.OptionsPageAttribute("JavaScriptContextActions", "Context Actions", typeof(JetBrains.ReSharper.Daemon.Src.Bulbs.Resources.BulbThemedIcons.ContextAction), HelpKeyword="Reference__Options__Languages__JavaScript__Context_Actions", ParentId="JavaScript")]
    public class JavaScriptContextActionsPage : JetBrains.ReSharper.Intentions.Options.ContextActionsPageBase
    {
        public const string PID = "JavaScriptContextActions";
        public JavaScriptContextActionsPage(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionTable contextActionTable, JetBrains.UI.Application.UIApplication uiApplication, JetBrains.Application.Interop.NativeHook.IWindowsHookManager windowsHookManager, JetBrains.ActionManagement.IActionManager actionManager, JetBrains.UI.Options.OptionsSettingsSmartContext smartContext, JetBrains.Threading.IThreading threading) { }
        public override string Id { get; }
    }
    [JetBrains.UI.Options.OptionsPageAttribute("JavaScript.Naming", "JavaScript Naming Style", typeof(JetBrains.ReSharper.Features.Environment.Src.Options.FeaturesEnvironmentOptionsThemedIcons.NamingConvention), HelpKeyword="Reference__Options__Languages__JavaScript__Naming_Style", ParentId="JavaScript", Sequence=0D)]
    public class JavaScriptNamingOptionsPage : JetBrains.ReSharper.Features.Environment.Options.Naming.CustomNamingOptionsPage<JetBrains.ReSharper.Psi.JavaScript.Naming.JavaScriptNamingSettingsKey>
    {
        [JetBrains.Annotations.PublicAPIAttribute()]
        public const string PID = "JavaScript.Naming";
        public JavaScriptNamingOptionsPage(JetBrains.DataFlow.Lifetime lifetime, JetBrains.UI.Options.OptionsSettingsSmartContext settings, JetBrains.ReSharper.Psi.Naming.Elements.INamedElementsManager namedElementsManager, JetBrains.UI.Icons.IThemedIconManager iconman) { }
        public override string Id { get; }
    }
    [JetBrains.UI.Options.OptionsPageAttribute("JavaScript", "JavaScript", typeof(JetBrains.ReSharper.Features.Web.Resources.FeaturesWebOptionsThemedIcons.JsOptionPage), HelpKeyword="Reference__Options__Languages__JavaScript", ParentId="CodeEditing", Sequence=15D)]
    public class JavaScriptPage : JetBrains.UI.Options.IOptionsPage
    {
        public const string PID = "JavaScript";
        public JetBrains.UI.CrossFramework.EitherControl Control { get; }
        public string Id { get; }
        public bool OnOk() { }
        public bool ValidatePage() { }
    }
    [JetBrains.UI.Options.OptionsPageAttribute("JavaScriptResolve", "Inspections", typeof(JetBrains.ReSharper.Features.Environment.Src.Options.FeaturesEnvironmentOptionsThemedIcons.CodeInspections), HelpKeyword="Reference__Options__Languages__JavaScript__Inspections_Analysis", ParentId="JavaScript", Sequence=0.5D)]
    public class JavaScriptResolveSettingsPage : JetBrains.UI.Options.Helpers.AStackPanelOptionsPage3
    {
        public readonly JetBrains.DataFlow.Property<bool> FullResolveForDynamicReferences;
        public const string PID = "JavaScriptResolve";
        public JavaScriptResolveSettingsPage(JetBrains.DataFlow.Lifetime lifetime, JetBrains.UI.Application.IUIApplication environment, JetBrains.UI.Options.OptionsSettingsSmartContext context) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class LineBreaksPageScheme
    {
        public LineBreaksPageScheme(JetBrains.Application.Settings.ISettingsStore settingsStore) { }
        public JetBrains.ReSharper.Features.Environment.Options.CodeStyle.CodeStyleDefNew LineBreaks { get; }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class OthersPageScheme
    {
        public OthersPageScheme(JetBrains.Application.Settings.ISettingsStore settingsStore) { }
        public JetBrains.ReSharper.Features.Environment.Options.CodeStyle.CodeStyleDefNew Others { get; }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class SpacesPageScheme
    {
        public SpacesPageScheme(JetBrains.Application.Settings.ISettingsStore settingsStore) { }
        public JetBrains.ReSharper.Features.Environment.Options.CodeStyle.CodeStyleDefNew Spaces { get; }
    }
}
namespace JetBrains.ReSharper.Features.Web.Options.Razor
{
    
    [JetBrains.UI.Options.OptionsPageAttribute("RazorContextActions", "Context Actions", typeof(JetBrains.ReSharper.Daemon.Src.Bulbs.Resources.BulbThemedIcons.ContextAction), HelpKeyword="Reference__Options__Languages__Razor__Context_Actions", ParentId="Razor")]
    public class RazorContextActionsPage : JetBrains.ReSharper.Intentions.Options.ContextActionsPageBase
    {
        public const string PID = "RazorContextActions";
        public RazorContextActionsPage(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionTable contextActionTable, JetBrains.UI.Application.UIApplication uiApplication, JetBrains.Application.Interop.NativeHook.IWindowsHookManager windowsHookManager, JetBrains.ActionManagement.IActionManager actionManager, JetBrains.UI.Options.OptionsSettingsSmartContext smartContext, JetBrains.Threading.IThreading threading) { }
        public override string Id { get; }
    }
    [JetBrains.UI.Options.OptionsPageAttribute("Razor.Editor", "Editor & Formatting", typeof(JetBrains.ReSharper.Features.Intellisense.Resources.FeaturesIntellisenseThemedIcons.EditorOptionsPage), HelpKeyword="Reference__Options__Languages__Razor__Editor", ParentId="Razor", Sequence=0D)]
    public class RazorEditorPage : JetBrains.ReSharper.Features.Web.Options.Html.HtmlEditorBasePage<JetBrains.ReSharper.Feature.Services.Razor.Options.RazorTypingAssistSettings>
    {
        [JetBrains.Annotations.PublicAPIAttribute()]
        public const string PID = "Razor.Editor";
        public RazorEditorPage(JetBrains.DataFlow.Lifetime lifetime, JetBrains.UI.Application.IUIApplication environment, JetBrains.UI.Options.OptionsSettingsSmartContext settings) { }
    }
    [JetBrains.UI.Options.OptionsPageAttribute("Razor", "Razor", typeof(JetBrains.ReSharper.Psi.Razor.Resources.PsiRazorThemedIcons.Razor), HelpKeyword="Reference__Options__Languages__Razor", ParentId="CodeEditing", Sequence=12D)]
    public class RazorPage : JetBrains.UI.Options.IOptionsPage
    {
        public const string PID = "Razor";
        public JetBrains.UI.CrossFramework.EitherControl Control { get; }
        public string Id { get; }
        public bool OnOk() { }
        public bool ValidatePage() { }
    }
}
namespace JetBrains.ReSharper.Features.Web.Resources
{
    
    public sealed class FeaturesWebOptionsThemedIcons
    {
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Features.Web;component/resources/FeaturesWebOptionsIcons/Them" +
            "edIcons.FeaturesWebOptions.Generated.Xaml", 1, "AspNetOptionPage")]
        public sealed class AspNetOptionPage : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Features.Web;component/resources/FeaturesWebOptionsIcons/Them" +
            "edIcons.FeaturesWebOptions.Generated.Xaml", 2, "CssOptionPage")]
        public sealed class CssOptionPage : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Features.Web;component/resources/FeaturesWebOptionsIcons/Them" +
            "edIcons.FeaturesWebOptions.Generated.Xaml", 0, "Js2OptionPage")]
        public sealed class Js2OptionPage : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Features.Web;component/resources/FeaturesWebOptionsIcons/Them" +
            "edIcons.FeaturesWebOptions.Generated.Xaml", 3, "JsOptionPage")]
        public sealed class JsOptionPage : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
    }
}
namespace JetBrains.ReSharper.Features.Web.StructuralSearch.Asp
{
    
    [JetBrains.ReSharper.Features.StructuralSearch.Placeholders.PlaceholderEditorAttribute(typeof(JetBrains.ReSharper.Psi.Asp.AspLanguage))]
    public class AspTagPlaceholderEditor : JetBrains.ReSharper.Features.Web.StructuralSearch.Html.HtmlTagPlaceholderEditor
    {
        public AspTagPlaceholderEditor(JetBrains.UI.Application.IUIApplication environment, JetBrains.Application.Interop.NativeHook.IWindowsHookManager hookManager, JetBrains.CommonControls.Validation.FormValidators formValidators, JetBrains.UI.Tooltips.ITooltipManager tooltipManager, JetBrains.ReSharper.Psi.Asp.AspLanguage aspLanguage) { }
        public override System.Type PlaceholderType { get; }
        protected override JetBrains.ReSharper.Features.Web.StructuralSearch.Html.UI.HtmlTagPlaceholderEditForm CreateEditor(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Psi.Services.Html.StructuralSearch.Placeholders.HtmlTagPlaceholder placeholder, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder> placeholders, System.Windows.Forms.IWin32Window mainwin) { }
    }
}
namespace JetBrains.ReSharper.Features.Web.StructuralSearch.Asp.UI
{
    
    public class AspTagPlaceholderEditForm : JetBrains.ReSharper.Features.Web.StructuralSearch.Html.UI.HtmlTagPlaceholderEditForm
    {
        public AspTagPlaceholderEditForm(JetBrains.UI.Application.IUIApplication environment, JetBrains.ReSharper.Psi.Asp.AspLanguage aspLanguage, JetBrains.Application.Interop.NativeHook.IWindowsHookManager hookManager, JetBrains.CommonControls.Validation.FormValidators formValidators, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Psi.Services.Html.StructuralSearch.Placeholders.HtmlTagPlaceholder placeholder, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder> placeholders, System.Windows.Forms.IWin32Window mainwin) { }
        protected JetBrains.ReSharper.Psi.Services.Asp.StructuralSearch.AspTagPlaceholder AspPlaceholder { get; }
        protected override void CreatePlaceholder() { }
        protected override void InitForm() { }
        protected override int InitializeAdditionalComponents(int yPos) { }
        protected override void SaveToPlaceholder() { }
    }
}
namespace JetBrains.ReSharper.Features.Web.StructuralSearch.Html
{
    
    [JetBrains.ReSharper.Features.StructuralSearch.Placeholders.PlaceholderEditorAttribute(typeof(JetBrains.ReSharper.Psi.Html.HtmlLanguage))]
    public class HtmlAttributeSequencePlaceholderEditor : JetBrains.ReSharper.Features.StructuralSearch.Placeholders.PlaceholderEditorBase<JetBrains.ReSharper.Psi.Services.Html.StructuralSearch.Placeholders.HtmlAttributeSequencePlaceholder, JetBrains.ReSharper.Features.Web.StructuralSearch.Html.UI.HtmlAttributeSequencePlaceholderEditForm>
    {
        public HtmlAttributeSequencePlaceholderEditor(JetBrains.UI.Application.IUIApplication environment, JetBrains.Application.Interop.NativeHook.IWindowsHookManager hookManager, JetBrains.CommonControls.Validation.FormValidators formValidators) { }
        public override string Name { get; }
        protected override JetBrains.ReSharper.Features.Web.StructuralSearch.Html.UI.HtmlAttributeSequencePlaceholderEditForm CreateEditor(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Psi.Services.Html.StructuralSearch.Placeholders.HtmlAttributeSequencePlaceholder placeholder, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder> placeholders, System.Windows.Forms.IWin32Window mainwin) { }
        public override JetBrains.UI.Icons.IconId GetImage() { }
    }
    [JetBrains.ReSharper.Features.StructuralSearch.Placeholders.PlaceholderEditorAttribute(typeof(JetBrains.ReSharper.Psi.Html.HtmlLanguage))]
    public class HtmlAttributeValuePlaceholderEditor : JetBrains.ReSharper.Features.StructuralSearch.Placeholders.PlaceholderEditorBase<JetBrains.ReSharper.Psi.Services.Html.StructuralSearch.Placeholders.HtmlAttributeValuePlaceholder, JetBrains.ReSharper.Features.Web.StructuralSearch.Html.UI.HtmlAttributeValuePlaceholderEditForm>
    {
        public HtmlAttributeValuePlaceholderEditor(JetBrains.UI.Application.IUIApplication environment, JetBrains.Application.Interop.NativeHook.IWindowsHookManager hookManager, JetBrains.CommonControls.Validation.FormValidators formValidators) { }
        public override string Name { get; }
        protected override JetBrains.ReSharper.Features.Web.StructuralSearch.Html.UI.HtmlAttributeValuePlaceholderEditForm CreateEditor(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Psi.Services.Html.StructuralSearch.Placeholders.HtmlAttributeValuePlaceholder placeholder, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder> placeholders, System.Windows.Forms.IWin32Window mainwin) { }
        public override JetBrains.UI.Icons.IconId GetImage() { }
    }
    [JetBrains.ReSharper.Features.StructuralSearch.Placeholders.PlaceholderEditorAttribute(typeof(JetBrains.ReSharper.Psi.Html.HtmlLanguage))]
    public class HtmlContentSequencePlaceholderEditor : JetBrains.ReSharper.Features.StructuralSearch.Placeholders.PlaceholderEditorBase<JetBrains.ReSharper.Psi.Services.Html.StructuralSearch.Placeholders.HtmlContentSequencePlaceholder, JetBrains.ReSharper.Features.Web.StructuralSearch.Html.UI.HtmlContentSequencePlaceholderEditForm>
    {
        public HtmlContentSequencePlaceholderEditor(JetBrains.UI.Application.IUIApplication environment, JetBrains.Application.Interop.NativeHook.IWindowsHookManager hookManager, JetBrains.CommonControls.Validation.FormValidators formValidators) { }
        public override string Name { get; }
        protected override JetBrains.ReSharper.Features.Web.StructuralSearch.Html.UI.HtmlContentSequencePlaceholderEditForm CreateEditor(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Psi.Services.Html.StructuralSearch.Placeholders.HtmlContentSequencePlaceholder placeholder, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder> placeholders, System.Windows.Forms.IWin32Window mainwin) { }
        public override JetBrains.UI.Icons.IconId GetImage() { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class HtmlPredefinedCustomPatterns : JetBrains.ReSharper.Features.StructuralSearch.IPredefinedCustomPatternsSource
    {
        public const string TagRegex = "^\\s*\\<\\/?[a-zA-Z]+.*?\\/?\\>";
        public HtmlPredefinedCustomPatterns(JetBrains.ReSharper.Psi.ILanguageManager languageManager) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Features.StructuralSearch.IPredefinedPattern> GetPatterns() { }
    }
    [JetBrains.ReSharper.Daemon.DaemonStageAttribute(StagesBefore=new System.Type[] {
            typeof(JetBrains.ReSharper.Daemon.LanguageSpecificDaemonStage)})]
    public class HtmlPredefinedPatternsStage : JetBrains.ReSharper.Daemon.IDaemonStage
    {
        public HtmlPredefinedPatternsStage(JetBrains.ReSharper.Features.StructuralSearch.PredefinedCustomPatternsManager patternsManager) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Daemon.IDaemonStageProcess> CreateProcess(JetBrains.ReSharper.Daemon.IDaemonProcess process, JetBrains.Application.Settings.IContextBoundSettingsStore settings, JetBrains.ReSharper.Daemon.DaemonProcessKind processKind) { }
        public JetBrains.ReSharper.Daemon.ErrorStripeRequest NeedsErrorStripe(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.Application.Settings.IContextBoundSettingsStore settings) { }
    }
    public class HtmlPredefinedPatternsStageProcess : JetBrains.ReSharper.Features.Web.StructuralSearch.Html.HtmlStructuralSearchDaemonStageProcess
    {
        public HtmlPredefinedPatternsStageProcess(JetBrains.ReSharper.Daemon.IDaemonProcess process, JetBrains.Application.Settings.IContextBoundSettingsStore settingsStore, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<JetBrains.ReSharper.Features.StructuralSearch.ICustomPattern, JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralMatcher>> matchers, JetBrains.ReSharper.Psi.Html.Tree.IHtmlFile file) { }
        protected override JetBrains.ReSharper.Daemon.IHighlighting CreateHighlighting(JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralMatchResult result, System.Collections.Generic.KeyValuePair<JetBrains.ReSharper.Features.StructuralSearch.ICustomPattern, JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralMatcher> pair) { }
    }
    [JetBrains.ReSharper.Daemon.DaemonStageAttribute(StagesBefore=new System.Type[] {
            typeof(JetBrains.ReSharper.Daemon.LanguageSpecificDaemonStage)})]
    public class HtmlStructuralSearchDaemonStage : JetBrains.ReSharper.Daemon.Html.Stages.HtmlDaemonStageBase<JetBrains.ReSharper.Psi.Html.Tree.IHtmlFile, JetBrains.ReSharper.Psi.Html.HtmlLanguage>
    {
        public HtmlStructuralSearchDaemonStage(JetBrains.ReSharper.Features.StructuralSearch.CustomPatternMatcherManager customPatternMatcherManager) { }
        protected override JetBrains.ReSharper.Daemon.IDaemonStageProcess CreateProcessInternal(JetBrains.ReSharper.Psi.Html.Tree.IHtmlFile file, JetBrains.ReSharper.Daemon.IDaemonProcess process, JetBrains.Application.Settings.IContextBoundSettingsStore settingsStore) { }
    }
    public class HtmlStructuralSearchDaemonStageProcess : JetBrains.ReSharper.Features.StructuralSearch.StructuralSearchDaemonStageProcessBase
    {
        public HtmlStructuralSearchDaemonStageProcess(JetBrains.ReSharper.Daemon.IDaemonProcess process, JetBrains.Application.Settings.IContextBoundSettingsStore settingsStore, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<JetBrains.ReSharper.Features.StructuralSearch.ICustomPattern, JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralMatcher>> matchers, JetBrains.ReSharper.Psi.Html.Tree.IHtmlFile file) { }
        public override bool InteriorShouldBeProcessed(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext context) { }
        public override void ProcessBeforeInterior(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext context) { }
    }
    [JetBrains.ReSharper.Features.StructuralSearch.Placeholders.PlaceholderEditorAttribute(typeof(JetBrains.ReSharper.Psi.Html.HtmlLanguage))]
    public class HtmlTagPlaceholderEditor : JetBrains.ReSharper.Features.StructuralSearch.Placeholders.PlaceholderEditorBase<JetBrains.ReSharper.Psi.Services.Html.StructuralSearch.Placeholders.HtmlTagPlaceholder, JetBrains.ReSharper.Features.Web.StructuralSearch.Html.UI.HtmlTagPlaceholderEditForm>
    {
        public HtmlTagPlaceholderEditor(JetBrains.UI.Application.IUIApplication environment, JetBrains.Application.Interop.NativeHook.IWindowsHookManager hookManager, JetBrains.CommonControls.Validation.FormValidators formValidators) { }
        public override string Name { get; }
        protected override JetBrains.ReSharper.Features.Web.StructuralSearch.Html.UI.HtmlTagPlaceholderEditForm CreateEditor(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Psi.Services.Html.StructuralSearch.Placeholders.HtmlTagPlaceholder placeholder, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder> placeholders, System.Windows.Forms.IWin32Window mainwin) { }
        public override JetBrains.UI.Icons.IconId GetImage() { }
    }
}
namespace JetBrains.ReSharper.Features.Web.StructuralSearch.Html.UI
{
    
    public abstract class BasePlaceholderEditForm<TPlaceholder> : JetBrains.UI.CommonControls.Controls.FormOwnedByMainWindow, JetBrains.ReSharper.Features.StructuralSearch.Placeholders.IPlaceholderEditorForm
        where TPlaceholder : JetBrains.ReSharper.Psi.Services.StructuralSearch.Impl.PlaceholderBase, new ()
    {
        protected BasePlaceholderEditForm(JetBrains.UI.Application.IUIApplication environment, JetBrains.Application.Interop.NativeHook.IWindowsHookManager hookManager, JetBrains.CommonControls.Validation.FormValidators formValidators, JetBrains.ProjectModel.ISolution solution, TPlaceholder placeholder, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder> placeholders, System.Windows.Forms.IWin32Window mainwin) { }
        public JetBrains.UI.Application.IUIApplication Environment { get; }
        protected JetBrains.CommonControls.Validation.IFormValidator FormValidator { get; }
        protected JetBrains.Application.Interop.NativeHook.IWindowsHookManager HookManager { get; }
        protected JetBrains.DataFlow.LifetimeDefinition LifetimeDefinition { get; }
        protected TPlaceholder Placeholder { get; set; }
        protected JetBrains.ProjectModel.ISolution Solution { get; }
        public event System.EventHandler OkClick;
        protected virtual void CreatePlaceholder() { }
        protected override void Dispose(bool disposing) { }
        protected virtual void InitForm() { }
        public void Initialize() { }
        protected virtual int InitializeAdditionalComponents(int i) { }
        protected void InitializeComponent() { }
        protected override void OnLoad(System.EventArgs e) { }
        protected void OnOkClick() { }
        protected virtual void SaveToPlaceholder() { }
    }
    public class BaseSequencePlaceholderEditForm<TPlaceholder> : JetBrains.ReSharper.Features.Web.StructuralSearch.Html.UI.BasePlaceholderEditForm<TPlaceholder>
        where TPlaceholder : JetBrains.ReSharper.Psi.Services.StructuralSearch.Impl.SequencePlaceholderBase, new ()
    {
        protected BaseSequencePlaceholderEditForm(JetBrains.UI.Application.IUIApplication environment, JetBrains.Application.Interop.NativeHook.IWindowsHookManager hookManager, JetBrains.CommonControls.Validation.FormValidators formValidators, JetBrains.ProjectModel.ISolution solution, TPlaceholder placeholder, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder> placeholders, System.Windows.Forms.IWin32Window mainwin) { }
        protected override void InitForm() { }
        protected override int InitializeAdditionalComponents(int yPos) { }
        protected override void SaveToPlaceholder() { }
    }
    public class CssSelectorValidator : JetBrains.CommonControls.Validation.ControlValidator
    {
        public CssSelectorValidator([JetBrains.Annotations.NotNullAttribute()] System.Windows.Forms.Control control, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Interop.NativeHook.IWindowsHookManager windowsHookManager, JetBrains.UI.Application.IUIApplication environment) { }
        public override void Update() { }
    }
    public class HtmlAttributeSequencePlaceholderEditForm : JetBrains.ReSharper.Features.Web.StructuralSearch.Html.UI.BaseSequencePlaceholderEditForm<JetBrains.ReSharper.Psi.Services.Html.StructuralSearch.Placeholders.HtmlAttributeSequencePlaceholder>
    {
        public HtmlAttributeSequencePlaceholderEditForm(JetBrains.UI.Application.IUIApplication environment, JetBrains.Application.Interop.NativeHook.IWindowsHookManager hookManager, JetBrains.CommonControls.Validation.FormValidators formValidators, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Psi.Services.Html.StructuralSearch.Placeholders.HtmlAttributeSequencePlaceholder placeholder, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder> placeholders, System.Windows.Forms.IWin32Window mainwin) { }
        protected override void InitForm() { }
        protected override int InitializeAdditionalComponents(int yPos) { }
        protected override void SaveToPlaceholder() { }
    }
    public class HtmlAttributeValuePlaceholderEditForm : JetBrains.ReSharper.Features.Web.StructuralSearch.Html.UI.BasePlaceholderEditForm<JetBrains.ReSharper.Psi.Services.Html.StructuralSearch.Placeholders.HtmlAttributeValuePlaceholder>
    {
        public HtmlAttributeValuePlaceholderEditForm(JetBrains.UI.Application.IUIApplication environment, JetBrains.Application.Interop.NativeHook.IWindowsHookManager hookManager, JetBrains.CommonControls.Validation.FormValidators formValidators, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Psi.Services.Html.StructuralSearch.Placeholders.HtmlAttributeValuePlaceholder placeholder, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder> placeholders, System.Windows.Forms.IWin32Window mainwin) { }
        protected override void InitForm() { }
        protected override int InitializeAdditionalComponents(int yPos) { }
        protected override void SaveToPlaceholder() { }
    }
    public class HtmlContentSequencePlaceholderEditForm : JetBrains.ReSharper.Features.Web.StructuralSearch.Html.UI.BaseSequencePlaceholderEditForm<JetBrains.ReSharper.Psi.Services.Html.StructuralSearch.Placeholders.HtmlContentSequencePlaceholder>
    {
        public HtmlContentSequencePlaceholderEditForm(JetBrains.UI.Application.IUIApplication environment, JetBrains.CommonControls.Validation.FormValidators formValidators, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Psi.Services.Html.StructuralSearch.Placeholders.HtmlContentSequencePlaceholder placeholder, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder> placeholders, System.Windows.Forms.IWin32Window mainwin, JetBrains.Application.Interop.NativeHook.IWindowsHookManager hookManager) { }
        protected override void InitForm() { }
        protected override int InitializeAdditionalComponents(int yPos) { }
        protected override void SaveToPlaceholder() { }
    }
    public class HtmlTagPlaceholderEditForm : JetBrains.ReSharper.Features.Web.StructuralSearch.Html.UI.BasePlaceholderEditForm<JetBrains.ReSharper.Psi.Services.Html.StructuralSearch.Placeholders.HtmlTagPlaceholder>
    {
        public HtmlTagPlaceholderEditForm(JetBrains.UI.Application.IUIApplication environment, JetBrains.Application.Interop.NativeHook.IWindowsHookManager hookManager, JetBrains.CommonControls.Validation.FormValidators formValidators, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Psi.Services.Html.StructuralSearch.Placeholders.HtmlTagPlaceholder placeholder, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder> placeholders, System.Windows.Forms.IWin32Window mainwin) { }
        protected override void InitForm() { }
        protected override int InitializeAdditionalComponents(int yPos) { }
        protected override void SaveToPlaceholder() { }
    }
    public class RegexValidator : JetBrains.CommonControls.Validation.ControlValidator
    {
        public RegexValidator(System.Windows.Forms.Control control, JetBrains.Application.Interop.NativeHook.IWindowsHookManager hookManager, JetBrains.ProjectModel.ISolution solution, JetBrains.UI.Application.IUIApplication environment) { }
        public override void Update() { }
    }
}