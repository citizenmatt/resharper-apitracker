[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("Redundant", null, "CodeRedundancy", "Redundant code", "Code is redundant.", JetBrains.ReSharper.Daemon.Severity.WARNING, false, Internal=false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("DeclarationIsEmpty", null, "DeclarationRedundancy", "Declaration is empty", "Declaration doesn\'t contain any properties.", JetBrains.ReSharper.Daemon.Severity.WARNING, false, Internal=false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("RequiresFallbackColor", null, "CodeSmell", "Requires fallback color", "Fallback color (hex or RGB) should precede color with new format (rgba, hsl, and " +
    "hsla).", JetBrains.ReSharper.Daemon.Severity.WARNING, false, Internal=false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("CssPropertyDoesNotOverrideVendorProperty", null, "CodeSmell", "Property does not override vendor-prefixed property", "Standard property should be set after vendor-prefixed property.", JetBrains.ReSharper.Daemon.Severity.WARNING, false, Internal=false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("RedundantUnits", null, "CodeRedundancy", "Redundant measure unit", "Unit of measure is redundant for zero value.", JetBrains.ReSharper.Daemon.Severity.WARNING, false, Internal=false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("InvalidValue", null, "CodeSmell", "Invalid value", "Invalid CSS value.", JetBrains.ReSharper.Daemon.Severity.ERROR, false, Internal=false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("CssBrowserCompatibility", null, "CodeSmell", "CSS symbol is not compatible with a specific browser", "CSS symbol is not compatible with a specific browser.", JetBrains.ReSharper.Daemon.Severity.WARNING, false, Internal=false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("PathNotResolved", null, "CodeSmell", "Cannot resolve file system path", "Cannot resolve file system path.", JetBrains.ReSharper.Daemon.Severity.ERROR, false, Internal=false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("UnknownCssVendorExtension", null, "CodeSmell", "Unknown vendor-specific extension", "Cannot resolve vendor-specific extension.", JetBrains.ReSharper.Daemon.Severity.HINT, false, Internal=false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("UnknownCssClass", null, "CodeSmell", "Unknown CSS class", "Cannot resolve CSS class with specified name.", JetBrains.ReSharper.Daemon.Severity.WARNING, false, Internal=false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("CssNotResolved", null, "CodeSmell", "Unknown CSS symbol", "Cannot resolve symbol with specified name.", JetBrains.ReSharper.Daemon.Severity.ERROR, false, Internal=false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("UnexpectedValue", null, "CodeSmell", "Value is unexpected", "This value will be ignored.", JetBrains.ReSharper.Daemon.Severity.ERROR, false, Internal=false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("HexColorValueWithAlpha", null, "CodeSmell", "Invalid hexadecimal value of color", "Hexadecimal value of color with alpha component is not supported.", JetBrains.ReSharper.Daemon.Severity.ERROR, false, Internal=false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("SyntaxIsNotAllowed", null, "CodeSmell", "Syntax is not allowed in specified CSS version", "Syntax is not allowed in specified CSS version.", JetBrains.ReSharper.Daemon.Severity.WARNING, false, Internal=false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("CssObsolete", null, "CodeSmell", "CSS symbol is obsolete", "CSS symbol is considered obsolete in specified language version.", JetBrains.ReSharper.Daemon.Severity.WARNING, false, Internal=false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterStaticHighlightingsGroupAttribute("CssErrors", "Css Errors", true)]
[assembly: JetBrains.TextControl.DocumentMarkup.RegisterHighlighterAttribute("ReSharper CSS keyword", "{1636DFFC-4ABA-4665-8E3A-E72170DCCA94}", DarkForegroundColor="LightSkyBlue", EffectType=JetBrains.TextControl.DocumentMarkup.EffectType.TEXT, ForegroundColor="Blue", Layer=2000, VSPriority=40)]
[assembly: JetBrains.TextControl.DocumentMarkup.RegisterHighlighterAttribute("ReSharper CSS value", "{D39042CA-256D-4F7A-808F-C27924D89704}", DarkForegroundColor="LightSkyBlue", EffectType=JetBrains.TextControl.DocumentMarkup.EffectType.TEXT, ForegroundColor="Blue", Layer=2000, VSPriority=40)]
[assembly: JetBrains.TextControl.DocumentMarkup.RegisterHighlighterAttribute("ReSharper CSS id selector", "{ED00C13A-7E0E-4590-BB77-EDC7939A5F08}", DarkForegroundColor="LightSkyBlue", EffectType=JetBrains.TextControl.DocumentMarkup.EffectType.TEXT, ForegroundColor="Blue", Layer=2000, VSPriority=40)]
[assembly: JetBrains.TextControl.DocumentMarkup.RegisterHighlighterAttribute("ReSharper CSS class selector", "{2A55BD84-4CF3-4144-8C8A-B278591D891F}", DarkForegroundColor="Plum", EffectType=JetBrains.TextControl.DocumentMarkup.EffectType.TEXT, ForegroundColor="Magenta", Layer=2000, VSPriority=40)]
[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]

namespace JetBrains.ReSharper.Daemon.Css.Highlightings
{
    
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.INFO, "IdentifierHighlightings", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.NONE, ShowToolTipInStatusBar=false)]
    public class CssCustomHighlighting : JetBrains.ReSharper.Daemon.ICustomAttributeIdHighlighting, JetBrains.ReSharper.Daemon.IHighlighting
    {
        public CssCustomHighlighting(string attributeId) { }
        public string AttributeId { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public bool IsValid() { }
    }
    public class CssCustomHighlightings
    {
        public static readonly JetBrains.ReSharper.Daemon.IHighlighting AttributeName;
        public static readonly JetBrains.ReSharper.Daemon.IHighlighting ClassSelector;
        public static readonly JetBrains.ReSharper.Daemon.IHighlighting IdSelector;
        public static readonly JetBrains.ReSharper.Daemon.IHighlighting Invocation;
        public static readonly JetBrains.ReSharper.Daemon.IHighlighting Keyword;
        public static readonly JetBrains.ReSharper.Daemon.IHighlighting MediaFeature;
        public static readonly JetBrains.ReSharper.Daemon.IHighlighting Property;
        public static readonly JetBrains.ReSharper.Daemon.IHighlighting PseudoClass;
        public static readonly JetBrains.ReSharper.Daemon.IHighlighting PseudoElement;
        public static readonly JetBrains.ReSharper.Daemon.IHighlighting PseudoFunction;
        public static readonly JetBrains.ReSharper.Daemon.IHighlighting Value;
    }
    [JetBrains.ReSharper.Daemon.DaemonTooltipProviderAttribute(typeof(JetBrains.ReSharper.Daemon.Css.Impl.CssIdentifierTooltipProvider))]
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.INFO, "IdentifierHighlightings", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.NONE, ShowToolTipInStatusBar=false)]
    public sealed class CssCustomHighlightingWithToolTip : JetBrains.ReSharper.Daemon.Css.Highlightings.CssCustomHighlighting
    {
        public CssCustomHighlightingWithToolTip(string attributeId) { }
    }
    public class static CssHighlightingAttributeIds
    {
        public const string CSS_CLASS_SELECTOR = "ReSharper CSS class selector";
        public const string CSS_ID_SELECTOR = "ReSharper CSS id selector";
        public const string CSS_KEYWORD = "ReSharper CSS keyword";
        public const string CSS_VALUE = "ReSharper CSS value";
    }
    public abstract class CssHighlightingBase : JetBrains.ReSharper.Daemon.IHighlighting
    {
        public abstract bool IsValid();
    }
}
namespace JetBrains.ReSharper.Daemon.Css.Impl
{
    
    public abstract class CssDaemonStageBase : JetBrains.ReSharper.Daemon.IDaemonStage
    {
        protected abstract JetBrains.ReSharper.Daemon.IDaemonStageProcess CreateProcess(JetBrains.ReSharper.Daemon.IDaemonProcess process, JetBrains.Application.Settings.IContextBoundSettingsStore settings, JetBrains.ReSharper.Daemon.DaemonProcessKind processKind, JetBrains.ReSharper.Psi.Css.Tree.ICssFile file);
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Daemon.IDaemonStageProcess> CreateProcess(JetBrains.ReSharper.Daemon.IDaemonProcess process, JetBrains.Application.Settings.IContextBoundSettingsStore settings, JetBrains.ReSharper.Daemon.DaemonProcessKind processKind) { }
        protected static bool IsSupported(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        public abstract JetBrains.ReSharper.Daemon.ErrorStripeRequest NeedsErrorStripe(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.Application.Settings.IContextBoundSettingsStore settings);
    }
    public abstract class CssDaemonStageProcessBase : JetBrains.ReSharper.Psi.Css.Tree.TreeNodeVisitor<JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer>, JetBrains.ReSharper.Daemon.IDaemonStageProcess, JetBrains.ReSharper.Psi.IRecursiveElementProcessor<JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer>
    {
        protected CssDaemonStageProcessBase(JetBrains.ReSharper.Daemon.IDaemonProcess process, JetBrains.Application.Settings.IContextBoundSettingsStore settingsStore, JetBrains.ReSharper.Psi.Css.Tree.ICssFile file) { }
        public JetBrains.ReSharper.Daemon.IDaemonProcess DaemonProcess { get; }
        public JetBrains.DocumentModel.IDocument Document { get; }
        public JetBrains.ReSharper.Psi.Css.Tree.ICssFile File { get; }
        public JetBrains.ReSharper.Psi.Modules.IPsiModule PsiModule { get; }
        public JetBrains.ReSharper.Psi.IPsiSourceFile SourceFile { get; }
        public virtual void Execute(System.Action<JetBrains.ReSharper.Daemon.DaemonStageResult> committer) { }
        protected void HighlightInFile(System.Action<JetBrains.ReSharper.Psi.Css.Tree.ICssFile, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer> fileHighlighter, System.Action<JetBrains.ReSharper.Daemon.DaemonStageResult> commiter) { }
        public virtual bool InteriorShouldBeProcessed(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer) { }
        public bool IsProcessingFinished(JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer context) { }
        public virtual void ProcessAfterInterior(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer) { }
        public virtual void ProcessBeforeInterior(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer) { }
    }
    public class CssFileStructure : JetBrains.ReSharper.Daemon.Stages.FileStructureBase
    {
        public CssFileStructure(JetBrains.ReSharper.Psi.Css.Tree.ICssFile file) { }
    }
    [JetBrains.ReSharper.Daemon.Stages.FileStructureExplorerAttribute()]
    public class CssFileStructureExplorer : JetBrains.ReSharper.Daemon.Stages.IFileStructureExplorer
    {
        public JetBrains.ReSharper.Daemon.Stages.IFileStructure Run(System.Predicate<JetBrains.DocumentModel.DocumentRange> isRangeInvalidated, JetBrains.ReSharper.Psi.IPsiSourceFile psiSourceFile, JetBrains.Application.Settings.IContextBoundSettingsStore settingsStore, JetBrains.ReSharper.Psi.Tree.IFile file) { }
    }
    public class ResolveProblemHighlighter
    {
        public ResolveProblemHighlighter([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.Tree.ICssFile file, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Daemon.Stages.Resolve.ResolveHighlighterRegistrar resolveHighlighterRegistrar) { }
        public void CheckForResolveProblems(JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer, JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Css.CssLanguageVersion version) { }
    }
}
namespace JetBrains.ReSharper.Daemon.Css.Stages
{
    
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("CssBrowserCompatibility", "CSS", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.WARNING, ToolTipFormatString="The {0} is not compatible with {1}")]
    public class CssBrowserCompatibilityWarning : JetBrains.ReSharper.Daemon.Css.Highlightings.CssHighlightingBase, JetBrains.ReSharper.Daemon.IHighlighting, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "CssBrowserCompatibility";
        protected const string MESSAGE = "The {0} is not compatible with {1}";
        public CssBrowserCompatibilityWarning(System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.Css.BrowserCompatibility.BrowserInfo> browsers, JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.Css.BrowserCompatibility.BrowserInfo> Browsers { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.Resolve.IReference Reference { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("CssNotResolved", "CSS", AttributeId="ReSharper Error Highlighting", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.UNRESOLVED_ERROR, ToolTipFormatString="Symbol \'{0}\' doesn\'t exist in CSS {1}")]
    public class CssNotResolvedError : JetBrains.ReSharper.Daemon.Css.Highlightings.CssHighlightingBase, JetBrains.ReSharper.Daemon.IHighlighting, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "CssNotResolved";
        protected const string MESSAGE = "Symbol \'{0}\' doesn\'t exist in CSS {1}";
        public CssNotResolvedError(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.Css.CssLanguageVersion version) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.Resolve.IReference Reference { get; }
        public string ToolTip { get; }
        public JetBrains.ReSharper.Psi.Css.CssLanguageVersion Version { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("CssObsolete", "CSS", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.WARNING, ToolTipFormatString="{0}")]
    public class CssObsoleteWarning : JetBrains.ReSharper.Daemon.Css.Highlightings.CssHighlightingBase, JetBrains.ReSharper.Daemon.IHighlighting, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "CssObsolete";
        protected const string MESSAGE = "{0}";
        public CssObsoleteWarning(string text, JetBrains.DocumentModel.DocumentRange documentRange) { }
        public JetBrains.DocumentModel.DocumentRange DocumentRange { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string Text { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("CssPropertyDoesNotOverrideVendorProperty", "CSS", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.WARNING, ToolTipFormatString="Property \'{0}\' should come after vendor-specific properties.")]
    public class CssPropertyDoesNotOverrideVendorPropertyWarning : JetBrains.ReSharper.Daemon.Css.Highlightings.CssHighlightingBase, JetBrains.ReSharper.Daemon.IHighlighting, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "CssPropertyDoesNotOverrideVendorProperty";
        protected const string MESSAGE = "Property \'{0}\' should come after vendor-specific properties.";
        public CssPropertyDoesNotOverrideVendorPropertyWarning(JetBrains.ReSharper.Psi.Css.Tree.ICssProperty property) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.Css.Tree.ICssProperty Property { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "CssErrors", AttributeId="ReSharper Underlined Error Highlighting", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR, ToolTipFormatString="{0}")]
    public class CssSyntaxError : JetBrains.ReSharper.Daemon.Css.Highlightings.CssHighlightingBase, JetBrains.ReSharper.Daemon.IHighlighting, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "{0}";
        public CssSyntaxError(string text, JetBrains.DocumentModel.DocumentRange documentRange) { }
        public JetBrains.DocumentModel.DocumentRange DocumentRange { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string Text { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("DeclarationIsEmpty", "CSS", AttributeId="ReSharper Dead Code", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.DEADCODE, ToolTipFormatString="Declaration is empty")]
    public class DeclarationIsEmptyWarning : JetBrains.ReSharper.Daemon.Css.Highlightings.CssHighlightingBase, JetBrains.ReSharper.Daemon.IHighlighting, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "DeclarationIsEmpty";
        protected const string MESSAGE = "Declaration is empty";
        public DeclarationIsEmptyWarning(JetBrains.ReSharper.Psi.Tree.ITreeNode node) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.Tree.ITreeNode Node { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("HexColorValueWithAlpha", "CSS", AttributeId="ReSharper Underlined Error Highlighting", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR, ToolTipFormatString="Value of color with alpha component is not supported.")]
    public class HexColorValueWithAlphaError : JetBrains.ReSharper.Daemon.Css.Highlightings.CssHighlightingBase, JetBrains.ReSharper.Daemon.IHighlighting, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "HexColorValueWithAlpha";
        protected const string MESSAGE = "Value of color with alpha component is not supported.";
        public HexColorValueWithAlphaError(JetBrains.ReSharper.Psi.Css.Tree.ICssColorExpression node) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.Css.Tree.ICssColorExpression Node { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.DaemonStageAttribute()]
    public class IdentifierHighlightingStage : JetBrains.ReSharper.Daemon.Css.Impl.CssDaemonStageBase
    {
        protected override JetBrains.ReSharper.Daemon.IDaemonStageProcess CreateProcess(JetBrains.ReSharper.Daemon.IDaemonProcess process, JetBrains.Application.Settings.IContextBoundSettingsStore settings, JetBrains.ReSharper.Daemon.DaemonProcessKind processKind, JetBrains.ReSharper.Psi.Css.Tree.ICssFile file) { }
        public override JetBrains.ReSharper.Daemon.ErrorStripeRequest NeedsErrorStripe(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.Application.Settings.IContextBoundSettingsStore settings) { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("InvalidValue", "CSS", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR, ToolTipFormatString="{0}")]
    public class InvalidValueError : JetBrains.ReSharper.Daemon.Css.Highlightings.CssHighlightingBase, JetBrains.ReSharper.Daemon.IHighlighting, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "InvalidValue";
        protected const string MESSAGE = "{0}";
        public InvalidValueError(string text, JetBrains.DocumentModel.DocumentRange documentRange, System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.Css.Validation.IFailDescription> descriptions) { }
        public System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.Css.Validation.IFailDescription> Descriptions { get; }
        public JetBrains.DocumentModel.DocumentRange DocumentRange { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string Text { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("PathNotResolved", "CSS", AttributeId="ReSharper Error Highlighting", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.UNRESOLVED_ERROR, ToolTipFormatString="{0}")]
    public class PathNotResolvedError : JetBrains.ReSharper.Daemon.Css.Highlightings.CssHighlightingBase, JetBrains.ReSharper.Daemon.IHighlighting, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "PathNotResolved";
        protected const string MESSAGE = "{0}";
        public PathNotResolvedError(JetBrains.ReSharper.Psi.Resolve.IPathReference reference, JetBrains.ReSharper.Psi.Resolve.FileResolveErrorType errorType) { }
        public string ErrorStripeToolTip { get; }
        public JetBrains.ReSharper.Psi.Resolve.FileResolveErrorType ErrorType { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.Resolve.IPathReference Reference { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("Redundant", "CSS", AttributeId="ReSharper Dead Code", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.DEADCODE, ToolTipFormatString="{0} is redundant")]
    public class RedundantWarning : JetBrains.ReSharper.Daemon.Css.Highlightings.CssHighlightingBase, JetBrains.ReSharper.Daemon.IHighlighting, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "Redundant";
        protected const string MESSAGE = "{0} is redundant";
        public RedundantWarning(JetBrains.ReSharper.Psi.Tree.ITreeNode node, string text) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.Tree.ITreeNode Node { get; }
        public string Text { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("RequiresFallbackColor", "CSS", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.WARNING, ToolTipFormatString="Requires fallback color")]
    public class RequiresFallbackColorWarning : JetBrains.ReSharper.Daemon.Css.Highlightings.CssHighlightingBase, JetBrains.ReSharper.Daemon.IHighlighting, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "RequiresFallbackColor";
        protected const string MESSAGE = "Requires fallback color";
        public RequiresFallbackColorWarning(JetBrains.ReSharper.Psi.Css.Tree.ICssInvocationExpression node) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.Css.Tree.ICssInvocationExpression Node { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.DaemonStageAttribute()]
    public class SyntaxHighlightingStage : JetBrains.ReSharper.Daemon.Css.Impl.CssDaemonStageBase
    {
        protected override JetBrains.ReSharper.Daemon.IDaemonStageProcess CreateProcess(JetBrains.ReSharper.Daemon.IDaemonProcess process, JetBrains.Application.Settings.IContextBoundSettingsStore settings, JetBrains.ReSharper.Daemon.DaemonProcessKind processKind, JetBrains.ReSharper.Psi.Css.Tree.ICssFile file) { }
        public override JetBrains.ReSharper.Daemon.ErrorStripeRequest NeedsErrorStripe(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.Application.Settings.IContextBoundSettingsStore settings) { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("SyntaxIsNotAllowed", "CSS", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR, ToolTipFormatString="Syntax is not allowed in CSS {0}")]
    public class SyntaxIsNotAllowedError : JetBrains.ReSharper.Daemon.Css.Highlightings.CssHighlightingBase, JetBrains.ReSharper.Daemon.IHighlighting, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "SyntaxIsNotAllowed";
        protected const string MESSAGE = "Syntax is not allowed in CSS {0}";
        public SyntaxIsNotAllowedError(JetBrains.DocumentModel.DocumentRange documentRange, JetBrains.ReSharper.Psi.Css.Tree.ICssVersionSpecific node, JetBrains.ReSharper.Psi.Css.CssLanguageVersion version) { }
        public JetBrains.DocumentModel.DocumentRange DocumentRange { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.Css.Tree.ICssVersionSpecific Node { get; }
        public string ToolTip { get; }
        public JetBrains.ReSharper.Psi.Css.CssLanguageVersion Version { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("UnexpectedValue", "CSS", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR, ToolTipFormatString="{0}")]
    public class UnexpectedValueError : JetBrains.ReSharper.Daemon.Css.Highlightings.CssHighlightingBase, JetBrains.ReSharper.Daemon.IHighlighting, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "UnexpectedValue";
        protected const string MESSAGE = "{0}";
        public UnexpectedValueError(string text, JetBrains.ReSharper.Psi.ITreeRange treeRange) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string Text { get; }
        public string ToolTip { get; }
        public JetBrains.ReSharper.Psi.ITreeRange TreeRange { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("RedundantUnits", "CSS", AttributeId="ReSharper Dead Code", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.DEADCODE, ToolTipFormatString="Unit of measure is redundant")]
    public class UnitMeasureRedundantWarning : JetBrains.ReSharper.Daemon.Css.Highlightings.CssHighlightingBase, JetBrains.ReSharper.Daemon.IHighlighting, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "RedundantUnits";
        protected const string MESSAGE = "Unit of measure is redundant";
        public UnitMeasureRedundantWarning(JetBrains.ReSharper.Psi.Css.Tree.ICssLiteralExpression expression) { }
        public string ErrorStripeToolTip { get; }
        public JetBrains.ReSharper.Psi.Css.Tree.ICssLiteralExpression Expression { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("CssNotResolved", "CSS", AttributeId="ReSharper Error Highlighting", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.UNRESOLVED_ERROR, ToolTipFormatString="Cannot resolve @keyframes with name \'{0}\'")]
    public class UnknownAnimationError : JetBrains.ReSharper.Daemon.Css.Highlightings.CssHighlightingBase, JetBrains.ReSharper.Daemon.IHighlighting, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "CssNotResolved";
        protected const string MESSAGE = "Cannot resolve @keyframes with name \'{0}\'";
        public UnknownAnimationError(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.Css.CssLanguageVersion version) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.Resolve.IReference Reference { get; }
        public string ToolTip { get; }
        public JetBrains.ReSharper.Psi.Css.CssLanguageVersion Version { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("CssNotResolved", "CSS", AttributeId="ReSharper Error Highlighting", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.UNRESOLVED_ERROR, ToolTipFormatString="Cannot resolve @color-profile with name \'{0}\'")]
    public class UnknownColorProfileError : JetBrains.ReSharper.Daemon.Css.Highlightings.CssHighlightingBase, JetBrains.ReSharper.Daemon.IHighlighting, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "CssNotResolved";
        protected const string MESSAGE = "Cannot resolve @color-profile with name \'{0}\'";
        public UnknownColorProfileError(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.Css.CssLanguageVersion version) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.Resolve.IReference Reference { get; }
        public string ToolTip { get; }
        public JetBrains.ReSharper.Psi.Css.CssLanguageVersion Version { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("UnknownCssClass", "CSS", AttributeId="ReSharper Error Highlighting", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.UNRESOLVED_ERROR, ToolTipFormatString="Unknown CSS class \'{0}\'")]
    public class UnknownCssClassError : JetBrains.ReSharper.Daemon.Css.Highlightings.CssHighlightingBase, JetBrains.ReSharper.Daemon.IHighlighting, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "UnknownCssClass";
        protected const string MESSAGE = "Unknown CSS class \'{0}\'";
        public UnknownCssClassError(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.Resolve.IReference Reference { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("CssNotResolved", "CSS", AttributeId="ReSharper Error Highlighting", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.UNRESOLVED_ERROR, ToolTipFormatString="Property \'{0}\' doesn\'t exist in CSS {1}")]
    public class UnknownCssPropertyError : JetBrains.ReSharper.Daemon.Css.Highlightings.CssHighlightingBase, JetBrains.ReSharper.Daemon.IHighlighting, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "CssNotResolved";
        protected const string MESSAGE = "Property \'{0}\' doesn\'t exist in CSS {1}";
        public UnknownCssPropertyError(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.Css.CssLanguageVersion version) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.Resolve.IReference Reference { get; }
        public string ToolTip { get; }
        public JetBrains.ReSharper.Psi.Css.CssLanguageVersion Version { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("UnknownCssVendorExtension", "CSS", AttributeId="ReSharper Error Highlighting", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.UNRESOLVED_ERROR, ToolTipFormatString="Unknown vendor-specific extension \'{0}\'")]
    public class UnknownCssVendorExtensionError : JetBrains.ReSharper.Daemon.Css.Highlightings.CssHighlightingBase, JetBrains.ReSharper.Daemon.IHighlighting, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "UnknownCssVendorExtension";
        protected const string MESSAGE = "Unknown vendor-specific extension \'{0}\'";
        public UnknownCssVendorExtensionError(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.Resolve.IReference Reference { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("UnknownCssVendorExtension", "CSS", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR, ToolTipFormatString="{0}")]
    public class UnknownCssVendorValueExtensionError : JetBrains.ReSharper.Daemon.Css.Highlightings.CssHighlightingBase, JetBrains.ReSharper.Daemon.IHighlighting, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "UnknownCssVendorExtension";
        protected const string MESSAGE = "{0}";
        public UnknownCssVendorValueExtensionError(string text, JetBrains.DocumentModel.DocumentRange documentRange) { }
        public JetBrains.DocumentModel.DocumentRange DocumentRange { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string Text { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("CssNotResolved", "CSS", AttributeId="ReSharper Error Highlighting", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.UNRESOLVED_ERROR, ToolTipFormatString="Function \'{0}\' doesn\'t exist in CSS {1}")]
    public class UnknownFunctionError : JetBrains.ReSharper.Daemon.Css.Highlightings.CssHighlightingBase, JetBrains.ReSharper.Daemon.IHighlighting, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "CssNotResolved";
        protected const string MESSAGE = "Function \'{0}\' doesn\'t exist in CSS {1}";
        public UnknownFunctionError(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.Css.CssLanguageVersion version) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.Resolve.IReference Reference { get; }
        public string ToolTip { get; }
        public JetBrains.ReSharper.Psi.Css.CssLanguageVersion Version { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("CssNotResolved", "CSS", AttributeId="ReSharper Error Highlighting", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.UNRESOLVED_ERROR, ToolTipFormatString="Media feature \'{0}\' doesn\'t exist in CSS {1}")]
    public class UnknownMediaFeatureError : JetBrains.ReSharper.Daemon.Css.Highlightings.CssHighlightingBase, JetBrains.ReSharper.Daemon.IHighlighting, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "CssNotResolved";
        protected const string MESSAGE = "Media feature \'{0}\' doesn\'t exist in CSS {1}";
        public UnknownMediaFeatureError(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.Css.CssLanguageVersion version) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.Resolve.IReference Reference { get; }
        public string ToolTip { get; }
        public JetBrains.ReSharper.Psi.Css.CssLanguageVersion Version { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("CssNotResolved", "CSS", AttributeId="ReSharper Error Highlighting", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.UNRESOLVED_ERROR, ToolTipFormatString="Cannot resolve @page with name \'{0}\'")]
    public class UnknownPageError : JetBrains.ReSharper.Daemon.Css.Highlightings.CssHighlightingBase, JetBrains.ReSharper.Daemon.IHighlighting, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "CssNotResolved";
        protected const string MESSAGE = "Cannot resolve @page with name \'{0}\'";
        public UnknownPageError(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.Css.CssLanguageVersion version) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.Resolve.IReference Reference { get; }
        public string ToolTip { get; }
        public JetBrains.ReSharper.Psi.Css.CssLanguageVersion Version { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("CssNotResolved", "CSS", AttributeId="ReSharper Error Highlighting", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.UNRESOLVED_ERROR, ToolTipFormatString="Pseudo class \'{0}\' doesn\'t exist in CSS {1}")]
    public class UnknownPseudoClassError : JetBrains.ReSharper.Daemon.Css.Highlightings.CssHighlightingBase, JetBrains.ReSharper.Daemon.IHighlighting, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "CssNotResolved";
        protected const string MESSAGE = "Pseudo class \'{0}\' doesn\'t exist in CSS {1}";
        public UnknownPseudoClassError(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.Css.CssLanguageVersion version) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.Resolve.IReference Reference { get; }
        public string ToolTip { get; }
        public JetBrains.ReSharper.Psi.Css.CssLanguageVersion Version { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("CssNotResolved", "CSS", AttributeId="ReSharper Error Highlighting", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.UNRESOLVED_ERROR, ToolTipFormatString="Pseudo element \'{0}\' doesn\'t exist in CSS {1}")]
    public class UnknownPseudoElementError : JetBrains.ReSharper.Daemon.Css.Highlightings.CssHighlightingBase, JetBrains.ReSharper.Daemon.IHighlighting, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "CssNotResolved";
        protected const string MESSAGE = "Pseudo element \'{0}\' doesn\'t exist in CSS {1}";
        public UnknownPseudoElementError(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.Css.CssLanguageVersion version) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.Resolve.IReference Reference { get; }
        public string ToolTip { get; }
        public JetBrains.ReSharper.Psi.Css.CssLanguageVersion Version { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("CssNotResolved", "CSS", AttributeId="ReSharper Error Highlighting", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.UNRESOLVED_ERROR, ToolTipFormatString="Pseudo function \'{0}\' doesn\'t exist in CSS {1}")]
    public class UnknownPseudoFunctionError : JetBrains.ReSharper.Daemon.Css.Highlightings.CssHighlightingBase, JetBrains.ReSharper.Daemon.IHighlighting, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "CssNotResolved";
        protected const string MESSAGE = "Pseudo function \'{0}\' doesn\'t exist in CSS {1}";
        public UnknownPseudoFunctionError(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.Css.CssLanguageVersion version) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.Resolve.IReference Reference { get; }
        public string ToolTip { get; }
        public JetBrains.ReSharper.Psi.Css.CssLanguageVersion Version { get; }
        public override bool IsValid() { }
    }
}