[assembly: JetBrains.TextControl.DocumentMarkup.RegisterHighlighterAttribute("ReSharper Template Editor JavaScript Comment", "{6ceadc67-0748-43aa-a42c-7c48138db090}", DarkForegroundColor="LightGreen", ForegroundColor="Green", Layer=2000, VSPriority=40)]
[assembly: JetBrains.TextControl.DocumentMarkup.RegisterHighlighterAttribute("ReSharper Template Editor JavaScript Keyword", "{ddc3f972-2827-4778-95e1-8f07041906c3}", DarkForegroundColor="LightSkyBlue", ForegroundColor="Blue", Layer=2000, VSPriority=40)]
[assembly: JetBrains.UI.Icons.CompiledIcons.CompiledIconsPackAttribute(IconNames=new string[] {
        "ScopeJS"}, IconPackResourceIdentification="JetBrains.ReSharper.LiveTemplates.JavaScript;component/resources/LiveTemplatesJav" +
    "aScripts/ThemedIcons.LiveTemplatesJavaScripts.Generated.Xaml")]
[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]
[assembly: System.Windows.Markup.XmlnsDefinitionAttribute("urn:shemas-jetbrains-com:ui-application-icons-live-templates-java-scripts", "JetBrains.ReSharper.LiveTemplates.JavaScript.Resources")]

namespace JetBrains.ReSharper.LiveTemplates.JavaScript.LiveTemplates
{
    
    public class InJavaScriptExpression : JetBrains.ReSharper.LiveTemplates.JavaScript.LiveTemplates.InJavaScriptFile
    {
        public override string PresentableShortName { get; }
        public override System.Guid GetDefaultUID() { }
        public override string ToString() { }
    }
    public class InJavaScriptFile : JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.InAnyLanguageFile, JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.IMainScopePoint, JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint
    {
        public override string PresentableShortName { get; }
        public string QuickListTitle { get; }
        public System.Guid QuickListUID { get; }
        public override JetBrains.ReSharper.Psi.PsiLanguageType RelatedLanguage { get; }
        public override System.Guid GetDefaultUID() { }
        protected override System.Collections.Generic.IEnumerable<string> GetExtensions() { }
        public override string ToString() { }
    }
    public class InJavaScriptStatement : JetBrains.ReSharper.LiveTemplates.JavaScript.LiveTemplates.InJavaScriptExpression
    {
        public override string PresentableShortName { get; }
        public override System.Guid GetDefaultUID() { }
        public override string ToString() { }
    }
    [JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ScopeCategoryUIProviderAttribute()]
    public class JavaScriptScopeCategoryUIProvider : JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ScopeCategoryUIProvider
    {
        public JavaScriptScopeCategoryUIProvider() { }
        public override string CategoryCaption { get; }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint> BuildAllPoints() { }
        public override string Present(JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint point) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class JavaScriptScopeProvider : JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ScopeProvider
    {
        public JavaScriptScopeProvider() { }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint> ProvideScopePoints(JetBrains.ReSharper.Feature.Services.LiveTemplates.Context.TemplateAcceptanceContext context) { }
    }
    public class JavaScriptTemplateContext : JetBrains.ReSharper.Feature.Services.LiveTemplates.Context.TemplateContext
    {
        public readonly JetBrains.ReSharper.LiveTemplates.JavaScript.LiveTemplates.JavaScriptTemplateContextType ContextType;
        public JavaScriptTemplateContext(JetBrains.ReSharper.LiveTemplates.JavaScript.LiveTemplates.JavaScriptTemplateContextType contextType) { }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint> ScopePoints { get; }
        public static JetBrains.ReSharper.Feature.Services.LiveTemplates.Context.ITemplateContext ReadFromXml(System.Xml.XmlElement element) { }
        public override string ToString() { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class JavaScriptTemplateContextFactory : JetBrains.ReSharper.Feature.Services.LiveTemplates.Context.ITemplateContextFactory
    {
        public JetBrains.ReSharper.Feature.Services.LiveTemplates.Context.ITemplateContext ReadFromXml(System.Xml.XmlElement element) { }
    }
    [System.FlagsAttribute()]
    public enum JavaScriptTemplateContextType
    {
        Everywhere = 1,
        StatementExpected = 2,
        ExpressionExpected = 4,
    }
    public class JavaScriptTemplateContextUI : JetBrains.UI.CommonControls.SafeUserControl, JetBrains.ReSharper.Feature.Services.LiveTemplates.Context.ITemplateContextUI, System.IDisposable
    {
        public JavaScriptTemplateContextUI(JetBrains.UI.Application.IUIApplication environment) { }
        public System.Windows.Forms.Control ContextOptionsUI { get; }
        public JetBrains.ReSharper.LiveTemplates.JavaScript.LiveTemplates.JavaScriptTemplateContextType ContextType { get; set; }
        public JetBrains.ReSharper.Feature.Services.LiveTemplates.Context.ITemplateContext TemplateContext { get; }
        public string Title { get; }
        public bool Valid { get; }
        public event System.EventHandler ValidChanged;
        protected override void Dispose(bool disposing) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.JavaScript.LanguageImpl.JavaScriptLanguage))]
    public class JavaScriptTemplateHighlightingProvider : JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.TemplateHighlightingProvider
    {
        public const string CommentAttribute = "ReSharper Template Editor JavaScript Comment";
        public const string KeywordAttribute = "ReSharper Template Editor JavaScript Keyword";
        public override string GetHighlightingAttributeId(JetBrains.ReSharper.Psi.Parsing.TokenNodeType tokenType) { }
    }
}
namespace JetBrains.ReSharper.LiveTemplates.JavaScript.Macros
{
    
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.JavaScript.LanguageImpl.JavaScriptLanguage))]
    public class JavaScriptMacroUtil : JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroUtilBase
    {
        public JavaScriptMacroUtil(JetBrains.ReSharper.Psi.JavaScript.LanguageImpl.JavaScriptLanguage language) { }
        public override JetBrains.ReSharper.Psi.IDeclaredElement AsDeclaredElement(string text, JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext context) { }
        protected override JetBrains.ReSharper.Psi.Tree.IExpression CreateExpression(JetBrains.ReSharper.Psi.Modules.IPsiModule module, string text) { }
        public override JetBrains.ReSharper.Psi.IDeclaredElement CreateVariableDeclaredElement(JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext hotspotContext) { }
        public override System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.IType> GetElementTypes(JetBrains.ReSharper.Psi.Tree.IExpression collectionExpression) { }
        protected override System.Collections.Generic.IList<JetBrains.ReSharper.Psi.ExpectedTypes.ExpectedType> GetExpectedTypes(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public override System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.IType> GetKeyTypes(JetBrains.ReSharper.Psi.Tree.IExpression collectionExpression) { }
        public override System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.IType> GetValueTypes(JetBrains.ReSharper.Psi.Tree.IExpression collectionExpression) { }
        public override void SortNames(JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext context, System.Collections.Generic.List<string> names) { }
        protected override System.Collections.Generic.IList<string> SuggestNamesForIdentifier(JetBrains.ReSharper.Psi.Tree.IIdentifier treeNode) { }
        public override System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem> SuggestVariableTypes(JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext context) { }
    }
}
namespace JetBrains.ReSharper.LiveTemplates.JavaScript.Resources
{
    
    public sealed class LiveTemplatesJavaScriptsThemedIcons
    {
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.LiveTemplates.JavaScript;component/resources/LiveTemplatesJav" +
            "aScripts/ThemedIcons.LiveTemplatesJavaScripts.Generated.Xaml", 0, "ScopeJS")]
        public sealed class ScopeJS : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
    }
}