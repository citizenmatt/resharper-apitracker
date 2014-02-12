[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]

namespace JetBrains.ReSharper.LiveTemplates.Razor
{
    
    public class InRazorAttribute : JetBrains.ReSharper.LiveTemplates.Razor.InRazorFile
    {
        public InRazorAttribute(JetBrains.ReSharper.Psi.Razor.RazorLanguage language = null, string prefix = null) { }
        public override string PresentableShortName { get; }
        public override System.Guid GetDefaultUID() { }
        public override JetBrains.ReSharper.LiveTemplates.Razor.InRazorFile NewInstance(JetBrains.ReSharper.Psi.Razor.RazorLanguage language) { }
        public override string ToString() { }
    }
    public class InRazorFile : JetBrains.ReSharper.LiveTemplates.Html.InHtmlLikeFile, JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.IMainScopePoint, JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint
    {
        public const string AttrLanguage = "language";
        public InRazorFile(JetBrains.ReSharper.Psi.Razor.RazorLanguage language = null, string prefix = null) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Psi.Razor.RazorLanguage CodeBehindLanguage { get; }
        protected string LangString { get; }
        public override string PresentableShortName { get; }
        public string QuickListTitle { get; }
        public System.Guid QuickListUID { get; }
        public override JetBrains.ReSharper.Psi.PsiLanguageType RelatedLanguage { get; }
        public override System.Collections.Generic.IEnumerable<JetBrains.Util.Pair<string, string>> EnumerateCustomProperties() { }
        public override System.Guid GetDefaultUID() { }
        protected override System.Collections.Generic.IEnumerable<string> GetExtensions() { }
        public override bool IsSubsetOf(JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint other) { }
        public virtual JetBrains.ReSharper.LiveTemplates.Razor.InRazorFile NewInstance(JetBrains.ReSharper.Psi.Razor.RazorLanguage language) { }
        public override string ToString() { }
        public override System.Xml.XmlElement WriteToXml(System.Xml.XmlElement element) { }
    }
    public class InRazorTag : JetBrains.ReSharper.LiveTemplates.Razor.InRazorFile
    {
        public InRazorTag(JetBrains.ReSharper.Psi.Razor.RazorLanguage language = null, string prefix = null) { }
        public override string PresentableShortName { get; }
        public override System.Guid GetDefaultUID() { }
        public override JetBrains.ReSharper.LiveTemplates.Razor.InRazorFile NewInstance(JetBrains.ReSharper.Psi.Razor.RazorLanguage language) { }
        public override string ToString() { }
    }
    [JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ScopeCategoryUIProviderAttribute(Priority=28D)]
    public class RazorScopeCategoryUIProvider : JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ScopeCategoryUIProvider
    {
        public RazorScopeCategoryUIProvider() { }
        public override string CategoryCaption { get; }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint> BuildAllPoints() { }
        public override JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ScopeOptionsUIBase CreateUI(JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint point) { }
        public override bool HaveOptionsUIFor(JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint point) { }
        public override string Present(JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint point) { }
    }
    public class RazorScopeConfig : JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ScopeOptionsUIBase, System.Windows.Markup.IComponentConnector
    {
        public RazorScopeConfig(JetBrains.ReSharper.LiveTemplates.Razor.InRazorFile razorPoint) { }
        public override void Done() { }
        public void InitializeComponent() { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class RazorScopeProvider : JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.IScopeProvider
    {
        public RazorScopeProvider() { }
        public JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint CreateScope(System.Guid scopeGuid, string typeName, System.Collections.Generic.IEnumerable<JetBrains.Util.Pair<string, string>> customProperties) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint> ProvideScopePoints(JetBrains.ReSharper.Feature.Services.LiveTemplates.Context.TemplateAcceptanceContext context) { }
        public JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint ReadFromXml(System.Xml.XmlElement scopeElement) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Razor.RazorLanguage))]
    public class RazorTemplateHighlightingProvider : JetBrains.ReSharper.LiveTemplates.Html.HtmlTemplateHighlightingProvider
    {
        public RazorTemplateHighlightingProvider(JetBrains.ReSharper.Psi.Razor.Parsing.IRazorTokenNodeTypes tokenNodeTypes) { }
    }
}