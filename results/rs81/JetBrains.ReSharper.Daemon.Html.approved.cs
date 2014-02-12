[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("Html.DeadCode", null, "CodeSmell", "Html Dead Code", "Html Dead Code", JetBrains.ReSharper.Daemon.Severity.WARNING, false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("Html.Warning", null, "CodeSmell", "Html Warning", "Html Warning", JetBrains.ReSharper.Daemon.Severity.WARNING, false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("Asp.Entity", null, "CodeSmell", "Unknown html entity", "Unknown html entity", JetBrains.ReSharper.Daemon.Severity.WARNING, false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("Html.PathError", null, "CodeSmell", "Path error", "Path error", JetBrains.ReSharper.Daemon.Severity.WARNING, false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("Html.TagNotResolved", null, "CodeSmell", "Unknown tag", "Unknown tag in HTML and related technologies", JetBrains.ReSharper.Daemon.Severity.WARNING, false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("Html.AttributeNotResolved", null, "CodeSmell", "Unknown attribute", "Unknown attribute in HTML and related technologies", JetBrains.ReSharper.Daemon.Severity.WARNING, false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("Html.EventNotResolved", null, "CodeSmell", "Unknown event", "Unknown event in HTML and related technologies", JetBrains.ReSharper.Daemon.Severity.WARNING, false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("Html.TagNotClosed", null, "CodeSmell", "Not closed tag", "Not closed tag in HTML and related technologies", JetBrains.ReSharper.Daemon.Severity.ERROR, false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("Html.IdNotResolved", null, "CodeSmell", "Unknown ID", "Link to unknown anchor (no element with such ID or name)", JetBrains.ReSharper.Daemon.Severity.WARNING, false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("Html.Obsolete", null, "CodeSmell", "Obsolete or nonstandard element", "Obsolete or nonstandard element", JetBrains.ReSharper.Daemon.Severity.WARNING, false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("Web.IgnoredPath", null, "CodeInfo", "Ignored path", "Path is ignored in project settings", JetBrains.ReSharper.Daemon.Severity.DO_NOT_SHOW, false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("Web.MappedPath", null, "CodeInfo", "Mapped path", "Path is mapped to a different path in project settings", JetBrains.ReSharper.Daemon.Severity.HINT, false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterStaticHighlightingsGroupAttribute("HtmlErrors", "HTML Errors", true)]
[assembly: JetBrains.ReSharper.Daemon.RegisterStaticHighlightingsGroupAttribute("HtmlInfo", "HTML Info", false)]
[assembly: JetBrains.TextControl.DocumentMarkup.RegisterHighlighterAttribute("ReSharper HTML Synchronous Tag Editing", "{D26E8A0F-4443-48F2-9A4A-9C6B913DF115}", Layer=1000, VSPriority=10001)]
[assembly: JetBrains.TextControl.DocumentMarkup.RegisterHighlighterAttribute("ReSharper HTML Entity", "{D686102B-8DC3-49E5-ACBA-4BEC03843210}", Layer=5000, VSPriority=10001)]
[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]

namespace JetBrains.ReSharper.Daemon.Html.Highlightings
{
    
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.INFO, "HtmlInfo", AttributeId="ReSharper HTML Synchronous Tag Editing", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.NONE, ShowToolTipInStatusBar=false)]
    public class ChangedTagNameHighlighting : JetBrains.ReSharper.Daemon.IHighlighting
    {
        public const string ChangedTagNameHighlightingName = "ReSharper HTML Synchronous Tag Editing";
        public ChangedTagNameHighlighting(JetBrains.ReSharper.Feature.Services.Html.TypingAssist.TagMarkers rangeMarkers) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("Html.AttributeNotResolved", "HTML", AttributeId="ReSharper Error Highlighting", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.UNRESOLVED_ERROR, OverloadResolvePriority=10)]
    public class HtmlAttributeResolvedErrorHighlighting : JetBrains.ReSharper.Daemon.Html.Highlightings.HtmlHighlightingWithReferenceBase<JetBrains.ReSharper.Psi.Resolve.IReference>
    {
        public HtmlAttributeResolvedErrorHighlighting(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "HtmlErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class HtmlConditionalCommentErrorHighlighting : JetBrains.ReSharper.Daemon.Html.Highlightings.HtmlErrorHighlighting
    {
        public HtmlConditionalCommentErrorHighlighting(JetBrains.ReSharper.Psi.Html.Tree.IHtmlConditionalComment comment, string tooltipTextFormat, params object[] args) { }
        public JetBrains.ReSharper.Psi.Html.Tree.IHtmlConditionalComment ConditionalComment { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("Html.DeadCode", "HTML", AttributeId="ReSharper Dead Code", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.DEADCODE)]
    public class HtmlDeadCodeHighlighting : JetBrains.ReSharper.Daemon.Html.Highlightings.HtmlHighlightingBase
    {
        public HtmlDeadCodeHighlighting(JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode element, string tooltipTextFormat, params object[] args) { }
        public JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode Element { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.INFO, "HtmlInfo", AttributeId="ReSharper HTML Entity", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.NONE, ShowToolTipInStatusBar=false)]
    public class HtmlEntityHighlighting : JetBrains.ReSharper.Daemon.Html.Highlightings.IHtmlEntitiesHighlighting, JetBrains.ReSharper.Daemon.IHighlighting
    {
        public const string HTML_ENTITY_HIGHLIGHTING = "ReSharper HTML Entity";
        public HtmlEntityHighlighting(JetBrains.ReSharper.Feature.Services.Html.HtmlEntities.HtmlEntity entity) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "HtmlErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class HtmlErrorHighlighting : JetBrains.ReSharper.Daemon.Html.Highlightings.HtmlHighlightingBase
    {
        public HtmlErrorHighlighting(string tooltipTextFormat, params object[] args) { }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("Html.EventNotResolved", "HTML", AttributeId="ReSharper Error Highlighting", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.UNRESOLVED_ERROR, OverloadResolvePriority=10)]
    public class HtmlEventResolvedErrorHighlighting : JetBrains.ReSharper.Daemon.Html.Highlightings.HtmlHighlightingWithReferenceBase<JetBrains.ReSharper.Psi.Resolve.IReference>
    {
        public HtmlEventResolvedErrorHighlighting(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
    }
    public abstract class HtmlHighlightingBase : JetBrains.ReSharper.Daemon.Html.Highlightings.IHtmlHighlighting, JetBrains.ReSharper.Daemon.IHighlighting
    {
        protected HtmlHighlightingBase([JetBrains.Annotations.NotNullAttribute()] string tooltipTextFormat, params object[] args) { }
        public virtual string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public virtual string ToolTip { get; }
        public abstract bool IsValid();
    }
    public abstract class HtmlHighlightingWithReferenceBase<T> : JetBrains.ReSharper.Daemon.Html.Highlightings.HtmlHighlightingBase, JetBrains.ReSharper.Daemon.IHighlighting, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
        where T : JetBrains.ReSharper.Psi.Resolve.IReference
    {
        protected HtmlHighlightingWithReferenceBase([JetBrains.Annotations.NotNullAttribute()] T reference, string tooltip = null, params object[] args) { }
        public JetBrains.ReSharper.Psi.Resolve.ResolveErrorType ErrorType { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public T Reference { get; }
        public override string ToolTip { get; }
        public JetBrains.DocumentModel.DocumentRange CalculateRange() { }
        protected virtual string CreateTooltip(T reference) { }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("Html.IdNotResolved", "HTML", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.WARNING)]
    public class HtmlIdNotResolvedErrorHighlighting : JetBrains.ReSharper.Daemon.Html.Highlightings.HtmlHighlightingWithReferenceBase<JetBrains.ReSharper.Psi.Resolve.IReference>
    {
        public HtmlIdNotResolvedErrorHighlighting(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("Web.IgnoredPath", "HTML", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.WARNING)]
    public class HtmlIgnoredPathHighlighting : JetBrains.ReSharper.Daemon.Html.Highlightings.HtmlHighlightingWithReferenceBase<JetBrains.ReSharper.Psi.Resolve.IPathReference>
    {
        public HtmlIgnoredPathHighlighting(JetBrains.ReSharper.Psi.Resolve.IPathReference pathReference) { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("Web.MappedPath", "HTML", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.WARNING)]
    public class HtmlMappedPathHighlighting : JetBrains.ReSharper.Daemon.Html.Highlightings.HtmlHighlightingWithReferenceBase<JetBrains.ReSharper.Psi.Resolve.IPathReference>
    {
        public HtmlMappedPathHighlighting(JetBrains.ReSharper.Psi.Resolve.IPathReference pathReference) { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("Html.Obsolete", "HTML", AttributeId="ReSharper Error Highlighting", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.UNRESOLVED_ERROR, OverloadResolvePriority=10)]
    public class HtmlObsoleteHighlighting : JetBrains.ReSharper.Daemon.Html.Highlightings.HtmlHighlightingWithReferenceBase<JetBrains.ReSharper.Psi.Resolve.IReference>
    {
        public HtmlObsoleteHighlighting(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("Html.PathError", "HTML", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.WARNING)]
    public class HtmlPathWarningHighlighting : JetBrains.ReSharper.Daemon.Html.Highlightings.HtmlHighlightingWithReferenceBase<JetBrains.ReSharper.Psi.Resolve.IPathReference>
    {
        public HtmlPathWarningHighlighting(JetBrains.ReSharper.Psi.Resolve.IPathReference pathReference) { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("Html.TagNotClosed", "HTML", AttributeId="ReSharper Underlined Error Highlighting", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR, OverloadResolvePriority=10)]
    public class HtmlTagNotClosedHighlighting : JetBrains.ReSharper.Daemon.Html.Highlightings.HtmlErrorHighlighting
    {
        public HtmlTagNotClosedHighlighting(JetBrains.ReSharper.Psi.Html.Tree.IHtmlTag tag, System.Collections.Generic.HashSet<JetBrains.ReSharper.Psi.Html.Tree.IHtmlTag> parentOpenTags = null) { }
        public System.Collections.Generic.HashSet<JetBrains.ReSharper.Psi.Html.Tree.IHtmlTag> ParentOpenTags { get; }
        public JetBrains.ReSharper.Psi.Html.Tree.IHtmlTag Tag { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("Html.TagNotResolved", "HTML", AttributeId="ReSharper Error Highlighting", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.UNRESOLVED_ERROR, OverloadResolvePriority=10)]
    public class HtmlTagNotResolvedErrorHighlighting : JetBrains.ReSharper.Daemon.Html.Highlightings.HtmlHighlightingWithReferenceBase<JetBrains.ReSharper.Psi.Resolve.IReference>
    {
        public HtmlTagNotResolvedErrorHighlighting(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("Html.Warning", "HTML", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.WARNING)]
    public class HtmlWarningHighlighting : JetBrains.ReSharper.Daemon.Html.Highlightings.HtmlHighlightingBase
    {
        public HtmlWarningHighlighting(string tooltipTextFormat, params object[] args) { }
        public override bool IsValid() { }
    }
    public interface IHtmlEntitiesHighlighting : JetBrains.ReSharper.Daemon.IHighlighting { }
    public interface IHtmlHighlighting : JetBrains.ReSharper.Daemon.IHighlighting { }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("Asp.Entity", "HTML", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.WARNING)]
    public class UnknownHtmlEntityHighlighting : JetBrains.ReSharper.Daemon.Html.Highlightings.IHtmlEntitiesHighlighting, JetBrains.ReSharper.Daemon.IHighlighting
    {
        public UnknownHtmlEntityHighlighting(JetBrains.ReSharper.Feature.Services.Html.HtmlEntities.HtmlEntity entity) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public bool IsValid() { }
    }
    public class static WebHighlightingConfigurableSeverity
    {
        public const string IgnoredPathSeverityId = "Web.IgnoredPath";
        public const string MappedPathSeverityId = "Web.MappedPath";
    }
}
namespace JetBrains.ReSharper.Daemon.Html
{
    
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Html.HtmlLanguage))]
    public class HtmlDaemonBehavior : JetBrains.ReSharper.Daemon.ILanguageSpecificDaemonBehavior
    {
        public bool CanShowErrorBox { get; }
        public bool RunInSolutionAnalysis { get; }
        public JetBrains.ReSharper.Daemon.ErrorStripeRequest InitialErrorStripe(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
    }
}
namespace JetBrains.ReSharper.Daemon.Html.Stages.Analysis
{
    
    public class static HtmlAnalysis
    {
        public static JetBrains.DocumentModel.DocumentRange FixHighlightingRange(JetBrains.DocumentModel.DocumentRange highlightingRange) { }
    }
    public abstract class HtmlAnalysis<TContext> : JetBrains.ReSharper.Daemon.Html.Stages.Analysis.IHtmlAnalysis<TContext>, JetBrains.ReSharper.Psi.IRecursiveElementProcessor<TContext>
    
    {
        protected HtmlAnalysis(JetBrains.ReSharper.Psi.Html.HtmlLanguage language) { }
        protected virtual bool IgnoreErrorInHtmlComment { get; }
        public virtual void Done(JetBrains.ReSharper.Psi.Html.Tree.IHtmlFile file, TContext context) { }
        public void Done(JetBrains.ReSharper.Psi.Html.Tree.IHtmlFile file, object context) { }
        protected virtual bool DoSupressHighlighting([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode node, TContext context) { }
        public virtual object Init(JetBrains.ReSharper.Psi.Html.Tree.IHtmlFile file, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer) { }
        public virtual bool InteriorShouldBeProcessed(JetBrains.ReSharper.Psi.Tree.ITreeNode element, TContext context) { }
        public bool InteriorShouldBeProcessed(JetBrains.ReSharper.Psi.Tree.ITreeNode element, object context) { }
        public virtual bool IsProcessingFinished(TContext context) { }
        public virtual bool IsProcessingFinished(object context) { }
        public virtual void ProcessAfterInterior(JetBrains.ReSharper.Psi.Tree.ITreeNode element, TContext context) { }
        public void ProcessAfterInterior(JetBrains.ReSharper.Psi.Tree.ITreeNode element, object context) { }
        public virtual void ProcessBeforeInterior(JetBrains.ReSharper.Psi.Tree.ITreeNode element, TContext context) { }
        public void ProcessBeforeInterior(JetBrains.ReSharper.Psi.Tree.ITreeNode element, object context) { }
    }
    [JetBrains.Annotations.BaseTypeRequiredAttribute(typeof(JetBrains.ReSharper.Daemon.Html.Stages.Analysis.IHtmlAnalysis))]
    [JetBrains.Annotations.MeansImplicitUseAttribute()]
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.All)]
    public class HtmlAnalysisAttribute : JetBrains.ReSharper.Psi.LanguageAttribute
    {
        public HtmlAnalysisAttribute(System.Type language) { }
    }
    public abstract class HtmlAnalysisProvider<TAnalysis, TContext> : JetBrains.ReSharper.Daemon.Html.Stages.Analysis.IHtmlAnalysisProvider<TAnalysis, TContext>
        where TAnalysis : JetBrains.ReSharper.Daemon.Html.Stages.Analysis.IHtmlAnalysis<>
    
    {
        protected HtmlAnalysisProvider(System.Collections.Generic.IEnumerable<TAnalysis> analyses) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Daemon.Html.Stages.Analysis.IHtmlAnalysis> GetAnalysis(JetBrains.ReSharper.Psi.Html.Tree.IHtmlFile file, JetBrains.ReSharper.Daemon.IDaemonProcess process) { }
    }
    [JetBrains.Annotations.BaseTypeRequiredAttribute(typeof(JetBrains.ReSharper.Daemon.Html.Stages.Analysis.IHtmlAnalysisProvider))]
    [JetBrains.Annotations.MeansImplicitUseAttribute()]
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.All)]
    public class HtmlAnalysisProviderAttribute : JetBrains.ReSharper.Psi.LanguageAttribute
    {
        public HtmlAnalysisProviderAttribute(System.Type language) { }
    }
    [JetBrains.ReSharper.Daemon.Html.Stages.Analysis.HtmlAnalysisAttribute(typeof(JetBrains.ReSharper.Psi.Html.HtmlLanguage))]
    public class HtmlIncludeAnalysis : JetBrains.ReSharper.Daemon.Html.Stages.Analysis.HtmlAnalysis<JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer>, JetBrains.ReSharper.Daemon.Html.Stages.Analysis.IHtmlAnalysis, JetBrains.ReSharper.Daemon.Html.Stages.Analysis.IHtmlAnalysis<object>, JetBrains.ReSharper.Daemon.Html.Stages.Analysis.IHtmlSemanticAnalysis, JetBrains.ReSharper.Psi.IRecursiveElementProcessor<object>
    {
        public HtmlIncludeAnalysis(JetBrains.ReSharper.Psi.Html.HtmlLanguage language) { }
        public override bool InteriorShouldBeProcessed(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer context) { }
        public override void ProcessAfterInterior(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer highlightings) { }
    }
    [JetBrains.ReSharper.Daemon.Html.Stages.Analysis.HtmlAnalysisAttribute(typeof(JetBrains.ReSharper.Psi.Html.HtmlLanguage))]
    public class HtmlObsoleteAnalysis : JetBrains.ReSharper.Daemon.Html.Stages.Analysis.HtmlAnalysis<JetBrains.Util.JetTuple<JetBrains.ReSharper.Psi.Html.Tree.IHtmlFile, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer>>, JetBrains.ReSharper.Daemon.Html.Stages.Analysis.IHtmlAnalysis, JetBrains.ReSharper.Daemon.Html.Stages.Analysis.IHtmlAnalysis<object>, JetBrains.ReSharper.Psi.IRecursiveElementProcessor<object>
    {
        public HtmlObsoleteAnalysis(JetBrains.ReSharper.Psi.Html.HtmlLanguage language) { }
        public override object Init(JetBrains.ReSharper.Psi.Html.Tree.IHtmlFile file, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer) { }
        public override bool IsProcessingFinished(JetBrains.Util.JetTuple<JetBrains.ReSharper.Psi.Html.Tree.IHtmlFile, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer> context) { }
        public override void ProcessBeforeInterior(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.Util.JetTuple<JetBrains.ReSharper.Psi.Html.Tree.IHtmlFile, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer> context) { }
    }
    [JetBrains.ReSharper.Daemon.Html.Stages.Analysis.HtmlAnalysisProviderAttribute(typeof(JetBrains.ReSharper.Psi.Html.HtmlLanguage))]
    public class HtmlSemanticAnalysisProvider : JetBrains.ReSharper.Daemon.Html.Stages.Analysis.HtmlAnalysisProvider<JetBrains.ReSharper.Daemon.Html.Stages.Analysis.IHtmlSemanticAnalysis, object>, JetBrains.ReSharper.Daemon.Html.Stages.Analysis.IHtmlAnalysisProvider, JetBrains.ReSharper.Daemon.Html.Stages.Analysis.IHtmlAnalysisProvider<JetBrains.ReSharper.Daemon.Html.Stages.Analysis.IHtmlAnalysis, object>
    {
        public HtmlSemanticAnalysisProvider(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Daemon.Html.Stages.Analysis.IHtmlSemanticAnalysis> analyses) { }
    }
    [JetBrains.ReSharper.Daemon.Html.Stages.Analysis.HtmlAnalysisProviderAttribute(typeof(JetBrains.ReSharper.Psi.Html.HtmlLanguage))]
    public class HtmlSyntaxAnanlysisProvider : JetBrains.ReSharper.Daemon.Html.Stages.Analysis.HtmlAnalysisProvider<JetBrains.ReSharper.Daemon.Html.Stages.Analysis.IHtmlSyntaxAnalysis, object>, JetBrains.ReSharper.Daemon.Html.Stages.Analysis.IHtmlAnalysisProvider, JetBrains.ReSharper.Daemon.Html.Stages.Analysis.IHtmlAnalysisProvider<JetBrains.ReSharper.Daemon.Html.Stages.Analysis.IHtmlAnalysis, object>
    {
        public HtmlSyntaxAnanlysisProvider(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Daemon.Html.Stages.Analysis.IHtmlSyntaxAnalysis> analyses) { }
    }
    [JetBrains.ReSharper.Daemon.Html.Stages.Analysis.HtmlAnalysisAttribute(typeof(JetBrains.ReSharper.Psi.Html.HtmlLanguage))]
    public class HtmlSyntaxErrorsAnalysis : JetBrains.ReSharper.Daemon.Html.Stages.Analysis.HtmlAnalysis<JetBrains.Util.JetTuple<JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer, JetBrains.ReSharper.Psi.Html.Html.IHtmlDeclaredElementsCache, JetBrains.ReSharper.Psi.Html.Tree.IHtmlFile, JetBrains.ReSharper.Psi.IPsiServices>>, JetBrains.ReSharper.Daemon.Html.Stages.Analysis.IHtmlAnalysis, JetBrains.ReSharper.Daemon.Html.Stages.Analysis.IHtmlAnalysis<object>, JetBrains.ReSharper.Daemon.Html.Stages.Analysis.IHtmlSyntaxAnalysis, JetBrains.ReSharper.Psi.IRecursiveElementProcessor<object>
    {
        public HtmlSyntaxErrorsAnalysis(JetBrains.ReSharper.Psi.Html.HtmlLanguage language, JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes tokenNodeTypes) { }
        protected override bool IgnoreErrorInHtmlComment { get; }
        public override object Init(JetBrains.ReSharper.Psi.Html.Tree.IHtmlFile file, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer) { }
        public override void ProcessBeforeInterior(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.Util.JetTuple<JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer, JetBrains.ReSharper.Psi.Html.Html.IHtmlDeclaredElementsCache, JetBrains.ReSharper.Psi.Html.Tree.IHtmlFile, JetBrains.ReSharper.Psi.IPsiServices> context) { }
    }
    [JetBrains.ReSharper.Daemon.Html.Stages.Analysis.HtmlAnalysisAttribute(typeof(JetBrains.ReSharper.Psi.Html.HtmlLanguage))]
    public class HtmlTagNotClosedAnalysis : JetBrains.ReSharper.Daemon.Html.Stages.Analysis.HtmlAnalysis<JetBrains.Util.JetTuple<JetBrains.ReSharper.Psi.Html.Tree.IHtmlFile, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer, JetBrains.ReSharper.Psi.Html.Html.IHtmlDeclaredElementTypesBase, System.Collections.Generic.HashSet<JetBrains.ReSharper.Psi.Html.Tree.IHtmlTag>>>, JetBrains.ReSharper.Daemon.Html.Stages.Analysis.IHtmlAnalysis, JetBrains.ReSharper.Daemon.Html.Stages.Analysis.IHtmlAnalysis<object>, JetBrains.ReSharper.Daemon.Html.Stages.Analysis.IHtmlSyntaxAnalysis, JetBrains.ReSharper.Psi.IRecursiveElementProcessor<object>
    {
        public HtmlTagNotClosedAnalysis(JetBrains.ReSharper.Psi.Html.HtmlLanguage language) { }
        protected override bool IgnoreErrorInHtmlComment { get; }
        public override object Init(JetBrains.ReSharper.Psi.Html.Tree.IHtmlFile file, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer) { }
        public override bool InteriorShouldBeProcessed(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.Util.JetTuple<JetBrains.ReSharper.Psi.Html.Tree.IHtmlFile, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer, JetBrains.ReSharper.Psi.Html.Html.IHtmlDeclaredElementTypesBase, System.Collections.Generic.HashSet<JetBrains.ReSharper.Psi.Html.Tree.IHtmlTag>> context) { }
        public override void ProcessAfterInterior(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.Util.JetTuple<JetBrains.ReSharper.Psi.Html.Tree.IHtmlFile, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer, JetBrains.ReSharper.Psi.Html.Html.IHtmlDeclaredElementTypesBase, System.Collections.Generic.HashSet<JetBrains.ReSharper.Psi.Html.Tree.IHtmlTag>> context) { }
        public override void ProcessBeforeInterior(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.Util.JetTuple<JetBrains.ReSharper.Psi.Html.Tree.IHtmlFile, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer, JetBrains.ReSharper.Psi.Html.Html.IHtmlDeclaredElementTypesBase, System.Collections.Generic.HashSet<JetBrains.ReSharper.Psi.Html.Tree.IHtmlTag>> context) { }
        protected virtual bool ShouldBeClosed(JetBrains.ReSharper.Psi.Html.Tree.IHtmlTag tag, JetBrains.Util.JetTuple<JetBrains.ReSharper.Psi.Html.Tree.IHtmlFile, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer, JetBrains.ReSharper.Psi.Html.Html.IHtmlDeclaredElementTypesBase, System.Collections.Generic.HashSet<JetBrains.ReSharper.Psi.Html.Tree.IHtmlTag>> context) { }
    }
    public interface IHtmlAnalysis : JetBrains.ReSharper.Daemon.Html.Stages.Analysis.IHtmlAnalysis<object>, JetBrains.ReSharper.Psi.IRecursiveElementProcessor<object> { }
    public interface IHtmlAnalysis<in TContext> : JetBrains.ReSharper.Psi.IRecursiveElementProcessor<TContext>
    
    {
        void Done(JetBrains.ReSharper.Psi.Html.Tree.IHtmlFile file, TContext context);
        object Init(JetBrains.ReSharper.Psi.Html.Tree.IHtmlFile file, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer);
    }
    public interface IHtmlAnalysisProvider : JetBrains.ReSharper.Daemon.Html.Stages.Analysis.IHtmlAnalysisProvider<JetBrains.ReSharper.Daemon.Html.Stages.Analysis.IHtmlAnalysis, object> { }
    public interface IHtmlAnalysisProvider<TAnalysis, TContext>
        where TAnalysis : JetBrains.ReSharper.Daemon.Html.Stages.Analysis.IHtmlAnalysis<>
    
    {
        System.Collections.Generic.IEnumerable<TAnalysis> GetAnalysis(JetBrains.ReSharper.Psi.Html.Tree.IHtmlFile file, JetBrains.ReSharper.Daemon.IDaemonProcess process);
    }
    public interface IHtmlSemanticAnalysis : JetBrains.ReSharper.Daemon.Html.Stages.Analysis.IHtmlAnalysis, JetBrains.ReSharper.Daemon.Html.Stages.Analysis.IHtmlAnalysis<object>, JetBrains.ReSharper.Psi.IRecursiveElementProcessor<object> { }
    public interface IHtmlSyntaxAnalysis : JetBrains.ReSharper.Daemon.Html.Stages.Analysis.IHtmlAnalysis, JetBrains.ReSharper.Daemon.Html.Stages.Analysis.IHtmlAnalysis<object>, JetBrains.ReSharper.Psi.IRecursiveElementProcessor<object> { }
}
namespace JetBrains.ReSharper.Daemon.Html.Stages
{
    
    [JetBrains.ReSharper.Daemon.DaemonStageAttribute()]
    public class ChangedTagNameDaemonStage : JetBrains.ReSharper.Daemon.IDaemonStage
    {
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Daemon.IDaemonStageProcess> CreateProcess(JetBrains.ReSharper.Daemon.IDaemonProcess process, JetBrains.Application.Settings.IContextBoundSettingsStore settings, JetBrains.ReSharper.Daemon.DaemonProcessKind processKind) { }
        public JetBrains.ReSharper.Daemon.ErrorStripeRequest NeedsErrorStripe(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.Application.Settings.IContextBoundSettingsStore settings) { }
    }
    public class ChangedTagNameDaemonStageProcess : JetBrains.ReSharper.Daemon.IDaemonStageProcess
    {
        public ChangedTagNameDaemonStageProcess(JetBrains.DocumentModel.IDocument document, JetBrains.ReSharper.Daemon.IDaemonProcess process) { }
        public JetBrains.ReSharper.Daemon.IDaemonProcess DaemonProcess { get; }
        public void Execute(System.Action<JetBrains.ReSharper.Daemon.DaemonStageResult> committer) { }
    }
    [JetBrains.ReSharper.Daemon.DaemonStageAttribute(StagesAfter=new System.Type[] {
            typeof(JetBrains.ReSharper.Daemon.Html.Stages.HtmlAnalysisStage)})]
    public class GlobalErrorStage : JetBrains.ReSharper.Daemon.Html.Stages.HtmlDaemonStageBase<JetBrains.ReSharper.Psi.Html.Tree.IHtmlFile, JetBrains.ReSharper.Psi.Html.HtmlLanguage>
    {
        public GlobalErrorStage(JetBrains.ReSharper.Daemon.Stages.Resolve.ResolveHighlighterRegistrar resolveHighlighterRegistrar) { }
        protected override JetBrains.ReSharper.Daemon.IDaemonStageProcess CreateProcessInternal(JetBrains.ReSharper.Psi.Html.Tree.IHtmlFile file, JetBrains.ReSharper.Daemon.IDaemonProcess process, JetBrains.Application.Settings.IContextBoundSettingsStore settingsStore) { }
    }
    [JetBrains.ReSharper.Daemon.DaemonStageAttribute(StagesAfter=new System.Type[] {
            typeof(JetBrains.ReSharper.Daemon.LanguageSpecificDaemonStage)})]
    public class HtmlAnalysisStage : JetBrains.ReSharper.Daemon.Html.Stages.HtmlDaemonStageBase<JetBrains.ReSharper.Psi.Html.Tree.IHtmlFile, JetBrains.ReSharper.Psi.Html.HtmlLanguage>
    {
        public HtmlAnalysisStage(JetBrains.ReSharper.Psi.ILanguageManager languageManager) { }
        protected override JetBrains.ReSharper.Daemon.IDaemonStageProcess CreateProcessInternal(JetBrains.ReSharper.Psi.Html.Tree.IHtmlFile file, JetBrains.ReSharper.Daemon.IDaemonProcess process, JetBrains.Application.Settings.IContextBoundSettingsStore settingsStore) { }
    }
    public abstract class HtmlDaemonStageBase<TFile, TLanguageType> : JetBrains.ReSharper.Daemon.IDaemonStage
        where TFile :  class, JetBrains.ReSharper.Psi.Html.Tree.IHtmlFile
        where TLanguageType : JetBrains.ReSharper.Psi.Html.HtmlLanguage
    {
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Daemon.IDaemonStageProcess> CreateProcess(JetBrains.ReSharper.Daemon.IDaemonProcess process, JetBrains.Application.Settings.IContextBoundSettingsStore settings, JetBrains.ReSharper.Daemon.DaemonProcessKind processKind) { }
        protected abstract JetBrains.ReSharper.Daemon.IDaemonStageProcess CreateProcessInternal(TFile file, JetBrains.ReSharper.Daemon.IDaemonProcess process, JetBrains.Application.Settings.IContextBoundSettingsStore settingsStore);
        public virtual JetBrains.ReSharper.Daemon.ErrorStripeRequest NeedsErrorStripe(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.Application.Settings.IContextBoundSettingsStore settings) { }
    }
    [JetBrains.ReSharper.Daemon.Stages.FileStructureExplorerAttribute()]
    public class HtmlFileStructureExplorer : JetBrains.ReSharper.Daemon.Stages.IFileStructureExplorer
    {
        public JetBrains.ReSharper.Daemon.Stages.IFileStructure Run(System.Predicate<JetBrains.DocumentModel.DocumentRange> isRangeInvalidated, JetBrains.ReSharper.Psi.IPsiSourceFile psiSourceFile, JetBrains.Application.Settings.IContextBoundSettingsStore settingsStore, JetBrains.ReSharper.Psi.Tree.IFile file1) { }
    }
}
namespace JetBrains.ReSharper.Daemon.Html.Stages.Resolve
{
    
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Html.HtmlLanguage))]
    public class HtmlErrorHandler : JetBrains.ReSharper.Daemon.Stages.Resolve.IResolveProblemHighlighter
    {
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Resolve.ResolveErrorType> ErrorTypes { get; }
        public JetBrains.ReSharper.Daemon.IHighlighting Run(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Html.HtmlLanguage))]
    public class HtmlNotResolvedErrorHandler : JetBrains.ReSharper.Daemon.Stages.Resolve.IResolveProblemHighlighter
    {
        public virtual System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Resolve.ResolveErrorType> ErrorTypes { get; }
        public virtual JetBrains.ReSharper.Daemon.IHighlighting Run(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Html.HtmlLanguage))]
    public class HtmlPathErrorHandler : JetBrains.ReSharper.Daemon.Stages.Resolve.PathErrorHandler
    {
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Resolve.ResolveErrorType> ErrorTypes { get; }
        public override JetBrains.ReSharper.Daemon.IHighlighting Run(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
    }
    public class static HtmlPathHighlightingUtil
    {
        public static JetBrains.ReSharper.Daemon.IHighlighting CreateHighlighting([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Resolve.IPathReference pathReference) { }
    }
}