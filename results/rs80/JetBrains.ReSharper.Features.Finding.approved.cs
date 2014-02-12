[assembly: JetBrains.ActionManagement.ActionsXmlAttribute("JetBrains.ReSharper.Features.Finding.resources.Actions.xml")]
[assembly: JetBrains.TextControl.DocumentMarkup.RegisterHighlighterAttribute("ReSharper Hyperlink", "{4904DF11-AC34-4226-9C64-9D4A4D047FBA}", EffectColor="Blue", EffectType=JetBrains.TextControl.DocumentMarkup.EffectType.SOLID_UNDERLINE, FontStyle=System.Drawing.FontStyle.Regular | System.Drawing.FontStyle.Underline, ForegroundColor="Blue", Layer=5001, VSPriority=10002)]
[assembly: JetBrains.UI.Icons.CompiledIcons.CompiledIconsPackAttribute(IconNames=new string[] {
        "SearchOptionsPage"}, IconPackResourceIdentification="JetBrains.ReSharper.Features.Finding;component/resources/FeaturesFindingIcons/The" +
    "medIcons.FeaturesFinding.Generated.Xaml")]
[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]
[assembly: System.Windows.Markup.XmlnsDefinitionAttribute("urn:shemas-jetbrains-com:ui-application-icons-features-finding", "JetBrains.ReSharper.Features.Finding.Resources")]

namespace JetBrains.ReSharper.Features.Finding.ExecutionHosting
{
    
    public class DefaultNavigationExecutionHost : JetBrains.ReSharper.Features.Common.Occurences.ExecutionHosting.INavigationExecutionHost
    {
        public static JetBrains.ReSharper.Features.Common.Occurences.ExecutionHosting.INavigationExecutionHost Instance { get; }
        public void ExecuteCandidates(JetBrains.Application.DataContext.IDataContext dataContext, bool promoteDeclaredElement, System.Collections.Generic.ICollection<JetBrains.Util.JetTuple<JetBrains.ReSharper.Psi.IDeclaredElement, JetBrains.ReSharper.Psi.Services.CandidatesUtil.DeclaredElementExecutor>> elementExecutionPairs) { }
        public void ExecuteWithDeclaredElements(JetBrains.Application.DataContext.IDataContext dataContext, bool promoteDeclaredElement, System.Collections.Generic.ICollection<JetBrains.Util.JetTuple<JetBrains.ReSharper.Psi.IDeclaredElement, JetBrains.ReSharper.Psi.Services.CandidatesUtil.DeclaredElementExecutor>> candidates, JetBrains.ReSharper.Psi.Services.CandidatesUtil.MultiplyDeclaredElementExecutor multipleExecutor) { }
        public JetBrains.ReSharper.Feature.Services.Navigation.AdvancedSearchingInfo ExecuteWithDialog(JetBrains.Application.DataContext.IDataContext dataContext, JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
        public bool ProcessImmediateResult(JetBrains.Application.DataContext.IDataContext context, System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.Search.IOccurence> results) { }
        public bool ProcessImmediateResultHierarchy(JetBrains.Application.DataContext.IDataContext context, System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.Search.IOccurence> results) { }
        public bool ProcessImmediateResultHighlightUsages(JetBrains.Application.DataContext.IDataContext context, System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.Search.IOccurence> results) { }
        public void ShowContextPopupMenu<TDescriptor>(JetBrains.Application.DataContext.IDataContext context, System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.Search.IOccurence> occurences, System.Func<TDescriptor> descriptorBuilder, System.Nullable<JetBrains.ReSharper.Feature.Services.Occurences.OccurencePresentationOptions> options, bool skipMenuIfSingleEnabled, string title)
            where TDescriptor : JetBrains.ReSharper.Features.Common.Occurences.OccurenceBrowserDescriptor { }
        public void ShowFindResults<TDescriptor>(JetBrains.Application.DataContext.IDataContext context, System.Func<TDescriptor> func)
            where TDescriptor : JetBrains.ReSharper.Features.Common.Occurences.OccurenceBrowserDescriptor { }
        public void ShowGlobalPopupMenu(JetBrains.ProjectModel.ISolution solution, System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.Search.IOccurence> occurences, bool activate, JetBrains.UI.PopupWindowManager.PopupWindowContextSource windowContext, System.Func<JetBrains.ReSharper.Features.Common.Occurences.OccurenceBrowserDescriptor> descriptorBuilder, System.Nullable<JetBrains.ReSharper.Feature.Services.Occurences.OccurencePresentationOptions> options, bool skipMenuIfSingleEnabled, string title) { }
    }
}
namespace JetBrains.ReSharper.Features.Finding.FindDeclarations
{
    
    [JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextNavigationProviderAttribute()]
    public class GotoTypeDeclarationProvider : JetBrains.ReSharper.Features.Finding.NavigateFromHere.RequestContextSearchProvider<JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.BaseSearches.TypeDeclarationContextSearch, JetBrains.ReSharper.Features.Finding.FindDeclarations.SearchDeclarationsDescriptor, JetBrains.ReSharper.Feature.Services.Search.SearchRequests.SearchDeclarationsRequest>, JetBrains.ReSharper.Feature.Services.ActionsMenu.IWorkflowProvider<JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextNavigation, JetBrains.ReSharper.Feature.Services.ContextNavigation.NavigationActionGroup>, JetBrains.ReSharper.Feature.Services.ContextNavigation.INavigateFromHereProvider
    {
        public GotoTypeDeclarationProvider(JetBrains.ReSharper.Feature.Services.IFeaturePartsContainer manager) { }
        protected override JetBrains.ReSharper.Features.Finding.FindDeclarations.SearchDeclarationsDescriptor CreateSearchDescriptor(JetBrains.ReSharper.Feature.Services.Search.SearchRequests.SearchDeclarationsRequest request, System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.Search.IOccurence> results) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextNavigation> CreateWorkflow(JetBrains.Application.DataContext.IDataContext dataContext) { }
        protected override System.Nullable<JetBrains.ReSharper.Feature.Services.Occurences.OccurencePresentationOptions> ProvideFeatureSpecificPresentationOptions() { }
        protected override void ShowResults(JetBrains.Application.DataContext.IDataContext context, JetBrains.ReSharper.Features.Common.Occurences.ExecutionHosting.INavigationExecutionHost host, string title, System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.Search.IOccurence> occurences, System.Func<JetBrains.ReSharper.Features.Finding.FindDeclarations.SearchDeclarationsDescriptor> descriptorBuilder, System.Collections.Generic.IComparer<JetBrains.ReSharper.Feature.Services.Search.IOccurence> customSearchRequestComparer) { }
    }
    public class SearchDeclarationsDescriptor : JetBrains.ReSharper.Features.Finding.Search.SearchDescriptor
    {
        public SearchDeclarationsDescriptor(JetBrains.ReSharper.Feature.Services.Search.SearchRequests.SearchDeclarationsRequest request, System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.Search.IOccurence> results) { }
        public override string GetResultsTitle(JetBrains.ReSharper.Features.Common.Occurences.OccurenceSection section) { }
    }
    public class SearchExtensionMethodsDescriptor : JetBrains.ReSharper.Features.Finding.Search.SearchDescriptor
    {
        public SearchExtensionMethodsDescriptor(JetBrains.ReSharper.Feature.Services.Search.SearchRequests.ExtensionMethodsSearchRequest request, System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.Search.IOccurence> occurences) { }
        public override string GetResultsTitle(JetBrains.ReSharper.Features.Common.Occurences.OccurenceSection section) { }
    }
}
namespace JetBrains.ReSharper.Features.Finding.FindDependentCode
{
    
    [JetBrains.ActionManagement.ActionHandlerAttribute()]
    public class FindDependentCodeAction : JetBrains.ReSharper.Features.Finding.NavigateFromHere.ContextSearchActionBase<JetBrains.ReSharper.Features.Finding.FindDependentCode.FindDependentCodeProvider> { }
    [JetBrains.Application.ShellComponentAttribute()]
    public class FindDependentCodeProvider : JetBrains.ReSharper.Features.Finding.NavigateFromHere.RequestContextSearchProvider<JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.IRequestContextSearch<JetBrains.ReSharper.Feature.Services.Search.SearchRequests.SearchRequest>, JetBrains.ReSharper.Features.Finding.FindDependentCode.ReferencedCodeUsagesDescriptor, JetBrains.ReSharper.Feature.Services.Search.SearchRequests.SearchRequest>
    {
        public FindDependentCodeProvider(JetBrains.ReSharper.Feature.Services.IFeaturePartsContainer manager) { }
        protected override JetBrains.ReSharper.Features.Finding.FindDependentCode.ReferencedCodeUsagesDescriptor CreateSearchDescriptor(JetBrains.ReSharper.Feature.Services.Search.SearchRequests.SearchRequest searchRequest, System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.Search.IOccurence> results) { }
        public override System.Action GetSearchesExecution(JetBrains.Application.DataContext.IDataContext dataContext, JetBrains.ReSharper.Features.Common.Occurences.ExecutionHosting.INavigationExecutionHost host) { }
    }
    [JetBrains.ReSharper.Psi.ShellFeaturePartAttribute()]
    public class FindUsagesOfModuleReferenceContextSearch : JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.BaseSearches.FindUsagesContextSearch
    {
        protected override JetBrains.ReSharper.Feature.Services.Search.SearchRequests.SearchUsagesRequest CreateSearchRequest(JetBrains.Application.DataContext.IDataContext dataContext, JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, JetBrains.ReSharper.Psi.IDeclaredElement initialTarget) { }
        protected override bool IsAvailableInternal(JetBrains.Application.DataContext.IDataContext dataContext) { }
        public override bool IsContextApplicable(JetBrains.Application.DataContext.IDataContext dataContext) { }
    }
    public class ReferencedCodeUsagesDescriptor : JetBrains.ReSharper.Features.Finding.FindUsages.SearchUsagesDescriptor
    {
        public ReferencedCodeUsagesDescriptor(JetBrains.ReSharper.Feature.Services.Search.SearchRequests.SearchRequest request, System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.Search.IOccurence> results) { }
        public override string ActionBarID { get; }
        protected override System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.Occurences.OccurenceKindProviders.OccurenceKind> GetAllOccurenceKinds() { }
        protected override string GetScopeTitle(JetBrains.ReSharper.Features.Finding.FindUsages.Scope scope) { }
    }
    public class SearchCodeDependentOnReferenceRequest : JetBrains.ReSharper.Feature.Services.Search.SearchRequests.SearchUsagesRequest
    {
        public SearchCodeDependentOnReferenceRequest(System.Collections.Generic.List<JetBrains.ProjectModel.IProjectToModuleReference> projectToModuleReferences, JetBrains.ProjectModel.ISolution solution) { }
        public override System.Collections.ICollection SearchTargets { get; }
        public override JetBrains.ProjectModel.ISolution Solution { get; }
        public override string Title { get; }
        public override System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.Search.IOccurence> Search(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
    }
    public class SearchDependentCodeProjectRequest : JetBrains.ReSharper.Feature.Services.Search.SearchRequests.SearchRequest
    {
        public SearchDependentCodeProjectRequest(JetBrains.ProjectModel.IProject project) { }
        public override System.Collections.ICollection SearchTargets { get; }
        public override JetBrains.ProjectModel.ISolution Solution { get; }
        public override string Title { get; }
        public override System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.Search.IOccurence> Search(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
    }
}
namespace JetBrains.ReSharper.Features.Finding.FindHierarchy
{
    
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "GotoBase"})]
    public class GotoBaseAction : JetBrains.ReSharper.Features.Finding.NavigateFromHere.ContextNavigationActionBase<JetBrains.ReSharper.Features.Finding.FindHierarchy.INavigateToBaseProvider>
    {
        public const string GOTO_BASE_ACTION_ID = "GotoBase";
    }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "GotoInheritors"})]
    public class GotoInheritorsAction : JetBrains.ReSharper.Features.Finding.NavigateFromHere.ContextNavigationActionBase<JetBrains.ReSharper.Features.Finding.FindHierarchy.IGotoInheritorsProvider>
    {
        public const string GOTO_INHERITORS_ACTION_ID = "GotoInheritors";
    }
    [JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextNavigationProviderAttribute()]
    public class GotoInheritorsProvider : JetBrains.ReSharper.Features.Finding.FindHierarchy.HierarchyProviderBase<JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.IInheritorsContextSearch, JetBrains.ReSharper.Features.Finding.Search.SearchDescriptor, JetBrains.ReSharper.Feature.Services.Search.SearchRequests.SearchRequest>, JetBrains.ReSharper.Feature.Services.ActionsMenu.IWorkflowProvider<JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextNavigation, JetBrains.ReSharper.Feature.Services.ContextNavigation.NavigationActionGroup>, JetBrains.ReSharper.Feature.Services.ContextNavigation.INavigateFromHereProvider, JetBrains.ReSharper.Features.Finding.FindHierarchy.IGotoInheritorsProvider
    {
        public GotoInheritorsProvider(JetBrains.ReSharper.Feature.Services.IFeaturePartsContainer manager) { }
        protected override JetBrains.ReSharper.Features.Finding.Search.SearchDescriptor CreateSearchDescriptor(JetBrains.ReSharper.Feature.Services.Search.SearchRequests.SearchRequest searchRequest, System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.Search.IOccurence> occurences) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextNavigation> CreateWorkflow(JetBrains.Application.DataContext.IDataContext dataContext) { }
        protected override string GetFeatureID() { }
    }
    public abstract class HierarchyProviderBase<TContextSearch, TDescriptor, TSearchRequest> : JetBrains.ReSharper.Features.Finding.NavigateFromHere.RequestContextSearchProvider<TContextSearch, TDescriptor, TSearchRequest>
        where TContextSearch :  class, JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.IRequestContextSearch<>
        where TDescriptor : JetBrains.ReSharper.Features.Finding.Search.SearchDescriptor
        where TSearchRequest : JetBrains.ReSharper.Feature.Services.Search.SearchRequests.SearchRequest
    {
        protected HierarchyProviderBase(JetBrains.ReSharper.Feature.Services.IFeaturePartsContainer manager) { }
        protected override bool ProcessImmediateResult(JetBrains.Application.DataContext.IDataContext context, System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.Search.IOccurence> results, JetBrains.ReSharper.Features.Common.Occurences.ExecutionHosting.INavigationExecutionHost host) { }
        protected override System.Nullable<JetBrains.ReSharper.Feature.Services.Occurences.OccurencePresentationOptions> ProvideFeatureSpecificPresentationOptions() { }
        protected override void ShowResults(JetBrains.Application.DataContext.IDataContext context, JetBrains.ReSharper.Features.Common.Occurences.ExecutionHosting.INavigationExecutionHost host, string title, System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.Search.IOccurence> occurences, System.Func<TDescriptor> descriptorBuilder, System.Collections.Generic.IComparer<JetBrains.ReSharper.Feature.Services.Search.IOccurence> customSearchRequestComparer) { }
    }
    public interface IFindUsagesProvider : JetBrains.ReSharper.Feature.Services.ActionsMenu.IWorkflowProvider<JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextNavigation, JetBrains.ReSharper.Feature.Services.ContextNavigation.NavigationActionGroup>, JetBrains.ReSharper.Feature.Services.ContextNavigation.INavigateFromHereProvider, JetBrains.ReSharper.Features.Finding.NavigateFromHere.IContextSearchProvider { }
    public interface IGotoImplementationsProvider : JetBrains.ReSharper.Feature.Services.ActionsMenu.IWorkflowProvider<JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextNavigation, JetBrains.ReSharper.Feature.Services.ContextNavigation.NavigationActionGroup>, JetBrains.ReSharper.Feature.Services.ContextNavigation.INavigateFromHereProvider { }
    public interface IGotoInheritorsProvider : JetBrains.ReSharper.Feature.Services.ActionsMenu.IWorkflowProvider<JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextNavigation, JetBrains.ReSharper.Feature.Services.ContextNavigation.NavigationActionGroup>, JetBrains.ReSharper.Feature.Services.ContextNavigation.INavigateFromHereProvider { }
    public interface IGotoUsagesProvider : JetBrains.ReSharper.Feature.Services.ActionsMenu.IWorkflowProvider<JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextNavigation, JetBrains.ReSharper.Feature.Services.ContextNavigation.NavigationActionGroup>, JetBrains.ReSharper.Feature.Services.ContextNavigation.INavigateFromHereProvider { }
    public interface INavigateToBaseProvider : JetBrains.ReSharper.Feature.Services.ActionsMenu.IWorkflowProvider<JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextNavigation, JetBrains.ReSharper.Feature.Services.ContextNavigation.NavigationActionGroup>, JetBrains.ReSharper.Feature.Services.ContextNavigation.INavigateFromHereProvider { }
    public class SearchBasesDescriptor : JetBrains.ReSharper.Features.Finding.Search.SearchDescriptor
    {
        public SearchBasesDescriptor(JetBrains.ReSharper.Feature.Services.Search.SearchRequests.SearchBasesRequest request, System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.Search.IOccurence> results) { }
        public override string GetResultsTitle(JetBrains.ReSharper.Features.Common.Occurences.OccurenceSection section) { }
    }
    public class SearchInheritorsDescriptor : JetBrains.ReSharper.Features.Finding.Search.SearchDescriptor
    {
        public SearchInheritorsDescriptor(JetBrains.ReSharper.Feature.Services.Search.SearchRequests.SearchInheritorsRequest request, System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.Search.IOccurence> results) { }
        public override string GetResultsTitle(JetBrains.ReSharper.Features.Common.Occurences.OccurenceSection section) { }
    }
}
namespace JetBrains.ReSharper.Features.Finding.FindImplementations
{
    
    public class SearchImplementationsDescriptor : JetBrains.ReSharper.Features.Finding.FindDeclarations.SearchDeclarationsDescriptor
    {
        public SearchImplementationsDescriptor(JetBrains.ReSharper.Feature.Services.Search.SearchRequests.SearchImplementationsRequest request, System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.Search.IOccurence> results) { }
        public override string GetResultsTitle(JetBrains.ReSharper.Features.Common.Occurences.OccurenceSection section) { }
    }
}
namespace JetBrains.ReSharper.Features.Finding.FindReferencedCode
{
    
    public class FindReferencedCodeDescriptor : JetBrains.ReSharper.Features.Common.Occurences.OccurenceBrowserDescriptor
    {
        public FindReferencedCodeDescriptor(JetBrains.ReSharper.Feature.Services.Search.SearchRequests.SearchRequest request) { }
        public FindReferencedCodeDescriptor(JetBrains.ReSharper.Feature.Services.Search.SearchRequests.SearchRequest request, System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.Search.IOccurence> results) { }
        public override string ActionBarID { get; }
        protected override int DefaultGroupingIndex { get; set; }
        public override JetBrains.TreeModels.TreeModel Model { get; }
        public JetBrains.TreeModels.TreeModel TargetModel { get; }
        public void Search() { }
        protected override void SetResults(System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.Search.IOccurence> items, JetBrains.Application.Progress.IProgressIndicator indicator = null, bool mergeItems = True) { }
    }
    [JetBrains.ReSharper.Psi.ShellFeaturePartAttribute()]
    public class FindReferencedCodeGroupingProvider : JetBrains.ReSharper.Features.Common.Occurences.OccurenceBrowserGroupingProvider
    {
        public override System.Collections.Generic.ICollection<JetBrains.TreeModels.TreeModelGrouping<JetBrains.ReSharper.Feature.Services.Search.IOccurence>> GetGroupings(JetBrains.IDE.TreeBrowser.TreeModelBrowserDescriptorBase descriptor) { }
        public override bool IsApplicable(JetBrains.IDE.TreeBrowser.TreeModelBrowserDescriptorBase descriptor) { }
        protected class DependencyGroupProviderBase
        {
            protected static JetBrains.ReSharper.Psi.IClrDeclaredElement GetReferencedElement(JetBrains.ReSharper.Feature.Services.Search.IOccurence occurence) { }
        }
        protected class DependencyModuleGroupProvider : JetBrains.ReSharper.Features.Finding.FindReferencedCode.FindReferencedCodeGroupingProvider.DependencyGroupProviderBase, JetBrains.TreeModels.ITreeGroupProvider<JetBrains.ReSharper.Feature.Services.Search.IOccurence>
        {
            public object ExtractGroupObject(JetBrains.ReSharper.Feature.Services.Search.IOccurence item) { }
        }
        protected class DependencyNamespaceGroupProvider : JetBrains.ReSharper.Features.Finding.FindReferencedCode.FindReferencedCodeGroupingProvider.DependencyGroupProviderBase, JetBrains.TreeModels.ITreeGroupProvider<JetBrains.ReSharper.Feature.Services.Search.IOccurence>
        {
            public object ExtractGroupObject(JetBrains.ReSharper.Feature.Services.Search.IOccurence item) { }
        }
        protected class DependencyTypeElementGroupProvider : JetBrains.ReSharper.Features.Finding.FindReferencedCode.FindReferencedCodeGroupingProvider.DependencyGroupProviderBase, JetBrains.TreeModels.ITreeGroupProvider<JetBrains.ReSharper.Feature.Services.Search.IOccurence>
        {
            public object ExtractGroupObject(JetBrains.ReSharper.Feature.Services.Search.IOccurence item) { }
        }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class FindReferencedCodeProvider : JetBrains.ReSharper.Features.Finding.NavigateFromHere.RequestContextSearchProvider<JetBrains.ReSharper.Feature.Services.Navigation.IReferencedCodeContextSearch, JetBrains.ReSharper.Features.Finding.FindReferencedCode.FindReferencedCodeDescriptor, JetBrains.ReSharper.Feature.Services.Search.SearchRequests.SearchReferencedCodeRequest>, JetBrains.ReSharper.Feature.Services.ActionsMenu.IWorkflowProvider<JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextNavigation, JetBrains.ReSharper.Feature.Services.ContextNavigation.NavigationActionGroup>, JetBrains.ReSharper.Feature.Services.ContextNavigation.INavigateFromHereProvider
    {
        public FindReferencedCodeProvider(JetBrains.ReSharper.Feature.Services.IFeaturePartsContainer manager) { }
        protected override JetBrains.ReSharper.Features.Finding.FindReferencedCode.FindReferencedCodeDescriptor CreateSearchDescriptor(JetBrains.ReSharper.Feature.Services.Search.SearchRequests.SearchReferencedCodeRequest request, System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.Search.IOccurence> results) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextNavigation> CreateWorkflow(JetBrains.Application.DataContext.IDataContext dataContext) { }
    }
    [JetBrains.ReSharper.Psi.ShellFeaturePartAttribute()]
    public class FindReferencedCodeSectionProvider : JetBrains.ReSharper.Features.Common.Occurences.OccurenceSectionProvider
    {
        public override System.Collections.Generic.ICollection<JetBrains.ReSharper.Features.Common.Occurences.GroupingSectionId> GetGroupSectionId(JetBrains.ReSharper.Feature.Services.Search.IOccurence occurence, JetBrains.ReSharper.Features.Common.Occurences.OccurenceBrowserDescriptor descriptor) { }
        public override System.Collections.Generic.ICollection<JetBrains.TreeModels.TreeSection> GetTreeSections(JetBrains.ReSharper.Features.Common.Occurences.OccurenceBrowserDescriptor descriptor) { }
        public override bool IsApplicable(JetBrains.ReSharper.Features.Common.Occurences.OccurenceBrowserDescriptor descriptor) { }
    }
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(JetBrains.UI.UserInterfaceSettings), "Find referenced code view settings")]
    public class FindReferencedCodeViewSettings
    {
        [JetBrains.Application.Settings.SettingsEntryAttribute(5, "Group by")]
        public int GroupingIndex;
    }
    [JetBrains.Application.Configuration.Upgrade.GlobalSettingsUpgraderAttribute()]
    public class FindReferencedCodeViewSettingsUpgrader : JetBrains.Application.Configuration.SettingTablesUpgrader
    {
        public FindReferencedCodeViewSettingsUpgrader(JetBrains.Application.Env.RunsProducts.ProductConfigurations productConfigurations) { }
        protected override void DoUpgrade(JetBrains.Application.Configuration.IComponentSettingsProvider legacySettingsProvider, JetBrains.Application.Settings.IContextBoundSettingsStore boundSettingsStore, JetBrains.DataFlow.Lifetime upgradeLifetime, JetBrains.Application.Configuration.SettingsTableBase workspaceSettingsTable, JetBrains.Application.Configuration.SettingsTableBase globalSettingsTable) { }
    }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "FindReferencedCode.Update"})]
    public class ReferencedCodeUpdateAction : JetBrains.ActionManagement.IActionHandler
    {
        public void Execute(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.DelegateExecute nextExecute) { }
        public bool Update(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.ActionPresentation presentation, JetBrains.ActionManagement.DelegateUpdate nextUpdate) { }
    }
}
namespace JetBrains.ReSharper.Features.Finding.FindUsages
{
    
    [JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextNavigationProviderAttribute()]
    public class GotoUsagesProvider : JetBrains.ReSharper.Features.Finding.Usages.UsagesContextSearchProviderBase<JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.IFindUsagesContextSearch, JetBrains.ReSharper.Features.Finding.FindUsages.SearchUsagesDescriptor, JetBrains.ReSharper.Feature.Services.Search.SearchRequests.SearchUsagesRequest>, JetBrains.ReSharper.Feature.Services.ActionsMenu.IWorkflowProvider<JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextNavigation, JetBrains.ReSharper.Feature.Services.ContextNavigation.NavigationActionGroup>, JetBrains.ReSharper.Feature.Services.ContextNavigation.INavigateFromHereProvider, JetBrains.ReSharper.Features.Finding.FindHierarchy.IGotoUsagesProvider
    {
        public GotoUsagesProvider(JetBrains.ReSharper.Feature.Services.IFeaturePartsContainer manager) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextNavigation> CreateWorkflow(JetBrains.Application.DataContext.IDataContext dataContext) { }
        protected override string GetFeatureID() { }
        protected override void ShowResults(JetBrains.Application.DataContext.IDataContext context, JetBrains.ReSharper.Features.Common.Occurences.ExecutionHosting.INavigationExecutionHost host, string title, System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.Search.IOccurence> occurences, System.Func<JetBrains.ReSharper.Features.Finding.FindUsages.SearchUsagesDescriptor> descriptorBuilder, System.Collections.Generic.IComparer<JetBrains.ReSharper.Feature.Services.Search.IOccurence> customSearchRequestComparer) { }
    }
    public enum Scope
    {
        Solution = 0,
        Libraries = 1,
        SolutionAndLibraries = 2,
    }
    public class SearchSpecialUsagesDescriptor : JetBrains.ReSharper.Features.Finding.FindUsages.SearchUsagesDescriptor
    {
        public SearchSpecialUsagesDescriptor(JetBrains.ReSharper.Feature.Services.Search.SearchRequests.SearchSpecialUsagesRequest request, System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.Search.IOccurence> results) { }
        public JetBrains.ReSharper.Feature.Services.Search.SearchRequests.SearchSpecialUsagesRequest SpecialUsagesRequest { get; }
        public override string GetResultsTitle(JetBrains.ReSharper.Features.Common.Occurences.OccurenceSection section) { }
    }
    public class SearchUsagesDescriptor : JetBrains.ReSharper.Features.Finding.Search.SearchDescriptor
    {
        public SearchUsagesDescriptor(JetBrains.ReSharper.Feature.Services.Search.SearchRequests.SearchRequest request, System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.Search.IOccurence> results) { }
        public override string GetResultsTitle(JetBrains.ReSharper.Features.Common.Occurences.OccurenceSection section) { }
        protected virtual string GetScopeTitle(JetBrains.ReSharper.Features.Finding.FindUsages.Scope scope) { }
    }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "FindUsages.Update"})]
    public class UpdateFindUsagesAction : JetBrains.ActionManagement.IActionHandler
    {
        public void Execute(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.DelegateExecute nextExecute) { }
        public bool Update(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.ActionPresentation presentation, JetBrains.ActionManagement.DelegateUpdate nextUpdate) { }
    }
}
namespace JetBrains.ReSharper.Features.Finding.GoToDeclaration
{
    
    public abstract class DeclarationProviderBase<TContextSearch, TSearchDescriptor, TSearchRequest> : JetBrains.ReSharper.Features.Finding.NavigateFromHere.RequestContextSearchProvider<TContextSearch, TSearchDescriptor, TSearchRequest>, JetBrains.ReSharper.Feature.Services.ActionsMenu.IWorkflowProvider<JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextNavigation, JetBrains.ReSharper.Feature.Services.ContextNavigation.NavigationActionGroup>, JetBrains.ReSharper.Feature.Services.ContextNavigation.INavigateFromHereProvider
        where TContextSearch :  class, JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.IRequestContextSearch<>
        where TSearchDescriptor : JetBrains.ReSharper.Features.Finding.FindDeclarations.SearchDeclarationsDescriptor
        where TSearchRequest : JetBrains.ReSharper.Feature.Services.Search.SearchRequests.SearchDeclarationsRequest
    {
        protected DeclarationProviderBase(JetBrains.ReSharper.Feature.Services.IFeaturePartsContainer manager) { }
        protected virtual string ActionId { get; }
        protected abstract string NavigationMenuTitle { get; }
        protected virtual string ShortActionId { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextNavigation> CreateWorkflow(JetBrains.Application.DataContext.IDataContext dataContext) { }
        protected override System.Nullable<JetBrains.ReSharper.Feature.Services.Occurences.OccurencePresentationOptions> ProvideFeatureSpecificPresentationOptions() { }
        protected override void ShowResults(JetBrains.Application.DataContext.IDataContext context, JetBrains.ReSharper.Features.Common.Occurences.ExecutionHosting.INavigationExecutionHost host, string title, System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.Search.IOccurence> occurences, System.Func<TSearchDescriptor> descriptorBuilder, System.Collections.Generic.IComparer<JetBrains.ReSharper.Feature.Services.Search.IOccurence> customSearchRequestComparer) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class DeclaredElementNavigationService : JetBrains.ReSharper.Feature.Services.Navigation.IDeclaredElementNavigationService
    {
        public DeclaredElementNavigationService(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.Feature.Services.SolutionFeaturePartsContainer solutionFeaturePartsContainer, JetBrains.UI.Application.IUIApplication environment) { }
        public void ExecuteCandidates(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IDeclaredElement> candidates, JetBrains.UI.PopupWindowManager.PopupWindowContextSource source, bool transferFocus) { }
        public virtual void Navigate(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, JetBrains.UI.PopupWindowManager.PopupWindowContextSource windowContext, bool transferFocus, System.Nullable<JetBrains.ReSharper.Feature.Services.Occurences.OccurencePresentationOptions> options = null, JetBrains.IDE.TabOptions tabOptions = 2) { }
    }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "GotoDeclaration",
            "GotoDeclarationShort"})]
    public class GotoDeclarationAction : JetBrains.ReSharper.Features.Finding.NavigateFromHere.ContextNavigationActionBase<JetBrains.ReSharper.Features.Finding.GoToDeclaration.IGotoDeclarationProvider>
    {
        public const string ACTION_ID = "GotoDeclaration";
        public const string SHORT_ACTION_ID = "GotoDeclarationShort";
    }
    [JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextNavigationProviderAttribute()]
    public class GotoDeclarationProvider : JetBrains.ReSharper.Features.Finding.GoToDeclaration.DeclarationProviderBase<JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.IDeclarationSearch, JetBrains.ReSharper.Features.Finding.FindDeclarations.SearchDeclarationsDescriptor, JetBrains.ReSharper.Feature.Services.Search.SearchRequests.SearchDeclarationsRequest>, JetBrains.ReSharper.Feature.Services.ActionsMenu.IWorkflowProvider<JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextNavigation, JetBrains.ReSharper.Feature.Services.ContextNavigation.NavigationActionGroup>, JetBrains.ReSharper.Feature.Services.ContextNavigation.INavigateFromHereProvider, JetBrains.ReSharper.Features.Finding.GoToDeclaration.IGotoDeclarationProvider, JetBrains.ReSharper.Features.Finding.NavigateFromHere.IContextSearchProvider
    {
        public GotoDeclarationProvider(JetBrains.ReSharper.Feature.Services.IFeaturePartsContainer manager) { }
        protected override string ActionId { get; }
        protected override string NavigationMenuTitle { get; }
        protected override string ShortActionId { get; }
        protected override JetBrains.ReSharper.Features.Finding.FindDeclarations.SearchDeclarationsDescriptor CreateSearchDescriptor(JetBrains.ReSharper.Feature.Services.Search.SearchRequests.SearchDeclarationsRequest searchRequest, System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.Search.IOccurence> occurences) { }
    }
    [JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextNavigationProviderAttribute()]
    public class GotoModuleReferenceProvider : JetBrains.ReSharper.Feature.Services.ActionsMenu.IWorkflowProvider<JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextNavigation, JetBrains.ReSharper.Feature.Services.ContextNavigation.NavigationActionGroup>, JetBrains.ReSharper.Feature.Services.ContextNavigation.INavigateFromHereProvider, JetBrains.ReSharper.Features.Finding.GoToDeclaration.IGotoDeclarationProvider, JetBrains.ReSharper.Features.Finding.NavigateFromHere.IContextSearchProvider
    {
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextNavigation> CreateWorkflow(JetBrains.Application.DataContext.IDataContext dataContext) { }
        public System.Action GetSearchesExecution(JetBrains.Application.DataContext.IDataContext dataContext, JetBrains.ReSharper.Features.Common.Occurences.ExecutionHosting.INavigationExecutionHost host) { }
    }
    public interface IDeclaredElementNavigator
    {
        bool IsApplicable(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement);
        void Navigate(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, JetBrains.UI.PopupWindowManager.PopupWindowContextSource windowContext, bool transferFocus, System.Nullable<JetBrains.ReSharper.Feature.Services.Occurences.OccurencePresentationOptions> options = null);
    }
    public interface IGotoDeclarationProvider : JetBrains.ReSharper.Feature.Services.ActionsMenu.IWorkflowProvider<JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextNavigation, JetBrains.ReSharper.Feature.Services.ContextNavigation.NavigationActionGroup>, JetBrains.ReSharper.Feature.Services.ContextNavigation.INavigateFromHereProvider, JetBrains.ReSharper.Features.Finding.NavigateFromHere.IContextSearchProvider { }
}
namespace JetBrains.ReSharper.Features.Finding.GoToDeclaration.DeclaredElementNavigation
{
    
    [JetBrains.ReSharper.Psi.SolutionFeaturePartAttribute()]
    public class CompiledElementNavigator : JetBrains.ReSharper.Features.Finding.GoToDeclaration.DeclaredElementNavigation.DefaultDeclaredElementNavigator
    {
        public CompiledElementNavigator(JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Feature.Services.IFeaturePartsContainer shellFeaturePartsContainer) { }
        public override bool IsApplicable(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
        public override void Navigate(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, JetBrains.UI.PopupWindowManager.PopupWindowContextSource windowContext, bool transferFocus, System.Nullable<JetBrains.ReSharper.Feature.Services.Occurences.OccurencePresentationOptions> options = null) { }
    }
    [JetBrains.ReSharper.Psi.SolutionFeaturePartAttribute()]
    public class DefaultDeclaredElementNavigator : JetBrains.ReSharper.Features.Finding.GoToDeclaration.IDeclaredElementNavigator
    {
        public DefaultDeclaredElementNavigator(JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Feature.Services.IFeaturePartsContainer shellFeaturePartsContainer) { }
        public virtual bool IsApplicable(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
        public virtual void Navigate(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, JetBrains.UI.PopupWindowManager.PopupWindowContextSource windowContext, bool transferFocus, System.Nullable<JetBrains.ReSharper.Feature.Services.Occurences.OccurencePresentationOptions> options = null) { }
    }
    [JetBrains.ReSharper.Psi.SolutionFeaturePartAttribute()]
    public class PathDeclaredElementNavigator : JetBrains.ReSharper.Features.Finding.GoToDeclaration.DeclaredElementNavigation.DefaultDeclaredElementNavigator
    {
        public PathDeclaredElementNavigator(JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Feature.Services.IFeaturePartsContainer shellFeaturePartsContainer) { }
        public override bool IsApplicable(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
        public override void Navigate(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, JetBrains.UI.PopupWindowManager.PopupWindowContextSource windowContext, bool transferFocus, System.Nullable<JetBrains.ReSharper.Feature.Services.Occurences.OccurencePresentationOptions> options = null) { }
    }
}
namespace JetBrains.ReSharper.Features.Finding.GoToDeclaredElement
{
    
    public abstract class GotoDeclaredElementAction : JetBrains.ReSharper.Features.Finding.GoToDeclaredElement.GotoDeclaredElementActionBase
    {
        public const string DESCRIPTOR_NULL_DIAG = "Go To ... Browser descriptor was not created, though it should be. Probably creat" +
            "ing descriptor and assigning a lifetime for it are not synchronized.";
        protected abstract JetBrains.UI.GotoByName.GotoByNameController CreateController(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.ISolution solution, JetBrains.Application.IShellLocks locks, JetBrains.Application.DataContext.IDataContext context);
        protected virtual void EnableShowInFindResults(JetBrains.UI.GotoByName.GotoByNameController controller, JetBrains.DataFlow.LifetimeDefinition definition, JetBrains.ProjectModel.ISolution solution) { }
        protected override void Execute(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.DataContext.IDataContext context) { }
    }
    public abstract class GotoDeclaredElementActionBase : JetBrains.ActionManagement.IActionHandler
    {
        protected abstract void Execute(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.DataContext.IDataContext context);
    }
    public class GotoDeclaredElementsBrowserDescriptor : JetBrains.ReSharper.Features.Common.Occurences.OccurenceBrowserDescriptor
    {
        public GotoDeclaredElementsBrowserDescriptor(JetBrains.ProjectModel.ISolution solution, string kind, string pattern, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Search.IOccurence> occurences, JetBrains.Application.Progress.IProgressIndicator indicator = null) { }
        public override string ActionBarID { get; }
        public string Kind { get; }
        public override JetBrains.TreeModels.TreeModel Model { get; }
        protected override void SetResults(System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.Search.IOccurence> items, JetBrains.Application.Progress.IProgressIndicator indicator = null, bool mergeItems = True) { }
    }
    [JetBrains.ReSharper.Psi.ShellFeaturePartAttribute()]
    public class GotoDeclaredElementsSectionProvider : JetBrains.ReSharper.Features.Common.Occurences.OccurenceSectionProvider
    {
        public override System.Collections.Generic.ICollection<JetBrains.TreeModels.TreeSection> GetTreeSections(JetBrains.ReSharper.Features.Common.Occurences.OccurenceBrowserDescriptor descriptor) { }
        public override bool IsApplicable(JetBrains.ReSharper.Features.Common.Occurences.OccurenceBrowserDescriptor descriptor) { }
    }
}
namespace JetBrains.ReSharper.Features.Finding.GoToFile
{
    
    [JetBrains.ActionManagement.ActionHandlerAttribute()]
    public class GotoFileAction : JetBrains.ActionManagement.IActionHandler
    {
        protected virtual JetBrains.ReSharper.Features.Finding.GoToFile.GotoFileBrowserDescriptor CreateGotoFileBrowserDescriptor(JetBrains.ProjectModel.ISolution solution, string pattern, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Search.IOccurence> occurences) { }
        public void Execute(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.DelegateExecute nextExecute) { }
        public bool Update(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.ActionPresentation presentation, JetBrains.ActionManagement.DelegateUpdate nextUpdate) { }
    }
    public class GotoFileBrowserDescriptor : JetBrains.ReSharper.Features.Finding.GoToDeclaredElement.GotoDeclaredElementsBrowserDescriptor
    {
        public GotoFileBrowserDescriptor(JetBrains.ProjectModel.ISolution solution, string kind, string pattern, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Search.IOccurence> occurences, JetBrains.Application.Progress.IProgressIndicator indicator = null) { }
    }
    [JetBrains.ReSharper.Psi.ShellFeaturePartAttribute()]
    public class GotoFileBrowserGroupingProvider : JetBrains.ReSharper.Features.Common.Occurences.OccurenceBrowserGroupingProvider
    {
        public override System.Collections.Generic.ICollection<JetBrains.TreeModels.TreeModelGrouping<JetBrains.ReSharper.Feature.Services.Search.IOccurence>> GetGroupings(JetBrains.IDE.TreeBrowser.TreeModelBrowserDescriptorBase descriptor) { }
        public override bool IsApplicable(JetBrains.IDE.TreeBrowser.TreeModelBrowserDescriptorBase descriptor) { }
    }
}
namespace JetBrains.ReSharper.Features.Finding.GoToImplementation
{
    
    [JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextNavigationProviderAttribute()]
    public class GotoImplementationProvider : JetBrains.ReSharper.Features.Finding.GoToDeclaration.DeclarationProviderBase<JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.IImplementationContextSearch, JetBrains.ReSharper.Features.Finding.FindImplementations.SearchImplementationsDescriptor, JetBrains.ReSharper.Feature.Services.Search.SearchRequests.SearchImplementationsRequest>, JetBrains.ReSharper.Feature.Services.ActionsMenu.IWorkflowProvider<JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextNavigation, JetBrains.ReSharper.Feature.Services.ContextNavigation.NavigationActionGroup>, JetBrains.ReSharper.Feature.Services.ContextNavigation.INavigateFromHereProvider, JetBrains.ReSharper.Features.Finding.FindHierarchy.IGotoImplementationsProvider
    {
        public GotoImplementationProvider(JetBrains.ReSharper.Feature.Services.IFeaturePartsContainer manager) { }
        protected override string ActionId { get; }
        protected override string NavigationMenuTitle { get; }
        protected override string ShortActionId { get; }
        protected override JetBrains.ReSharper.Features.Finding.FindImplementations.SearchImplementationsDescriptor CreateSearchDescriptor(JetBrains.ReSharper.Feature.Services.Search.SearchRequests.SearchImplementationsRequest searchRequest, System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.Search.IOccurence> occurences) { }
        protected override System.Nullable<JetBrains.ReSharper.Feature.Services.Occurences.OccurencePresentationOptions> ProvideFeatureSpecificPresentationOptions() { }
    }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "GotoImplementation",
            "GotoImplementationShort"})]
    public class GotoImplementationsAction : JetBrains.ReSharper.Features.Finding.NavigateFromHere.ContextNavigationActionBase<JetBrains.ReSharper.Features.Finding.FindHierarchy.IGotoImplementationsProvider>
    {
        public const string GOTO_IMPLEMENTATION_ACTION_ID = "GotoImplementation";
        public const string GOTO_IMPLEMENTATION_SHORT_ACTION_ID = "GotoImplementationShort";
    }
}
namespace JetBrains.ReSharper.Features.Finding.GoToMember
{
    
    public class GotoFileMemberController : JetBrains.ReSharper.Features.Common.GoToByName.Controllers.GotoControllerBase<JetBrains.ReSharper.Feature.Services.Goto.IGotoFileMemberProvider, JetBrains.ReSharper.Feature.Services.Goto.ChainedProviders.IChainedSearchProvider>
    {
        public static JetBrains.ReSharper.Features.Finding.GoToMember.GotoFileMemberController CreateModel(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.Application.IShellLocks locks, JetBrains.ReSharper.Feature.Services.Search.LibrariesFlag librariesFlag) { }
        protected override System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.Goto.ChainedNavigationItemData> InitScopes(bool isSearchingInLibs) { }
        public override bool IsSpecialString(ref string filterString) { }
        protected System.Collections.Generic.IEnumerable<JetBrains.Util.Pair<JetBrains.ReSharper.Feature.Services.Search.IOccurence, JetBrains.ReSharper.Feature.Services.Goto.MatchingInfo>> SortOccurences(System.Collections.Generic.IEnumerable<JetBrains.Util.Pair<JetBrains.ReSharper.Feature.Services.Search.IOccurence, JetBrains.ReSharper.Feature.Services.Goto.MatchingInfo>> items, string filterString) { }
    }
}
namespace JetBrains.ReSharper.Features.Finding.GoToOccurence
{
    
    [JetBrains.ActionManagement.ActionHandlerAttribute()]
    public class GotoOccurenceAction : JetBrains.ActionManagement.IActionHandler
    {
        public void Execute(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.DelegateExecute nextExecute) { }
        public bool Update(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.ActionPresentation presentation, JetBrains.ActionManagement.DelegateUpdate nextUpdate) { }
    }
}
namespace JetBrains.ReSharper.Features.Finding.GoToRelated
{
    
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "GotoRelatedFiles"})]
    public class GotoRelatedFilesAction : JetBrains.ReSharper.Features.Finding.NavigateFromHere.ContextNavigationActionBase<JetBrains.ReSharper.Features.Finding.GoToRelated.GotoRelatedFilesProvider>
    {
        public const string ACTION_ID = "GotoRelatedFiles";
    }
    [JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextNavigationProviderAttribute()]
    public class GotoRelatedFilesProvider : JetBrains.ReSharper.Feature.Services.ActionsMenu.IWorkflowProvider<JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextNavigation, JetBrains.ReSharper.Feature.Services.ContextNavigation.NavigationActionGroup>, JetBrains.ReSharper.Feature.Services.ContextNavigation.INavigateFromHereProvider
    {
        public GotoRelatedFilesProvider(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.IShellLocks shellLocks, JetBrains.ReSharper.Feature.Services.Navigation.GoToRelated.RelatedFilesManager relatedFilesManager, JetBrains.UI.PopupMenu.JetPopupMenus jetPopupMenus, JetBrains.ProjectModel.ProjectModelElementPresentationService projectModelElementPresentationService, JetBrains.UI.Application.IUIApplication environment) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextNavigation> CreateWorkflow(JetBrains.Application.DataContext.IDataContext dataContext) { }
    }
}
namespace JetBrains.ReSharper.Features.Finding.GoToSymbol
{
    
    [JetBrains.ActionManagement.ActionHandlerAttribute()]
    public class GotoSymbolAction : JetBrains.ActionManagement.IActionHandler
    {
        public void Execute(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.DelegateExecute nextExecute) { }
        public bool Update(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.ActionPresentation presentation, JetBrains.ActionManagement.DelegateUpdate nextUpdate) { }
    }
    public class GotoSymbolBrowserDescriptor : JetBrains.ReSharper.Features.Finding.GoToDeclaredElement.GotoDeclaredElementsBrowserDescriptor
    {
        public GotoSymbolBrowserDescriptor(JetBrains.ProjectModel.ISolution solution, string kind, string pattern, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Search.IOccurence> occurences, JetBrains.Application.Progress.IProgressIndicator indicator = null) { }
    }
}
namespace JetBrains.ReSharper.Features.Finding.GoToType
{
    
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "GotoType"})]
    public class GotoTypeAction : JetBrains.ReSharper.Features.Finding.GoToDeclaredElement.GotoDeclaredElementAction
    {
        public static readonly JetBrains.Application.DataContext.DataConstant<JetBrains.UI.GotoByName.GotoByNameController> GotoController;
        protected override JetBrains.UI.GotoByName.GotoByNameController CreateController(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.ISolution solution, JetBrains.Application.IShellLocks locks, JetBrains.Application.DataContext.IDataContext context) { }
    }
}
namespace JetBrains.ReSharper.Features.Finding.LocateIn
{
    
    public interface IAssemblyExplorerContextSearch : JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.IContextSearch
    {
        void Execute(JetBrains.Application.DataContext.IDataContext dataContext);
    }
    public interface ISolutionExplorerContextSearch : JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.IContextSearch
    {
        void Execute(JetBrains.Application.DataContext.IDataContext dataContext);
    }
    [JetBrains.ActionManagement.ActionHandlerAttribute()]
    public class LocateInAssemblyExplorerAction : JetBrains.ReSharper.Features.Finding.NavigateFromHere.ContextSearchActionBase<JetBrains.ReSharper.Features.Finding.LocateIn.LocateInAssemblyExplorerProvider> { }
    [JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextNavigationProviderAttribute()]
    public class LocateInAssemblyExplorerProvider : JetBrains.ReSharper.Features.Finding.NavigateFromHere.ContextNavigationProviderBase<JetBrains.ReSharper.Features.Finding.LocateIn.IAssemblyExplorerContextSearch>, JetBrains.ReSharper.Feature.Services.ActionsMenu.IWorkflowProvider<JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextNavigation, JetBrains.ReSharper.Feature.Services.ContextNavigation.NavigationActionGroup>, JetBrains.ReSharper.Feature.Services.ContextNavigation.INavigateFromHereProvider
    {
        public LocateInAssemblyExplorerProvider(JetBrains.ReSharper.Feature.Services.IFeaturePartsContainer manager) { }
        protected override JetBrains.ReSharper.Feature.Services.ContextNavigation.NavigationActionGroup ActionGroup { get; }
        protected override void Execute(JetBrains.Application.DataContext.IDataContext dataContext, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Features.Finding.LocateIn.IAssemblyExplorerContextSearch> searches, JetBrains.ReSharper.Features.Common.Occurences.ExecutionHosting.INavigationExecutionHost host) { }
        protected override string GetActionId(JetBrains.Application.DataContext.IDataContext dataContext) { }
        protected override string GetNavigationMenuTitle(JetBrains.Application.DataContext.IDataContext dataContext) { }
    }
    [JetBrains.ActionManagement.ActionHandlerAttribute()]
    public class LocateInSolutionExplorerAction : JetBrains.ReSharper.Features.Finding.NavigateFromHere.ContextSearchActionBase<JetBrains.ReSharper.Features.Finding.LocateIn.LocateInSolutionExplorerProvider> { }
    [JetBrains.ReSharper.Psi.ShellFeaturePartAttribute()]
    public class LocateInSolutionExplorerContextSearch : JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.IContextSearch, JetBrains.ReSharper.Features.Finding.LocateIn.ISolutionExplorerContextSearch
    {
        public virtual void Execute(JetBrains.Application.DataContext.IDataContext dataContext) { }
        public virtual bool IsAvailable(JetBrains.Application.DataContext.IDataContext dataContext) { }
        public virtual bool IsContextApplicable(JetBrains.Application.DataContext.IDataContext dataContext) { }
    }
    [JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextNavigationProviderAttribute()]
    public class LocateInSolutionExplorerProvider : JetBrains.ReSharper.Features.Finding.NavigateFromHere.ContextNavigationProviderBase<JetBrains.ReSharper.Features.Finding.LocateIn.ISolutionExplorerContextSearch>, JetBrains.ReSharper.Feature.Services.ActionsMenu.IWorkflowProvider<JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextNavigation, JetBrains.ReSharper.Feature.Services.ContextNavigation.NavigationActionGroup>, JetBrains.ReSharper.Feature.Services.ContextNavigation.INavigateFromHereProvider
    {
        public LocateInSolutionExplorerProvider(JetBrains.ReSharper.Feature.Services.IFeaturePartsContainer manager) { }
        protected override JetBrains.ReSharper.Feature.Services.ContextNavigation.NavigationActionGroup ActionGroup { get; }
        protected override void Execute(JetBrains.Application.DataContext.IDataContext dataContext, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Features.Finding.LocateIn.ISolutionExplorerContextSearch> searches, JetBrains.ReSharper.Features.Common.Occurences.ExecutionHosting.INavigationExecutionHost host) { }
        protected override string GetActionId(JetBrains.Application.DataContext.IDataContext dataContext) { }
        protected override string GetNavigationMenuTitle(JetBrains.Application.DataContext.IDataContext dataContext) { }
    }
}
namespace JetBrains.ReSharper.Features.Finding.NavigateFromHere.ConflictDeclarations
{
    
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "NavigateToDeclarationConflict"})]
    public class ConflictDeclarationsNavigationAction : JetBrains.ReSharper.Features.Finding.NavigateFromHere.ContextNavigationActionBase<JetBrains.ReSharper.Features.Finding.NavigateFromHere.ConflictDeclarations.IConflictDeclarationsNavigationProvider> { }
    public interface IConflictDeclarationsNavigationProvider : JetBrains.ReSharper.Feature.Services.ActionsMenu.IWorkflowProvider<JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextNavigation, JetBrains.ReSharper.Feature.Services.ContextNavigation.NavigationActionGroup>, JetBrains.ReSharper.Feature.Services.ContextNavigation.INavigateFromHereProvider { }
}
namespace JetBrains.ReSharper.Features.Finding.NavigateFromHere
{
    
    public abstract class ContextNavigationActionBase<TContextNavigationProvider> : JetBrains.ReSharper.Feature.Services.ActionsMenu.ExtensibleAction<TContextNavigationProvider, JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextNavigation, JetBrains.ReSharper.Feature.Services.ContextNavigation.NavigationActionGroup>
        where TContextNavigationProvider :  class, JetBrains.ReSharper.Feature.Services.ContextNavigation.INavigateFromHereProvider
    {
        protected override bool AssertsMenuItemsMnemonics { get; }
        protected override JetBrains.UI.RichText.RichText Caption { get; }
        protected override bool ShowMenuWithOneItem { get; }
        protected override void Execute(JetBrains.Application.DataContext.IDataContext context, JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextNavigation refactoringWorkflow) { }
        protected override JetBrains.UI.Icons.IconId GetIcon(JetBrains.Application.DataContext.IDataContext dataContext) { }
        protected override System.Collections.Generic.ICollection<TContextNavigationProvider> GetWorkflowProviders() { }
        protected override bool IsAvailable(JetBrains.Application.DataContext.IDataContext context, JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextNavigation refactoringWorkflow) { }
        protected override bool IsEnabled(JetBrains.Application.DataContext.IDataContext context, JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextNavigation workflow) { }
    }
    public class static ContextNavigationLanguageUtil
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.ICollection<TContextSearch> GetAvailableContextSearches<TContextSearch>(JetBrains.Application.DataContext.IDataContext dataContext, JetBrains.ReSharper.Feature.Services.IFeaturePartsContainer container)
            where TContextSearch :  class, JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.IContextSearch { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class ContextNavigationManager
    {
        public ContextNavigationManager(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.ContextNavigation.INavigateFromHereProvider> navigateFromHereProviders, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Features.Finding.NavigateFromHere.IContextSearchProvider> contextSearchProviders) { }
        public static JetBrains.ReSharper.Features.Finding.NavigateFromHere.ContextNavigationManager Instance { get; }
        public System.Collections.Generic.IEnumerable<TContextSearchProvider> GetContextSearchProviders<TContextSearchProvider>()
            where TContextSearchProvider :  class, JetBrains.ReSharper.Features.Finding.NavigateFromHere.IContextSearchProvider { }
        public System.Collections.Generic.IEnumerable<TNavigateFromHereProvider> GetNavigateFromHereProviders<TNavigateFromHereProvider>()
            where TNavigateFromHereProvider :  class, JetBrains.ReSharper.Feature.Services.ContextNavigation.INavigateFromHereProvider { }
    }
    public abstract class ContextNavigationProviderBase<TContextSearch> : JetBrains.ReSharper.Features.Finding.NavigateFromHere.IContextSearchProvider
        where TContextSearch :  class, JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.IContextSearch
    {
        protected ContextNavigationProviderBase(JetBrains.ReSharper.Feature.Services.IFeaturePartsContainer manager) { }
        [JetBrains.Annotations.NotNullAttribute()]
        protected abstract JetBrains.ReSharper.Feature.Services.ContextNavigation.NavigationActionGroup ActionGroup { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextNavigation> CreateWorkflow(JetBrains.Application.DataContext.IDataContext dataContext) { }
        protected abstract void Execute(JetBrains.Application.DataContext.IDataContext dataContext, System.Collections.Generic.IEnumerable<TContextSearch> searches, JetBrains.ReSharper.Features.Common.Occurences.ExecutionHosting.INavigationExecutionHost host);
        protected abstract string GetActionId(JetBrains.Application.DataContext.IDataContext dataContext);
        protected abstract string GetNavigationMenuTitle(JetBrains.Application.DataContext.IDataContext dataContext);
        public System.Action GetSearchesExecution(JetBrains.Application.DataContext.IDataContext dataContext, JetBrains.ReSharper.Features.Common.Occurences.ExecutionHosting.INavigationExecutionHost host) { }
    }
    public abstract class ContextSearchActionBase<TContextSearchProvider> : JetBrains.ActionManagement.IActionHandler
        where TContextSearchProvider :  class, JetBrains.ReSharper.Features.Finding.NavigateFromHere.IContextSearchProvider
    {
        public void Execute(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.DelegateExecute nextExecute) { }
        public bool Update(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.ActionPresentation presentation, JetBrains.ActionManagement.DelegateUpdate nextUpdate) { }
    }
    public abstract class ContextSearchesCollector<TContextSearch> : JetBrains.ReSharper.Features.Finding.NavigateFromHere.IContextSearchProvider
        where TContextSearch :  class, JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.IContextSearch
    {
        protected ContextSearchesCollector(JetBrains.ReSharper.Feature.Services.IFeaturePartsContainer manager) { }
        protected JetBrains.ReSharper.Feature.Services.IFeaturePartsContainer Manager { get; }
        protected abstract void Execute(JetBrains.Application.DataContext.IDataContext dataContext, System.Collections.Generic.IEnumerable<TContextSearch> searches, JetBrains.ReSharper.Features.Common.Occurences.ExecutionHosting.INavigationExecutionHost host);
        public virtual System.Action GetSearchesExecution(JetBrains.Application.DataContext.IDataContext dataContext, JetBrains.ReSharper.Features.Common.Occurences.ExecutionHosting.INavigationExecutionHost host) { }
    }
    public interface IContextSearchProvider
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        System.Action GetSearchesExecution(JetBrains.Application.DataContext.IDataContext dataContext, JetBrains.ReSharper.Features.Common.Occurences.ExecutionHosting.INavigationExecutionHost host);
    }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "NavigateTo"})]
    public class NavigateFromHereAction : JetBrains.ReSharper.Features.Finding.NavigateFromHere.ContextNavigationActionBase<JetBrains.ReSharper.Feature.Services.ContextNavigation.INavigateFromHereProvider>
    {
        protected override JetBrains.UI.RichText.RichText Caption { get; }
        protected override bool ShowMenuWithOneItem { get; }
    }
    public abstract class RequestContextSearchProvider<TContextSearch, TDescriptor, TSearchRequest> : JetBrains.ReSharper.Features.Finding.NavigateFromHere.ContextSearchesCollector<TContextSearch>
        where TContextSearch :  class, JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.IRequestContextSearch<>
        where TDescriptor : JetBrains.ReSharper.Features.Common.Occurences.OccurenceBrowserDescriptor
        where TSearchRequest : JetBrains.ReSharper.Feature.Services.Search.SearchRequests.SearchRequest
    {
        protected RequestContextSearchProvider(JetBrains.ReSharper.Feature.Services.IFeaturePartsContainer manager) { }
        protected abstract TDescriptor CreateSearchDescriptor(TSearchRequest searchRequest, System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.Search.IOccurence> occurences);
        protected override void Execute(JetBrains.Application.DataContext.IDataContext dataContext, System.Collections.Generic.IEnumerable<TContextSearch> searches, JetBrains.ReSharper.Features.Common.Occurences.ExecutionHosting.INavigationExecutionHost host) { }
        protected void ExecuteCandidates(JetBrains.Application.DataContext.IDataContext dataContext, bool promoteDeclaredElement, System.Collections.Generic.ICollection<JetBrains.Util.JetTuple<JetBrains.ReSharper.Psi.IDeclaredElement, JetBrains.ReSharper.Psi.Services.CandidatesUtil.DeclaredElementExecutor>> elementExecutionPairs) { }
        protected void ExecuteElementSearchPairs(JetBrains.Application.DataContext.IDataContext dataContext, System.Collections.Generic.IEnumerable<JetBrains.Util.JetTuple<JetBrains.ReSharper.Psi.IDeclaredElement, JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.GetSearchRequest<TSearchRequest>>> declaredElementsSearches, JetBrains.ReSharper.Features.Common.Occurences.ExecutionHosting.INavigationExecutionHost host) { }
        protected void ExecuteSearchRequest(JetBrains.Application.DataContext.IDataContext context, [JetBrains.Annotations.CanBeNullAttribute()] TSearchRequest searchRequest, JetBrains.ReSharper.Features.Common.Occurences.ExecutionHosting.INavigationExecutionHost host) { }
        protected void ExecuteWithDeclaredElements(JetBrains.Application.DataContext.IDataContext dataContext, bool promoteDeclaredElement, System.Collections.Generic.ICollection<JetBrains.Util.JetTuple<JetBrains.ReSharper.Psi.IDeclaredElement, JetBrains.ReSharper.Psi.Services.CandidatesUtil.DeclaredElementExecutor>> candidates, JetBrains.ReSharper.Psi.Services.CandidatesUtil.MultiplyDeclaredElementExecutor multipleExecutor) { }
        [System.ComponentModel.LocalizableAttribute(false)]
        protected virtual string GetFeatureID() { }
        protected virtual string GetNotFoundMessage(TSearchRequest request) { }
        protected virtual JetBrains.ReSharper.Psi.Search.ISearchDomain GetSearchDomain(JetBrains.Application.DataContext.IDataContext dataContext) { }
        protected virtual bool ProcessImmediateResult(JetBrains.Application.DataContext.IDataContext context, System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.Search.IOccurence> results, JetBrains.ReSharper.Features.Common.Occurences.ExecutionHosting.INavigationExecutionHost host) { }
        protected virtual System.Nullable<JetBrains.ReSharper.Feature.Services.Occurences.OccurencePresentationOptions> ProvideFeatureSpecificPresentationOptions() { }
        protected virtual void ShowResultMessage(JetBrains.Application.DataContext.IDataContext context, string message) { }
        protected virtual void ShowResults(JetBrains.Application.DataContext.IDataContext context, JetBrains.ReSharper.Features.Common.Occurences.ExecutionHosting.INavigationExecutionHost host, string title, System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.Search.IOccurence> occurences, System.Func<TDescriptor> descriptorBuilder, System.Collections.Generic.IComparer<JetBrains.ReSharper.Feature.Services.Search.IOccurence> customSearchRequestComparer) { }
        protected JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.GetSearchRequest<TSearchRequest> TryFindSingleSpecialSearch(System.Collections.Generic.IEnumerable<JetBrains.Util.JetTuple<System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IDeclaredElement>, JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.GetSearchRequest<TSearchRequest>>> elementsSearchPairs) { }
    }
}
namespace JetBrains.ReSharper.Features.Finding.NavigateFromHere.ExtensionMethods
{
    
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "NavigateToExtensionMethods"})]
    public class ExtensionMethodsNavigationAction : JetBrains.ReSharper.Features.Finding.NavigateFromHere.ContextNavigationActionBase<JetBrains.ReSharper.Features.Finding.NavigateFromHere.ExtensionMethods.IExtensionMethodsNavigationProvider>
    {
        protected override JetBrains.UI.RichText.RichText Caption { get; }
    }
    [JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextNavigationProviderAttribute()]
    public class ExtensionMethodsNavigationProvider : JetBrains.ReSharper.Features.Finding.NavigateFromHere.ContextNavigationProviderBase<JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.IExtensionMethodsContextSearch>, JetBrains.ReSharper.Feature.Services.ActionsMenu.IWorkflowProvider<JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextNavigation, JetBrains.ReSharper.Feature.Services.ContextNavigation.NavigationActionGroup>, JetBrains.ReSharper.Feature.Services.ContextNavigation.INavigateFromHereProvider, JetBrains.ReSharper.Features.Finding.NavigateFromHere.ExtensionMethods.IExtensionMethodsNavigationProvider
    {
        public ExtensionMethodsNavigationProvider(JetBrains.ReSharper.Feature.Services.IFeaturePartsContainer manager) { }
        protected override JetBrains.ReSharper.Feature.Services.ContextNavigation.NavigationActionGroup ActionGroup { get; }
        protected override void Execute(JetBrains.Application.DataContext.IDataContext dataContext, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.IExtensionMethodsContextSearch> searches, JetBrains.ReSharper.Features.Common.Occurences.ExecutionHosting.INavigationExecutionHost host) { }
        protected override string GetActionId(JetBrains.Application.DataContext.IDataContext dataContext) { }
        protected override string GetNavigationMenuTitle(JetBrains.Application.DataContext.IDataContext dataContext) { }
    }
    public interface IExtensionMethodsNavigationProvider : JetBrains.ReSharper.Feature.Services.ActionsMenu.IWorkflowProvider<JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextNavigation, JetBrains.ReSharper.Feature.Services.ContextNavigation.NavigationActionGroup>, JetBrains.ReSharper.Feature.Services.ContextNavigation.INavigateFromHereProvider { }
}
namespace JetBrains.ReSharper.Features.Finding.NavigateFromHere.FlowTarget
{
    
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "NavigateToControlFlowTarget"})]
    public class FlowTargetNavigationAction : JetBrains.ReSharper.Features.Finding.NavigateFromHere.ContextNavigationActionBase<JetBrains.ReSharper.Features.Finding.NavigateFromHere.FlowTarget.IFlowTargetNavigationProvider> { }
    public interface IFlowTargetNavigationProvider : JetBrains.ReSharper.Feature.Services.ActionsMenu.IWorkflowProvider<JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextNavigation, JetBrains.ReSharper.Feature.Services.ContextNavigation.NavigationActionGroup>, JetBrains.ReSharper.Feature.Services.ContextNavigation.INavigateFromHereProvider { }
}
namespace JetBrains.ReSharper.Features.Finding.NavigateFromHere.FunctionExits
{
    
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "NavigateToFunctionExits"})]
    public class FunctionExitsNavigationAction : JetBrains.ReSharper.Features.Finding.NavigateFromHere.ContextNavigationActionBase<JetBrains.ReSharper.Features.Finding.NavigateFromHere.FunctionExits.IFunctionExitsNavigationProvider>
    {
        public static readonly string CONTROL_FLOW_NEVER_LEAVES_FUNCTION;
    }
    public interface IFunctionExitsNavigationProvider : JetBrains.ReSharper.Feature.Services.ActionsMenu.IWorkflowProvider<JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextNavigation, JetBrains.ReSharper.Feature.Services.ContextNavigation.NavigationActionGroup>, JetBrains.ReSharper.Feature.Services.ContextNavigation.INavigateFromHereProvider { }
}
namespace JetBrains.ReSharper.Features.Finding.NavigateFromHere.ImplementingMembers
{
    
    public interface IImplementingMembersNavigationProvider : JetBrains.ReSharper.Feature.Services.ActionsMenu.IWorkflowProvider<JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextNavigation, JetBrains.ReSharper.Feature.Services.ContextNavigation.NavigationActionGroup>, JetBrains.ReSharper.Feature.Services.ContextNavigation.INavigateFromHereProvider { }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "NavigateToInterfaceImplementation"})]
    public class ImplementingMembersNavigationAction : JetBrains.ReSharper.Features.Finding.NavigateFromHere.ContextNavigationActionBase<JetBrains.ReSharper.Features.Finding.NavigateFromHere.ImplementingMembers.IImplementingMembersNavigationProvider>
    {
        public static readonly string ARGUMENT_NOT_FOUND;
    }
}
namespace JetBrains.ReSharper.Features.Finding.NavigateFromHere.Overloads
{
    
    public interface IOverloadsNavigationProvider : JetBrains.ReSharper.Feature.Services.ActionsMenu.IWorkflowProvider<JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextNavigation, JetBrains.ReSharper.Feature.Services.ContextNavigation.NavigationActionGroup>, JetBrains.ReSharper.Feature.Services.ContextNavigation.INavigateFromHereProvider { }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "NavigateToOverloads"})]
    public class OverloadsNavigationAction : JetBrains.ReSharper.Features.Finding.NavigateFromHere.ContextNavigationActionBase<JetBrains.ReSharper.Features.Finding.NavigateFromHere.Overloads.IOverloadsNavigationProvider> { }
}
namespace JetBrains.ReSharper.Features.Finding.NavigateFromHere.ParameterDeclaration
{
    
    public interface IParameterDeclarationNavigationProvider : JetBrains.ReSharper.Feature.Services.ActionsMenu.IWorkflowProvider<JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextNavigation, JetBrains.ReSharper.Feature.Services.ContextNavigation.NavigationActionGroup>, JetBrains.ReSharper.Feature.Services.ContextNavigation.INavigateFromHereProvider { }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "NavigateToParameter"})]
    public class ParameterDeclarationNavigationAction : JetBrains.ReSharper.Features.Finding.NavigateFromHere.ContextNavigationActionBase<JetBrains.ReSharper.Features.Finding.NavigateFromHere.ParameterDeclaration.IParameterDeclarationNavigationProvider> { }
}
namespace JetBrains.ReSharper.Features.Finding.NavigateFromHere.Substitutions
{
    
    public interface ISubstitutionNavigationProvider : JetBrains.ReSharper.Feature.Services.ActionsMenu.IWorkflowProvider<JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextNavigation, JetBrains.ReSharper.Feature.Services.ContextNavigation.NavigationActionGroup>, JetBrains.ReSharper.Feature.Services.ContextNavigation.INavigateFromHereProvider { }
    public class SearchSubstitutionsDescriptor : JetBrains.ReSharper.Features.Finding.Search.SearchDescriptor
    {
        public SearchSubstitutionsDescriptor(JetBrains.ReSharper.Feature.Services.Search.SearchRequests.SearchSubstitutionRequest request, System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.Search.IOccurence> occurences) { }
        public override JetBrains.UI.TreeView.StructuredPresenter<JetBrains.TreeModels.TreeModelNode, JetBrains.CommonControls.IPresentableItem> Presenter { get; }
        public override bool QuickSearchSupported { get; }
        public override string GetResultsTitle(JetBrains.ReSharper.Features.Common.Occurences.OccurenceSection section) { }
        public override bool QuickSearchMatches(JetBrains.TreeModels.TreeModelNode modelNode, string quickSearchText) { }
    }
    [JetBrains.ReSharper.Psi.ShellFeaturePartAttribute()]
    public class SubstitutionGroupingProvider : JetBrains.ReSharper.Features.Common.Occurences.OccurenceBrowserGroupingProvider
    {
        public override System.Collections.Generic.ICollection<JetBrains.TreeModels.TreeModelGrouping<JetBrains.ReSharper.Feature.Services.Search.IOccurence>> GetGroupings(JetBrains.IDE.TreeBrowser.TreeModelBrowserDescriptorBase descriptor) { }
        public override bool IsApplicable(JetBrains.IDE.TreeBrowser.TreeModelBrowserDescriptorBase descriptor) { }
        protected class SubstitutionGroupProvider : JetBrains.TreeModels.ITreeGroupProvider<JetBrains.ReSharper.Feature.Services.Search.IOccurence>
        {
            public object ExtractGroupObject(JetBrains.ReSharper.Feature.Services.Search.IOccurence item) { }
        }
    }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "NavigateToSubstitutions"})]
    public class SubstitutionNavigationAction : JetBrains.ReSharper.Features.Finding.NavigateFromHere.ContextNavigationActionBase<JetBrains.ReSharper.Features.Finding.NavigateFromHere.Substitutions.ISubstitutionNavigationProvider>
    {
        protected override JetBrains.UI.RichText.RichText Caption { get; }
    }
    [JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextNavigationProviderAttribute()]
    public class SubstitutionNavigationProvider : JetBrains.ReSharper.Features.Finding.NavigateFromHere.ContextNavigationProviderBase<JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.ISubstitutionContextSearch>, JetBrains.ReSharper.Feature.Services.ActionsMenu.IWorkflowProvider<JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextNavigation, JetBrains.ReSharper.Feature.Services.ContextNavigation.NavigationActionGroup>, JetBrains.ReSharper.Feature.Services.ContextNavigation.INavigateFromHereProvider, JetBrains.ReSharper.Features.Finding.NavigateFromHere.Substitutions.ISubstitutionNavigationProvider
    {
        public SubstitutionNavigationProvider(JetBrains.ReSharper.Feature.Services.IFeaturePartsContainer manager, JetBrains.Application.IShellLocks shellLocks, JetBrains.ActionManagement.IActionManager actionManager) { }
        protected override JetBrains.ReSharper.Feature.Services.ContextNavigation.NavigationActionGroup ActionGroup { get; }
        protected override void Execute(JetBrains.Application.DataContext.IDataContext dataContext, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.ISubstitutionContextSearch> searches, JetBrains.ReSharper.Features.Common.Occurences.ExecutionHosting.INavigationExecutionHost host) { }
        protected override string GetActionId(JetBrains.Application.DataContext.IDataContext dataContext) { }
        protected override string GetNavigationMenuTitle(JetBrains.Application.DataContext.IDataContext dataContext) { }
    }
    public sealed class SubstitutionTypeGroup : System.IComparable<JetBrains.ReSharper.Features.Finding.NavigateFromHere.Substitutions.SubstitutionTypeGroup>, System.IEquatable<JetBrains.ReSharper.Features.Finding.NavigateFromHere.Substitutions.SubstitutionTypeGroup>
    {
        public SubstitutionTypeGroup([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IType type, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.PsiLanguageType language) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.Psi.PsiLanguageType Language { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.Psi.IType Type { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public string TypePresentation { get; }
        public int CompareTo(JetBrains.ReSharper.Features.Finding.NavigateFromHere.Substitutions.SubstitutionTypeGroup other) { }
        public bool Equals(JetBrains.ReSharper.Features.Finding.NavigateFromHere.Substitutions.SubstitutionTypeGroup other) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
    }
    public class SubstitutionTypeGroupComparer : JetBrains.ReSharper.Features.Common.Occurences.OccurenceComparer
    {
        public static readonly JetBrains.ReSharper.Features.Finding.NavigateFromHere.Substitutions.SubstitutionTypeGroupComparer Instance;
    }
    public class SubstitutionTypePresenter : JetBrains.ReSharper.Features.Common.Occurences.OccurenceBrowserPresenter
    {
        public SubstitutionTypePresenter() { }
    }
}
namespace JetBrains.ReSharper.Features.Finding.Options
{
    
    [JetBrains.UI.Options.OptionsPageAttribute("SearchAndNavigation", "Search & Navigation", typeof(JetBrains.ReSharper.Features.Finding.Resources.FeaturesFindingThemedIcons.SearchOptionsPage), HelpKeyword="Reference__Options__Environment__Search_and_Navigation", ParentId="Environment", Sequence=2D)]
    public class SearchAndNavigationPage : JetBrains.UI.Options.Helpers.AStackPanelOptionsPage3
    {
        public const string PID = "SearchAndNavigation";
        public SearchAndNavigationPage(JetBrains.DataFlow.Lifetime lifetime, JetBrains.UI.Application.IUIApplication environment, JetBrains.UI.Options.OptionsSettingsSmartContext settings) { }
    }
}
namespace JetBrains.ReSharper.Features.Finding.Resources
{
    
    public sealed class FeaturesFindingThemedIcons
    {
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Features.Finding;component/resources/FeaturesFindingIcons/The" +
            "medIcons.FeaturesFinding.Generated.Xaml", 0, "SearchOptionsPage")]
        public sealed class SearchOptionsPage : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
    }
}
namespace JetBrains.ReSharper.Features.Finding.Search
{
    
    [JetBrains.ReSharper.Psi.ShellFeaturePartAttribute()]
    public class ReferencedCodeUsagesSectionProvider : JetBrains.ReSharper.Features.Finding.Search.SearchDescriptorSectionProvider
    {
        public override System.Collections.Generic.ICollection<JetBrains.ReSharper.Features.Common.Occurences.GroupingSectionId> GetGroupSectionId(JetBrains.ReSharper.Feature.Services.Search.IOccurence occurence, JetBrains.ReSharper.Features.Common.Occurences.OccurenceBrowserDescriptor descriptor) { }
        public override bool IsApplicable(JetBrains.ReSharper.Features.Common.Occurences.OccurenceBrowserDescriptor descriptor) { }
    }
    public abstract class SearchDescriptor : JetBrains.ReSharper.Features.Common.Occurences.OccurenceBrowserDescriptor
    {
        protected SearchDescriptor(JetBrains.ReSharper.Feature.Services.Search.SearchRequests.SearchRequest request) { }
        protected SearchDescriptor(JetBrains.ReSharper.Feature.Services.Search.SearchRequests.SearchRequest request, System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.Search.IOccurence> results) { }
        public override string ActionBarID { get; }
        public override JetBrains.TreeModels.TreeModel Model { get; }
        public JetBrains.ReSharper.Feature.Services.Search.SearchRequests.SearchRequest Request { get; }
        public virtual System.Collections.ICollection SearchTargets { get; }
        public JetBrains.TreeModels.TreeModel TargetModel { get; }
        public abstract string GetResultsTitle(JetBrains.ReSharper.Features.Common.Occurences.OccurenceSection section);
        public bool Search() { }
        protected override void SetResults(System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.Search.IOccurence> items, JetBrains.Application.Progress.IProgressIndicator indicator = null, bool mergeItems = True) { }
    }
    [JetBrains.ReSharper.Psi.ShellFeaturePartAttribute()]
    public class SearchDescriptorSectionProvider : JetBrains.ReSharper.Features.Common.Occurences.OccurenceSectionProvider
    {
        public override System.Collections.Generic.ICollection<JetBrains.ReSharper.Features.Common.Occurences.GroupingSectionId> GetGroupSectionId(JetBrains.ReSharper.Feature.Services.Search.IOccurence occurence, JetBrains.ReSharper.Features.Common.Occurences.OccurenceBrowserDescriptor descriptor) { }
        public override System.Collections.Generic.ICollection<JetBrains.TreeModels.TreeSection> GetTreeSections(JetBrains.ReSharper.Features.Common.Occurences.OccurenceBrowserDescriptor descriptor) { }
        public override bool IsApplicable(JetBrains.ReSharper.Features.Common.Occurences.OccurenceBrowserDescriptor descriptor) { }
    }
}
namespace JetBrains.ReSharper.Features.Finding.SearchDialogs
{
    
    public abstract class AdvancedSearchDialog : System.Windows.Forms.Form
    {
        protected static readonly System.Linq.Expressions.Expression<System.Func<JetBrains.ReSharper.Features.Finding.SearchSettings, bool>> DELEGATE_TARGETS_KEY;
        protected static readonly System.Linq.Expressions.Expression<System.Func<JetBrains.ReSharper.Features.Finding.SearchSettings, bool>> DERIVED_TYPES_KEY;
        protected static readonly System.Linq.Expressions.Expression<System.Func<JetBrains.ReSharper.Features.Finding.SearchSettings, bool>> EXTENDING_INTERFACES_KEY;
        protected static readonly System.Linq.Expressions.Expression<System.Func<JetBrains.ReSharper.Features.Finding.SearchSettings, bool>> HIDING_KEY;
        protected static readonly System.Linq.Expressions.Expression<System.Func<JetBrains.ReSharper.Features.Finding.SearchSettings, bool>> IMPLEMENTATIONS_KEY;
        protected static readonly System.Linq.Expressions.Expression<System.Func<JetBrains.ReSharper.Features.Finding.SearchSettings, bool>> INHERITED_MEMBERS_KEY;
        protected static readonly System.Linq.Expressions.Expression<System.Func<JetBrains.ReSharper.Features.Finding.SearchSettings, bool>> LATE_BOUND_KEY;
        protected static readonly System.Linq.Expressions.Expression<System.Func<JetBrains.ReSharper.Features.Finding.SearchSettings, bool>> MEMBERS_USAGES_KEY;
        protected static readonly System.Linq.Expressions.Expression<System.Func<JetBrains.ReSharper.Features.Finding.SearchSettings, bool>> OVERLOADING_KEY;
        protected static readonly System.Linq.Expressions.Expression<System.Func<JetBrains.ReSharper.Features.Finding.SearchSettings, bool>> TEXTUAL_OCCURENCES_KEY;
        protected static readonly System.Linq.Expressions.Expression<System.Func<JetBrains.ReSharper.Features.Finding.SearchSettings, bool>> USAGES_KEY;
        protected AdvancedSearchDialog(JetBrains.ReSharper.Feature.Services.Search.ISearchDomainContext searchDomainContext) { }
        public JetBrains.ReSharper.Psi.Search.ISearchDomain SearchDomain { get; }
        public event System.EventHandler FocusedNodeChanged;
        protected abstract System.Collections.Generic.IList<JetBrains.ReSharper.Psi.IDeclaredElement> GetCandidates();
        protected abstract JetBrains.ReSharper.Psi.IDeclaredElement GetDefaultCandidate();
        public abstract System.Collections.Generic.IList<JetBrains.ReSharper.Features.Finding.SearchDialogs.FindFlag> GetFlags();
        protected abstract JetBrains.ReSharper.Psi.IDeclaredElement GetOriginalElement();
        public abstract JetBrains.ReSharper.Psi.Search.SearchPattern GetPattern();
        public virtual System.Collections.Generic.IList<JetBrains.ReSharper.Psi.IDeclaredElement> GetSearchElements() { }
        public void Initialize() { }
        protected abstract void UpdateFlags(JetBrains.ReSharper.Psi.IDeclaredElement element);
    }
    public class DeclaredElementSelector : JetBrains.UI.CommonControls.SafeUserControl
    {
        public DeclaredElementSelector(JetBrains.UI.Application.IUIApplication environment) { }
        public System.Collections.Generic.ICollection<JetBrains.TreeModels.TreeModelNode> ModelSelection { get; }
        public JetBrains.ReSharper.Psi.IDeclaredElement Selection { get; }
        public event System.EventHandler FocusedNodeChanged;
        protected override void Dispose(bool disposing) { }
        public void SetElements(System.Collections.Generic.IList<JetBrains.ReSharper.Psi.IDeclaredElement> elements, JetBrains.ReSharper.Psi.IDeclaredElement defaultCandidate, JetBrains.ReSharper.Psi.IDeclaredElement originalElement) { }
    }
    public sealed class FindFlag
    {
        public FindFlag(System.Linq.Expressions.Expression<System.Func<JetBrains.ReSharper.Features.Finding.SearchSettings, bool>> expression, string text) { }
        public bool Enabled { get; set; }
        public System.Linq.Expressions.Expression<System.Func<JetBrains.ReSharper.Features.Finding.SearchSettings, bool>> Expression { get; }
        public string Text { get; set; }
        public bool Value { get; set; }
        public event System.EventHandler Changed;
    }
    public class FlagsSelector : JetBrains.UI.CommonControls.SafeUserControl
    {
        public FlagsSelector(JetBrains.UI.Application.IUIApplication environment) { }
        public int FlagsHeight { get; }
        public event System.EventHandler FlagsChanged;
        protected override void Dispose(bool disposing) { }
        public void ShowFlags(System.Collections.Generic.IList<JetBrains.ReSharper.Features.Finding.SearchDialogs.FindFlag> flags) { }
    }
    public class SearchConstructorDialog : JetBrains.ReSharper.Features.Finding.SearchDialogs.AdvancedSearchDialog
    {
        public SearchConstructorDialog(JetBrains.ReSharper.Psi.IConstructor constructor, JetBrains.ReSharper.Feature.Services.Search.ISearchDomainContext searchDomainContext) { }
        protected override System.Collections.Generic.IList<JetBrains.ReSharper.Psi.IDeclaredElement> GetCandidates() { }
        protected override JetBrains.ReSharper.Psi.IDeclaredElement GetDefaultCandidate() { }
        public override System.Collections.Generic.IList<JetBrains.ReSharper.Features.Finding.SearchDialogs.FindFlag> GetFlags() { }
        protected override JetBrains.ReSharper.Psi.IDeclaredElement GetOriginalElement() { }
        public override JetBrains.ReSharper.Psi.Search.SearchPattern GetPattern() { }
        public override System.Collections.Generic.IList<JetBrains.ReSharper.Psi.IDeclaredElement> GetSearchElements() { }
        protected override void UpdateFlags(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
    }
    public class SearchDeclaredElementDialog : JetBrains.ReSharper.Features.Finding.SearchDialogs.AdvancedSearchDialog
    {
        public SearchDeclaredElementDialog(JetBrains.ReSharper.Psi.IDeclaredElement member, JetBrains.ReSharper.Feature.Services.Search.ISearchDomainContext searchDomainContext) { }
        protected override System.Collections.Generic.IList<JetBrains.ReSharper.Psi.IDeclaredElement> GetCandidates() { }
        protected override JetBrains.ReSharper.Psi.IDeclaredElement GetDefaultCandidate() { }
        public override System.Collections.Generic.IList<JetBrains.ReSharper.Features.Finding.SearchDialogs.FindFlag> GetFlags() { }
        protected override JetBrains.ReSharper.Psi.IDeclaredElement GetOriginalElement() { }
        public override JetBrains.ReSharper.Psi.Search.SearchPattern GetPattern() { }
        protected override void UpdateFlags(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
    }
    public class SearchOverridableMemberDialog : JetBrains.ReSharper.Features.Finding.SearchDialogs.AdvancedSearchDialog
    {
        public SearchOverridableMemberDialog(JetBrains.ReSharper.Psi.IOverridableMember member, JetBrains.ReSharper.Feature.Services.Search.ISearchDomainContext searchDomainContext) { }
        protected override System.Collections.Generic.IList<JetBrains.ReSharper.Psi.IDeclaredElement> GetCandidates() { }
        protected override JetBrains.ReSharper.Psi.IDeclaredElement GetDefaultCandidate() { }
        public override System.Collections.Generic.IList<JetBrains.ReSharper.Features.Finding.SearchDialogs.FindFlag> GetFlags() { }
        protected override JetBrains.ReSharper.Psi.IDeclaredElement GetOriginalElement() { }
        public override JetBrains.ReSharper.Psi.Search.SearchPattern GetPattern() { }
        public override System.Collections.Generic.IList<JetBrains.ReSharper.Psi.IDeclaredElement> GetSearchElements() { }
        protected override void UpdateFlags(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
    }
    public class SearchTypeDialog : JetBrains.ReSharper.Features.Finding.SearchDialogs.AdvancedSearchDialog
    {
        public SearchTypeDialog(JetBrains.ReSharper.Psi.ITypeElement type, JetBrains.ReSharper.Feature.Services.Search.ISearchDomainContext searchDomainContext) { }
        protected override System.Collections.Generic.IList<JetBrains.ReSharper.Psi.IDeclaredElement> GetCandidates() { }
        protected override JetBrains.ReSharper.Psi.IDeclaredElement GetDefaultCandidate() { }
        public override System.Collections.Generic.IList<JetBrains.ReSharper.Features.Finding.SearchDialogs.FindFlag> GetFlags() { }
        protected override JetBrains.ReSharper.Psi.IDeclaredElement GetOriginalElement() { }
        public override JetBrains.ReSharper.Psi.Search.SearchPattern GetPattern() { }
        protected override void UpdateFlags(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
    }
}
namespace JetBrains.ReSharper.Features.Finding
{
    
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(JetBrains.Application.Settings.HousekeepingSettings), "Search settings")]
    public class SearchSettings
    {
        [JetBrains.Application.Settings.SettingsEntryAttribute(false, "Whether a hint was used for the Highlight Usages action")]
        public bool HighlightUsagesHintUsed;
        [JetBrains.Application.Settings.SettingsEntryAttribute(false, "Whether to search for delegate targets")]
        public bool SearchForDelegateTargets;
        [JetBrains.Application.Settings.SettingsEntryAttribute(false, "Whether to search for derived types")]
        public bool SearchForDerivedTypes;
        [JetBrains.Application.Settings.SettingsEntryAttribute(false, "Whether to search for extending interfaces")]
        public bool SearchForExtendingInterfaces;
        [JetBrains.Application.Settings.SettingsEntryAttribute(false, "Whether to search for hiding members")]
        public bool SearchForHiding;
        [JetBrains.Application.Settings.SettingsEntryAttribute(false, "Whether to search for implementations")]
        public bool SearchForImplementations;
        [JetBrains.Application.Settings.SettingsEntryAttribute(false, "Whether to search for inherited members")]
        public bool SearchForInheritedMembers;
        [JetBrains.Application.Settings.SettingsEntryAttribute(false, "Whether to search for late-bound references")]
        public bool SearchForLateBound;
        [JetBrains.Application.Settings.SettingsEntryAttribute(false, "Whether to search for member usages")]
        public bool SearchForMembersUsages;
        [JetBrains.Application.Settings.SettingsEntryAttribute(false, "Whether to search for overloading members")]
        public bool SearchForOverloading;
        [JetBrains.Application.Settings.SettingsEntryAttribute(true, "Whether to search for textual occurrences")]
        public bool SearchForTextualOccurences;
        [JetBrains.Application.Settings.SettingsEntryAttribute(true, "Whether to search for usages")]
        public bool SearchForUsages;
    }
    [JetBrains.Application.Configuration.Upgrade.GlobalSettingsUpgraderAttribute()]
    public class SearchSettingsUpgrader : JetBrains.Application.Configuration.SettingTablesUpgrader
    {
        public SearchSettingsUpgrader(JetBrains.Application.Env.RunsProducts.ProductConfigurations productConfigurations) { }
        protected override void DoUpgrade(JetBrains.Application.Configuration.IComponentSettingsProvider legacySettingsProvider, JetBrains.Application.Settings.IContextBoundSettingsStore boundSettingsStore, JetBrains.DataFlow.Lifetime upgradeLifetime, JetBrains.Application.Configuration.SettingsTableBase workspaceSettingsTable, JetBrains.Application.Configuration.SettingsTableBase globalSettingsTable) { }
    }
}
namespace JetBrains.ReSharper.Features.Finding.Usages
{
    
    [JetBrains.Application.ShellComponentAttribute()]
    public class FindUsagesAdvancedProvider : JetBrains.ReSharper.Features.Finding.NavigateFromHere.RequestContextSearchProvider<JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.IFindUsagesAdvancedContextSearch, JetBrains.ReSharper.Features.Finding.FindUsages.SearchUsagesDescriptor, JetBrains.ReSharper.Feature.Services.Search.SearchRequests.SearchUsagesRequest>
    {
        public FindUsagesAdvancedProvider(JetBrains.ReSharper.Feature.Services.IFeaturePartsContainer manager) { }
        protected override JetBrains.ReSharper.Features.Finding.FindUsages.SearchUsagesDescriptor CreateSearchDescriptor(JetBrains.ReSharper.Feature.Services.Search.SearchRequests.SearchUsagesRequest searchRequest, System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.Search.IOccurence> occurences) { }
        protected override void Execute(JetBrains.Application.DataContext.IDataContext dataContext, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.IFindUsagesAdvancedContextSearch> searches, JetBrains.ReSharper.Features.Common.Occurences.ExecutionHosting.INavigationExecutionHost host) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class FindUsagesProvider : JetBrains.ReSharper.Features.Finding.Usages.UsagesContextSearchProviderBase<JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.IFindUsagesContextSearch, JetBrains.ReSharper.Features.Finding.FindUsages.SearchUsagesDescriptor, JetBrains.ReSharper.Feature.Services.Search.SearchRequests.SearchUsagesRequest>, JetBrains.ReSharper.Feature.Services.ActionsMenu.IWorkflowProvider<JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextNavigation, JetBrains.ReSharper.Feature.Services.ContextNavigation.NavigationActionGroup>, JetBrains.ReSharper.Feature.Services.ContextNavigation.INavigateFromHereProvider, JetBrains.ReSharper.Features.Finding.FindHierarchy.IFindUsagesProvider, JetBrains.ReSharper.Features.Finding.NavigateFromHere.IContextSearchProvider
    {
        public FindUsagesProvider(JetBrains.ReSharper.Feature.Services.IFeaturePartsContainer manager) { }
        protected override JetBrains.ReSharper.Features.Finding.FindUsages.SearchUsagesDescriptor CreateSearchDescriptor(JetBrains.ReSharper.Feature.Services.Search.SearchRequests.SearchUsagesRequest searchUsagesRequest, System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.Search.IOccurence> occurences) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextNavigation> CreateWorkflow(JetBrains.Application.DataContext.IDataContext dataContext) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class HighlightUsagesProvider : JetBrains.ReSharper.Features.Finding.Usages.UsagesContextSearchProviderBase<JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.IHighlightUsagesContextSearch, JetBrains.ReSharper.Features.Finding.FindUsages.SearchUsagesDescriptor, JetBrains.ReSharper.Feature.Services.Search.SearchRequests.SearchUsagesRequest>
    {
        public HighlightUsagesProvider(JetBrains.ReSharper.Feature.Services.IFeaturePartsContainer manager, JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.UI.Tooltips.ITooltipManager tooltipManager, JetBrains.UI.StatusBar.IStatusBar statusBar) { }
        protected override string GetNotFoundMessage(JetBrains.ReSharper.Feature.Services.Search.SearchRequests.SearchUsagesRequest request) { }
        protected override bool ProcessImmediateResult(JetBrains.Application.DataContext.IDataContext context, System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.Search.IOccurence> results, JetBrains.ReSharper.Features.Common.Occurences.ExecutionHosting.INavigationExecutionHost host) { }
        protected override bool SearchParametersOverloads(JetBrains.Application.DataContext.IDataContext dataContext, JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.IHighlightUsagesContextSearch contextSearch) { }
        protected override void ShowResultMessage(JetBrains.Application.DataContext.IDataContext context, string message) { }
        protected override void ShowResults(JetBrains.Application.DataContext.IDataContext context, JetBrains.ReSharper.Features.Common.Occurences.ExecutionHosting.INavigationExecutionHost host, string title, System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.Search.IOccurence> occurences, System.Func<JetBrains.ReSharper.Features.Finding.FindUsages.SearchUsagesDescriptor> descriptorBuilder, System.Collections.Generic.IComparer<JetBrains.ReSharper.Feature.Services.Search.IOccurence> customSearchRequestComparer) { }
    }
    public abstract class UsagesContextSearchProviderBase<TContextSearch, TSearchUsagesDescriptor, TSearchUsagesRequest> : JetBrains.ReSharper.Features.Finding.NavigateFromHere.RequestContextSearchProvider<TContextSearch, TSearchUsagesDescriptor, TSearchUsagesRequest>
        where TContextSearch :  class, JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.IMultipleCandidatesContextSearch<>
        where TSearchUsagesDescriptor : JetBrains.ReSharper.Features.Finding.FindUsages.SearchUsagesDescriptor
        where TSearchUsagesRequest : JetBrains.ReSharper.Feature.Services.Search.SearchRequests.SearchRequest
    {
        protected UsagesContextSearchProviderBase(JetBrains.ReSharper.Feature.Services.IFeaturePartsContainer manager) { }
        protected override TSearchUsagesDescriptor CreateSearchDescriptor(TSearchUsagesRequest searchUsagesRequest, System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.Search.IOccurence> occurences) { }
        protected override void Execute(JetBrains.Application.DataContext.IDataContext dataContext, System.Collections.Generic.IEnumerable<TContextSearch> searches, JetBrains.ReSharper.Features.Common.Occurences.ExecutionHosting.INavigationExecutionHost host) { }
        protected virtual bool SearchParametersOverloads(JetBrains.Application.DataContext.IDataContext dataContext, TContextSearch contextSearch) { }
    }
}