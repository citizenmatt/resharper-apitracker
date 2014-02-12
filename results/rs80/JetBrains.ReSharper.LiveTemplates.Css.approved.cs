[assembly: JetBrains.TextControl.DocumentMarkup.RegisterHighlighterAttribute("ReSharper Template Editor CSS Keyword", "{900f41c1-451b-4a06-96eb-d782c1b1f6ac}", DarkForegroundColor="LightSkyBlue", ForegroundColor="Blue", Layer=2000, VSPriority=40)]
[assembly: JetBrains.TextControl.DocumentMarkup.RegisterHighlighterAttribute("ReSharper Template Editor CSS Comment", "{3645cd13-a483-479f-a6fc-1ab23fac67d8}", DarkForegroundColor="LightGreen", ForegroundColor="Green", Layer=2000, VSPriority=40)]
[assembly: JetBrains.UI.Icons.CompiledIcons.CompiledIconsPackAttribute(IconNames=new string[] {
        "ScopeCss"}, IconPackResourceIdentification="JetBrains.ReSharper.LiveTemplates.Css;component/resources/LiveTemplatesCss/Themed" +
    "Icons.LiveTemplatesCss.Generated.Xaml")]
[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]
[assembly: System.Windows.Markup.XmlnsDefinitionAttribute("urn:shemas-jetbrains-com:ui-application-icons-live-templates-css", "JetBrains.ReSharper.LiveTemplates.Css.Resources")]

namespace JetBrains.ReSharper.LiveTemplates.Css.LiveTemplates
{
    
    [JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ScopeCategoryUIProviderAttribute()]
    public class CssScopeCategoryUIProvider : JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ScopeCategoryUIProvider
    {
        public CssScopeCategoryUIProvider() { }
        public override string CategoryCaption { get; }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint> BuildAllPoints() { }
        public override string Present(JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint point) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class CssScopeProvider : JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ScopeProvider
    {
        public CssScopeProvider() { }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint> ProvideScopePoints(JetBrains.ReSharper.Feature.Services.LiveTemplates.Context.TemplateAcceptanceContext context) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Css.CssLanguage))]
    public class CssTemplateHighlightingProvider : JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.TemplateHighlightingProvider
    {
        public const string CommentAttribute = "ReSharper Template Editor CSS Comment";
        public const string KeywordAttribute = "ReSharper Template Editor CSS Keyword";
        public override string GetHighlightingAttributeId(JetBrains.ReSharper.Psi.Parsing.TokenNodeType tokenType) { }
    }
    public class InCssExpression : JetBrains.ReSharper.LiveTemplates.Css.LiveTemplates.InCssFile
    {
        public override string PresentableShortName { get; }
        public override System.Guid GetDefaultUID() { }
        public override string ToString() { }
    }
    public class InCssFile : JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.InAnyLanguageFile, JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.IMainScopePoint, JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint
    {
        public override string PresentableShortName { get; }
        public string QuickListTitle { get; }
        public System.Guid QuickListUID { get; }
        public override JetBrains.ReSharper.Psi.PsiLanguageType RelatedLanguage { get; }
        public override System.Guid GetDefaultUID() { }
        protected override System.Collections.Generic.IEnumerable<string> GetExtensions() { }
        public override string ToString() { }
    }
    public class InCssStatement : JetBrains.ReSharper.LiveTemplates.Css.LiveTemplates.InCssExpression
    {
        public override string PresentableShortName { get; }
        public override System.Guid GetDefaultUID() { }
        public override string ToString() { }
    }
}
namespace JetBrains.ReSharper.LiveTemplates.Css.Resources
{
    
    public sealed class LiveTemplatesCssThemedIcons
    {
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.LiveTemplates.Css;component/resources/LiveTemplatesCss/Themed" +
            "Icons.LiveTemplatesCss.Generated.Xaml", 0, "ScopeCss")]
        public sealed class ScopeCss : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
    }
}