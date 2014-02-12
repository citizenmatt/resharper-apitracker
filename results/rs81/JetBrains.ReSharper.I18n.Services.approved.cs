[assembly: JetBrains.ActionManagement.ActionsXmlAttribute("JetBrains.ReSharper.I18n.Services.resources.Actions.xml")]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("ResourceNotResolved", null, "CodeSmell", "Cannot resolve resource", "Cannot resolve resource.", JetBrains.ReSharper.Daemon.Severity.ERROR, false, Internal=false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("ResourceItemNotResolved", null, "CodeSmell", "Cannot resolve resource item", "Cannot resolve resource item.", JetBrains.ReSharper.Daemon.Severity.ERROR, false, Internal=false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("PropertyNotResolved", null, "CodeSmell", "Cannot resolve property", "Cannot resolve property.", JetBrains.ReSharper.Daemon.Severity.ERROR, false, Internal=false)]
[assembly: JetBrains.UI.Icons.CompiledIcons.CompiledIconsPackAttribute(IconNames=new string[] {
        "BaseCulture",
        "SpecificCulture",
        "Localization",
        "SpecificAndBaseCulture"}, IconPackResourceIdentification="JetBrains.ReSharper.I18n.Services;component/resources/Services118nIcons/ThemedIco" +
    "ns.Services118n.Generated.Xaml")]
[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]
[assembly: System.Windows.Markup.XmlnsDefinitionAttribute("urn:shemas-jetbrains-com:ui-application-icons-services118n", "JetBrains.ReSharper.I18n.Services.Resources")]

namespace JetBrains.ReSharper.Feature.Services.Resx.i18n
{
    
    public abstract class ResourceItemBase : JetBrains.ReSharper.Psi.Resx.IResourceItem
    {
        protected ResourceItemBase([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IPsiSourceFile psiSourceFile, [JetBrains.Annotations.NotNullAttribute()] string name, int offset, int formatArgs) { }
        public virtual JetBrains.ReSharper.Psi.IResourceItemDeclaredElement DeclaredElement { get; }
        public int FormatArgs { get; }
        public string Name { get; }
        public int Offset { get; }
        public JetBrains.ReSharper.Psi.IPsiSourceFile PsiSourceFile { get; }
        protected bool Equals(JetBrains.ReSharper.Psi.Resx.IResourceItem other) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
        public virtual JetBrains.DocumentModel.DocumentRange GetNameDocumentRange() { }
        public virtual bool IsValid() { }
        public override string ToString() { }
    }
}
namespace JetBrains.ReSharper.I18n.Services.Actions
{
    
    [JetBrains.ReSharper.Psi.ShellFeaturePartAttribute()]
    public class BaseResourceContextSearch : JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.BaseSearches.ContextSearchBase<JetBrains.ReSharper.I18n.Services.Actions.SearchResourceBaseRequest>, JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.IContextSearch, JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.IRequestContextSearch<JetBrains.ReSharper.I18n.Services.Actions.SearchResourceBaseRequest>, JetBrains.ReSharper.I18n.Services.Actions.IBaseResourceContextSearch
    {
        protected override JetBrains.ReSharper.Psi.Services.ReferencePreferenceKind ReferencePreferenceKind { get; }
        protected override JetBrains.ReSharper.I18n.Services.Actions.SearchResourceBaseRequest CreateSearchRequest(JetBrains.Application.DataContext.IDataContext dataContext, JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, JetBrains.ReSharper.Psi.IDeclaredElement initialTarget) { }
        protected override System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.DeclaredElementInstance> GetCandidateInstances(JetBrains.Application.DataContext.IDataContext context, JetBrains.ReSharper.Psi.Services.ReferencePreferenceKind kind) { }
        public override bool IsAvailable(JetBrains.Application.DataContext.IDataContext context) { }
        protected override bool IsAvailableInternal(JetBrains.Application.DataContext.IDataContext dataContext) { }
    }
    [JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextNavigationProviderAttribute()]
    public class GotoImplementationsResourceProvider : JetBrains.ReSharper.I18n.Services.Actions.ResourcesHierarchyProviderBase<JetBrains.ReSharper.I18n.Services.Actions.IImplementationsResourceContextSearch, JetBrains.ReSharper.Features.Finding.FindImplementations.SearchImplementationsDescriptor, JetBrains.ReSharper.I18n.Services.Actions.SearchResourceImplementationsRequest>, JetBrains.ReSharper.Feature.Services.ActionsMenu.IWorkflowProvider<JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextNavigation, JetBrains.ReSharper.Feature.Services.ContextNavigation.NavigationActionGroup>, JetBrains.ReSharper.Feature.Services.ContextNavigation.INavigateFromHereProvider, JetBrains.ReSharper.Features.Finding.FindHierarchy.IGotoImplementationsProvider
    {
        public GotoImplementationsResourceProvider(JetBrains.ReSharper.Feature.Services.IFeaturePartsContainer manager) { }
        protected override JetBrains.ReSharper.Features.Finding.FindImplementations.SearchImplementationsDescriptor CreateSearchDescriptor(JetBrains.ReSharper.I18n.Services.Actions.SearchResourceImplementationsRequest searchRequest, System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.Search.IOccurence> occurences) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextNavigation> CreateWorkflow(JetBrains.Application.DataContext.IDataContext dataContext) { }
    }
    [JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextNavigationProviderAttribute()]
    public class GotoInheritorsResourceProvider : JetBrains.ReSharper.I18n.Services.Actions.ResourcesHierarchyProviderBase<JetBrains.ReSharper.I18n.Services.Actions.IInheritorsResourceContextSearch, JetBrains.ReSharper.Features.Finding.FindHierarchy.SearchInheritorsDescriptor, JetBrains.ReSharper.I18n.Services.Actions.SearchResourceInheritorsRequest>, JetBrains.ReSharper.Feature.Services.ActionsMenu.IWorkflowProvider<JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextNavigation, JetBrains.ReSharper.Feature.Services.ContextNavigation.NavigationActionGroup>, JetBrains.ReSharper.Feature.Services.ContextNavigation.INavigateFromHereProvider, JetBrains.ReSharper.Features.Finding.FindHierarchy.IGotoInheritorsProvider
    {
        public GotoInheritorsResourceProvider(JetBrains.ReSharper.Feature.Services.IFeaturePartsContainer manager) { }
        protected override JetBrains.ReSharper.Features.Finding.FindHierarchy.SearchInheritorsDescriptor CreateSearchDescriptor(JetBrains.ReSharper.I18n.Services.Actions.SearchResourceInheritorsRequest searchRequest, System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.Search.IOccurence> occurences) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextNavigation> CreateWorkflow(JetBrains.Application.DataContext.IDataContext dataContext) { }
    }
    public interface IBaseResourceContextSearch : JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.IContextSearch, JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.IRequestContextSearch<JetBrains.ReSharper.I18n.Services.Actions.SearchResourceBaseRequest> { }
    public interface IImplementationsResourceContextSearch : JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.IContextSearch, JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.IRequestContextSearch<JetBrains.ReSharper.I18n.Services.Actions.SearchResourceImplementationsRequest> { }
    public interface IInheritorsResourceContextSearch : JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.IContextSearch, JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.IRequestContextSearch<JetBrains.ReSharper.I18n.Services.Actions.SearchResourceInheritorsRequest> { }
    [JetBrains.ReSharper.Psi.ShellFeaturePartAttribute()]
    public class ImplementationsResourceContextSearch : JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.BaseSearches.ContextSearchBase<JetBrains.ReSharper.I18n.Services.Actions.SearchResourceImplementationsRequest>, JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.IContextSearch, JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.IRequestContextSearch<JetBrains.ReSharper.I18n.Services.Actions.SearchResourceImplementationsRequest>, JetBrains.ReSharper.I18n.Services.Actions.IImplementationsResourceContextSearch
    {
        protected override JetBrains.ReSharper.Psi.Services.ReferencePreferenceKind ReferencePreferenceKind { get; }
        protected override JetBrains.ReSharper.I18n.Services.Actions.SearchResourceImplementationsRequest CreateSearchRequest(JetBrains.Application.DataContext.IDataContext dataContext, JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, JetBrains.ReSharper.Psi.IDeclaredElement initialTarget) { }
        protected override System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.DeclaredElementInstance> GetCandidateInstances(JetBrains.Application.DataContext.IDataContext context, JetBrains.ReSharper.Psi.Services.ReferencePreferenceKind kind) { }
        public override bool IsAvailable(JetBrains.Application.DataContext.IDataContext context) { }
        protected override bool IsAvailableInternal(JetBrains.Application.DataContext.IDataContext dataContext) { }
    }
    [JetBrains.ReSharper.Psi.ShellFeaturePartAttribute()]
    public class InheritorsResourceContextSearch : JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.BaseSearches.ContextSearchBase<JetBrains.ReSharper.I18n.Services.Actions.SearchResourceInheritorsRequest>, JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.IContextSearch, JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.IRequestContextSearch<JetBrains.ReSharper.I18n.Services.Actions.SearchResourceInheritorsRequest>, JetBrains.ReSharper.I18n.Services.Actions.IInheritorsResourceContextSearch
    {
        protected override JetBrains.ReSharper.Psi.Services.ReferencePreferenceKind ReferencePreferenceKind { get; }
        protected override JetBrains.ReSharper.I18n.Services.Actions.SearchResourceInheritorsRequest CreateSearchRequest(JetBrains.Application.DataContext.IDataContext dataContext, JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, JetBrains.ReSharper.Psi.IDeclaredElement initialTarget) { }
        protected override System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.DeclaredElementInstance> GetCandidateInstances(JetBrains.Application.DataContext.IDataContext context, JetBrains.ReSharper.Psi.Services.ReferencePreferenceKind kind) { }
        public override bool IsAvailable(JetBrains.Application.DataContext.IDataContext context) { }
        protected override bool IsAvailableInternal(JetBrains.Application.DataContext.IDataContext dataContext) { }
    }
    public abstract class ResourcesHierarchyProviderBase<TContextSearch, TDescriptor, TSearchRequest> : JetBrains.ReSharper.Features.Finding.NavigateFromHere.RequestContextSearchProvider<TContextSearch, TDescriptor, TSearchRequest>
        where TContextSearch :  class, JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.IRequestContextSearch<>
        where TDescriptor : JetBrains.ReSharper.Features.Finding.Search.SearchDescriptor
        where TSearchRequest : JetBrains.ReSharper.Feature.Services.Search.SearchRequests.SearchRequest
    {
        protected ResourcesHierarchyProviderBase(JetBrains.ReSharper.Feature.Services.IFeaturePartsContainer manager) { }
        protected override System.Nullable<JetBrains.ReSharper.Feature.Services.Occurences.OccurencePresentationOptions> ProvideFeatureSpecificPresentationOptions() { }
        protected override void ShowResults(JetBrains.Application.DataContext.IDataContext context, JetBrains.ReSharper.Features.Common.Occurences.ExecutionHosting.INavigationExecutionHost host, string title, System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.Search.IOccurence> occurences, System.Func<TDescriptor> descriptorBuilder, System.Collections.Generic.IComparer<JetBrains.ReSharper.Feature.Services.Search.IOccurence> customSearchRequestComparer) { }
    }
    public class SearchResourceBaseRequest : JetBrains.ReSharper.Feature.Services.Search.SearchRequests.SearchBasesRequest
    {
        public SearchResourceBaseRequest(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public override System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.Search.IOccurence> Search(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
    }
    public class SearchResourceImplementationsRequest : JetBrains.ReSharper.Feature.Services.Search.SearchRequests.SearchImplementationsRequest
    {
        public SearchResourceImplementationsRequest(JetBrains.ReSharper.Psi.IDeclaredElement element, JetBrains.ReSharper.Psi.Search.ISearchDomain searchDomain) { }
        public override System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.Search.IOccurence> Search(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
    }
    public class SearchResourceInheritorsRequest : JetBrains.ReSharper.Feature.Services.Search.SearchRequests.SearchInheritorsRequest
    {
        public SearchResourceInheritorsRequest(JetBrains.ReSharper.Psi.IDeclaredElement element, JetBrains.ReSharper.Psi.Search.ISearchDomain searchDomain) { }
        public override System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.Search.IOccurence> Search(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
    }
}
namespace JetBrains.ReSharper.I18n.Services
{
    
    public class static AttributeInstanceExtensions
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static T ChangeAttributeParameters<T>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.IAttributeInstance instance, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IEnumerable<string> oldParameters, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IEnumerable<JetBrains.Util.Pair<string, JetBrains.ReSharper.Psi.AttributeValue>> newParameters, [JetBrains.Annotations.NotNullAttribute()] System.Func<JetBrains.ReSharper.Psi.ITypeElement, JetBrains.ReSharper.Psi.AttributeValue[], JetBrains.Util.Pair<, >[], T> factory, System.StringComparison comparison)
            where T : JetBrains.ReSharper.Psi.Tree.ITreeNode { }
    }
    public abstract class CustomToolService
    {
        public abstract bool RunCustomTool([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IPsiSourceFile psiSourceFile);
    }
    public class static ElementFactory
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.Tree.IExpression CreateByValue([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Tree.ITreeNode element, [JetBrains.Annotations.NotNullAttribute()] object value) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.Tree.IExpression CreateByValue([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.ConstantValue value) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.Tree.IExpression CreateByValue([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.IClrDeclaredElement element, [JetBrains.Annotations.NotNullAttribute()] object value) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.Tree.IExpression CreateByValue([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.IClrDeclaredElement element, JetBrains.ReSharper.Psi.ConstantValue value) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.Tree.IExpression CreateExpression([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Tree.ITreeNode element, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.Tree.IExpression CreateExpression([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Tree.ITreeNode element, [JetBrains.Annotations.NotNullAttribute()] [System.ComponentModel.LocalizableAttribute(false)] string format, [JetBrains.Annotations.CanBeNullAttribute()] params object[] args) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.Tree.IExpression CreateExpression([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.IClrDeclaredElement element, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.Tree.IExpression CreateExpression([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.IClrDeclaredElement element, [JetBrains.Annotations.NotNullAttribute()] [System.ComponentModel.LocalizableAttribute(false)] string format, [JetBrains.Annotations.CanBeNullAttribute()] params object[] args) { }
    }
    public abstract class ElementFactoryService
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        public abstract object CreateAttribute([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Modules.IPsiModule module, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.ITypeElement attributeType, [JetBrains.Annotations.CanBeNullAttribute()] params JetBrains.ReSharper.Psi.AttributeValue[] values);
        public abstract JetBrains.ReSharper.Psi.Tree.IExpression CreateByValue(JetBrains.ReSharper.Psi.ConstantValue value);
        [JetBrains.Annotations.CanBeNullAttribute()]
        public virtual JetBrains.ReSharper.Psi.Tree.IExpression CreateExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Modules.IPsiModule module, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public abstract JetBrains.ReSharper.Psi.Tree.IExpression CreateExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Modules.IPsiModule module, [JetBrains.Annotations.NotNullAttribute()] [System.ComponentModel.LocalizableAttribute(false)] string format, [JetBrains.Annotations.CanBeNullAttribute()] params object[] args);
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.I18n.Services.ElementFactoryService Get([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.I18n.Services.ElementFactoryService Get([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.PsiLanguageType language) { }
    }
    public interface ILocalizableManager
    {
        JetBrains.ReSharper.I18n.Services.Localizable IsLocalizable([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.IExpression expression);
    }
    public enum Localizable
    {
        Default = 0,
        Yes = 1,
        No = 2,
    }
    public enum LocalizableInspector
    {
        Optimistic = 0,
        Pessimistic = 1,
    }
    public class static LocalizableInspectorProperty
    {
        public static JetBrains.ReSharper.I18n.Services.LocalizableInspector GetLocalizableInspectorProperty(this JetBrains.ProjectModel.IProject project, JetBrains.Application.Settings.ISettingsStore settingsStore) { }
        public static JetBrains.ReSharper.I18n.Services.LocalizableInspector GetLocalizableInspectorProperty(JetBrains.Application.Settings.IContextBoundSettingsStore settingsStore) { }
        public static void SetLocalizableInspectorProperty(this JetBrains.ProjectModel.IProject project, JetBrains.ReSharper.I18n.Services.LocalizableInspector value) { }
    }
    public class static LocalizableProperty
    {
        public static JetBrains.ReSharper.I18n.Services.Localizable GetLocalizableProperty(this JetBrains.ProjectModel.IProject project, JetBrains.Application.Settings.ISettingsStore settingsStore) { }
        public static JetBrains.ReSharper.I18n.Services.Localizable GetLocalizableProperty(JetBrains.Application.Settings.IContextBoundSettingsStore settingsStore) { }
        public static void SetLocalizableProperty(this JetBrains.ProjectModel.IProject project, JetBrains.ReSharper.I18n.Services.Localizable value) { }
    }
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(JetBrains.ReSharper.Settings.CodeEditingSettings), "Localization project settings", KeyNameOverride="Localization")]
    public class LocalizationProjectSettings
    {
        [JetBrains.Application.Settings.SettingsEntryAttribute(null, "Last resource file")]
        public string LastResourceFile;
        [JetBrains.Application.Settings.SettingsEntryAttribute(JetBrains.ReSharper.I18n.Services.Localizable.Default, "Localizable inspector switch")]
        public JetBrains.ReSharper.I18n.Services.Localizable Localizable;
        [JetBrains.Application.Settings.SettingsEntryAttribute(JetBrains.ReSharper.I18n.Services.LocalizableInspector.Optimistic, "Localizable inspector strategy")]
        public JetBrains.ReSharper.I18n.Services.LocalizableInspector LocalizableInspector;
    }
    [JetBrains.ProjectModel.Settings.Upgrade.ProjectSettingsUpgraderAttribute()]
    public class LocalizationProjectSettingsUpgrader : JetBrains.Application.Configuration.IXmlReadable, JetBrains.Application.Configuration.Upgrade.ISettingsUpgrader, JetBrains.ProjectModel.Settings.Upgrade.IProjectSettingsUpgrader
    {
        public LocalizationProjectSettingsUpgrader(JetBrains.ProjectModel.IProject project, JetBrains.Application.Settings.ISettingsStore settingsStore) { }
    }
    public class static ProjectUtil
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ProjectModel.IProjectFile AddExistenFile([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ProjectModel.IProject project, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath filePath, JetBrains.ProjectModel.IProjectModelTransactionCookie cookie) { }
    }
    public abstract class PsiService
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public abstract JetBrains.ReSharper.Psi.PsiLanguageType LanguageType { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public abstract JetBrains.ReSharper.Psi.Tree.IArgument GetArgumentByValue([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Tree.IExpression expression);
        [JetBrains.Annotations.CanBeNullAttribute()]
        public abstract JetBrains.ReSharper.Psi.Tree.IExpression GetArgumentValue([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Tree.IArgument argument);
        [JetBrains.Annotations.CanBeNullAttribute()]
        public abstract JetBrains.ReSharper.Psi.Tree.IExpression GetAssignmentTarget([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Tree.IExpression source);
        [JetBrains.Annotations.CanBeNullAttribute()]
        public abstract JetBrains.ReSharper.Psi.Tree.IExpression GetContainingParenthesizedExpression([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Tree.IExpression expression);
        public abstract JetBrains.ReSharper.Psi.Tree.ITreeNode GetEndRegion(JetBrains.ReSharper.Psi.Tree.ITreeNode element);
        [JetBrains.Annotations.NotNullAttribute()]
        public abstract JetBrains.ReSharper.Psi.IType GetExpressionCompileType([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.IExpression expression);
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.I18n.Services.PsiService GetInstance([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.PsiLanguageType psiLanguageType) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.I18n.Services.PsiService GetInstance([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public abstract JetBrains.ReSharper.Psi.IInvocationInfo GetInvocationInfoByArgument([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.IArgument argument);
        [JetBrains.Annotations.CanBeNullAttribute()]
        public abstract JetBrains.ReSharper.Psi.Resolve.IReference GetInvokedReference([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IInvocationInfo invocationInfo);
        [JetBrains.Annotations.CanBeNullAttribute()]
        public abstract JetBrains.ReSharper.Psi.Tree.IExpression GetOperandThroughParenthesis([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Tree.IExpression expression);
        [JetBrains.Annotations.CanBeNullAttribute()]
        public abstract JetBrains.ReSharper.Psi.Resolve.IReference GetReferenceFromExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.IExpression expression);
        public abstract string GetRegionName(JetBrains.ReSharper.Psi.Tree.ITreeNode element);
        public abstract void SetAttribute([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.IDeclaration declaration, [JetBrains.Annotations.NotNullAttribute()] object attribute);
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.I18n.Services.PsiService TryGetInstance([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.PsiLanguageType psiLanguageType) { }
    }
    public class static ResourceAccessibleUtil
    {
        public static bool IsAccessible([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.I18n.Services.Searching.ResourceAccessorFinder finder, JetBrains.ReSharper.Psi.IPsiSourceFile resourceFile, JetBrains.ReSharper.Psi.Resolve.IAccessContext context) { }
        public class ResourceAccessContext : JetBrains.ReSharper.Psi.Resolve.IAccessContext
        {
            public ResourceAccessContext([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProject project) { }
            public JetBrains.ReSharper.Psi.ITypeElement GetAccessContainingTypeElement() { }
            public JetBrains.ReSharper.Psi.Modules.IPsiModule GetPsiModule() { }
            public JetBrains.ReSharper.Psi.Resolve.QualifierKind GetQualifierKind() { }
            public JetBrains.ReSharper.Psi.ITypeElement GetQualifierTypeElement() { }
            public JetBrains.ReSharper.Psi.Resolve.Staticness GetStaticness() { }
        }
    }
    public class static ResxFileUtil
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static string GetCultureName([JetBrains.Annotations.NotNullAttribute()] string fileName) { }
        public static string GetFullTypeName([JetBrains.Annotations.NotNullAttribute()] string fileName, JetBrains.ProjectModel.IProjectFileExtensions projectFileExtensions) { }
        public static string GetFullTypeName([JetBrains.Annotations.NotNullAttribute()] string fileName, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ProjectFileType projectFileType, JetBrains.ProjectModel.IProjectFileExtensions projectFileExtensions) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static string GetNamespace([JetBrains.Annotations.NotNullAttribute()] string fileName, JetBrains.ProjectModel.IProjectFileExtensions projectFileExtensions) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static string GetNamespace([JetBrains.Annotations.NotNullAttribute()] string fileName, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ProjectFileType projectFileType, JetBrains.ProjectModel.IProjectFileExtensions projectFileExtensions) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static string GetNamespace([JetBrains.Annotations.NotNullAttribute()] string fileName, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.PsiLanguageType psiLanguageType, JetBrains.ProjectModel.IProjectFileExtensions projectFileExtensions) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static string GetTypeName([JetBrains.Annotations.NotNullAttribute()] string fileName, JetBrains.ProjectModel.IProjectFileExtensions projectFileExtensions) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static string GetTypeName([JetBrains.Annotations.NotNullAttribute()] string fileName, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ProjectFileType projectFileType, JetBrains.ProjectModel.IProjectFileExtensions projectFileExtensions) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static string GetTypeName([JetBrains.Annotations.NotNullAttribute()] string fileName, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.PsiLanguageType psiLanguageType, JetBrains.ProjectModel.IProjectFileExtensions projectFileExtensions) { }
        public static bool IsDefaultCulture([JetBrains.Annotations.CanBeNullAttribute()] string fileName) { }
        public static bool IsValidResourceFileName([JetBrains.Annotations.NotNullAttribute()] string fileName) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static string VerifyMemberName([JetBrains.Annotations.NotNullAttribute()] string resourceName, JetBrains.ProjectModel.IProjectFileExtensions projectFileExtensions) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static string VerifyMemberName([JetBrains.Annotations.NotNullAttribute()] string resourceName, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ProjectFileType projectFileType, JetBrains.ProjectModel.IProjectFileExtensions projectFileExtensions) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static string VerifyMemberName([JetBrains.Annotations.NotNullAttribute()] string resourceName, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.PsiLanguageType languageType, JetBrains.ProjectModel.IProjectFileExtensions projectFileExtensions) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static string VerifyMemberName([JetBrains.Annotations.NotNullAttribute()] string resourceName, [JetBrains.Annotations.NotNullAttribute()] System.CodeDom.Compiler.CodeDomProvider codeDomProvider) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static string VerifyResourceFileName([JetBrains.Annotations.NotNullAttribute()] string fileName) { }
    }
    public class static RunCustomToolEx
    {
        public static bool RunCustomTool([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.IPsiSourceFile projectFile, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
        public static void RunCustomToolAsync([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.IPsiSourceFile projectFile, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Threading.IThreading invocator, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.I18n.Services.CustomToolService customToolService) { }
    }
    [JetBrains.ReSharper.Psi.PsiComponentAttribute()]
    public class SolutionResourceCache : JetBrains.ReSharper.Psi.Caches.ICache, JetBrains.ReSharper.Psi.Resx.ISolutionResourceCache
    {
        public SolutionResourceCache(JetBrains.Application.IShellLocks locks, JetBrains.ReSharper.Psi.Files.IPsiFiles psiFiles, JetBrains.ReSharper.Psi.IPsiConfiguration psiConfiguration, JetBrains.ReSharper.Psi.Caches.IPersistentIndexManager persistentIndexManager) { }
        public bool HasDirtyFiles { get; }
        public object SyncObject { get; }
        public bool ContainsItems(JetBrains.ReSharper.Psi.IPsiSourceFile psiSourceFile) { }
        public bool ContainsItems(JetBrains.ReSharper.Psi.IPsiSourceFile psiSourceFile, string name) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Resx.IResourceItem> EnumerateResourceItems(JetBrains.ReSharper.Psi.IPsiSourceFile psiSourceFile) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Resx.IResourceItem> EnumerateResourceItems(JetBrains.ReSharper.Psi.IPsiSourceFile psiSourceFile, string name) { }
        public System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<JetBrains.ReSharper.Psi.IPsiSourceFile, JetBrains.Util.DataStructures.CompactOneToListMap<string, JetBrains.ReSharper.Psi.Resx.IResourceItem>>> EnumerateResources(string resourceBaseName) { }
        public System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<JetBrains.ReSharper.Psi.IPsiSourceFile, JetBrains.Util.DataStructures.CompactOneToListMap<string, JetBrains.ReSharper.Psi.Resx.IResourceItem>>> EnumerateResources(JetBrains.ProjectModel.IProject project) { }
        public System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.IPsiSourceFile> GetAllResourceFiles() { }
        public System.Collections.Generic.ICollection<string> GetResourceItemNames(JetBrains.ReSharper.Psi.IPsiSourceFile psiSourceFile) { }
        public void OnDocumentChange(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.DocumentManagers.impl.ProjectFileDocumentCopyChange change) { }
        public bool TryGetMapItemsByHashValue(JetBrains.ReSharper.Psi.IPsiSourceFile psiSourceFile, out JetBrains.Util.DataStructures.CompactOneToListMap<, > itemsByHashValue) { }
        public bool TryGetMapItemsByName(JetBrains.ReSharper.Psi.IPsiSourceFile psiSourceFile, out JetBrains.Util.DataStructures.CompactOneToListMap<, > itemsByName) { }
        public bool UpToDate(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
    }
    public class static StringUtil
    {
        public static string TrimAllLines([JetBrains.Annotations.CanBeNullAttribute()] this string text) { }
        public static string TrimToLength([JetBrains.Annotations.CanBeNullAttribute()] this string text) { }
        public static string TrimToLength([JetBrains.Annotations.CanBeNullAttribute()] this string text, int length) { }
    }
}
namespace JetBrains.ReSharper.I18n.Services.CustomReferences
{
    
    public class ComponentPropertyReferenceFactory : JetBrains.ReSharper.I18n.Services.CustomReferences.ElementReferenceFactoryBase<JetBrains.ReSharper.Psi.Resx.Tree.IResxIdentifierAttribute>
    {
        public const string COMPONENT = "component";
        public const string PROPERTY = "property";
        public static readonly System.Text.RegularExpressions.Regex ResourceKeyParser;
        public override JetBrains.ReSharper.Psi.Resolve.IReference[] GetReferencesWithoutCache(JetBrains.ReSharper.Psi.Resx.Tree.IResxIdentifierAttribute element, JetBrains.ReSharper.Psi.Resolve.IReference[] oldReferences) { }
        public override bool HasReference(JetBrains.ReSharper.Psi.Resx.Tree.IResxIdentifierAttribute element, System.Collections.Generic.ICollection<string> names) { }
        public override bool UseOldReferences(JetBrains.ReSharper.Psi.Resx.Tree.IResxIdentifierAttribute element, JetBrains.ReSharper.Psi.Resolve.IReference[] oldReferences) { }
    }
    public abstract class ComponentReference<TOwner, TToken> : JetBrains.ReSharper.Psi.Resx.Impl.Tree.References.ReferenceWithTokenBase<TOwner, TToken>, JetBrains.ReSharper.Psi.Resolve.IQualifier
        where TOwner : JetBrains.ReSharper.Psi.Tree.ITreeNode
        where TToken :  class, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        protected ComponentReference(TOwner owner, TToken token, JetBrains.ReSharper.Psi.TreeTextRange withinRange) { }
        public bool Resolved { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        protected abstract JetBrains.ReSharper.Psi.IPsiSourceFile GetCodeFile();
        public JetBrains.ReSharper.Psi.Resolve.QualifierKind GetKind() { }
        public override JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetReferenceSymbolTable(bool useReferenceName) { }
        public override JetBrains.ReSharper.Psi.Resolve.ISymbolFilter[] GetSymbolFilters() { }
        public JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetSymbolTable(JetBrains.ReSharper.Psi.Resolve.SymbolTableMode mode) { }
        public override JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.ResolveResultWithInfo ResolveWithoutCache() { }
    }
    public abstract class ElementReferenceFactoryBase<TElement> : JetBrains.ReSharper.I18n.Services.CustomReferences.IElementReferenceFactory<TElement>, JetBrains.ReSharper.Psi.Resolve.IReferenceFactory
        where TElement :  class, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        protected static JetBrains.ReSharper.Psi.TreeTextRange GetRange(System.Text.RegularExpressions.Capture capture, JetBrains.Util.RangeTranslator translator) { }
        public virtual JetBrains.ReSharper.Psi.Resolve.IReference[] GetReferences(TElement element, JetBrains.ReSharper.Psi.Resolve.IReference[] oldReferences) { }
        public abstract JetBrains.ReSharper.Psi.Resolve.IReference[] GetReferencesWithoutCache(TElement element, JetBrains.ReSharper.Psi.Resolve.IReference[] oldReferences);
        public abstract bool HasReference([JetBrains.Annotations.NotNullAttribute()] TElement element, [JetBrains.Annotations.CanBeNullAttribute()] System.Collections.Generic.ICollection<string> names);
        protected static bool IsNotEmpty(System.Text.RegularExpressions.Group group) { }
        public abstract bool UseOldReferences([JetBrains.Annotations.NotNullAttribute()] TElement element, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Resolve.IReference[] oldReferences);
    }
    public class EnumMemberReferenceInsideTag : JetBrains.ReSharper.Psi.Resx.Impl.Tree.References.ReferenceInsideTagBase<JetBrains.ReSharper.Psi.Resx.Tree.IResxDataValueTag>
    {
        public EnumMemberReferenceInsideTag(JetBrains.ReSharper.Psi.Resx.Tree.IResxDataValueTag owner, JetBrains.ReSharper.Psi.TreeTextRange withinRange) { }
        protected override bool CaseSensitive { get; }
        public override JetBrains.ReSharper.Psi.Resolve.IReference BindTo(JetBrains.ReSharper.Psi.IDeclaredElement element, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
        public override JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetReferenceSymbolTable(bool useReferenceName) { }
        public override JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.ResolveResultWithInfo ResolveWithoutCache() { }
    }
    public interface IElementReferenceFactory<TElement> : JetBrains.ReSharper.Psi.Resolve.IReferenceFactory
        where TElement :  class, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Resolve.IReference[] GetReferences([JetBrains.Annotations.NotNullAttribute()] TElement element, JetBrains.ReSharper.Psi.Resolve.IReference[] oldReferences);
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Resolve.IReference[] GetReferencesWithoutCache([JetBrains.Annotations.NotNullAttribute()] TElement element, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Resolve.IReference[] oldReferences);
        bool HasReference(TElement element, System.Collections.Generic.ICollection<string> names);
        bool UseOldReferences(TElement element, JetBrains.ReSharper.Psi.Resolve.IReference[] oldReferences);
    }
    public class OneElementReferenceFactory<TElement> : JetBrains.ReSharper.I18n.Services.CustomReferences.ElementReferenceFactoryBase<TElement>
        where TElement :  class, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        public OneElementReferenceFactory([JetBrains.Annotations.CanBeNullAttribute()] params JetBrains.ReSharper.I18n.Services.CustomReferences.IElementReferenceFactory<>[] factories) { }
        public override JetBrains.ReSharper.Psi.Resolve.IReference[] GetReferencesWithoutCache(TElement element, JetBrains.ReSharper.Psi.Resolve.IReference[] oldReferences) { }
        public override bool HasReference(TElement element, System.Collections.Generic.ICollection<string> names) { }
        public override bool UseOldReferences(TElement element, JetBrains.ReSharper.Psi.Resolve.IReference[] oldReferences) { }
    }
    public abstract class ResourceReference<TOwner, TToken> : JetBrains.ReSharper.I18n.Services.CustomReferences.ResourceReferenceBase<TOwner, TToken>
        where TOwner :  class, JetBrains.ReSharper.Psi.Tree.IArgument
        where TToken :  class, JetBrains.ReSharper.Psi.Tree.IExpression
    {
        protected ResourceReference(JetBrains.ReSharper.Psi.TreeTextRange withinRange, [JetBrains.Annotations.NotNullAttribute()] TOwner owner, TToken token) { }
        public override bool CaseSensitive { get; }
        protected override JetBrains.ReSharper.Psi.Resolve.IReference BindToInternal(JetBrains.ReSharper.Psi.IDeclaredElement element, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
        [JetBrains.Annotations.NotNullAttribute()]
        protected virtual System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.IPsiSourceFile> FindResourceFileFromDeclaredElement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
        protected override string GetElementText() { }
        public override JetBrains.ReSharper.Psi.TreeTextRange GetTreeTextRange() { }
    }
    public abstract class ResourceReferenceBase<TOwner, TToken> : JetBrains.ReSharper.Psi.Resx.Impl.Tree.References.ReferenceWithTokenBase<TOwner, TToken>, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.ICheckedReference, JetBrains.ReSharper.Psi.Resolve.ICompleteableReference, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.ReSharper.Psi.Resx.Tree.IResourceItemReference, JetBrains.ReSharper.Psi.Resx.Tree.IResourceReference, JetBrains.Util.IUserDataHolder
        where TOwner : JetBrains.ReSharper.Psi.Tree.ITreeNode
        where TToken :  class, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        protected ResourceReferenceBase(JetBrains.ReSharper.Psi.TreeTextRange withinRange, [JetBrains.Annotations.NotNullAttribute()] TOwner owner, TToken token) { }
        public abstract System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.IPsiSourceFile> FindResourceFiles();
        public string GetDefaultName() { }
        public override JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetReferenceSymbolTable(bool useReferenceName) { }
        public override JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.ResolveResultWithInfo ResolveWithoutCache() { }
    }
    public class ResxComponentNameReferenceFactory : JetBrains.ReSharper.I18n.Services.CustomReferences.ElementReferenceFactoryBase<JetBrains.ReSharper.Psi.Resx.Tree.IResxDataValueTag>
    {
        public override JetBrains.ReSharper.Psi.Resolve.IReference[] GetReferencesWithoutCache(JetBrains.ReSharper.Psi.Resx.Tree.IResxDataValueTag element, JetBrains.ReSharper.Psi.Resolve.IReference[] oldReferences) { }
        public override bool HasReference(JetBrains.ReSharper.Psi.Resx.Tree.IResxDataValueTag element, System.Collections.Generic.ICollection<string> names) { }
        public override bool UseOldReferences(JetBrains.ReSharper.Psi.Resx.Tree.IResxDataValueTag element, JetBrains.ReSharper.Psi.Resolve.IReference[] oldReferences) { }
    }
    public class ResxComponentPropertyReference : JetBrains.ReSharper.Psi.Resx.Impl.Tree.References.QualifiableReferenceWithTokenBase<JetBrains.ReSharper.Psi.Resx.Tree.IResxIdentifierAttribute, JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken>
    {
        public ResxComponentPropertyReference(JetBrains.ReSharper.Psi.Resx.Tree.IResxIdentifierAttribute owner, JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken token, JetBrains.ReSharper.Psi.TreeTextRange withinRange) { }
        public ResxComponentPropertyReference(JetBrains.ReSharper.Psi.Resx.Tree.IResxIdentifierAttribute owner, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Resolve.IQualifier quilifier, JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken token, JetBrains.ReSharper.Psi.TreeTextRange withinRange) { }
        protected override JetBrains.ReSharper.Psi.Resolve.IReference BindToInternal(JetBrains.ReSharper.Psi.IDeclaredElement element, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
        protected override string GetElementText() { }
        public override JetBrains.ReSharper.Psi.ITypeElement GetQualifierTypeElement() { }
        public override JetBrains.ReSharper.Psi.Resolve.Staticness GetStaticness() { }
        public override JetBrains.ReSharper.Psi.Resolve.ISymbolFilter[] GetSymbolFilters() { }
        public override JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.ResolveResultWithInfo Resolve(JetBrains.ReSharper.Psi.Resolve.ISymbolTable symbolTable, JetBrains.ReSharper.Psi.Resolve.IAccessContext context) { }
    }
    public class ResxComponentReference : JetBrains.ReSharper.I18n.Services.CustomReferences.ComponentReference<JetBrains.ReSharper.Psi.Resx.Tree.IResxIdentifierAttribute, JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken>
    {
        public ResxComponentReference(JetBrains.ReSharper.Psi.Resx.Tree.IResxIdentifierAttribute owner, JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken token, JetBrains.ReSharper.Psi.TreeTextRange withinRange) { }
        public override bool CaseSensitive { get; }
        protected override JetBrains.ReSharper.Psi.Resolve.IReference BindToInternal(JetBrains.ReSharper.Psi.IDeclaredElement element, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
        protected override JetBrains.ReSharper.Psi.IPsiSourceFile GetCodeFile() { }
        protected override string GetElementText() { }
        public override string ToString() { }
    }
    public class ResxComponentReferenceInsideTag : JetBrains.ReSharper.Psi.Resx.Impl.Tree.References.ReferenceInsideTagBase<JetBrains.ReSharper.Psi.Resx.Tree.IResxDataValueTag>
    {
        public ResxComponentReferenceInsideTag(JetBrains.ReSharper.Psi.Resx.Tree.IResxDataValueTag owner, JetBrains.ReSharper.Psi.TreeTextRange withinRange) { }
        public override JetBrains.ReSharper.Psi.Resolve.IReference BindTo(JetBrains.ReSharper.Psi.IDeclaredElement element, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
        public override JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetReferenceSymbolTable(bool useReferenceName) { }
        public override JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.ResolveResultWithInfo ResolveWithoutCache() { }
        public override string ToString() { }
    }
    public class ResxEnumMemberReferenceFactory : JetBrains.ReSharper.I18n.Services.CustomReferences.ElementReferenceFactoryBase<JetBrains.ReSharper.Psi.Resx.Tree.IResxDataValueTag>
    {
        public override JetBrains.ReSharper.Psi.Resolve.IReference[] GetReferencesWithoutCache(JetBrains.ReSharper.Psi.Resx.Tree.IResxDataValueTag element, JetBrains.ReSharper.Psi.Resolve.IReference[] oldReferences) { }
        public override bool HasReference(JetBrains.ReSharper.Psi.Resx.Tree.IResxDataValueTag element, System.Collections.Generic.ICollection<string> names) { }
        public override bool UseOldReferences(JetBrains.ReSharper.Psi.Resx.Tree.IResxDataValueTag element, JetBrains.ReSharper.Psi.Resolve.IReference[] oldReferences) { }
    }
    public abstract class StringArgumentReferenceFactoryBase<TArgument, TArgumentValue> : JetBrains.ReSharper.I18n.Services.CustomReferences.ElementReferenceFactoryBase<TArgument>
        where TArgument :  class, JetBrains.ReSharper.Psi.Tree.IArgument
        where TArgumentValue :  class, JetBrains.ReSharper.Psi.Tree.IExpression
    {
        protected StringArgumentReferenceFactoryBase(JetBrains.ReSharper.Psi.PsiLanguageType psiLanguageType) { }
        [JetBrains.Annotations.NotNullAttribute()]
        protected abstract JetBrains.ReSharper.Psi.Resolve.IReference[] CreateArgumentReferences([JetBrains.Annotations.NotNullAttribute()] TArgument argument, [JetBrains.Annotations.NotNullAttribute()] TArgumentValue argumentValue, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IInvocationInfo invocation);
        protected JetBrains.ReSharper.Psi.ConstantValue GetArgumentConstantValue([JetBrains.Annotations.NotNullAttribute()] TArgument argument) { }
        [JetBrains.Annotations.NotNullAttribute()]
        protected virtual System.Collections.Generic.IEnumerable<string> GetNamesFromArgumentValue(TArgument argument) { }
        protected static JetBrains.ReSharper.Psi.TreeTextRange GetReferenceRange([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public virtual JetBrains.ReSharper.Psi.Resolve.IReference[] GetReferencesWithoutCache(TArgument argument, JetBrains.ReSharper.Psi.Resolve.IReference[] oldReferences) { }
        public override bool HasReference(TArgument argument, System.Collections.Generic.ICollection<string> names) { }
        protected abstract bool OnMethodCandidate([JetBrains.Annotations.NotNullAttribute()] string methodName);
        protected abstract bool OnParameterCandidate([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IInvocationInfo invocationInfo, [JetBrains.Annotations.NotNullAttribute()] TArgument argument);
        protected abstract bool OnTypeCandidate([JetBrains.Annotations.NotNullAttribute()] string typeName);
        public virtual bool UseOldReferences(TArgument argument, JetBrains.ReSharper.Psi.Resolve.IReference[] oldReferences) { }
        protected virtual bool UseOldReferences([JetBrains.Annotations.NotNullAttribute()] TArgument argument, [JetBrains.Annotations.NotNullAttribute()] TArgumentValue argumentValue, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Resolve.IReference[] oldReferences) { }
    }
}
namespace JetBrains.ReSharper.I18n.Services.Daemon
{
    
    public abstract class DaemonStageBase<TPsiFile> : JetBrains.ReSharper.Daemon.IDaemonStage
        where TPsiFile :  class, JetBrains.ReSharper.Psi.Tree.IFile
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        protected abstract JetBrains.ReSharper.Daemon.IDaemonStageProcess CreateDaemonProcess([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Daemon.IDaemonProcess process, JetBrains.ReSharper.Daemon.DaemonProcessKind processKind, [JetBrains.Annotations.NotNullAttribute()] TPsiFile file, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.IContextBoundSettingsStore settingsStore);
        public virtual System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Daemon.IDaemonStageProcess> CreateProcess(JetBrains.ReSharper.Daemon.IDaemonProcess process, JetBrains.Application.Settings.IContextBoundSettingsStore settings, JetBrains.ReSharper.Daemon.DaemonProcessKind processKind) { }
        [JetBrains.Annotations.NotNullAttribute()]
        protected abstract System.Collections.Generic.IEnumerable<TPsiFile> GetPsiFiles([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile);
        public virtual JetBrains.ReSharper.Daemon.ErrorStripeRequest NeedsErrorStripe(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.Application.Settings.IContextBoundSettingsStore settings) { }
    }
    public abstract class DaemonStageProcessBase<TPsiFile> : JetBrains.ReSharper.Daemon.IDaemonStageProcess, JetBrains.ReSharper.Psi.IRecursiveElementProcessor
        where TPsiFile :  class, JetBrains.ReSharper.Psi.Tree.IFile
    {
        protected readonly TPsiFile myFile;
        protected readonly JetBrains.ReSharper.Daemon.Stages.DefaultHighlightingConsumer myHighlightingConsumer;
        protected readonly JetBrains.ReSharper.Daemon.IDaemonProcess myProcess;
        protected DaemonStageProcessBase([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Daemon.IDaemonProcess process, [JetBrains.Annotations.NotNullAttribute()] TPsiFile file, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.IContextBoundSettingsStore settingsStore) { }
        public JetBrains.ReSharper.Daemon.IDaemonProcess DaemonProcess { get; }
        public virtual bool ProcessingIsFinished { get; }
        protected void AddHighlightingInfo([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Daemon.HighlightingBase highlighting) { }
        protected void AddHighlightingInfo(JetBrains.DocumentModel.DocumentRange range, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Daemon.IHighlighting highlighting) { }
        public virtual void Execute(System.Action<JetBrains.ReSharper.Daemon.DaemonStageResult> committer) { }
        public virtual bool InteriorShouldBeProcessed(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public virtual void ProcessAfterInterior(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public virtual void ProcessBeforeInterior(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("ResourceItemNotResolved", "CSHARP,VBASIC,ASPX", AttributeId="ReSharper Error Highlighting", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.WARNING, ToolTipFormatString="Ambiguous resource item:{0}{1}match")]
    public class MultipleResourceItemCandidatesWarning : JetBrains.ReSharper.Daemon.HighlightingBase, JetBrains.ReSharper.Daemon.IHighlighting, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "ResourceItemNotResolved";
        protected const string MESSAGE = "Ambiguous resource item:{0}{1}match";
        public MultipleResourceItemCandidatesWarning(string string1, JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.Resolve.IReference Reference { get; }
        public string String1 { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("PropertyNotResolved", "CSHARP,VBASIC,ASPX", AttributeId="ReSharper Error Highlighting", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.WARNING, ToolTipFormatString="Cannot resolve property \'{0}\'")]
    public class PropertyNotResolvedWarning : JetBrains.ReSharper.Daemon.HighlightingBase, JetBrains.ReSharper.Daemon.IHighlighting, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "PropertyNotResolved";
        protected const string MESSAGE = "Cannot resolve property \'{0}\'";
        public PropertyNotResolvedWarning(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.Resolve.IReference Reference { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("PropertyNotResolved", "CSHARP,VBASIC,ASPX", AttributeId="ReSharper Error Highlighting", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.WARNING, ToolTipFormatString="Cannot resolve public property \'{0}\'")]
    public class PublicPropertyNotResolvedWarning : JetBrains.ReSharper.Daemon.HighlightingBase, JetBrains.ReSharper.Daemon.IHighlighting, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "PropertyNotResolved";
        protected const string MESSAGE = "Cannot resolve public property \'{0}\'";
        public PublicPropertyNotResolvedWarning(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.Resolve.IReference Reference { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("ResourceItemNotResolved", "CSHARP,VBASIC,ASPX", AttributeId="ReSharper Error Highlighting", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.WARNING, ToolTipFormatString="Cannot resolve resource item \'{0}\'")]
    public class ResourceItemNotResolvedWarning : JetBrains.ReSharper.Daemon.HighlightingBase, JetBrains.ReSharper.Daemon.IHighlighting, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "ResourceItemNotResolved";
        protected const string MESSAGE = "Cannot resolve resource item \'{0}\'";
        public ResourceItemNotResolvedWarning(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.Resolve.IReference Reference { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("ResourceNotResolved", "CSHARP,VBASIC,ASPX", AttributeId="ReSharper Error Highlighting", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.WARNING, ToolTipFormatString="Cannot resolve resource \'{0}\'")]
    public class ResourceNotResolvedWarning : JetBrains.ReSharper.Daemon.HighlightingBase, JetBrains.ReSharper.Daemon.IHighlighting, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "ResourceNotResolved";
        protected const string MESSAGE = "Cannot resolve resource \'{0}\'";
        public ResourceNotResolvedWarning(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.Resolve.IReference Reference { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
}
namespace JetBrains.ReSharper.I18n.Services.Impl
{
    
    public class static ProjectFileTypeServicesEx
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static T GetService<T>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.IPsiSourceFile resourceFile)
            where T :  class { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static T GetService<T>([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ISolution solution, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ProjectFileType projectFileType)
            where T :  class { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static T TryGetService<T>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.IPsiSourceFile resourceFile)
            where T :  class { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static T TryGetService<T>([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ISolution solution, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ProjectFileType projectFileType)
            where T :  class { }
    }
    public abstract class ResxResourceModificationServiceBase : JetBrains.ReSharper.I18n.Services.Services.IResourceModificationService
    {
        public virtual void AddResourceItem(JetBrains.ReSharper.Psi.IPsiSourceFile resourceFile, string name, string value, string comment, JetBrains.ReSharper.Psi.IType type) { }
        public void ChangeResourceItem(JetBrains.ReSharper.Psi.Resx.IResourceItem resourceItem, string newValue, string newComment) { }
        public void ChangeResourceItemName(JetBrains.ReSharper.Psi.IPsiSourceFile resourceFile, string oldName, string newName) { }
        public void CopyResourceItem(JetBrains.ReSharper.Psi.Resx.IResourceItem resourceItem, JetBrains.ReSharper.Psi.IPsiSourceFile targetResourceFile, string newName) { }
        public void DeleteResourceItem(JetBrains.ReSharper.Psi.Resx.IResourceItem resourceItem) { }
        public void DeleteResourceItem(JetBrains.ReSharper.Psi.IPsiSourceFile resourceFile, string name) { }
        public void MoveResourceItem(JetBrains.ReSharper.Psi.Resx.IResourceItem resourceItem, JetBrains.ReSharper.Psi.IPsiSourceFile targetResourceFile, string newName) { }
    }
}
namespace JetBrains.ReSharper.I18n.Services.Navigation
{
    
    public interface IResouceItemNavigationProvider : JetBrains.ReSharper.Feature.Services.Navigation.Navigation.INavigationProvider<JetBrains.ReSharper.I18n.Services.Navigation.ResourceItemOccurence> { }
    [JetBrains.ReSharper.Psi.SolutionFeaturePartAttribute()]
    public class ResouceItemOccurenceNavigationProvider : JetBrains.ReSharper.Feature.Services.Navigation.Navigation.INavigationProvider<JetBrains.ReSharper.I18n.Services.Navigation.ResourceItemOccurence>, JetBrains.ReSharper.I18n.Services.Navigation.IResouceItemNavigationProvider
    {
        public ResouceItemOccurenceNavigationProvider(JetBrains.ReSharper.ExternalSources.ReSharperIntegration.FileSystemPathNavigator navigator, JetBrains.ProjectModel.ProjectFileExtensions extensions, JetBrains.ReSharper.Psi.PsiProjectFileTypeCoordinator fileTypeCoordinator, JetBrains.IDE.EditorManager editorManager) { }
        public virtual System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Navigation.Navigation.INavigationPoint> CreateNavigationPoints(JetBrains.ReSharper.I18n.Services.Navigation.ResourceItemOccurence target) { }
        public virtual bool IsApplicable(JetBrains.ReSharper.I18n.Services.Navigation.ResourceItemOccurence data) { }
    }
    [JetBrains.ReSharper.Psi.ShellFeaturePartAttribute()]
    public class ResourceItemDeclarationSearch : JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.BaseSearches.DefaultDeclarationSearch
    {
        protected override JetBrains.ReSharper.Feature.Services.Search.SearchRequests.SearchDeclarationsRequest CreateSearchRequest(JetBrains.Application.DataContext.IDataContext dataContext, JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, JetBrains.ReSharper.Psi.IDeclaredElement initialTarget) { }
        public override JetBrains.ReSharper.Feature.Services.Search.SearchRequests.SearchDeclarationsRequest GetDeclarationSearchRequest(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
        public override JetBrains.Util.JetTuple<System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IDeclaredElement>, JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.GetSearchRequest<JetBrains.ReSharper.Feature.Services.Search.SearchRequests.SearchDeclarationsRequest>> GetElementsAndSearchRequest(JetBrains.Application.DataContext.IDataContext dataContext) { }
        protected override bool IsAvailableInternal(JetBrains.Application.DataContext.IDataContext dataContext) { }
        public override bool IsContextApplicable(JetBrains.Application.DataContext.IDataContext dataContext) { }
        public override bool IsGotoDeclarationApplicable(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
    }
    public class ResourceItemDeclarationsSearchRequest : JetBrains.ReSharper.Feature.Services.Search.SearchRequests.SearchDeclarationsRequest
    {
        public ResourceItemDeclarationsSearchRequest(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
        public override System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.Search.IOccurence> Search(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
    }
    public class ResourceItemOccurence : JetBrains.ReSharper.Feature.Services.Search.IOccurence
    {
        public ResourceItemOccurence([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Resx.IResourceItem resourceItem) { }
        public bool IsValid { get; }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.Search.IOccurence> MergedItems { get; }
        public object MergeKey { get; }
        public string Name { get; }
        public JetBrains.ReSharper.Psi.DeclaredElementEnvoy<JetBrains.ReSharper.Psi.INamespace> Namespace { get; }
        public JetBrains.ReSharper.Feature.Services.Search.OccurenceType OccurenceType { get; }
        public JetBrains.ReSharper.Feature.Services.Occurences.OccurencePresentationOptions PresentationOptions { get; set; }
        public JetBrains.ProjectModel.ProjectModelElementEnvoy ProjectModelElementEnvoy { get; }
        public JetBrains.ReSharper.Psi.IPsiSourceFile SourceFile { get; }
        public JetBrains.Util.TextRange TextRange { get; }
        public JetBrains.ReSharper.Psi.DeclaredElementEnvoy<JetBrains.ReSharper.Psi.ITypeElement> TypeElement { get; }
        public JetBrains.ReSharper.Psi.DeclaredElementEnvoy<JetBrains.ReSharper.Psi.ITypeMember> TypeMember { get; }
        public string DumpToString() { }
        public bool Navigate(JetBrains.ProjectModel.ISolution solution, JetBrains.UI.PopupWindowManager.PopupWindowContextSource windowContext, bool transferFocus, JetBrains.IDE.TabOptions tabOptions = 2) { }
    }
}
namespace JetBrains.ReSharper.I18n.Services.Options
{
    
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(JetBrains.ReSharper.I18n.Services.LocalizationProjectSettings), "Localization options")]
    public class LocalizationOptionsSettings
    {
        [JetBrains.Application.Settings.SettingsEntryAttribute("$TypeName$_$MemberName$_$Value$", "Resource entry default name")]
        public string ResourceNameTemplate;
    }
    [JetBrains.Application.Configuration.Upgrade.GlobalSettingsUpgraderAttribute()]
    public class LocalizationOptionsUpgrader : JetBrains.Application.Configuration.SettingTablesUpgrader
    {
        public LocalizationOptionsUpgrader(JetBrains.Application.Env.RunsProducts.ProductConfigurations productConfigurations) { }
        protected override void DoUpgrade(JetBrains.Application.Configuration.IComponentSettingsProvider legacySettingsProvider, JetBrains.Application.Settings.IContextBoundSettingsStore boundSettingsStore, JetBrains.DataFlow.Lifetime upgradeLifetime, JetBrains.Application.Configuration.SettingsTableBase workspaceSettingsTable, JetBrains.Application.Configuration.SettingsTableBase globalSettingsTable) { }
    }
}
namespace JetBrains.ReSharper.I18n.Services.Refactoring
{
    
    public class AvailableResourcesRefactoringPage : JetBrains.ReSharper.I18n.Services.UI.Refactoring.RefactoringPageBase
    {
        public AvailableResourcesRefactoringPage([JetBrains.Annotations.NotNullAttribute()] System.Func<JetBrains.Application.Progress.IProgressIndicator, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage> findAvailableResources) { }
        public override bool DoNotShow { get; }
        public override JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage Commit(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
        protected override void Dispose(bool disposing) { }
        public override bool Initialize(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
        public override bool RefreshContents(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
    }
    public abstract class DrivenWorkflowWithRollBackBase : JetBrains.ReSharper.Refactorings.WorkflowNew.DrivenRefactoringWorkflow2<JetBrains.ReSharper.Refactorings.IWorkflowExec>
    {
        protected readonly System.Collections.Generic.List<System.Action<JetBrains.Application.Progress.IProgressIndicator>> myRollBackActions;
        protected DrivenWorkflowWithRollBackBase(JetBrains.ProjectModel.ISolution solution, string actionId) { }
        public void AddTextDocumentRollBackAction(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        protected override JetBrains.ReSharper.Refactorings.IWorkflowExec CreateHelper(JetBrains.ReSharper.Refactorings.IRefactoringLanguageService service) { }
        protected override JetBrains.ReSharper.Refactorings.IWorkflowExec CreateUnsupportedHelper() { }
        public override bool PreExecute(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
        public bool RunCustomTool(JetBrains.ReSharper.Psi.IPsiSourceFile file, JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
        public override void UnsuccessfulFinish(JetBrains.Application.Progress.IProgressIndicator pi) { }
    }
    public class ElementsPresenter : JetBrains.ReSharper.Features.Common.Occurences.OccurenceBrowserPresenter
    {
        public ElementsPresenter() { }
    }
    public class ExpressionSourceElement<T> : JetBrains.ReSharper.I18n.Services.Refactoring.ISourceElement
        where T :  class, JetBrains.ReSharper.Psi.Tree.IExpression, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        public ExpressionSourceElement([JetBrains.Annotations.NotNullAttribute()] T expression) { }
        public JetBrains.DocumentModel.DocumentRange DocumentRange { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public T Expression { get; }
        public JetBrains.ReSharper.Psi.PsiLanguageType PsiLanguageType { get; }
        public JetBrains.ReSharper.Psi.IPsiSourceFile SourceFile { get; }
        public JetBrains.ReSharper.Psi.IType Type { get; set; }
        public object Value { get; set; }
        public override bool Equals(object obj) { }
        public bool Equals(JetBrains.ReSharper.I18n.Services.Refactoring.ExpressionSourceElement<T> other) { }
        public override int GetHashCode() { }
        public bool IsValid() { }
    }
    public abstract class ExpressionToResourceExtractorBase<T> : JetBrains.ReSharper.I18n.Services.Refactoring.IResourceExtractor
        where T :  class, JetBrains.ReSharper.Psi.Tree.IExpression
    {
        protected readonly JetBrains.ReSharper.I18n.Services.Searching.ResourceAccessorFinder ResourceAccessorFinder;
        protected ExpressionToResourceExtractorBase(JetBrains.ReSharper.I18n.Services.Searching.ResourceAccessorFinder resourceAccessorFinder) { }
        public abstract byte Priority { get; }
        public virtual bool CanExtractTo(JetBrains.ReSharper.I18n.Services.Refactoring.ISourceElement sourceElement, JetBrains.ReSharper.Psi.IPsiSourceFile resourceFile) { }
        public virtual bool CanUseResource(JetBrains.ReSharper.Psi.IPsiSourceFile resourceFile, JetBrains.ReSharper.Psi.Resolve.IAccessContext context) { }
        public virtual bool Extract(JetBrains.ReSharper.I18n.Services.Refactoring.ISourceElement sourceElement, JetBrains.ReSharper.Psi.Resx.IResourceItem resourceItem, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        protected static JetBrains.ReSharper.Psi.Tree.IExpression GetConstantExpression(JetBrains.Application.DataContext.IDataContext context) { }
        public virtual string GetDefaultResourceName(JetBrains.ReSharper.I18n.Services.Refactoring.ISourceElement sourceElement) { }
        public virtual JetBrains.ReSharper.I18n.Services.Refactoring.ISourceElement GetSourceElement(JetBrains.Application.DataContext.IDataContext context) { }
        public virtual JetBrains.ReSharper.I18n.Services.Refactoring.ISourceElement GetSourceElement(JetBrains.ReSharper.Psi.Tree.ITreeNode node) { }
        protected static bool InInstanceMemeberOfType(JetBrains.ReSharper.Psi.Tree.ITypeMemberDeclaration declaration, string clrName) { }
        public virtual bool IsAvailable(JetBrains.Application.DataContext.IDataContext context) { }
    }
    public class static Helper
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Psi.ITreeNodePointer<T> CreatePointer<T>([JetBrains.Annotations.NotNullAttribute()] this T element)
            where T :  class, JetBrains.ReSharper.Psi.Tree.ITreeNode { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static string GetNewResourceIdentifier([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode element, [JetBrains.Annotations.CanBeNullAttribute()] object value) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.IResourceItemDeclaredElement GetResourceItemDeclaredElement([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.DataContext.IDataContext context) { }
        public static bool IsNoSelection(JetBrains.Application.DataContext.IDataContext context) { }
        public static bool IsValid<T>([JetBrains.Annotations.CanBeNullAttribute()] this JetBrains.ReSharper.Psi.ITreeNodePointer<T> pointer)
            where T :  class, JetBrains.ReSharper.Psi.Tree.ITreeNode { }
    }
    public class InlineResource : JetBrains.ReSharper.Refactorings.Common.RefactoringExecBase<JetBrains.ReSharper.I18n.Services.Refactoring.InlineResourceDrivenWorkflow, JetBrains.ReSharper.I18n.Services.Refactoring.InlineResourceRefactoring>
    {
        public InlineResource(JetBrains.ReSharper.I18n.Services.Refactoring.InlineResourceDrivenWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
    }
    public class InlineResourceDrivenWorkflow : JetBrains.ReSharper.I18n.Services.Refactoring.DrivenWorkflowWithRollBackBase
    {
        public InlineResourceDrivenWorkflow(JetBrains.ProjectModel.ISolution solution, string actionId) { }
        public override JetBrains.ReSharper.Refactorings.Workflow.RefactoringActionGroup ActionGroup { get; }
        public JetBrains.ReSharper.I18n.Services.Refactoring.InlineResourceDrivenWorkflow.Arguments Args { get; }
        public override JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage FirstPendingRefactoringPage { get; }
        public override string HelpKeyword { get; }
        public override bool MightModifyManyDocuments { get; }
        public override bool RequiresSolutionTransation { get; }
        public override string Title { get; }
        public override JetBrains.ReSharper.Refactorings.Workflow.IRefactoringExecuter CreateRefactoring(JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override bool Initialize(JetBrains.Application.DataContext.IDataContext context) { }
        public override bool IsAvailable(JetBrains.Application.DataContext.IDataContext context) { }
        public override void SuccessfulFinish(JetBrains.Application.Progress.IProgressIndicator pi) { }
        public class Arguments
        {
            public Arguments() { }
            public System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.IReferencePointer> AllUsages { get; }
            public JetBrains.ReSharper.Psi.IReferencePointer CurrentUsage { get; set; }
            public bool InlineAllUsages { get; set; }
            public bool RemoveDeclaration { get; set; }
            public JetBrains.ReSharper.Psi.IResourceItemDeclaredElement ResourceItemDeclaredElement { get; set; }
            public bool IsValid() { }
        }
    }
    public class InlineResourceFirstPage : JetBrains.ReSharper.I18n.Services.UI.Refactoring.RefactoringPageBase
    {
        public InlineResourceFirstPage(JetBrains.ReSharper.I18n.Services.Refactoring.InlineResourceDrivenWorkflow.Arguments arguments) { }
        public override JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage Commit(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
        protected override void Dispose(bool disposing) { }
        public override bool Initialize(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
        public override bool RefreshContents(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
    }
    public class InlineResourceRefactoring : JetBrains.ReSharper.Refactorings.Common.DrivenRefactoring<JetBrains.ReSharper.I18n.Services.Refactoring.InlineResourceDrivenWorkflow, JetBrains.ReSharper.I18n.Services.Refactoring.InlineResource>
    {
        public InlineResourceRefactoring(JetBrains.ReSharper.I18n.Services.Refactoring.InlineResourceDrivenWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override bool Execute(JetBrains.Application.Progress.IProgressIndicator pi) { }
    }
    [JetBrains.ReSharper.Refactorings.Workflow.RefactoringWorkflowProviderAttribute()]
    public class InlineResourceValueWorkflowProvider : JetBrains.ReSharper.Refactorings.Inline.InlineWorkflowProvider, JetBrains.ReSharper.Feature.Services.ActionsMenu.IOverridingWorkflowProvider
    {
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflow> CreateWorkflow(JetBrains.Application.DataContext.IDataContext dataContext) { }
        public bool HideOtherActions(JetBrains.Application.DataContext.IDataContext context) { }
    }
    public interface IResourceExtractor
    {
        byte Priority { get; }
        bool CanExtractTo([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.I18n.Services.Refactoring.ISourceElement sourceElement, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IPsiSourceFile resourceFile);
        bool CanUseResource([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IPsiSourceFile resourceFile, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Resolve.IAccessContext context);
        bool Extract([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.I18n.Services.Refactoring.ISourceElement sourceElement, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Resx.IResourceItem resourceItem, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver);
        [JetBrains.Annotations.CanBeNullAttribute()]
        string GetDefaultResourceName([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.I18n.Services.Refactoring.ISourceElement sourceElement);
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.I18n.Services.Refactoring.ISourceElement GetSourceElement([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.DataContext.IDataContext context);
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.I18n.Services.Refactoring.ISourceElement GetSourceElement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode node);
        bool IsAvailable([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.DataContext.IDataContext context);
    }
    public interface IResourceInliner
    {
        byte Priority { get; }
        bool CanInline([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IResourceItemDeclaredElement element);
        bool CanInline([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Resolve.IReference reference, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IResourceItemDeclaredElement element);
        bool CanInline([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode sourceElement, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IResourceItemDeclaredElement element);
        bool Inline([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Resolve.IReference reference, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IResourceItemDeclaredElement element);
        bool Inline([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode sourceElement, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IResourceItemDeclaredElement element);
    }
    public interface IResourceRenameAction
    {
        bool Execute([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Progress.IProgressIndicator progressIndicator, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.I18n.Services.Refactoring.RenameResourceRefactoring refactoring);
        bool Initialize([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.DataContext.IDataContext context, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.I18n.Services.Refactoring.RenameResourceDrivenWorkflow workflow);
        bool IsAvailable([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.DataContext.IDataContext context);
        bool PreExecute([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Progress.IProgressIndicator progressIndicator, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.I18n.Services.Refactoring.RenameResourceDrivenWorkflow workflow);
    }
    public interface ISourceElement
    {
        JetBrains.DocumentModel.DocumentRange DocumentRange { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.PsiLanguageType PsiLanguageType { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IPsiSourceFile SourceFile { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IType Type { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        object Value { get; }
        bool IsValid();
    }
    public class MoveResource : JetBrains.ReSharper.Refactorings.Common.RefactoringExecBase<JetBrains.ReSharper.I18n.Services.Refactoring.MoveResourceDrivenWorkflow, JetBrains.ReSharper.I18n.Services.Refactoring.MoveResourceRefactoring>
    {
        public MoveResource(JetBrains.ReSharper.I18n.Services.Refactoring.MoveResourceDrivenWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
    }
    public class MoveResourceDrivenWorkflow : JetBrains.ReSharper.I18n.Services.Refactoring.DrivenWorkflowWithRollBackBase
    {
        public MoveResourceDrivenWorkflow(JetBrains.ProjectModel.ISolution solution, string actionId) { }
        public override JetBrains.ReSharper.Refactorings.Workflow.RefactoringActionGroup ActionGroup { get; }
        public JetBrains.ReSharper.I18n.Services.Refactoring.MoveResourceDrivenWorkflow.Arguments Args { get; }
        public System.Collections.Generic.HashSet<JetBrains.ReSharper.Psi.IPsiSourceFile> ChangedCultures { get; }
        public override JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage FirstPendingRefactoringPage { get; }
        public override string HelpKeyword { get; }
        public override bool MightModifyManyDocuments { get; }
        public override bool RequiresSolutionTransation { get; }
        public System.Collections.Generic.HashSet<JetBrains.ReSharper.Psi.IPsiSourceFile> SkippedCultures { get; }
        public override string Title { get; }
        public System.Collections.Generic.List<JetBrains.Util.JetTuple<JetBrains.ReSharper.Psi.IReferencePointer, JetBrains.ReSharper.I18n.Services.Refactoring.ParametersOwnerSignature>> UsagesByWrapper { get; }
        public System.Collections.Generic.List<JetBrains.ReSharper.Psi.IReferencePointer> UsagesDirectly { get; }
        public override JetBrains.ReSharper.Refactorings.Workflow.IRefactoringExecuter CreateRefactoring(JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override bool Initialize(JetBrains.Application.DataContext.IDataContext context) { }
        public override bool IsAvailable(JetBrains.Application.DataContext.IDataContext context) { }
        public override bool PreExecute(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
        public class Arguments
        {
            public System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.IPsiSourceFile> AvailableResources { get; set; }
            [JetBrains.Annotations.CanBeNullAttribute()]
            public JetBrains.ReSharper.Psi.IResourceItemDeclaredElement ResourceItemDeclaredElement { get; set; }
            [JetBrains.Annotations.CanBeNullAttribute()]
            public JetBrains.ReSharper.Psi.IPsiSourceFile TargetResourceFile { get; set; }
            [JetBrains.Annotations.CanBeNullAttribute()]
            public string TargetResourceItemName { get; set; }
            public bool IsValid() { }
        }
    }
    public class MoveResourceRefactoring : JetBrains.ReSharper.Refactorings.Common.DrivenRefactoring<JetBrains.ReSharper.I18n.Services.Refactoring.MoveResourceDrivenWorkflow, JetBrains.ReSharper.I18n.Services.Refactoring.MoveResource>
    {
        public MoveResourceRefactoring(JetBrains.ReSharper.I18n.Services.Refactoring.MoveResourceDrivenWorkflow workFlow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override bool Execute(JetBrains.Application.Progress.IProgressIndicator pi) { }
    }
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(JetBrains.ReSharper.I18n.Services.LocalizationProjectSettings), "Move Resource refactoring settings", KeyNameOverride="MoveResource")]
    public class MoveResourceSettings
    {
        [JetBrains.Application.Settings.SettingsEntryAttribute(null, "Last used resource file")]
        public string LastResourceFile;
    }
    [JetBrains.ReSharper.Refactorings.Workflow.RefactoringWorkflowProviderAttribute()]
    public class MoveResourceWorkflowProvider : JetBrains.ReSharper.Refactorings.MoveWorkflowProvider, JetBrains.ReSharper.Feature.Services.ActionsMenu.IOverridingWorkflowProvider
    {
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflow> CreateWorkflow(JetBrains.Application.DataContext.IDataContext dataContext) { }
        public bool HideOtherActions(JetBrains.Application.DataContext.IDataContext context) { }
    }
    public class MoveToResource : JetBrains.ReSharper.Refactorings.Common.RefactoringExecBase<JetBrains.ReSharper.I18n.Services.Refactoring.MoveToResourceDrivenWorkflow, JetBrains.ReSharper.I18n.Services.Refactoring.MoveToResourceRefactoring>
    {
        public MoveToResource(JetBrains.ReSharper.I18n.Services.Refactoring.MoveToResourceDrivenWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
    }
    public class MoveToResourceDrivenWorkflow : JetBrains.ReSharper.I18n.Services.Refactoring.DrivenWorkflowWithRollBackBase
    {
        public MoveToResourceDrivenWorkflow(JetBrains.ProjectModel.ISolution solution, string actionId) { }
        public override JetBrains.ReSharper.Refactorings.Workflow.RefactoringActionGroup ActionGroup { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.I18n.Services.Refactoring.MoveToResourceDrivenWorkflow.Arguments Args { get; }
        public override JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage FirstPendingRefactoringPage { get; }
        public override string HelpKeyword { get; }
        public override bool MightModifyManyDocuments { get; }
        public override bool RequiresSolutionTransation { get; }
        public JetBrains.ReSharper.Psi.Resx.IResourceItem ResourceItem { get; }
        public override string Title { get; }
        public override JetBrains.ReSharper.Refactorings.Workflow.IRefactoringExecuter CreateRefactoring(JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override bool Initialize(JetBrains.Application.DataContext.IDataContext context) { }
        public override bool IsAvailable(JetBrains.Application.DataContext.IDataContext context) { }
        public override bool PreExecute(JetBrains.Application.Progress.IProgressIndicator indicator) { }
        public class Arguments
        {
            public Arguments(JetBrains.Application.Settings.ISettingsStore settingsStore, System.Func<JetBrains.DataFlow.Lifetime, JetBrains.Application.DataContext.DataContexts, JetBrains.Application.DataContext.IDataContext> fContext) { }
            [JetBrains.Annotations.NotNullAttribute()]
            public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IPsiSourceFile> AvailableResourceFiles { get; set; }
            public bool MoveSameElements { get; set; }
            public JetBrains.ReSharper.I18n.Services.Refactoring.SameElementsScope MoveSameElementsScope { get; set; }
            [JetBrains.Annotations.CanBeNullAttribute()]
            public string ResourceComment { get; set; }
            [JetBrains.Annotations.CanBeNullAttribute()]
            public JetBrains.ReSharper.Psi.IPsiSourceFile ResourceFile { get; set; }
            [JetBrains.Annotations.NotNullAttribute()]
            public string ResourceName { get; set; }
            [JetBrains.Annotations.NotNullAttribute()]
            public string ResourceValueText { get; set; }
            [JetBrains.Annotations.NotNullAttribute()]
            public System.Collections.Generic.ICollection<JetBrains.ReSharper.I18n.Services.Refactoring.SameElementOccurence> SameElements { get; set; }
            [JetBrains.Annotations.CanBeNullAttribute()]
            public JetBrains.ReSharper.I18n.Services.Refactoring.ISourceElement SourceElement { get; set; }
            public bool IsValid() { }
        }
    }
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(JetBrains.ReSharper.Refactorings.RefactoringsMruSettings), "Move to Resource refactoring settings")]
    public class MoveToResourceDrivenWorkflowSettings
    {
        [JetBrains.Application.Settings.SettingsEntryAttribute(true, "Whether to move similar elements")]
        public bool MoveSameElements;
        [JetBrains.Application.Settings.SettingsEntryAttribute(JetBrains.ReSharper.I18n.Services.Refactoring.SameElementsScope.File, "Scope for moving similar elements")]
        public JetBrains.ReSharper.I18n.Services.Refactoring.SameElementsScope MoveSameElementsScope;
    }
    public class MoveToResourceFirstPage : JetBrains.ReSharper.I18n.Services.UI.Refactoring.RefactoringPageBase
    {
        public MoveToResourceFirstPage([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.I18n.Services.Refactoring.MoveToResourceDrivenWorkflow.Arguments arguments) { }
        public override JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage Commit(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
        protected override void Dispose(bool disposing) { }
        public override bool Initialize(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
        public override bool RefreshContents(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
    }
    public sealed class MoveToResourceRefactoring : JetBrains.ReSharper.Refactorings.Common.DrivenRefactoring<JetBrains.ReSharper.I18n.Services.Refactoring.MoveToResourceDrivenWorkflow, JetBrains.ReSharper.I18n.Services.Refactoring.MoveToResource>
    {
        public MoveToResourceRefactoring(JetBrains.ReSharper.I18n.Services.Refactoring.MoveToResourceDrivenWorkflow workFlow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override bool Execute(JetBrains.Application.Progress.IProgressIndicator pi) { }
    }
    public class MoveToResourceSecondPage : JetBrains.ReSharper.I18n.Services.UI.Refactoring.RefactoringPageBase
    {
        public MoveToResourceSecondPage([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.I18n.Services.Refactoring.MoveToResourceDrivenWorkflow.Arguments arguments) { }
        public override bool DoNotShow { get; }
        public override JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage Commit(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
        protected override void Dispose(bool disposing) { }
        public override bool Initialize(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
        public override bool RefreshContents(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
    }
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(JetBrains.ReSharper.I18n.Services.LocalizationProjectSettings), "Move to Resource refactoring settings", KeyNameOverride="MoveToResource")]
    public class MoveToResourceSettings
    {
        [JetBrains.Application.Settings.SettingsEntryAttribute(null, "Last used resource file")]
        public string LastResourceFile;
    }
    [JetBrains.ReSharper.Refactorings.Workflow.RefactoringWorkflowProviderAttribute()]
    public class MoveToResourceWorkflowProvider : JetBrains.ReSharper.Refactorings.MoveWorkflowProvider
    {
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflow> CreateWorkflow(JetBrains.Application.DataContext.IDataContext dataContext) { }
    }
    public class ParametersOwnerSignature
    {
        public JetBrains.ReSharper.Psi.Resolve.ISubstitution IDSubstitution { get; }
        public System.Collections.Generic.ICollection<JetBrains.Util.JetTuple<string, JetBrains.ReSharper.Psi.IType, JetBrains.ReSharper.Psi.ParameterKind>> Parameters { get; }
        public JetBrains.ReSharper.Psi.IType ReturnType { get; }
        public string ShortName { get; }
        public static bool CompareWithoutName(JetBrains.ReSharper.I18n.Services.Refactoring.ParametersOwnerSignature x, JetBrains.ReSharper.I18n.Services.Refactoring.ParametersOwnerSignature y) { }
        public static JetBrains.ReSharper.I18n.Services.Refactoring.ParametersOwnerSignature Create(JetBrains.ReSharper.Psi.IParametersOwner parametersOwner, JetBrains.ReSharper.Psi.Resolve.ISubstitution idSubstitution) { }
    }
    [JetBrains.Application.Configuration.Upgrade.GlobalSettingsUpgraderAttribute()]
    public class RefactoringsSettingsUpgrader : JetBrains.Application.Configuration.SettingTablesUpgrader
    {
        public RefactoringsSettingsUpgrader(JetBrains.Application.Env.RunsProducts.ProductConfigurations productConfigurations) { }
        protected override void DoUpgrade(JetBrains.Application.Configuration.IComponentSettingsProvider legacySettingsProvider, JetBrains.Application.Settings.IContextBoundSettingsStore boundSettingsStore, JetBrains.DataFlow.Lifetime upgradeLifetime, JetBrains.Application.Configuration.SettingsTableBase workspaceSettingsTable, JetBrains.Application.Configuration.SettingsTableBase globalSettingsTable) { }
    }
    public class RenameResource : JetBrains.ReSharper.Refactorings.Common.RefactoringExecBase<JetBrains.ReSharper.I18n.Services.Refactoring.RenameResourceDrivenWorkflow, JetBrains.ReSharper.I18n.Services.Refactoring.RenameResourceRefactoring>
    {
        public RenameResource(JetBrains.ReSharper.I18n.Services.Refactoring.RenameResourceDrivenWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
    }
    public class RenameResourceDrivenWorkflow : JetBrains.ReSharper.I18n.Services.Refactoring.DrivenWorkflowWithRollBackBase
    {
        public RenameResourceDrivenWorkflow(JetBrains.ProjectModel.ISolution solution, string actionId) { }
        public override JetBrains.ReSharper.Refactorings.Workflow.RefactoringActionGroup ActionGroup { get; }
        public JetBrains.ReSharper.I18n.Services.Refactoring.RenameResourceDrivenWorkflow.Arguments Args { get; }
        public override JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage FirstPendingRefactoringPage { get; }
        public override string HelpKeyword { get; }
        public override bool MightModifyManyDocuments { get; }
        public override bool RequiresSolutionTransation { get; }
        public JetBrains.ReSharper.I18n.Services.Refactoring.IResourceRenameAction ResourceRenameAction { get; }
        public override string Title { get; }
        public override JetBrains.ReSharper.Refactorings.Workflow.IRefactoringExecuter CreateRefactoring(JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override bool Initialize(JetBrains.Application.DataContext.IDataContext context) { }
        public override bool IsAvailable(JetBrains.Application.DataContext.IDataContext context) { }
        public override bool PreExecute(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
        public class Arguments
        {
            public JetBrains.ReSharper.Psi.Naming.Settings.NamingPolicy NamingPolicy { get; set; }
            public JetBrains.ReSharper.Psi.Pointers.IDeclaredElementPointer<JetBrains.ReSharper.Psi.IResourceItemDeclaredElement> ResourceElement { get; set; }
            public string ResourceElementNewName { get; set; }
            public System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Naming.Impl.NameRoot> Roots { get; set; }
            public bool IsValid() { }
        }
    }
    public class RenameResourceFirstPage : JetBrains.ReSharper.I18n.Services.UI.Refactoring.RefactoringPageBase
    {
        public RenameResourceFirstPage(JetBrains.ReSharper.I18n.Services.Refactoring.RenameResourceDrivenWorkflow.Arguments arguments, JetBrains.ProjectModel.ISolution solution) { }
        public override JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage Commit(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
        protected override void Dispose(bool disposing) { }
        public override bool Initialize(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
        public override bool RefreshContents(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
    }
    public class RenameResourceRefactoring : JetBrains.ReSharper.Refactorings.Common.DrivenRefactoring<JetBrains.ReSharper.I18n.Services.Refactoring.RenameResourceDrivenWorkflow, JetBrains.ReSharper.I18n.Services.Refactoring.RenameResource>
    {
        public RenameResourceRefactoring(JetBrains.ReSharper.I18n.Services.Refactoring.RenameResourceDrivenWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override bool Execute(JetBrains.Application.Progress.IProgressIndicator pi) { }
    }
    [JetBrains.ReSharper.Refactorings.Workflow.RefactoringWorkflowProviderAttribute()]
    public class RenameResourceWorkflowProvider : JetBrains.ReSharper.Refactorings.Rename.RenameWorkflowProvider, JetBrains.ReSharper.Feature.Services.ActionsMenu.IOverridingWorkflowProvider
    {
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflow> CreateWorkflow(JetBrains.Application.DataContext.IDataContext dataContext) { }
        public bool HideOtherActions(JetBrains.Application.DataContext.IDataContext context) { }
    }
    [JetBrains.ReSharper.Refactorings.Workflow.RefactoringWorkflowProviderAttribute()]
    public class ResourceElementsChangeSignatureWorkflowProvider : JetBrains.ReSharper.Feature.Services.ActionsMenu.IOverridingWorkflowProvider, JetBrains.ReSharper.Feature.Services.ActionsMenu.IWorkflowProvider<JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflow, JetBrains.ReSharper.Refactorings.Workflow.RefactoringActionGroup>, JetBrains.ReSharper.Refactorings.ChangeSignature.IChangeSignatureWorkflowProvider, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflowProvider
    {
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflow> CreateWorkflow(JetBrains.Application.DataContext.IDataContext dataContext) { }
        public bool HideOtherActions(JetBrains.Application.DataContext.IDataContext context) { }
    }
    [JetBrains.ReSharper.Refactorings.Workflow.RefactoringWorkflowProviderAttribute()]
    public class ResourceExtractSuperclassWorkflowProvider : JetBrains.ReSharper.Feature.Services.ActionsMenu.IOverridingWorkflowProvider, JetBrains.ReSharper.Feature.Services.ActionsMenu.IWorkflowProvider<JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflow, JetBrains.ReSharper.Refactorings.Workflow.RefactoringActionGroup>, JetBrains.ReSharper.Refactorings.MoveMembers.Actions.IExtractSuperclassWorkflowProvider, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflowProvider
    {
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflow> CreateWorkflow(JetBrains.Application.DataContext.IDataContext dataContext) { }
        public bool HideOtherActions(JetBrains.Application.DataContext.IDataContext context) { }
    }
    public class static ResourceFileSettingsUtil
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.IPsiSourceFile GetLastSelectedFile<T>(System.Linq.Expressions.Expression<System.Func<T, string>> expression, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProject project) { }
        public static void SetLastSelectedFile<T>(System.Linq.Expressions.Expression<System.Func<T, string>> expression, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProject project, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.IPsiSourceFile projectFile = null) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class ResourceInliner
    {
        public ResourceInliner(JetBrains.ProjectModel.ISolution solution) { }
        public bool CanInline(JetBrains.ReSharper.Psi.IResourceItemDeclaredElement element) { }
        public bool CanInline(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.IResourceItemDeclaredElement element) { }
        public bool CanInline(JetBrains.ReSharper.Psi.Tree.ITreeNode sourceElement, JetBrains.ReSharper.Psi.IResourceItemDeclaredElement element) { }
        public bool Inline(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.IResourceItemDeclaredElement element) { }
        public bool Inline(JetBrains.ReSharper.Psi.Tree.ITreeNode sourceElement, JetBrains.ReSharper.Psi.IResourceItemDeclaredElement element) { }
    }
    [JetBrains.ReSharper.Refactorings.Workflow.RefactoringWorkflowProviderAttribute()]
    public class ResourcePushDownWorkflowProvider : JetBrains.ReSharper.Feature.Services.ActionsMenu.IOverridingWorkflowProvider, JetBrains.ReSharper.Feature.Services.ActionsMenu.IWorkflowProvider<JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflow, JetBrains.ReSharper.Refactorings.Workflow.RefactoringActionGroup>, JetBrains.ReSharper.Refactorings.MoveMembers.Actions.IPushDownWorkflowProvider, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflowProvider
    {
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflow> CreateWorkflow(JetBrains.Application.DataContext.IDataContext dataContext) { }
        public bool HideOtherActions(JetBrains.Application.DataContext.IDataContext context) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class ResourceRenameAction
    {
        public ResourceRenameAction(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.I18n.Services.Refactoring.IResourceRenameAction> renameActions) { }
        public static JetBrains.ReSharper.I18n.Services.Refactoring.ResourceRenameAction Instance { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.I18n.Services.Refactoring.IResourceRenameAction GetAction([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.DataContext.IDataContext context) { }
    }
    [JetBrains.Annotations.BaseTypeRequiredAttribute(typeof(JetBrains.ReSharper.I18n.Services.Refactoring.IResourceRenameAction))]
    public class ResourceRenameActionAttribute : JetBrains.Application.ShellComponentAttribute { }
    public abstract class ResourceToExpressionInlinerBase<T> : JetBrains.ReSharper.I18n.Services.Refactoring.IResourceInliner
        where T :  class, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        public abstract byte Priority { get; }
        protected abstract JetBrains.ReSharper.Psi.PsiLanguageType PsiLanguageType { get; }
        public virtual bool CanInline(JetBrains.ReSharper.Psi.IResourceItemDeclaredElement element) { }
        public virtual bool CanInline(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.IResourceItemDeclaredElement element) { }
        public virtual bool CanInline(JetBrains.ReSharper.Psi.Tree.ITreeNode sourceElement, JetBrains.ReSharper.Psi.IResourceItemDeclaredElement element) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        protected abstract T CreateExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.ConstantValue value);
        [JetBrains.Annotations.NotNullAttribute()]
        protected abstract JetBrains.ReSharper.Psi.Tree.ITreeNode GetElementToInline([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Resolve.IReference reference);
        public virtual bool Inline(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.IResourceItemDeclaredElement element) { }
        public virtual bool Inline(JetBrains.ReSharper.Psi.Tree.ITreeNode sourceElement, JetBrains.ReSharper.Psi.IResourceItemDeclaredElement element) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Resx.ResxLanguage))]
    public class ResxRefactoringLanguageService : JetBrains.ReSharper.Refactorings.InternalRefactoringLanguageService
    {
        public override JetBrains.ReSharper.Refactorings.RefactoringsHelper Helper { get; }
        public override JetBrains.ReSharper.Refactorings.SafeDeleteFolder.SafeDeleteFolderHelperBase CreateSafeDeleteFolderHelper() { }
    }
    public class ResxRename : JetBrains.ReSharper.Refactorings.RenameModel.RenameBase { }
    public class ResxSafeDeleteFolderHelper : JetBrains.ReSharper.Refactorings.SafeDeleteFolder.SafeDeleteFolderHelperBase
    {
        public override bool IsLanguageSupported { get; }
        public override System.Collections.Generic.IList<JetBrains.ReSharper.Psi.IDeclaredElement> GetExternalDeclaredElements(JetBrains.ReSharper.Psi.Tree.IFile file) { }
    }
    public class SafeDeleteResource : JetBrains.ReSharper.Refactorings.Common.RefactoringExecBase<JetBrains.ReSharper.I18n.Services.Refactoring.SafeDeleteResourceDrivenWorkflow, JetBrains.ReSharper.I18n.Services.Refactoring.SafeDeleteResourceRefactoring>
    {
        public SafeDeleteResource(JetBrains.ReSharper.I18n.Services.Refactoring.SafeDeleteResourceDrivenWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
    }
    public class SafeDeleteResourceDrivenWorkflow : JetBrains.ReSharper.I18n.Services.Refactoring.DrivenWorkflowWithRollBackBase
    {
        public SafeDeleteResourceDrivenWorkflow(JetBrains.ProjectModel.ISolution solution, string actionId) { }
        public override JetBrains.ReSharper.Refactorings.Workflow.RefactoringActionGroup ActionGroup { get; }
        public System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.IReferencePointer> AllUsages { get; }
        public JetBrains.ReSharper.I18n.Services.Refactoring.SafeDeleteResourceDrivenWorkflow.Arguments Args { get; }
        public override JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage FirstPendingRefactoringPage { get; }
        public override string HelpKeyword { get; }
        public override bool MightModifyManyDocuments { get; }
        public override bool RequiresSolutionTransation { get; }
        public override string Title { get; }
        public override JetBrains.ReSharper.Refactorings.Workflow.IRefactoringExecuter CreateRefactoring(JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override bool Initialize(JetBrains.Application.DataContext.IDataContext context) { }
        public override bool IsAvailable(JetBrains.Application.DataContext.IDataContext context) { }
        public override void SuccessfulFinish(JetBrains.Application.Progress.IProgressIndicator pi) { }
        public class Arguments
        {
            public JetBrains.ReSharper.Psi.IResourceItemDeclaredElement ResourceItemDeclaredElement { get; set; }
            public bool IsValid() { }
        }
    }
    public class SafeDeleteResourceRefactoring : JetBrains.ReSharper.Refactorings.Common.DrivenRefactoring<JetBrains.ReSharper.I18n.Services.Refactoring.SafeDeleteResourceDrivenWorkflow, JetBrains.ReSharper.I18n.Services.Refactoring.SafeDeleteResource>
    {
        public SafeDeleteResourceRefactoring(JetBrains.ReSharper.I18n.Services.Refactoring.SafeDeleteResourceDrivenWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override bool Execute(JetBrains.Application.Progress.IProgressIndicator pi) { }
    }
    [JetBrains.ReSharper.Refactorings.Workflow.RefactoringWorkflowProviderAttribute()]
    public class SafeDeleteResourceWorkflowProvider : JetBrains.ReSharper.Refactorings.SafeDeleteTheSecond.SafeDeleteWorkflowProvider, JetBrains.ReSharper.Feature.Services.ActionsMenu.IOverridingWorkflowProvider
    {
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflow> CreateWorkflow(JetBrains.Application.DataContext.IDataContext dataContext) { }
        public bool HideOtherActions(JetBrains.Application.DataContext.IDataContext context) { }
    }
    public class SameElementOccurence : JetBrains.ReSharper.Feature.Services.Navigation.Occurences.RangeOccurence
    {
        public SameElementOccurence([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.I18n.Services.Refactoring.ISourceElement element) { }
        public bool Included { get; set; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.I18n.Services.Refactoring.ISourceElement SourceElement { get; }
    }
    public enum SameElementsScope
    {
        Type = 0,
        File = 1,
        Folder = 2,
        Project = 3,
        Solution = 4,
    }
}
namespace JetBrains.ReSharper.I18n.Services.Refactoring.Rename
{
    
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Resx.ResxLanguage))]
    public class ResourceItemRenameHelper : JetBrains.ReSharper.Refactorings.Rename.RenameHelperBase
    {
        public override bool IsLanguageSupported { get; }
        public override void AdditionalReferenceProcessing(JetBrains.ReSharper.Psi.IDeclaredElement newTarget, JetBrains.ReSharper.Psi.Resolve.IReference reference, System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.Resolve.IReference> newReferences) { }
        public override bool DoNotProcess(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public override JetBrains.ReSharper.Psi.Resolve.IReference TransformProjectedInitializer(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
    }
    [JetBrains.ReSharper.Psi.ShellFeaturePartAttribute()]
    public class ResourceItemRenamesFactory : JetBrains.ReSharper.Refactorings.Rename.AtomicRenamesFactory
    {
        public override JetBrains.ReSharper.Refactorings.RenameModel.RenameAvailabilityCheckResult CheckRenameAvailability(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
        public override bool IsApplicable(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
    }
}
namespace JetBrains.ReSharper.I18n.Services.Resolve
{
    
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.KnownLanguage))]
    public class I18nResolveErrorHelper : JetBrains.ReSharper.Daemon.Stages.Resolve.IResolveProblemHighlighter
    {
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Resolve.ResolveErrorType> ErrorTypes { get; }
        public JetBrains.ReSharper.Daemon.IHighlighting Run(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
    }
    public class I18nResolveErrorType : JetBrains.ReSharper.Psi.Resolve.ResolveErrorType
    {
        public static readonly JetBrains.ReSharper.I18n.Services.Resolve.I18nResolveErrorType PROPERTY_NOT_RESOLVED;
        public static readonly JetBrains.ReSharper.I18n.Services.Resolve.I18nResolveErrorType PUBLIC_PROPERTY_NOT_RESOLVED;
        protected I18nResolveErrorType(string name) { }
    }
    public class ResourceItemDeclaredElement : JetBrains.ReSharper.Psi.IDeclaredElement, JetBrains.ReSharper.Psi.IResourceItemDeclaredElement
    {
        public ResourceItemDeclaredElement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Resx.IResourceItem resourceItem) { }
        public bool CaseSensistiveName { get; }
        public JetBrains.ReSharper.Psi.PsiLanguageType PresentationLanguage { get; }
        public string ShortName { get; }
        public override bool Equals(object obj) { }
        protected bool Equals(JetBrains.ReSharper.Psi.IResourceItemDeclaredElement other) { }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Tree.IDeclaration> GetDeclarations() { }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Tree.IDeclaration> GetDeclarationsIn(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        public JetBrains.ReSharper.Psi.DeclaredElementType GetElementType() { }
        public override int GetHashCode() { }
        public JetBrains.ReSharper.Psi.IPsiServices GetPsiServices() { }
        public JetBrains.Util.DataStructures.HybridCollection<JetBrains.ReSharper.Psi.IPsiSourceFile> GetSourceFiles() { }
        public System.Xml.XmlNode GetXMLDescriptionSummary(bool inherit) { }
        public System.Xml.XmlNode GetXMLDoc(bool inherit) { }
        public bool HasDeclarationsIn(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        public bool IsSynthetic() { }
        public bool IsValid() { }
        public override string ToString() { }
    }
}
namespace JetBrains.ReSharper.I18n.Services.Resources
{
    
    public sealed class Services118nThemedIcons
    {
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.I18n.Services;component/resources/Services118nIcons/ThemedIco" +
            "ns.Services118n.Generated.Xaml", 0, "BaseCulture")]
        public sealed class BaseCulture : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.I18n.Services;component/resources/Services118nIcons/ThemedIco" +
            "ns.Services118n.Generated.Xaml", 2, "Localization")]
        public sealed class Localization : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.I18n.Services;component/resources/Services118nIcons/ThemedIco" +
            "ns.Services118n.Generated.Xaml", 3, "SpecificAndBaseCulture")]
        public sealed class SpecificAndBaseCulture : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.I18n.Services;component/resources/Services118nIcons/ThemedIco" +
            "ns.Services118n.Generated.Xaml", 1, "SpecificCulture")]
        public sealed class SpecificCulture : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
    }
}
namespace JetBrains.ReSharper.I18n.Services.Searching
{
    
    [JetBrains.ReSharper.Psi.PsiSharedComponentAttribute()]
    public class GeneratedFileFinder
    {
        public GeneratedFileFinder(JetBrains.DataFlow.Lifetime lifetime, JetBrains.DataFlow.IViewable<JetBrains.ReSharper.I18n.Services.Searching.IGeneratedFileFinder> finders) { }
        public static JetBrains.ReSharper.I18n.Services.Searching.GeneratedFileFinder Instance { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public System.Collections.Generic.IEnumerable<T> FindElementsInFile<T>([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile)
            where T : JetBrains.ReSharper.Psi.IDeclaredElement { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ProjectModel.IProjectFile FindGeneratedFile([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ProjectModel.IProjectFile masterFile) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ProjectModel.IProjectFile FindMasterFile([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ProjectModel.IProjectFile generatedFile) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.ITypeMember> FindMembersByMasterFile([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ProjectModel.IProjectFile masterFile, [JetBrains.Annotations.NotNullAttribute()] [System.ComponentModel.LocalizableAttribute(false)] string name, bool caseSensitive) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.ITypeMember> FindMembersInFile([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ProjectModel.IProjectFile projectFile, [JetBrains.Annotations.NotNullAttribute()] [System.ComponentModel.LocalizableAttribute(false)] string name, bool caseSensitive) { }
        public bool IsGeneratedFile([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ProjectModel.IProjectFile projectFile) { }
    }
    [JetBrains.Annotations.BaseTypeRequiredAttribute(typeof(JetBrains.ReSharper.I18n.Services.Searching.IGeneratedFileFinder))]
    [JetBrains.Annotations.MeansImplicitUseAttribute()]
    public class GeneratedFileFinderAttribute : JetBrains.ReSharper.Psi.PsiSharedComponentAttribute
    {
        public byte Priority { get; set; }
    }
    public interface IGeneratedFileFinder
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ProjectModel.IProjectFile FindGeneratedFile([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ProjectModel.IProjectFile masterFile);
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ProjectModel.IProjectFile FindMasterFile([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ProjectModel.IProjectFile generatedFile);
        bool IsGeneratedFile([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ProjectModel.IProjectFile projectFile);
    }
    public interface IResourceAccessor
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredElement DeclaredElement { get; }
        byte Priority { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Tree.ITreeNode Replace([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode element);
    }
    public interface IResourceAccessorFinder
    {
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.I18n.Services.Searching.IResourceAccessor> FindAccessors([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IResourceItemDeclaredElement element, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.I18n.Services.Searching.IResourceAccessor> accessors);
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.ITypeElement> FindTypeElements([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IPsiSourceFile resourceFile);
    }
    public interface IResourceSearchDomainProvider
    {
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Search.ISearchDomain GetSearchDomain([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IResourceItemDeclaredElement element, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Search.ISearchDomain searchDomain);
    }
    [JetBrains.ReSharper.Psi.PsiSharedComponentAttribute()]
    public class ResourceAccessorFinder
    {
        public ResourceAccessorFinder(JetBrains.DataFlow.Lifetime lifetime, JetBrains.DataFlow.IViewable<JetBrains.ReSharper.I18n.Services.Searching.IResourceAccessorFinder> finders) { }
        public static JetBrains.ReSharper.I18n.Services.Searching.ResourceAccessorFinder Instance { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public System.Collections.Generic.ICollection<JetBrains.ReSharper.I18n.Services.Searching.IResourceAccessor> FindAccessors([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IResourceItemDeclaredElement element) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.ITypeElement> FindTypeElements([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
    }
    public abstract class ResourceAccessorFinderBase<TProjectFileType, TLanguageType> : JetBrains.ReSharper.I18n.Services.Searching.IResourceAccessorFinder
        where TProjectFileType : JetBrains.ProjectModel.ProjectFileType
        where TLanguageType : JetBrains.ReSharper.Psi.PsiLanguageType
    {
        protected ResourceAccessorFinderBase(JetBrains.ReSharper.I18n.Services.Searching.GeneratedFileFinder generatedFileFinder, JetBrains.ReSharper.Psi.Search.SearchDomainFactory searchDomainFactory) { }
        protected abstract JetBrains.ReSharper.I18n.Services.Searching.IResourceAccessor CreateResourceAccessor([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.ITypeMember typeMember);
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.I18n.Services.Searching.IResourceAccessor> FindAccessors(JetBrains.ReSharper.Psi.IResourceItemDeclaredElement element, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.I18n.Services.Searching.IResourceAccessor> accessors) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.ITypeElement> FindTypeElements(JetBrains.ReSharper.Psi.IPsiSourceFile resourceFile) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        protected abstract JetBrains.ReSharper.Psi.Tree.IArgument GetArgument([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode element);
        [JetBrains.Annotations.CanBeNullAttribute()]
        protected abstract JetBrains.ReSharper.Psi.Tree.IExpression GetArgumentValue([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.IArgument argument);
        protected virtual bool IsSupport(JetBrains.ReSharper.Psi.IResourceItemDeclaredElement element) { }
        protected abstract class GeneratedResourceAccessorBase<TProjectFileType, TLanguageType> : JetBrains.ReSharper.I18n.Services.Searching.IResourceAccessor
            where TProjectFileType : JetBrains.ProjectModel.ProjectFileType
            where TLanguageType : JetBrains.ReSharper.Psi.PsiLanguageType
        {
            protected GeneratedResourceAccessorBase([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.ITypeMember typeMember, byte priority, [JetBrains.Annotations.NotNullAttribute()] string format) { }
            [JetBrains.Annotations.NotNullAttribute()]
            public JetBrains.ReSharper.Psi.IDeclaredElement DeclaredElement { get; }
            public string Format { get; }
            public byte Priority { get; }
            public abstract JetBrains.ReSharper.Psi.Tree.ITreeNode Replace(JetBrains.ReSharper.Psi.Tree.ITreeNode element);
        }
    }
    [JetBrains.Annotations.BaseTypeRequiredAttribute(typeof(JetBrains.ReSharper.I18n.Services.Searching.IResourceAccessorFinder))]
    [JetBrains.Annotations.MeansImplicitUseAttribute()]
    public class ResourceAccessorsFinderAttribute : JetBrains.ReSharper.Psi.PsiSharedComponentAttribute
    {
        public byte Priority { get; set; }
    }
    public class ResourceNameFinder : JetBrains.ReSharper.Psi.IRecursiveElementProcessor
    {
        public ResourceNameFinder(bool findFirst) { }
        [JetBrains.Annotations.NotNullAttribute()]
        protected System.Collections.Generic.Dictionary<JetBrains.ReSharper.Psi.Tree.ITypeMemberDeclaration, string> ResourceAccessors { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static string FindResourceDeclarationName([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode codeElement) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.IResourceItemDeclaredElement FindResourceItemDeclaredElement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.I18n.Services.Searching.GeneratedFileFinder generatedFileFinder, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
    }
    [JetBrains.Annotations.BaseTypeRequiredAttribute(typeof(JetBrains.ReSharper.I18n.Services.Searching.IResourceSearchDomainProvider))]
    [JetBrains.Annotations.MeansImplicitUseAttribute()]
    public class ResourceSearchDomainProviderAttribute : JetBrains.ReSharper.Psi.PsiSharedComponentAttribute
    {
        public byte Priority { get; set; }
    }
    public class ResxReferenceSearcher : JetBrains.ReSharper.Psi.ExtensionsAPI.IDomainSpecificSearcher
    {
        public ResxReferenceSearcher(JetBrains.ReSharper.Psi.ExtensionsAPI.IDomainSpecificSearcherFactory factory, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IDeclaredElement> elements, bool findCandidates, bool findLateBound) { }
        public bool ProcessElement<TResult>(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Search.IFindResultConsumer<TResult> consumer) { }
        public bool ProcessProjectItem<TResult>(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.ReSharper.Psi.Search.IFindResultConsumer<TResult> consumer) { }
    }
    [JetBrains.ReSharper.Psi.PsiSharedComponentAttribute()]
    public class ResxSearcherFactory : JetBrains.ReSharper.Psi.ExtensionsAPI.IDomainSpecificSearcherFactory
    {
        public ResxSearcherFactory(JetBrains.ReSharper.Psi.Search.SearchDomainFactory searchDomainFactory, JetBrains.ReSharper.Psi.Resx.Services.IResourceSearchService resourceSearchService, JetBrains.ReSharper.I18n.Services.Searching.ResourceAccessorFinder resourceAccessorFinder, JetBrains.ReSharper.I18n.Services.Searching.GeneratedFileFinder generatedFileFinder) { }
        public JetBrains.ReSharper.Psi.ExtensionsAPI.IDomainSpecificSearcher CreateAnonymousTypeSearcher(System.Collections.Generic.IList<JetBrains.ReSharper.Psi.AnonymousTypeDescriptor> typeDescription, bool caseSensitive) { }
        public JetBrains.ReSharper.Psi.ExtensionsAPI.IDomainSpecificSearcher CreateConstantExpressionSearcher(JetBrains.ReSharper.Psi.ConstantValue constantValue, bool onlyLiteralExpression) { }
        public JetBrains.ReSharper.Psi.ExtensionsAPI.IDomainSpecificSearcher CreateConstructorSpecialReferenceSearcher(System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.IConstructor> constructors) { }
        public JetBrains.ReSharper.Psi.ExtensionsAPI.IDomainSpecificSearcher CreateLateBoundReferenceSearcher(System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.IDeclaredElement> elements) { }
        public JetBrains.ReSharper.Psi.ExtensionsAPI.IDomainSpecificSearcher CreateMethodsReferencedByDelegateSearcher(JetBrains.ReSharper.Psi.IDelegate @delegate) { }
        public JetBrains.ReSharper.Psi.ExtensionsAPI.IDomainSpecificSearcher CreateReferenceSearcher(System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.IDeclaredElement> elements, bool findCandidates) { }
        public JetBrains.ReSharper.Psi.ExtensionsAPI.IDomainSpecificSearcher CreateTextOccurenceSearcher(System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.IDeclaredElement> elements) { }
        public JetBrains.ReSharper.Psi.ExtensionsAPI.IDomainSpecificSearcher CreateTextOccurenceSearcher(string subject) { }
        public System.Collections.Generic.IEnumerable<string> GetAllPossibleWordsInFile(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public JetBrains.ReSharper.Psi.Search.ISearchDomain GetDeclaredElementSearchDomain(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
        public JetBrains.Util.JetTuple<System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.IDeclaredElement>, System.Predicate<JetBrains.ReSharper.Psi.Search.IFindResultReference>, bool> GetDerivedFindRequest(JetBrains.ReSharper.Psi.Search.IFindResultReference result) { }
        public JetBrains.Util.JetTuple<System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.IDeclaredElement>, bool> GetNavigateToTargets(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public System.Collections.Generic.IEnumerable<JetBrains.Util.Pair<JetBrains.ReSharper.Psi.IDeclaredElement, System.Predicate<JetBrains.ReSharper.Psi.Search.FindResult>>> GetRelatedDeclaredElements(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public bool IsCompatibleWithLanguage(JetBrains.ReSharper.Psi.PsiLanguageType languageType) { }
        public System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.Search.FindResult> TransformNavigationTargets(System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.Search.FindResult> targets) { }
    }
}
namespace JetBrains.ReSharper.I18n.Services.Services
{
    
    public interface IResourceModificationService
    {
        void AddResourceItem(JetBrains.ReSharper.Psi.IPsiSourceFile resourceFile, string name, string value, string comment, JetBrains.ReSharper.Psi.IType type);
        void ChangeResourceItem(JetBrains.ReSharper.Psi.Resx.IResourceItem resourceItem, string newValue, string newComment);
        void ChangeResourceItemName(JetBrains.ReSharper.Psi.IPsiSourceFile resourceFile, string oldName, string newName);
        void CopyResourceItem(JetBrains.ReSharper.Psi.Resx.IResourceItem resourceItem, JetBrains.ReSharper.Psi.IPsiSourceFile targetResourceFile, string newName);
        void DeleteResourceItem(JetBrains.ReSharper.Psi.Resx.IResourceItem resourceItem);
        void DeleteResourceItem(JetBrains.ReSharper.Psi.IPsiSourceFile resourceFile, string name);
        void MoveResourceItem(JetBrains.ReSharper.Psi.Resx.IResourceItem resourceItem, JetBrains.ReSharper.Psi.IPsiSourceFile targetResourceFile, string newName);
    }
    public interface IResourceProvider
    {
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Resx.IResourceItem> EnumerateResourceItems([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IPsiSourceFile resourceFile);
        [JetBrains.Annotations.CanBeNullAttribute()]
        string GetResourceItemComment(JetBrains.ReSharper.Psi.IPsiSourceFile resourceFile, string name);
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.ConstantValue GetResourceItemValue([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IPsiSourceFile resourceFile, [JetBrains.Annotations.NotNullAttribute()] string name);
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.Util.DataStructures.CompactOneToListMap<string, JetBrains.ReSharper.Psi.Resx.IResourceItem> LoadData([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IPsiSourceFile resourceFile, [JetBrains.Annotations.NotNullAttribute()] System.IO.BinaryReader reader);
        void WriteData([JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.DataStructures.CompactOneToListMap<string, JetBrains.ReSharper.Psi.Resx.IResourceItem> data, System.IO.BinaryWriter writer);
    }
}
namespace JetBrains.ReSharper.I18n.Services.UI
{
    
    public class ComboBoxItem<T> : System.IEquatable<JetBrains.ReSharper.I18n.Services.UI.ComboBoxItem<T>>
    
    {
        public ComboBoxItem([JetBrains.Annotations.NotNullAttribute()] string name, T value) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public string Name { get; }
        public T Value { get; }
        public override bool Equals(object obj) { }
        public bool Equals(JetBrains.ReSharper.I18n.Services.UI.ComboBoxItem<T> comboBoxItem) { }
        public override int GetHashCode() { }
        public override string ToString() { }
    }
}
namespace JetBrains.ReSharper.I18n.Services.UI.Options
{
    
    [JetBrains.UI.Options.OptionsPageAttribute("LocalizationOptions", "Localization", typeof(JetBrains.ReSharper.I18n.Services.Resources.Services118nThemedIcons.Localization), HelpKeyword="Reference__Options__Tools__Localization", ParentId="CodeEditing", Sequence=5D)]
    public class LocalizationOptionPage : JetBrains.ReSharper.I18n.Services.UI.Options.OptionPageBase
    {
        public LocalizationOptionPage(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Threading.IThreading threading, JetBrains.UI.Options.OptionsSettingsSmartContext smartContext, JetBrains.UI.Application.IUIApplication environment, JetBrains.ReSharper.Daemon.Daemon daemon = null) { }
        protected override void Dispose(bool disposing) { }
        protected override bool PressOk() { }
    }
    public class OptionPageBase : JetBrains.UI.CommonControls.SafeUserControl, JetBrains.UI.Options.IOptionsPage
    {
        protected OptionPageBase(string id, JetBrains.UI.Application.IUIApplication environment, JetBrains.ReSharper.Daemon.Daemon daemon = null) { }
        public virtual string Id { get; }
        protected virtual void Activated(bool activated) { }
        protected virtual void InitializeUI() { }
        public bool OnOk() { }
        protected virtual bool OnValidatePage() { }
        protected virtual bool PressOk() { }
        protected void RefreshHighlightings() { }
    }
}
namespace JetBrains.ReSharper.I18n.Services.UI.Refactoring
{
    
    [System.ComponentModel.DefaultPropertyAttribute("Title")]
    public class RefactoringPageBase : System.Windows.Forms.UserControl, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage
    {
        [System.ComponentModel.BrowsableAttribute(false)]
        public virtual JetBrains.DataFlow.IProperty<bool> ContinueEnabled { get; }
        [System.ComponentModel.CategoryAttribute("RefactoringPage")]
        [System.ComponentModel.DefaultValueAttribute("")]
        [System.ComponentModel.LocalizableAttribute(true)]
        public string Description { get; set; }
        public virtual bool DoNotShow { get; }
        [System.ComponentModel.CategoryAttribute("RefactoringPage")]
        [System.ComponentModel.DefaultValueAttribute("")]
        [System.ComponentModel.LocalizableAttribute(true)]
        public string Title { get; set; }
        [System.ComponentModel.BrowsableAttribute(false)]
        public virtual JetBrains.UI.CrossFramework.EitherControl View { get; }
        public virtual JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage Commit(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
        public virtual bool Initialize(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
        public virtual bool RefreshContents(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
    }
}
namespace JetBrains.ReSharper.I18n.Services.UI.ResourceInplaceEditor
{
    
    public class ResourceEditorForm : System.Windows.Forms.Form
    {
        public ResourceEditorForm([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IResourceItemDeclaredElement resourceItemDeclaredElement) { }
        protected override void Dispose(bool disposing) { }
        protected override void OnFormClosing(System.Windows.Forms.FormClosingEventArgs e) { }
        protected override void OnKeyDown(System.Windows.Forms.KeyEventArgs e) { }
        protected class ResourceEntry
        {
            public ResourceEntry([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Resx.IResourceItem item, [JetBrains.Annotations.CanBeNullAttribute()] string value, [JetBrains.Annotations.CanBeNullAttribute()] string comment, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, [JetBrains.Annotations.NotNullAttribute()] string cultureName) { }
            [JetBrains.Annotations.CanBeNullAttribute()]
            public string Comment { get; set; }
            [JetBrains.Annotations.NotNullAttribute()]
            public string CultureEnglishName { get; }
            [JetBrains.Annotations.NotNullAttribute()]
            public string CultureName { get; }
            public bool IsChanged { get; }
            public bool IsCommentChanged { get; }
            public bool IsValueChanged { get; }
            [JetBrains.Annotations.CanBeNullAttribute()]
            public JetBrains.ReSharper.Psi.Resx.IResourceItem Item { get; }
            [JetBrains.Annotations.CanBeNullAttribute()]
            public string OriginalComment { get; }
            [JetBrains.Annotations.CanBeNullAttribute()]
            public string OriginalValue { get; }
            [JetBrains.Annotations.NotNullAttribute()]
            public JetBrains.ReSharper.Psi.IPsiSourceFile SourceFile { get; set; }
            [JetBrains.Annotations.CanBeNullAttribute()]
            public string Value { get; set; }
            public void ApplyChanges() { }
        }
    }
}
namespace JetBrains.ReSharper.Psi.Resx.Impl
{
    
    public interface IResourceItemSymbolInfo : JetBrains.ReSharper.Psi.Resolve.ISymbolInfo
    {
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Resx.IResourceItem Entry { get; }
    }
    public class ResourceItemSymbolInfo : JetBrains.ReSharper.Psi.Resolve.ISymbolInfo, JetBrains.ReSharper.Psi.Resx.Impl.IResourceItemSymbolInfo
    {
        public ResourceItemSymbolInfo([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Resx.IResourceItem item) { }
        public ResourceItemSymbolInfo([JetBrains.Annotations.NotNullAttribute()] string shortName, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Resx.IResourceItem item) { }
        public ResourceItemSymbolInfo([JetBrains.Annotations.NotNullAttribute()] string shortName, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Resx.IResourceItem item, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution, int level) { }
        public JetBrains.ReSharper.Psi.Resx.IResourceItem Entry { get; }
        public System.Nullable<int> InheritanceLevel { get; }
        public int Level { get; }
        public string ShortName { get; }
        public JetBrains.ReSharper.Psi.IDeclaredElement GetDeclaredElement() { }
        public JetBrains.ReSharper.Psi.Resolve.ISubstitution GetSubstitution() { }
        public JetBrains.ReSharper.Psi.Resolve.ISymbolInfo ReplaceLevel(int level) { }
        public JetBrains.ReSharper.Psi.Resolve.ISymbolInfo ReplaceSubstitution(JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
    }
    public class ResourceItemSymbolTable : JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.SymbolTableBase
    {
        public ResourceItemSymbolTable([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IPsiSourceFile psiSourceFile) { }
        protected virtual JetBrains.ReSharper.Psi.Resolve.ISymbolInfo CreateSymbolInfo(JetBrains.ReSharper.Psi.Resx.IResourceItem item) { }
        public override void ForAllSymbolInfos(System.Action<JetBrains.ReSharper.Psi.Resolve.ISymbolInfo> processor) { }
        public override JetBrains.ReSharper.Psi.Dependencies.ISymbolTableDependencySet GetDependencySet() { }
        public override System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Resolve.ISymbolInfo> GetSymbolInfos(string name) { }
        public override System.Collections.Generic.IEnumerable<string> Names() { }
    }
    public class ReswSymbolTable : JetBrains.ReSharper.Psi.Resx.Impl.ResourceItemSymbolTable
    {
        public ReswSymbolTable([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IPsiSourceFile psiSourceFile) { }
        protected override JetBrains.ReSharper.Psi.Resolve.ISymbolInfo CreateSymbolInfo(JetBrains.ReSharper.Psi.Resx.IResourceItem item) { }
        public override System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Resolve.ISymbolInfo> GetSymbolInfos(string name) { }
        public override System.Collections.Generic.IEnumerable<string> Names() { }
    }
}
namespace JetBrains.ReSharper.Psi.Resx
{
    
    public interface IResourceItem
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.IResourceItemDeclaredElement DeclaredElement { get; }
        int FormatArgs { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        string Name { get; }
        int Offset { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IPsiSourceFile PsiSourceFile { get; }
        JetBrains.DocumentModel.DocumentRange GetNameDocumentRange();
        bool IsValid();
    }
    public interface ISolutionResourceCache : JetBrains.ReSharper.Psi.Caches.ICache
    {
        [JetBrains.Annotations.NotNullAttribute()]
        object SyncObject { get; }
        bool ContainsItems([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IPsiSourceFile psiSourceFile);
        bool ContainsItems([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IPsiSourceFile psiSourceFile, [JetBrains.Annotations.NotNullAttribute()] string name);
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Resx.IResourceItem> EnumerateResourceItems([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IPsiSourceFile psiSourceFile);
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Resx.IResourceItem> EnumerateResourceItems([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IPsiSourceFile psiSourceFile, [JetBrains.Annotations.NotNullAttribute()] string name);
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<JetBrains.ReSharper.Psi.IPsiSourceFile, JetBrains.Util.DataStructures.CompactOneToListMap<string, JetBrains.ReSharper.Psi.Resx.IResourceItem>>> EnumerateResources([JetBrains.Annotations.NotNullAttribute()] string resourceBaseName);
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<JetBrains.ReSharper.Psi.IPsiSourceFile, JetBrains.Util.DataStructures.CompactOneToListMap<string, JetBrains.ReSharper.Psi.Resx.IResourceItem>>> EnumerateResources([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProject project);
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.IPsiSourceFile> GetAllResourceFiles();
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.ICollection<string> GetResourceItemNames([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IPsiSourceFile psiSourceFile);
        bool TryGetMapItemsByHashValue([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IPsiSourceFile psiSourceFile, [JetBrains.Annotations.NotNullAttribute()] out JetBrains.Util.DataStructures.CompactOneToListMap<, > itemsByHashValue);
        bool TryGetMapItemsByName([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IPsiSourceFile psiSourceFile, [JetBrains.Annotations.NotNullAttribute()] out JetBrains.Util.DataStructures.CompactOneToListMap<, > itemsByName);
    }
    public abstract class SolutionResourceManager
    {
        [JetBrains.Annotations.NotNullAttribute()]
        protected readonly JetBrains.ProjectModel.ISolution Solution;
        protected SolutionResourceManager([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ISolution solution) { }
        public abstract JetBrains.ReSharper.Psi.Resx.ISolutionResourceCache ResourceCache { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public abstract System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IPsiSourceFile> GetAvailableResources([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ProjectModel.IProject project, [JetBrains.Annotations.CanBeNullAttribute()] System.Predicate<JetBrains.ReSharper.Psi.IPsiSourceFile> filter = null);
    }
}
namespace JetBrains.ReSharper.Psi.Resx.Services
{
    
    [JetBrains.Application.ShellComponentAttribute()]
    [System.ComponentModel.LocalizableAttribute(false)]
    public class CultureInfoService : System.IDisposable
    {
        public CultureInfoService() { }
        public static JetBrains.ReSharper.Psi.Resx.Services.CultureInfoService Instance { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public System.Globalization.CultureInfo GetBaseCulture([JetBrains.Annotations.NotNullAttribute()] string cultureName) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public System.Globalization.CultureInfo GetCultureInfo([JetBrains.Annotations.NotNullAttribute()] string cultureName) { }
        public string GetEnglishName([JetBrains.Annotations.NotNullAttribute()] string cultureName) { }
        public bool IsCultureName([JetBrains.Annotations.NotNullAttribute()] string name) { }
    }
    public interface IResourceSearchService
    {
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IDeclaredElement> GetResourceAccessors(JetBrains.ReSharper.Psi.IResourceItemDeclaredElement element);
        JetBrains.ReSharper.Psi.Search.ISearchDomain GetSearchDomain(JetBrains.ReSharper.Psi.IResourceItemDeclaredElement element);
    }
    public abstract class ResourceService
    {
        public abstract string GetCultureName(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile);
        [JetBrains.Annotations.NotNullAttribute()]
        public abstract string GetResourceName([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IPsiSourceFile resourceFile);
        [JetBrains.Annotations.NotNullAttribute()]
        public abstract System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IPsiSourceFile> GetResourcesWithAllCultures([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IPsiSourceFile resourceFile);
        [JetBrains.Annotations.NotNullAttribute()]
        public virtual System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.IPsiSourceFile> GetResourcesWithBaseCulture([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IPsiSourceFile resourceFile) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public virtual System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.IPsiSourceFile> GetResourcesWithBaseCultures([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IPsiSourceFile resourceFile) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public abstract System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.IPsiSourceFile> GetResourcesWithCulture([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IPsiSourceFile resourceFile, [JetBrains.Annotations.CanBeNullAttribute()] string cultureName);
        public System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.IPsiSourceFile> GetResourcesWithDefaultCulture([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IPsiSourceFile resourceFile) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public abstract System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.IPsiSourceFile> GetResourcesWithSpecificCultures([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IPsiSourceFile resourceFile);
        public abstract bool IsDefaultCulture([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IPsiSourceFile resourceFile);
    }
    public class static ResourceServiceEx
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Psi.Resx.Services.ResourceService GetResourceService([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.IPsiSourceFile resourceFile) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Psi.Resx.Services.ResourceService GetResourceService([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ProjectModel.IProjectFile resourceFile) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Psi.Resx.Services.ResourceService GetResourceService([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ProjectModel.ISolution solution, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ProjectFileType projectFileType) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.Resx.Services.ResourceService TryGetResourceService([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.IPsiSourceFile resourceFile) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.Resx.Services.ResourceService TryGetResourceService([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ProjectModel.IProjectFile resourceFile) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.Resx.Services.ResourceService TryGetResourceService([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ProjectModel.ISolution solution, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ProjectFileType projectFileType) { }
    }
    public class static WinRTResourceHelper
    {
        public const string DefaultResourceFileName = "Resources";
        public static readonly System.Text.RegularExpressions.Regex FileNameQualifierParser;
        public static readonly System.Text.RegularExpressions.Regex FolderNameQualifierParser;
        public const string PackageAppxManifest = "Package.appxmanifest";
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.IDictionary<string, JetBrains.ProjectModel.IProject> GetPackagesMap([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProject project) { }
        public static string GetResourceFileFullName(JetBrains.ReSharper.Psi.IPsiSourceFile projectFile) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.Util.OneToSetMap<string, string> GetResourceFileQualifiers([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IPsiSourceFile file) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetResourcesSymbolTable([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProject project) { }
        public static bool IsDefaultResourceFile([JetBrains.Annotations.NotNullAttribute()] string resourceFileName) { }
        public static bool IsWindowsStorePackage([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProject project) { }
        public static System.Collections.Generic.List<JetBrains.ReSharper.Psi.DeclaredElementInstance> ResolveResource<T>(System.Collections.Generic.IList<string> nameParts, JetBrains.ProjectModel.IProject currentProject)
            where T :  class, JetBrains.ReSharper.Psi.IResourceItemDeclaredElement { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.IPsiSourceFile> ResolveResourceFiles([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProject project, [JetBrains.Annotations.NotNullAttribute()] string resourceFullName) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IPsiSourceFile> ResolveResourceFilesInProject(JetBrains.ProjectModel.IProject project, string resourceFileName) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.DeclaredElementInstance<T>> ResolveResourceItem<T>(System.Collections.Generic.IDictionary<string, JetBrains.ProjectModel.IProject> packagesMap, string packageName, string resourceFileName, string resourceName)
            where T :  class, JetBrains.ReSharper.Psi.IResourceItemDeclaredElement { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.DeclaredElementInstance<T>> ResolveResourceItem<T>([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProject project, string resourceFileName, string resourceName)
            where T :  class, JetBrains.ReSharper.Psi.IResourceItemDeclaredElement { }
    }
    public abstract class WinRTResourceServiceBase : JetBrains.ReSharper.Psi.Resx.Services.ResourceService
    {
        public override string GetCultureName(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        public override string GetResourceName(JetBrains.ReSharper.Psi.IPsiSourceFile resourceFile) { }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IPsiSourceFile> GetResourcesWithAllCultures(JetBrains.ReSharper.Psi.IPsiSourceFile resourceFile) { }
        public override System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.IPsiSourceFile> GetResourcesWithCulture(JetBrains.ReSharper.Psi.IPsiSourceFile resourceFile, string cultureName) { }
        public override System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.IPsiSourceFile> GetResourcesWithSpecificCultures(JetBrains.ReSharper.Psi.IPsiSourceFile resourceFile) { }
        public override bool IsDefaultCulture(JetBrains.ReSharper.Psi.IPsiSourceFile resourceFile) { }
    }
}
namespace JetBrains.ReSharper.Psi.Resx.Utils
{
    
    public class static ResourceCultureEx
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static string GetCultureName([JetBrains.Annotations.CanBeNullAttribute()] this JetBrains.ProjectModel.IProjectFile projectFile) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static string GetCultureName([JetBrains.Annotations.CanBeNullAttribute()] this JetBrains.ReSharper.Psi.IPsiSourceFile psiSourceFile) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static string GetNameWithoutCulture([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.IPsiSourceFile projectFile) { }
        public static bool IsDefaultCulture([JetBrains.Annotations.CanBeNullAttribute()] this JetBrains.ReSharper.Psi.IPsiSourceFile projectFile) { }
    }
}