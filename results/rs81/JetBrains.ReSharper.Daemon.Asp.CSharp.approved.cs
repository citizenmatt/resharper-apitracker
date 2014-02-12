[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]

namespace JetBrains.ReSharper.Daemon.Asp.CSharp.Highlightings
{
    
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("RedundantUsingDirective", "ASPX", AttributeId="ReSharper Dead Code", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.DEADCODE)]
    public class AspUnusedUsingDirectiveWarning : JetBrains.ReSharper.Daemon.CSharp.Errors.UnusedUsingDirectiveWarning
    {
        public AspUnusedUsingDirectiveWarning([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.CSharp.Tree.IUsingDirective directive, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Asp.Tree.IAspDirective importDirective) { }
        public override bool IsValid() { }
    }
}
namespace JetBrains.ReSharper.Daemon.Asp.CSharp.Stages
{
    
    [JetBrains.ReSharper.Daemon.DaemonStageAttribute(StagesAfter=new System.Type[] {
            typeof(JetBrains.ReSharper.Daemon.CSharp.Stages.CSharpErrorStage)}, StagesBefore=new System.Type[] {
            typeof(JetBrains.ReSharper.Daemon.UsageChecking.CollectUsagesStage)})]
    public class AspAutoEventWireupStage : JetBrains.ReSharper.Daemon.IDaemonStage
    {
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Daemon.IDaemonStageProcess> CreateProcess(JetBrains.ReSharper.Daemon.IDaemonProcess process, JetBrains.Application.Settings.IContextBoundSettingsStore settings, JetBrains.ReSharper.Daemon.DaemonProcessKind processKind) { }
        public JetBrains.ReSharper.Daemon.ErrorStripeRequest NeedsErrorStripe(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.Application.Settings.IContextBoundSettingsStore settings) { }
    }
    [JetBrains.ReSharper.Daemon.DaemonStageAttribute(StagesAfter=new System.Type[] {
            typeof(JetBrains.ReSharper.Daemon.UsageChecking.CollectUsagesStage)}, StagesBefore=new System.Type[] {
            typeof(JetBrains.ReSharper.Daemon.CSharp.Stages.SmartResolverStage)})]
    public class AspCSharpImportDirectivesStage : JetBrains.ReSharper.Daemon.Asp.Stages.AspImportDirectivesStageBase<JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpFile, JetBrains.ReSharper.Daemon.CSharp.Stages.SmartResolverProcess>
    {
        protected override JetBrains.ReSharper.Psi.PsiLanguageType ExpectedLanguage { get; }
        protected override JetBrains.ReSharper.Daemon.Asp.Stages.AspImportDirectivesProcessBase<JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpFile, JetBrains.ReSharper.Daemon.CSharp.Stages.SmartResolverProcess> CreateProcess(JetBrains.ReSharper.Daemon.IDaemonProcess process, JetBrains.ReSharper.Psi.Asp.Tree.IAspFile aspFile, JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpFile codeBehindFile, JetBrains.ReSharper.Daemon.CSharp.Stages.SmartResolverProcess smartResolverProcess, JetBrains.Application.Settings.IContextBoundSettingsStore settingsStore) { }
    }
    public class AspDetectUnreferencedModule : JetBrains.ReSharper.Daemon.CSharp.Stages.DetectUnreferencedModule
    {
        public AspDetectUnreferencedModule(JetBrains.ReSharper.Daemon.IDaemonProcess daemonProcess) { }
        protected override bool IsDLRSupportVisible(JetBrains.ReSharper.Psi.Tree.IExpression expression) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class AspDetectUnreferencedModuleFactory : JetBrains.ReSharper.Daemon.CSharp.Stages.DetectUnreferencedModuleFactory
    {
        public override JetBrains.ReSharper.Daemon.CSharp.Stages.DetectUnreferencedModule CreateDetectUnreferencedModule(JetBrains.ReSharper.Daemon.IDaemonProcess daemonProcess) { }
    }
}
namespace JetBrains.ReSharper.Daemon.Asp.CSharp.Stages.Resolve
{
    
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class AspCSharpPathErrorHandler : JetBrains.ReSharper.Daemon.Stages.Resolve.PathErrorHandler
    {
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Resolve.ResolveErrorType> ErrorTypes { get; }
        public override JetBrains.ReSharper.Daemon.IHighlighting Run(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
    }
}