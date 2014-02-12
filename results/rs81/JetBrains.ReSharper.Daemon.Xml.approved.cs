[assembly: JetBrains.ReSharper.Daemon.RegisterStaticHighlightingsGroupAttribute("XMLWarnings", "XML Warnings", true)]
[assembly: JetBrains.ReSharper.Daemon.RegisterStaticHighlightingsGroupAttribute("XMLErrors", "XML Errors", true)]
[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]

namespace JetBrains.ReSharper.Daemon.Xml.Highlightings
{
    
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "XMLErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class XmlErrorHighlighting : JetBrains.ReSharper.Daemon.Xml.Stages.XmlHighlighting
    {
        public XmlErrorHighlighting(string tooltipTextFmt, params object[] args) { }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.DaemonTooltipProviderAttribute(typeof(JetBrains.ReSharper.Daemon.Xml.Stages.XmlIdentifierTooltipProvider))]
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.INFO, "IdentifierHighlightings", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.NONE, ShowToolTipInStatusBar=false)]
    public class XmlIdentifierHighlighting : JetBrains.ReSharper.Daemon.Xml.Stages.XmlHighlightingBase, JetBrains.ReSharper.Daemon.ICustomAttributeIdHighlighting, JetBrains.ReSharper.Daemon.IHighlighting
    {
        public XmlIdentifierHighlighting(string attributeId) { }
        public string AttributeId { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "XMLErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class XmlMisplacedCommentErrorHighlighting : JetBrains.ReSharper.Daemon.Xml.Highlightings.XmlErrorHighlighting
    {
        public XmlMisplacedCommentErrorHighlighting([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xml.Tree.IXmlComment comment) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.Psi.Xml.Tree.IXmlComment Comment { get; }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "XMLErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class XmlNoRootTagDefinedHighlighting : JetBrains.ReSharper.Daemon.Xml.Highlightings.XmlErrorHighlighting
    {
        public XmlNoRootTagDefinedHighlighting(string tooltipTextFmt, params object[] args) { }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "XMLErrors", AttributeId="ReSharper Error Highlighting", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.UNRESOLVED_ERROR)]
    public class XmlNotResolvedErrorHighlighting<T> : JetBrains.ReSharper.Daemon.Xml.Highlightings.XmlResolveErrorHighlighting<T>
        where T : JetBrains.ReSharper.Psi.Resolve.IReference
    {
        public XmlNotResolvedErrorHighlighting(T reference) { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "XMLErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class XmlOnlyOneTagAllowedAtRootLevelHighlighting : JetBrains.ReSharper.Daemon.Xml.Highlightings.XmlErrorHighlighting
    {
        public XmlOnlyOneTagAllowedAtRootLevelHighlighting(string tooltipTextFmt, params object[] args) { }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "XMLErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class XmlPIErrorHighlighting : JetBrains.ReSharper.Daemon.Xml.Stages.XmlHighlighting
    {
        public XmlPIErrorHighlighting([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xml.Tree.IXmlProcessingInstruction xmlPI, string tooltipTextFmt, params object[] args) { }
        public JetBrains.ReSharper.Psi.Xml.Tree.IXmlProcessingInstruction XmlPI { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "XMLErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class XmlResolveErrorHighlighting<T> : JetBrains.ReSharper.Daemon.Xml.Stages.XmlHighlightingBase
        where T : JetBrains.ReSharper.Psi.Resolve.IReference
    {
        public XmlResolveErrorHighlighting(T reference) { }
        public XmlResolveErrorHighlighting(T reference, string tooltip) { }
        public JetBrains.ReSharper.Psi.Resolve.ResolveErrorType ErrorType { get; }
        public T Reference { get; }
        public override string ToolTip { get; }
        protected static string CreateTooltip(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "XMLErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class XmlSyntaxErrorHighlighting : JetBrains.ReSharper.Daemon.Xml.Highlightings.XmlErrorHighlighting
    {
        public XmlSyntaxErrorHighlighting(JetBrains.ReSharper.Psi.Xml.Tree.IXmlSyntaxErrorElement errorElement) { }
        public XmlSyntaxErrorHighlighting(JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken tokenNode) { }
        public XmlSyntaxErrorHighlighting(JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken tokenNode, string tooltip, params object[] args) { }
        public JetBrains.ReSharper.Psi.Xml.Tree.IXmlSyntaxErrorElement ErrorElement { get; }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "XMLErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class XmlTagFooterErrorHighlighting : JetBrains.ReSharper.Daemon.Xml.Highlightings.XmlErrorHighlighting
    {
        public XmlTagFooterErrorHighlighting(JetBrains.ReSharper.Psi.Xml.Tree.IXmlSyntaxErrorElement errorElement) { }
        public JetBrains.ReSharper.Psi.Xml.Tree.IXmlSyntaxErrorElement ErrorElement { get; }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "XMLErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class XmlTagIsNotClosedHighlighting : JetBrains.ReSharper.Daemon.Xml.Highlightings.XmlErrorHighlighting
    {
        public XmlTagIsNotClosedHighlighting([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag tag) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag Tag { get; }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "XMLErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class XmlTagIsNotClosedHighlighting2 : JetBrains.ReSharper.Daemon.Xml.Highlightings.XmlErrorHighlighting
    {
        public XmlTagIsNotClosedHighlighting2([JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag> tags) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag> Tags { get; }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "XMLErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class XmlTextIsNotAllowedAtRootHighlighting : JetBrains.ReSharper.Daemon.Xml.Highlightings.XmlErrorHighlighting
    {
        public XmlTextIsNotAllowedAtRootHighlighting(string tooltipTextFmt, params object[] args) { }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.WARNING, "XMLWarnings", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.WARNING)]
    public class XmlWarningHighlighting : JetBrains.ReSharper.Daemon.Xml.Stages.XmlHighlighting
    {
        public XmlWarningHighlighting(string tooltipTextFmt, params object[] args) { }
        public override bool IsValid() { }
    }
}
namespace JetBrains.ReSharper.Daemon.Xml.Stages.Analysis
{
    
    public interface IXmlAnalysisProvider
    {
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Daemon.Xml.Stages.XmlAnalysis> GetAnalyses(JetBrains.ReSharper.Psi.Xml.Tree.IXmlFile file, JetBrains.ReSharper.Daemon.IDaemonProcess process, JetBrains.Application.Settings.IContextBoundSettingsStore settingsStore);
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class XmlAnalysisManager
    {
        public XmlAnalysisManager(JetBrains.DataFlow.Lifetime lifetime, JetBrains.DataFlow.IViewable<JetBrains.ReSharper.Daemon.Xml.Stages.Analysis.IXmlAnalysisProvider> providers) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Daemon.Xml.Stages.Analysis.IXmlAnalysisProvider> Providers { get; }
    }
    [JetBrains.Annotations.MeansImplicitUseAttribute()]
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.All, AllowMultiple=false, Inherited=false)]
    public class XmlAnalysisProviderAttribute : JetBrains.ProjectModel.SolutionComponentAttribute { }
}
namespace JetBrains.ReSharper.Daemon.Xml.Stages.FileStructureStage
{
    
    public class XmlFileStructure : JetBrains.ReSharper.Daemon.Stages.FileStructureBase
    {
        public XmlFileStructure(JetBrains.ReSharper.Psi.Xml.Tree.IXmlFile file) { }
    }
    [JetBrains.ReSharper.Daemon.Stages.FileStructureExplorerAttribute()]
    public class XmlFileStructureExplorer : JetBrains.ReSharper.Daemon.Stages.IFileStructureExplorer
    {
        public JetBrains.ReSharper.Daemon.Stages.IFileStructure Run(System.Predicate<JetBrains.DocumentModel.DocumentRange> isRangeInvalidated, JetBrains.ReSharper.Psi.IPsiSourceFile psiSourceFile, JetBrains.Application.Settings.IContextBoundSettingsStore settingsStore, JetBrains.ReSharper.Psi.Tree.IFile file) { }
    }
}
namespace JetBrains.ReSharper.Daemon.Xml.Stages
{
    
    public class static HighlightingProcessUtil
    {
        public static JetBrains.ReSharper.Daemon.HighlightingInfo[] FixHighlightingInfos(JetBrains.ReSharper.Psi.Xml.Tree.IXmlFile xmlFile, System.Collections.Generic.IList<JetBrains.ReSharper.Daemon.HighlightingInfo> infos) { }
    }
    public abstract class XmlAnalysis
    {
        public virtual void Done(JetBrains.ReSharper.Psi.Xml.Tree.IXmlFile file, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer) { }
        public virtual void Init(JetBrains.ReSharper.Psi.Xml.Tree.IXmlFile file) { }
        public virtual bool InteriorShouldBeProcessed(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public virtual void ProcessAfterInterior(JetBrains.ReSharper.Psi.Tree.ITreeNode element, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer) { }
        public virtual void ProcessBeforeInterior(JetBrains.ReSharper.Psi.Tree.ITreeNode element, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer) { }
    }
    [JetBrains.ReSharper.Daemon.DaemonStageAttribute()]
    public class XmlAnalysisStage : JetBrains.ReSharper.Daemon.IDaemonStage
    {
        public XmlAnalysisStage([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Daemon.Xml.Stages.Analysis.XmlAnalysisManager xmlAnalysisManager) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Daemon.IDaemonStageProcess> CreateProcess(JetBrains.ReSharper.Daemon.IDaemonProcess process, JetBrains.Application.Settings.IContextBoundSettingsStore settings, JetBrains.ReSharper.Daemon.DaemonProcessKind processKind) { }
        public JetBrains.ReSharper.Daemon.ErrorStripeRequest NeedsErrorStripe(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.Application.Settings.IContextBoundSettingsStore settings) { }
    }
    public sealed class XmlAnalysisStageProcess : JetBrains.ReSharper.Daemon.Xml.Stages.XmlDaemonStageProcessBase, JetBrains.ReSharper.Psi.IRecursiveElementProcessor
    {
        public XmlAnalysisStageProcess([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xml.Tree.IXmlFile xmlFile, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Daemon.Xml.Stages.XmlAnalysis> analysises, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Daemon.IDaemonProcess process, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.IContextBoundSettingsStore settingsStore) { }
        public XmlAnalysisStageProcess([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xml.Tree.IXmlFile xmlFile, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Daemon.Xml.Stages.XmlAnalysis> analysises, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer) { }
        public override void Execute([JetBrains.Annotations.InstantHandleAttribute()] System.Action<JetBrains.ReSharper.Daemon.DaemonStageResult> committer) { }
    }
    public abstract class XmlDaemonStageProcessBase : JetBrains.ReSharper.Daemon.IDaemonStageProcess
    {
        protected XmlDaemonStageProcessBase([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xml.Tree.IXmlFile file, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Daemon.IDaemonProcess process) { }
        public JetBrains.ReSharper.Daemon.IDaemonProcess DaemonProcess { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.Psi.Xml.Tree.IXmlFile File { get; }
        public abstract void Execute(System.Action<JetBrains.ReSharper.Daemon.DaemonStageResult> committer);
    }
    public abstract class XmlErrorStageProcess : JetBrains.ReSharper.Daemon.Xml.Stages.XmlDaemonStageProcessBase, JetBrains.ReSharper.Psi.IRecursiveElementProcessor
    {
        protected readonly bool HighlightIdentifiers;
        [JetBrains.Annotations.NotNullAttribute()]
        protected readonly JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer HighlightingConsumer;
        protected XmlErrorStageProcess([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xml.Tree.IXmlFile file, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Daemon.IDaemonProcess process, JetBrains.ReSharper.Daemon.DaemonProcessKind processKind, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.IContextBoundSettingsStore settingsStore, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Daemon.Stages.Resolve.ResolveHighlighterRegistrar resolveHighlighterRegistrar, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerRegistrar elementProblemAnalyzerRegistrar) { }
        public bool ProcessingIsFinished { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        protected virtual JetBrains.ReSharper.Daemon.IHighlighting CreateResolveErrorHighlighting(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.Resolve.ResolveErrorType resolveErrorType) { }
        public override void Execute(System.Action<JetBrains.ReSharper.Daemon.DaemonStageResult> committer) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        protected virtual string GetHighlightingAttributeId([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
        protected virtual void HighlightDeclaration([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
        protected void HighlightReferencedIdentifier([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, JetBrains.DocumentModel.DocumentRange referenceRange) { }
        protected virtual void HighlightTypeDeclaration(JetBrains.ReSharper.Psi.Tree.ITypeDeclaration typeDeclaration) { }
        protected virtual void HighlightTypeMemberDeclaration(JetBrains.ReSharper.Psi.Tree.ITypeMemberDeclaration memberDeclaration) { }
        public virtual bool InteriorShouldBeProcessed(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public virtual void ProcessAfterInterior(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public virtual void ProcessBeforeInterior(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public virtual void ProcessReference(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        protected virtual void ProcessResolvedReference(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
    }
    public abstract class XmlHighlighting : JetBrains.ReSharper.Daemon.Xml.Stages.XmlHighlightingBase
    {
        protected readonly string myTooltipText;
        public XmlHighlighting(string tooltipTextFmt, params object[] args) { }
        public System.Drawing.Color ColorOnStripe { get; }
        public override string ErrorStripeToolTip { get; }
        public virtual int NavigationOffsetPatch { get; }
        public bool ShowToolTipInStatusBar { get; }
        public override string ToolTip { get; }
    }
    public abstract class XmlHighlightingBase : JetBrains.ReSharper.Daemon.IHighlighting
    {
        public virtual string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public virtual string ToolTip { get; }
        public abstract bool IsValid();
    }
    public class XmlPIAnalysis : JetBrains.ReSharper.Daemon.Xml.Stages.XmlAnalysis
    {
        public static readonly PiAttributeConstraint[] XML_PI_ATTRIBUTE_CONSTRAINT;
        public static readonly string[] XML_PI_ATTRIBUTE_VALUES;
        public static readonly string[] XML_PI_ATTRIBUTES;
        public override bool InteriorShouldBeProcessed(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public override void ProcessBeforeInterior(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer highlightings) { }
        [System.FlagsAttribute()]
        public enum PiAttributeConstraint
        {
            REQUIRED = 1,
            FIXED_POS = 2,
        }
    }
    public class static XMLStaticHighlightingsGroups
    {
        public const string XMLErrorsGroup = "XMLErrors";
        public const string XMLWarningsGroup = "XMLWarnings";
    }
}
namespace JetBrains.ReSharper.Daemon.Xml.Stages.Resolve
{
    
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Xml.XmlLanguage))]
    public class XmlNotResolvedErrorHandler : JetBrains.ReSharper.Daemon.Stages.Resolve.IResolveProblemHighlighter
    {
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Resolve.ResolveErrorType> ErrorTypes { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        protected virtual JetBrains.ReSharper.Daemon.IHighlighting CreateNotResolvedErrorHighlighting(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        protected virtual JetBrains.ReSharper.Daemon.IHighlighting CreateNotResolvedLateBoundReferenceHighlighting(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public JetBrains.ReSharper.Daemon.IHighlighting Run(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
    }
}
namespace JetBrains.ReSharper.Daemon.Xml
{
    
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Xml.XmlLanguage))]
    public class XmlDaemonBehavior : JetBrains.ReSharper.Daemon.ILanguageSpecificDaemonBehavior
    {
        public virtual bool CanShowErrorBox { get; }
        public virtual bool RunInSolutionAnalysis { get; }
        public virtual JetBrains.ReSharper.Daemon.ErrorStripeRequest InitialErrorStripe(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
    }
}