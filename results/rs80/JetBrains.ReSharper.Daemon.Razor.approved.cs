[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("Razor.SectionNotResolved", null, "CodeSmell", "Unknown Razor section", "Unknown Razor section", JetBrains.ReSharper.Daemon.Severity.ERROR, false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterStaticHighlightingsGroupAttribute("RazorErrors", "Razor Errors", true)]
[assembly: JetBrains.ReSharper.Daemon.RegisterStaticHighlightingsGroupAttribute("RazorWarnings", "Razor Warnings", true)]
[assembly: JetBrains.ReSharper.Daemon.RegisterStaticHighlightingsGroupAttribute("RazorInfo", "Razor Info", false)]
[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]

namespace JetBrains.ReSharper.Daemon.Razor.Highlightings
{
    
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "RazorErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class RazorErrorHighlighting : JetBrains.ReSharper.Daemon.Html.Highlightings.HtmlErrorHighlighting
    {
        public RazorErrorHighlighting(string tooltipTextFormat, params object[] args) { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "RazorErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.UNRESOLVED_ERROR, OverloadResolvePriority=10)]
    public class RazorNotEnclosedBlockStatementHighlighting : JetBrains.ReSharper.Daemon.Razor.Highlightings.RazorErrorHighlighting
    {
        public RazorNotEnclosedBlockStatementHighlighting(JetBrains.ReSharper.Psi.ITreeRange treeRange) { }
        public JetBrains.ReSharper.Psi.ITreeRange TreeRange { get; }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("Razor.SectionNotResolved", "Razor", AttributeId="ReSharper Error Highlighting", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.UNRESOLVED_ERROR, OverloadResolvePriority=10)]
    public class RazorNotResolvedSectionHighlighting : JetBrains.ReSharper.Daemon.Razor.Highlightings.RazorErrorHighlighting
    {
        public const string SEVERITY_ID = "Razor.SectionNotResolved";
        public RazorNotResolvedSectionHighlighting([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "RazorErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class RazorReservedKeywordErrorHighlighting : JetBrains.ReSharper.Daemon.Razor.Highlightings.RazorErrorHighlighting
    {
        public RazorReservedKeywordErrorHighlighting([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Html.Tree.IHtmlErrorElement error) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.Psi.Html.Tree.IHtmlErrorElement Error { get; }
        public override bool IsValid() { }
    }
    public class static RazorStaticHighlightingsGroups
    {
        public const string RazorErrorsGroup = "RazorErrors";
        public const string RazorInfoGroup = "RazorInfo";
        public const string RazorWarningsGroup = "RazorWarnings";
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "RazorErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.UNRESOLVED_ERROR, OverloadResolvePriority=10)]
    public class RazorTransitionInsideCodeHighlighting : JetBrains.ReSharper.Daemon.Razor.Highlightings.RazorErrorHighlighting
    {
        public RazorTransitionInsideCodeHighlighting(JetBrains.ReSharper.Psi.ITreeRange treeRange) { }
        public JetBrains.ReSharper.Psi.ITreeRange TreeRange { get; }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "RazorErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class RazorVoidWriteCallErrorHighlighting : JetBrains.ReSharper.Daemon.Razor.Highlightings.RazorErrorHighlighting, JetBrains.ReSharper.Daemon.IHighlighting, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public RazorVoidWriteCallErrorHighlighting(JetBrains.ReSharper.Psi.Resolve.Managed.IManagedExpression writeMethod, JetBrains.ReSharper.Psi.Resolve.Managed.IManagedExpression writeArgument) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Psi.Resolve.Managed.IManagedExpression Argument { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Psi.Resolve.Managed.IManagedExpression Method { get; }
        public JetBrains.DocumentModel.DocumentRange CalculateRange() { }
        public override bool IsValid() { }
    }
}
namespace JetBrains.ReSharper.Daemon.Razor.Stages.Analysis
{
    
    [JetBrains.ReSharper.Daemon.Html.Stages.Analysis.HtmlAnalysisAttribute(typeof(JetBrains.ReSharper.Psi.Razor.RazorLanguage))]
    public class RazorSyntaxErrorsAnalysis : JetBrains.ReSharper.Daemon.Html.Stages.Analysis.HtmlSyntaxErrorsAnalysis
    {
        public RazorSyntaxErrorsAnalysis(JetBrains.ReSharper.Psi.Razor.RazorLanguage language, JetBrains.ReSharper.Psi.Razor.Parsing.IRazorTokenNodeTypes tokenNodeTypes) { }
        public override void ProcessBeforeInterior(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.Util.JetTuple<JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer, JetBrains.ReSharper.Psi.Html.Html.IHtmlDeclaredElementsCache, JetBrains.ReSharper.Psi.Html.Tree.IHtmlFile, JetBrains.ReSharper.Psi.IPsiServices> context) { }
    }
    [JetBrains.ReSharper.Daemon.Html.Stages.Analysis.HtmlAnalysisAttribute(typeof(JetBrains.ReSharper.Psi.Razor.RazorLanguage))]
    public sealed class RazorTagNotClosedAnalysis : JetBrains.ReSharper.Daemon.Html.Stages.Analysis.HtmlTagNotClosedAnalysis
    {
        public RazorTagNotClosedAnalysis(JetBrains.ReSharper.Psi.Razor.RazorLanguage language) { }
        protected override bool DoSupressHighlighting(JetBrains.ReSharper.Psi.Tree.ITreeNode node, JetBrains.Util.JetTuple<JetBrains.ReSharper.Psi.Html.Tree.IHtmlFile, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer, JetBrains.ReSharper.Psi.Html.Html.IHtmlDeclaredElementTypesBase, System.Collections.Generic.HashSet<JetBrains.ReSharper.Psi.Html.Tree.IHtmlTag>> context) { }
        public override bool InteriorShouldBeProcessed(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.Util.JetTuple<JetBrains.ReSharper.Psi.Html.Tree.IHtmlFile, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer, JetBrains.ReSharper.Psi.Html.Html.IHtmlDeclaredElementTypesBase, System.Collections.Generic.HashSet<JetBrains.ReSharper.Psi.Html.Tree.IHtmlTag>> context) { }
    }
    [JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerAttribute(new System.Type[] {
            typeof(JetBrains.ReSharper.Psi.Resolve.Managed.IManagedExpression)}, HighlightingTypes=new System.Type[] {
            typeof(JetBrains.ReSharper.Daemon.Razor.Highlightings.RazorVoidWriteCallErrorHighlighting)})]
    public class WriteCallProblemAnalyzer : JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzer<JetBrains.ReSharper.Psi.Resolve.Managed.IManagedExpression>
    {
        public WriteCallProblemAnalyzer(JetBrains.ProjectModel.FileTypes.IProjectFileTypeServices projectFileTypeServices) { }
        protected override void Run(JetBrains.ReSharper.Psi.Resolve.Managed.IManagedExpression element, JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerData data, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer) { }
    }
}