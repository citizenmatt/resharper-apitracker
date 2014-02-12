[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]
[assembly: System.Runtime.Versioning.TargetFrameworkAttribute(".NETFramework,Version=v4.0", FrameworkDisplayName=".NET Framework 4")]
[assembly: System.Windows.Markup.XmlnsDefinitionAttribute("urn:shemas-jetbrains-com:platform-extensions", "JetBrains.Application.Extensions")]

namespace JetBrains.Application.Extensions
{
    
    [JetBrains.Application.Env.EnvironmentComponentAttribute(JetBrains.Application.Sharing.Product)]
    public class BundledPackagesInstaller : JetBrains.Application.IOneTimeInitializationHandler
    {
        public BundledPackagesInstaller(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Threading.IThreading threading, NuGet.IPackageRepositoryFactory packageRepositoryFactory, JetBrains.Application.Extensions.IProductPackageManagerFactory productPackageManagerFactory, JetBrains.Application.Env.Components.ProductSettingsLocation productSettingsLocation, JetBrains.Util.ILogger logger) { }
        public void PerformOneTimeInitialization() { }
    }
    [JetBrains.Application.Env.EnvironmentComponentAttribute(JetBrains.Application.Sharing.Product)]
    public sealed class DeleteOnRestartManager : JetBrains.Application.Extensions.IDeleteOnRestartManager
    {
        public DeleteOnRestartManager(JetBrains.Threading.IThreading threading, JetBrains.Application.Extensions.IFileSystemProvider fileSystemProvider, JetBrains.Application.Extensions.IRepositorySettings repositorySettings) { }
        public void ClearPackageDirectoryForDeletion(NuGet.IPackage package) { }
        public void DeleteMarkedPackageDirectories() { }
        public System.Collections.Generic.IList<string> GetPackageDirectoriesMarkedForDeletion() { }
        public void MarkPackageDirectoryForDeletion(NuGet.IPackage package) { }
    }
    [JetBrains.Application.Env.EnvironmentComponentAttribute(JetBrains.Application.Sharing.Product)]
    public class EnvironmentProductPackageManagerFactory : JetBrains.Application.Extensions.ProductPackageManagerFactory
    {
        public EnvironmentProductPackageManagerFactory(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.Env.JetEnvironment environment, NuGet.IPackageRepositoryFactory packageRepositoryFactory, JetBrains.Application.Extensions.Settings.IExtensionSourceProvider extensionSourceProvider, JetBrains.Application.Extensions.NuGetRepositoryLocation nugetRepositoryLocation, JetBrains.Application.Env.Components.AnyProductSettingsLocation anyProductSettingsLocation, JetBrains.Application.Extensions.IDeleteOnRestartManager deleteOnRestartManager, JetBrains.Application.Extensions.PackageInstallerEvents packageInstallerEvents, JetBrains.Application.Extensions.IFileSystemProvider fileSystemProvider, JetBrains.Application.Extensions.ExtensionLocations extensionLocations) { }
    }
    public class FallbackRepository : NuGet.IDependencyResolver, NuGet.IOperationAwareRepository, NuGet.IPackageLookup, NuGet.IPackageRepository, NuGet.IServiceBasedRepository
    {
        public FallbackRepository(NuGet.IPackageRepository primaryRepository, NuGet.IPackageRepository dependencyResolver) { }
        public NuGet.IPackageRepository DependencyResolver { get; }
        public string Source { get; }
        public NuGet.IPackageRepository SourceRepository { get; }
        public bool SupportsPrereleasePackages { get; }
        public void AddPackage(NuGet.IPackage package) { }
        public bool Exists(string packageId, NuGet.SemanticVersion version) { }
        public NuGet.IPackage FindPackage(string packageId, NuGet.SemanticVersion version) { }
        public System.Collections.Generic.IEnumerable<NuGet.IPackage> FindPackagesById(string packageId) { }
        public System.Linq.IQueryable<NuGet.IPackage> GetPackages() { }
        public System.Collections.Generic.IEnumerable<NuGet.IPackage> GetUpdates(System.Collections.Generic.IEnumerable<NuGet.IPackage> packages, bool includePrerelease, bool includeAllVersions, System.Collections.Generic.IEnumerable<System.Runtime.Versioning.FrameworkName> targetFrameworks, System.Collections.Generic.IEnumerable<NuGet.IVersionSpec> versionConstraints) { }
        public void RemovePackage(NuGet.IPackage package) { }
        public NuGet.IPackage ResolveDependency(NuGet.PackageDependency dependency, NuGet.IPackageConstraintProvider constraintProvider, bool allowPrereleaseVersions, bool preferListedPackages) { }
        public System.Linq.IQueryable<NuGet.IPackage> Search(string searchTerm, System.Collections.Generic.IEnumerable<string> targetFrameworks, bool allowPrereleaseVersions) { }
        public System.IDisposable StartOperation(string operation, string mainPackageId) { }
    }
    [JetBrains.Application.Env.EnvironmentComponentAttribute(JetBrains.Application.Sharing.Common)]
    public class FileSystemProvider : JetBrains.Application.Extensions.IFileSystemProvider
    {
        public FileSystemProvider(JetBrains.Util.ILogger logger) { }
        public NuGet.IFileSystem GetFileSystem(string path) { }
        public NuGet.IFileSystem GetFileSystem(string path, bool ignoreSourceControlSetting) { }
    }
    public class static FileSystemProviderEx
    {
        public static NuGet.IFileSystem GetFileSystem([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.Extensions.IFileSystemProvider fileSystemProvider, JetBrains.Util.FileSystemPath path) { }
    }
    public interface IDeleteOnRestartManager
    {
        void ClearPackageDirectoryForDeletion(NuGet.IPackage package);
        void DeleteMarkedPackageDirectories();
        System.Collections.Generic.IList<string> GetPackageDirectoriesMarkedForDeletion();
        void MarkPackageDirectoryForDeletion(NuGet.IPackage package);
    }
    public interface IExtensionManagerWebProxy
    {
        bool AllowPromptForCredentials { get; set; }
    }
    public interface IFileSystemProvider
    {
        NuGet.IFileSystem GetFileSystem(string path);
        NuGet.IFileSystem GetFileSystem(string path, bool ignoreSourceControlSetting);
    }
    public interface IInteractiveProxyCredentialStore
    {
        System.Net.ICredentials GetCredentials(System.Uri uri, System.Net.IWebProxy proxy, bool authenticateProxy, bool allowPrompt);
    }
    public interface IPackageInstallerEvents
    {
        public event System.EventHandler<NuGet.PackageOperationEventArgs> PackageInstalled;
        public event System.EventHandler<NuGet.PackageOperationEventArgs> PackageInstalling;
        public event System.EventHandler<NuGet.PackageOperationEventArgs> PackageReferenceAdded;
        public event System.EventHandler<NuGet.PackageOperationEventArgs> PackageReferenceAdding;
        public event System.EventHandler<NuGet.PackageOperationEventArgs> PackageReferenceRemoved;
        public event System.EventHandler<NuGet.PackageOperationEventArgs> PackageReferenceRemoving;
        public event System.EventHandler<NuGet.PackageOperationEventArgs> PackageUninstalled;
        public event System.EventHandler<NuGet.PackageOperationEventArgs> PackageUninstalling;
    }
    public interface IPackageOperationEventListener
    {
        void OnAddPackageReferenceError(JetBrains.Application.IApplicationDescriptor project, System.Exception exception);
        void OnAfterAddPackageReference(JetBrains.Application.IApplicationDescriptor project);
        void OnBeforeAddPackageReference(JetBrains.Application.IApplicationDescriptor project);
    }
    public interface IProductPackageManager : NuGet.IPackageManager
    {
        NuGet.IProjectManager GetProjectManager(JetBrains.Application.IApplicationDescriptor project);
        void InstallPackage(System.Collections.Generic.IEnumerable<JetBrains.Application.IApplicationDescriptor> projects, NuGet.IPackage package, System.Collections.Generic.IEnumerable<NuGet.PackageOperation> operations, bool ignoreDependencies, bool allowPrereleaseVersions, NuGet.ILogger logger, JetBrains.Application.Extensions.IPackageOperationEventListener eventListener);
        void InstallPackage(NuGet.IProjectManager projectManager, string packageId, NuGet.SemanticVersion version, bool ignoreDependencies, bool allowPrereleaseVersions, NuGet.ILogger logger);
        void InstallPackage(NuGet.IProjectManager projectManager, string packageId, NuGet.SemanticVersion version, bool ignoreDependencies, bool allowPrereleaseVersions, bool skipAssemblyReferences, NuGet.ILogger logger);
        void InstallPackage(NuGet.IProjectManager projectManager, NuGet.IPackage package, System.Collections.Generic.IEnumerable<NuGet.PackageOperation> operations, bool ignoreDependencies, bool allowPrereleaseVersions, NuGet.ILogger logger);
        bool IsProjectLevel(NuGet.IPackage package);
        void ReinstallPackage(string packageId, bool updateDependencies, bool allowPrereleaseVersions, NuGet.ILogger logger, JetBrains.Application.Extensions.IPackageOperationEventListener eventListener);
        void ReinstallPackage(NuGet.IProjectManager projectManager, string packageId, bool updateDependencies, bool allowPrereleaseVersions, NuGet.ILogger logger);
        void ReinstallPackages(bool updateDependencies, bool allowPrereleaseVersions, NuGet.ILogger logger, JetBrains.Application.Extensions.IPackageOperationEventListener eventListener);
        void ReinstallPackages(NuGet.IProjectManager projectManager, bool updateDependencies, bool allowPrereleaseVersions, NuGet.ILogger logger);
        void SafeUpdatePackage(string packageId, bool updateDependencies, bool allowPrereleaseVersions, NuGet.ILogger logger, JetBrains.Application.Extensions.IPackageOperationEventListener eventListener);
        void SafeUpdatePackage(NuGet.IProjectManager projectManager, string packageId, bool updateDependencies, bool allowPrereleaseVersions, NuGet.ILogger logger);
        void SafeUpdatePackages(bool updateDependencies, bool allowPrereleaseVersions, NuGet.ILogger logger, JetBrains.Application.Extensions.IPackageOperationEventListener eventListener);
        void SafeUpdatePackages(NuGet.IProjectManager projectManager, bool updateDependencies, bool allowPrereleaseVersions, NuGet.ILogger logger);
        void UninstallPackage(NuGet.IProjectManager projectManager, string packageId, NuGet.SemanticVersion version, bool forceRemove, bool removeDependencies);
        void UninstallPackage(NuGet.IProjectManager projectManager, string packageId, NuGet.SemanticVersion version, bool forceRemove, bool removeDependencies, NuGet.ILogger logger);
        void UpdatePackage(string packageId, NuGet.SemanticVersion version, bool updateDependencies, bool allowPrereleaseVersions, NuGet.ILogger logger, JetBrains.Application.Extensions.IPackageOperationEventListener eventListener);
        void UpdatePackage(string packageId, NuGet.IVersionSpec versionSpec, bool updateDependencies, bool allowPrereleaseVersions, NuGet.ILogger logger, JetBrains.Application.Extensions.IPackageOperationEventListener eventListener);
        void UpdatePackage(NuGet.IProjectManager projectManager, string packageId, NuGet.SemanticVersion version, bool updateDependencies, bool allowPrereleaseVersions, NuGet.ILogger logger);
        void UpdatePackage(System.Collections.Generic.IEnumerable<JetBrains.Application.IApplicationDescriptor> projects, NuGet.IPackage package, System.Collections.Generic.IEnumerable<NuGet.PackageOperation> operations, bool updateDependencies, bool allowPrereleaseVersions, NuGet.ILogger logger, JetBrains.Application.Extensions.IPackageOperationEventListener eventListener);
        void UpdatePackages(bool updateDependencies, bool allowPrereleaseVersions, NuGet.ILogger logger, JetBrains.Application.Extensions.IPackageOperationEventListener eventListener);
        void UpdatePackages(NuGet.IProjectManager projectManager, bool updateDependencies, bool allowPrereleaseVersions, NuGet.ILogger logger);
        void UpdatePackages(NuGet.IProjectManager projectManager, System.Collections.Generic.IEnumerable<NuGet.IPackage> packages, System.Collections.Generic.IEnumerable<NuGet.PackageOperation> operations, bool updateDependencies, bool allowPrereleaseVersions, NuGet.ILogger logger);
        void UpdateSolutionPackages(System.Collections.Generic.IEnumerable<NuGet.IPackage> packages, System.Collections.Generic.IEnumerable<NuGet.PackageOperation> operations, bool updateDependencies, bool allowPrereleaseVersions, NuGet.ILogger logger, JetBrains.Application.Extensions.IPackageOperationEventListener eventListener);
    }
    public interface IProductPackageManagerFactory
    {
        JetBrains.Application.Extensions.IProductPackageManager CreatePackageManager();
        JetBrains.Application.Extensions.IProductPackageManager CreatePackageManager(NuGet.IPackageRepository repository, bool useFallbackForDependencies);
    }
    public interface IRepositorySettings
    {
        string ConfigFolderPath { get; }
        string RepositoryPath { get; }
    }
    public class NuGetExtension : JetBrains.Application.Extensions.IExtension, System.IEquatable<JetBrains.Application.Extensions.NuGetExtension>
    {
        public NuGetExtension(NuGet.IPackage package, JetBrains.Application.Extensions.NuGetRepositoryLocation repositoryLocation, JetBrains.Application.Extensions.ExtensionLocations extensionLocations, JetBrains.Application.IApplicationDescriptor applicationDescriptor, JetBrains.Application.Extensions.IExtensionProvider provider) { }
        public JetBrains.DataFlow.IProperty<System.Nullable<bool>> Enabled { get; }
        public string Id { get; }
        public JetBrains.Application.Extensions.IExtensionMetadata Metadata { get; }
        public JetBrains.DataFlow.ListEvents<JetBrains.Application.Extensions.ExtensionRecord> RuntimeInfoRecords { get; }
        public string SemanticVersion { get; }
        public JetBrains.Application.Extensions.IExtensionProvider Source { get; }
        public bool Supported { get; }
        public System.Version Version { get; }
        public bool Equals(JetBrains.Application.Extensions.NuGetExtension other) { }
        public override bool Equals(object obj) { }
        public System.Collections.Generic.IEnumerable<JetBrains.Util.FileSystemPath> GetFiles(string fileType) { }
        public override int GetHashCode() { }
    }
    public class NuGetExtensionCatalog : JetBrains.Application.Extensions.IExtensionCatalog
    {
        public NuGetExtensionCatalog(string name, JetBrains.Application.Extensions.IProductPackageManagerFactory packageManagerFactory, JetBrains.Application.IApplicationDescriptor applicationDescriptor, NuGet.IPackageRepository sourceRepository, NuGet.IPackageRepository localRepository) { }
        public string Name { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.Application.Extensions.IExtensionCatalogItem> GetExtensions(string searchTerm, bool includePrerelease, JetBrains.Application.Extensions.SortOrder sortOrder) { }
        public int GetExtensionsCount(string searchTerm, bool includePrerelease) { }
        public System.Collections.Generic.IEnumerable<JetBrains.Application.Extensions.IExtensionCatalogItem> GetUpdates(bool includePrerelease) { }
        public bool Install(JetBrains.Application.Extensions.IExtensionCatalogItem catalogItem, JetBrains.Application.Extensions.IExtensionCatalogActionEvents events) { }
        public bool Update(JetBrains.Application.Extensions.IExtensionCatalogItem catalogItem, JetBrains.Application.Extensions.IExtensionCatalogActionEvents events) { }
        public bool Update(System.Collections.Generic.IEnumerable<JetBrains.Application.Extensions.IExtensionCatalogItem> catalogItem, JetBrains.Application.Extensions.IExtensionCatalogActionEvents events) { }
    }
    public class NuGetExtensionCatalogItem : JetBrains.Application.Extensions.IExtensionCatalogItem
    {
        public NuGetExtensionCatalogItem(NuGet.IPackage package, JetBrains.Application.IApplicationDescriptor applicationDescriptor) { }
        public System.Uri AbuseUrl { get; }
        public System.Nullable<int> DownloadCount { get; }
        public System.Uri GalleryUrl { get; }
        public string Id { get; }
        public JetBrains.Application.Extensions.IExtensionMetadata Metadata { get; }
        public NuGet.IPackage Package { get; }
        public string ReleaseNotes { get; }
        public JetBrains.DataFlow.ListEvents<JetBrains.Application.Extensions.ExtensionRecord> RuntimeInfoRecords { get; }
        public string SemanticVersion { get; }
        public bool Supported { get; }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class NuGetExtensionCatalogProvider : JetBrains.Application.Extensions.IExtensionCatalogProvider
    {
        public NuGetExtensionCatalogProvider(NuGet.IPackageRepositoryFactory packageRepositoryFactory, JetBrains.Application.Extensions.IProductPackageManagerFactory packageManagerFactory, JetBrains.Application.IApplicationDescriptor applicationDescriptor, JetBrains.Application.Extensions.Settings.IExtensionSourceProvider sourceProvider) { }
        public JetBrains.Application.Extensions.IExtensionCatalog AggregateCatalog { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.Application.Extensions.IExtensionCatalog> Catalogs { get; }
    }
    public class NuGetExtensionMetadata : JetBrains.Application.Extensions.IExtensionMetadata
    {
        public NuGetExtensionMetadata(NuGet.IPackage package) { }
        public System.Collections.Generic.IEnumerable<string> Authors { get; }
        public string Copyright { get; }
        public System.Nullable<System.DateTimeOffset> Created { get; }
        public System.Collections.Generic.IEnumerable<string> DependencyDescriptions { get; }
        public System.Collections.Generic.IEnumerable<string> DependencyIds { get; }
        public string Description { get; }
        public System.Uri IconUrl { get; }
        public System.Uri LicenseUrl { get; }
        public System.Collections.Generic.IEnumerable<string> Owners { get; }
        public bool PreRelease { get; }
        public System.Uri ProjectUrl { get; }
        public string Summary { get; }
        public System.Collections.Generic.IEnumerable<string> Tags { get; }
        public string Title { get; }
    }
    [JetBrains.Application.Env.EnvironmentComponentAttribute(JetBrains.Application.Sharing.Product)]
    public class NuGetExtensionProvider : JetBrains.Application.Extensions.IExtensionProvider
    {
        public NuGetExtensionProvider(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.IApplicationDescriptor applicationDescriptor, JetBrains.Application.Extensions.NuGetRepositoryLocation repositoryLocation, JetBrains.Application.Extensions.ExtensionLocations extensionLocations, JetBrains.Application.Extensions.IPackageInstallerEvents packageInstallerEvents) { }
        public JetBrains.DataFlow.IViewable<JetBrains.Application.Extensions.IExtension> Extensions { get; }
        public string Name { get; }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class NuGetExtensionRepository : JetBrains.Application.Extensions.IExtensionRepository
    {
        public NuGetExtensionRepository(JetBrains.Application.Extensions.IProductPackageManagerFactory packageManagerFactory, JetBrains.Application.IApplicationDescriptor applicationDescriptor, JetBrains.Application.Env.RunningProducts products, JetBrains.Application.Extensions.IDeleteOnRestartManager deleteOnRestartManager) { }
        public bool CanUninstall(string id) { }
        public System.Collections.Generic.IEnumerable<string> GetExtensionsRequiringRestart() { }
        public bool HasMissingExtensions() { }
        public void RestoreMissingExtensions() { }
        public void Uninstall(string id, bool removeDependencies, System.Collections.Generic.IEnumerable<string> dependencies, System.Action<JetBrains.Util.LoggingLevel, string> logger) { }
        public class NuGetFacade : System.IDisposable
        {
            public NuGetFacade(JetBrains.Application.Extensions.IProductPackageManager packageManager, JetBrains.Application.IApplicationDescriptor applicationDescriptor, JetBrains.Application.Env.RunningProducts products) { }
            public bool CanUninstall(string id) { }
            public void Dispose() { }
            public bool HasMissingExtensions() { }
            public void RestoreMissingExtensions() { }
            public void Uninstall(string id, bool removeDependencies, System.Action<JetBrains.Util.LoggingLevel, string> logger) { }
        }
    }
    public class NuGetLogger : NuGet.IFileConflictResolver, NuGet.ILogger
    {
        public NuGetLogger(JetBrains.Util.ILogger logger, System.Type caller = null) { }
        public void Log(NuGet.MessageLevel level, string message, params object[] args) { }
        public NuGet.FileConflictResolution ResolveFileConflict(string message) { }
    }
    [JetBrains.Application.Env.EnvironmentComponentAttribute(JetBrains.Application.Sharing.Product)]
    public class NuGetRepositoryLocation
    {
        public NuGetRepositoryLocation(JetBrains.Application.Extensions.IFileSystemProvider fileSystemProvider, JetBrains.Application.Extensions.IRepositorySettings repositorySettings, NuGet.IProjectSystem productFileSystem) { }
        public NuGet.IFileSystem FileSystem { get; }
        public NuGet.IPackagePathResolver PathResolver { get; }
        public NuGet.IPackageLookup ProductRepository { get; }
        public NuGet.ISharedPackageRepository SharedRepository { get; }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class NuGetWebProxy : JetBrains.Application.Extensions.IExtensionManagerWebProxy
    {
        public NuGetWebProxy(JetBrains.Application.Communication.WebProxySettingsReader webProxySettings, JetBrains.Application.Extensions.Settings.IExtensionSourceProvider sourceProvider, JetBrains.Util.Lazy.Lazy<JetBrains.Application.Extensions.IInteractiveProxyCredentialStore> promptForCrendentials = null) { }
        public bool AllowPromptForCredentials { get; set; }
        public class InteractiveCredentialProvider : NuGet.ICredentialProvider
        {
            public InteractiveCredentialProvider(JetBrains.Util.Lazy.Lazy<JetBrains.Application.Extensions.IInteractiveProxyCredentialStore> interactiveCredentialStore) { }
            public bool AllowPromptForCredentials { get; set; }
            public System.Net.ICredentials GetCredentials(System.Uri uri, System.Net.IWebProxy proxy, NuGet.CredentialType credentialType, bool retrying) { }
        }
        public class ReSharperProxyCredentialProvider : NuGet.ICredentialProvider
        {
            public ReSharperProxyCredentialProvider(NuGet.ICredentialProvider innerProvider, JetBrains.Application.Communication.WebProxySettingsReader webProxySettings) { }
            public System.Net.ICredentials GetCredentials(System.Uri uri, System.Net.IWebProxy proxy, NuGet.CredentialType credentialType, bool retrying) { }
        }
    }
    public class NullFileSystem : NuGet.IFileSystem
    {
        public static NuGet.IFileSystem Instance { get; }
        public NuGet.ILogger Logger { get; set; }
        public string Root { get; }
        public void AddFile(string path, System.IO.Stream stream) { }
        public void AddFile(string path, System.Action<System.IO.Stream> writeToStream) { }
        public System.IO.Stream CreateFile(string path) { }
        public void DeleteDirectory(string path, bool recursive) { }
        public void DeleteFile(string path) { }
        public bool DirectoryExists(string path) { }
        public bool FileExists(string path) { }
        public System.DateTimeOffset GetCreated(string path) { }
        public System.Collections.Generic.IEnumerable<string> GetDirectories(string path) { }
        public System.Collections.Generic.IEnumerable<string> GetFiles(string path, string filter, bool recursive) { }
        public string GetFullPath(string path) { }
        public System.DateTimeOffset GetLastAccessed(string path) { }
        public System.DateTimeOffset GetLastModified(string path) { }
        public void MakeFileWritable(string path) { }
        public System.IO.Stream OpenFile(string path) { }
    }
    public class static PackageExtensions
    {
        public static System.Collections.Generic.IEnumerable<NuGet.IPackageFile> GetFiles(this NuGet.IPackage package, JetBrains.Util.FileSystemPath prefix, bool recursive = True) { }
        public static JetBrains.Util.FileSystemPath GetFullPath(this NuGet.IPackageFile file, NuGet.IPackage package, NuGet.IPackagePathResolver pathResolver) { }
        public static bool IsSupported(this NuGet.IPackage package, JetBrains.Application.IApplicationDescriptor applicationDescriptor, string source, JetBrains.DataFlow.ListEvents<JetBrains.Application.Extensions.ExtensionRecord> runtimeInfoRecords) { }
    }
    [JetBrains.Application.Env.EnvironmentComponentAttribute(JetBrains.Application.Sharing.Common)]
    public class PackageInstallerEvents : JetBrains.Application.Extensions.IPackageInstallerEvents
    {
        public PackageInstallerEvents() { }
        public event System.EventHandler<NuGet.PackageOperationEventArgs> PackageInstalled;
        public event System.EventHandler<NuGet.PackageOperationEventArgs> PackageInstalling;
        public event System.EventHandler<NuGet.PackageOperationEventArgs> PackageReferenceAdded;
        public event System.EventHandler<NuGet.PackageOperationEventArgs> PackageReferenceAdding;
        public event System.EventHandler<NuGet.PackageOperationEventArgs> PackageReferenceRemoved;
        public event System.EventHandler<NuGet.PackageOperationEventArgs> PackageReferenceRemoving;
        public event System.EventHandler<NuGet.PackageOperationEventArgs> PackageUninstalled;
        public event System.EventHandler<NuGet.PackageOperationEventArgs> PackageUninstalling;
        public void NotifyInstalled(object sender, NuGet.PackageOperationEventArgs e) { }
        public void NotifyInstalling(object sender, NuGet.PackageOperationEventArgs e) { }
        public void NotifyReferenceAdded(object sender, NuGet.PackageOperationEventArgs e) { }
        public void NotifyReferenceAdding(object sender, NuGet.PackageOperationEventArgs e) { }
        public void NotifyReferenceRemoved(object sender, NuGet.PackageOperationEventArgs e) { }
        public void NotifyReferenceRemoving(object sender, NuGet.PackageOperationEventArgs e) { }
        public void NotifyUninstalled(object sender, NuGet.PackageOperationEventArgs e) { }
        public void NotifyUninstalling(object sender, NuGet.PackageOperationEventArgs e) { }
    }
    public class PackageNotInstalledException : System.Exception
    {
        public PackageNotInstalledException(string message) { }
        public PackageNotInstalledException(string message, System.Exception innerException) { }
    }
    [JetBrains.Application.Env.EnvironmentComponentAttribute(JetBrains.Application.Sharing.Product)]
    public class ProductFileSystem : NuGet.IFileSystem, NuGet.IProjectSystem, NuGet.IPropertyProvider
    {
        public ProductFileSystem(JetBrains.Application.Env.Components.AnyProductSettingsLocation anyProductSettingsLocation, JetBrains.Application.IApplicationDescriptor product, JetBrains.Application.Extensions.ExtensionLocations extensionLocations, JetBrains.Application.Extensions.IFileSystemProvider fileSystemProvider) { }
        public NuGet.ILogger Logger { get; set; }
        public JetBrains.Application.IApplicationDescriptor Product { get; }
    }
    public class ProductManager : NuGet.ProjectManager
    {
        public ProductManager(NuGet.IPackageRepository sourceRepository, NuGet.IPackagePathResolver pathResolver, NuGet.IProjectSystem project, NuGet.IPackageRepository localRepository) { }
        public override void AddPackageReference(NuGet.IPackage package, bool ignoreDependencies, bool allowPrereleaseVersions) { }
        protected override void ExtractPackageFilesToProject(NuGet.IPackage package) { }
    }
    public class ProductPackage : NuGet.IPackage, NuGet.IPackageMetadata, NuGet.IServerPackageMetadata
    {
        public ProductPackage(JetBrains.Application.IApplicationDescriptor descriptor) { }
        public System.Collections.Generic.IEnumerable<NuGet.IPackageAssemblyReference> AssemblyReferences { get; }
        public System.Collections.Generic.IEnumerable<string> Authors { get; }
        public string Copyright { get; }
        public System.Collections.Generic.IEnumerable<NuGet.PackageDependencySet> DependencySets { get; }
        public string Description { get; }
        public int DownloadCount { get; }
        public System.Collections.Generic.IEnumerable<NuGet.FrameworkAssemblyReference> FrameworkAssemblies { get; }
        public System.Uri IconUrl { get; }
        public string Id { get; }
        public bool IsAbsoluteLatestVersion { get; }
        public bool IsLatestVersion { get; }
        public string Language { get; }
        public System.Uri LicenseUrl { get; }
        public bool Listed { get; }
        public System.Version MinClientVersion { get; }
        public System.Collections.Generic.IEnumerable<string> Owners { get; }
        public System.Collections.Generic.ICollection<NuGet.PackageReferenceSet> PackageAssemblyReferences { get; }
        public System.Uri ProjectUrl { get; }
        public System.Nullable<System.DateTimeOffset> Published { get; }
        public string ReleaseNotes { get; }
        public System.Uri ReportAbuseUrl { get; }
        public bool RequireLicenseAcceptance { get; }
        public string Summary { get; }
        public string Tags { get; }
        public string Title { get; }
        public NuGet.SemanticVersion Version { get; }
        public System.Collections.Generic.IEnumerable<NuGet.IPackageFile> GetFiles() { }
        public System.IO.Stream GetStream() { }
        public System.Collections.Generic.IEnumerable<System.Runtime.Versioning.FrameworkName> GetSupportedFrameworks() { }
        public override string ToString() { }
    }
    public class ProductPackageManager : NuGet.PackageManager, JetBrains.Application.Extensions.IProductPackageManager, NuGet.IPackageManager
    {
        public ProductPackageManager(JetBrains.DataFlow.Lifetime lifetime, JetBrains.DataFlow.ICollectionEvents<JetBrains.Application.IApplicationDescriptor> products, JetBrains.Application.Env.Components.AnyProductSettingsLocation anyProductSettingsLocation, NuGet.IPackageRepository sourceRepository, JetBrains.Application.Extensions.NuGetRepositoryLocation nugetRepositoryLocation, JetBrains.Application.Extensions.IDeleteOnRestartManager deleteOnRestartManager, JetBrains.Application.Extensions.PackageInstallerEvents packageEvents, JetBrains.Application.Extensions.IFileSystemProvider fileSystemProvider, JetBrains.Application.Extensions.ExtensionLocations extensionLocations) { }
        public bool BindingRedirectEnabled { get; set; }
        protected override void ExecuteUninstall(NuGet.IPackage package) { }
        public virtual NuGet.IProjectManager GetProjectManager(JetBrains.Application.IApplicationDescriptor project) { }
        public void InstallPackage(System.Collections.Generic.IEnumerable<JetBrains.Application.IApplicationDescriptor> projects, NuGet.IPackage package, System.Collections.Generic.IEnumerable<NuGet.PackageOperation> operations, bool ignoreDependencies, bool allowPrereleaseVersions, NuGet.ILogger logger, JetBrains.Application.Extensions.IPackageOperationEventListener packageOperationEventListener) { }
        public virtual void InstallPackage(NuGet.IProjectManager projectManager, string packageId, NuGet.SemanticVersion version, bool ignoreDependencies, bool allowPrereleaseVersions, NuGet.ILogger logger) { }
        public void InstallPackage(NuGet.IProjectManager projectManager, string packageId, NuGet.SemanticVersion version, bool ignoreDependencies, bool allowPrereleaseVersions, bool skipAssemblyReferences, NuGet.ILogger logger) { }
        public void InstallPackage(NuGet.IProjectManager projectManager, NuGet.IPackage package, System.Collections.Generic.IEnumerable<NuGet.PackageOperation> operations, bool ignoreDependencies, bool allowPrereleaseVersions, NuGet.ILogger logger) { }
        public bool IsProjectLevel(NuGet.IPackage package) { }
        protected override void OnInstalled(NuGet.PackageOperationEventArgs e) { }
        protected override void OnInstalling(NuGet.PackageOperationEventArgs e) { }
        protected override void OnUninstalled(NuGet.PackageOperationEventArgs e) { }
        protected override void OnUninstalling(NuGet.PackageOperationEventArgs e) { }
        public void ReinstallPackage(string packageId, bool updateDependencies, bool allowPrereleaseVersions, NuGet.ILogger logger, JetBrains.Application.Extensions.IPackageOperationEventListener eventListener) { }
        public void ReinstallPackage(NuGet.IProjectManager projectManager, string packageId, bool updateDependencies, bool allowPrereleaseVersions, NuGet.ILogger logger) { }
        public void ReinstallPackages(bool updateDependencies, bool allowPrereleaseVersions, NuGet.ILogger logger, JetBrains.Application.Extensions.IPackageOperationEventListener eventListener) { }
        public void ReinstallPackages(NuGet.IProjectManager projectManager, bool updateDependencies, bool allowPrereleaseVersions, NuGet.ILogger logger) { }
        public void SafeUpdatePackage(string packageId, bool updateDependencies, bool allowPrereleaseVersions, NuGet.ILogger logger, JetBrains.Application.Extensions.IPackageOperationEventListener eventListener) { }
        public void SafeUpdatePackage(NuGet.IProjectManager projectManager, string packageId, bool updateDependencies, bool allowPrereleaseVersions, NuGet.ILogger logger) { }
        public void SafeUpdatePackages(NuGet.IProjectManager projectManager, bool updateDependencies, bool allowPrereleaseVersions, NuGet.ILogger logger) { }
        public void SafeUpdatePackages(bool updateDependencies, bool allowPrereleaseVersions, NuGet.ILogger logger, JetBrains.Application.Extensions.IPackageOperationEventListener eventListener) { }
        public void UninstallPackage(NuGet.IProjectManager projectManager, string packageId, NuGet.SemanticVersion version, bool forceRemove, bool removeDependencies) { }
        public virtual void UninstallPackage(NuGet.IProjectManager projectManager, string packageId, NuGet.SemanticVersion version, bool forceRemove, bool removeDependencies, NuGet.ILogger logger) { }
        public void UpdatePackage(System.Collections.Generic.IEnumerable<JetBrains.Application.IApplicationDescriptor> projects, NuGet.IPackage package, System.Collections.Generic.IEnumerable<NuGet.PackageOperation> operations, bool updateDependencies, bool allowPrereleaseVersions, NuGet.ILogger logger, JetBrains.Application.Extensions.IPackageOperationEventListener packageOperationEventListener) { }
        public virtual void UpdatePackage(NuGet.IProjectManager projectManager, string packageId, NuGet.SemanticVersion version, bool updateDependencies, bool allowPrereleaseVersions, NuGet.ILogger logger) { }
        public void UpdatePackage(string packageId, NuGet.IVersionSpec versionSpec, bool updateDependencies, bool allowPrereleaseVersions, NuGet.ILogger logger, JetBrains.Application.Extensions.IPackageOperationEventListener eventListener) { }
        public void UpdatePackage(string packageId, NuGet.SemanticVersion version, bool updateDependencies, bool allowPrereleaseVersions, NuGet.ILogger logger, JetBrains.Application.Extensions.IPackageOperationEventListener eventListener) { }
        public void UpdatePackages(NuGet.IProjectManager projectManager, System.Collections.Generic.IEnumerable<NuGet.IPackage> packages, System.Collections.Generic.IEnumerable<NuGet.PackageOperation> operations, bool updateDependencies, bool allowPrereleaseVersions, NuGet.ILogger logger) { }
        public void UpdatePackages(bool updateDependencies, bool allowPrereleaseVersions, NuGet.ILogger logger, JetBrains.Application.Extensions.IPackageOperationEventListener eventListener) { }
        public void UpdatePackages(NuGet.IProjectManager projectManager, bool updateDependencies, bool allowPrereleaseVersions, NuGet.ILogger logger) { }
        public void UpdateSolutionPackages(System.Collections.Generic.IEnumerable<NuGet.IPackage> packages, System.Collections.Generic.IEnumerable<NuGet.PackageOperation> operations, bool updateDependencies, bool allowPrereleaseVersions, NuGet.ILogger logger, JetBrains.Application.Extensions.IPackageOperationEventListener eventListener) { }
    }
    public class static ProductPackageManagerEx
    {
        public static string GetDisplayName(this JetBrains.Application.IApplicationDescriptor product) { }
        public static string GetTargetFramework(this JetBrains.Application.IApplicationDescriptor product) { }
        public static System.Runtime.Versioning.FrameworkName GetTargetFrameworkName(this JetBrains.Application.IApplicationDescriptor product) { }
        public static string GetUniqueName(this JetBrains.Application.IApplicationDescriptor product) { }
    }
    public abstract class ProductPackageManagerFactory : JetBrains.Application.Extensions.IProductPackageManagerFactory
    {
        public ProductPackageManagerFactory(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.Env.JetEnvironment environment, NuGet.IPackageRepositoryFactory packageRepositoryFactory, JetBrains.Application.Extensions.Settings.IExtensionSourceProvider extensionSourceProvider, JetBrains.Application.Extensions.NuGetRepositoryLocation nugetRepositoryLocation, JetBrains.Application.Env.Components.AnyProductSettingsLocation anyProductSettingsLocation, JetBrains.Application.Extensions.IDeleteOnRestartManager deleteOnRestartManager, JetBrains.Application.Extensions.PackageInstallerEvents packageInstallerEvents, JetBrains.Application.Extensions.IFileSystemProvider fileSystemProvider, JetBrains.Application.Extensions.ExtensionLocations extensionLocations) { }
        public JetBrains.Application.Extensions.IProductPackageManager CreatePackageManager() { }
        public JetBrains.Application.Extensions.IProductPackageManager CreatePackageManager(NuGet.IPackageRepository repository, bool useFallbackForDependencies) { }
    }
    [JetBrains.Application.Env.EnvironmentComponentAttribute(JetBrains.Application.Sharing.Product)]
    public class ProductPackageRepositoryFactory : NuGet.PackageRepositoryFactory
    {
        public ProductPackageRepositoryFactory(JetBrains.Application.IProductNameAndVersion product) { }
        public override NuGet.IPackageRepository CreateRepository(string packageSource) { }
    }
    public class ProductsRepository : NuGet.IDependencyResolver, NuGet.IPackageLookup, NuGet.IPackageRepository
    {
        public ProductsRepository(JetBrains.DataFlow.Lifetime lifetime, JetBrains.DataFlow.IViewable<JetBrains.Application.IApplicationDescriptor> products, NuGet.IPackageRepository repository) { }
        public string Source { get; }
        public bool SupportsPrereleasePackages { get; }
        public void AddPackage(NuGet.IPackage package) { }
        public bool Exists(string packageId, NuGet.SemanticVersion version) { }
        public NuGet.IPackage FindPackage(string packageId, NuGet.SemanticVersion version) { }
        public System.Collections.Generic.IEnumerable<NuGet.IPackage> FindPackagesById(string packageId) { }
        public System.Linq.IQueryable<NuGet.IPackage> GetPackages() { }
        public void RemovePackage(NuGet.IPackage package) { }
        public NuGet.IPackage ResolveDependency(NuGet.PackageDependency dependency, NuGet.IPackageConstraintProvider constraintProvider, bool allowPrereleaseVersions, bool preferListedPackages) { }
    }
    [JetBrains.Application.Env.EnvironmentComponentAttribute(JetBrains.Application.Sharing.Product)]
    public class RepositorySettings : JetBrains.Application.Extensions.IRepositorySettings
    {
        public static readonly string PACKAGES_FOLDER;
        public RepositorySettings(JetBrains.Application.Env.Components.ProductSettingsLocation settingsLocation, JetBrains.Application.Extensions.ExtensionLocations extensionLocations) { }
        public string ConfigFolderPath { get; }
        public string RepositoryPath { get; }
    }
    public class static RepositorySettingsEx
    {
        public static NuGet.IFileSystem GetConfigFolderFileSystem(this JetBrains.Application.Extensions.IRepositorySettings repositorySettings, JetBrains.Application.Extensions.IFileSystemProvider fileSystemProvider) { }
        public static NuGet.IFileSystem GetRepositoryFileSystem(this JetBrains.Application.Extensions.IRepositorySettings repositorySettings, JetBrains.Application.Extensions.IFileSystemProvider fileSystemProvider) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class ShellProductPackageManagerFactory : JetBrains.Application.Extensions.EnvironmentProductPackageManagerFactory
    {
        public ShellProductPackageManagerFactory(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.Env.JetEnvironment environment, NuGet.IPackageRepositoryFactory packageRepositoryFactory, JetBrains.Application.Extensions.Settings.IExtensionSourceProvider extensionSourceProvider, JetBrains.Application.Extensions.NuGetRepositoryLocation nugetRepositoryLocation, JetBrains.Application.Env.Components.AnyProductSettingsLocation anyProductSettingsLocation, JetBrains.Application.Extensions.IDeleteOnRestartManager deleteOnRestartManager, JetBrains.Application.Extensions.PackageInstallerEvents packageInstallerEvents, JetBrains.Application.Extensions.IFileSystemProvider fileSystemProvider, JetBrains.Application.Extensions.ExtensionLocations extensionLocations) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class SneakyHackToGetSettingsSerialisedCorrectly
    {
        public SneakyHackToGetSettingsSerialisedCorrectly() { }
    }
}
namespace JetBrains.Application.Extensions.OptionsPages
{
    
    [JetBrains.UI.Options.OptionsPageAttribute("ExtensionManager", "Extension Manager", typeof(JetBrains.UI.Resources.OptionsThemedIcons.ExtensionManager), HelpKeyword="Reference__Options__Environment__Extension_Manager", ParentId="Environment")]
    public class ExtensionManagerOptionPage : JetBrains.UI.Options.Helpers.AOptionsPage
    {
        public const string Pid = "ExtensionManager";
        public ExtensionManagerOptionPage(JetBrains.DataFlow.Lifetime lifetime, JetBrains.UI.Application.IUIApplication environment, JetBrains.UI.Options.OptionsSettingsSmartContext settings, JetBrains.Application.IApplicationDescriptor product, JetBrains.UI.Icons.IThemedIconManager themedIconManager, JetBrains.Application.Interop.NativeHook.IWindowsHookManager windowsHookManager, JetBrains.CommonControls.Validation.FormValidators formValidators, JetBrains.Util.ILogger logger) { }
    }
    public class PackageSourceEditorDialog : System.Windows.Forms.Form
    {
        public PackageSourceEditorDialog(NuGet.PackageSource initial, JetBrains.Application.IApplicationDescriptor product, JetBrains.CommonControls.Validation.FormValidators formValidators, JetBrains.Application.Interop.NativeHook.IWindowsHookManager windowsHookManager, JetBrains.UI.Application.IUIApplication environment) { }
        public NuGet.PackageSource PackageSource { get; }
        protected override void Dispose(bool disposing) { }
    }
    public class PackageSourcesEditor : System.Windows.Forms.UserControl
    {
        public PackageSourcesEditor(JetBrains.DataFlow.Lifetime lifetime, NuGet.IPackageSourceProvider packageSourceProvider, JetBrains.UI.Application.IUIApplication environment, JetBrains.Application.IApplicationDescriptor product, JetBrains.UI.Icons.IThemedIconManager themedIconManager, JetBrains.Application.Interop.NativeHook.IWindowsHookManager windowsHookManager, JetBrains.CommonControls.Validation.FormValidators formValidators) { }
        public JetBrains.DataStructures.ImmutableArray<NuGet.PackageSource> PackageSources { get; }
    }
}
namespace JetBrains.Application.Extensions.Settings
{
    
    [JetBrains.Application.ShellComponentAttribute()]
    public class DefaultExtensionManagerSettings : JetBrains.Application.Settings.IHaveDefaultSettingsStream
    {
        public string Name { get; }
        public System.IO.Stream GetDefaultSettingsStream(JetBrains.DataFlow.Lifetime lifetime) { }
    }
    [JetBrains.Application.Env.EnvironmentComponentAttribute(JetBrains.Application.Sharing.Product)]
    public class EnvironmentExtensionSourceProvider : JetBrains.Application.Extensions.Settings.IExtensionSourceProvider, NuGet.IPackageSourceProvider
    {
        public virtual void DisablePackageSource(NuGet.PackageSource source) { }
        public virtual bool IsPackageSourceEnabled(NuGet.PackageSource source) { }
        public virtual System.Collections.Generic.IEnumerable<NuGet.PackageSource> LoadPackageSources() { }
        public virtual void SavePackageSources(System.Collections.Generic.IEnumerable<NuGet.PackageSource> sources) { }
    }
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(JetBrains.Application.Settings.EnvironmentSettings), "Extension manager options")]
    public class ExtensionManagerSettings
    {
        [JetBrains.Application.Settings.SettingsIndexedEntryAttribute("Extension sources")]
        public JetBrains.Application.Settings.Store.IIndexedEntry<string, JetBrains.Application.Extensions.Settings.PackageSourceSettings> Sources;
    }
    public class static ExtensionManagerSettingsAccessor
    {
        public static readonly System.Linq.Expressions.Expression<System.Func<JetBrains.Application.Extensions.Settings.ExtensionManagerSettings, JetBrains.Application.Settings.Store.IIndexedEntry<string, JetBrains.Application.Extensions.Settings.PackageSourceSettings>>> Sources;
    }
    public class ExtensionSourceProvider : JetBrains.Application.Extensions.Settings.IExtensionSourceProvider, NuGet.IPackageSourceProvider
    {
        public ExtensionSourceProvider(JetBrains.Application.Settings.IContextBoundSettingsStore contextBoundSettingsStore, JetBrains.Util.ILogger logger) { }
        public void DisablePackageSource(NuGet.PackageSource source) { }
        public bool IsPackageSourceEnabled(NuGet.PackageSource source) { }
        public System.Collections.Generic.IEnumerable<NuGet.PackageSource> LoadPackageSources() { }
        public void SavePackageSources(System.Collections.Generic.IEnumerable<NuGet.PackageSource> sources) { }
    }
    public interface IExtensionSourceProvider : NuGet.IPackageSourceProvider { }
    public class JsonTypeConverter<T> : JetBrains.Util.Reflection.TypeConverterBase<T>
    
    {
        public JsonTypeConverter() { }
    }
    [System.ComponentModel.TypeConverterAttribute(typeof(JetBrains.Application.Extensions.Settings.JsonTypeConverter<JetBrains.Application.Extensions.Settings.PackageSourceSettings>))]
    [System.Runtime.Serialization.DataContractAttribute()]
    public class PackageSourceSettings : System.IEquatable<JetBrains.Application.Extensions.Settings.PackageSourceSettings>
    {
        public PackageSourceSettings(NuGet.PackageSource packageSource) { }
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsEnabled { get; set; }
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name { get; set; }
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Order { get; set; }
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Source { get; set; }
        public bool Equals(JetBrains.Application.Extensions.Settings.PackageSourceSettings other) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
        public NuGet.PackageSource ToPackageSource() { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class ShellExtensionSourceProvider : JetBrains.Application.Extensions.Settings.EnvironmentExtensionSourceProvider
    {
        public ShellExtensionSourceProvider(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.Util.ILogger logger) { }
        public override void DisablePackageSource(NuGet.PackageSource source) { }
        public override bool IsPackageSourceEnabled(NuGet.PackageSource source) { }
        public override System.Collections.Generic.IEnumerable<NuGet.PackageSource> LoadPackageSources() { }
        public override void SavePackageSources(System.Collections.Generic.IEnumerable<NuGet.PackageSource> sources) { }
    }
}