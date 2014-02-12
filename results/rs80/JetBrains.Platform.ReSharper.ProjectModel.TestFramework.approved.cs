[assembly: JetBrains.Util.TestDataPathBaseAttribute("Platform\\test\\data")]
[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]

namespace JetBrains.ProjectModel.Test.Components
{
    
    public class ExtraAssemblyResolveFoldersCookie : System.IDisposable
    {
        public ExtraAssemblyResolveFoldersCookie(params JetBrains.Util.FileSystemPath[] paths) { }
        public void Dispose() { }
    }
    [JetBrains.ProjectModel.model2.Assemblies.AssemblyToAssemblyResolvers.AssemblyToAssemblyReferencesResolverAttribute(1.1D)]
    [JetBrains.ProjectModel.model2.Assemblies.ProjectToAssemblyResolvers.ProjectToAssemblyReferencesResolverAttribute(1.1D)]
    public class ExtraFoldersReferencesResolver : JetBrains.ProjectModel.model2.Assemblies.AssemblyToAssemblyResolvers.IAssemblyToAssemblyReferencesResolver, JetBrains.ProjectModel.model2.Assemblies.ProjectToAssemblyResolvers.IProjectToAssemblyReferencesResolver
    {
        public static readonly System.Collections.Generic.List<JetBrains.Util.FileSystemPath> ExtraFolders;
        public ExtraFoldersReferencesResolver(JetBrains.ProjectModel.Impl.AssemblyInfoCache assemblyInfoCache, JetBrains.ProjectModel.AssemblyNamesInterner interner) { }
        public System.Collections.Generic.IEnumerable<JetBrains.Util.FileSystemPath> ResolveReference(System.Collections.Generic.ICollection<JetBrains.Util.FileSystemPath> sourceAssemblyFile, JetBrains.Metadata.Utils.AssemblyNameInfo referenceName) { }
        public System.Collections.Generic.IEnumerable<JetBrains.Util.FileSystemPath> ResolveReference(JetBrains.ProjectModel.Model2.References.AssemblyReferenceTarget referenceTarget, JetBrains.ProjectModel.IProject referenceSource) { }
    }
    public class TestDataFrameworkLocationHelper : JetBrains.ProjectModel.impl.FrameworkDetectionHelperBase
    {
        public event System.Action DetectionDataChanged;
        public override System.Version[] EnumerateInstalledNetFrameworks() { }
        public override System.Collections.Generic.IList<JetBrains.ProjectModel.impl.LightPlatformDefinition> GetCompactPlatforms() { }
        public override System.Collections.Generic.IList<JetBrains.ProjectModel.Impl.Sdk.SdkInfo> GetDotNetSdk() { }
        protected override System.Collections.Generic.IEnumerable<JetBrains.Util.FileSystemPath> GetExtensionSdksFolders() { }
        public override System.Collections.Generic.IList<JetBrains.ProjectModel.impl.LightPlatformDefinition> GetMicroFrameworkPlatforms() { }
        [JetBrains.Annotations.NotNullAttribute()]
        protected override JetBrains.Util.FileSystemPath GetMicrosoftReferenceAssembliesRoot() { }
        public override JetBrains.Util.FileSystemPath GetMsBuildDirectory(System.Version version) { }
        public override JetBrains.Util.FileSystemPath GetNetCoreFrameworkReferenceAssembliesPath() { }
        public override JetBrains.Util.FileSystemPath[] GetNetFrameworkAssemblyFolders(System.Version version) { }
        public override JetBrains.Util.FileSystemPath GetNetFrameworkDirectory(System.Version version) { }
        public override JetBrains.Util.FileSystemPath[] GetNetFrameworkGlobalAssemblyFolders() { }
        public override JetBrains.Util.FileSystemPath GetNetFrameworkReferenceAssembliesPath() { }
        public override JetBrains.Util.FileSystemPath GetNetFrameworkV3AssembliesPath(int minorVersion) { }
        public override System.Collections.Generic.ICollection<JetBrains.Util.FileSystemPath> GetSdkInstallationFolders() { }
        public override System.Collections.Generic.IList<JetBrains.ProjectModel.impl.LightPlatformDefinition> GetSilverlightPlatforms() { }
        public override JetBrains.Util.FileSystemPath GetWindows8PlatfromSdkFolder(System.Version version) { }
        public override System.Collections.Generic.IList<JetBrains.ProjectModel.Impl.Sdk.SdkInfo> GetWindowsSdk() { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class TestPlatformsProvider : JetBrains.ProjectModel.impl.IPlatformsProvider
    {
        public JetBrains.ProjectModel.PlatformID DetectPlatformIdByReferences(JetBrains.Metadata.Utils.AssemblyNameInfo corlibReference, JetBrains.Metadata.Utils.AssemblyNameInfo[] otherReferences, System.Collections.Generic.IList<JetBrains.ProjectModel.PlatformInfo> platforms) { }
        public System.Collections.Generic.IDictionary<JetBrains.Util.FileSystemPath, JetBrains.ProjectModel.PlatformID> GetPlatformFoldersPrefixes(System.Collections.Generic.IList<JetBrains.ProjectModel.PlatformInfo> platforms) { }
        public System.Collections.Generic.IList<JetBrains.ProjectModel.PlatformInfo> GetPlatforms() { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class TestSwitchingFrameworkLocationHelper : JetBrains.ProjectModel.impl.SwitchingFrameworkLocationHelper
    {
        protected override JetBrains.ProjectModel.impl.IFrameworkDetectionHelper GetDefaultHelper() { }
    }
}
namespace JetBrains.ProjectModel.Test
{
    
    [NUnit.Framework.CategoryAttribute("Project Model")]
    public abstract class ProjectModelTestBase : JetBrains.TestShell.Infra.BaseTest
    {
        protected ProjectModelTestBase() { }
        protected JetBrains.TestFramework.ProjectModel.TestSolutionManager SolutionManager { get; }
        protected void ClearEventDump() { }
        protected System.Text.StringBuilder GetCurrentEventDump() { }
        [NUnit.Framework.SetUpAttribute()]
        public override void SetUp() { }
        [NUnit.Framework.TearDownAttribute()]
        public override void TearDown() { }
    }
}
namespace JetBrains.TestFramework.ProjectModel
{
    
    [JetBrains.Application.ShellComponentAttribute()]
    public class PlatformManagerTestImpl : JetBrains.ProjectModel.impl.PlatformManagerImpl
    {
        public static readonly System.Version DefaultVersion;
        public PlatformManagerTestImpl(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.impl.IFrameworkDetectionHelper frameworkDetectionHelper, JetBrains.DataFlow.IViewable<JetBrains.ProjectModel.impl.IPlatformsProvider> providers) { }
        public override JetBrains.Util.FileSystemPath Gac40Path { get; }
        public override JetBrains.Util.FileSystemPath GacPath { get; }
        public override JetBrains.ProjectModel.PlatformInfo GetDefaultPlatformInfo() { }
        public void RemovePlatform(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.PlatformID platformID) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class ReuseSolutionInTestsComponent
    {
        public ReuseSolutionInTestsComponent(JetBrains.DataFlow.Lifetime lifetime, JetBrains.TestFramework.ProjectModel.TestSolutionManager solutionManager, JetBrains.Application.IShellLocks locks) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ProjectModel.ISolution Solution { get; }
        public void CloseSolution() { }
        public JetBrains.ProjectModel.ISolution PrepareSolution([JetBrains.Annotations.NotNullAttribute()] System.Action<JetBrains.ProjectModel.ISolution> fillSolution, [JetBrains.Annotations.NotNullAttribute()] System.Func<JetBrains.TestFramework.ProjectModel.TestSolutionManager, JetBrains.ProjectModel.ISolution> createEmptySolution, System.Func<JetBrains.ProjectModel.ISolution, bool> canUseCurrentSolution = null) { }
    }
    [JetBrains.ProjectModel.SolutionInstanceComponentAttribute()]
    public class TestProjectModelUpdater : JetBrains.ProjectModel.Update.ProjectModelUpdater
    {
        public TestProjectModelUpdater(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.Impl.SolutionElement solution, JetBrains.Application.IShellLocks locks, JetBrains.ProjectModel.Update.ProjectReferenceFactory referenceFactory, JetBrains.ProjectModel.Transaction.IProjectModelBatchChangeManager batchChangeManager, JetBrains.ProjectModel.impl.SpecialFiles.SpecialFilesManager specialFilesManager, JetBrains.ProjectModel.Caches.ProjectFileDataCache projectFileDataCache) { }
        public override JetBrains.ProjectModel.IProject FindProject(JetBrains.ProjectModel.Update.IProjectDescriptor descriptor) { }
    }
    [JetBrains.ProjectModel.SolutionInstanceComponentAttribute()]
    public class TestSdkReferenceManager : JetBrains.ProjectModel.References.SdkReferencesManager
    {
        public TestSdkReferenceManager(JetBrains.ProjectModel.Impl.SolutionElement solution, JetBrains.Application.ChangeManager changeManager, JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.impl.NetCoreProvider netCoreProvider, JetBrains.ProjectModel.impl.IFrameworkDetectionHelper frameworkDetectionHelper) { }
        protected override void FixSdkModuleReferences(JetBrains.ProjectModel.Sdk.SdkModuleImpl referenceOwner, JetBrains.ProjectModel.Impl.SolutionElement solutionElement) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class TestSharepointFilesLocator : JetBrains.ProjectModel.Sharepoint.SharepointFilesLocatorImpl
    {
        public JetBrains.Util.FileSystemPath SharepointDllPath { get; }
        protected override JetBrains.Util.FileSystemPath InitializeRootPath() { }
    }
    [JetBrains.ProjectModel.SolutionInstanceComponentAttribute()]
    public class TestSolutionCachesConfiguration : JetBrains.ProjectModel.Caches.SolutionCachesConfiguration
    {
        public TestSolutionCachesConfiguration(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.ProjectModel.ISolution solution, JetBrains.Application.IApplicationDescriptor applicationDescriptor, JetBrains.Application.Env.Components.ProductSettingsLocation productSettingsLocation, JetBrains.ProjectModel.Settings.Storages.SolutionSettingsStoragePersonal needToBeReady, JetBrains.ProjectModel.Settings.Storages.SolutionSettingsStorageShared needToBeReady2) { }
        public override bool PersistCaches { get; }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class TestSolutionManager : JetBrains.ProjectModel.Impl.SolutionManagerImpl
    {
        public TestSolutionManager(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.Parts.IPartsCatalogueSet catalogueSet, JetBrains.Application.Components.IComponentContainer componentContainer, JetBrains.Application.ChangeManager changeManager, JetBrains.ProjectModel.Standalone.IProjectImporter projectImporter, JetBrains.Application.IShellLocks shellLocks, JetBrains.ProjectModel.PlatformManager platformManager, JetBrains.Application.Env.RunsProducts.ProductConfigurations productConfigurations, System.Collections.Generic.IEnumerable<JetBrains.ProjectModel.IQuerySolutionCloseHandler> solutionCloseHandlers, JetBrains.ProjectModel.Properties.ProjectPropertiesFactory projectPropertiesFactory, JetBrains.ProjectModel.Properties.ProjectFlavoursFactory projectFlavoursFactory, JetBrains.ProjectModel.Tasks.ISolutionLoadTasksScheduler scheduler, JetBrains.ProjectModel.Properties.ProjectFilePropertiesFactory projectFilePropertiesFactory, JetBrains.ProjectModel.IProjectFileExtensions projectFileExtensions) { }
        public JetBrains.ProjectModel.ISolution CreateSolutionWithExistingProjects(JetBrains.Util.FileSystemPath solutionFilePath, System.Action<JetBrains.ProjectModel.Impl.SolutionElement> customImporter) { }
    }
}