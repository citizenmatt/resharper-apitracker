[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]

namespace JetBrains.ReSharper.Feature.Services.ExternalSources.ContextNavigation
{
    
    [JetBrains.ReSharper.Psi.ShellFeaturePartAttribute()]
    public class ExternalSourcesReferencedCodeContextSearch : JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.DeclaredElementsReferencedCodeContextSearch
    {
        protected override bool IsAvailableInternal(JetBrains.Application.DataContext.IDataContext dataContext) { }
        public override bool IsContextApplicable(JetBrains.Application.DataContext.IDataContext dataContext) { }
    }
    [JetBrains.ReSharper.Psi.ShellFeaturePartAttribute()]
    public class FindParameterUsagesContextSearch : JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.BaseSearches.FindUsagesContextSearch
    {
        protected override JetBrains.ReSharper.Feature.Services.Search.SearchRequests.SearchDeclaredElementUsagesRequest CreateMultipleSearchRequest(JetBrains.Application.DataContext.IDataContext dataContext, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IDeclaredElement> elements, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IDeclaredElement> initialTargets) { }
        protected override JetBrains.ReSharper.Feature.Services.Search.SearchRequests.SearchUsagesRequest CreateSearchRequest(JetBrains.Application.DataContext.IDataContext dataContext, JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, JetBrains.ReSharper.Psi.IDeclaredElement initialTarget) { }
        public override bool IsContextApplicable(JetBrains.Application.DataContext.IDataContext dataContext) { }
    }
    [JetBrains.ReSharper.Psi.ShellFeaturePartAttribute()]
    public class GotoDeclarationVsDelegator : JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.BaseSearches.DefaultDeclarationSearch
    {
        public GotoDeclarationVsDelegator(JetBrains.Application.Settings.ISettingsStore settingsStore) { }
        public override bool IsAvailable(JetBrains.Application.DataContext.IDataContext context) { }
        public override bool IsContextApplicable(JetBrains.Application.DataContext.IDataContext dataContext) { }
    }
    [JetBrains.ReSharper.Psi.ShellFeaturePartAttribute()]
    public class VsGotoImplementationDelegator : JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.BaseSearches.ImplementationContextSearch
    {
        public VsGotoImplementationDelegator(JetBrains.Application.Settings.ISettingsStore settingsStore) { }
        public override bool IsAvailable(JetBrains.Application.DataContext.IDataContext context) { }
        public override bool IsContextApplicable(JetBrains.Application.DataContext.IDataContext dataContext) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.ExternalSources.Core
{
    
    public class DecompilationCacheItem
    {
        public DecompilationCacheItem(JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IAssembly assembly, JetBrains.Util.FileSystemPath location, JetBrains.Util.ReadOnlyDictionary<string, string> properties, string moniker, string decompilerId, bool expired) { }
        public JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IAssembly Assembly { get; }
        public string DecompilerId { get; }
        public bool Expired { get; }
        public JetBrains.Util.FileSystemPath Location { get; }
        public string Moniker { get; }
        public JetBrains.Util.ReadOnlyDictionary<string, string> Properties { get; }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class ExternalSourcesActivation : JetBrains.Application.IExternalSourcesDebugInfoProvider
    {
        public ExternalSourcesActivation(JetBrains.DataFlow.Lifetime lifetime) { }
        public JetBrains.DataFlow.IProperty<bool> Active { get; }
        public void Dump(System.IO.TextWriter sw) { }
    }
    [JetBrains.Application.ShellComponentAttribute(JetBrains.Application.Components.ProgramConfigurations.NONE | JetBrains.Application.Components.ProgramConfigurations.STANDALONE | JetBrains.Application.Components.ProgramConfigurations.COMMAND_LINE | JetBrains.Application.Components.ProgramConfigurations.ALL)]
    public class ExternalSourcesActivationDefaults : JetBrains.ReSharper.Feature.Services.ExternalSources.Core.ExternalSourcesActivation
    {
        public ExternalSourcesActivationDefaults(JetBrains.DataFlow.Lifetime lifetime) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class ExternalSourcesDebugInfoDumper
    {
        public ExternalSourcesDebugInfoDumper(JetBrains.Application.IShellLocks shellLocks, System.Collections.Generic.IEnumerable<JetBrains.Application.IExternalSourcesDebugInfoProvider> providers) { }
        public void Dump(System.IO.TextWriter sw) { }
        public void DumpToNotepad() { }
    }
    [JetBrains.ActionManagement.ActionHandlerAttribute()]
    public class ExternalSourcesDumpSupportInformationActionHandler : JetBrains.ActionManagement.IActionHandler
    {
        public void Execute(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.DelegateExecute nextExecute) { }
        public bool Update(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.ActionPresentation presentation, JetBrains.ActionManagement.DelegateUpdate nextUpdate) { }
    }
    public enum ExternalSourcesNavigationMode
    {
        Disabled = 0,
        ObjectBrowser = 1,
        Sources = 2,
    }
    public class static ExternalSourcesServiceEx
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Feature.Services.ExternalSources.Core.Impl.ExternalSourcesMapping GetMapping([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Feature.Services.ExternalSources.Core.IExternalSourcesService service, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProjectFile projectFile) { }
        public static bool HasMapping([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Feature.Services.ExternalSources.Core.IExternalSourcesService service, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProjectFile projectFile) { }
    }
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(JetBrains.Application.Settings.EnvironmentSettings), "External sources navigation options")]
    public class ExternalSourcesSettings
    {
        [JetBrains.Application.Settings.SettingsEntryAttribute(false, "First time navigation dialog has been shown")]
        public bool FirstTimeFormShown;
        [JetBrains.Application.Settings.SettingsEntryAttribute(false, "Lock external sources files located on local machine")]
        public bool LockUserFiles;
        [JetBrains.Application.Settings.SettingsEntryAttribute(JetBrains.ReSharper.Feature.Services.ExternalSources.Core.ExternalSourcesNavigationMode.Sources, "Navigation mode")]
        public JetBrains.ReSharper.Feature.Services.ExternalSources.Core.ExternalSourcesNavigationMode NavigationMode;
    }
    [JetBrains.Application.Configuration.Upgrade.GlobalSettingsUpgraderAttribute()]
    public class ExternalSourcesSettingsConverter : JetBrains.Application.Configuration.Upgrade.IGlobalSettingsUpgrader, JetBrains.Application.Configuration.Upgrade.ISettingsUpgrader
    {
        public void Upgrade(JetBrains.Application.Configuration.IComponentSettingsProvider legacySettingsProvider, JetBrains.Application.Settings.IContextBoundSettingsStore boundSettingsStore, JetBrains.DataFlow.Lifetime upgradeLifetime) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class ExternalSourcesSettingsDumper : JetBrains.Application.IExternalSourcesDebugInfoProvider
    {
        public ExternalSourcesSettingsDumper(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.ProjectModel.ISolution solution, JetBrains.Application.DataContext.DataContexts dataContexts) { }
        public void Dump(System.IO.TextWriter sw) { }
    }
    public interface IDecompilationCache
    {
        bool CanBeCachedFile(string decompilerId, JetBrains.Util.FileSystemPath file);
        void ClearCache();
        JetBrains.ReSharper.Feature.Services.ExternalSources.Core.DecompilationCacheItem GetCacheItem(JetBrains.Util.FileSystemPath file);
        JetBrains.ReSharper.Feature.Services.ExternalSources.Core.DecompilationCacheItem GetCacheItem(string decompilerId, JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IAssembly assembly, string moniker, string fileName);
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Feature.Services.ExternalSources.Core.DecompilationCacheItem PutCacheItem(string decompilerId, JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IAssembly assembly, string moniker, string fileName, System.Collections.Generic.IDictionary<string, string> properties, string content);
    }
    public interface IExternalSourcesDefinesManager
    {
        JetBrains.ReSharper.Psi.PreProcessingDirective[] GetPreProcessingDirectives([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Modules.IPsiModule psiModule, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext resolveContext);
    }
    public interface IExternalSourcesDefinesProvider
    {
        JetBrains.ReSharper.Psi.PreProcessingDirective[] GetPreProcessingDirectives([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Modules.IPsiModule psiModule, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext resolveContext);
    }
    public interface IExternalSourcesMappingChangeManager
    {
        System.DateTime LastMappingChanged { get; }
        JetBrains.DataFlow.ISimpleSignal MappingChanged { get; }
        void FireMappingChanged();
        void UpdateLastMappingChanged();
    }
    public interface IExternalSourcesProvider
    {
        [JetBrains.Annotations.NotNullAttribute()]
        string Id { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        string PresentableShortName { get; }
        int Priority { get; }
        bool IsApplicable([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Feature.Services.Navigation.CompiledElementNavigationInfo navigationInfo);
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Feature.Services.ExternalSources.Core.Impl.ExternalSourcesMapping MapFileToAssembly([JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath file);
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.DataStructures.IReadOnlyCollection<JetBrains.ReSharper.Feature.Services.ExternalSources.Core.Impl.ExternalSourcesMapping> NavigateToSources([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.ICompiledElement compiledElement, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Progress.ITaskExecutor taskExecutor);
    }
    public interface IExternalSourcesService
    {
        JetBrains.DataStructures.IReadOnlyList<JetBrains.ReSharper.Feature.Services.ExternalSources.Core.IExternalSourcesProvider> OrderedProviders { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IPsiSourceFile GetOrCreateSourceFile(JetBrains.Util.FileSystemPath location, JetBrains.ReSharper.Psi.Modules.IAssemblyPsiModule assemblyPsiModule, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext resolveContext);
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.IPsiSourceFile GetOrCreateSourceFile(JetBrains.ProjectModel.IProjectFile projectFile);
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.DataStructures.IReadOnlyCollection<JetBrains.ReSharper.Feature.Services.ExternalSources.Core.Impl.ExternalSourcesMapping> NavigateToSources([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.ICompiledElement compiledElement, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.ExternalSources.Core.IExternalSourcesProvider> providers);
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Feature.Services.ExternalSources.Core.Impl.ExternalSourcesMapping TryGetMapping([JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath file);
    }
}
namespace JetBrains.ReSharper.Feature.Services.ExternalSources.Core.Impl
{
    
    [JetBrains.ReSharper.Psi.PsiComponentAttribute()]
    public class DeclaredElementBinderService : JetBrains.ReSharper.Psi.Caches.IPsiCache
    {
        protected readonly JetBrains.DataFlow.IProperty<bool> myFailOnUnresolvedSymbols;
        public DeclaredElementBinderService(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.Psi.Files.IPsiFiles psiFiles, JetBrains.ReSharper.Psi.ILanguageManager languageManager) { }
        public void Invalidate(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.PsiChangedElementType elementType) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class DecompilationCacheImpl : JetBrains.Application.IExternalSourcesDebugInfoProvider, JetBrains.ReSharper.Feature.Services.ExternalSources.Core.IDecompilationCache
    {
        public DecompilationCacheImpl(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Psi.IPsiConfiguration cacheSettings, JetBrains.ReSharper.Feature.Services.ExternalSources.Core.Impl.InfoFileContentGenerationService infoFileContentGenerationService, JetBrains.ReSharper.Psi.IPsiConfiguration psiConfiguration, JetBrains.ProjectModel.Model2.Assemblies.Impl.AssemblyCollection assemblyCollection, JetBrains.DocumentManagers.DocumentManager documentManager, JetBrains.TextControl.TextControlManager textControlManager, JetBrains.DocumentManagers.impl.DocumentManagerOperations documentOperations) { }
        public virtual bool CanBeCachedFile([JetBrains.Annotations.NotNullAttribute()] string decompilerId, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath file) { }
        public virtual void ClearCache() { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public virtual JetBrains.ReSharper.Feature.Services.ExternalSources.Core.DecompilationCacheItem GetCacheItem([JetBrains.Annotations.NotNullAttribute()] string decompilerId, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IAssembly assembly, [JetBrains.Annotations.NotNullAttribute()] string moniker, [JetBrains.Annotations.NotNullAttribute()] string fileName) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public virtual JetBrains.ReSharper.Feature.Services.ExternalSources.Core.DecompilationCacheItem GetCacheItem([JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath file) { }
        public virtual JetBrains.ReSharper.Feature.Services.ExternalSources.Core.DecompilationCacheItem PutCacheItem(string decompilerId, JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IAssembly assembly, string moniker, string fileName, System.Collections.Generic.IDictionary<string, string> properties, [JetBrains.Annotations.NotNullAttribute()] string content) { }
        public bool ReplaceTextControlContent(JetBrains.Util.FileSystemPath file, string newContent) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class ExternalSourcesDefinesManagerImpl : JetBrains.ReSharper.Feature.Services.ExternalSources.Core.IExternalSourcesDefinesManager
    {
        public ExternalSourcesDefinesManagerImpl(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.ExternalSources.Core.IExternalSourcesDefinesProvider> providers) { }
        public JetBrains.ReSharper.Psi.PreProcessingDirective[] GetPreProcessingDirectives(JetBrains.ReSharper.Psi.Modules.IPsiModule psiModule, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext resolveContext) { }
    }
    public class ExternalSourcesMapping
    {
        public ExternalSourcesMapping([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IAssembly assembly, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath file, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Feature.Services.ExternalSources.Core.IExternalSourcesProvider provider, bool isUserFile) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IAssembly Assembly { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.Util.FileSystemPath File { get; }
        public bool IsUserFile { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.Feature.Services.ExternalSources.Core.IExternalSourcesProvider Provider { get; }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class ExternalSourcesMappingChangeManagerImpl : JetBrains.ReSharper.Feature.Services.ExternalSources.Core.IExternalSourcesMappingChangeManager
    {
        public ExternalSourcesMappingChangeManagerImpl(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.Feature.Services.ExternalSources.Core.ExternalSourcesActivation externalSourcesActivation) { }
        public System.DateTime LastMappingChanged { get; }
        public JetBrains.DataFlow.ISimpleSignal MappingChanged { get; }
        public void FireMappingChanged() { }
        public void UpdateLastMappingChanged() { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class ExternalSourcesPsiSourceFiles
    {
        public ExternalSourcesPsiSourceFiles(JetBrains.ProjectModel.ISolution solution, JetBrains.ProjectModel.IProjectFileExtensions projectFileExtensions, JetBrains.ReSharper.Psi.PsiProjectFileTypeCoordinator projectFileTypeCoordinator, JetBrains.ReSharper.Feature.Services.ExternalSources.Core.IExternalSourcesDefinesManager externalSourcesDefinesManager, JetBrains.DocumentManagers.DocumentManager documentManager, JetBrains.ProjectModel.impl.ViewableProjectsCollection projects, JetBrains.Application.ChangeManager changeManager) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class ExternalSourcesServiceImpl : JetBrains.Application.IExternalSourcesDebugInfoProvider, JetBrains.ReSharper.Feature.Services.ExternalSources.Core.IExternalSourcesService
    {
        public ExternalSourcesServiceImpl(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Psi.Modules.IPsiModules modules, JetBrains.Threading.IThreading threading, JetBrains.DataFlow.IViewable<JetBrains.ReSharper.Feature.Services.ExternalSources.Core.IExternalSourcesProvider> providers, JetBrains.ReSharper.Feature.Services.ExternalSources.Core.IExternalSourcesMappingChangeManager mappingChangeManager, JetBrains.Application.IShellLocks locks, JetBrains.ReSharper.Feature.Services.ExternalSources.Core.ExternalSourcesActivation externalSourcesActivation, JetBrains.ReSharper.Feature.Services.ExternalSources.Core.Impl.ExternalSourcesPsiSourceFiles sourceFiles, JetBrains.Application.ChangeManager changeManager) { }
        public JetBrains.DataStructures.IReadOnlyList<JetBrains.ReSharper.Feature.Services.ExternalSources.Core.IExternalSourcesProvider> OrderedProviders { get; }
        public JetBrains.ReSharper.Psi.IPsiSourceFile GetOrCreateSourceFile(JetBrains.Util.FileSystemPath location, JetBrains.ReSharper.Psi.Modules.IAssemblyPsiModule assemblyPsiModule, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext resolveContext) { }
        public JetBrains.ReSharper.Psi.IPsiSourceFile GetOrCreateSourceFile(JetBrains.ProjectModel.IProjectFile projectFile) { }
        public JetBrains.DataStructures.IReadOnlyCollection<JetBrains.ReSharper.Feature.Services.ExternalSources.Core.Impl.ExternalSourcesMapping> NavigateToSources(JetBrains.ReSharper.Psi.ICompiledElement compiledElement, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.ExternalSources.Core.IExternalSourcesProvider> providers) { }
        public JetBrains.ReSharper.Feature.Services.ExternalSources.Core.Impl.ExternalSourcesMapping TryGetMapping(JetBrains.Util.FileSystemPath file) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class InfoFileContentGenerationService
    {
        public InfoFileContentGenerationService() { }
        public void ClearCaches() { }
        public string GetInfoFileContentCached(JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IAssembly assembly) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class InfoFileContentInvalidator : JetBrains.Application.IChangeProvider
    {
        public InfoFileContentInvalidator(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.Psi.Modules.IPsiModules psiModules, JetBrains.Application.ChangeManager changeManager, JetBrains.ReSharper.Feature.Services.ExternalSources.Core.Impl.InfoFileContentGenerationService generationService) { }
        public object Execute(JetBrains.Application.IChangeMap changeMap) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.ExternalSources.MetadataTranslator
{
    
    public interface IMetadataTranslator
    {
        bool IsAvailable { get; }
        bool IsMethodBodiesDecompilationSupported { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        string TranslateAssemblyInfo([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Modules.IAssemblyPsiModule context, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext resolveContext);
        [JetBrains.Annotations.CanBeNullAttribute()]
        string TranslateTopLevelTypeElement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.ITypeElement element, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Modules.IAssemblyPsiModule context, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Feature.Services.ExternalSources.MetadataTranslator.MetadataTranslatorOptions options, JetBrains.Application.Progress.IProgressIndicator indicator);
    }
    public class MetadataTranslatorOptions
    {
        public bool AddPartialModifier { get; set; }
        public bool ContainsUnsafeCode { get; set; }
        public bool DecompileMethodBodies { get; set; }
        public bool DescribeTypeLocation { get; set; }
        public bool ReorderMembers { get; set; }
        public bool ShowCompilerGeneratedCode { get; set; }
        public bool ShowNonVisibleMembers { get; set; }
        public bool ShowXmlDoc { get; set; }
    }
}
namespace JetBrains.ReSharper.Feature.Services.ExternalSources.Occurences
{
    
    [JetBrains.ReSharper.Feature.Services.Occurences.OccurenceProviderAttribute(Priority=10)]
    public class AssemblyAttributeOccurenceProvider : JetBrains.ReSharper.Feature.Services.Occurences.IOccurenceProvider
    {
        public JetBrains.ReSharper.Feature.Services.Search.IOccurence MakeOccurence(JetBrains.ReSharper.Psi.Search.FindResult findResult) { }
    }
    [JetBrains.ReSharper.Feature.Services.Occurences.Presentation.OccurencePresenterAttribute()]
    public class AssemblyInfoOccurencePresenter : JetBrains.ReSharper.Feature.Services.Occurences.Presentation.IOccurencePresenter
    {
        public bool IsApplicable(JetBrains.ReSharper.Feature.Services.Search.IOccurence occurence) { }
        public bool Present(JetBrains.UI.PopupMenu.IMenuItemDescriptor descriptor, JetBrains.ReSharper.Feature.Services.Search.IOccurence occurence, JetBrains.ReSharper.Feature.Services.Occurences.OccurencePresentationOptions occurencePresentationOptions) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.ExternalSources.Pdb.Cache
{
    
    public interface IPdbCacheManager
    {
        JetBrains.ReSharper.Feature.Services.ExternalSources.Pdb.PdbInfo GetAssemblyFileDebugInformation(JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IAssemblyFile assemblyFile);
        JetBrains.DataStructures.IReadOnlyCollection<JetBrains.ReSharper.Feature.Services.ExternalSources.Pdb.PdbInfo> GetCurrentPdbs();
        void RescanAllIfNeeded();
        void RescanIfNeeded(JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IAssemblyFile assembly);
        void WaitForCaches();
    }
    public interface IPdbInformationChangeManager
    {
        JetBrains.DataFlow.ISimpleSignal InformationChanged { get; }
    }
    public class ParsedPdbDiskStorage : JetBrains.ReSharper.Feature.Services.ExternalSources.Utils.AbstractKeyValueStorage<JetBrains.Util.FileSystemPath, JetBrains.Metadata.Utils.Pdb.ParsedPdb>
    {
        public ParsedPdbDiskStorage(JetBrains.Util.FileSystemPath cacheDirectory) { }
        protected override string GetKeyStrongHash(JetBrains.Util.FileSystemPath key) { }
        protected override JetBrains.Metadata.Utils.Pdb.ParsedPdb ReadValue(JetBrains.Util.FileSystemPath key, System.IO.BinaryReader reader) { }
        protected override void WriteValue(JetBrains.Util.FileSystemPath key, JetBrains.Metadata.Utils.Pdb.ParsedPdb value, System.IO.BinaryWriter writer) { }
    }
    public class ParsedPdbMemoryStorage : JetBrains.ReSharper.Feature.Services.ExternalSources.Utils.MemoryKeyValueStorage<JetBrains.Util.FileSystemPath, JetBrains.Metadata.Utils.Pdb.ParsedPdb>
    {
        protected override string GetKeyStrongHash(JetBrains.Util.FileSystemPath key) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class PdbCacheManagerImpl : JetBrains.Application.IChangeProvider, JetBrains.Application.IExternalSourcesDebugInfoProvider, JetBrains.ReSharper.Feature.Services.ExternalSources.Pdb.Cache.IPdbCacheManager
    {
        public PdbCacheManagerImpl(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.ISolution solution, JetBrains.Application.ChangeManager changeManager, JetBrains.ReSharper.Psi.Modules.IPsiModules psiModules, JetBrains.ReSharper.Feature.Services.ExternalSources.Pdb.Cache.IPdbInformationChangeManager pdbInformationChangeManager, JetBrains.ReSharper.Psi.IPsiConfiguration psiConfiguration, JetBrains.ReSharper.Psi.Caches.IPsiCaches psiCaches, JetBrains.ReSharper.Feature.Services.ExternalSources.Pdb.Cache.PdbScanner pdbScanner, JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IAssemblyCollection assemblyCollection, JetBrains.Application.IShellLocks shellLocks, JetBrains.ReSharper.Feature.Services.ExternalSources.Core.ExternalSourcesActivation externalSourcesActivation, JetBrains.ProjectModel.Tasks.ISolutionLoadTasksScheduler scheduler) { }
        public object Execute(JetBrains.Application.IChangeMap changeMap) { }
        public virtual JetBrains.ReSharper.Feature.Services.ExternalSources.Pdb.PdbInfo GetAssemblyFileDebugInformation(JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IAssemblyFile assembly) { }
        public virtual JetBrains.DataStructures.IReadOnlyCollection<JetBrains.ReSharper.Feature.Services.ExternalSources.Pdb.PdbInfo> GetCurrentPdbs() { }
        public void Release() { }
        public virtual void RescanAllIfNeeded() { }
        public virtual void RescanIfNeeded(JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IAssemblyFile assembly) { }
        public void WaitForAliveCaches() { }
        public virtual void WaitForCaches() { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class PdbChangesFromFileSystemChanges
    {
        public PdbChangesFromFileSystemChanges(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.FileSystemTracker.IFileSystemTracker fileSystemTracker, JetBrains.DataFlow.IViewable<JetBrains.Symbols.SymbolsCache.IDirectorySymbolsCache> symbolsCaches, JetBrains.Threading.IThreading invocator, JetBrains.ReSharper.Feature.Services.ExternalSources.Pdb.Cache.PdbScanner pdbScanner) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class PdbChangesNearAssembliesAdviser : JetBrains.Application.IChangeProvider
    {
        public PdbChangesNearAssembliesAdviser(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.ChangeManager changeManager, JetBrains.ReSharper.Psi.Modules.IPsiModules psiModules, JetBrains.Application.FileSystemTracker.IFileSystemTracker fileSystemTracker) { }
        public object Execute(JetBrains.Application.IChangeMap changeMap) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class PdbScanner
    {
        public readonly JetBrains.DataFlow.ISimpleSignal CachesDropped;
        public readonly JetBrains.DataFlow.ISignal<JetBrains.Util.FileSystemPath> CachesForAssemblyFileDropped;
        public PdbScanner(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Symbols.Providers.ISymbolsProvidersManager symbolsProvidersManager, JetBrains.ProjectModel.SolutionsManager solutionsManager) { }
        public JetBrains.Util.FileSystemPath[] AssemblyFiles { get; }
        public JetBrains.DataStructures.IReadOnlyCollection<JetBrains.ReSharper.Feature.Services.ExternalSources.Pdb.PdbInfo> CurrentPdbInfos { get; }
        public void DropCaches() { }
        public void DropCachesForAssemblyFile(JetBrains.Util.FileSystemPath assemblyFile) { }
        public JetBrains.ReSharper.Feature.Services.ExternalSources.Pdb.PdbInfo GetCachedPdbInfo(JetBrains.Util.FileSystemPath location) { }
        public JetBrains.ReSharper.Feature.Services.ExternalSources.Pdb.PdbInfo GetUpdatedPdbInfo(JetBrains.Util.FileSystemPath assemblyFile, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Feature.Services.ExternalSources.Pdb.PdbInfo oldInfo) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.ExternalSources.Pdb
{
    
    public sealed class FolderSubstitution
    {
        public FolderSubstitution([JetBrains.Annotations.NotNullAttribute()] string sourceFolder, [JetBrains.Annotations.NotNullAttribute()] string targetFolder, bool enabled) { }
        public bool Enabled { get; }
        public bool Incomplete { get; }
        public string SourceFolder { get; }
        public string TargetFolder { get; }
        public override bool Equals(object obj) { }
        public static JetBrains.DataStructures.ImmutableArray<JetBrains.ReSharper.Feature.Services.ExternalSources.Pdb.FolderSubstitution> FromSettings(JetBrains.Application.Settings.IContextBoundSettingsStore settingsStore, JetBrains.Application.Settings.SettingsIndexedEntry folderSubstitutionsSettingsEntry) { }
        public override int GetHashCode() { }
        public static JetBrains.ReSharper.Feature.Services.ExternalSources.Pdb.FolderSubstitution ReadFromXml(System.Xml.XmlElement element) { }
        public JetBrains.ReSharper.Feature.Services.ExternalSources.Pdb.FolderSubstitution SetEnabled(bool enabled) { }
        public static void ToSettings(JetBrains.Application.Settings.IContextBoundSettingsStore settingsStore, JetBrains.Application.Settings.SettingsIndexedEntry folderSubstitutionsSettingsEntry, JetBrains.DataStructures.ImmutableArray<JetBrains.ReSharper.Feature.Services.ExternalSources.Pdb.FolderSubstitution> folderSubstitutions) { }
        public override string ToString() { }
        public static void WriteToXml(System.Xml.XmlElement element, JetBrains.ReSharper.Feature.Services.ExternalSources.Pdb.FolderSubstitution substitution) { }
    }
    public interface IPdbService
    {
        void DownloadSourceFilesForTypeIfNeeded([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IAssemblyFile assemblyFile, JetBrains.ReSharper.Psi.IClrTypeName typeName, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Progress.IProgressIndicator progressIndicator);
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Feature.Services.ExternalSources.Pdb.PdbInfo GetPdbInformation(JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IAssemblyFile assemblyFile);
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Feature.Services.ExternalSources.Pdb.PdbSourceFile GetPdbSourceFile(JetBrains.Util.FileSystemPath path);
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.DataStructures.IReadOnlyCollection<JetBrains.ReSharper.Feature.Services.ExternalSources.Pdb.PdbSourceFile> GetTypeFiles(JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IAssemblyFile assembly, JetBrains.ReSharper.Psi.IClrTypeName typeName);
    }
    public class PdbInfo
    {
        public PdbInfo(JetBrains.Util.FileSystemPath assemblyFilePath, JetBrains.Util.FileSystemPath pdbPath, JetBrains.Metadata.Utils.Pdb.ParsedPdb parsedPdb) { }
        public JetBrains.Util.FileSystemPath AssemblyFilePath { get; }
        public JetBrains.Util.FileSystemPath PdbPath { get; }
        public JetBrains.Metadata.Utils.Pdb.SrcSrv.SrcSrvInfo SrcSrvInfo { get; }
        public System.DateTime Timestamp { get; }
        public JetBrains.Util.DataStructures.CompactOneToListMap<string, string> Type2FilesMapping { get; }
        public System.Collections.Generic.IEnumerable<string> GetTypeFiles(string type) { }
        public bool ReferencesFile(JetBrains.Util.FileSystemPath filePath) { }
        public override string ToString() { }
    }
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(JetBrains.ReSharper.Feature.Services.ExternalSources.Core.ExternalSourcesSettings), "Symbol files usage options")]
    public class PdbNavigationSettings
    {
        [JetBrains.Application.Settings.SettingsEntryAttribute(true, "Download symbol files from symbol server(s)")]
        public bool Download;
        [JetBrains.Application.Settings.SettingsIndexedEntryAttribute("Folder substitutions used in searching for local sources")]
        public JetBrains.Application.Settings.Store.IIndexedEntry<string, string> FolderSubstitutions;
        [JetBrains.Application.Settings.SettingsEntryAttribute(true, "Use symbol files to get compiled code sources")]
        public bool UseSymbolFiles;
    }
    [JetBrains.Application.Configuration.Upgrade.GlobalSettingsUpgraderAttribute()]
    public class PdbOptionsConverter : JetBrains.Application.Configuration.Upgrade.IGlobalSettingsUpgrader, JetBrains.Application.Configuration.Upgrade.ISettingsUpgrader
    {
        public void Upgrade(JetBrains.Application.Configuration.IComponentSettingsProvider legacySettingsProvider, JetBrains.Application.Settings.IContextBoundSettingsStore boundSettingsStore, JetBrains.DataFlow.Lifetime upgradeLifetime) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class PdbOptionsDumper : JetBrains.Application.IExternalSourcesDebugInfoProvider
    {
        public PdbOptionsDumper(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.ProjectModel.ISolution solution, JetBrains.Application.DataContext.DataContexts dataContexts) { }
        public void Dump(System.IO.TextWriter sw) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class PdbServiceImpl : JetBrains.Application.IExternalSourcesDebugInfoProvider, JetBrains.ReSharper.Feature.Services.ExternalSources.Pdb.IPdbService
    {
        public PdbServiceImpl(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.ISolution solution, JetBrains.Symbols.SourcesCache sourcesCache, JetBrains.Symbols.ISourcesDownloader sourcesDownloader, JetBrains.ReSharper.Feature.Services.ExternalSources.Pdb.Cache.IPdbCacheManager pdbCacheManager, JetBrains.ReSharper.Feature.Services.ExternalSources.Pdb.Cache.IPdbInformationChangeManager informationChangeManager, JetBrains.ReSharper.Feature.Services.ExternalSources.Core.IExternalSourcesMappingChangeManager externalSourcesMappingChangeManager, JetBrains.ProjectModel.Model2.Assemblies.Impl.AssemblyCollection assemblyCollection, JetBrains.ReSharper.Feature.Services.ExternalSources.Core.ExternalSourcesActivation externalSourcesActivation, JetBrains.Application.Settings.ISettingsStore settingsStore) { }
        public void DownloadSourceFilesForTypeIfNeeded(JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IAssemblyFile assembly, JetBrains.ReSharper.Psi.IClrTypeName typeName, JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
        public JetBrains.ReSharper.Feature.Services.ExternalSources.Pdb.PdbInfo GetPdbInformation(JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IAssemblyFile assemblyFile) { }
        public JetBrains.ReSharper.Feature.Services.ExternalSources.Pdb.PdbSourceFile GetPdbSourceFile(JetBrains.Util.FileSystemPath path) { }
        public JetBrains.DataStructures.IReadOnlyCollection<JetBrains.ReSharper.Feature.Services.ExternalSources.Pdb.PdbSourceFile> GetTypeFiles(JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IAssemblyFile assembly, JetBrains.ReSharper.Psi.IClrTypeName typeName) { }
    }
    public class PdbSourceFile
    {
        public PdbSourceFile([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IAssemblyFile assemblyFile, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath file, bool isUserFile) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IAssemblyFile AssemblyFile { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.Util.FileSystemPath File { get; }
        public bool IsUserFile { get; }
    }
}
namespace JetBrains.ReSharper.Feature.Services.ExternalSources.ReferenceSource
{
    
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class ReferenceSourceDefinesProvider : JetBrains.ReSharper.Feature.Services.ExternalSources.Core.IExternalSourcesDefinesProvider
    {
        public JetBrains.ReSharper.Psi.PreProcessingDirective[] GetPreProcessingDirectives(JetBrains.ReSharper.Psi.Modules.IPsiModule psiModule, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext resolveContext) { }
    }
    public class static ReferenceSourceUtilsPsi
    {
        public static bool IsRelatedToReferenceSource(JetBrains.ReSharper.Psi.Modules.IPsiModule psiModule, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext resolveContext) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.ExternalSources.Utils
{
    
    public abstract class AbstractKeyValueStorage<TKey, TValue> : JetBrains.ReSharper.Feature.Services.ExternalSources.Utils.IKeyValueStorage<TKey, TValue>, System.IDisposable
        where TKey :  class, System.IEquatable<>
        where TValue :  class
    {
        protected AbstractKeyValueStorage(JetBrains.Util.FileSystemPath cacheDirectory, int formatVersion) { }
        public void Dispose() { }
        public TValue Get(TKey key) { }
        protected abstract string GetKeyStrongHash(TKey key);
        protected abstract TValue ReadValue(TKey key, System.IO.BinaryReader reader);
        public void Remove(TKey key) { }
        public void Set(TKey key, TValue value) { }
        protected abstract void WriteValue(TKey key, TValue value, System.IO.BinaryWriter writer);
    }
    public class static CacheDirectoryUtil
    {
        public static JetBrains.Util.FileSystemPath CreateCache(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Util.FileSystemPath solutionCacheFolder, bool persistCaches, string cacheName) { }
    }
    public class CodeTextWriter : JetBrains.ReSharper.Feature.Services.ExternalSources.Utils.ICodeTextWriter
    {
        public CodeTextWriter(bool projectionIsUsed, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext resolveContext) { }
        public int Indent { get; set; }
        public int IndentSize { get; set; }
        public JetBrains.ReSharper.Feature.Services.ExternalSources.Utils.ICodeTextWriter AppendNewLine() { }
        public JetBrains.ReSharper.Feature.Services.ExternalSources.Utils.ICodeTextWriter AppendText(string s) { }
        public JetBrains.ReSharper.Feature.Services.ExternalSources.Utils.ICodeTextWriter AppendTypeName(JetBrains.ReSharper.Psi.ClrTypeName clrTypeName) { }
        public JetBrains.Util.Pair<string, JetBrains.ReSharper.Feature.Services.ExternalSources.Utils.CodeTextWriter.OptimizeImportsResult> GetText(JetBrains.ReSharper.Psi.Modules.IPsiModule context, System.Collections.Generic.List<string> ownNamespaces) { }
        public class OptimizeImportsResult
        {
            public string[] ImportedNamespaces { get; set; }
            public JetBrains.Util.DataStructures.CompactMap<string, string> QualifiedTypeNameToPresentation { get; set; }
        }
    }
    public class static CodeTextWriterEx
    {
        public static JetBrains.ReSharper.Feature.Services.ExternalSources.Utils.ICodeTextWriter AppendDelimited<T>(this JetBrains.ReSharper.Feature.Services.ExternalSources.Utils.ICodeTextWriter writer, string delimiter, System.Collections.Generic.IEnumerable<T> enumerable, System.Action<T, JetBrains.ReSharper.Feature.Services.ExternalSources.Utils.ICodeTextWriter> action) { }
        public static JetBrains.ReSharper.Feature.Services.ExternalSources.Utils.ICodeTextWriter AppendTextIf(this JetBrains.ReSharper.Feature.Services.ExternalSources.Utils.ICodeTextWriter writer, bool condition, string s) { }
        public static System.IDisposable Brace(this JetBrains.ReSharper.Feature.Services.ExternalSources.Utils.ICodeTextWriter writer) { }
        public static System.IDisposable Indent(this JetBrains.ReSharper.Feature.Services.ExternalSources.Utils.ICodeTextWriter writer) { }
    }
    public class static CompiledModuleNamespacesUtil
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.INamespace GetDefaultNamespace([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Modules.IPsiModule psiModule, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext resolveContext) { }
        public static string[] GetPreimportedNamespaces([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Modules.IPsiModule psiModule, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext resolveContext) { }
    }
    public abstract class DeclaredElementBinder
    {
        public abstract void BindDeclarations([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.IFile file, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Modules.IPsiModule psiModule, bool failOnUnresolvedSymbols);
    }
    public class static DeclaredElementBinderUtils
    {
        public static void BindParameters(JetBrains.ReSharper.Psi.Tree.IParametersOwnerDeclaration declaration, JetBrains.ReSharper.Psi.IParametersOwner declaredElement) { }
        public static void BindTypeMembersToDeclaredElementsUsingXmlDocId(JetBrains.ReSharper.Psi.Tree.ITypeDeclaration typeDeclaration, bool failOnUnresolvedSymbols) { }
    }
    public class static DeclaredElementUtil
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.ITypeElement GetTopLevelTypeElement(JetBrains.ReSharper.Psi.IClrDeclaredElement declaredElement) { }
    }
    public class static EscapingFileNameUtil
    {
        public static string EscapeFileName(string fileName) { }
        public static string EscapePathName(string path) { }
        public static string UnescapeFileName(string fileName) { }
    }
    public class static ExtensionMethods
    {
        public static void Dump<TK, TV>(this System.Collections.Generic.IDictionary<TK, TV> dict, System.Text.StringBuilder builder) { }
        public static void DumpOneToListMap<TK, TV>(this JetBrains.Util.DataStructures.CompactOneToListMap<TK, TV> map, System.Text.StringBuilder builder) { }
        public static string DumpToString<TK, TV>(this System.Collections.Generic.IDictionary<TK, TV> dict) { }
        public static string EnsureEndsWithNewLine(this string s) { }
        public static JetBrains.ReSharper.Psi.IPsiAssembly[] GetAllPsiAssemblies([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Modules.IPsiModules psiModules) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.IPsiAssembly GetPsiAssembly([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Modules.IPsiModules psiModules, JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IAssemblyFile assemblyFile) { }
        public static void ReadValueFromXmlAttribute<T>(this JetBrains.DataFlow.IProperty<T> property, System.Xml.XmlElement element, T defaultValue)
            where T :  struct { }
        public static void ReadValueFromXmlAttribute(this JetBrains.DataFlow.IProperty<string> property, System.Xml.XmlElement element, string defaultValue) { }
        public static void WriteToXmlAttribute<T>(this JetBrains.DataFlow.IProperty<T> property, System.Xml.XmlElement element) { }
    }
    public interface ICodeTextWriter
    {
        int Indent { get; set; }
        JetBrains.ReSharper.Feature.Services.ExternalSources.Utils.ICodeTextWriter AppendNewLine();
        JetBrains.ReSharper.Feature.Services.ExternalSources.Utils.ICodeTextWriter AppendText(string text);
        JetBrains.ReSharper.Feature.Services.ExternalSources.Utils.ICodeTextWriter AppendTypeName(JetBrains.ReSharper.Psi.ClrTypeName clrTypeName);
    }
    public interface IKeyValueStorage<TKey, TValue>
    
        where TValue :  class
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        TValue Get([JetBrains.Annotations.NotNullAttribute()] TKey key);
        void Remove([JetBrains.Annotations.NotNullAttribute()] TKey key);
        void Set([JetBrains.Annotations.NotNullAttribute()] TKey key, [JetBrains.Annotations.NotNullAttribute()] TValue value);
    }
    public interface IReorderMembers
    {
        void ReorderMembers([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.IFile file);
    }
    public class static LanguagesUtils
    {
        public static JetBrains.Util.JetTuple<JetBrains.ReSharper.Psi.PsiLanguageType, string> GetCSharpLanguageAndExtension() { }
        public static JetBrains.Util.JetTuple<JetBrains.ReSharper.Psi.PsiLanguageType, string> GetLanguageAndExtension(JetBrains.ReSharper.Psi.PsiLanguageType language) { }
        public static JetBrains.Util.JetTuple<JetBrains.ReSharper.Psi.PsiLanguageType, string> GetLanguageAndExtension() { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static string GetLanguageExtensionNoDot(JetBrains.ReSharper.Psi.PsiLanguageType psiLanguageType) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static string GetLanguageExtensionWithDot(JetBrains.ReSharper.Psi.PsiLanguageType psiLanguageType) { }
        public static System.Collections.Generic.List<JetBrains.ReSharper.Psi.PsiLanguageType> GetLanguages() { }
        public static bool IsTranslatorAvailable(JetBrains.ReSharper.Psi.PsiLanguageType language) { }
        public static JetBrains.ReSharper.Psi.PsiLanguageType PickLanguage() { }
    }
    public abstract class MemoryKeyValueStorage<TKey, TValue> : JetBrains.ReSharper.Feature.Services.ExternalSources.Utils.IKeyValueStorage<TKey, TValue>
        where TKey :  class, System.IEquatable<>
        where TValue :  class
    {
        protected MemoryKeyValueStorage() { }
        public TValue Get([JetBrains.Annotations.NotNullAttribute()] TKey key) { }
        protected abstract string GetKeyStrongHash(TKey key);
        public void Remove([JetBrains.Annotations.NotNullAttribute()] TKey key) { }
        public void Set([JetBrains.Annotations.NotNullAttribute()] TKey key, [JetBrains.Annotations.NotNullAttribute()] TValue value) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class MetadataAccessDebugInfo : JetBrains.Application.IExternalSourcesDebugInfoProvider
    {
        public void Dump(System.IO.TextWriter sw) { }
    }
    public class static NamespaceFolderExtensions
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static string GetFolderName([JetBrains.Annotations.NotNullAttribute()] this string namespaceQualifiedName) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static string GetFolderName([JetBrains.Annotations.CanBeNullAttribute()] this JetBrains.ReSharper.Psi.INamespace ns) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static string GetRelativeFolderName([JetBrains.Annotations.CanBeNullAttribute()] this JetBrains.ReSharper.Psi.INamespace ns, [JetBrains.Annotations.CanBeNullAttribute()] string defaultNamespaceFolderName) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static string GetRelativeName([JetBrains.Annotations.NotNullAttribute()] this string name, [JetBrains.Annotations.CanBeNullAttribute()] string defaultNamespaceFolderName) { }
    }
    public class static PropertiesFile
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static System.Collections.Generic.IDictionary<string, string> ReadAllProperties([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Util.FileSystemPath file) { }
        public static void WriteAllProperties([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Util.FileSystemPath file, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IDictionary<string, string> dict) { }
    }
    public class static TypeElementFileNameExtensions
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static string NormalizeFileName([JetBrains.Annotations.NotNullAttribute()] this string fileName) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static string TryGetCSharpFileName(this JetBrains.ReSharper.Psi.ITypeElement typeElement) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static string TryGetElementCSharpFileName(this JetBrains.ReSharper.Psi.IClrDeclaredElement declaredElement) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static string TryGetFileName(this JetBrains.ReSharper.Psi.ITypeElement typeElement, JetBrains.Util.JetTuple<JetBrains.ReSharper.Psi.PsiLanguageType, string> languageAndExtensionPair) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static string TryGetRelativeCSharpFilePath(this JetBrains.ReSharper.Psi.IClrDeclaredElement declaredElement) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Xaml.XamlLanguage))]
    public class XamlDeclaredElementsBinder : JetBrains.ReSharper.Feature.Services.ExternalSources.Utils.DeclaredElementBinder
    {
        public override void BindDeclarations(JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.ReSharper.Psi.Modules.IPsiModule psiModule, bool failOnUnresolvedSymbols) { }
    }
}