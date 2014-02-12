[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("DuplicateResource", null, "CodeSmell", "Duplicate resource name", "Resource file contains two or more items with identical names.", JetBrains.ReSharper.Daemon.Severity.WARNING, false, Internal=false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("RedundantStringType", null, "CodeRedundancy", "Redundant string type", "Explicitly specifying System.String as type of a data entry is redundant.", JetBrains.ReSharper.Daemon.Severity.SUGGESTION, false, Internal=false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("OverridenWithSameValue", null, "CodeRedundancy", "Resource is overridden with identical value", "Base resource item and the current item have the same value.", JetBrains.ReSharper.Daemon.Severity.SUGGESTION, false, Internal=false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("OverridenWithEmptyValue", null, "CodeSmell", "Resource overrides base resource with empty value", "Base resource contains a non-empty value while this resource is empty.", JetBrains.ReSharper.Daemon.Severity.WARNING, false, Internal=false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("NotOverridenInSpecificCulture", null, "CodeSmell", "Resource is not overridden in specific culture", "Resource is not overridden in one or more specific cultures.", JetBrains.ReSharper.Daemon.Severity.WARNING, false, Internal=false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("NotDeclaredInParentCulture", null, "CodeSmell", "Resource is not declared in base culture", "Resource is not declared in base culture.", JetBrains.ReSharper.Daemon.Severity.WARNING, false, Internal=false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("FormatStringPlaceholdersMismatch", null, "CodeSmell", "Format string placeholders mismatch", "Format string placeholders don\'t match between cultures.", JetBrains.ReSharper.Daemon.Severity.WARNING, false, Internal=false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("InvalidValueType", null, "CodeSmell", "Resource value type is invalid", "Resource in base culture has another value type.", JetBrains.ReSharper.Daemon.Severity.WARNING, false, Internal=false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("LocalizableElement", null, "CodeSmell", "Element is localizable", "You can move this element to a resource.", JetBrains.ReSharper.Daemon.Severity.WARNING, false, Internal=false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("ResxNotResolved", null, "CodeSmell", "Cannot resolve symbol", "Cannot resolve symbol.", JetBrains.ReSharper.Daemon.Severity.WARNING, false, Internal=false)]
[assembly: JetBrains.TextControl.DocumentMarkup.RegisterHighlighterAttribute("ReSharper Base and Specific Culture Mark", "{C2725EB9-3B53-42B6-B881-6D21F1577CC3}", EffectType=JetBrains.TextControl.DocumentMarkup.EffectType.GUTTER_MARK, GutterMarkType=typeof(JetBrains.ReSharper.Daemon.Resx.Errors.SpecificAndBaseCultureGutterMark), Layer=2001)]
[assembly: JetBrains.TextControl.DocumentMarkup.RegisterHighlighterAttribute("ReSharper Base Culture Mark", "{4C059ECB-683C-4E0E-BFA9-40FC23DBC451}", EffectType=JetBrains.TextControl.DocumentMarkup.EffectType.GUTTER_MARK, GutterMarkType=typeof(JetBrains.ReSharper.Daemon.Resx.Errors.BaseCultureGutterMark), Layer=2001)]
[assembly: JetBrains.TextControl.DocumentMarkup.RegisterHighlighterAttribute("ReSharper Specific Culture Mark", "{B44F82F5-F5B5-48AB-9C94-03F4A435E73F}", EffectType=JetBrains.TextControl.DocumentMarkup.EffectType.GUTTER_MARK, GutterMarkType=typeof(JetBrains.ReSharper.Daemon.Resx.Errors.SpecificCultureGutterMark), Layer=2001)]
[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]

namespace JetBrains.ReSharper.Daemon.Resx.Errors
{
    
    public class BaseCultureGutterMark : JetBrains.ReSharper.Daemon.Resx.Errors.ResourceGutterMarkBase
    {
        public BaseCultureGutterMark(JetBrains.UI.Icons.IThemedIconManager a) { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("DuplicateResource", "RESX", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.WARNING, ToolTipFormatString="Duplicate resource \'{0}\'")]
    public class DuplicateResourceWarning : JetBrains.ReSharper.Daemon.Resx.ResxHighlightingBase, JetBrains.ReSharper.Daemon.IHighlighting, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "DuplicateResource";
        protected const string MESSAGE = "Duplicate resource \'{0}\'";
        public DuplicateResourceWarning(JetBrains.ReSharper.Psi.Resx.IResourceItem item) { }
        public string ErrorStripeToolTip { get; }
        public JetBrains.ReSharper.Psi.Resx.IResourceItem Item { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("FormatStringPlaceholdersMismatch", "RESX", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.WARNING, ToolTipFormatString="Format string placeholders mismatch")]
    public class FormatStringPlaceholdersMismatchWarning : JetBrains.ReSharper.Daemon.Resx.ResxHighlightingBase, JetBrains.ReSharper.Daemon.IHighlighting, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "FormatStringPlaceholdersMismatch";
        protected const string MESSAGE = "Format string placeholders mismatch";
        public FormatStringPlaceholdersMismatchWarning(JetBrains.ReSharper.Psi.Resx.IResourceItem item) { }
        public string ErrorStripeToolTip { get; }
        public JetBrains.ReSharper.Psi.Resx.IResourceItem Item { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("InvalidValueType", "RESX", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.WARNING, ToolTipFormatString="Resource type \'{0}\' is not equal to the base type \'{1}\'")]
    public class InvalidValueTypeWarning : JetBrains.ReSharper.Daemon.Resx.ResxHighlightingBase, JetBrains.ReSharper.Daemon.IHighlighting, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "InvalidValueType";
        protected const string MESSAGE = "Resource type \'{0}\' is not equal to the base type \'{1}\'";
        public InvalidValueTypeWarning(JetBrains.ReSharper.Psi.Resx.IResourceItem item, JetBrains.ReSharper.Psi.IType valueType, JetBrains.ReSharper.Psi.IType baseType) { }
        public JetBrains.ReSharper.Psi.IType BaseType { get; }
        public string ErrorStripeToolTip { get; }
        public JetBrains.ReSharper.Psi.Resx.IResourceItem Item { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public JetBrains.ReSharper.Psi.IType ValueType { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("LocalizableElement", "RESX", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.WARNING, ToolTipFormatString="Element is localizable")]
    public class LocalizableElementWarning : JetBrains.ReSharper.Daemon.Resx.ResxHighlightingBase, JetBrains.ReSharper.Daemon.IHighlighting, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "LocalizableElement";
        protected const string MESSAGE = "Element is localizable";
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("NotDeclaredInParentCulture", "RESX", AttributeId="ReSharper Dead Code", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.DEADCODE, ToolTipFormatString="Resource is not declared in {0}")]
    public class NotDeclaredInParentCultureWarning : JetBrains.ReSharper.Daemon.Resx.ResxHighlightingBase, JetBrains.ReSharper.Daemon.IHighlighting, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "NotDeclaredInParentCulture";
        protected const string MESSAGE = "Resource is not declared in {0}";
        public NotDeclaredInParentCultureWarning(JetBrains.ReSharper.Psi.Resx.IResourceItem item, JetBrains.ReSharper.Psi.IPsiSourceFile[] resourceFiles, JetBrains.ReSharper.Psi.Resx.Services.ResourceService resourceService) { }
        public string ErrorStripeToolTip { get; }
        public JetBrains.ReSharper.Psi.Resx.IResourceItem Item { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.IPsiSourceFile[] ResourceFiles { get; }
        public JetBrains.ReSharper.Psi.Resx.Services.ResourceService ResourceService { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("NotOverridenInSpecificCulture", "RESX", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.WARNING, ToolTipFormatString="Resource is not overridden in {0}")]
    public class NotOverridenInSpecificCultureWarning : JetBrains.ReSharper.Daemon.Resx.ResxHighlightingBase, JetBrains.ReSharper.Daemon.IHighlighting, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "NotOverridenInSpecificCulture";
        protected const string MESSAGE = "Resource is not overridden in {0}";
        public NotOverridenInSpecificCultureWarning(JetBrains.ReSharper.Psi.Resx.IResourceItem item, JetBrains.ReSharper.Psi.IPsiSourceFile[] resourceFiles, JetBrains.ReSharper.Psi.Resx.Services.ResourceService resourceService) { }
        public string ErrorStripeToolTip { get; }
        public JetBrains.ReSharper.Psi.Resx.IResourceItem Item { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.IPsiSourceFile[] ResourceFiles { get; }
        public JetBrains.ReSharper.Psi.Resx.Services.ResourceService ResourceService { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("OverridenWithEmptyValue", "RESX", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.WARNING, ToolTipFormatString="Resource overrides base resource with empty value")]
    public class OverridenWithEmptyValueWarning : JetBrains.ReSharper.Daemon.Resx.ResxHighlightingBase, JetBrains.ReSharper.Daemon.IHighlighting, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "OverridenWithEmptyValue";
        protected const string MESSAGE = "Resource overrides base resource with empty value";
        public OverridenWithEmptyValueWarning(JetBrains.ReSharper.Psi.Resx.IResourceItem item) { }
        public string ErrorStripeToolTip { get; }
        public JetBrains.ReSharper.Psi.Resx.IResourceItem Item { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("OverridenWithSameValue", "RESX", AttributeId="ReSharper Dead Code", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.DEADCODE, ToolTipFormatString="Resource is overridden with identical value")]
    public class OverridenWithSameValueWarning : JetBrains.ReSharper.Daemon.Resx.ResxHighlightingBase, JetBrains.ReSharper.Daemon.IHighlighting, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "OverridenWithSameValue";
        protected const string MESSAGE = "Resource is overridden with identical value";
        public OverridenWithSameValueWarning(JetBrains.ReSharper.Psi.Resx.IResourceItem item) { }
        public string ErrorStripeToolTip { get; }
        public JetBrains.ReSharper.Psi.Resx.IResourceItem Item { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("RedundantStringType", "RESX", AttributeId="ReSharper Dead Code", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.DEADCODE, ToolTipFormatString="Resource type is redundant")]
    public class RedundantStringTypeWarning : JetBrains.ReSharper.Daemon.Resx.ResxHighlightingBase, JetBrains.ReSharper.Daemon.IHighlighting, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "RedundantStringType";
        protected const string MESSAGE = "Resource type is redundant";
        public RedundantStringTypeWarning(JetBrains.ReSharper.Psi.Resx.Tree.IResxAttribute attribute) { }
        public JetBrains.ReSharper.Psi.Resx.Tree.IResxAttribute Attribute { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    public abstract class ResourceGutterMarkBase : JetBrains.TextControl.DocumentMarkup.IconGutterMark
    {
        protected ResourceGutterMarkBase(JetBrains.UI.Icons.IconId a, JetBrains.UI.Icons.IThemedIconManager b) { }
        public override System.Collections.Generic.IEnumerable<JetBrains.UI.BulbMenu.BulbMenuItem> GetBulbMenuItems(JetBrains.TextControl.DocumentMarkup.IHighlighter highlighter) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.KnownLanguage))]
    public class ResourceResolveErrorHelper : JetBrains.ReSharper.Daemon.Stages.Resolve.IResolveProblemHighlighter
    {
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Resolve.ResolveErrorType> ErrorTypes { get; }
        public JetBrains.ReSharper.Daemon.IHighlighting Run(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("ResxNotResolved", "RESX", AttributeId="ReSharper Error Highlighting", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.WARNING, ToolTipFormatString="{0}")]
    public class ResxNotResolvedWarning : JetBrains.ReSharper.Daemon.Resx.ResxHighlightingBase, JetBrains.ReSharper.Daemon.IHighlighting, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "ResxNotResolved";
        protected const string MESSAGE = "{0}";
        public ResxNotResolvedWarning(JetBrains.ReSharper.Psi.Resolve.IReference reference, string text) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.Resolve.IReference Reference { get; }
        public string Text { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    public class SpecificAndBaseCultureGutterMark : JetBrains.ReSharper.Daemon.Resx.Errors.ResourceGutterMarkBase
    {
        public SpecificAndBaseCultureGutterMark(JetBrains.UI.Icons.IThemedIconManager a) { }
    }
    public class SpecificCultureGutterMark : JetBrains.ReSharper.Daemon.Resx.Errors.ResourceGutterMarkBase
    {
        public SpecificCultureGutterMark(JetBrains.UI.Icons.IThemedIconManager a) { }
    }
}
namespace JetBrains.ReSharper.Daemon.Resx
{
    
    public abstract class ResxHighlightingBase : JetBrains.ReSharper.Daemon.HighlightingBase { }
}
namespace JetBrains.ReSharper.Daemon.Resx.Stages.Resolve
{
    
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Resx.ResxLanguage))]
    public class ResxNotResolvedErrorHandler : JetBrains.ReSharper.Daemon.Xml.Stages.Resolve.XmlNotResolvedErrorHandler
    {
        protected override JetBrains.ReSharper.Daemon.IHighlighting CreateNotResolvedErrorHighlighting(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
    }
}