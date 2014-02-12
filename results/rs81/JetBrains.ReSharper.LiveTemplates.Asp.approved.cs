[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]

namespace JetBrains.ReSharper.LiveTemplates.Asp
{
    
    [JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ScopeCategoryUIProviderAttribute(Priority=28D)]
    public class AspScopeCategoryUIProvider : JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ScopeCategoryUIProvider
    {
        public AspScopeCategoryUIProvider() { }
        public override string CategoryCaption { get; }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint> BuildAllPoints() { }
        public override string Present(JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint point) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class AspScopeProvider : JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.IScopeProvider
    {
        public AspScopeProvider() { }
        public JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint CreateScope(System.Guid scopeGuid, string typeName, System.Collections.Generic.IEnumerable<JetBrains.Util.Pair<string, string>> customProperties) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint> ProvideScopePoints(JetBrains.ReSharper.Feature.Services.LiveTemplates.Context.TemplateAcceptanceContext context) { }
        public JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint ReadFromXml(System.Xml.XmlElement scopeElement) { }
    }
    public class AspTemplateContext : JetBrains.ReSharper.Feature.Services.LiveTemplates.Context.TemplateContext
    {
        public readonly JetBrains.ReSharper.LiveTemplates.Asp.AspTemplateContextType ContextType;
        public readonly JetBrains.ReSharper.Psi.PsiLanguageType LanguageType;
        public AspTemplateContext(JetBrains.ReSharper.LiveTemplates.Asp.AspTemplateContextType contextType, JetBrains.ReSharper.Psi.PsiLanguageType languageType) { }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint> ScopePoints { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.LiveTemplates.Asp.AspTemplateContext ReadFromXml([JetBrains.Annotations.NotNullAttribute()] System.Xml.XmlElement element) { }
        public override string ToString() { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class AspTemplateContextFactory : JetBrains.ReSharper.Feature.Services.LiveTemplates.Context.ITemplateContextFactory
    {
        public JetBrains.ReSharper.Feature.Services.LiveTemplates.Context.ITemplateContext ReadFromXml(System.Xml.XmlElement element) { }
    }
    public enum AspTemplateContextType
    {
        EVERYWHERE = 0,
        TAG_EXPECTED = 1,
        ATTRIBUTE_EXPECTED = 2,
    }
    public class AspTemplateContextUI : JetBrains.UI.CommonControls.SafeUserControl, JetBrains.ReSharper.Feature.Services.LiveTemplates.Context.ITemplateContextUI, System.IDisposable
    {
        public AspTemplateContextUI(JetBrains.UI.Application.IUIApplication environment) { }
        public System.Windows.Forms.Control ContextOptionsUI { get; }
        public JetBrains.ReSharper.LiveTemplates.Asp.AspTemplateContextType ContextType { get; set; }
        public JetBrains.ReSharper.Psi.PsiLanguageType LanguageType { get; set; }
        public JetBrains.ReSharper.Feature.Services.LiveTemplates.Context.ITemplateContext TemplateContext { get; }
        public string Title { get; }
        public bool Valid { get; }
        public event System.EventHandler ValidChanged;
        protected override void Dispose(bool disposing) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Asp.AspLanguage))]
    public class AspTemplateHighlightingProvider : JetBrains.ReSharper.LiveTemplates.Html.HtmlTemplateHighlightingProvider
    {
        public AspTemplateHighlightingProvider(JetBrains.ReSharper.Psi.Asp.Parsing.IAspTokenNodeTypes tokenNodeTypes) { }
    }
    public class InAspAttribute : JetBrains.ReSharper.LiveTemplates.Asp.InAspFile
    {
        public InAspAttribute(JetBrains.ReSharper.Psi.PsiLanguageType language = null) { }
        public override string PresentableShortName { get; }
        public override System.Guid GetDefaultUID() { }
        public override string ToString() { }
    }
    public class InAspFile : JetBrains.ReSharper.LiveTemplates.Html.InHtmlLikeFile, JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.IMainScopePoint, JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint
    {
        public const string AttrLanguage = "language";
        public InAspFile(JetBrains.ReSharper.Psi.PsiLanguageType language = null) { }
        protected string LangString { get; }
        public override string PresentableShortName { get; }
        public string QuickListTitle { get; }
        public System.Guid QuickListUID { get; }
        public override JetBrains.ReSharper.Psi.PsiLanguageType RelatedLanguage { get; }
        public override System.Collections.Generic.IEnumerable<JetBrains.Util.Pair<string, string>> EnumerateCustomProperties() { }
        public override System.Guid GetDefaultUID() { }
        protected override System.Collections.Generic.IEnumerable<string> GetExtensions() { }
        public override bool IsSubsetOf(JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint other) { }
        public override string ToString() { }
        public override System.Xml.XmlElement WriteToXml(System.Xml.XmlElement element) { }
    }
    public class InAspTag : JetBrains.ReSharper.LiveTemplates.Asp.InAspFile
    {
        public InAspTag(JetBrains.ReSharper.Psi.PsiLanguageType language = null) { }
        public override string PresentableShortName { get; }
        public override string CalcPrefix(JetBrains.DocumentModel.IDocument document, int caretOffset) { }
        public override System.Guid GetDefaultUID() { }
        public override string ToString() { }
    }
}
namespace JetBrains.ReSharper.LiveTemplates.Asp.FilenameSelectors
{
    
    public class CodebehindSelector : JetBrains.ReSharper.Feature.Services.LiveTemplates.FileTemplates.ISectionFilenameSelector
    {
        public string Id { get; }
        public string Name { get; }
        public JetBrains.ReSharper.Feature.Services.LiveTemplates.FileTemplates.ISectionLocationAutomation CreateAutomation(JetBrains.DataFlow.Lifetime lifetime, string selectorConfig, JetBrains.ReSharper.Feature.Services.LiveTemplates.FileTemplates.ITemplateSectionAutomation parentSection) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.FileTemplates.SuggestedSectionFile> SuggestFilenames(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint> mainScopePoints, JetBrains.ProjectModel.IProjectFolder mainFolder, JetBrains.ProjectModel.IProjectFile mainFile, string config) { }
        public class CodebehindSelectorAutomation : JetBrains.ReSharper.Feature.Services.LiveTemplates.FileTemplates.SectionLocationAutomationBase
        {
            public CodebehindSelectorAutomation(JetBrains.DataFlow.Lifetime lifetime) { }
        }
    }
}
namespace JetBrains.ReSharper.LiveTemplates.Asp.Macros
{
    
    public class AspImpl : JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroImplementationScopeProviderBase
    {
        public AspImpl() { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Asp.AspLanguage))]
    public class AspMacroUtil : JetBrains.ReSharper.LiveTemplates.Html.Macros.HtmlMacroUtil
    {
        public AspMacroUtil(JetBrains.ReSharper.Psi.Asp.AspLanguage language) { }
        protected override System.Collections.Generic.IList<string> SuggestNamesForIdentifier(JetBrains.ReSharper.Psi.Tree.IIdentifier treeNode) { }
    }
    [JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroDefinitionAttribute("AspMasterpageContentGenerator", LongDescription="Generate content for masterpage content placeholders at the point where the varia" +
        "ble is evaluated", ShortDescription="ASP.NET Masterpage content generator")]
    public class AspMasterpageContentGeneratorMacroDef : JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.SimpleMacroDefinition
    {
        public override string GetPlaceholder(JetBrains.DocumentModel.IDocument document, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.IMacroParameterValue> parameters) { }
    }
    [JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroImplementationAttribute(Definition=typeof(JetBrains.ReSharper.LiveTemplates.Asp.Macros.AspMasterpageContentGeneratorMacroDef))]
    public class AspMasterpageContentGeneratorMacroImpl : JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.Implementations.GeneratorMacro
    {
        protected override string CommandName { get; }
        protected override JetBrains.ReSharper.Psi.PsiLanguageType Language { get; }
        protected override string WorkflowKind { get; }
    }
    [JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroDefinitionAttribute("AspMvcAction", LongDescription="Show completion list with available ASP.NET MVC Actions at the point where the va" +
        "riable is evaluated", ShortDescription="ASP.NET MVC Action")]
    public class AspMvcActionMacroDef : JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.SimpleMacroDefinition { }
    [JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroImplementationAttribute(Definition=typeof(JetBrains.ReSharper.LiveTemplates.Asp.Macros.AspMvcActionMacroDef))]
    public class AspMvcActionMacroImpl : JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.SimpleMacroImplementation
    {
        public override JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.HotspotItems GetLookupItems(JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext context) { }
    }
    [JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroDefinitionAttribute("AspMvcController", LongDescription="Show completion list with available ASP.NET MVC Controllers at the point where th" +
        "e variable is evaluated", ShortDescription="ASP.NET MVC Controller")]
    public class AspMvcControllerMacroDef : JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.SimpleMacroDefinition { }
    [JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroImplementationAttribute(Definition=typeof(JetBrains.ReSharper.LiveTemplates.Asp.Macros.AspMvcControllerMacroDef))]
    public class AspMvcControllerMacroImpl : JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.SimpleMacroImplementation
    {
        public override JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.HotspotItems GetLookupItems(JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext context) { }
    }
    [JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroDefinitionAttribute("runAtServer", LongDescription="Insert runat=\"server\" if server-side tag selected", ShortDescription="Insert runat=\"server\" if server-side tag selected")]
    public class RunAtServerMacroDef : JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.SimpleMacroDefinition { }
    [JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroImplementationAttribute(Definition=typeof(JetBrains.ReSharper.LiveTemplates.Asp.Macros.RunAtServerMacroDef))]
    public class RunAtServerMacroImpl : JetBrains.ReSharper.LiveTemplates.Html.Macros.HtmlMacroImplBase<JetBrains.ReSharper.Psi.Asp.AspLanguage, JetBrains.ReSharper.Psi.Asp.Tree.IAspFile>
    {
        public RunAtServerMacroImpl() { }
        protected override System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem> GetSuggestedNames(JetBrains.ReSharper.Psi.Asp.Tree.IAspFile file, JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext context) { }
    }
    [JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroImplementationAttribute(Definition=typeof(JetBrains.ReSharper.LiveTemplates.Html.Macros.SuggestTagNameMacroDef), ScopeProvider=typeof(JetBrains.ReSharper.LiveTemplates.Asp.Macros.AspImpl))]
    public class SuggestTagNameMacroImpl : JetBrains.ReSharper.LiveTemplates.Html.Macros.SuggestTagNameMacroBase
    {
        public override System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem> GetSuggestedNames(JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext context) { }
    }
}