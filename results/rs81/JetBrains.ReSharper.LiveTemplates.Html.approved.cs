[assembly: JetBrains.TextControl.DocumentMarkup.RegisterHighlighterAttribute("ReSharper Template Editor HTML Tag", "{E4F2ECFD-0901-4CB1-9AFF-EB01FF532FCF}", DarkForegroundColor="LightSkyBlue", ForegroundColor="Blue", Layer=2000, VSPriority=40)]
[assembly: JetBrains.TextControl.DocumentMarkup.RegisterHighlighterAttribute("ReSharper Template Editor HTML Comment", "{A30A39DD-B71F-42EB-807F-239756FBED7C}", DarkForegroundColor="LightGreen", ForegroundColor="Green", Layer=2000, VSPriority=40)]
[assembly: JetBrains.TextControl.DocumentMarkup.RegisterHighlighterAttribute("ReSharper Template Editor HTML Attribute", "{BBCA5F13-5230-42CD-B522-E520ECD8A3FA}", DarkForegroundColor="Violet", ForegroundColor="Purple", Layer=2000, VSPriority=40)]
[assembly: JetBrains.UI.Icons.CompiledIcons.CompiledIconsPackAttribute(IconNames=new string[] {
        "ScopeHtmlLike",
        "ScopeHtml"}, IconPackResourceIdentification="JetBrains.ReSharper.LiveTemplates.Html;component/resources/LiveTemplatesHtml/Them" +
    "edIcons.LiveTemplatesHtml.Generated.Xaml")]
[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]
[assembly: System.Windows.Markup.XmlnsDefinitionAttribute("urn:shemas-jetbrains-com:ui-application-icons-live-templates-html", "JetBrains.ReSharper.LiveTemplates.Html.Resources")]

namespace JetBrains.ReSharper.LiveTemplates.Html
{
    
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Html.HtmlLanguage))]
    public class HtmlLanguageCaseProvider : JetBrains.ReSharper.Feature.Services.LiveTemplates.LiveTemplates.LanguageCaseProvider
    {
        public override bool IsCaseSensitive() { }
    }
    [JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ScopeCategoryUIProviderAttribute(Priority=30D)]
    public class HtmlLikeScopeCategoryUIProvider : JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ScopeCategoryUIProvider
    {
        public HtmlLikeScopeCategoryUIProvider() { }
        public override string CategoryCaption { get; }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint> BuildAllPoints() { }
        public override string Present(JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint point) { }
    }
    [JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ScopeCategoryUIProviderAttribute(Priority=29D)]
    public class HtmlScopeCategoryUIProvider : JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ScopeCategoryUIProvider
    {
        public HtmlScopeCategoryUIProvider() { }
        public override string CategoryCaption { get; }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint> BuildAllPoints() { }
        public override string Present(JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint point) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class HtmlScopeProvider : JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ScopeProvider
    {
        public HtmlScopeProvider() { }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint> ProvideScopePoints(JetBrains.ReSharper.Feature.Services.LiveTemplates.Context.TemplateAcceptanceContext context) { }
    }
    public class HtmlTemplateContext : JetBrains.ReSharper.Feature.Services.LiveTemplates.Context.TemplateContext
    {
        public readonly JetBrains.ReSharper.LiveTemplates.Html.HtmlTemplateContextType ContextType;
        public readonly JetBrains.ReSharper.Psi.PsiLanguageType LimitToLanguage;
        public HtmlTemplateContext(JetBrains.ReSharper.LiveTemplates.Html.HtmlTemplateContextType contextType, JetBrains.ReSharper.Psi.PsiLanguageType language = null) { }
        public bool IsSealed { get; }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint> ScopePoints { get; }
        public static JetBrains.ReSharper.Feature.Services.LiveTemplates.Context.ITemplateContext ReadFromXml(System.Xml.XmlElement element) { }
    }
    public class HtmlTemplateContextAcceptor : JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ScopedTemplateAcceptorBase
    {
        public HtmlTemplateContextAcceptor(JetBrains.ReSharper.Feature.Services.LiveTemplates.Context.TemplateAcceptanceContext context) { }
        public override bool Accepts(JetBrains.ReSharper.Feature.Services.LiveTemplates.Context.ITemplateContext templateContext) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class HtmlTemplateContextFactory : JetBrains.ReSharper.Feature.Services.LiveTemplates.Context.ITemplateContextFactory
    {
        public JetBrains.ReSharper.Feature.Services.LiveTemplates.Context.ITemplateContext ReadFromXml(System.Xml.XmlElement element) { }
    }
    public enum HtmlTemplateContextType
    {
        EVERYWHERE = 0,
        TAG_EXPECTED = 1,
        ATTRIBUTE_EXPECTED = 2,
    }
    public class HtmlTemplateContextUI : JetBrains.UI.CommonControls.SafeUserControl, JetBrains.ReSharper.Feature.Services.LiveTemplates.Context.ITemplateContextUI, System.IDisposable
    {
        public HtmlTemplateContextUI(JetBrains.UI.Application.IUIApplication environment) { }
        public System.Windows.Forms.Control ContextOptionsUI { get; }
        public JetBrains.ReSharper.LiveTemplates.Html.HtmlTemplateContextType ContextType { get; set; }
        public JetBrains.ReSharper.Feature.Services.LiveTemplates.Context.ITemplateContext TemplateContext { get; }
        public string Title { get; }
        public bool Valid { get; }
        public event System.EventHandler ValidChanged;
        protected override void Dispose(bool disposing) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Html.HtmlLanguage))]
    public class HtmlTemplateFormatter : JetBrains.ReSharper.Feature.Services.LiveTemplates.Formatting.ITemplateFormatter
    {
        public bool SupportsShorteningQualifiedReferences { get; }
        public void BeforeFormatting(JetBrains.DocumentModel.DocumentRange documentRange, JetBrains.ProjectModel.ISolution solution) { }
        public void ShortenQualifiedReferences(JetBrains.DocumentModel.DocumentRange documentRange, JetBrains.ProjectModel.ISolution solution) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Html.HtmlLanguage))]
    public class HtmlTemplateHighlightingProvider : JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.TemplateHighlightingProvider
    {
        public const string AttrAttribute = "ReSharper Template Editor HTML Attribute";
        public const string CommentAttribute = "ReSharper Template Editor HTML Comment";
        protected readonly System.Collections.Generic.IDictionary<JetBrains.ReSharper.Psi.Parsing.TokenNodeType, string> HighlightingMap;
        public const string TagAttribute = "ReSharper Template Editor HTML Tag";
        public HtmlTemplateHighlightingProvider(JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes tokenNodeTypes) { }
        public override string GetHighlightingAttributeId(JetBrains.ReSharper.Psi.Parsing.TokenNodeType tokenType) { }
    }
    public class InHtmlAttribute : JetBrains.ReSharper.LiveTemplates.Html.InHtmlFile
    {
        public InHtmlAttribute() { }
        public InHtmlAttribute(string prefix) { }
        public override string PresentableShortName { get; }
        public override System.Guid GetDefaultUID() { }
        public override string ToString() { }
    }
    public class InHtmlFile : JetBrains.ReSharper.LiveTemplates.Html.InHtmlLikeFile, JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.IMainScopePoint, JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint
    {
        public InHtmlFile() { }
        public InHtmlFile(string prefix) { }
        public override string PresentableShortName { get; }
        public string QuickListTitle { get; }
        public System.Guid QuickListUID { get; }
        public override System.Guid GetDefaultUID() { }
        protected override System.Collections.Generic.IEnumerable<string> GetExtensions() { }
        public override string ToString() { }
    }
    public class InHtmlLikeAttribute : JetBrains.ReSharper.LiveTemplates.Html.InHtmlLikeFile
    {
        public InHtmlLikeAttribute() { }
        public InHtmlLikeAttribute(string prefix) { }
        public override string PresentableShortName { get; }
        public override System.Guid GetDefaultUID() { }
        public override string ToString() { }
    }
    public class InHtmlLikeFile : JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.InAnyLanguageFile
    {
        public InHtmlLikeFile() { }
        public InHtmlLikeFile(string prefix) { }
        public override string PresentableShortName { get; }
        public override JetBrains.ReSharper.Psi.PsiLanguageType RelatedLanguage { get; }
        public override string CalcPrefix(JetBrains.DocumentModel.IDocument document, int caretOffset) { }
        public override System.Guid GetDefaultUID() { }
        public override string ToString() { }
    }
    public class InHtmlLikeTag : JetBrains.ReSharper.LiveTemplates.Html.InHtmlLikeFile
    {
        public InHtmlLikeTag() { }
        public InHtmlLikeTag(string prefix) { }
        public override string PresentableShortName { get; }
        public override string CalcPrefix(JetBrains.DocumentModel.IDocument document, int caretOffset) { }
        public override System.Guid GetDefaultUID() { }
        public override string ToString() { }
    }
    public class InHtmlTag : JetBrains.ReSharper.LiveTemplates.Html.InHtmlFile
    {
        public InHtmlTag() { }
        public InHtmlTag(string prefix) { }
        public override string PresentableShortName { get; }
        public override string CalcPrefix(JetBrains.DocumentModel.IDocument document, int caretOffset) { }
        public override System.Guid GetDefaultUID() { }
        public override string ToString() { }
    }
}
namespace JetBrains.ReSharper.LiveTemplates.Html.Macros
{
    
    public class HtmlImpl : JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroImplementationScopeProviderBase
    {
        public HtmlImpl() { }
    }
    public abstract class HtmlMacroImplBase<TLanguage, TFile> : JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.SimpleMacroImplementation
        where TLanguage : JetBrains.ReSharper.Psi.Html.HtmlLanguage
        where TFile :  class, JetBrains.ReSharper.Psi.Html.Tree.IHtmlFile
    {
        public override JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.HotspotItems GetLookupItems(JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext context) { }
        protected abstract System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem> GetSuggestedNames(TFile file, JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext context);
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Html.HtmlLanguage))]
    public class HtmlMacroUtil : JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroUtilBase
    {
        public HtmlMacroUtil(JetBrains.ReSharper.Psi.Html.HtmlLanguage language) { }
        public override JetBrains.ReSharper.Psi.IDeclaredElement AsDeclaredElement(string text, JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext context) { }
        protected override JetBrains.ReSharper.Psi.Tree.IExpression CreateExpression(JetBrains.ReSharper.Psi.Modules.IPsiModule module, string text) { }
        public override JetBrains.ReSharper.Psi.IDeclaredElement CreateVariableDeclaredElement(JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext hotspotContext) { }
        protected override System.Collections.Generic.IList<JetBrains.ReSharper.Psi.IType> GetExpectedConcreteTypes(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public override void SortNames(JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext context, System.Collections.Generic.List<string> names) { }
        protected override System.Collections.Generic.IList<string> SuggestNamesForIdentifier(JetBrains.ReSharper.Psi.Tree.IIdentifier treeNode) { }
    }
    [JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroDefinitionAttribute("suggestAttributeNameByTag", LongDescription="Suggests attribute name used in the same tags in current document", ShortDescription="Suggests attribute name by tag")]
    public class SuggestAttributeNameByTagMacroDef : JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.SimpleMacroDefinition { }
    [JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroImplementationAttribute(Definition=typeof(JetBrains.ReSharper.LiveTemplates.Html.Macros.SuggestAttributeNameByTagMacroDef))]
    public class SuggestAttributeNameByTagMacroImpl : JetBrains.ReSharper.LiveTemplates.Html.Macros.HtmlMacroImplBase<JetBrains.ReSharper.Psi.Html.HtmlLanguage, JetBrains.ReSharper.Psi.Html.Tree.IHtmlFile>
    {
        protected override System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem> GetSuggestedNames(JetBrains.ReSharper.Psi.Html.Tree.IHtmlFile file, JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext context) { }
    }
    [JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroDefinitionAttribute("suggestAttributeValue", LongDescription="Suggest attribute value for current html tag attribute", ShortDescription="Suggest attribute value")]
    public class SuggestAttributeValueMacroDef : JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.SimpleMacroDefinition { }
    [JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroImplementationAttribute(Definition=typeof(JetBrains.ReSharper.LiveTemplates.Html.Macros.SuggestAttributeValueMacroDef))]
    public class SuggestAttributeValueMacroImpl : JetBrains.ReSharper.LiveTemplates.Html.Macros.HtmlMacroImplBase<JetBrains.ReSharper.Psi.Html.HtmlLanguage, JetBrains.ReSharper.Psi.Html.Tree.IHtmlFile>
    {
        protected override System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem> GetSuggestedNames(JetBrains.ReSharper.Psi.Html.Tree.IHtmlFile file, JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext context) { }
    }
    public abstract class SuggestTagNameMacroBase : JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.SimpleMacroImplementation
    {
        public override JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.HotspotItems GetLookupItems(JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext context) { }
        public abstract System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem> GetSuggestedNames(JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext context);
    }
    [JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroDefinitionAttribute("suggestTagName", LongDescription="Suggest tag name used in current document", ShortDescription="Suggest tag name")]
    public class SuggestTagNameMacroDef : JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.SimpleMacroDefinition { }
    [JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroImplementationAttribute(Definition=typeof(JetBrains.ReSharper.LiveTemplates.Html.Macros.SuggestTagNameMacroDef), ScopeProvider=typeof(JetBrains.ReSharper.LiveTemplates.Html.Macros.HtmlImpl))]
    public class SuggestTagNameMacroImpl : JetBrains.ReSharper.LiveTemplates.Html.Macros.SuggestTagNameMacroBase
    {
        public override System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem> GetSuggestedNames(JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext context) { }
    }
}
namespace JetBrains.ReSharper.LiveTemplates.Html.Resources
{
    
    public sealed class LiveTemplatesHtmlThemedIcons
    {
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.LiveTemplates.Html;component/resources/LiveTemplatesHtml/Them" +
            "edIcons.LiveTemplatesHtml.Generated.Xaml", 1, "ScopeHtml")]
        public sealed class ScopeHtml : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.LiveTemplates.Html;component/resources/LiveTemplatesHtml/Them" +
            "edIcons.LiveTemplatesHtml.Generated.Xaml", 0, "ScopeHtmlLike")]
        public sealed class ScopeHtmlLike : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
    }
}