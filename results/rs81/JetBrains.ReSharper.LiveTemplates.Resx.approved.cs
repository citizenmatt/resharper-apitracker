[assembly: JetBrains.UI.Icons.CompiledIcons.CompiledIconsPackAttribute(IconNames=new string[] {
        "ScopeResx"}, IconPackResourceIdentification="JetBrains.ReSharper.LiveTemplates.Resx;component/resources/LiveTemplatesResx/Them" +
    "edIcons.LiveTemplatesResx.Generated.Xaml")]
[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]
[assembly: System.Windows.Markup.XmlnsDefinitionAttribute("urn:shemas-jetbrains-com:ui-application-icons-live-templates-resx", "JetBrains.ReSharper.LiveTemplates.Resx.Resources")]

namespace JetBrains.ReSharper.LiveTemplates.Resx
{
    
    public class InResxDatatag : JetBrains.ReSharper.LiveTemplates.Resx.InResxFile
    {
        public override string PresentableShortName { get; }
        public override System.Guid GetDefaultUID() { }
        public override string ToString() { }
    }
    public class InResxFile : JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.InAnyLanguageFile, JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.IMainScopePoint, JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint
    {
        public override string PresentableShortName { get; }
        public string QuickListTitle { get; }
        public System.Guid QuickListUID { get; }
        public override JetBrains.ReSharper.Psi.PsiLanguageType RelatedLanguage { get; }
        public override System.Guid GetDefaultUID() { }
        protected override System.Collections.Generic.IEnumerable<string> GetExtensions() { }
        public override string ToString() { }
    }
    public class InResxRoot : JetBrains.ReSharper.LiveTemplates.Resx.InResxFile
    {
        public override string PresentableShortName { get; }
        public override System.Guid GetDefaultUID() { }
        public override string ToString() { }
    }
    [JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ScopeCategoryUIProviderAttribute(Priority=-50D)]
    public class ResxScopeCategoryUIProvider : JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ScopeCategoryUIProvider
    {
        public ResxScopeCategoryUIProvider() { }
        public override string CategoryCaption { get; }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint> BuildAllPoints() { }
        public override string Present(JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint point) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class ResxScopeProvider : JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ScopeProvider
    {
        public ResxScopeProvider() { }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint> ProvideScopePoints(JetBrains.ReSharper.Feature.Services.LiveTemplates.Context.TemplateAcceptanceContext context) { }
    }
    public class ResxTemplateContext : JetBrains.ReSharper.Feature.Services.LiveTemplates.Context.TemplateContext
    {
        public const string ATTRIBUTE_NAME = "type";
        public readonly JetBrains.ReSharper.LiveTemplates.Resx.ResxTemplateContextType ContextType;
        public const string TAG_NAME = "ResxContext";
        public ResxTemplateContext(JetBrains.ReSharper.LiveTemplates.Resx.ResxTemplateContextType contextType) { }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint> ScopePoints { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.LiveTemplates.Resx.ResxTemplateContext ReadFromXml(System.Xml.XmlElement element) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class ResxTemplateContextFactory : JetBrains.ReSharper.Feature.Services.LiveTemplates.Context.ITemplateContextFactory
    {
        public JetBrains.ReSharper.Feature.Services.LiveTemplates.Context.ITemplateContext ReadFromXml(System.Xml.XmlElement element) { }
    }
    public enum ResxTemplateContextType
    {
        EVERYWHERE = 0,
        ROOT_EXPECTED = 1,
        DATATAG_EXPECTED = 2,
    }
    public class ResxTemplateContextUI : JetBrains.UI.CommonControls.SafeUserControl, JetBrains.ReSharper.Feature.Services.LiveTemplates.Context.ITemplateContextUI, System.IDisposable
    {
        public ResxTemplateContextUI(JetBrains.UI.Application.IUIApplication environment) { }
        public System.Windows.Forms.Control ContextOptionsUI { get; }
        public JetBrains.ReSharper.LiveTemplates.Resx.ResxTemplateContextType ContextType { get; set; }
        public JetBrains.ReSharper.Feature.Services.LiveTemplates.Context.ITemplateContext TemplateContext { get; }
        public string Title { get; }
        public bool Valid { get; }
        public event System.EventHandler ValidChanged;
        protected override void Dispose(bool disposing) { }
    }
}
namespace JetBrains.ReSharper.LiveTemplates.Resx.Resources
{
    
    public sealed class LiveTemplatesResxThemedIcons
    {
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.LiveTemplates.Resx;component/resources/LiveTemplatesResx/Them" +
            "edIcons.LiveTemplatesResx.Generated.Xaml", 0, "ScopeResx")]
        public sealed class ScopeResx : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
    }
}