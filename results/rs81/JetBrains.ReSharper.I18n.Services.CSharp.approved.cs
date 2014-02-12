[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]

namespace JetBrains.ReSharper.I18n.Services.CSharp
{
    
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class CSharpLocalizableManager : JetBrains.ReSharper.I18n.Services.ILocalizableManager
    {
        public JetBrains.ReSharper.I18n.Services.Localizable IsLocalizable(JetBrains.ReSharper.Psi.Tree.IExpression expression) { }
    }
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(JetBrains.ReSharper.I18n.Services.LocalizationProjectSettings), "C# localization options")]
    public class CSharpLocalizationOptionsSettings
    {
        [JetBrains.Application.Settings.SettingsEntryAttribute(true, "Ignore verbatim strings")]
        public bool DontAnalyseVerbatimStrings;
    }
    [JetBrains.Application.Configuration.Upgrade.GlobalSettingsUpgraderAttribute()]
    public class CSharpLocalizationOptionsUpgrader : JetBrains.Application.Configuration.SettingTablesUpgrader
    {
        public CSharpLocalizationOptionsUpgrader(JetBrains.Application.Env.RunsProducts.ProductConfigurations productConfigurations) { }
        protected override void DoUpgrade(JetBrains.Application.Configuration.IComponentSettingsProvider legacySettingsProvider, JetBrains.Application.Settings.IContextBoundSettingsStore boundSettingsStore, JetBrains.DataFlow.Lifetime upgradeLifetime, JetBrains.Application.Configuration.SettingsTableBase workspaceSettingsTable, JetBrains.Application.Configuration.SettingsTableBase globalSettingsTable) { }
    }
    public class LocalizableManager
    {
        public static readonly JetBrains.ReSharper.Psi.IClrTypeName ComponentLocalizableAttribute;
        public static JetBrains.ReSharper.I18n.Services.Localizable IsLocalizable([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression expression) { }
        public static JetBrains.ReSharper.I18n.Services.Localizable IsLocalizable([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression expression, out JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression localizableExpression) { }
        public static JetBrains.ReSharper.I18n.Services.Localizable IsLocalizable([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression expression, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IDictionary<JetBrains.ReSharper.Psi.IDeclaredElement, JetBrains.ReSharper.I18n.Services.Localizable> cacheLocalizableItems) { }
        public static JetBrains.ReSharper.I18n.Services.Localizable IsLocalizable([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression expression, out JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression localizableExpression, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IDictionary<JetBrains.ReSharper.Psi.IDeclaredElement, JetBrains.ReSharper.I18n.Services.Localizable> cacheLocalizableItems) { }
        public static JetBrains.ReSharper.I18n.Services.Localizable IsLocalizable([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression expression, out JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression localizableExpression, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IDictionary<JetBrains.ReSharper.Psi.IDeclaredElement, JetBrains.ReSharper.I18n.Services.Localizable> cacheLocalizableItems, JetBrains.ReSharper.Psi.CodeAnnotations.CodeAnnotationsCache codeAnnotationsCache) { }
        public static JetBrains.ReSharper.I18n.Services.Localizable IsLocalizable([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.IDeclaredElement owner) { }
        public static JetBrains.ReSharper.I18n.Services.Localizable IsLocalizable([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.IDeclaredElement owner, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IDictionary<JetBrains.ReSharper.Psi.IDeclaredElement, JetBrains.ReSharper.I18n.Services.Localizable> cacheLocalizableItems) { }
        public static JetBrains.ReSharper.I18n.Services.Localizable IsLocalizable([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.IDeclaredElement owner, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IDictionary<JetBrains.ReSharper.Psi.IDeclaredElement, JetBrains.ReSharper.I18n.Services.Localizable> cacheLocalizableItems, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.CodeAnnotations.CodeAnnotationsCache codeAnnotationsCache) { }
    }
}
namespace JetBrains.ReSharper.I18n.Services.CSharp.CustomReferences
{
    
    public class CSharpComponentResourceReference : JetBrains.ReSharper.I18n.Services.CSharp.CustomReferences.CSharpResourceReference, JetBrains.ReSharper.Feature.Services.Util.IImplicitReference, JetBrains.ReSharper.Feature.Services.Util.IPrefferedReference, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.Util.IUserDataHolder
    {
        public CSharpComponentResourceReference(JetBrains.ReSharper.Psi.TreeTextRange withinRange, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpArgument owner, JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression token) { }
        protected override JetBrains.ReSharper.Psi.Resolve.IReference BindToInternal(JetBrains.ReSharper.Psi.IDeclaredElement element, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
        public override JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetReferenceSymbolTable(bool useReferenceName) { }
        public override JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.ResolveResultWithInfo ResolveWithoutCache() { }
    }
    public class CSharpResourceReference : JetBrains.ReSharper.I18n.Services.CustomReferences.ResourceReference<JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpArgument, JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression>, JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.SmartCompletion.ISmartCompleatebleReference
    {
        public CSharpResourceReference(JetBrains.ReSharper.Psi.TreeTextRange withinRange, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpArgument owner, JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression token) { }
        public override System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.IPsiSourceFile> FindResourceFiles() { }
    }
    public class CSharpWindowsResourceItemReference : JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.CheckedReferenceBase<JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpArgument>, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.ICheckedReference, JetBrains.ReSharper.Psi.Resolve.ICompleteableReference, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.ReSharper.Psi.Resx.Tree.IResourceItemReference, JetBrains.ReSharper.Psi.Resx.Tree.IResourceReference, JetBrains.Util.IUserDataHolder
    {
        public CSharpWindowsResourceItemReference(JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpArgument owner) { }
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
        public static string GetResourceFullName([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpArgument argument) { }
        public override JetBrains.ReSharper.Psi.Resolve.ISymbolFilter[] GetSymbolFilters() { }
        public override JetBrains.ReSharper.Psi.TreeTextRange GetTreeTextRange() { }
        public override JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.ResolveResultWithInfo ResolveWithoutCache() { }
    }
    public class CSharpWindowsResourceLoaderItemReference : JetBrains.ReSharper.I18n.Services.CSharp.CustomReferences.CSharpWindowsResourceItemReference
    {
        public CSharpWindowsResourceLoaderItemReference(JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpArgument owner) { }
        public override JetBrains.ReSharper.Psi.Resolve.IReference BindTo(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.CSharp.Tree.IArgumentList GetConstructorArgumentList(JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpArgument argument) { }
        protected override string GetResourceFullName() { }
        public new static string GetResourceFullName(JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpArgument sharpArgument) { }
    }
    public class CSharpWindowsResourceLoaderItemReferenceProvider : JetBrains.ReSharper.I18n.Services.CustomReferences.StringArgumentReferenceFactoryBase<JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpArgument, JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression>
    {
        public CSharpWindowsResourceLoaderItemReferenceProvider() { }
        protected override JetBrains.ReSharper.Psi.Resolve.IReference[] CreateArgumentReferences(JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpArgument argument, JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression argumentValue, JetBrains.ReSharper.Psi.IInvocationInfo invocation) { }
        protected override System.Collections.Generic.IEnumerable<string> GetNamesFromArgumentValue(JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpArgument argument) { }
        protected override bool OnMethodCandidate(string methodName) { }
        protected override bool OnParameterCandidate(JetBrains.ReSharper.Psi.IInvocationInfo invocationInfo, JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpArgument argument) { }
        protected override bool OnTypeCandidate(string typeName) { }
    }
    public class CSharpWindowsResourceManagerReferenceProvider : JetBrains.ReSharper.I18n.Services.CustomReferences.StringArgumentReferenceFactoryBase<JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpArgument, JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression>
    {
        public CSharpWindowsResourceManagerReferenceProvider() { }
        protected override JetBrains.ReSharper.Psi.Resolve.IReference[] CreateArgumentReferences(JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpArgument argument, JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression argumentValue, JetBrains.ReSharper.Psi.IInvocationInfo invocation) { }
        protected override System.Collections.Generic.IEnumerable<string> GetNamesFromArgumentValue(JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpArgument argument) { }
        protected override bool OnMethodCandidate(string methodName) { }
        protected override bool OnParameterCandidate(JetBrains.ReSharper.Psi.IInvocationInfo invocationInfo, JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpArgument argument) { }
        protected override bool OnTypeCandidate(string typeName) { }
    }
    public class ResourceManagerReferenceProvider : JetBrains.ReSharper.I18n.Services.CustomReferences.StringArgumentReferenceFactoryBase<JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpArgument, JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression>
    {
        public ResourceManagerReferenceProvider() { }
        protected override JetBrains.ReSharper.Psi.Resolve.IReference[] CreateArgumentReferences(JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpArgument argument, JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression argumentValue, JetBrains.ReSharper.Psi.IInvocationInfo invocation) { }
        protected override bool OnMethodCandidate(string methodName) { }
        protected override bool OnParameterCandidate(JetBrains.ReSharper.Psi.IInvocationInfo invocationInfo, JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpArgument argument) { }
        protected override bool OnTypeCandidate(string typeName) { }
    }
}
namespace JetBrains.ReSharper.I18n.Services.CSharp.Daemon.Errors
{
    
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("LocalizableElement", "CSHARP", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.WARNING, ToolTipFormatString="Localizable string: \"{0}\"")]
    public class LocalizableStringWarning : JetBrains.ReSharper.Daemon.CSharp.Errors.CSharpHighlightingBase, JetBrains.ReSharper.Daemon.IHighlighting, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "LocalizableElement";
        protected const string MESSAGE = "Localizable string: \"{0}\"";
        public LocalizableStringWarning(JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression expression, JetBrains.DocumentModel.DocumentRange range) { }
        public string ErrorStripeToolTip { get; }
        public JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression Expression { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.DocumentModel.DocumentRange Range { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
}
namespace JetBrains.ReSharper.I18n.Services.CSharp.Daemon
{
    
    [JetBrains.ReSharper.Daemon.DaemonStageAttribute(StagesBefore=new System.Type[] {
            typeof(JetBrains.ReSharper.Daemon.LanguageSpecificDaemonStage),
            typeof(JetBrains.ReSharper.Daemon.Stages.GlobalFileStructureCollectorStage)})]
    public class LocalizableElementDaemonStage : JetBrains.ReSharper.Daemon.CSharp.Stages.CSharpDaemonStageBase
    {
        public LocalizableElementDaemonStage(JetBrains.ReSharper.Psi.CodeAnnotations.CodeAnnotationsCache codeAnnotationsCache) { }
        protected override JetBrains.ReSharper.Daemon.IDaemonStageProcess CreateProcess(JetBrains.ReSharper.Daemon.IDaemonProcess process, JetBrains.Application.Settings.IContextBoundSettingsStore settings, JetBrains.ReSharper.Daemon.DaemonProcessKind processKind, JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpFile file1) { }
        public override JetBrains.ReSharper.Daemon.ErrorStripeRequest NeedsErrorStripe(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.Application.Settings.IContextBoundSettingsStore settings) { }
    }
}
namespace JetBrains.ReSharper.I18n.Services.CSharp.QuickFixes
{
    
    public class ConvertArgumentToVerbatimStringFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public ConvertArgumentToVerbatimStringFix(JetBrains.ReSharper.I18n.Services.CSharp.Daemon.Errors.LocalizableStringWarning error) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class ConvertRegularStringToVerbatimFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public ConvertRegularStringToVerbatimFix(JetBrains.ReSharper.I18n.Services.CSharp.Daemon.Errors.LocalizableStringWarning error) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class DisableProjectLocalizationFix : JetBrains.ReSharper.Intentions.Extensibility.IBulbAction, JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        public DisableProjectLocalizationFix(JetBrains.ReSharper.I18n.Services.CSharp.Daemon.Errors.LocalizableStringWarning error) { }
        public string Text { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public void Execute(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class MarkDeclarationAsNonLocalizableFix : JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        public MarkDeclarationAsNonLocalizableFix(JetBrains.ReSharper.I18n.Services.CSharp.Daemon.Errors.LocalizableStringWarning error) { }
        public JetBrains.ReSharper.Intentions.Extensibility.IBulbAction[] Items { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class MoveToResourceFix : JetBrains.ReSharper.Intentions.Extensibility.IBulbAction, JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        public MoveToResourceFix(JetBrains.ReSharper.I18n.Services.CSharp.Daemon.Errors.LocalizableStringWarning error) { }
        public string Text { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public void Execute(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
}
namespace JetBrains.ReSharper.I18n.Services.CSharp.Refactoring
{
    
    public abstract class ExpressionToResourceExtractor : JetBrains.ReSharper.I18n.Services.Refactoring.ExpressionToResourceExtractorBase<JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression>
    {
        protected ExpressionToResourceExtractor(JetBrains.ReSharper.I18n.Services.Searching.ResourceAccessorFinder resourceAccessorFinder) { }
        public override JetBrains.ReSharper.I18n.Services.Refactoring.ISourceElement GetSourceElement(JetBrains.ReSharper.Psi.Tree.ITreeNode node) { }
    }
}
namespace JetBrains.ReSharper.I18n.Services.CSharp.Searching
{
    
    [JetBrains.ReSharper.I18n.Services.Searching.ResourceAccessorsFinderAttribute(Priority=1)]
    public class CSharpGeneratedResourceAccessorFinder : JetBrains.ReSharper.I18n.Services.Searching.IResourceAccessorFinder
    {
        public CSharpGeneratedResourceAccessorFinder(JetBrains.ReSharper.I18n.Services.Searching.GeneratedFileFinder generatedFileFinder) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.I18n.Services.Searching.IResourceAccessor> FindAccessors(JetBrains.ReSharper.Psi.IResourceItemDeclaredElement element, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.I18n.Services.Searching.IResourceAccessor> accessors) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.ITypeElement> FindTypeElements(JetBrains.ReSharper.Psi.IPsiSourceFile resourceFile) { }
    }
    [JetBrains.ReSharper.Psi.PsiSharedComponentAttribute()]
    public class CSharpResourceUsagesByByArgumentSearcherFactory : JetBrains.ReSharper.Psi.ExtensionsAPI.IDomainSpecificSearcherFactory
    {
        public CSharpResourceUsagesByByArgumentSearcherFactory(JetBrains.ReSharper.I18n.Services.Searching.GeneratedFileFinder generatedFileFinder) { }
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
namespace JetBrains.ReSharper.I18n.Services.UI.Options
{
    
    [JetBrains.UI.Options.OptionsPageAttribute("CSharpLocalizationOptions", "Localization", typeof(JetBrains.ReSharper.I18n.Services.Resources.Services118nThemedIcons.Localization), HelpKeyword="Reference__Options__Languages__CSharp__Localization", ParentId="Csharp", SupportedEditions=new string[] {
            "Csharp"})]
    public class CSharpLocallizationOptionPage : JetBrains.ReSharper.I18n.Services.UI.Options.OptionPageBase
    {
        public CSharpLocallizationOptionPage(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Threading.IThreading threading, JetBrains.UI.Options.OptionsSettingsSmartContext smartContext, JetBrains.UI.Application.IUIApplication environment, JetBrains.ReSharper.Daemon.Daemon daemon = null) { }
        protected override void Dispose(bool disposing) { }
        protected override void InitializeUI() { }
        protected override bool PressOk() { }
    }
}