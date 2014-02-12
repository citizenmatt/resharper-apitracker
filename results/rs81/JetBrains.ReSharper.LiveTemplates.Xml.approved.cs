[assembly: JetBrains.UI.Icons.CompiledIcons.CompiledIconsPackAttribute(IconNames=new string[] {
        "ScopeXml"}, IconPackResourceIdentification="JetBrains.ReSharper.LiveTemplates.Xml;component/resources/LiveTemplatesXml/Themed" +
    "Icons.LiveTemplatesXml.Generated.Xaml")]
[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]
[assembly: System.Windows.Markup.XmlnsDefinitionAttribute("urn:shemas-jetbrains-com:ui-application-icons-live-templates-xml", "JetBrains.ReSharper.LiveTemplates.Xml.Resources")]

namespace JetBrains.ReSharper.LiveTemplates.Xml
{
    
    public class InXmlAttribute : JetBrains.ReSharper.LiveTemplates.Xml.InXmlFile
    {
        public override string PresentableShortName { get; }
        public override System.Guid GetDefaultUID() { }
        public override string ToString() { }
    }
    public class InXmlFile : JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.InAnyLanguageFile, JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.IMainScopePoint, JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint
    {
        public override string PresentableShortName { get; }
        public string QuickListTitle { get; }
        public System.Guid QuickListUID { get; }
        public override JetBrains.ReSharper.Psi.PsiLanguageType RelatedLanguage { get; }
        public override System.Guid GetDefaultUID() { }
        protected override System.Collections.Generic.IEnumerable<string> GetExtensions() { }
        public override string ToString() { }
    }
    public class InXmlTag : JetBrains.ReSharper.LiveTemplates.Xml.InXmlFile
    {
        public override string PresentableShortName { get; }
        public override System.Guid GetDefaultUID() { }
        public override string ToString() { }
    }
    [JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ScopeCategoryUIProviderAttribute(Priority=70D)]
    public class XmlScopeCategoryUIProvider : JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ScopeCategoryUIProvider
    {
        public XmlScopeCategoryUIProvider() { }
        public override string CategoryCaption { get; }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint> BuildAllPoints() { }
        public override string Present(JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint point) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class XmlScopeProvider : JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ScopeProvider
    {
        public XmlScopeProvider() { }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint> ProvideScopePoints(JetBrains.ReSharper.Feature.Services.LiveTemplates.Context.TemplateAcceptanceContext context) { }
    }
    public class XmlTemplateContext : JetBrains.ReSharper.Feature.Services.LiveTemplates.Context.TemplateContext
    {
        public const string ATTRIBUTE_NAME = "type";
        public readonly JetBrains.ReSharper.LiveTemplates.Xml.XmlTemplateContextType ContextType;
        public const string TAG_NAME = "XMLContext";
        public XmlTemplateContext(JetBrains.ReSharper.LiveTemplates.Xml.XmlTemplateContextType contextType) { }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint> ScopePoints { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.LiveTemplates.Xml.XmlTemplateContext ReadFromXml(System.Xml.XmlElement element) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class XmlTemplateContextFactory : JetBrains.ReSharper.Feature.Services.LiveTemplates.Context.ITemplateContextFactory
    {
        public JetBrains.ReSharper.Feature.Services.LiveTemplates.Context.ITemplateContext ReadFromXml(System.Xml.XmlElement element) { }
    }
    public enum XmlTemplateContextType
    {
        EVERYWHERE = 0,
        TAG_EXPECTED = 1,
        ATTRIBUTE_EXPECTED = 2,
    }
    public class XmlTemplateContextUI : JetBrains.UI.CommonControls.SafeUserControl, JetBrains.ReSharper.Feature.Services.LiveTemplates.Context.ITemplateContextUI, System.IDisposable
    {
        public XmlTemplateContextUI([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.UI.Application.IUIApplication environment) { }
        public System.Windows.Forms.Control ContextOptionsUI { get; }
        public JetBrains.ReSharper.LiveTemplates.Xml.XmlTemplateContextType ContextType { get; set; }
        public JetBrains.ReSharper.Feature.Services.LiveTemplates.Context.ITemplateContext TemplateContext { get; }
        public string Title { get; }
        public bool Valid { get; }
        public event System.EventHandler ValidChanged;
        protected override void Dispose(bool disposing) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Xml.XmlLanguage))]
    public class XmlTemplateFormatter : JetBrains.ReSharper.Feature.Services.LiveTemplates.Formatting.ITemplateFormatter
    {
        public bool SupportsShorteningQualifiedReferences { get; }
        public void BeforeFormatting(JetBrains.DocumentModel.DocumentRange documentRange, JetBrains.ProjectModel.ISolution solution) { }
        public void ShortenQualifiedReferences(JetBrains.DocumentModel.DocumentRange documentRange, JetBrains.ProjectModel.ISolution solution) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Xml.XmlLanguage))]
    public class XmlTemplateHighlightingProvider : JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.TemplateHighlightingProvider
    {
        public XmlTemplateHighlightingProvider(JetBrains.ReSharper.Psi.Parsing.XmlTokenTypes xmlTokenTypes) { }
        public override string GetHighlightingAttributeId(JetBrains.ReSharper.Psi.Parsing.TokenNodeType tokenType) { }
    }
}
namespace JetBrains.ReSharper.LiveTemplates.Xml.Macros
{
    
    [JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroDefinitionAttribute("fullTagName", LongDescription="Inserts full name of containing tag", ShortDescription="Full tag name")]
    public class FullTagNameMacroDef : JetBrains.ReSharper.LiveTemplates.Xml.Macros.XmlTagMacroDefBase { }
    [JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroImplementationAttribute(Definition=typeof(JetBrains.ReSharper.LiveTemplates.Xml.Macros.FullTagNameMacroDef))]
    public class FullTagNameMacroImpl : JetBrains.ReSharper.LiveTemplates.Xml.Macros.XmlTagMacroImplBase
    {
        public FullTagNameMacroImpl(JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroParameterValueCollection arguments) { }
        public override string EvaluateQuickResult(JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext context) { }
    }
    [JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroImplementationAttribute(Definition=typeof(JetBrains.ReSharper.LiveTemplates.Xml.Macros.SuggestAttributeNameByTagMacroDef))]
    public class SuggestAttributeNameByTagMacro : JetBrains.ReSharper.LiveTemplates.Xml.Macros.XmlMacroImpl
    {
        protected override System.Collections.Generic.ICollection<string> GetSuggestedNames(JetBrains.ReSharper.Psi.Xml.Tree.IXmlFile file, JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext context) { }
    }
    [JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroDefinitionAttribute("suggestXmlAttributeNameByTag", LongDescription="Suggests XML attribute name used in the same tags in current document", ShortDescription="Suggests XML attribute name by tag")]
    public class SuggestAttributeNameByTagMacroDef : JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.SimpleMacroDefinition
    {
        public override string GetPlaceholder(JetBrains.DocumentModel.IDocument document, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.IMacroParameterValue> parameters) { }
    }
    [JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroDefinitionAttribute("suggestAttributeName", LongDescription="Suggests XML attribute name used in current document", ShortDescription="Suggests XML attribute name")]
    public class SuggestAttributeNameMacroDef : JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.SimpleMacroDefinition
    {
        public override string GetPlaceholder(JetBrains.DocumentModel.IDocument document, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.IMacroParameterValue> parameters) { }
    }
    [JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroImplementationAttribute(Definition=typeof(JetBrains.ReSharper.LiveTemplates.Xml.Macros.SuggestAttributeNameMacroDef))]
    public class SuggestAttributeNameMacroImpl : JetBrains.ReSharper.LiveTemplates.Xml.Macros.XmlMacroImpl
    {
        protected override System.Collections.Generic.ICollection<string> GetSuggestedNames(JetBrains.ReSharper.Psi.Xml.Tree.IXmlFile file, JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext context) { }
    }
    [JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroDefinitionAttribute("suggestXmlTagName", LongDescription="Suggests XML tag name used in current document", ShortDescription="Suggests XML tag name")]
    public class SuggestTagNameMacroDef : JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.SimpleMacroDefinition
    {
        public override string GetPlaceholder(JetBrains.DocumentModel.IDocument document, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.IMacroParameterValue> parameters) { }
    }
    [JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroImplementationAttribute(Definition=typeof(JetBrains.ReSharper.LiveTemplates.Xml.Macros.SuggestTagNameMacroDef))]
    public class SuggestTagNameMacroImpl : JetBrains.ReSharper.LiveTemplates.Xml.Macros.XmlMacroImpl
    {
        protected override System.Collections.Generic.ICollection<string> GetSuggestedNames(JetBrains.ReSharper.Psi.Xml.Tree.IXmlFile file, JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext context) { }
    }
    [JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroDefinitionAttribute("tagName", LongDescription="Inserts name of containing tag without namespace", ShortDescription="Tag name")]
    public class TagNameMacroDef : JetBrains.ReSharper.LiveTemplates.Xml.Macros.XmlTagMacroDefBase { }
    [JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroImplementationAttribute(Definition=typeof(JetBrains.ReSharper.LiveTemplates.Xml.Macros.TagNameMacroDef))]
    public class TagNameMacroImpl : JetBrains.ReSharper.LiveTemplates.Xml.Macros.XmlTagMacroImplBase
    {
        public TagNameMacroImpl(JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroParameterValueCollection arguments) { }
        public override string EvaluateQuickResult(JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext context) { }
    }
    [JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroImplementationAttribute(Definition=typeof(JetBrains.ReSharper.LiveTemplates.Xml.Macros.TagNamespaceMacroDef))]
    public class TagNamespaceMacro : JetBrains.ReSharper.LiveTemplates.Xml.Macros.XmlTagMacroImplBase
    {
        public TagNamespaceMacro(JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroParameterValueCollection arguments) { }
        public override string EvaluateQuickResult(JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext context) { }
    }
    [JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroDefinitionAttribute("tagNamespace", LongDescription="Inserts namespace of containing tag", ShortDescription="Tag namespace")]
    public class TagNamespaceMacroDef : JetBrains.ReSharper.LiveTemplates.Xml.Macros.XmlTagMacroDefBase { }
    public abstract class XmlMacroImpl : JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.SimpleMacroImplementation
    {
        public override JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.HotspotItems GetLookupItems(JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext context) { }
        protected abstract System.Collections.Generic.ICollection<string> GetSuggestedNames(JetBrains.ReSharper.Psi.Xml.Tree.IXmlFile file, JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext context);
        protected JetBrains.ReSharper.Psi.Xml.Tree.IXmlFile GetXmlFile(JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext context) { }
    }
    public class XmlTagMacroDefBase : JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.SimpleMacroDefinition
    {
        public override string GetPlaceholder(JetBrains.DocumentModel.IDocument document, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.IMacroParameterValue> parameters) { }
    }
    public abstract class XmlTagMacroImplBase : JetBrains.ReSharper.LiveTemplates.Xml.Macros.XmlMacroImpl
    {
        protected readonly System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.IMacroParameterValueNew> myArguments;
        protected XmlTagMacroImplBase(JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroParameterValueCollection arguments) { }
        protected override System.Collections.Generic.ICollection<string> GetSuggestedNames(JetBrains.ReSharper.Psi.Xml.Tree.IXmlFile file, JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext context) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        protected JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag GetTag(JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext context) { }
    }
}
namespace JetBrains.ReSharper.LiveTemplates.Xml.Resources
{
    
    public sealed class LiveTemplatesXmlThemedIcons
    {
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.LiveTemplates.Xml;component/resources/LiveTemplatesXml/Themed" +
            "Icons.LiveTemplatesXml.Generated.Xaml", 0, "ScopeXml")]
        public sealed class ScopeXml : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
    }
}