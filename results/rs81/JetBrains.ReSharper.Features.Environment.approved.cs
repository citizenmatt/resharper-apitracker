[assembly: JetBrains.ActionManagement.ActionsXmlAttribute("JetBrains.ReSharper.Features.Environment.resources.Actions.xml")]
[assembly: JetBrains.UI.Icons.CompiledIcons.CompiledIconsPackAttribute(IconNames=new string[] {
        "Tip",
        "CacheNotifierGlyph",
        "NAEnvironment",
        "AddFile"}, IconPackResourceIdentification="JetBrains.ReSharper.Features.Environment;component/resources/FeaturesEnvironmentT" +
    "hemedIcons/ThemedIcons.FeaturesEnvironment.Generated.Xaml")]
[assembly: JetBrains.UI.Icons.CompiledIcons.CompiledIconsPackAttribute(IconNames=new string[] {
        "SkipItemsEditMask",
        "SkipItemsAddMask",
        "SkipItemsRemoveMask"}, IconPackResourceIdentification="JetBrains.ReSharper.Features.Environment;component/src/Options/Inspections/SkipIt" +
    "emsDialogThemedIcons/ThemedIcons.SkipItemsDialog.Generated.Xaml")]
[assembly: JetBrains.UI.Icons.CompiledIcons.CompiledIconsPackAttribute(IconNames=new string[] {
        "StringFormat",
        "CodeStyle",
        "Persistence",
        "GeneratedCode",
        "ValueAnalysis",
        "Highlighting",
        "CodeInspections",
        "BracesLayout",
        "Quickfixes",
        "UsingDirectives",
        "GlobalAnalysis",
        "EnvironmentGeneral",
        "NamingConvention",
        "TypeMembersLayout"}, IconPackResourceIdentification="JetBrains.ReSharper.Features.Environment;component/src/Options/FeaturesEnvironmen" +
    "tOptionsIcons/ThemedIcons.FeaturesEnvironmentOptions.Generated.Xaml")]
[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]
[assembly: System.Windows.Markup.XmlnsDefinitionAttribute("urn:shemas-jetbrains-com:ui-application-icons-features-environment-options", "JetBrains.ReSharper.Features.Environment.Src.Options")]
[assembly: System.Windows.Markup.XmlnsDefinitionAttribute("urn:shemas-jetbrains-com:ui-application-icons-skip-items-dialog", "JetBrains.ReSharper.Features.Environment.Src.Options.Inspections")]
[assembly: System.Windows.Markup.XmlnsDefinitionAttribute("urn:shemas-jetbrains-com:ui-application-icons-features-environment", "JetBrains.ReSharper.Features.Environment.Resources")]

namespace JetBrains.ReSharper.Features.Environment.Actions
{
    
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "Synchronize"})]
    public class SynchronizeAction : JetBrains.ActionManagement.IActionHandler
    {
        public void Execute(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.DelegateExecute nextExecute) { }
        public bool Update(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.ActionPresentation presentation, JetBrains.ActionManagement.DelegateUpdate nextUpdate) { }
    }
}
namespace JetBrains.ReSharper.Features.Environment.Navigation
{
    
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "NavigateBackward",
            "NavigateBackwardApp"})]
    public class NavigateBackwardAction : JetBrains.ActionManagement.IActionHandler
    {
        public void Execute(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.DelegateExecute nextExecute) { }
        public bool Update(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.ActionPresentation presentation, JetBrains.ActionManagement.DelegateUpdate nextUpdate) { }
    }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "NavigateForward",
            "NavigateForwardApp"})]
    public class NavigateForwardAction : JetBrains.ActionManagement.IActionHandler
    {
        public void Execute(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.DelegateExecute nextExecute) { }
        public bool Update(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.ActionPresentation presentation, JetBrains.ActionManagement.DelegateUpdate nextUpdate) { }
    }
}
namespace JetBrains.ReSharper.Features.Environment.Options.CodeStyle
{
    
    public class CodeStyleCategoryNew
    {
        public CodeStyleCategoryNew([JetBrains.Annotations.NotNullAttribute()] string name, [JetBrains.Annotations.NotNullAttribute()] params JetBrains.ReSharper.Features.Environment.Options.CodeStyle.CodeStyleItemNew[] items) { }
        public JetBrains.ReSharper.Features.Environment.Options.CodeStyle.CodeStyleItemNew[] Items { get; }
        public string Name { get; }
    }
    public class CodeStyleDefNew
    {
        public CodeStyleDefNew([JetBrains.Annotations.NotNullAttribute()] params JetBrains.ReSharper.Features.Environment.Options.CodeStyle.CodeStyleCategoryNew[] categories) { }
        public JetBrains.ReSharper.Features.Environment.Options.CodeStyle.CodeStyleCategoryNew[] Categories { get; }
    }
    public class CodeStyleItemNew
    {
        public const string ModifiersOrderControlType = "ModifiersOrderControlType";
        public CodeStyleItemNew([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.SettingsScalarEntry settingsEntry, [JetBrains.Annotations.NotNullAttribute()] string previewCode, JetBrains.ReSharper.OptionPages.CodeStyle.Impl.PreviewParseType parseType = 3, JetBrains.ReSharper.OptionPages.CodeStyle.Impl.PreviewType previewType = 1, [JetBrains.Annotations.CanBeNullAttribute()] System.Action<JetBrains.Application.Settings.IContextBoundSettingsStore> fixupAction = null, string controlType = null) { }
        public CodeStyleItemNew([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.SettingsScalarEntry settingsEntry, JetBrains.ReSharper.OptionPages.CodeStyle.Impl.PreviewType previewType, JetBrains.ReSharper.OptionPages.CodeStyle.Impl.PreviewParseType parseType, [JetBrains.Annotations.NotNullAttribute()] string previewCode, [JetBrains.Annotations.CanBeNullAttribute()] System.Action<JetBrains.Application.Settings.IContextBoundSettingsStore> fixupAction = null, string controlType = null) { }
        public string ControlType { get; }
        public JetBrains.ReSharper.OptionPages.CodeStyle.Impl.PreviewParseType ParseType { get; }
        public string PreviewCode { get; }
        public System.Action<JetBrains.Application.Settings.IContextBoundSettingsStore> PreviewFixupAction { get; }
        public JetBrains.ReSharper.OptionPages.CodeStyle.Impl.PreviewType PreviewType { get; }
        public JetBrains.Application.Settings.SettingsScalarEntry SettingsEntry { get; }
    }
    [JetBrains.UI.Options.OptionsPageAttribute("CommonFormatter", "General Formatter Style", typeof(JetBrains.ReSharper.Features.Environment.Src.Options.FeaturesEnvironmentOptionsThemedIcons.CodeStyle), HelpKeyword="Reference__Options__General_Formatter_Style", Internal=false, ParentId="CodeEditing", Sequence=1.5D)]
    public class CommonFormatterPage : JetBrains.UI.Options.Helpers.AStackPanelOptionsPage3
    {
        public const string PID = "CommonFormatter";
        public CommonFormatterPage(JetBrains.DataFlow.Lifetime lifetime, JetBrains.UI.Application.IUIApplication environment, JetBrains.UI.Options.OptionsSettingsSmartContext context) { }
    }
    public class static NamespaceImportsPageBase
    {
        public static readonly JetBrains.DataFlow.PropertyId<JetBrains.DataFlow.IProperty<bool>> AddImportsToDeepestScope;
        public static readonly JetBrains.DataFlow.PropertyId<JetBrains.DataFlow.IProperty<bool>> AllowAlias;
        public static readonly JetBrains.DataFlow.PropertyId<JetBrains.DataFlow.IProperty<bool>> CanUseGlobalAlias;
        public static readonly JetBrains.DataFlow.PropertyId<string> ImportDirectiveName;
        public static readonly JetBrains.DataFlow.PropertyId<JetBrains.DataFlow.IProperty<string[]>> KeepImports;
        public static readonly JetBrains.DataFlow.PropertyId<JetBrains.DataFlow.IProperty<bool>> KeepNontrivialAlias;
        public static readonly JetBrains.DataFlow.PropertyId<JetBrains.DataFlow.IProperty<string[]>> MandatoryImports;
        public static readonly JetBrains.DataFlow.PropertyId<JetBrains.DataFlow.IProperty<bool>> PreferQualifiedReference;
        public static readonly JetBrains.DataFlow.PropertyId<JetBrains.DataFlow.IProperty<bool>> QualifiedUsingAtNestedScope;
        public static System.Collections.Generic.List<JetBrains.DataFlow.IPropertyBinding> CreateView(JetBrains.UI.Application.IUIApplication environment, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.PropertyBag settings, [JetBrains.Annotations.NotNullAttribute()] System.Windows.Forms.TableLayoutPanel grid, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.PsiIconManager psiIconManager, JetBrains.UI.Application.UIApplication uiApplication, JetBrains.Application.Interop.NativeHook.IWindowsHookManager windowsHookManager, JetBrains.CommonControls.Validation.FormValidators formValidators) { }
        public static void Set<T>(this JetBrains.DataFlow.PropertyBag bag, JetBrains.DataFlow.PropertyId<JetBrains.DataFlow.IProperty<T>> propertyId, T initialValue, System.Action<T> setter) { }
    }
}
namespace JetBrains.ReSharper.Features.Environment.Options.CodeStyle.CSharp
{
    
    [JetBrains.Application.ShellComponentAttribute()]
    public class BlankLinesPagePageScheme
    {
        public BlankLinesPagePageScheme(JetBrains.Application.Settings.ISettingsStore settingsStore) { }
        public JetBrains.ReSharper.Features.Environment.Options.CodeStyle.CodeStyleDefNew CodeStyleDef { get; }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class BracesPageScheme
    {
        public BracesPageScheme(JetBrains.Application.Settings.ISettingsStore settingsStore) { }
        public JetBrains.ReSharper.Features.Environment.Options.CodeStyle.CodeStyleDefNew CodeStyleDef { get; }
    }
    [JetBrains.UI.Options.OptionsPageAttribute("CsharpCodeStyle", "Formatting Style", typeof(JetBrains.ReSharper.Features.Environment.Src.Options.FeaturesEnvironmentOptionsThemedIcons.CodeStyle), HelpKeyword="Reference__Options__Languages__CSharp__Formatting_Style", ParentId="Csharp", Sequence=1D, SupportedEditions=new string[] {
            "Csharp"})]
    public class CSharpCodeStylePage : JetBrains.UI.Options.IOptionsPage
    {
        public const string PID = "CsharpCodeStyle";
        public JetBrains.UI.CrossFramework.EitherControl Control { get; }
        public string Id { get; }
        public bool OnOk() { }
        public bool ValidatePage() { }
    }
    [JetBrains.UI.Options.OptionsPageAttribute("CsharpMemberOrder", "Type Members Layout", typeof(JetBrains.ReSharper.Features.Environment.Src.Options.FeaturesEnvironmentOptionsThemedIcons.TypeMembersLayout), HelpKeyword="Reference__Options__Languages__CSharp__Type_Members_Layout", ParentId="Csharp", Sequence=2D, SupportedEditions=new string[] {
            "Csharp"})]
    public class CsharpMemberOrderPage : JetBrains.UI.CommonControls.SafeUserControl, JetBrains.UI.Options.IOptionsPage
    {
        public const string PID = "CsharpMemberOrder";
        public CsharpMemberOrderPage(JetBrains.DataFlow.Lifetime lifetime, JetBrains.UI.Options.OptionsSettingsSmartContext smartContext, JetBrains.Threading.IThreading threading, JetBrains.UI.Application.IUIApplication environment) { }
        public JetBrains.UI.CrossFramework.EitherControl Control { get; }
        public string Id { get; }
        protected override void Dispose(bool disposing) { }
        public bool OnOk() { }
        public bool ValidatePage() { }
    }
    [JetBrains.UI.Options.OptionsPageAttribute("CsharpNamespaceImports", "Namespace Imports", typeof(JetBrains.ReSharper.Features.Environment.Src.Options.FeaturesEnvironmentOptionsThemedIcons.UsingDirectives), HelpKeyword="Reference__Options__Languages__CSharp__Namespace_Imports", ParentId="Csharp", Sequence=3D, SupportedEditions=new string[] {
            "Csharp"})]
    public class CsharpNamespaceImportsPage : JetBrains.UI.CommonControls.SafeTableLayoutPanel, JetBrains.UI.Options.IOptionsPage
    {
        public const string PID = "CsharpNamespaceImports";
        public CsharpNamespaceImportsPage([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, JetBrains.UI.Application.IUIApplication environment, JetBrains.UI.Options.OptionsSettingsSmartContext smartContext, JetBrains.ReSharper.Psi.PsiIconManager psiIconManager, JetBrains.UI.Application.UIApplication uiApplication, JetBrains.Application.IApplicationDescriptor applicationDescriptor, JetBrains.Application.Interop.NativeHook.IWindowsHookManager windowsHookManager, JetBrains.CommonControls.Validation.FormValidators formValidators, JetBrains.Threading.IThreading threading, JetBrains.UI.Icons.IThemedIconManager uiIconsComponent) { }
        public JetBrains.UI.CrossFramework.EitherControl Control { get; }
        public string Id { get; }
        public bool OnOk() { }
        public bool ValidatePage() { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class LineBreaksPageScheme
    {
        public LineBreaksPageScheme(JetBrains.Application.Settings.ISettingsStore settingsStore) { }
        public JetBrains.ReSharper.Features.Environment.Options.CodeStyle.CodeStyleDefNew CodeStyleDef { get; }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class OthersPageScheme
    {
        public OthersPageScheme(JetBrains.Application.Settings.ISettingsStore settingsStore) { }
        public JetBrains.ReSharper.Features.Environment.Options.CodeStyle.CodeStyleDefNew CodeStyleDef { get; }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class SpacesPageScheme
    {
        public SpacesPageScheme(JetBrains.Application.Settings.ISettingsStore settingsStore) { }
        public JetBrains.ReSharper.Features.Environment.Options.CodeStyle.CodeStyleDefNew CodeStyleDef { get; }
    }
}
namespace JetBrains.ReSharper.Features.Environment.Options.CodeStyle.Impl
{
    
    public abstract class CodeStylePageWithPreviewOnSettingsKey : JetBrains.UI.CommonControls.SafeUserControl, JetBrains.UI.Options.IOptionsPage
    {
        protected CodeStylePageWithPreviewOnSettingsKey(JetBrains.Application.Components.IComponentContainer container, JetBrains.DataFlow.Lifetime lifetime, JetBrains.UI.Application.IUIApplication environment, JetBrains.UI.Options.OptionsSettingsSmartContext smartContext, JetBrains.UI.WindowManagement.WindowFrame windowFrame, JetBrains.ReSharper.Features.Environment.Options.CodeStyle.Impl.CodeStyleTreeLoader settingsTreeLoader, JetBrains.TextControl.DocumentMarkup.IDocumentMarkupManager documentMarkupManager, JetBrains.ReSharper.Features.Environment.Options.CodeStyle.CodeStyleDefNew codeStyleDef, JetBrains.ReSharper.Features.Common.Options.FakeSolutionProvider fakeSolutionProvider, JetBrains.ProjectModel.FileTypes.IProjectFileTypeServices projectFileTypeServices, JetBrains.ProjectModel.ISolution solution = null) { }
        protected JetBrains.ReSharper.Features.Environment.Options.CodeStyle.CodeStyleDefNew CodeStyleDef { get; }
        public JetBrains.UI.CrossFramework.EitherControl Control { get; }
        public new JetBrains.UI.Application.IUIApplication Environment { get; }
        public abstract string Id { get; }
        protected virtual bool LanguageEnabled { get; }
        protected virtual string LanguageName { get; }
        public JetBrains.ReSharper.Features.Environment.Options.CodeStyle.Impl.CodeStyleTreeLoader SettingsTreeLoader { get; }
        protected abstract JetBrains.ReSharper.OptionPages.CodeStyle.Impl.CodeStylePreview CreateCodeStylePreview(JetBrains.TextControl.DocumentMarkup.IDocumentMarkupManager documentMarkupManager, JetBrains.UI.WindowManagement.WindowFrame windowFrame, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ISolution solution, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.FileTypes.IProjectFileTypeServices projectFileTypeServices);
        protected void ItemChangedHandler(JetBrains.ReSharper.Features.Environment.Options.CodeStyle.Impl.EditItems.CodeStyleEditItem item) { }
        protected override void OnCreateControl() { }
        public bool OnOk() { }
        public bool ValidatePage() { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class CodeStyleTreeLoader
    {
        public CodeStyleTreeLoader(JetBrains.Application.Settings.ISettingsStore settingsStore) { }
        public JetBrains.Application.Settings.ISettingsStore SettingsStore { get; }
        public JetBrains.ReSharper.Features.Environment.Options.CodeStyle.Impl.EditItems.CodeStyleEditItem[] LoadTree(JetBrains.ReSharper.Features.Environment.Options.CodeStyle.CodeStyleDefNew element, System.Action<JetBrains.ReSharper.Features.Environment.Options.CodeStyle.Impl.EditItems.CodeStyleEditItem> handler, JetBrains.UI.Options.OptionsSettingsSmartContext smartContext) { }
    }
}
namespace JetBrains.ReSharper.Features.Environment.Options.CodeStyle.Impl.EditItems
{
    
    public abstract class CodeStyleEditItem
    {
        protected CodeStyleEditItem(string category, int id) { }
        protected CodeStyleEditItem(int id, int parent, JetBrains.ReSharper.Features.Environment.Options.CodeStyle.CodeStyleItemNew codeStyleItem, System.Action<JetBrains.ReSharper.Features.Environment.Options.CodeStyle.Impl.EditItems.CodeStyleEditItem> handler, JetBrains.UI.Options.OptionsSettingsSmartContext smartContext) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Features.Environment.Options.CodeStyle.CodeStyleItemNew CodeStyleItem { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        protected System.Action<JetBrains.ReSharper.Features.Environment.Options.CodeStyle.Impl.EditItems.CodeStyleEditItem> Handler { get; }
        public int ID { get; }
        [JetBrains.Annotations.UsedImplicitlyAttribute()]
        public string Name { get; }
        public int ParentID { get; }
        public JetBrains.ReSharper.OptionPages.CodeStyle.Impl.CodeStylePreviewData Preview { get; }
        public abstract DevExpress.XtraEditors.Repository.RepositoryItem RepositoryItem { get; }
        [JetBrains.Annotations.UsedImplicitlyAttribute()]
        public virtual object Value { get; set; }
        public void FixupSettingsForPreview(JetBrains.Application.Settings.IContextBoundSettingsStore settingsStore) { }
    }
}
namespace JetBrains.ReSharper.Features.Environment.Options.CodeStyle.VB.Pages
{
    
    [JetBrains.Application.ShellComponentAttribute()]
    public class BlankLinesPageScheme
    {
        public BlankLinesPageScheme(JetBrains.Application.Settings.ISettingsStore settingsStore) { }
        public JetBrains.ReSharper.Features.Environment.Options.CodeStyle.CodeStyleDefNew CodeStyleDef { get; }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class LineBreaksPageScheme
    {
        public LineBreaksPageScheme(JetBrains.Application.Settings.ISettingsStore settingsStore) { }
        public JetBrains.ReSharper.Features.Environment.Options.CodeStyle.CodeStyleDefNew CodeStyleDef { get; }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class OthersPagePageScheme
    {
        public OthersPagePageScheme(JetBrains.Application.Settings.ISettingsStore settingsStore) { }
        public JetBrains.ReSharper.Features.Environment.Options.CodeStyle.CodeStyleDefNew CodeStyleDef { get; }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class SpacesPageScheme
    {
        public SpacesPageScheme(JetBrains.Application.Settings.ISettingsStore settingsStore) { }
        public JetBrains.ReSharper.Features.Environment.Options.CodeStyle.CodeStyleDefNew CodeStyleDef { get; }
    }
    [JetBrains.UI.Options.OptionsPageAttribute("VBAnalysis", "Inspections", typeof(JetBrains.ReSharper.Features.Environment.Src.Options.FeaturesEnvironmentOptionsThemedIcons.CodeInspections), HelpKeyword="Reference__Options__Languages__Visual_Basic__NET__Inspections", ParentId="Vbnet", Sequence=0.5D, SupportedEditions=new string[] {
            "Vbnet"})]
    public class VBAnalysisPage : JetBrains.UI.Options.Helpers.AStackPanelOptionsPage3
    {
        public const string PID = "VBAnalysis";
        public readonly JetBrains.DataFlow.Property<bool> UseReSharperAnalysis;
        public VBAnalysisPage(JetBrains.DataFlow.Lifetime lifetime, JetBrains.UI.Application.IUIApplication environment, JetBrains.UI.Options.OptionsSettingsSmartContext context) { }
    }
}
namespace JetBrains.ReSharper.Features.Environment.Options.CodeStyle.VB
{
    
    [JetBrains.UI.Options.OptionsPageAttribute("VbnetCodeStyle", "Formatting Style", typeof(JetBrains.ReSharper.Features.Environment.Src.Options.FeaturesEnvironmentOptionsThemedIcons.CodeStyle), HelpKeyword="Reference__Options__Languages__Visual_Basic__NET__Formatting_Style", ParentId="Vbnet", Sequence=1D, SupportedEditions=new string[] {
            "Vbnet"})]
    public class VBCodeStylePage : JetBrains.UI.Options.IOptionsPage
    {
        public const string PID = "VbnetCodeStyle";
        public JetBrains.UI.CrossFramework.EitherControl Control { get; }
        public string Id { get; }
        public bool OnOk() { }
        public bool ValidatePage() { }
    }
}
namespace JetBrains.ReSharper.Features.Environment.Options.CodeStyle.XML
{
    
    [JetBrains.UI.Options.OptionsPageAttribute("XmlCodeStyle", "Formatting Style", typeof(JetBrains.ReSharper.Features.Environment.Src.Options.FeaturesEnvironmentOptionsThemedIcons.CodeStyle), HelpKeyword="Reference__Options__Languages__XML__Formatting_Style", ParentId="Xml", Sequence=1D)]
    public class XmlCodeStylePage : JetBrains.ReSharper.Features.Environment.Options.CodeStyle.Impl.CodeStylePageWithPreviewOnSettingsKey
    {
        public const string PID = "XmlCodeStyle";
        public XmlCodeStylePage(JetBrains.Application.Components.IComponentContainer container, JetBrains.DataFlow.Lifetime lifetime, JetBrains.UI.Application.IUIApplication environment, JetBrains.UI.Options.OptionsSettingsSmartContext smartContext, JetBrains.UI.WindowManagement.WindowFrame windowFrame, JetBrains.ReSharper.Features.Environment.Options.CodeStyle.XML.XmlCodeStylePageScheme scheme, JetBrains.TextControl.DocumentMarkup.IDocumentMarkupManager documentMarkupManager, JetBrains.Application.IShellLocks shellLocks, JetBrains.UI.CommonControls.Fonts.FontsManager fontsManager, JetBrains.ReSharper.Features.Environment.Options.CodeStyle.Impl.CodeStyleTreeLoader settingsTreeLoader, JetBrains.ReSharper.Features.Common.Options.FakeSolutionProvider fakeSolutionProvider, JetBrains.ProjectModel.FileTypes.IProjectFileTypeServices projectFileTypeServices, JetBrains.ProjectModel.ISolution solution = null) { }
        public override string Id { get; }
        protected override JetBrains.ReSharper.OptionPages.CodeStyle.Impl.CodeStylePreview CreateCodeStylePreview(JetBrains.TextControl.DocumentMarkup.IDocumentMarkupManager documentMarkupManager, JetBrains.UI.WindowManagement.WindowFrame windowFrame, JetBrains.ProjectModel.ISolution solution, JetBrains.ProjectModel.FileTypes.IProjectFileTypeServices projectFileTypeServices) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class XmlCodeStylePageScheme : JetBrains.ReSharper.Features.Environment.Options.CodeStyle.XML.XmlCodeStylePageSchemeBase<JetBrains.ReSharper.Psi.Xml.CodeStyle.XmlFormatterSettingsKey>
    {
        public XmlCodeStylePageScheme(JetBrains.Application.Settings.ISettingsStore settingsStore) { }
    }
    public class XmlCodeStylePageSchemeBase<TKey>
        where TKey : JetBrains.ReSharper.Psi.Xml.CodeStyle.XmlFormatterSettingsKey
    {
        protected static readonly string NL;
        public XmlCodeStylePageSchemeBase(JetBrains.Application.Settings.ISettingsStore settingsStore) { }
        public JetBrains.ReSharper.Features.Environment.Options.CodeStyle.CodeStyleDefNew CodeStyleDef { get; }
        protected JetBrains.Application.Settings.ISettingsStore SettingsStore { get; set; }
        protected virtual System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Features.Environment.Options.CodeStyle.CodeStyleItemNew> GetAroundTagsSettings() { }
        protected virtual System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Features.Environment.Options.CodeStyle.CodeStyleItemNew> GetGeneralSettings() { }
        protected virtual System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Features.Environment.Options.CodeStyle.CodeStyleItemNew> GetProcessingInstructionSettings() { }
        protected virtual System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Features.Environment.Options.CodeStyle.CodeStyleCategoryNew> GetSettingSections() { }
        protected virtual System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Features.Environment.Options.CodeStyle.CodeStyleItemNew> GetTagContentSettings() { }
        protected virtual System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Features.Environment.Options.CodeStyle.CodeStyleItemNew> GetTagHeaderSettings() { }
        protected static void KeepMyLinebreaksFixup(JetBrains.Application.Settings.IContextBoundSettingsStore store) { }
        protected static void WrapLimitFixup(JetBrains.Application.Settings.IContextBoundSettingsStore store) { }
    }
    [JetBrains.UI.Options.OptionsPageAttribute("XmlDocCodeStyle", "Formatting Style", typeof(JetBrains.ReSharper.Features.Environment.Src.Options.FeaturesEnvironmentOptionsThemedIcons.CodeStyle), HelpKeyword="Reference__Options__XML_Doc_Comments_Formatting_Style", ParentId="XmlDoc", Sequence=1D)]
    public class XmlDocCodeStylePage : JetBrains.ReSharper.Features.Environment.Options.CodeStyle.Impl.CodeStylePageWithPreviewOnSettingsKey
    {
        public const string PID = "XmlDocCodeStyle";
        public XmlDocCodeStylePage(JetBrains.Application.Components.IComponentContainer container, JetBrains.DataFlow.Lifetime lifetime, JetBrains.UI.Application.IUIApplication environment, JetBrains.UI.Options.OptionsSettingsSmartContext smartContext, JetBrains.UI.WindowManagement.WindowFrame windowFrame, JetBrains.ReSharper.Features.Environment.Options.CodeStyle.XML.XmlDocCodeStylePageScheme scheme, JetBrains.TextControl.DocumentMarkup.IDocumentMarkupManager documentMarkupManager, JetBrains.ReSharper.Features.Environment.Options.CodeStyle.Impl.CodeStyleTreeLoader settingsTreeLoader, JetBrains.ReSharper.Features.Common.Options.FakeSolutionProvider fakeSolutionProvider, JetBrains.ProjectModel.FileTypes.IProjectFileTypeServices projectFileTypeServices, JetBrains.ProjectModel.ISolution solution = null) { }
        public override string Id { get; }
        protected override JetBrains.ReSharper.OptionPages.CodeStyle.Impl.CodeStylePreview CreateCodeStylePreview(JetBrains.TextControl.DocumentMarkup.IDocumentMarkupManager documentMarkupManager, JetBrains.UI.WindowManagement.WindowFrame windowFrame, JetBrains.ProjectModel.ISolution solution, JetBrains.ProjectModel.FileTypes.IProjectFileTypeServices projectFileTypeServices) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class XmlDocCodeStylePageScheme : JetBrains.ReSharper.Features.Environment.Options.CodeStyle.XML.XmlCodeStylePageSchemeBase<JetBrains.ReSharper.Psi.Xml.CodeStyle.XmlDocFormatterSettingsKey>
    {
        public XmlDocCodeStylePageScheme(JetBrains.Application.Settings.ISettingsStore settingsStore) { }
        protected override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Features.Environment.Options.CodeStyle.CodeStyleItemNew> GetAroundTagsSettings() { }
    }
}
namespace JetBrains.ReSharper.Features.Environment.Options
{
    
    [JetBrains.UI.Options.OptionsPageAttribute("EnvironmentGeneral", "General", typeof(JetBrains.ReSharper.Features.Environment.Src.Options.FeaturesEnvironmentOptionsThemedIcons.EnvironmentGeneral), HelpKeyword="Reference__Options__Environment__General", ParentId="Environment", Sequence=0D)]
    public class EnvironmentGeneralPage : JetBrains.UI.Options.Helpers.AOptionsPage
    {
        public EnvironmentGeneralPage(JetBrains.DataFlow.Lifetime lifetime, JetBrains.UI.Application.IUIApplication environment, JetBrains.Application.IApplicationDescriptor product, JetBrains.UI.Options.OptionsSettingsSmartContext ctx, JetBrains.UI.Application.Progress.UITaskExecutor executor, JetBrains.Application.Components.IComponentContainer ccFactory, JetBrains.ReSharper.Psi.IPsiConfiguration psiConfiguration = null, JetBrains.ProjectModel.ISolution solution = null) { }
    }
}
namespace JetBrains.ReSharper.Features.Environment.Options.Inspections
{
    
    [JetBrains.UI.Options.OptionsPageAttribute("CodeAnnotations", "Code Annotations", typeof(JetBrains.ReSharper.Features.Environment.Src.Options.FeaturesEnvironmentOptionsThemedIcons.ValueAnalysis), HelpKeyword="Reference__Options__Code_Inspection__Code_Annotations", ParentId="CodeInspection", Sequence=4D, SupportedEditions=new string[] {
            "Csharp"})]
    public class CodeAnnotationsPage : JetBrains.UI.CommonControls.SafeTableLayoutPanel, JetBrains.UI.Options.IOptionsPage
    {
        public const string PID = "CodeAnnotations";
        public CodeAnnotationsPage([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.UI.Options.OptionsSettingsSmartContext smartContext, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.IShellLocks shellLocks, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.PsiIconManager psiIconManager, [JetBrains.Annotations.NotNullAttribute()] JetBrains.UI.Application.IUIApplication environment, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Files.IPsiFiles psiFiles = null, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Caches.IPsiCaches psiCaches = null, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Caches.ISymbolCache symbolCache = null) { }
        public JetBrains.UI.CrossFramework.EitherControl Control { get; }
        public string Id { get; }
        public bool OnOk() { }
        public bool ValidatePage() { }
    }
    [JetBrains.UI.Options.OptionsPageAttribute("CodeInspectionGeneratedSettings", "Generated Code", typeof(JetBrains.ReSharper.Features.Environment.Src.Options.FeaturesEnvironmentOptionsThemedIcons.GeneratedCode), HelpKeyword="Reference__Options__Code_Inspection__Generated_Code", ParentId="CodeInspection", Sequence=1D)]
    public class CodeInspectionGeneratedPage : JetBrains.UI.Options.Helpers.AStackPanelOptionsPage
    {
        public const string PID = "CodeInspectionGeneratedSettings";
        public CodeInspectionGeneratedPage(JetBrains.UI.Application.IUIApplication environment, JetBrains.UI.Options.OptionsSettingsSmartContext smartContext, JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.IShellLocks shellLocks, JetBrains.Application.Interop.NativeHook.IWindowsHookManager windowsHookManager, JetBrains.CommonControls.Validation.FormValidators formValidators, JetBrains.UI.CommonControls.Fonts.FontsManager fontsManager, JetBrains.UI.Icons.IThemedIconManager uiIconsComponent, JetBrains.ProjectModel.ISolution solution = null, JetBrains.UI.Application.IMainWindow mainWindow = null) { }
        public override bool OnOk() { }
    }
    [JetBrains.UI.Options.OptionsPageAttribute("CodeInspection", "Code Inspection", null, HelpKeyword="Reference__Options__Code_Inspection", Sequence=1D)]
    public class CodeInspectionPage : JetBrains.UI.Options.Helpers.AEmptyOptionsPage
    {
        public const string PID = "CodeInspection";
        public CodeInspectionPage() { }
    }
    [JetBrains.UI.Options.OptionsPageAttribute("CodeInspectionSettings", "Settings", typeof(JetBrains.ReSharper.Features.Environment.Src.Options.FeaturesEnvironmentOptionsThemedIcons.CodeInspections), HelpKeyword="Reference__Options__Code_Inspection__Settings", ParentId="CodeInspection", Sequence=0D)]
    public class CodeInspectionSettingsPage : JetBrains.UI.Options.Helpers.AStackPanelOptionsPage
    {
        public const string PID = "CodeInspectionSettings";
        public CodeInspectionSettingsPage(JetBrains.DataFlow.Lifetime lifetime, JetBrains.UI.Application.IUIApplication environment, JetBrains.UI.Options.OptionsSettingsSmartContext optionsSettingsSmartContext, JetBrains.Application.Interop.NativeHook.IWindowsHookManager windowsHookManager, JetBrains.CommonControls.Validation.FormValidators formValidators, JetBrains.UI.Application.IMainWindow mainWindow = null, JetBrains.ProjectModel.ISolution solution = null, JetBrains.ReSharper.Daemon.Impl.SolutionAnalysisService solutionAnalysisService = null) { }
        protected override void Dispose(bool disposing) { }
        public override bool OnOk() { }
    }
    [JetBrains.UI.Options.OptionsPageAttribute("InspectionSeverity", "Inspection Severity", typeof(JetBrains.ReSharper.Features.Environment.Src.Options.FeaturesEnvironmentOptionsThemedIcons.Highlighting), HelpKeyword="Reference__Options__Code_Inspection__Inspection_Severity", ParentId="CodeInspection", Sequence=2D)]
    public class InspectionSeverityPage : System.Windows.Forms.Panel, JetBrains.UI.Options.IOptionsPage
    {
        public const string PID = "InspectionSeverity";
        public InspectionSeverityPage(JetBrains.ReSharper.Daemon.HighlightingSettingsManager highlightingSettingsManager, JetBrains.UI.Options.OptionsSettingsSmartContext optionsSettingsContext) { }
        public JetBrains.UI.CrossFramework.EitherControl Control { get; }
        public string Id { get; }
        public bool OnOk() { }
        public bool ValidatePage() { }
    }
    public class InspectionSeverityView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector
    {
        public static readonly System.Windows.DependencyProperty LanguageFilterProperty;
        public static readonly JetBrains.UI.Avalon.ValueConverter<JetBrains.ReSharper.Psi.PsiLanguageType, string> PsiLanguageToTextConverter;
        public InspectionSeverityView() { }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Features.Environment.Options.Inspections.SeverityGroupItem> Groups { set; }
        public JetBrains.UI.Controls.Misc.FilterController<JetBrains.ReSharper.Psi.PsiLanguageType> LanguageFilter { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Features.Environment.Options.Inspections.SeverityItem SelectedItem { get; }
        public event System.Action SelectionChanged;
        public void InitializeComponent() { }
    }
    public class SeverityGroupItem : JetBrains.UI.Avalon.TreeListView.ObservableObject
    {
        public SeverityGroupItem(string title, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Features.Environment.Options.Inspections.SeverityItem> children) { }
        public System.Collections.Generic.List<JetBrains.ReSharper.Features.Environment.Options.Inspections.SeverityItem> Children { get; set; }
        public string Title { get; set; }
    }
    public class SeverityItem : JetBrains.UI.Avalon.TreeListView.ObservableObject
    {
        public SeverityItem(JetBrains.UI.Options.OptionsSettingsSmartContext settingsStore, System.Collections.Generic.List<JetBrains.ReSharper.Daemon.HighlightingSettingsManager.ConfigurableSeverityItem> items) { }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Features.Environment.Options.Inspections.SeverityItem> Children { get; }
        public string Description { get; set; }
        public string Id { get; set; }
        protected bool IsComposite { get; }
        public bool IsEqualSubitemsState { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.UI.Avalon.TreeListView.ObservableObject Parent { get; set; }
        public JetBrains.ReSharper.Features.Environment.Options.Inspections.SeverityOption SelectedOption { get; set; }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Features.Environment.Options.Inspections.SeverityOption> SeverityOptions { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.PsiLanguageType> SupportedLanguages { get; }
        public string Title { get; set; }
        public static JetBrains.ReSharper.Features.Environment.Options.Inspections.SeverityItem Create(JetBrains.UI.Options.OptionsSettingsSmartContext settingsStore, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Daemon.HighlightingSettingsManager.ConfigurableSeverityItem> items) { }
    }
    public class SeverityItemToTextBlockConverter : System.Windows.Data.IValueConverter
    {
        public object Convert(object value, System.Type targetType, object parameter, System.Globalization.CultureInfo culture) { }
        public object ConvertBack(object value, System.Type targetType, object parameter, System.Globalization.CultureInfo culture) { }
    }
    public class SeverityOption
    {
        public SeverityOption(string display, JetBrains.ReSharper.Daemon.Severity severity, System.Windows.Media.SolidColorBrush color) { }
        public System.Windows.Media.SolidColorBrush Color { get; set; }
        public string Display { get; set; }
        public JetBrains.ReSharper.Daemon.Severity Severity { get; set; }
    }
    public class SkipItemsForm : System.Windows.Forms.Form
    {
        public SkipItemsForm(JetBrains.DataFlow.Lifetime lifetime, JetBrains.UI.Application.IUIApplication environment, JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Settings.IContextBoundSettingsStore settingsStore, JetBrains.Application.Interop.NativeHook.IWindowsHookManager windowsHookManager, JetBrains.CommonControls.Validation.FormValidators formValidators, JetBrains.UI.Application.IMainWindow mainWindow = null) { }
        public JetBrains.UI.Application.IUIApplication Environment { get; }
        protected override void Dispose(bool disposing) { }
        public void OnCancel() { }
        public void OnOk() { }
    }
}
namespace JetBrains.ReSharper.Features.Environment.Options.Languages
{
    
    [JetBrains.UI.Options.OptionsPageAttribute("Languages", "Languages", typeof(JetBrains.UI.Resources.CommonThemedIcons.Components), HelpKeyword="Reference__Options__Environment__Languages", ParentId="Environment")]
    public class LanguagesPage : JetBrains.UI.Options.Helpers.AOptionsPage
    {
        public const string Pid = "Languages";
        public LanguagesPage([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.Settings.Storage.DefaultFileStorages.GlobalPerProductStorage globalPerProductStorage, JetBrains.UI.Application.IUIApplication environment, JetBrains.ReSharper.Psi.LanguageSettings.EnabledLanguagesSupport languagesSupport, JetBrains.ProjectModel.FileTypes.ProjectFileTypeServices services, JetBrains.UI.Options.OptionsSettingsSmartContext settings, JetBrains.Application.Application.Environment.Components.IApplicationRestart restart, JetBrains.Application.Components.IComponentContainer uiData, JetBrains.Application.IShellLocks locks) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Features.Environment.Options.Languages.LanguageSupportItem> Languages { get; }
        public JetBrains.DataFlow.Property<System.Windows.Visibility> RestartAdviserVisible { get; }
        public bool ApplicationCanRestart() { }
        public void Restart() { }
    }
    public class LanguagesPageView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector
    {
        public LanguagesPageView() { }
        public void InitializeComponent() { }
        public void SetBindings(JetBrains.ReSharper.Features.Environment.Options.Languages.LanguagesPage context) { }
    }
    public class LanguageSupportItem : System.ComponentModel.INotifyPropertyChanged
    {
        public LanguageSupportItem(JetBrains.ReSharper.Features.Environment.Options.Languages.LanguageSupportItem baseItem, string languageName, string languageDescription, JetBrains.UI.Icons.IconId icon, bool enabledAtStartup, bool enabledInitially) { }
        public bool Available { get; }
        public System.Windows.Visibility AvailableVisibility { get; }
        public string Description { get; }
        public bool EnabledAtStartup { get; }
        public JetBrains.DataFlow.IProperty<bool> IsEnabled { get; }
        public JetBrains.UI.Icons.IconId LanguageIcon { get; }
        public JetBrains.DataFlow.IProperty<string> LanguageText { get; }
        public bool NeedRestart { get; }
        public System.Windows.Visibility NeedRestartVisibility { get; }
        public string UnavailableText { get; }
        public System.Windows.Visibility UnavailableVisibility { get; }
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        public event System.Action Updated;
        [JetBrains.Annotations.NotifyPropertyChangedInvocatorAttribute()]
        protected virtual void OnPropertyChanged(string propertyName) { }
    }
}
namespace JetBrains.ReSharper.Features.Environment.Options.Naming
{
    
    public class static AbbreviationsUtil
    {
        public static void ProcessChange<TKey>(JetBrains.Application.Settings.IContextBoundSettingsStore settingsStore, System.Linq.Expressions.Expression<System.Func<TKey, JetBrains.Application.Settings.Store.IIndexedEntry<string, string>>> abbreviationsSettingsKey, string userValue) { }
        public static string ReadFromSettings<TKey>(JetBrains.Application.Settings.IContextBoundSettingsStore settingsStore, System.Linq.Expressions.Expression<System.Func<TKey, JetBrains.Application.Settings.Store.IIndexedEntry<string, string>>> abbreviationsSettingsKey) { }
    }
    public class AdvancedNamingSettingListItem
    {
        public System.Guid Guid;
        public JetBrains.ReSharper.Psi.Naming.Settings.ClrUserDefinedNamingRule Rule;
        public AdvancedNamingSettingListItem(JetBrains.ReSharper.Psi.Naming.Settings.ClrUserDefinedNamingRule rule, System.Guid guid) { }
    }
    public class AdvancedNamingSettingsForm<TKey> : System.Windows.Forms.Form
        where TKey : JetBrains.ReSharper.Psi.Naming.Settings.ClrLanguageNamingSettingsKeyBase
    {
        public AdvancedNamingSettingsForm(JetBrains.UI.Options.OptionsSettingsSmartContext settings, JetBrains.ReSharper.Psi.PsiLanguageType language, JetBrains.UI.Icons.IThemedIconManager iconman) { }
        protected override void Dispose(bool disposing) { }
    }
    [JetBrains.UI.Options.OptionsPageAttribute("CSharpNamingStyle2", "Naming Style", typeof(JetBrains.ReSharper.Features.Environment.Src.Options.FeaturesEnvironmentOptionsThemedIcons.NamingConvention), HelpKeyword="Reference__Options__Languages__CSharp__CSharp_Naming_Style", ParentId="Csharp", Sequence=0D, SupportedEditions=new string[] {
            "Csharp"})]
    public class CSharpNamingOptionsPage : JetBrains.ReSharper.Features.Environment.Options.Naming.NamingStylePage<JetBrains.ReSharper.Psi.CSharp.Naming2.CSharpNamingSettings>
    {
        public const string PID = "CSharpNamingStyle2";
        public CSharpNamingOptionsPage(JetBrains.UI.Options.OptionsSettingsSmartContext settings, JetBrains.UI.Icons.IThemedIconManager uiIconsComponent) { }
        public override string Id { get; }
    }
    public class CustomNamingOptionsPage<TKey> : System.Windows.Forms.UserControl, JetBrains.UI.Options.IOptionsPage
        where TKey : JetBrains.ReSharper.Psi.Naming.Settings.CustomRulesNamingSettingsKeyBase
    {
        protected CustomNamingOptionsPage(JetBrains.DataFlow.Lifetime lifetime, JetBrains.UI.Options.OptionsSettingsSmartContext settings, JetBrains.ReSharper.Psi.Naming.Elements.INamedElementsManager namedElementsManager, JetBrains.ReSharper.Psi.PsiLanguageType languageType, JetBrains.UI.Icons.IThemedIconManager iconman) { }
        public JetBrains.UI.CrossFramework.EitherControl Control { get; }
        public virtual string Id { get; }
        protected override void Dispose(bool disposing) { }
        public bool OnOk() { }
        public bool ValidatePage() { }
    }
    public class CustomNamingRuleItem
    {
        public readonly string Name;
        public JetBrains.ReSharper.Psi.Naming.Settings.NamingPolicy Policy;
        public readonly string PresentableName;
        public JetBrains.ReSharper.Features.Environment.Options.Naming.StyleItemState State;
        public CustomNamingRuleItem(string name, string presentableName, JetBrains.ReSharper.Psi.Naming.Settings.NamingPolicy policy, JetBrains.ReSharper.Features.Environment.Options.Naming.StyleItemState state) { }
    }
    public class CustomNamingRulesTreeView : JetBrains.UI.TreeView.TreeModelPresentableView
    {
        public CustomNamingRulesTreeView(JetBrains.TreeModels.TreeModel model, JetBrains.UI.TreeView.ITreeViewController controller) { }
        protected override void Initialize() { }
        protected override void SetupColumnWidth() { }
        protected override void UpdateNodeCells(JetBrains.UI.TreeView.TreeModelViewNode viewNode, JetBrains.TreeModels.TreeModelNode modelNode, JetBrains.UI.TreeView.PresentationState state) { }
        public class InnerPresenter : JetBrains.UI.TreeView.StructuredPresenter<JetBrains.TreeModels.TreeModelNode, JetBrains.CommonControls.IPresentableItem>
        {
            public InnerPresenter() { }
        }
    }
    public class EditNamingPolicyControl : System.Windows.Forms.UserControl
    {
        public EditNamingPolicyControl(JetBrains.ReSharper.Psi.Naming.Settings.NamingPolicy namingPolicy, JetBrains.UI.Icons.IThemedIconManager iconman) { }
        public bool HasChanges { get; }
        public JetBrains.ReSharper.Psi.Naming.Settings.NamingPolicy Policy { get; }
        protected override void Dispose(bool disposing) { }
    }
    public class EditNamingPolicyDialog : System.Windows.Window, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector
    {
        public EditNamingPolicyDialog() { }
        public EditNamingPolicyDialog(JetBrains.ReSharper.Psi.Naming.Settings.NamingPolicy namingPolicy, string ruleName, JetBrains.UI.Icons.IThemedIconManager uiIconsComponent, JetBrains.UI.Options.OptionsDialog2.UserFriendlySettingsLayerUidata[] settingsLayers = null) { }
        public bool CanSaveTo { get; }
        public bool HasChanges { get; }
        public JetBrains.ReSharper.Psi.Naming.Settings.NamingPolicy Policy { get; }
        public JetBrains.UI.Options.OptionsDialog2.UserFriendlySettingsLayerUidata SelectedSettingsLayer { get; }
        public JetBrains.UI.Options.OptionsDialog2.UserFriendlySettingsLayerUidata[] SettingsLayers { get; }
        public void InitializeComponent() { }
    }
    [System.ObsoleteAttribute("Use EditNamingPolicyDialog instead")]
    public class EditNamingPolicyForm : System.Windows.Forms.Form
    {
        public EditNamingPolicyForm(JetBrains.ReSharper.Psi.Naming.Settings.NamingPolicy namingPolicy, string myRuleName, JetBrains.UI.Icons.IThemedIconManager uiIconsComponent) { }
        public bool HasChanges { get; }
        public JetBrains.ReSharper.Psi.Naming.Settings.NamingPolicy Policy { get; }
        protected override void Dispose(bool disposing) { }
        protected override void OnClosed(System.EventArgs e) { }
    }
    public class EditNamingPolicyTreeView : JetBrains.UI.TreeView.TreeModelPresentableView
    {
        public EditNamingPolicyTreeView(JetBrains.TreeModels.TreeModel model, JetBrains.UI.TreeView.ITreeViewController controller) { }
        protected override void Initialize() { }
    }
    public class EditUserRuleForm : System.Windows.Forms.Form
    {
        public JetBrains.ReSharper.Psi.Naming.Settings.AccessRightKinds AccessRightKind;
        public string Description;
        public JetBrains.ReSharper.Psi.Naming.Elements.IElementKindSet ElementKind;
        public JetBrains.ReSharper.Psi.Naming.Settings.StaticnessKinds StaticnessKind;
        public EditUserRuleForm() { }
        public EditUserRuleForm(JetBrains.ReSharper.Psi.Naming.Settings.ClrNamedElementDescriptor descriptor, JetBrains.ReSharper.Psi.PsiLanguageType languageType, JetBrains.ReSharper.Psi.Naming.Settings.NamingPolicy policy, JetBrains.UI.Icons.IThemedIconManager uiIconsComponent) { }
        public JetBrains.ReSharper.Psi.Naming.Settings.NamingPolicy Policy { get; }
        protected override void Dispose(bool disposing) { }
        protected override void OnClosed(System.EventArgs e) { }
    }
    public class ElementKindPresenter : JetBrains.UI.TreeView.StructuredPresenter<JetBrains.TreeModels.TreeModelNode, JetBrains.CommonControls.IPresentableItem>
    {
        public ElementKindPresenter() { }
    }
    public class ElementKindsTreeView : JetBrains.UI.TreeView.TreeModelViewChecked
    {
        public ElementKindsTreeView(JetBrains.TreeModels.TreeModel model, JetBrains.UI.TreeView.ITreeViewController controller) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Naming.Elements.IElementKind> CheckedValues { get; }
        public static JetBrains.ReSharper.Features.Environment.Options.Naming.ElementKindsTreeView Create(System.Collections.Generic.IEnumerable<JetBrains.Util.Pair<JetBrains.ReSharper.Psi.Naming.Elements.IElementKind, bool>> elements) { }
    }
    public class EnumMembersCheckTreeView<ENUM_TYPE> : JetBrains.UI.TreeView.TreeModelViewChecked
    
    {
        public EnumMembersCheckTreeView(JetBrains.TreeModels.TreeModel model, JetBrains.UI.TreeView.ITreeViewController controller) { }
        public System.Collections.Generic.IEnumerable<ENUM_TYPE> CheckedValues { get; }
        public static JetBrains.ReSharper.Features.Environment.Options.Naming.EnumMembersCheckTreeView<ENUM_TYPE> Create(System.Collections.Generic.IEnumerable<ENUM_TYPE> members, System.Func<ENUM_TYPE, bool> check, System.Func<ENUM_TYPE, string> enumPresenter) { }
        protected override void Initialize() { }
    }
    public class EnumMemberTreeViewConmtroller : JetBrains.UI.TreeView.TreeViewController
    {
        public EnumMemberTreeViewConmtroller() { }
    }
    public class EnumPresenter<ENUM_TYPE> : JetBrains.UI.TreeView.StructuredPresenter<JetBrains.TreeModels.TreeModelNode, JetBrains.CommonControls.IPresentableItem>
    
    {
        public EnumPresenter(System.Func<ENUM_TYPE, string> enumPresenter) { }
    }
    public class NamingPolicyViewController : JetBrains.UI.TreeView.TreeViewController
    {
        public NamingPolicyViewController() { }
        public override bool DragDropSupported { get; }
        public override bool GuardActions { get; }
        public override bool QuickSearchSupported { get; }
        public override bool ExpandNodeInitially(JetBrains.TreeModels.TreeModelNode modelNode) { }
        public override bool VisibilityState(JetBrains.TreeModels.TreeModelNode modelNode) { }
    }
    public class NamingRuleViewController : JetBrains.UI.TreeView.TreeViewController
    {
        public NamingRuleViewController() { }
        public override bool DragDropSupported { get; }
        public override bool GuardActions { get; }
        public override bool QuickSearchSupported { get; }
        public override bool ExpandNodeInitially(JetBrains.TreeModels.TreeModelNode modelNode) { }
        public override bool VisibilityState(JetBrains.TreeModels.TreeModelNode modelNode) { }
    }
    public abstract class NamingStylePage<TKey> : System.Windows.Forms.UserControl, JetBrains.UI.Options.IOptionsPage
        where TKey : JetBrains.ReSharper.Psi.Naming.Settings.ClrLanguageNamingSettingsKeyBase
    {
        public NamingStylePage(JetBrains.UI.Options.OptionsSettingsSmartContext settings, JetBrains.ReSharper.Psi.PsiLanguageType language, JetBrains.UI.Icons.IThemedIconManager uiIconsComponent) { }
        public JetBrains.UI.CrossFramework.EitherControl Control { get; }
        public abstract string Id { get; }
        public bool OnOk() { }
        public bool ValidatePage() { }
    }
    public class PredefinedEditItem : System.ComponentModel.INotifyPropertyChanged
    {
        public readonly JetBrains.ReSharper.Psi.Naming.Settings.NamedElementKinds NamedElementKind;
        public PredefinedEditItem(JetBrains.ReSharper.Psi.Naming.Settings.NamedElementKinds namedElementKind, JetBrains.ReSharper.Psi.Naming.Settings.NamingPolicy policy, JetBrains.ReSharper.Features.Environment.Options.Naming.StyleItemState state) { }
        [JetBrains.Annotations.UsedImplicitlyAttribute()]
        public System.Windows.Media.Brush Color { get; }
        [JetBrains.Annotations.UsedImplicitlyAttribute()]
        public string EntityKinds { get; }
        [JetBrains.Annotations.UsedImplicitlyAttribute()]
        public string ExtraPreview { get; }
        public JetBrains.ReSharper.Psi.Naming.Settings.NamingPolicy Policy { get; set; }
        [JetBrains.Annotations.UsedImplicitlyAttribute()]
        public string Preview { get; }
        public JetBrains.ReSharper.Features.Environment.Options.Naming.StyleItemState State { get; set; }
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
    }
    public class PredefinedNamingRulePresenter : JetBrains.UI.TreeView.StructuredPresenter<JetBrains.TreeModels.TreeModelNode, JetBrains.CommonControls.IPresentableItem>
    {
        public PredefinedNamingRulePresenter() { }
    }
    public class PredefinedNamingRulesTreeView : JetBrains.UI.TreeView.TreeModelPresentableView
    {
        public PredefinedNamingRulesTreeView(JetBrains.TreeModels.TreeModel model, JetBrains.UI.TreeView.ITreeViewController controller) { }
        protected override void Initialize() { }
        protected override void SetupColumnWidth() { }
        protected override void UpdateNodeCells(JetBrains.UI.TreeView.TreeModelViewNode viewNode, JetBrains.TreeModels.TreeModelNode modelNode, JetBrains.UI.TreeView.PresentationState state) { }
    }
    public class RuleWrapper
    {
        public RuleWrapper(bool isDefault, JetBrains.ReSharper.Psi.Naming.Settings.NamingRule rule) { }
        public bool IsDefault { get; set; }
        public JetBrains.ReSharper.Psi.Naming.Settings.NamingRule Rule { get; }
        public override string ToString() { }
    }
    public class RuleWrapperPresenter : JetBrains.UI.TreeView.StructuredPresenter<JetBrains.TreeModels.TreeModelNode, JetBrains.CommonControls.IPresentableItem>
    {
        public RuleWrapperPresenter() { }
    }
    public enum StyleItemState
    {
        Default = 0,
        Unchanged = 1,
        Reset = 2,
        Modified = 3,
    }
    public class UserNamingRulePresenter : JetBrains.UI.TreeView.StructuredPresenter<JetBrains.TreeModels.TreeModelNode, JetBrains.CommonControls.IPresentableItem>
    {
        public UserNamingRulePresenter() { }
    }
    public class UserNamingRulesTreeView : JetBrains.UI.TreeView.TreeModelPresentableView
    {
        public UserNamingRulesTreeView(JetBrains.TreeModels.TreeModel model, JetBrains.UI.TreeView.ITreeViewController controller) { }
        protected override void Initialize() { }
        protected override void SetupColumnWidth() { }
        protected override void UpdateNodeCells(JetBrains.UI.TreeView.TreeModelViewNode viewNode, JetBrains.TreeModels.TreeModelNode modelNode, JetBrains.UI.TreeView.PresentationState state) { }
    }
    [JetBrains.UI.Options.OptionsPageAttribute("VBNamingStyle2", "Naming Style", typeof(JetBrains.ReSharper.Features.Environment.Src.Options.FeaturesEnvironmentOptionsThemedIcons.NamingConvention), HelpKeyword="Reference__Options__Languages__Visual_Basic__NET__VB_Naming_Style", ParentId="Vbnet", Sequence=0D, SupportedEditions=new string[] {
            "Vbnet"})]
    public class VBNamingOptionsPage : JetBrains.ReSharper.Features.Environment.Options.Naming.NamingStylePage<JetBrains.ReSharper.Psi.VB.Naming2.VBNamingSettings>
    {
        public const string PID = "VBNamingStyle2";
        public VBNamingOptionsPage(JetBrains.UI.Options.OptionsSettingsSmartContext settings, JetBrains.UI.Icons.IThemedIconManager uiIconsComponent) { }
        public override string Id { get; }
    }
}
namespace JetBrains.ReSharper.Features.Environment.Options.Naming.Xaml
{
    
    [JetBrains.UI.Options.OptionsPageAttribute("Xaml.Naming", "XAML Naming Style", typeof(JetBrains.ReSharper.Features.Environment.Src.Options.FeaturesEnvironmentOptionsThemedIcons.NamingConvention), HelpKeyword="Reference__Options__Languages__XAML__Xaml_Naming_Style", ParentId="Xaml", Sequence=0D)]
    public class XamlNamingOptionsPage : JetBrains.ReSharper.Features.Environment.Options.Naming.CustomNamingOptionsPage<JetBrains.ReSharper.Psi.Xaml.Naming.XamlNamingSettingsKey>
    {
        [JetBrains.Annotations.PublicAPIAttribute()]
        public const string PID = "Xaml.Naming";
        public XamlNamingOptionsPage(JetBrains.DataFlow.Lifetime lifetime, JetBrains.UI.Options.OptionsSettingsSmartContext settings, JetBrains.ReSharper.Psi.Naming.Elements.INamedElementsManager namedElementsManager, JetBrains.UI.Icons.IThemedIconManager iconman) { }
        public override string Id { get; }
    }
}
namespace JetBrains.ReSharper.Features.Environment.PsiCacheNotifier
{
    
    [JetBrains.ProjectModel.SolutionComponentAttribute(JetBrains.Application.Components.ProgramConfigurations.NONE | JetBrains.Application.Components.ProgramConfigurations.STANDALONE | JetBrains.Application.Components.ProgramConfigurations.VS_ADDIN | JetBrains.Application.Components.ProgramConfigurations.ALL)]
    public class PsiCacheNotifierImpl : JetBrains.ReSharper.Psi.Caches.PsiCacheNotifier
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly JetBrains.DataFlow.Property<string> DescriptionUi;
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly JetBrains.DataFlow.Property<string> HeaderUi;
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly JetBrains.DataFlow.Property<bool> IsActiveUi;
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly JetBrains.DataFlow.Property<double> ProgressUi;
        public PsiCacheNotifierImpl(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.IShellLocks locks, JetBrains.UI.CommonControls.Fonts.FontsManager fontsman, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.UI.Application.IMainWindow mainwin, JetBrains.Application.IApplicationDescriptor product, JetBrains.UI.StatusBar.IStatusBar statusBar, JetBrains.UI.Application.IIsApplicationActiveState isApplicationActiveState, JetBrains.UI.PopupWindowManager.PopupWindowManager popupWindowManager, JetBrains.UI.Icons.IThemedIconManager themedIconManager) { }
        public static void HideReadLocks([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.IShellLocks locks) { }
        public override bool WaitForCaches(string callerName, string cancelButtonContent) { }
    }
}
namespace JetBrains.ReSharper.Features.Environment.RecentFiles
{
    
    public class FileLocationInfo
    {
        public FileLocationInfo([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ProjectModel.IProjectFile projectFile) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.UI.PopupMenu.IMenuItemDescriptor CachedPresentation { get; }
        public int CaretOffset { get; set; }
        public JetBrains.Util.dataStructures.TypedIntrinsics.Int32<JetBrains.TextControl.TextControlLine> DistanceFromTop { get; set; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.Util.FileSystemPath FileSystemPath { get; }
        public JetBrains.ProjectModel.IProjectFile ProjectFile { get; }
    }
    [JetBrains.ActionManagement.ActionHandlerAttribute()]
    public class GotoRecentEditsAction : JetBrains.ActionManagement.IActionHandler
    {
        public void Execute(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.DelegateExecute nextExecute) { }
        public bool Update(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.ActionPresentation presentation, JetBrains.ActionManagement.DelegateUpdate nextUpdate) { }
    }
    [JetBrains.ReSharper.Psi.ShellFeaturePartAttribute()]
    public class GotoRecentEditsProvider : JetBrains.ReSharper.Feature.Services.Goto.IApplicableGotoProvider, JetBrains.ReSharper.Feature.Services.Navigation.Goto.IGotoRecentEditsProvider, JetBrains.ReSharper.Feature.Services.Navigation.Goto.IInstantGotoProvider
    {
        public virtual System.Collections.Generic.IEnumerable<JetBrains.Util.Pair<JetBrains.ReSharper.Feature.Services.Search.IOccurence, JetBrains.ReSharper.Feature.Services.Goto.MatchingInfo>> GetMatchingOccurences(JetBrains.Text.IdentifierMatcher matcher, JetBrains.ReSharper.Feature.Services.Goto.INavigationScope scope, JetBrains.ReSharper.Feature.Services.Goto.GotoContext gotoContext, JetBrains.Application.CheckForInterrupt checkForInterrupt) { }
        public bool IsApplicable(JetBrains.ReSharper.Feature.Services.Goto.INavigationScope scope, JetBrains.ReSharper.Feature.Services.Goto.GotoContext gotoContext, JetBrains.Text.IdentifierMatcher matcher) { }
    }
    [JetBrains.ActionManagement.ActionHandlerAttribute()]
    public class GotoRecentFilesAction : JetBrains.ActionManagement.IActionHandler
    {
        public void Execute(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.DelegateExecute nextExecute) { }
        public bool Update(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.ActionPresentation presentation, JetBrains.ActionManagement.DelegateUpdate nextUpdate) { }
    }
    [JetBrains.ReSharper.Psi.ShellFeaturePartAttribute()]
    public class GotoRecentFilesProvider : JetBrains.ReSharper.Feature.Services.Goto.IApplicableGotoProvider, JetBrains.ReSharper.Feature.Services.Goto.IGotoRecentFilesProvider, JetBrains.ReSharper.Feature.Services.Navigation.Goto.IInstantGotoProvider
    {
        public GotoRecentFilesProvider(JetBrains.TextControl.ITextControlManager textControlManager) { }
        public System.Collections.Generic.IEnumerable<JetBrains.Util.Pair<JetBrains.ReSharper.Feature.Services.Search.IOccurence, JetBrains.ReSharper.Feature.Services.Goto.MatchingInfo>> GetMatchingOccurences(JetBrains.Text.IdentifierMatcher matcher, JetBrains.ReSharper.Feature.Services.Goto.INavigationScope scope, JetBrains.ReSharper.Feature.Services.Goto.GotoContext gotoContext, JetBrains.Application.CheckForInterrupt checkForInterrupt) { }
        public bool IsApplicable(JetBrains.ReSharper.Feature.Services.Goto.INavigationScope scope, JetBrains.ReSharper.Feature.Services.Goto.GotoContext gotoContext, JetBrains.Text.IdentifierMatcher matcher) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class RecentFilesCommands
    {
        public RecentFilesCommands(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.Features.Environment.RecentFiles.RecentFilesTracker tracker, JetBrains.Application.IShellLocks shellLocks, JetBrains.ReSharper.Features.Shared.Occurences.OccurencePresentationManager occurencePresentationManager, JetBrains.ReSharper.Psi.Files.IPsiFiles psiFiles, JetBrains.UI.PopupMenu.JetPopupMenus jetPopupMenus, JetBrains.UI.PopupWindowManager.MainWindowPopupWindowContext mainWindowPopupWindowContext, JetBrains.Application.Interop.NativeHook.IWindowsHookManager windowsHookManager, JetBrains.ProjectModel.ISolution solution, JetBrains.UI.Application.IUIApplication environment, JetBrains.UI.Application.IMainWindow mainWindow = null) { }
        public void NavigatePreviousEditLocation(JetBrains.TextControl.ITextControl textControl) { }
        public void ShowRecentEdits() { }
        public void ShowRecentFiles() { }
    }
    [JetBrains.ReSharper.Psi.SolutionFeaturePartAttribute()]
    public class RecentFilesNavigationProvider : JetBrains.ReSharper.Feature.Services.Navigation.ProjectFileNavigationProvider
    {
        public RecentFilesNavigationProvider(JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Features.Environment.RecentFiles.RecentFilesTracker recentFilesTracker) { }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Navigation.Navigation.INavigationPoint> CreateNavigationPoints(JetBrains.ProjectModel.IProjectModelElement target) { }
        public override bool IsApplicable(JetBrains.ProjectModel.IProjectModelElement data) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class RecentFilesTracker : JetBrains.Application.Configuration.IXmlReadable, JetBrains.Application.Configuration.IXmlWritable, JetBrains.Application.IChangeProvider
    {
        protected readonly JetBrains.ProjectModel.ISolution mySolution;
        public RecentFilesTracker(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.ISolution solution, JetBrains.DocumentManagers.DocumentManager documentManager, JetBrains.Application.ChangeManager changeManager, JetBrains.Application.CommandProcessing.ICommandProcessor commandProcessor, JetBrains.TextControl.ITextControlManager textControlManager, JetBrains.Application.IShellLocks shellLocks, JetBrains.ProjectModel.ProjectModelElementPointerManager projectModelElementPointerManager, JetBrains.ReSharper.Psi.IPsiConfiguration configuration) { }
        public JetBrains.ReSharper.Features.Environment.RecentFiles.FileLocationInfo CurrentEdit { get; }
        public JetBrains.ReSharper.Features.Environment.RecentFiles.FileLocationInfo CurrentFile { get; }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Features.Environment.RecentFiles.FileLocationInfo> EditLocations { get; }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Features.Environment.RecentFiles.FileLocationInfo> FileLocations { get; }
        public JetBrains.ReSharper.Features.Environment.RecentFiles.FileLocationInfo CurrentEditLocation([JetBrains.Annotations.NotNullAttribute()] JetBrains.TextControl.ITextControl textControl) { }
        protected virtual string GetId(JetBrains.ReSharper.Features.Environment.RecentFiles.FileLocationInfo location) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        protected virtual JetBrains.ProjectModel.IProjectFile GetProjectFile(string id) { }
        public JetBrains.ReSharper.Features.Environment.RecentFiles.FileLocationInfo PreviousEditLocation(JetBrains.TextControl.ITextControl textControl) { }
    }
    [JetBrains.ProjectModel.Settings.Upgrade.SolutionSettingsUpgraderAttribute()]
    public class RecentFilesTrackerUpgrader : JetBrains.Application.Configuration.Upgrade.ISettingsUpgrader, JetBrains.ProjectModel.Settings.Upgrade.ISolutionSettingsUpgrader
    {
        public RecentFilesTrackerUpgrader(JetBrains.ReSharper.Features.Environment.RecentFiles.RecentFilesTracker recentFilesTracker) { }
        public void Upgrade(JetBrains.Application.Configuration.IComponentSettingsProvider legacySettingsProvider, JetBrains.Application.Settings.IContextBoundSettingsStore boundSettingsStore, JetBrains.DataFlow.Lifetime upgradeLifetime) { }
    }
}
namespace JetBrains.ReSharper.Features.Environment.Resources
{
    
    public sealed class FeaturesEnvironmentThemedIcons
    {
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Features.Environment;component/resources/FeaturesEnvironmentT" +
            "hemedIcons/ThemedIcons.FeaturesEnvironment.Generated.Xaml", 3, "AddFile")]
        public sealed class AddFile : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Features.Environment;component/resources/FeaturesEnvironmentT" +
            "hemedIcons/ThemedIcons.FeaturesEnvironment.Generated.Xaml", 1, "CacheNotifierGlyph")]
        public sealed class CacheNotifierGlyph : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Features.Environment;component/resources/FeaturesEnvironmentT" +
            "hemedIcons/ThemedIcons.FeaturesEnvironment.Generated.Xaml", 2, "NAEnvironment")]
        public sealed class NAEnvironment : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Features.Environment;component/resources/FeaturesEnvironmentT" +
            "hemedIcons/ThemedIcons.FeaturesEnvironment.Generated.Xaml", 0, "Tip")]
        public sealed class Tip : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
    }
}
namespace JetBrains.ReSharper.Features.Environment.Src.Options
{
    
    public sealed class FeaturesEnvironmentOptionsThemedIcons
    {
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Features.Environment;component/src/Options/FeaturesEnvironmen" +
            "tOptionsIcons/ThemedIcons.FeaturesEnvironmentOptions.Generated.Xaml", 7, "BracesLayout")]
        public sealed class BracesLayout : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Features.Environment;component/src/Options/FeaturesEnvironmen" +
            "tOptionsIcons/ThemedIcons.FeaturesEnvironmentOptions.Generated.Xaml", 6, "CodeInspections")]
        public sealed class CodeInspections : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Features.Environment;component/src/Options/FeaturesEnvironmen" +
            "tOptionsIcons/ThemedIcons.FeaturesEnvironmentOptions.Generated.Xaml", 1, "CodeStyle")]
        public sealed class CodeStyle : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Features.Environment;component/src/Options/FeaturesEnvironmen" +
            "tOptionsIcons/ThemedIcons.FeaturesEnvironmentOptions.Generated.Xaml", 11, "EnvironmentGeneral")]
        public sealed class EnvironmentGeneral : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Features.Environment;component/src/Options/FeaturesEnvironmen" +
            "tOptionsIcons/ThemedIcons.FeaturesEnvironmentOptions.Generated.Xaml", 3, "GeneratedCode")]
        public sealed class GeneratedCode : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Features.Environment;component/src/Options/FeaturesEnvironmen" +
            "tOptionsIcons/ThemedIcons.FeaturesEnvironmentOptions.Generated.Xaml", 10, "GlobalAnalysis")]
        public sealed class GlobalAnalysis : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Features.Environment;component/src/Options/FeaturesEnvironmen" +
            "tOptionsIcons/ThemedIcons.FeaturesEnvironmentOptions.Generated.Xaml", 5, "Highlighting")]
        public sealed class Highlighting : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Features.Environment;component/src/Options/FeaturesEnvironmen" +
            "tOptionsIcons/ThemedIcons.FeaturesEnvironmentOptions.Generated.Xaml", 12, "NamingConvention")]
        public sealed class NamingConvention : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Features.Environment;component/src/Options/FeaturesEnvironmen" +
            "tOptionsIcons/ThemedIcons.FeaturesEnvironmentOptions.Generated.Xaml", 2, "Persistence")]
        public sealed class Persistence : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Features.Environment;component/src/Options/FeaturesEnvironmen" +
            "tOptionsIcons/ThemedIcons.FeaturesEnvironmentOptions.Generated.Xaml", 8, "Quickfixes")]
        public sealed class Quickfixes : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Features.Environment;component/src/Options/FeaturesEnvironmen" +
            "tOptionsIcons/ThemedIcons.FeaturesEnvironmentOptions.Generated.Xaml", 0, "StringFormat")]
        public sealed class StringFormat : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Features.Environment;component/src/Options/FeaturesEnvironmen" +
            "tOptionsIcons/ThemedIcons.FeaturesEnvironmentOptions.Generated.Xaml", 13, "TypeMembersLayout")]
        public sealed class TypeMembersLayout : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Features.Environment;component/src/Options/FeaturesEnvironmen" +
            "tOptionsIcons/ThemedIcons.FeaturesEnvironmentOptions.Generated.Xaml", 9, "UsingDirectives")]
        public sealed class UsingDirectives : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Features.Environment;component/src/Options/FeaturesEnvironmen" +
            "tOptionsIcons/ThemedIcons.FeaturesEnvironmentOptions.Generated.Xaml", 4, "ValueAnalysis")]
        public sealed class ValueAnalysis : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
    }
}
namespace JetBrains.ReSharper.Features.Environment.Src.Options.Inspections
{
    
    public sealed class SkipItemsDialogThemedIcons
    {
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Features.Environment;component/src/Options/Inspections/SkipIt" +
            "emsDialogThemedIcons/ThemedIcons.SkipItemsDialog.Generated.Xaml", 1, "SkipItemsAddMask")]
        public sealed class SkipItemsAddMask : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Features.Environment;component/src/Options/Inspections/SkipIt" +
            "emsDialogThemedIcons/ThemedIcons.SkipItemsDialog.Generated.Xaml", 0, "SkipItemsEditMask")]
        public sealed class SkipItemsEditMask : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Features.Environment;component/src/Options/Inspections/SkipIt" +
            "emsDialogThemedIcons/ThemedIcons.SkipItemsDialog.Generated.Xaml", 2, "SkipItemsRemoveMask")]
        public sealed class SkipItemsRemoveMask : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
    }
}
namespace JetBrains.ReSharper.Features.Environment.src.Options.Naming
{
    
    public class PredefinedNamingSettingsPage : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector
    {
        public PredefinedNamingSettingsPage(System.Collections.Generic.List<JetBrains.ReSharper.Features.Environment.Options.Naming.PredefinedEditItem> myItems, System.Action advancedClick, System.Action onOk, JetBrains.UI.Icons.IThemedIconManager uiIconsComponent) { }
        public System.Collections.ObjectModel.ObservableCollection<JetBrains.ReSharper.Features.Environment.Options.Naming.PredefinedEditItem> Settings { get; set; }
        public void InitializeComponent() { }
    }
}
namespace JetBrains.ReSharper.Features.Environment.Tips
{
    
    [System.ComponentModel.TypeConverterAttribute("JetBrains.ReSharper.Features.Environment.Tips.ActivityConverter")]
    public class Activity
    {
        public const string EDITING = "editing";
        [JetBrains.Application.Configuration.XmlExternalizableAttribute(null)]
        public string Id;
        [JetBrains.Application.Configuration.XmlExternalizableAttribute(null)]
        public string Language;
        public const string VIEWING = "viewing";
        public Activity(string id, string language) { }
        public Activity(System.Xml.XmlElement element) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
        public void ReadFromXml(System.Xml.XmlElement element) { }
        public void WriteToXml(System.Xml.XmlElement element) { }
    }
    public class ActivityConverter : JetBrains.Util.Reflection.TypeConverterBase<JetBrains.ReSharper.Features.Environment.Tips.Activity>
    {
        public ActivityConverter() { }
    }
    [System.ComponentModel.TypeConverterAttribute("JetBrains.ReSharper.Features.Environment.Tips.ActivityDataConverter")]
    public class ActivityData : JetBrains.ReSharper.Features.Environment.Tips.IActivityData
    {
        public System.DateTime LastTimeUsed;
        public int TotalWorkTime;
        public ActivityData() { }
        public int TotalWorkAmount { get; }
        public void ReadFromXml(System.Xml.XmlElement element) { }
        public void WriteToXml(System.Xml.XmlElement element) { }
    }
    public class ActivityDataConverter : JetBrains.Util.Reflection.TypeConverterBase<JetBrains.ReSharper.Features.Environment.Tips.ActivityData>
    {
        public ActivityDataConverter() { }
    }
    [System.ComponentModel.TypeConverterAttribute("JetBrains.ReSharper.Features.Environment.Tips.FeatureAndLanguageConverter")]
    public class FeatureAndLanguage : JetBrains.Application.Configuration.IXmlReadable, JetBrains.Application.Configuration.IXmlWritable, System.IEquatable<JetBrains.ReSharper.Features.Environment.Tips.FeatureAndLanguage>
    {
        [JetBrains.Application.Configuration.XmlExternalizableAttribute(null, SettingName="Feature")]
        public string myFeatureId;
        [JetBrains.Application.Configuration.XmlExternalizableAttribute(null, SettingName="Language")]
        public string myLanguage;
        public FeatureAndLanguage(string featureId, string language) { }
        public FeatureAndLanguage(System.Xml.XmlElement element) { }
        public string FeatureId { get; }
        public string Language { get; }
        public bool Equals(JetBrains.ReSharper.Features.Environment.Tips.FeatureAndLanguage featureAndLanguage) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
        public void ReadFromXml(System.Xml.XmlElement element) { }
        public void WriteToXml(System.Xml.XmlElement element) { }
    }
    public class FeatureAndLanguageConverter : JetBrains.Util.Reflection.TypeConverterBase<JetBrains.ReSharper.Features.Environment.Tips.FeatureAndLanguage>
    {
        public FeatureAndLanguageConverter() { }
    }
    [System.ComponentModel.TypeConverterAttribute("JetBrains.ReSharper.Features.Environment.Tips.FeatureDataConverter")]
    public class FeatureData : JetBrains.Application.Configuration.IXmlReadable, JetBrains.Application.Configuration.IXmlWritable, JetBrains.ReSharper.Features.Environment.Tips.IActivityData
    {
        [JetBrains.Application.Configuration.XmlExternalizableAttribute(-1)]
        public int StartWorkAmount;
        [JetBrains.Application.Configuration.XmlExternalizableAttribute("")]
        public System.DateTime TipShownTime;
        [JetBrains.Application.Configuration.XmlExternalizableAttribute(0)]
        public int UseCount;
        public FeatureData() { }
        public bool TipWasShown { get; }
        public int TotalWorkAmount { get; }
        public void ReadFromXml(System.Xml.XmlElement element) { }
        public void WriteToXml(System.Xml.XmlElement element) { }
    }
    public class FeatureDataConverter : JetBrains.Util.Reflection.TypeConverterBase<JetBrains.ReSharper.Features.Environment.Tips.FeatureData>
    {
        public FeatureDataConverter() { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class TipsManagerImpl : JetBrains.ReSharper.Feature.Services.Tips.TipsManager
    {
        public const int FORMAT_VERSION = 2;
        public const string TAG_NAME = "TipsManager";
        public TipsManagerImpl(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.Env.RunsProducts.ProductConfigurations productConfigurations, JetBrains.Application.IApplicationDescriptor product, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.UI.Application.IMainWindow mainwin, JetBrains.Threading.IThreading invocator, JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.Application.DataContext.DataContexts dataContexts, JetBrains.Application.Env.Components.ProductSettingsLocation productSettingsLocation) { }
        public override void ActivityIsUsed(string activityId, string language) { }
        public override void DisableTips() { }
        public override void FeatureIsUsed(string featureId, JetBrains.DocumentModel.IDocument document, JetBrains.ProjectModel.ISolution solution) { }
        public override void FeatureIsUsed(string featureId, JetBrains.Application.DataContext.IDataContext context) { }
        public override void FeatureIsUsed(string featureId, string language) { }
        public void LoadFromXml(System.Xml.XmlElement element) { }
        public void OnCaretMoved(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        public void OnTyping(JetBrains.ProjectModel.ISolution solution, JetBrains.DocumentModel.IDocument document) { }
        public void SetActivityData(JetBrains.ReSharper.Features.Environment.Tips.Activity activity, JetBrains.ReSharper.Features.Environment.Tips.ActivityData data) { }
        public void SetFeatureData(JetBrains.ReSharper.Features.Environment.Tips.FeatureAndLanguage featureAndLanguage, JetBrains.ReSharper.Features.Environment.Tips.FeatureData data) { }
        public override void ShowTips(bool onStartup) { }
    }
    [JetBrains.Application.Configuration.Upgrade.GlobalSettingsUpgraderAttribute()]
    public class TipsManagerSettingsUpgrader : JetBrains.Application.Configuration.IXmlReadable, JetBrains.Application.Configuration.Upgrade.IGlobalSettingsUpgrader, JetBrains.Application.Configuration.Upgrade.ISettingsUpgrader
    {
        public TipsManagerSettingsUpgrader(JetBrains.ReSharper.Features.Environment.Tips.TipsManagerImpl tipsManagerImpl) { }
    }
}
namespace JetBrains.ReSharper.OptionPages.CodeStyle.Impl
{
    
    public abstract class CodeStylePreview : System.Windows.Forms.Label
    {
        protected CodeStylePreview([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ProjectModel.ISolution solution, [JetBrains.Annotations.NotNullAttribute()] JetBrains.UI.WindowManagement.WindowFrame frame, JetBrains.ProjectModel.FileTypes.IProjectFileTypeServices projectFileTypeServices, JetBrains.ProjectModel.ProjectFileType projectFileType, JetBrains.UI.Application.IUIApplication environment) { }
        protected override void OnSizeChanged(System.EventArgs e) { }
        protected abstract void PrepareText(JetBrains.DocumentModel.IDocument document, string text, JetBrains.ReSharper.OptionPages.CodeStyle.Impl.PreviewParseType type, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.Application.Settings.IContextBoundSettingsStore boundSettingsStore);
        public void ShowPreview(JetBrains.ReSharper.OptionPages.CodeStyle.Impl.CodeStylePreviewData preview, JetBrains.Application.Settings.IContextBoundSettingsStore boundSettingsStore) { }
    }
    public struct CodeStylePreviewData
    {
        public static readonly JetBrains.ReSharper.OptionPages.CodeStyle.Impl.CodeStylePreviewData Empty;
        public CodeStylePreviewData(JetBrains.ReSharper.OptionPages.CodeStyle.Impl.PreviewType type, JetBrains.ReSharper.OptionPages.CodeStyle.Impl.PreviewParseType parse, string text) { }
        public JetBrains.ReSharper.OptionPages.CodeStyle.Impl.PreviewParseType Parse { get; set; }
        public string Text { get; set; }
        public JetBrains.ReSharper.OptionPages.CodeStyle.Impl.PreviewType Type { get; set; }
    }
    public class ModifiersOrderEdit : DevExpress.XtraEditors.PopupContainerControl
    {
        public ModifiersOrderEdit() { }
        public string[] Order { get; set; }
        protected override void Dispose(bool disposing) { }
    }
    public enum PreviewParseType
    {
        None = 0,
        File = 1,
        Member = 2,
        Statement = 3,
    }
    public enum PreviewType
    {
        None = 0,
        Description = 1,
        Code = 2,
        Diff = 3,
    }
}