[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("WebConfig.WebConfigPathWarning", null, "CodeSmell", "Referenced path cannot be found in the website", "Referenced path cannot be found in the website", JetBrains.ReSharper.Daemon.Severity.WARNING, false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("WebConfig.ModuleQualificationResolve", null, "CodeSmell", "Module qualification required", "Module qualification required for type resolution", JetBrains.ReSharper.Daemon.Severity.WARNING, false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("WebConfig.RedundantLocationTag", null, "CodeRedundancy", "Redundant location element", "Location element does not correspond to any path in the web site and can be safel" +
    "y removed", JetBrains.ReSharper.Daemon.Severity.WARNING, false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("WebConfig.TagPrefixRedundand", null, "CodeRedundancy", "Redundant tagPrefix declaration", "Tag prefix does not declare any new alias and can be removed safely", JetBrains.ReSharper.Daemon.Severity.WARNING, false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("WebConfig.UnusedAddTag", null, "CodeRedundancy", "Redundant add element", "Add element is redundant because it is cleared later and can be safely removed", JetBrains.ReSharper.Daemon.Severity.WARNING, false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("WebConfig.UnusedRemoveOrClearTag", null, "CodeRedundancy", "Redundant remove or clear element", "Element does not clear anything and can be safely removed", JetBrains.ReSharper.Daemon.Severity.WARNING, false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("WebConfig.RedundantAddNamespaceTag", null, "CodeRedundancy", "Redundant add namespace element", "Add namespace element is redundant because it duplicates another element of is cl" +
    "eared later and can be safely removed", JetBrains.ReSharper.Daemon.Severity.WARNING, false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("WebConfig.UnusedElementDueToConfigSourceAttribute", null, "CodeRedundancy", "Redundant element or attribute because of \'configSource\' attribute", "Element or attribute is not applied because of \'configSource\' attribute and can b" +
    "e safely removed", JetBrains.ReSharper.Daemon.Severity.WARNING, false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterStaticHighlightingsGroupAttribute("WebConfigErrors", "WebConfig Errors", true)]
[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]

namespace JetBrains.ReSharper.Daemon.WebConfig.Highlightings
{
    
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "WebConfigErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class ConfigSourceErrorHighlighting : JetBrains.ReSharper.Daemon.Xml.Highlightings.XmlErrorHighlighting
    {
        public readonly JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IConfigSourceAttribute ConfigSourceAttribute;
        public ConfigSourceErrorHighlighting(JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IConfigSourceAttribute configSourceAttribute) { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "WebConfigErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class ModuleQualificationMissingError : JetBrains.ReSharper.Daemon.Xml.Highlightings.XmlErrorHighlighting
    {
        public readonly JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IWebConfigTypeAttribute Attribute;
        public ModuleQualificationMissingError(JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IWebConfigTypeAttribute attribute) { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "WebConfigErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class ModuleQualificationResolveError : JetBrains.ReSharper.Daemon.Xml.Highlightings.XmlResolveErrorHighlighting<JetBrains.ReSharper.Psi.Web.Impl.WebConfig.Tree.References.ModuleQualificationReference>
    {
        public ModuleQualificationResolveError(JetBrains.ReSharper.Psi.Web.Impl.WebConfig.Tree.References.ModuleQualificationReference reference) { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "WebConfigErrors", AttributeId="ReSharper Underlined Error Highlighting", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class PathIsRelativeErrorHighlighting : JetBrains.ReSharper.Daemon.Xml.Stages.XmlHighlighting
    {
        public PathIsRelativeErrorHighlighting(JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IXmlPathAttribute attribute) { }
        public JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IXmlPathAttribute Attribute { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("WebConfig.RedundantAddNamespaceTag", "Web.Config", AttributeId="ReSharper Dead Code", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.DEADCODE)]
    public class RedundantAddNamespaceTagHighlighting : JetBrains.ReSharper.Daemon.Xml.Stages.XmlHighlighting
    {
        public readonly JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IAddNamespaceTag AddTag;
        public const string SEVERITY_ID = "WebConfig.RedundantAddNamespaceTag";
        public RedundantAddNamespaceTagHighlighting(JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IAddNamespaceTag tag) { }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("WebConfig.RedundantLocationTag", "Web.Config", AttributeId="ReSharper Dead Code", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.DEADCODE)]
    public class RedundantLocationTagHighlighting : JetBrains.ReSharper.Daemon.Xml.Stages.XmlHighlighting
    {
        public readonly JetBrains.ReSharper.Psi.Web.WebConfig.Tree.ILocationTag LocationTag;
        public const string SEVERITY_ID = "WebConfig.RedundantLocationTag";
        public RedundantLocationTagHighlighting(JetBrains.ReSharper.Psi.Web.WebConfig.Tree.ILocationTag tag, string text) { }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("WebConfig.TagPrefixRedundand", "Web.Config", AttributeId="ReSharper Dead Code", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.DEADCODE)]
    public class RedundantTagPrefixHighlighting : JetBrains.ReSharper.Daemon.WebConfig.Highlightings.TagPrefixHighlightingBase
    {
        public const string SEVERITY_ID = "WebConfig.TagPrefixRedundand";
        public RedundantTagPrefixHighlighting(JetBrains.ReSharper.Psi.Web.TagPrefixes.ITagPrefixHolder holder, string tooltip) { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "WebConfigErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class TagPrefixErrorHighlighting : JetBrains.ReSharper.Daemon.WebConfig.Highlightings.TagPrefixHighlightingBase
    {
        public TagPrefixErrorHighlighting(JetBrains.ReSharper.Psi.Web.TagPrefixes.ITagPrefixHolder holder, string tooltip) { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.INFO, "GutterMarks", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.NONE)]
    public class TagPrefixHidesHighlighting : JetBrains.ReSharper.Daemon.InheritanceMarkOnGutterBase<JetBrains.ReSharper.Psi.Web.TagPrefixes.ITagName>
    {
        public TagPrefixHidesHighlighting(JetBrains.ReSharper.Psi.Web.TagPrefixes.ITagNameDeclaration inheritor) { }
        protected override string FormatLocation(JetBrains.ReSharper.Psi.Web.TagPrefixes.ITagName member) { }
    }
    public class TagPrefixHighlightingBase : JetBrains.ReSharper.Daemon.IHighlighting
    {
        public readonly JetBrains.ReSharper.Psi.Web.TagPrefixes.ITagPrefixHolder Holder;
        public TagPrefixHighlightingBase(JetBrains.ReSharper.Psi.Web.TagPrefixes.ITagPrefixHolder holder, string tooltip) { }
        public virtual string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public virtual string ToolTip { get; }
        public bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "WebConfigErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class TypeMustBePublicErrorHighlighting : JetBrains.ReSharper.Daemon.Xml.Highlightings.XmlResolveErrorHighlighting<JetBrains.ReSharper.Psi.Web.Impl.WebConfig.Tree.References.IWebTypeReference>
    {
        public TypeMustBePublicErrorHighlighting(JetBrains.ReSharper.Psi.Web.Impl.WebConfig.Tree.References.IWebTypeReference reference) { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("WebConfig.UnusedAddTag", "Web.Config", AttributeId="ReSharper Dead Code", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.DEADCODE)]
    public class UnusedAddTagHighlighting : JetBrains.ReSharper.Daemon.Xml.Stages.XmlHighlighting
    {
        public readonly JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IWebConfigTag AddTag;
        public readonly JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IWebConfigTag RemoveOrClearTag;
        public const string SEVERITY_ID = "WebConfig.UnusedAddTag";
        public UnusedAddTagHighlighting(JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IWebConfigTag addTag, JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IWebConfigTag removeTag) { }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("WebConfig.UnusedElementDueToConfigSourceAttribute", "Web.Config", AttributeId="ReSharper Dead Code", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.DEADCODE)]
    public class UnusedElementDueToConfigSourceAttributeHighlighting : JetBrains.ReSharper.Daemon.Xml.Stages.XmlHighlighting
    {
        public const string SEVERITY_ID = "WebConfig.UnusedElementDueToConfigSourceAttribute";
        public readonly JetBrains.ReSharper.Psi.Tree.ITreeNode UnusedNode;
        public UnusedElementDueToConfigSourceAttributeHighlighting(JetBrains.ReSharper.Psi.Tree.ITreeNode unusedNode) { }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("WebConfig.UnusedRemoveOrClearTag", "Web.Config", AttributeId="ReSharper Dead Code", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.DEADCODE)]
    public class UnusedRemoveOrClearTagHighlighting : JetBrains.ReSharper.Daemon.Xml.Stages.XmlHighlighting
    {
        public readonly JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IWebConfigTag RemoveTag;
        public const string SEVERITY_ID = "WebConfig.UnusedRemoveOrClearTag";
        public UnusedRemoveOrClearTagHighlighting(JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IWebConfigTag tag) { }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("Web.IgnoredPath", "Web.Config", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.WARNING)]
    public class WebConfigIgnoredPathHighlighting : JetBrains.ReSharper.Daemon.WebConfig.Highlightings.WebConfigPathErrorHighlighting
    {
        public const string SEVERITY_ID = "Web.IgnoredPath";
        public WebConfigIgnoredPathHighlighting(JetBrains.ReSharper.Psi.Web.Impl.WebConfig.Tree.References.WebConfigPathReferenceBase reference) { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("Web.MappedPath", "Web.Config", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.WARNING)]
    public class WebConfigMappedPathHighlighting : JetBrains.ReSharper.Daemon.WebConfig.Highlightings.WebConfigPathErrorHighlighting
    {
        public const string SEVERITY_ID = "Web.MappedPath";
        public WebConfigMappedPathHighlighting(JetBrains.ReSharper.Psi.Web.Impl.WebConfig.Tree.References.WebConfigPathReferenceBase reference) { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "WebConfigErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class WebConfigPathErrorHighlighting : JetBrains.ReSharper.Daemon.Xml.Highlightings.XmlResolveErrorHighlighting<JetBrains.ReSharper.Psi.Web.Impl.WebConfig.Tree.References.WebConfigPathReferenceBase>
    {
        public WebConfigPathErrorHighlighting(JetBrains.ReSharper.Psi.Web.Impl.WebConfig.Tree.References.WebConfigPathReferenceBase reference) { }
        protected static string CreateTooltip(JetBrains.ReSharper.Psi.Web.Impl.WebConfig.Tree.References.WebConfigPathReferenceBase reference) { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("WebConfig.WebConfigPathWarning", "Web.Config", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.WARNING)]
    public class WebConfigPathWarningHighlighting : JetBrains.ReSharper.Daemon.WebConfig.Highlightings.WebConfigPathErrorHighlighting
    {
        public const string SEVERITY_ID = "WebConfig.WebConfigPathWarning";
        public WebConfigPathWarningHighlighting(JetBrains.ReSharper.Psi.Web.Impl.WebConfig.Tree.References.WebConfigPathReferenceBase reference) { }
    }
    public class static WebConfigStaticHighlightingsGroups
    {
        public const string WEB_CONFIG_ERRORS_GROUP = "WebConfigErrors";
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "WebConfigErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class WrongModuleErrorHighlighting : JetBrains.ReSharper.Daemon.Xml.Highlightings.XmlResolveErrorHighlighting<JetBrains.ReSharper.Psi.Web.Impl.WebConfig.Tree.References.WebConfigTypeReference>
    {
        public WrongModuleErrorHighlighting(JetBrains.ReSharper.Psi.Web.Impl.WebConfig.Tree.References.WebConfigTypeReference reference) { }
    }
}
namespace JetBrains.ReSharper.Daemon.WebConfig.Stages.Resolve
{
    
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Web.WebConfig.WebConfigLanguage))]
    public class WebConfigNotResolvedErrorHandler : JetBrains.ReSharper.Daemon.Xml.Stages.Resolve.XmlNotResolvedErrorHandler
    {
        protected override JetBrains.ReSharper.Daemon.IHighlighting CreateNotResolvedErrorHighlighting(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Web.WebConfig.WebConfigLanguage))]
    public class WebConfigPathErrorHandler : JetBrains.ReSharper.Daemon.Stages.Resolve.PathErrorHandler
    {
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Resolve.ResolveErrorType> ErrorTypes { get; }
        public override JetBrains.ReSharper.Daemon.IHighlighting Run(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
    }
}
namespace JetBrains.ReSharper.Daemon.WebConfig.Stages
{
    
    public class static TagChecker
    {
        public static void CheckAttribute(JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IWebConfigTag tag, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer highlightings, string attributeName) { }
    }
}
namespace JetBrains.ReSharper.Daemon.WebConfig.Util
{
    
    public class TagPrefixAnalysisData
    {
        public TagPrefixAnalysisData() { }
        public JetBrains.ReSharper.Daemon.WebConfig.Util.TagPrefixAnalysisData.Entry GetEntry(JetBrains.Util.FileSystemPath path) { }
        public class Entry
        {
            public readonly System.Collections.Generic.Dictionary<string, JetBrains.ReSharper.Psi.Web.TagPrefixes.ITagName> TagPrefixNames;
            public readonly JetBrains.Util.OneToListMap<string, JetBrains.ReSharper.Daemon.WebConfig.Util.TagPrefixAnalysisData.NamespaceWrapper> TagPrefixToNamespaceMap;
            public Entry() { }
            public void Add(string prefix, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.INamespace @namespace) { }
            public bool Contains(string prefix, JetBrains.ReSharper.Psi.INamespace @namespace) { }
        }
        public class NamespaceWrapper
        {
            public NamespaceWrapper([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.INamespace @namespace) { }
            public bool Equals(JetBrains.ReSharper.Daemon.WebConfig.Util.TagPrefixAnalysisData.NamespaceWrapper other) { }
            public override bool Equals(object obj) { }
            public override int GetHashCode() { }
        }
    }
    public class static TagPrefixAnalysisUtil
    {
        public static JetBrains.ReSharper.Daemon.WebConfig.Util.TagPrefixAnalysisData Init(JetBrains.ReSharper.Psi.Tree.IFile file) { }
        public static void ProcessHolder(JetBrains.ReSharper.Psi.Web.TagPrefixes.ITagPrefixHolder holder, JetBrains.ReSharper.Daemon.WebConfig.Util.TagPrefixAnalysisData data, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer highlightings) { }
    }
}