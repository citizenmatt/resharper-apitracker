[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]

namespace JetBrains.ReSharper.I18n.Services.VB.CustomReferences
{
    
    public class ResourceManagerReferenceProvider : JetBrains.ReSharper.I18n.Services.CustomReferences.StringArgumentReferenceFactoryBase<JetBrains.ReSharper.Psi.VB.Tree.IExpressionArgument, JetBrains.ReSharper.Psi.VB.Tree.IVBExpression>
    {
        public ResourceManagerReferenceProvider() { }
        protected override JetBrains.ReSharper.Psi.Resolve.IReference[] CreateArgumentReferences(JetBrains.ReSharper.Psi.VB.Tree.IExpressionArgument argument, JetBrains.ReSharper.Psi.VB.Tree.IVBExpression argumentValue, JetBrains.ReSharper.Psi.IInvocationInfo invocation) { }
        protected override bool OnMethodCandidate(string methodName) { }
        protected override bool OnParameterCandidate(JetBrains.ReSharper.Psi.IInvocationInfo invocationInfo, JetBrains.ReSharper.Psi.VB.Tree.IExpressionArgument argument) { }
        protected override bool OnTypeCandidate(string typeName) { }
    }
    public class VBComponentResourceReference : JetBrains.ReSharper.I18n.Services.VB.CustomReferences.VBResourceReference, JetBrains.ReSharper.Feature.Services.Util.IImplicitReference, JetBrains.ReSharper.Feature.Services.Util.IPrefferedReference, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.Util.IUserDataHolder
    {
        public VBComponentResourceReference(JetBrains.ReSharper.Psi.TreeTextRange withinRange, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.VB.Tree.IExpressionArgument owner, JetBrains.ReSharper.Psi.VB.Tree.IVBExpression token) { }
        protected override JetBrains.ReSharper.Psi.Resolve.IReference BindToInternal(JetBrains.ReSharper.Psi.IDeclaredElement element, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
        public override JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetReferenceSymbolTable(bool useReferenceName) { }
        public override JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.ResolveResultWithInfo ResolveWithoutCache() { }
    }
    public class VBResourceReference : JetBrains.ReSharper.I18n.Services.CustomReferences.ResourceReference<JetBrains.ReSharper.Psi.VB.Tree.IExpressionArgument, JetBrains.ReSharper.Psi.VB.Tree.IVBExpression>, JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.ISmartCompleatebleReference, JetBrains.ReSharper.Psi.Resolve.ICompleteableReference, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.Util.IUserDataHolder
    {
        public VBResourceReference(JetBrains.ReSharper.Psi.TreeTextRange withinRange, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.VB.Tree.IExpressionArgument owner, JetBrains.ReSharper.Psi.VB.Tree.IVBExpression token) { }
        public override System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.IPsiSourceFile> FindResourceFiles() { }
    }
    public class VBWindowsResourceItemReference : JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.CheckedReferenceBase<JetBrains.ReSharper.Psi.VB.Tree.IVBArgument>, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.ICheckedReference, JetBrains.ReSharper.Psi.Resolve.ICompleteableReference, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.ReSharper.Psi.Resx.Tree.IResourceItemReference, JetBrains.ReSharper.Psi.Resx.Tree.IResourceReference, JetBrains.Util.IUserDataHolder
    {
        public VBWindowsResourceItemReference(JetBrains.ReSharper.Psi.VB.Tree.IVBArgument owner) { }
        public override bool HasMultipleNames { get; }
        public override JetBrains.ReSharper.Psi.Resolve.IReference BindTo(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public override JetBrains.ReSharper.Psi.Resolve.IReference BindTo(JetBrains.ReSharper.Psi.IDeclaredElement element, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
        public System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.IPsiSourceFile> FindResourceFiles() { }
        public override JetBrains.ReSharper.Psi.Resolve.IAccessContext GetAccessContext() { }
        public override System.Collections.Generic.IEnumerable<string> GetAllNames() { }
        public JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetCompletionSymbolTable() { }
        public string GetDefaultName() { }
        public override string GetName() { }
        public override JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetReferenceSymbolTable(bool useReferenceName) { }
        protected virtual string GetResourceFullName() { }
        public static string GetResourceFullName(JetBrains.ReSharper.Psi.VB.Tree.IVBArgument argument) { }
        public override JetBrains.ReSharper.Psi.Resolve.ISymbolFilter[] GetSymbolFilters() { }
        public override JetBrains.ReSharper.Psi.TreeTextRange GetTreeTextRange() { }
        public override JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.ResolveResultWithInfo ResolveWithoutCache() { }
    }
    public class VBWindowsResourceLoaderItemReference : JetBrains.ReSharper.I18n.Services.VB.CustomReferences.VBWindowsResourceItemReference
    {
        public VBWindowsResourceLoaderItemReference(JetBrains.ReSharper.Psi.VB.Tree.IVBArgument owner) { }
        public override JetBrains.ReSharper.Psi.Resolve.IReference BindTo(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.VB.Tree.IArgumentList GetConstructorArgumentList(JetBrains.ReSharper.Psi.VB.Tree.IVBArgument argument) { }
        protected override string GetResourceFullName() { }
        public new static string GetResourceFullName(JetBrains.ReSharper.Psi.VB.Tree.IVBArgument vbArgument) { }
    }
    public class VBWindowsResourceLoaderItemReferenceProvider : JetBrains.ReSharper.I18n.Services.CustomReferences.StringArgumentReferenceFactoryBase<JetBrains.ReSharper.Psi.VB.Tree.IExpressionArgument, JetBrains.ReSharper.Psi.VB.Tree.IVBExpression>
    {
        public VBWindowsResourceLoaderItemReferenceProvider() { }
        protected override JetBrains.ReSharper.Psi.Resolve.IReference[] CreateArgumentReferences(JetBrains.ReSharper.Psi.VB.Tree.IExpressionArgument argument, JetBrains.ReSharper.Psi.VB.Tree.IVBExpression argumentValue, JetBrains.ReSharper.Psi.IInvocationInfo invocation) { }
        protected override System.Collections.Generic.IEnumerable<string> GetNamesFromArgumentValue(JetBrains.ReSharper.Psi.VB.Tree.IExpressionArgument argument) { }
        protected override bool OnMethodCandidate(string methodName) { }
        protected override bool OnParameterCandidate(JetBrains.ReSharper.Psi.IInvocationInfo invocationInfo, JetBrains.ReSharper.Psi.VB.Tree.IExpressionArgument argument) { }
        protected override bool OnTypeCandidate(string typeName) { }
    }
    public class VBWindowsResourceManagerReferenceProvider : JetBrains.ReSharper.I18n.Services.CustomReferences.StringArgumentReferenceFactoryBase<JetBrains.ReSharper.Psi.VB.Tree.IExpressionArgument, JetBrains.ReSharper.Psi.VB.Tree.IVBExpression>
    {
        public VBWindowsResourceManagerReferenceProvider() { }
        protected override JetBrains.ReSharper.Psi.Resolve.IReference[] CreateArgumentReferences(JetBrains.ReSharper.Psi.VB.Tree.IExpressionArgument argument, JetBrains.ReSharper.Psi.VB.Tree.IVBExpression argumentValue, JetBrains.ReSharper.Psi.IInvocationInfo invocation) { }
        protected override System.Collections.Generic.IEnumerable<string> GetNamesFromArgumentValue(JetBrains.ReSharper.Psi.VB.Tree.IExpressionArgument argument) { }
        protected override bool OnMethodCandidate(string methodName) { }
        protected override bool OnParameterCandidate(JetBrains.ReSharper.Psi.IInvocationInfo invocationInfo, JetBrains.ReSharper.Psi.VB.Tree.IExpressionArgument argument) { }
        protected override bool OnTypeCandidate(string typeName) { }
    }
}
namespace JetBrains.ReSharper.I18n.Services.VB.Daemon.Errors
{
    
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("LocalizableElement", "VBASIC", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.WARNING, ToolTipFormatString="Localizable string: \"{0}\"")]
    public class LocalizableStringWarning : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.IHighlighting, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "LocalizableElement";
        protected const string MESSAGE = "Localizable string: \"{0}\"";
        public LocalizableStringWarning(JetBrains.ReSharper.Psi.VB.Tree.IVBExpression expression, JetBrains.DocumentModel.DocumentRange range) { }
        public string ErrorStripeToolTip { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IVBExpression Expression { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.DocumentModel.DocumentRange Range { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
}
namespace JetBrains.ReSharper.I18n.Services.VB.Daemon
{
    
    [JetBrains.ReSharper.Daemon.DaemonStageAttribute(StagesBefore=new System.Type[] {
            typeof(JetBrains.ReSharper.Daemon.LanguageSpecificDaemonStage)})]
    public class LocalizableElementDaemonStage : JetBrains.ReSharper.Daemon.VB.Stages.VBDaemonStageBase
    {
        public LocalizableElementDaemonStage(JetBrains.ReSharper.Psi.CodeAnnotations.CodeAnnotationsCache codeAnnotationsCache) { }
        public override JetBrains.ReSharper.Daemon.IDaemonStageProcess CreateProcess(JetBrains.ReSharper.Daemon.IDaemonProcess process, JetBrains.Application.Settings.IContextBoundSettingsStore settings, JetBrains.ReSharper.Daemon.DaemonProcessKind processKind, JetBrains.ReSharper.Psi.VB.Tree.IVBFile vbFile) { }
    }
}
namespace JetBrains.ReSharper.I18n.Services.VB
{
    
    public class static LocalizableManager
    {
        public static readonly JetBrains.ReSharper.Psi.IClrTypeName ComponentLocalizableAttribute;
        public static readonly string LocalizationRequiredAttribute;
        public static JetBrains.ReSharper.I18n.Services.Localizable IsLocalizable([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.VB.Tree.IVBExpression expression) { }
        public static JetBrains.ReSharper.I18n.Services.Localizable IsLocalizable([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.VB.Tree.IVBExpression expression, out JetBrains.ReSharper.Psi.VB.Tree.IVBExpression localizableExpression) { }
        public static JetBrains.ReSharper.I18n.Services.Localizable IsLocalizable([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.VB.Tree.IVBExpression expression, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IDictionary<JetBrains.ReSharper.Psi.IDeclaredElement, JetBrains.ReSharper.I18n.Services.Localizable> cacheLocalizableItems) { }
        public static JetBrains.ReSharper.I18n.Services.Localizable IsLocalizable([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.VB.Tree.IVBExpression expression, out JetBrains.ReSharper.Psi.VB.Tree.IVBExpression localizableExpression, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IDictionary<JetBrains.ReSharper.Psi.IDeclaredElement, JetBrains.ReSharper.I18n.Services.Localizable> cacheLocalizableItems) { }
        public static JetBrains.ReSharper.I18n.Services.Localizable IsLocalizable([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.VB.Tree.IVBExpression expression, out JetBrains.ReSharper.Psi.VB.Tree.IVBExpression localizableExpression, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IDictionary<JetBrains.ReSharper.Psi.IDeclaredElement, JetBrains.ReSharper.I18n.Services.Localizable> cacheLocalizableItems, JetBrains.ReSharper.Psi.CodeAnnotations.CodeAnnotationsCache codeAnnotationsCache) { }
        public static JetBrains.ReSharper.I18n.Services.Localizable IsLocalizable([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.IDeclaredElement owner) { }
        public static JetBrains.ReSharper.I18n.Services.Localizable IsLocalizable([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.IDeclaredElement owner, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IDictionary<JetBrains.ReSharper.Psi.IDeclaredElement, JetBrains.ReSharper.I18n.Services.Localizable> cacheLocalizableItems) { }
        public static JetBrains.ReSharper.I18n.Services.Localizable IsLocalizable([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.IDeclaredElement owner, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IDictionary<JetBrains.ReSharper.Psi.IDeclaredElement, JetBrains.ReSharper.I18n.Services.Localizable> cacheLocalizableItems, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.CodeAnnotations.CodeAnnotationsCache codeAnnotationsCache) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class VBLocalizableManager : JetBrains.ReSharper.I18n.Services.ILocalizableManager
    {
        public JetBrains.ReSharper.I18n.Services.Localizable IsLocalizable(JetBrains.ReSharper.Psi.Tree.IExpression expression) { }
    }
}
namespace JetBrains.ReSharper.I18n.Services.VB.QuickFixes
{
    
    public class DisableProjectLocalizationFix : JetBrains.ReSharper.Intentions.Extensibility.IBulbAction, JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        public DisableProjectLocalizationFix(JetBrains.ReSharper.I18n.Services.VB.Daemon.Errors.LocalizableStringWarning error) { }
        public string Text { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public void Execute(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class MarkDeclarationAsNonLocalizableFix : JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        public MarkDeclarationAsNonLocalizableFix(JetBrains.ReSharper.I18n.Services.VB.Daemon.Errors.LocalizableStringWarning error) { }
        public JetBrains.ReSharper.Intentions.Extensibility.IBulbAction[] Items { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class MoveToResourceFix : JetBrains.ReSharper.Intentions.Extensibility.IBulbAction, JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        public MoveToResourceFix(JetBrains.ReSharper.I18n.Services.VB.Daemon.Errors.LocalizableStringWarning error) { }
        public string Text { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public void Execute(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
}
namespace JetBrains.ReSharper.I18n.Services.VB.Refactoring
{
    
    public abstract class ExpressionToResourceExtractor : JetBrains.ReSharper.I18n.Services.Refactoring.ExpressionToResourceExtractorBase<JetBrains.ReSharper.Psi.VB.Tree.IVBExpression>
    {
        protected ExpressionToResourceExtractor(JetBrains.ReSharper.I18n.Services.Searching.ResourceAccessorFinder resourceAccessorFinder) { }
        public override JetBrains.ReSharper.I18n.Services.Refactoring.ISourceElement GetSourceElement(JetBrains.ReSharper.Psi.Tree.ITreeNode node) { }
    }
}
namespace JetBrains.ReSharper.I18n.Services.VB.Searching
{
    
    [JetBrains.ReSharper.I18n.Services.Searching.ResourceAccessorsFinderAttribute(Priority=1)]
    public class VBGeneratedResourceAccessorFinder : JetBrains.ReSharper.I18n.Services.Searching.IResourceAccessorFinder
    {
        public VBGeneratedResourceAccessorFinder(JetBrains.ReSharper.I18n.Services.Searching.GeneratedFileFinder generatedFileFinder) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.I18n.Services.Searching.IResourceAccessor> FindAccessors(JetBrains.ReSharper.Psi.IResourceItemDeclaredElement element, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.I18n.Services.Searching.IResourceAccessor> accessors) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.ITypeElement> FindTypeElements(JetBrains.ReSharper.Psi.IPsiSourceFile resourceFile) { }
    }
    [JetBrains.ReSharper.Psi.PsiSharedComponentAttribute()]
    public class VBResourceUsagesByArgumentSearcherFactory : JetBrains.ReSharper.Psi.ExtensionsAPI.IDomainSpecificSearcherFactory
    {
        public VBResourceUsagesByArgumentSearcherFactory(JetBrains.ReSharper.I18n.Services.Searching.GeneratedFileFinder generatedFileFinder) { }
        public System.Collections.Generic.ICollection<string> Methods { get; }
        public JetBrains.ReSharper.Psi.ExtensionsAPI.IDomainSpecificSearcher CreateAnonymousTypeSearcher(System.Collections.Generic.IList<JetBrains.ReSharper.Psi.AnonymousTypeDescriptor> typeDescription, bool caseSensitive) { }
        public JetBrains.ReSharper.Psi.ExtensionsAPI.IDomainSpecificSearcher CreateConstantExpressionSearcher(JetBrains.ReSharper.Psi.ConstantValue constantValue, bool onlyLiteralExpression) { }
        public JetBrains.ReSharper.Psi.ExtensionsAPI.IDomainSpecificSearcher CreateConstructorSpecialReferenceSearcher(System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.IConstructor> constructors) { }
        public JetBrains.ReSharper.Psi.ExtensionsAPI.IDomainSpecificSearcher CreateLateBoundReferenceSearcher(System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.IDeclaredElement> elements) { }
        public JetBrains.ReSharper.Psi.ExtensionsAPI.IDomainSpecificSearcher CreateMethodsReferencedByDelegateSearcher(JetBrains.ReSharper.Psi.IDelegate @delegate) { }
        public JetBrains.ReSharper.Psi.ExtensionsAPI.IDomainSpecificSearcher CreateReferenceSearcher(System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.IDeclaredElement> elements, bool findCandidates) { }
        public JetBrains.ReSharper.Psi.ExtensionsAPI.IDomainSpecificSearcher CreateTextOccurenceSearcher(System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.IDeclaredElement> elements) { }
        public JetBrains.ReSharper.Psi.ExtensionsAPI.IDomainSpecificSearcher CreateTextOccurenceSearcher(string subject) { }
        public virtual System.Collections.Generic.IEnumerable<string> GetAllPossibleWordsInFile(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public JetBrains.ReSharper.Psi.Search.ISearchDomain GetDeclaredElementSearchDomain(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
        public JetBrains.Util.JetTuple<System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.IDeclaredElement>, System.Predicate<JetBrains.ReSharper.Psi.Search.IFindResultReference>, bool> GetDerivedFindRequest(JetBrains.ReSharper.Psi.Search.IFindResultReference result) { }
        public JetBrains.Util.JetTuple<System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.IDeclaredElement>, bool> GetNavigateToTargets(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public System.Collections.Generic.IEnumerable<JetBrains.Util.Pair<JetBrains.ReSharper.Psi.IDeclaredElement, System.Predicate<JetBrains.ReSharper.Psi.Search.FindResult>>> GetRelatedDeclaredElements(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public bool IsCompatibleWithLanguage(JetBrains.ReSharper.Psi.PsiLanguageType languageType) { }
        public System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.Search.FindResult> TransformNavigationTargets(System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.Search.FindResult> targets) { }
    }
}