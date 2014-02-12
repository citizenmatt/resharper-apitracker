[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]

namespace JetBrains.ReSharper.Daemon.Asp.VB.Highlightings
{
    
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("UnusedImportClause", "ASPX", AttributeId="ReSharper Dead Code", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.DEADCODE)]
    public class AspUnusedImportClauseWarning : JetBrains.ReSharper.Daemon.VB.Errors.UnusedImportClauseWarning
    {
        public AspUnusedImportClauseWarning([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Asp.Tree.IAspDirective aspDirective, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.VB.Tree.IImportClause clause) { }
        public override bool IsValid() { }
    }
}
namespace JetBrains.ReSharper.Daemon.Asp.VB.Stages
{
    
    [JetBrains.ReSharper.Daemon.DaemonStageAttribute(StagesBefore=new System.Type[] {
            typeof(JetBrains.ReSharper.Daemon.VB.Stages.VBSmartResolverStage)})]
    public class AspVBImportDirectivesStage : JetBrains.ReSharper.Daemon.Asp.Stages.AspImportDirectivesStageBase<JetBrains.ReSharper.Psi.VB.Tree.IVBFile, JetBrains.ReSharper.Daemon.VB.Stages.VBSmartResolverProcess>
    {
        protected override JetBrains.ReSharper.Psi.PsiLanguageType ExpectedLanguage { get; }
        protected override JetBrains.ReSharper.Daemon.Asp.Stages.AspImportDirectivesProcessBase<JetBrains.ReSharper.Psi.VB.Tree.IVBFile, JetBrains.ReSharper.Daemon.VB.Stages.VBSmartResolverProcess> CreateProcess(JetBrains.ReSharper.Daemon.IDaemonProcess process, JetBrains.ReSharper.Psi.Asp.Tree.IAspFile aspFile, JetBrains.ReSharper.Psi.VB.Tree.IVBFile codeBehindFile, JetBrains.ReSharper.Daemon.VB.Stages.VBSmartResolverProcess smartResolverProcess, JetBrains.Application.Settings.IContextBoundSettingsStore settingsStore) { }
    }
}
namespace JetBrains.ReSharper.Daemon.Asp.VB.Stages.Resolve
{
    
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class AspVBPathErrorHandler : JetBrains.ReSharper.Daemon.Stages.Resolve.PathErrorHandler
    {
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Resolve.ResolveErrorType> ErrorTypes { get; }
        public override JetBrains.ReSharper.Daemon.IHighlighting Run(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
    }
}