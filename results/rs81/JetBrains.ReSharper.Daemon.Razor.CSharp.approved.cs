[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]

namespace JetBrains.ReSharper.Daemon.Razor.CSharp.Highlightings
{
    
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "RazorErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.UNRESOLVED_ERROR, OverloadResolvePriority=10)]
    public class RazorNotEnclosedBlockStatementInCodeHighlighting : JetBrains.ReSharper.Daemon.Razor.Highlightings.RazorErrorHighlighting
    {
        public RazorNotEnclosedBlockStatementInCodeHighlighting(JetBrains.ReSharper.Psi.Services.CSharp.BlockUtil.NestedBlock nestedBlock) { }
        public JetBrains.ReSharper.Psi.Services.CSharp.BlockUtil.NestedBlock NestedBlock { get; }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.WARNING, "RazorWarnings", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.WARNING)]
    public class RazorReturnValueOfHelperIsNotUsedWarning : JetBrains.ReSharper.Daemon.Razor.Highlightings.RazorErrorHighlighting, JetBrains.ReSharper.Daemon.IHighlighting, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public RazorReturnValueOfHelperIsNotUsedWarning(JetBrains.ReSharper.Psi.CSharp.Tree.IReferenceExpression invokedExpression) { }
        public JetBrains.DocumentModel.DocumentRange CalculateRange() { }
        public override bool IsValid() { }
    }
}
namespace JetBrains.ReSharper.Daemon.Razor.CSharp.Stages.Analysis
{
    
    [JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerAttribute(new System.Type[] {
            typeof(JetBrains.ReSharper.Psi.CSharp.Tree.IInvocationExpression)}, HighlightingTypes=new System.Type[] {
            typeof(JetBrains.ReSharper.Daemon.Razor.CSharp.Highlightings.RazorReturnValueOfHelperIsNotUsedWarning)})]
    public class HelperCallProblemAnalyzer : JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzer<JetBrains.ReSharper.Psi.CSharp.Tree.IInvocationExpression>
    {
        public HelperCallProblemAnalyzer(JetBrains.ProjectModel.FileTypes.IProjectFileTypeServices projectFileTypeServices) { }
        protected override void Run(JetBrains.ReSharper.Psi.CSharp.Tree.IInvocationExpression element, JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerData data, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer) { }
    }
    [JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerAttribute(new System.Type[] {
            typeof(JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpStatement)}, HighlightingTypes=new System.Type[] {
            typeof(JetBrains.ReSharper.Daemon.Razor.CSharp.Highlightings.RazorNotEnclosedBlockStatementInCodeHighlighting)})]
    public class RazorNotEnclosedBlockStatementInCodeProblemAnalyzer : JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzer<JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpStatement>
    {
        public RazorNotEnclosedBlockStatementInCodeProblemAnalyzer(JetBrains.ProjectModel.FileTypes.IProjectFileTypeServices projectFileTypeServices) { }
        protected override void Run(JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpStatement statement, JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerData data, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer) { }
    }
}
namespace JetBrains.ReSharper.Daemon.Razor.CSharp.Stages.Resolve
{
    
    public class RazorCSharpPathErrorHandler : JetBrains.ReSharper.Daemon.Stages.Resolve.PathErrorHandler
    {
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Resolve.ResolveErrorType> ErrorTypes { get; }
        public override JetBrains.ReSharper.Daemon.IHighlighting Run(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
    }
}