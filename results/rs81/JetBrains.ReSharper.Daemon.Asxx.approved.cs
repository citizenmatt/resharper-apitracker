[assembly: JetBrains.ReSharper.Daemon.ConfigurableSeverityImplementedForLanguageAttribute(typeof(JetBrains.ReSharper.Daemon.UsageChecking.UnusedFieldGlobalWarning), "ASXX")]
[assembly: JetBrains.ReSharper.Daemon.ConfigurableSeverityImplementedForLanguageAttribute(typeof(JetBrains.ReSharper.Daemon.UsageChecking.NotAccessedFieldGlobalWarning), "ASXX")]
[assembly: JetBrains.ReSharper.Daemon.RegisterStaticHighlightingsGroupAttribute("AsxxErrors", "Asxx Errors", true)]
[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]

namespace JetBrains.ReSharper.Daemon.Asxx
{
    
    public class AsxxElementPropertiesCalculator : JetBrains.ReSharper.Daemon.UsageChecking.ILanguageSpecificElementPropertiesCalculator
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
    public class AsxxPresentationHelper : JetBrains.ReSharper.Daemon.UsageChecking.IPresentationHelper
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
}
namespace JetBrains.ReSharper.Daemon.Asxx.Highlightings
{
    
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "AsxxErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class AsxxErrorHighlighting : JetBrains.ReSharper.Daemon.Asxx.Highlightings.AsxxHighlightingBase
    {
        public AsxxErrorHighlighting(string tooltipTextFmt, params object[] args) { }
        public override bool IsValid() { }
    }
    public abstract class AsxxHighlightingBase : JetBrains.ReSharper.Daemon.Asxx.Highlightings.IAsxxHighlighting, JetBrains.ReSharper.Daemon.IHighlighting
    {
        protected AsxxHighlightingBase([JetBrains.Annotations.NotNullAttribute()] string tooltipTextFmt, params object[] args) { }
        public virtual string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public virtual string ToolTip { get; }
        public abstract bool IsValid();
    }
    public abstract class AsxxHighlightingWithReferenceBase<T> : JetBrains.ReSharper.Daemon.Asxx.Highlightings.AsxxHighlightingBase
        where T : JetBrains.ReSharper.Psi.Resolve.IReference
    {
        protected AsxxHighlightingWithReferenceBase(T reference, string tooltip = null, params object[] args) { }
        public JetBrains.ReSharper.Psi.Resolve.ResolveErrorType ErrorType { get; }
        public T Reference { get; }
        public override string ToolTip { get; }
        protected virtual string CreateTooltip(T reference) { }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "AsxxErrors", AttributeId="ReSharper Error Highlighting", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.UNRESOLVED_ERROR, OverloadResolvePriority=10)]
    public class AsxxNotResolvedErrorHighlighting<T> : JetBrains.ReSharper.Daemon.Asxx.Highlightings.AsxxResolveErrorHighlighting<T>
        where T : JetBrains.ReSharper.Psi.Resolve.IReference
    {
        public AsxxNotResolvedErrorHighlighting(T reference, [JetBrains.Annotations.CanBeNullAttribute()] string tooltip = null, params object[] args) { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "AsxxErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class AsxxResolveErrorHighlighting<T> : JetBrains.ReSharper.Daemon.Asxx.Highlightings.AsxxHighlightingWithReferenceBase<T>
        where T : JetBrains.ReSharper.Psi.Resolve.IReference
    {
        public AsxxResolveErrorHighlighting(T reference, string tooltip = null, params object[] args) { }
    }
    public interface IAsxxHighlighting : JetBrains.ReSharper.Daemon.IHighlighting { }
}
namespace JetBrains.ReSharper.Daemon.Asxx.Stages
{
    
    public abstract class AsxxDaemonStageBase : JetBrains.ReSharper.Daemon.IDaemonStage
    {
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Daemon.IDaemonStageProcess> CreateProcess(JetBrains.ReSharper.Daemon.IDaemonProcess process, JetBrains.Application.Settings.IContextBoundSettingsStore settings, JetBrains.ReSharper.Daemon.DaemonProcessKind processKind) { }
        protected abstract JetBrains.ReSharper.Daemon.IDaemonStageProcess CreateProcessInternal(JetBrains.ReSharper.Psi.Asxx.Tree.IAsxxFile file, JetBrains.ReSharper.Daemon.IDaemonProcess process, JetBrains.Application.Settings.IContextBoundSettingsStore settingsStore);
        public virtual JetBrains.ReSharper.Daemon.ErrorStripeRequest NeedsErrorStripe(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.Application.Settings.IContextBoundSettingsStore settings) { }
    }
}
namespace JetBrains.ReSharper.Daemon.Asxx.Stages.Resolve
{
    
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Asxx.AsxxLanguage))]
    public class AsxxNotResolvedErrorHandler : JetBrains.ReSharper.Daemon.Stages.Resolve.IResolveProblemHighlighter
    {
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Resolve.ResolveErrorType> ErrorTypes { get; }
        public JetBrains.ReSharper.Daemon.IHighlighting Run(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
    }
}