[assembly: JetBrains.ReSharper.Daemon.ConfigurableSeverityImplementedForLanguageAttribute(typeof(JetBrains.ReSharper.Daemon.UsageChecking.UnusedFieldGlobalWarning), "ASPX")]
[assembly: JetBrains.ReSharper.Daemon.ConfigurableSeverityImplementedForLanguageAttribute(typeof(JetBrains.ReSharper.Daemon.UsageChecking.NotAccessedFieldGlobalWarning), "ASPX")]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("Mvc.ViewNotResolved", "MVC", "CodeSmell", "Unknown view", "Unknown ASP.NET MVC View", JetBrains.ReSharper.Daemon.Severity.ERROR, false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("Mvc.PartialViewNotResolved", "MVC", "CodeSmell", "Unknown partial view", "Unknown ASP.NET MVC Partial View", JetBrains.ReSharper.Daemon.Severity.ERROR, false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("Mvc.TemplateNotResolved", "MVC", "CodeSmell", "Unknown template", "Unknown ASP.NET MVC Template", JetBrains.ReSharper.Daemon.Severity.ERROR, false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("Mvc.MasterpageNotResolved", "MVC", "CodeSmell", "Unknown masterpage", "Unknown ASP.NET MVC Masterpage", JetBrains.ReSharper.Daemon.Severity.ERROR, false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("Mvc.ControllerNotResolved", "MVC", "CodeSmell", "Unknown controller", "Unknown ASP.NET MVC Controller", JetBrains.ReSharper.Daemon.Severity.ERROR, false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("Mvc.ActionNotResolved", "MVC", "CodeSmell", "Unknown action", "Unknown ASP.NET MVC Action", JetBrains.ReSharper.Daemon.Severity.ERROR, false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("Mvc.AreaNotResolved", "MVC", "CodeSmell", "Unknown area", "Unknown ASP.NET MVC Area", JetBrains.ReSharper.Daemon.Severity.ERROR, false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("Asp.Image", null, "CodeSmell", "Wrong image size", "Wrong image size", JetBrains.ReSharper.Daemon.Severity.WARNING, false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("Asp.DeadCode", null, "CodeSmell", "ASP.NET Dead Code", "ASP.NET Dead Code", JetBrains.ReSharper.Daemon.Severity.WARNING, false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("Asp.Warning", null, "CodeSmell", "ASP.NET Warning", "ASP.NET Warning", JetBrains.ReSharper.Daemon.Severity.WARNING, false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("Asp.ResolveWarning", null, "CodeSmell", "ASP.NET Resolve Warning", "ASP.NET Resolve Warning", JetBrains.ReSharper.Daemon.Severity.WARNING, false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("AspUnusedRegisterDirectiveHighlighting", null, "CodeRedundancy", "Unused register directive", "Register directive is unused and can be safely removed", JetBrains.ReSharper.Daemon.Severity.WARNING, false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("Asp.NotResolved", null, "CodeSmell", "Unknown symbol", "Unknown symbol in ASP.NET and related technologies", JetBrains.ReSharper.Daemon.Severity.ERROR, false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("Asp.TagAttributeWithOptionalValue", null, "BestPractice", "Attribute with optional value problem", "Attribute with optional value problem", JetBrains.ReSharper.Daemon.Severity.WARNING, false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("Asp.ContentPlaceholderNotResolved", null, "CodeSmell", "Unknown content placeholder", "Unknown content placeholder", JetBrains.ReSharper.Daemon.Severity.ERROR, false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("Asp.SkinNotResolved", null, "CodeSmell", "Unknown skin", "Unknown skin", JetBrains.ReSharper.Daemon.Severity.ERROR, false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("AspOdsMethodReferenceResolveError", null, "CodeSmell", "Object data source method resolve problem", "Object data source method resolve problem", JetBrains.ReSharper.Daemon.Severity.ERROR, false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("Asp.ThemeNotResolved", null, "CodeSmell", "Unknown theme", "Unknown theme", JetBrains.ReSharper.Daemon.Severity.ERROR, false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterStaticHighlightingsGroupAttribute("AspMvcInfo", "ASP MVC Info", false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterStaticHighlightingsGroupAttribute("AspErrors", "ASP Errors", true)]
[assembly: JetBrains.TextControl.DocumentMarkup.RegisterHighlighterAttribute("ReSharper ASP.NET MVC Area", "{ABF5D4E7-DDAA-4BF8-B270-4F6F5E093062}", EffectColor="Brown", EffectType=JetBrains.TextControl.DocumentMarkup.EffectType.SOLID_UNDERLINE, Layer=2000, VSPriority=40)]
[assembly: JetBrains.TextControl.DocumentMarkup.RegisterHighlighterAttribute("ReSharper ASP.NET MVC Action", "{7C9F9F83-C196-4ED9-8868-F10070681959}", EffectColor="Brown", EffectType=JetBrains.TextControl.DocumentMarkup.EffectType.SOLID_UNDERLINE, Layer=2000, VSPriority=40)]
[assembly: JetBrains.TextControl.DocumentMarkup.RegisterHighlighterAttribute("ReSharper ASP.NET MVC View", "{AE572429-9450-4E2B-9C06-1E70F03E268E}", EffectColor="Brown", EffectType=JetBrains.TextControl.DocumentMarkup.EffectType.SOLID_UNDERLINE, Layer=2000, VSPriority=40)]
[assembly: JetBrains.TextControl.DocumentMarkup.RegisterHighlighterAttribute("ReSharper ASP.NET RunAt attribute", "{F1CD561D-AE2C-4380-95D0-93E4BFF1F5A9}", DarkForegroundColor="BurlyWood", ForegroundColor="Brown", Layer=2000, VSPriority=40)]
[assembly: JetBrains.TextControl.DocumentMarkup.RegisterHighlighterAttribute("ReSharper ASP.NET MVC Controller", "{457822CB-E927-4220-B4C2-8530ED4703A0}", EffectColor="Brown", EffectType=JetBrains.TextControl.DocumentMarkup.EffectType.SOLID_UNDERLINE, Layer=2000, VSPriority=40)]
[assembly: JetBrains.TextControl.DocumentMarkup.RegisterHighlighterAttribute("ReSharper HTML ID attribute", "{88B5849C-8C72-4116-A6D2-F9BD757D0E1D}", DarkForegroundColor="LightSkyBlue", FontStyle=System.Drawing.FontStyle.Regular | System.Drawing.FontStyle.Bold, ForegroundColor="Blue", Layer=2000, VSPriority=40)]
[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]

namespace JetBrains.ReSharper.Daemon.Asp
{
    
    public class AspElementPropertiesCalculator : JetBrains.ReSharper.Daemon.UsageChecking.ILanguageSpecificElementPropertiesCalculator
    {
        public bool CanConvertToConstant(JetBrains.ReSharper.Psi.IField field) { }
        public bool CanConvertToConstant(JetBrains.ReSharper.Psi.ILocalVariable local) { }
        public bool IsAutoProperty(JetBrains.ReSharper.Psi.IProperty property) { }
        public bool IsInitializedInDeclaration(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
        public bool IsPartialClass(JetBrains.ReSharper.Psi.IClass @class) { }
        public bool IsPartialMethod(JetBrains.ReSharper.Psi.IMethod method) { }
        public bool IsRedundantOverload(JetBrains.ReSharper.Psi.ITypeMember member) { }
        public bool IsStaticClass(JetBrains.ReSharper.Psi.IClass @class) { }
        public bool IsUsedInTermsOfCompiler(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
        public bool MethodDeclarationHasBody(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
    }
    public class AspPresentationHelper : JetBrains.ReSharper.Daemon.UsageChecking.IPresentationHelper
    {
        public string DeclaredElementName(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
        public string GetInternalTerm(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
        public string GetReadOnlyTerm(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
        public string GetSealedTerm(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
        public string GetStaticTerm() { }
        public string GetVirtualTerm(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
        public JetBrains.DocumentModel.DocumentRange LowerAccessHighlightingRange(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
        public JetBrains.DocumentModel.DocumentRange ReturnTypeRange(JetBrains.ReSharper.Psi.Tree.IFunctionDeclaration declaration) { }
        public JetBrains.DocumentModel.DocumentRange TypeUsageRange(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
        public JetBrains.DocumentModel.DocumentRange VirtualMemberNeverOverridenRange(JetBrains.ReSharper.Psi.Tree.ITypeMemberDeclaration declaration) { }
    }
    public class static ImageUtil
    {
        public const string HEIGHT_ATTR = "height";
        public const string WIDTH_ATTR = "width";
        public static System.Nullable<System.Drawing.Size> GetImageSize(JetBrains.ReSharper.Psi.Tree.ITreeNode element, out JetBrains.ReSharper.Psi.Html.Tree.ITagAttribute src) { }
    }
}
namespace JetBrains.ReSharper.Daemon.Asp.Highlightings
{
    
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("Asp.TagAttributeWithOptionalValue", "ASPX", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.WARNING)]
    public class AspAttributeWithOptionalValueWarningHighlighting : JetBrains.ReSharper.Daemon.Asp.Highlightings.AspWarningHighlighting
    {
        public AspAttributeWithOptionalValueWarningHighlighting(JetBrains.ReSharper.Psi.Html.Tree.ITagAttribute attribute) { }
        public JetBrains.ReSharper.Psi.Html.Tree.ITagAttribute Attribute { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "AspErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class AspCodeFileWithoutInheritsAttributeErrorHighlighting : JetBrains.ReSharper.Daemon.Html.Highlightings.HtmlHighlightingBase, JetBrains.ReSharper.Daemon.Asp.Highlightings.IAspHighlighting, JetBrains.ReSharper.Daemon.Html.Highlightings.IHtmlHighlighting, JetBrains.ReSharper.Daemon.IHighlighting
    {
        public readonly JetBrains.ReSharper.Psi.Asp.Tree.IAspMainDirective MainDirective;
        public AspCodeFileWithoutInheritsAttributeErrorHighlighting(JetBrains.ReSharper.Psi.Asp.Tree.IAspMainDirective mainDirective) { }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("Asp.ContentPlaceholderNotResolved", "ASPX", AttributeId="ReSharper Error Highlighting", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.UNRESOLVED_ERROR, OverloadResolvePriority=10)]
    public class AspConfigurableContentPlaceholderNotResolvedErrorHighlighting : JetBrains.ReSharper.Daemon.Asp.Highlightings.AspConfigurableNotResolvedErrorHighlighting<JetBrains.ReSharper.Psi.Asp.References.IContentPlaceholderReference>
    {
        public const string SEVERITY_ID = "Asp.ContentPlaceholderNotResolved";
        public AspConfigurableContentPlaceholderNotResolvedErrorHighlighting(JetBrains.ReSharper.Psi.Asp.References.IContentPlaceholderReference reference) { }
        protected override string CreateTooltip(JetBrains.ReSharper.Psi.Asp.References.IContentPlaceholderReference reference) { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("Asp.NotResolved", "ASPX", AttributeId="ReSharper Error Highlighting", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.UNRESOLVED_ERROR, OverloadResolvePriority=10)]
    public class AspConfigurableNotResolvedErrorHighlighting<T> : JetBrains.ReSharper.Daemon.Asp.Highlightings.AspNotResolvedErrorHighlighting<T>
        where T : JetBrains.ReSharper.Psi.Resolve.IReference
    {
        public AspConfigurableNotResolvedErrorHighlighting(T reference, string tooltip = null, params object[] args) { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("Asp.SkinNotResolved", "ASPX", AttributeId="ReSharper Error Highlighting", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.UNRESOLVED_ERROR, OverloadResolvePriority=10)]
    public class AspConfigurableSkinNotResolvedErrorHighlighting : JetBrains.ReSharper.Daemon.Asp.Highlightings.AspConfigurableNotResolvedErrorHighlighting<JetBrains.ReSharper.Psi.Asp.References.ISkinReference>
    {
        public const string SEVERITY_ID = "Asp.SkinNotResolved";
        public AspConfigurableSkinNotResolvedErrorHighlighting(JetBrains.ReSharper.Psi.Asp.References.ISkinReference reference) { }
        protected override string CreateTooltip(JetBrains.ReSharper.Psi.Asp.References.ISkinReference reference) { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("Asp.ThemeNotResolved", "ASPX", AttributeId="ReSharper Error Highlighting", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.UNRESOLVED_ERROR, OverloadResolvePriority=10)]
    public class AspConfigurableThemeNotResolvedErrorHighlighting : JetBrains.ReSharper.Daemon.Asp.Highlightings.AspConfigurableNotResolvedErrorHighlighting<JetBrains.ReSharper.Psi.Asp.References.IThemeReference>
    {
        public const string SEVERITY_ID = "Asp.ThemeNotResolved";
        public AspConfigurableThemeNotResolvedErrorHighlighting(JetBrains.ReSharper.Psi.Asp.References.IThemeReference reference) { }
        protected override string CreateTooltip(JetBrains.ReSharper.Psi.Asp.References.IThemeReference reference) { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("Asp.DeadCode", "ASPX", AttributeId="ReSharper Dead Code", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.DEADCODE)]
    public class AspDeadCodeHighlighting : JetBrains.ReSharper.Daemon.Html.Highlightings.HtmlDeadCodeHighlighting, JetBrains.ReSharper.Daemon.Asp.Highlightings.IAspHighlighting, JetBrains.ReSharper.Daemon.Html.Highlightings.IHtmlHighlighting, JetBrains.ReSharper.Daemon.IHighlighting
    {
        public AspDeadCodeHighlighting(JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode element, string tooltipTextFormat, params object[] args) { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "AspErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class AspErrorHighlighting : JetBrains.ReSharper.Daemon.Html.Highlightings.HtmlErrorHighlighting, JetBrains.ReSharper.Daemon.Asp.Highlightings.IAspHighlighting, JetBrains.ReSharper.Daemon.Html.Highlightings.IHtmlHighlighting, JetBrains.ReSharper.Daemon.IHighlighting
    {
        public AspErrorHighlighting(string tooltipTextFormat, params object[] args) { }
    }
    public class static AspHighlightingRegistry
    {
        public const string HTML_ID_ATTRIBUTE = "ReSharper HTML ID attribute";
        public const string RUNATSERVER_ATTRIBUTE = "ReSharper ASP.NET RunAt attribute";
    }
    public class AspHighlightingWithReferenceBase<T> : JetBrains.ReSharper.Daemon.Html.Highlightings.HtmlHighlightingWithReferenceBase<T>, JetBrains.ReSharper.Daemon.Asp.Highlightings.IAspHighlighting, JetBrains.ReSharper.Daemon.Html.Highlightings.IHtmlHighlighting, JetBrains.ReSharper.Daemon.IHighlighting
        where T : JetBrains.ReSharper.Psi.Resolve.IReference
    {
        public AspHighlightingWithReferenceBase(T reference, string tooltip = null, params object[] args) { }
        protected override string CreateTooltip(T reference) { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("Asp.Image", "ASPX", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.WARNING)]
    public class AspImageWarningHighlighting : JetBrains.ReSharper.Daemon.Asp.Highlightings.AspWarningHighlighting
    {
        public AspImageWarningHighlighting(JetBrains.Util.TextRange range, string realSize, string tooltipTextFormat, params object[] args) { }
        public JetBrains.Util.TextRange Range { get; }
        public string RealSize { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "AspErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class AspMissingAttributeHighlighting : JetBrains.ReSharper.Daemon.Asp.Highlightings.AspErrorHighlighting
    {
        public AspMissingAttributeHighlighting(JetBrains.ReSharper.Psi.Asp.Tree.IAspTag tag, string missingAttributeName) { }
        public string MissingAttributeName { get; }
        public JetBrains.ReSharper.Psi.Asp.Tree.IAspTag Tag { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "AspErrors", AttributeId="ReSharper Error Highlighting", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.UNRESOLVED_ERROR, OverloadResolvePriority=10)]
    public class AspNotResolvedErrorHighlighting<T> : JetBrains.ReSharper.Daemon.Asp.Highlightings.AspResolveErrorHighlighting<T>
        where T : JetBrains.ReSharper.Psi.Resolve.IReference
    {
        public AspNotResolvedErrorHighlighting(T reference, [JetBrains.Annotations.CanBeNullAttribute()] string tooltip = null, params object[] args) { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("AspOdsMethodReferenceResolveError", "ASPX", AttributeId="ReSharper Underlined Error Highlighting", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class AspOdsMethodReferenceResolveErrorHighlighting : JetBrains.ReSharper.Daemon.Asp.Highlightings.AspResolveErrorHighlighting<JetBrains.ReSharper.Psi.Asp.References.IOdsMethodReference>
    {
        public const string SEVERITY_ID = "AspOdsMethodReferenceResolveError";
        public AspOdsMethodReferenceResolveErrorHighlighting(JetBrains.ReSharper.Psi.Asp.References.IOdsMethodReference reference) { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "AspErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class AspResolveErrorHighlighting<T> : JetBrains.ReSharper.Daemon.Asp.Highlightings.AspHighlightingWithReferenceBase<T>
        where T : JetBrains.ReSharper.Psi.Resolve.IReference
    {
        public AspResolveErrorHighlighting(T reference, string tooltip = null, params object[] args) { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("Asp.ResolveWarning", "ASPX", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.WARNING)]
    public class AspResolveWarningHighlighting<T> : JetBrains.ReSharper.Daemon.Asp.Highlightings.AspHighlightingWithReferenceBase<T>
        where T : JetBrains.ReSharper.Psi.Resolve.IReference
    {
        public AspResolveWarningHighlighting(T reference) { }
        public AspResolveWarningHighlighting(T reference, string tooltip) { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "AspErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class AspScriptLanguageErrorHighlighting : JetBrains.ReSharper.Daemon.Asp.Highlightings.AspErrorHighlighting
    {
        public AspScriptLanguageErrorHighlighting(JetBrains.ReSharper.Psi.Html.Tree.ITagAttribute languageAttribute, string tooltipTextFormat, params object[] args) { }
        public JetBrains.ReSharper.Psi.Html.Tree.ITagAttribute LanguageAttribute { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("AspUnusedRegisterDirectiveHighlighting", "ASPX", AttributeId="ReSharper Dead Code", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.DEADCODE)]
    public class AspUnusedRegisterDirectiveHighlighting : JetBrains.ReSharper.Daemon.Asp.Highlightings.AspWarningHighlighting
    {
        public readonly JetBrains.ReSharper.Psi.Asp.Tree.IAspRegisterDirective RegisterDirective;
        public const string SEVERITY_ID = "AspUnusedRegisterDirectiveHighlighting";
        public AspUnusedRegisterDirectiveHighlighting(JetBrains.ReSharper.Psi.Asp.Tree.IAspRegisterDirective registerDirective) { }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("Asp.Warning", "ASPX", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.WARNING)]
    public class AspWarningHighlighting : JetBrains.ReSharper.Daemon.Html.Highlightings.HtmlWarningHighlighting, JetBrains.ReSharper.Daemon.Asp.Highlightings.IAspHighlighting, JetBrains.ReSharper.Daemon.Html.Highlightings.IHtmlHighlighting, JetBrains.ReSharper.Daemon.IHighlighting
    {
        public AspWarningHighlighting(string tooltipTextFormat, params object[] args) { }
    }
    public interface IAspHighlighting : JetBrains.ReSharper.Daemon.Html.Highlightings.IHtmlHighlighting, JetBrains.ReSharper.Daemon.IHighlighting { }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.INFO, "AspMvcInfo", AttributeId="ReSharper ASP.NET MVC Action", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.NONE, ShowToolTipInStatusBar=false)]
    public class MvcActionHighlighting : JetBrains.ReSharper.Daemon.Asp.Highlightings.MvcHighlightingBase
    {
        public const string HIGHLIGHTING_ID = "ReSharper ASP.NET MVC Action";
        public MvcActionHighlighting(JetBrains.ReSharper.Feature.Services.Asp.CustomReferences.IMvcReference reference) { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.INFO, "AspMvcInfo", AttributeId="ReSharper ASP.NET MVC Area", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.NONE, ShowToolTipInStatusBar=false)]
    public class MvcAreaHighlighting : JetBrains.ReSharper.Daemon.Asp.Highlightings.MvcHighlightingBase
    {
        public const string HIGHLIGHTING_ID = "ReSharper ASP.NET MVC Area";
        public MvcAreaHighlighting(JetBrains.ReSharper.Feature.Services.Asp.CustomReferences.IMvcReference reference) { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.INFO, "AspMvcInfo", AttributeId="ReSharper ASP.NET MVC Controller", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.NONE, ShowToolTipInStatusBar=false)]
    public class MvcControllerHighlighting : JetBrains.ReSharper.Daemon.Asp.Highlightings.MvcHighlightingBase
    {
        public const string HIGHLIGHTING_ID = "ReSharper ASP.NET MVC Controller";
        public MvcControllerHighlighting(JetBrains.ReSharper.Feature.Services.Asp.CustomReferences.IMvcReference reference) { }
    }
    public abstract class MvcHighlightingBase : JetBrains.ReSharper.Daemon.IHighlighting
    {
        protected MvcHighlightingBase(JetBrains.ReSharper.Feature.Services.Asp.CustomReferences.IMvcReference reference) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public virtual string ToolTip { get; }
        public bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.INFO, "AspMvcInfo", AttributeId="ReSharper ASP.NET MVC View", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.NONE, ShowToolTipInStatusBar=false)]
    public class MvcViewHighlighting : JetBrains.ReSharper.Daemon.Asp.Highlightings.MvcHighlightingBase
    {
        public const string HIGHLIGHTING_ID = "ReSharper ASP.NET MVC View";
        public MvcViewHighlighting(JetBrains.ReSharper.Feature.Services.Asp.CustomReferences.IMvcViewReference reference) { }
        public override string ToolTip { get; }
    }
}
namespace JetBrains.ReSharper.Daemon.Asp.Highlightings.Mvc
{
    
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("Mvc.ActionNotResolved", "ASPX", AttributeId="ReSharper Error Highlighting", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.UNRESOLVED_ERROR, OverloadResolvePriority=10)]
    public class MvcConfigurableActionNotResolvedErrorHighlighting : JetBrains.ReSharper.Daemon.Asp.Highlightings.AspConfigurableNotResolvedErrorHighlighting<JetBrains.ReSharper.Feature.Services.Asp.CustomReferences.IMvcReference>
    {
        public const string SEVERITY_ID = "Mvc.ActionNotResolved";
        public MvcConfigurableActionNotResolvedErrorHighlighting(JetBrains.ReSharper.Feature.Services.Asp.CustomReferences.IMvcReference reference) { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("Mvc.AreaNotResolved", "ASPX", AttributeId="ReSharper Error Highlighting", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.UNRESOLVED_ERROR, OverloadResolvePriority=10)]
    public class MvcConfigurableAreaNotResolvedErrorHighlighting : JetBrains.ReSharper.Daemon.Asp.Highlightings.AspConfigurableNotResolvedErrorHighlighting<JetBrains.ReSharper.Feature.Services.Asp.CustomReferences.IMvcReference>
    {
        public const string SEVERITY_ID = "Mvc.AreaNotResolved";
        public MvcConfigurableAreaNotResolvedErrorHighlighting(JetBrains.ReSharper.Feature.Services.Asp.CustomReferences.IMvcReference reference) { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("Mvc.ControllerNotResolved", "ASPX", AttributeId="ReSharper Error Highlighting", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.UNRESOLVED_ERROR, OverloadResolvePriority=10)]
    public class MvcConfigurableControllerNotResolvedErrorHighlighting : JetBrains.ReSharper.Daemon.Asp.Highlightings.AspConfigurableNotResolvedErrorHighlighting<JetBrains.ReSharper.Feature.Services.Asp.CustomReferences.IMvcReference>
    {
        public const string SEVERITY_ID = "Mvc.ControllerNotResolved";
        public MvcConfigurableControllerNotResolvedErrorHighlighting(JetBrains.ReSharper.Feature.Services.Asp.CustomReferences.IMvcReference reference) { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("Mvc.MasterpageNotResolved", "ASPX", AttributeId="ReSharper Error Highlighting", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.UNRESOLVED_ERROR, OverloadResolvePriority=10)]
    public class MvcConfigurableMasterpageNotResolvedErrorHighlighting : JetBrains.ReSharper.Daemon.Asp.Highlightings.AspConfigurableNotResolvedErrorHighlighting<JetBrains.ReSharper.Feature.Services.Asp.CustomReferences.IMvcReference>
    {
        public const string SEVERITY_ID = "Mvc.MasterpageNotResolved";
        public MvcConfigurableMasterpageNotResolvedErrorHighlighting(JetBrains.ReSharper.Feature.Services.Asp.CustomReferences.IMvcReference reference) { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("Mvc.PartialViewNotResolved", "ASPX", AttributeId="ReSharper Error Highlighting", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.UNRESOLVED_ERROR, OverloadResolvePriority=10)]
    public class MvcConfigurablePartialViewNotResolvedErrorHighlighting : JetBrains.ReSharper.Daemon.Asp.Highlightings.AspConfigurableNotResolvedErrorHighlighting<JetBrains.ReSharper.Feature.Services.Asp.CustomReferences.IMvcReference>
    {
        public const string SEVERITY_ID = "Mvc.PartialViewNotResolved";
        public MvcConfigurablePartialViewNotResolvedErrorHighlighting(JetBrains.ReSharper.Feature.Services.Asp.CustomReferences.IMvcReference reference) { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("Mvc.TemplateNotResolved", "ASPX", AttributeId="ReSharper Error Highlighting", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.UNRESOLVED_ERROR, OverloadResolvePriority=10)]
    public class MvcConfigurableTemplateNotResolvedErrorHighlighting : JetBrains.ReSharper.Daemon.Asp.Highlightings.AspConfigurableNotResolvedErrorHighlighting<JetBrains.ReSharper.Feature.Services.Asp.CustomReferences.IMvcReference>
    {
        public const string SEVERITY_ID = "Mvc.TemplateNotResolved";
        public MvcConfigurableTemplateNotResolvedErrorHighlighting(JetBrains.ReSharper.Feature.Services.Asp.CustomReferences.IMvcReference reference) { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("Mvc.ViewNotResolved", "ASPX", AttributeId="ReSharper Error Highlighting", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.UNRESOLVED_ERROR, OverloadResolvePriority=10)]
    public class MvcConfigurableViewNotResolvedErrorHighlighting : JetBrains.ReSharper.Daemon.Asp.Highlightings.AspConfigurableNotResolvedErrorHighlighting<JetBrains.ReSharper.Feature.Services.Asp.CustomReferences.IMvcReference>
    {
        public const string SEVERITY_ID = "Mvc.ViewNotResolved";
        public MvcConfigurableViewNotResolvedErrorHighlighting(JetBrains.ReSharper.Feature.Services.Asp.CustomReferences.IMvcReference reference) { }
    }
}
namespace JetBrains.ReSharper.Daemon.Asp.Stages.Analysis
{
    
    [JetBrains.ReSharper.Daemon.Html.Stages.Analysis.HtmlAnalysisAttribute(typeof(JetBrains.ReSharper.Psi.Asp.AspLanguage))]
    public class AspDuplicateAnalysis : JetBrains.ReSharper.Daemon.Html.Stages.Analysis.HtmlAnalysis<JetBrains.Util.JetTuple<JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer, System.Collections.Generic.IDictionary<string, System.Collections.Generic.IDictionary<JetBrains.ReSharper.Psi.Html.Tree.IHtmlTagContainer, JetBrains.Util.OneToListMap<string, JetBrains.Util.Pair<JetBrains.DocumentModel.DocumentRange, bool>>>>, JetBrains.ReSharper.Psi.IDeclaredType[]>>, JetBrains.ReSharper.Daemon.Asp.Stages.Analysis.IAspSemanticAnalysis, JetBrains.ReSharper.Daemon.Html.Stages.Analysis.IHtmlAnalysis, JetBrains.ReSharper.Daemon.Html.Stages.Analysis.IHtmlAnalysis<object>, JetBrains.ReSharper.Daemon.Html.Stages.Analysis.IHtmlSemanticAnalysis, JetBrains.ReSharper.Psi.IRecursiveElementProcessor<object>
    {
        public AspDuplicateAnalysis(JetBrains.ReSharper.Psi.Asp.AspLanguage language) { }
        public override void Done(JetBrains.ReSharper.Psi.Html.Tree.IHtmlFile file, JetBrains.Util.JetTuple<JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer, System.Collections.Generic.IDictionary<string, System.Collections.Generic.IDictionary<JetBrains.ReSharper.Psi.Html.Tree.IHtmlTagContainer, JetBrains.Util.OneToListMap<string, JetBrains.Util.Pair<JetBrains.DocumentModel.DocumentRange, bool>>>>, JetBrains.ReSharper.Psi.IDeclaredType[]> context) { }
        public override object Init(JetBrains.ReSharper.Psi.Html.Tree.IHtmlFile file, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer) { }
        public override bool InteriorShouldBeProcessed(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.Util.JetTuple<JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer, System.Collections.Generic.IDictionary<string, System.Collections.Generic.IDictionary<JetBrains.ReSharper.Psi.Html.Tree.IHtmlTagContainer, JetBrains.Util.OneToListMap<string, JetBrains.Util.Pair<JetBrains.DocumentModel.DocumentRange, bool>>>>, JetBrains.ReSharper.Psi.IDeclaredType[]> context) { }
        public override void ProcessAfterInterior(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.Util.JetTuple<JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer, System.Collections.Generic.IDictionary<string, System.Collections.Generic.IDictionary<JetBrains.ReSharper.Psi.Html.Tree.IHtmlTagContainer, JetBrains.Util.OneToListMap<string, JetBrains.Util.Pair<JetBrains.DocumentModel.DocumentRange, bool>>>>, JetBrains.ReSharper.Psi.IDeclaredType[]> context) { }
    }
    [JetBrains.ReSharper.Daemon.Html.Stages.Analysis.HtmlAnalysisAttribute(typeof(JetBrains.ReSharper.Psi.Asp.AspLanguage))]
    public class AspExpressionAnalysis : JetBrains.ReSharper.Daemon.Html.Stages.Analysis.HtmlAnalysis<JetBrains.Util.JetTuple<JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer, JetBrains.ReSharper.Psi.Web.Tree.IWebFileWithCodeBehind, JetBrains.ReSharper.Psi.Tree.IFile, JetBrains.ReSharper.Psi.Files.ISecondaryRangeTranslator>>, JetBrains.ReSharper.Daemon.Asp.Stages.Analysis.IAspSyntaxAnalysis, JetBrains.ReSharper.Daemon.Html.Stages.Analysis.IHtmlAnalysis, JetBrains.ReSharper.Daemon.Html.Stages.Analysis.IHtmlAnalysis<object>, JetBrains.ReSharper.Daemon.Html.Stages.Analysis.IHtmlSyntaxAnalysis, JetBrains.ReSharper.Psi.IRecursiveElementProcessor<object>
    {
        public AspExpressionAnalysis(JetBrains.ReSharper.Psi.Asp.AspLanguage language) { }
        public override object Init(JetBrains.ReSharper.Psi.Html.Tree.IHtmlFile file, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer) { }
        public override bool InteriorShouldBeProcessed(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.Util.JetTuple<JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer, JetBrains.ReSharper.Psi.Web.Tree.IWebFileWithCodeBehind, JetBrains.ReSharper.Psi.Tree.IFile, JetBrains.ReSharper.Psi.Files.ISecondaryRangeTranslator> context) { }
        public override void ProcessBeforeInterior(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.Util.JetTuple<JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer, JetBrains.ReSharper.Psi.Web.Tree.IWebFileWithCodeBehind, JetBrains.ReSharper.Psi.Tree.IFile, JetBrains.ReSharper.Psi.Files.ISecondaryRangeTranslator> context) { }
    }
    [JetBrains.ReSharper.Daemon.Html.Stages.Analysis.HtmlAnalysisAttribute(typeof(JetBrains.ReSharper.Psi.Asp.AspLanguage))]
    public class AspImageAnalysis : JetBrains.ReSharper.Daemon.Html.Stages.Analysis.HtmlAnalysis<JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer>, JetBrains.ReSharper.Daemon.Asp.Stages.Analysis.IAspSemanticAnalysis, JetBrains.ReSharper.Daemon.Html.Stages.Analysis.IHtmlAnalysis, JetBrains.ReSharper.Daemon.Html.Stages.Analysis.IHtmlAnalysis<object>, JetBrains.ReSharper.Daemon.Html.Stages.Analysis.IHtmlSemanticAnalysis, JetBrains.ReSharper.Psi.IRecursiveElementProcessor<object>
    {
        public AspImageAnalysis(JetBrains.ReSharper.Psi.Asp.AspLanguage language) { }
        public override bool InteriorShouldBeProcessed(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer context) { }
        public override void ProcessAfterInterior(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer highlightings) { }
    }
    [JetBrains.ReSharper.Daemon.Html.Stages.Analysis.HtmlAnalysisAttribute(typeof(JetBrains.ReSharper.Psi.Asp.AspLanguage))]
    public sealed class AspRequiredAttributesAnalysis : JetBrains.ReSharper.Daemon.Html.Stages.Analysis.HtmlAnalysis<JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer>, JetBrains.ReSharper.Daemon.Asp.Stages.Analysis.IAspSyntaxAnalysis, JetBrains.ReSharper.Daemon.Html.Stages.Analysis.IHtmlAnalysis, JetBrains.ReSharper.Daemon.Html.Stages.Analysis.IHtmlAnalysis<object>, JetBrains.ReSharper.Daemon.Html.Stages.Analysis.IHtmlSyntaxAnalysis, JetBrains.ReSharper.Psi.IRecursiveElementProcessor<object>
    {
        public AspRequiredAttributesAnalysis(JetBrains.ReSharper.Psi.Asp.AspLanguage language) { }
        public override bool InteriorShouldBeProcessed(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer context) { }
        public override void ProcessBeforeInterior(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer context) { }
    }
    [JetBrains.ReSharper.Daemon.Html.Stages.Analysis.HtmlAnalysisAttribute(typeof(JetBrains.ReSharper.Psi.Asp.AspLanguage))]
    public class AspScriptAnaysis : JetBrains.ReSharper.Daemon.Html.Stages.Analysis.HtmlAnalysis<JetBrains.Util.JetTuple<JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer>>, JetBrains.ReSharper.Daemon.Asp.Stages.Analysis.IAspSyntaxAnalysis, JetBrains.ReSharper.Daemon.Html.Stages.Analysis.IHtmlAnalysis, JetBrains.ReSharper.Daemon.Html.Stages.Analysis.IHtmlAnalysis<object>, JetBrains.ReSharper.Daemon.Html.Stages.Analysis.IHtmlSyntaxAnalysis, JetBrains.ReSharper.Psi.IRecursiveElementProcessor<object>
    {
        public AspScriptAnaysis(JetBrains.ReSharper.Psi.Asp.AspLanguage language) { }
        public override object Init(JetBrains.ReSharper.Psi.Html.Tree.IHtmlFile file, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer) { }
        public override bool InteriorShouldBeProcessed(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.Util.JetTuple<JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer> context) { }
        public override void ProcessBeforeInterior(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.Util.JetTuple<JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer> context) { }
    }
    [JetBrains.ReSharper.Daemon.Html.Stages.Analysis.HtmlAnalysisAttribute(typeof(JetBrains.ReSharper.Psi.Asp.AspLanguage))]
    public class AspScriptletAnalysis : JetBrains.ReSharper.Daemon.Html.Stages.Analysis.HtmlAnalysis<JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer>, JetBrains.ReSharper.Daemon.Asp.Stages.Analysis.IAspSemanticAnalysis, JetBrains.ReSharper.Daemon.Html.Stages.Analysis.IHtmlAnalysis, JetBrains.ReSharper.Daemon.Html.Stages.Analysis.IHtmlAnalysis<object>, JetBrains.ReSharper.Daemon.Html.Stages.Analysis.IHtmlSemanticAnalysis, JetBrains.ReSharper.Psi.IRecursiveElementProcessor<object>
    {
        public AspScriptletAnalysis(JetBrains.ReSharper.Psi.Asp.AspLanguage language) { }
        public override bool InteriorShouldBeProcessed(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer context) { }
        public override void ProcessAfterInterior(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer highlightings) { }
    }
    [JetBrains.ReSharper.Daemon.Html.Stages.Analysis.HtmlAnalysisAttribute(typeof(JetBrains.ReSharper.Psi.Asp.AspLanguage))]
    public sealed class AspTagNotClosedAnalysis : JetBrains.ReSharper.Daemon.Html.Stages.Analysis.HtmlTagNotClosedAnalysis, JetBrains.ReSharper.Daemon.Asp.Stages.Analysis.IAspSyntaxAnalysis, JetBrains.ReSharper.Daemon.Html.Stages.Analysis.IHtmlAnalysis, JetBrains.ReSharper.Daemon.Html.Stages.Analysis.IHtmlAnalysis<object>, JetBrains.ReSharper.Daemon.Html.Stages.Analysis.IHtmlSyntaxAnalysis, JetBrains.ReSharper.Psi.IRecursiveElementProcessor<object>
    {
        public AspTagNotClosedAnalysis(JetBrains.ReSharper.Psi.Asp.AspLanguage language) { }
        protected override bool DoSupressHighlighting(JetBrains.ReSharper.Psi.Tree.ITreeNode node, JetBrains.Util.JetTuple<JetBrains.ReSharper.Psi.Html.Tree.IHtmlFile, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer, JetBrains.ReSharper.Psi.Html.Html.IHtmlDeclaredElementTypesBase, System.Collections.Generic.HashSet<JetBrains.ReSharper.Psi.Html.Tree.IHtmlTag>> context) { }
        public override object Init(JetBrains.ReSharper.Psi.Html.Tree.IHtmlFile file, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer) { }
        protected override bool ShouldBeClosed(JetBrains.ReSharper.Psi.Html.Tree.IHtmlTag tag, JetBrains.Util.JetTuple<JetBrains.ReSharper.Psi.Html.Tree.IHtmlFile, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer, JetBrains.ReSharper.Psi.Html.Html.IHtmlDeclaredElementTypesBase, System.Collections.Generic.HashSet<JetBrains.ReSharper.Psi.Html.Tree.IHtmlTag>> context) { }
    }
    [JetBrains.ReSharper.Daemon.Html.Stages.Analysis.HtmlAnalysisAttribute(typeof(JetBrains.ReSharper.Psi.Asp.AspLanguage))]
    public class AspVersionRestrictionAnalysis : JetBrains.ReSharper.Daemon.Html.Stages.Analysis.HtmlAnalysis<JetBrains.Util.JetTuple<JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer, JetBrains.ReSharper.Psi.Web.AspNetVersion>>, JetBrains.ReSharper.Daemon.Asp.Stages.Analysis.IAspSyntaxAnalysis, JetBrains.ReSharper.Daemon.Html.Stages.Analysis.IHtmlAnalysis, JetBrains.ReSharper.Daemon.Html.Stages.Analysis.IHtmlAnalysis<object>, JetBrains.ReSharper.Daemon.Html.Stages.Analysis.IHtmlSyntaxAnalysis, JetBrains.ReSharper.Psi.IRecursiveElementProcessor<object>
    {
        public AspVersionRestrictionAnalysis(JetBrains.ReSharper.Psi.Asp.AspLanguage language) { }
        public override object Init(JetBrains.ReSharper.Psi.Html.Tree.IHtmlFile file, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer) { }
        public override bool InteriorShouldBeProcessed(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.Util.JetTuple<JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer, JetBrains.ReSharper.Psi.Web.AspNetVersion> context) { }
        public override void ProcessAfterInterior(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.Util.JetTuple<JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer, JetBrains.ReSharper.Psi.Web.AspNetVersion> context) { }
    }
    public interface IAspSemanticAnalysis : JetBrains.ReSharper.Daemon.Html.Stages.Analysis.IHtmlAnalysis, JetBrains.ReSharper.Daemon.Html.Stages.Analysis.IHtmlAnalysis<object>, JetBrains.ReSharper.Daemon.Html.Stages.Analysis.IHtmlSemanticAnalysis, JetBrains.ReSharper.Psi.IRecursiveElementProcessor<object> { }
    public interface IAspSyntaxAnalysis : JetBrains.ReSharper.Daemon.Html.Stages.Analysis.IHtmlAnalysis, JetBrains.ReSharper.Daemon.Html.Stages.Analysis.IHtmlAnalysis<object>, JetBrains.ReSharper.Daemon.Html.Stages.Analysis.IHtmlSyntaxAnalysis, JetBrains.ReSharper.Psi.IRecursiveElementProcessor<object> { }
    [JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerAttribute(new System.Type[] {
            typeof(JetBrains.ReSharper.Psi.Tree.IExpression)})]
    public class MvcModelTypeAnalyzer : JetBrains.ReSharper.Daemon.Stages.Dispatcher.IElementProblemAnalyzer
    {
        public MvcModelTypeAnalyzer(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Settings.ISettingsStore settingsStore) { }
        public void Run(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerData data, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer) { }
    }
}
namespace JetBrains.ReSharper.Daemon.Asp.Stages
{
    
    public abstract class AspDaemonStageBase : JetBrains.ReSharper.Daemon.Html.Stages.HtmlDaemonStageBase<JetBrains.ReSharper.Psi.Asp.Tree.IAspFile, JetBrains.ReSharper.Psi.Asp.AspLanguage> { }
    public abstract class AspImportDirectivesProcessBase<TFile, TSmartResolverProcess> : JetBrains.ReSharper.Daemon.IDaemonStageProcess
        where TFile :  class, JetBrains.ReSharper.Psi.Tree.IFile
        where TSmartResolverProcess :  class, JetBrains.ReSharper.Daemon.IDaemonStageProcess
    {
        protected AspImportDirectivesProcessBase(JetBrains.ReSharper.Daemon.IDaemonProcess daemonProcess, JetBrains.ReSharper.Psi.Asp.Tree.IAspFile aspFile, TFile codeBehindFile, TSmartResolverProcess smartResolverProcess, JetBrains.Application.Settings.IContextBoundSettingsStore settingsStore) { }
        public JetBrains.ReSharper.Daemon.IDaemonProcess DaemonProcess { get; }
        protected abstract void CheckUsingDirective(JetBrains.ReSharper.Psi.Asp.Tree.IAspDirective aspDirective, JetBrains.ReSharper.Psi.Tree.ITreeNode codeBehindElement, System.Collections.Generic.List<JetBrains.ReSharper.Daemon.HighlightingInfo> highlightings, TSmartResolverProcess smartResolverProcess);
        public void Execute(System.Action<JetBrains.ReSharper.Daemon.DaemonStageResult> committer) { }
    }
    public abstract class AspImportDirectivesStageBase<TFile, TSmartResolverProcess> : JetBrains.ReSharper.Daemon.IDaemonStage
        where TFile :  class, JetBrains.ReSharper.Psi.Tree.IFile
        where TSmartResolverProcess :  class, JetBrains.ReSharper.Daemon.IDaemonStageProcess
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        protected abstract JetBrains.ReSharper.Psi.PsiLanguageType ExpectedLanguage { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Daemon.IDaemonStageProcess> CreateProcess(JetBrains.ReSharper.Daemon.IDaemonProcess process, JetBrains.Application.Settings.IContextBoundSettingsStore settings, JetBrains.ReSharper.Daemon.DaemonProcessKind processKind) { }
        protected abstract JetBrains.ReSharper.Daemon.Asp.Stages.AspImportDirectivesProcessBase<TFile, TSmartResolverProcess> CreateProcess(JetBrains.ReSharper.Daemon.IDaemonProcess process, JetBrains.ReSharper.Psi.Asp.Tree.IAspFile aspFile, TFile codeBehindFile, TSmartResolverProcess smartResolverProcess, JetBrains.Application.Settings.IContextBoundSettingsStore settingsStore);
        public JetBrains.ReSharper.Daemon.ErrorStripeRequest NeedsErrorStripe(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.Application.Settings.IContextBoundSettingsStore settings) { }
    }
    [JetBrains.ReSharper.Daemon.DaemonStageAttribute(StagesBefore=new System.Type[] {
            typeof(JetBrains.ReSharper.Daemon.LanguageSpecificDaemonStage),
            typeof(JetBrains.ReSharper.Daemon.UsageChecking.CollectUsagesStage)})]
    public class MvcDaemonStage : JetBrains.ReSharper.Daemon.IDaemonStage
    {
        public MvcDaemonStage(JetBrains.ReSharper.Psi.Search.SearchDomainFactory searchDomainFactory, JetBrains.Application.Settings.ISettingsOptimization settingsOptimization) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Daemon.IDaemonStageProcess> CreateProcess(JetBrains.ReSharper.Daemon.IDaemonProcess process, JetBrains.Application.Settings.IContextBoundSettingsStore settings, JetBrains.ReSharper.Daemon.DaemonProcessKind processKind) { }
        public JetBrains.ReSharper.Daemon.ErrorStripeRequest NeedsErrorStripe(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.Application.Settings.IContextBoundSettingsStore settings) { }
    }
    public class MvcDaemonStageProcess : JetBrains.ReSharper.Daemon.IDaemonStageProcess
    {
        public MvcDaemonStageProcess(JetBrains.ReSharper.Psi.Search.SearchDomainFactory searchDomainFactory, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Daemon.IDaemonProcess daemonProcess, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Daemon.UsageChecking.CollectUsagesStageProcess collectUsagesStageProcess, JetBrains.Application.Settings.IContextBoundSettingsStore settingsStore) { }
        public JetBrains.ReSharper.Daemon.IDaemonProcess DaemonProcess { get; }
        public void Execute(System.Action<JetBrains.ReSharper.Daemon.DaemonStageResult> committer) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class MvcSettingsDaemonRestarter
    {
        public MvcSettingsDaemonRestarter(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.ReSharper.Daemon.Daemon daemon, JetBrains.ProjectModel.Transaction.IProjectModelBatchChangeManager projectModelBatchChangeManager, JetBrains.ProjectModel.ISolution solution, JetBrains.Threading.IThreading locks) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class MvcSpecificFileImageContributor : JetBrains.ReSharper.Psi.Dependencies.IFileImageContributor
    {
        public MvcSpecificFileImageContributor(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.ProjectModel.ISolution solution, JetBrains.Threading.IThreading locks) { }
        public static JetBrains.ReSharper.ExternalProcessStorage.SolutionAnalysis.Dependency Dependency { get; }
        public System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<JetBrains.ReSharper.ExternalProcessStorage.SolutionAnalysis.Dependency, JetBrains.ReSharper.Psi.Dependencies.Hash>> ModuleDependencies(JetBrains.ReSharper.Psi.Modules.IPsiModule module) { }
        public System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<JetBrains.ReSharper.ExternalProcessStorage.SolutionAnalysis.Dependency, JetBrains.ReSharper.Psi.Dependencies.Hash>> SolutionDependencies(JetBrains.ProjectModel.ISolution solution) { }
    }
}
namespace JetBrains.ReSharper.Daemon.Asp.Stages.Resolve
{
    
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Asp.AspLanguage))]
    public class AspNotResolvedErrorHandler : JetBrains.ReSharper.Daemon.Html.Stages.Resolve.HtmlNotResolvedErrorHandler
    {
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Resolve.ResolveErrorType> ErrorTypes { get; }
        public override JetBrains.ReSharper.Daemon.IHighlighting Run(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
    }
}