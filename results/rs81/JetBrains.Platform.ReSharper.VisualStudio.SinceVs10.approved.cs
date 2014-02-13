[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]
[assembly: System.Runtime.Versioning.TargetFrameworkAttribute(".NETFramework,Version=v4.0", FrameworkDisplayName=".NET Framework 4")]
[assembly: System.Windows.Markup.XmlnsDefinitionAttribute("urn:shemas-jetbrains-com:platform-extensions", "JetBrains.Application.Extensions.UI")]

namespace JetBrains.Application.Extensions
{
    
    public class static ExtensionManagerAction
    {
        public const string ActionID = "ExtensionManager";
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class ExtensionManagerProviderSettings : JetBrains.Application.Extensions.IProviderSettings
    {
        public ExtensionManagerProviderSettings(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.Settings.ISettingsStore settingsStore) { }
        public bool IncludePrereleasePackages { get; set; }
        public int SelectedProvider { get; set; }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class ExtensionManagerUpdatesAlerts
    {
        public ExtensionManagerUpdatesAlerts(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Threading.IThreading threading, JetBrains.UI.Icons.IThemedIconManager themedIconManager, JetBrains.Application.Extensions.IExtensionCatalogProvider extensionCatalogProvider, JetBrains.Application.IProductNameAndVersion product, JetBrains.ActionManagement.IActionManager actionManager, JetBrains.Application.Extensions.IProviderSettings providerSettings, JetBrains.UI.Application.IMainWindow mainWindow = null) { }
    }
    public interface IProviderSettings
    {
        bool IncludePrereleasePackages { get; set; }
        int SelectedProvider { get; set; }
    }
    public interface IWindowSettingsManager
    {
        System.Windows.Size GetWindowSize(string windowToken);
        void SetWindowSize(string windowToken, System.Windows.Size size);
    }
    [JetBrains.Application.Env.EnvironmentComponentAttribute(JetBrains.Application.Sharing.Product)]
    public class VsExtensionLocations : JetBrains.Application.Extensions.ExtensionLocations
    {
        public VsExtensionLocations(JetBrains.DataFlow.Lifetime lifetime, JetBrains.DataFlow.IViewable<JetBrains.Application.Extensions.IExtensionManagerSupportedProductsProvider> supportedProductsProviders, JetBrains.Application.Env.Components.ProductSettingsLocation settingsLocation, JetBrains.VsIntegration.Application.IVsEnvironmentInformation vsEnvironmentInformation) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class WindowSettingsManager : JetBrains.Application.Extensions.IWindowSettingsManager
    {
        public WindowSettingsManager(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.Settings.ISettingsStore settingsStore) { }
        public System.Windows.Size GetWindowSize(string windowToken) { }
        public void SetWindowSize(string windowToken, System.Windows.Size size) { }
    }
}
namespace JetBrains.Application.Extensions.UI
{
    
    public class static Commands
    {
        public static readonly System.Windows.Input.RoutedCommand EnableDisableCommand;
        public static readonly System.Windows.Input.RoutedCommand FocusOnSearchBox;
        public static readonly System.Windows.Input.RoutedCommand InstallUninstallCommand;
        public static readonly System.Windows.Input.RoutedCommand OpenExternalLink;
        public static readonly System.Windows.Input.RoutedCommand ShowOptionsPage;
        public static readonly System.Windows.Input.RoutedCommand ShowRecords;
        public static readonly System.Windows.Input.RoutedCommand UpdateAll;
    }
    public class static ExceptionHelper
    {
        public static System.Exception Unwrap(System.Exception exception) { }
        public static void WriteToActivityLog(System.Exception exception) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class ExtensionManagerOptionsPageActivator
    {
        public ExtensionManagerOptionsPageActivator(JetBrains.Threading.IThreading threading, JetBrains.UI.Options.OptionsDialogOwner optionsDialogOwner, JetBrains.ActionManagement.IActionManager actionManager, JetBrains.Application.Settings.Storage.DefaultFileStorages.GlobalSettings globalSettings) { }
        public void ShowOptions() { }
    }
    public class static MessageBoxHelper
    {
        public static void ShowErrorMessage(System.Exception exception, string title, System.IntPtr window) { }
        public static void ShowErrorMessage(string message, string title, System.IntPtr window) { }
        public static void ShowInfoMessage(string message, string title, System.IntPtr window) { }
        public static System.Nullable<bool> ShowQueryMessage(string message, string title, bool showCancelButton, System.IntPtr window) { }
        public static void ShowWarningMessage(string message, string title, System.IntPtr window) { }
    }
    public class static UriHelper
    {
        public static void OpenExternalLink(System.Uri url) { }
    }
    public class static WindowSizePersistenceHelper
    {
        public static readonly System.Windows.DependencyProperty WindowTokenProperty;
        public static string GetWindowToken(System.Windows.DependencyObject obj) { }
        public static void SetWindowToken(System.Windows.DependencyObject obj, string value) { }
    }
}
namespace JetBrains.VsIntegration.DevTen.Application.MethTest
{
    
    public interface IMethTestServer
    {
        bool IsMethLoaded { get; }
    }
    public class MethTestClient
    {
        public MethTestClient(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Threading.IThreading invocator, Microsoft.VisualStudio.ComponentModelHost.IComponentModel componentModel, JetBrains.Application.IApplicationDescriptor applicationDescriptor) { }
    }
    [System.ComponentModel.Composition.ExportAttribute(typeof(JetBrains.VsIntegration.DevTen.Application.MethTest.IMethTestServer))]
    public class MethTestServer : JetBrains.VsIntegration.DevTen.Application.MethTest.IMethTestServer
    {
        public MethTestServer() { }
    }
}
namespace JetBrains.VsIntegration.DevTen.DocumentModel
{
    
    public class VsBufferGraphUtils
    {
        public static string DumpBuffer(Microsoft.VisualStudio.Text.ITextBuffer buffer, int level) { }
        public static string DumpBufferGraph(Microsoft.VisualStudio.Text.Projection.IBufferGraph graph) { }
        public static string GetBufferID(Microsoft.VisualStudio.Text.ITextBuffer buffer) { }
        public static string PresentBuffer(Microsoft.VisualStudio.Text.ITextBuffer buffer) { }
    }
}
namespace JetBrains.VsIntegration.DevTen.Install
{
    
    [System.FlagsAttribute()]
    public enum ExclusionFlags
    {
        ExcludeOwnVersion = 1,
        ExcludePerMachineLocation = 2,
        ExcludePerUserPerHiveLocations = 4,
    }
    [JetBrains.Application.Install.StaticInstallerAttribute(JetBrains.Application.Install.InstallerVsVersionAffinity.Specific)]
    public class MsiExtensionManifestInstaller : JetBrains.Application.Install.IStaticInstaller
    {
        public static readonly string Identity;
        public static readonly string IdentitySuffixUnderBin;
        public static readonly string IdentitySuffixUnderExtensions;
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.Util.FileSystemPath GetEmittedExtensionManifestFilePath([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Install.Installer installer) { }
    }
    public class static PackageDefWriter
    {
        public static readonly JetBrains.DataFlow.PropertyId<bool> IsPackageDefFile;
        public static void Install([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Install.Installer installer, [JetBrains.Annotations.NotNullAttribute()] System.IO.TextWriter writer) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.Application.Install.InstallationData.InstallationData Install([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Install.InstallationData.InstallationData data, [JetBrains.Annotations.NotNullAttribute()] System.Version vsVersion, [JetBrains.Annotations.NotNullAttribute()] string sVsRootSuffix, [JetBrains.Annotations.NotNullAttribute()] System.IO.TextWriter writer, System.Collections.Generic.Dictionary<JetBrains.Application.Install.InstallationData.InstallationMacroName, string> macrosOverride = null) { }
        public enum PkgDefMacros
        {
            AppDataLocalFolder = 0,
            AppName = 1,
            BaseInstallDir = 2,
            CommonFiles = 3,
            HivelessRootKey = 4,
            MyDocuments = 5,
            PackageFolder = 6,
            ProgramFiles = 7,
            RootFolder = 8,
            RootKey = 9,
            ShellFolder = 10,
            System = 11,
            WinDir = 12,
        }
    }
    [JetBrains.Application.Install.StaticInstallerAttribute(JetBrains.Application.Install.InstallerVsVersionAffinity.Specific)]
    public class RegistryToPackageDefConverter : JetBrains.Application.Install.IStaticInstaller
    {
        public static readonly string Identity;
        public static readonly string IdentitySuffixUnderBin;
        public static readonly string IdentitySuffixUnderExtensions;
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.Util.FileSystemPath GetEmittedPackageDefFilePath([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Install.Installer installer) { }
    }
    public class VsIntegrationInstaller
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static readonly JetBrains.Util.FileSystemPath DevEnvExtensionsRelPath;
        public static readonly JetBrains.Util.FileSystemPath Vs11LocalAppDataComponentModelCacheFolderRelPath;
        [JetBrains.Annotations.NotNullAttribute()]
        public static readonly JetBrains.Util.FileSystemPath Vs11MachineExtensionsConfigurationChangedFileRelPath;
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.Util.FileSystemPath GetPerMachineExtensionFolderRelPath([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.IProductNameAndVersion product) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.Util.FileSystemPath GetPerMachineExtensionFolderRelPath_NoVersionNumber([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.IProductNameAndVersion product) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.Util.FileSystemPath GetProductBinariesVsSpecificDir([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Install.Installer installer) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.Util.FileSystemPath GetProductBinariesVsSpecificDir_Relative([JetBrains.Annotations.NotNullAttribute()] System.Version versionVs) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.Util.FileSystemPath GetProductBinariesVsSpecificDir_Relative([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Install.Installer installer) { }
    }
    public class static VsixHelper
    {
        public static void AdjustExtensionToRunPerUser([JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath pathManifest, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.IProductNameAndVersion descriptor, [JetBrains.Annotations.NotNullAttribute()] JetBrains.VsIntegration.Application.IVsEnvironmentInformation vsenv) { }
        public static void AdjustExtensionToRunPerUser_EnableInRegistry([JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath pathManifest, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.IProductNameAndVersion product, [JetBrains.Annotations.NotNullAttribute()] JetBrains.VsIntegration.Application.IVsEnvironmentInformation vsenv) { }
        public static void EnableExtensionInRegistry([JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath pathExtensionFolder, [JetBrains.Annotations.NotNullAttribute()] JetBrains.VsIntegration.Application.IVsEnvironmentInformation vsenv) { }
        public static void EnsureValidRegistry([JetBrains.Annotations.NotNullAttribute()] JetBrains.VsIntegration.Application.IVsEnvironmentInformation vsenv) { }
        public static System.Collections.Generic.IList<JetBrains.Util.FileSystemPath> FindAllCompanyExtensionsInHive(JetBrains.VsIntegration.DevTen.Install.ExclusionFlags exclusionflags, [JetBrains.Annotations.NotNullAttribute()] JetBrains.VsIntegration.Application.IVsEnvironmentInformation vsenv) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.Util.FileSystemPath FindExtensionManifest([JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath pathExtensionFolder) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.List<JetBrains.Util.FileSystemPath> GetExtensionsInHive(JetBrains.VsIntegration.DevTen.Install.ExclusionFlags exclusionflags, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.IProductNameAndVersion product, [JetBrains.Annotations.NotNullAttribute()] JetBrains.VsIntegration.Application.IVsEnvironmentInformation vsenv) { }
        public static string GetVsExtensionManagerEnabledExtensionsRegistryPath([JetBrains.Annotations.NotNullAttribute()] JetBrains.VsIntegration.Application.IVsEnvironmentInformation vsenv) { }
        public static string GetVsExtensionManagerRegistryPath([JetBrains.Annotations.NotNullAttribute()] JetBrains.VsIntegration.Application.IVsEnvironmentInformation vsenv) { }
        public static void ResetVs11ConfigurationFlag([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.IProductNameAndVersion product, [JetBrains.Annotations.NotNullAttribute()] JetBrains.VsIntegration.Application.IVsEnvironmentInformation vsenv) { }
    }
    public class static VsixManifestWriter
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static readonly string ExtensionManifestDefaultFileName;
        public static readonly System.Version NetfxVersionMax;
        public static readonly System.Version NetfxVersionMin;
        [JetBrains.Annotations.NotNullAttribute()]
        public static string GetExtensionIdentifier([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.IProductNameAndVersion descriptor) { }
        public static string GetExtensionManifestFileName([JetBrains.Annotations.NotNullAttribute()] System.Version versionVs) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static string GetExtensionVersionString([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.IProductNameAndVersion descriptor) { }
        public static void Install([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Install.Installer installer, [JetBrains.Annotations.NotNullAttribute()] System.Xml.XmlWriter writer, [JetBrains.Annotations.CanBeNullAttribute()] System.Uri uriPartPkgDef, [JetBrains.Annotations.CanBeNullAttribute()] System.Uri uriPartIcon, [JetBrains.Annotations.CanBeNullAttribute()] System.Uri uriPartPreview, [JetBrains.Annotations.CanBeNullAttribute()] System.Uri uriPartLicense, JetBrains.VsIntegration.DevTen.Install.VsixManifestWriter.DeploymentMode deploymentmode, string sContentLocationPrefix = "") { }
        public enum DeploymentMode
        {
            Msi = 0,
            Manual = 1,
            Vsix = 2,
        }
        public class static Elem
        {
            public static readonly string Author;
            public static readonly string Content;
            public static readonly string Description;
            public static readonly string Edition;
            public static readonly string GettingStartedGuide;
            public static readonly string Icon;
            public static readonly string Identifier;
            public static readonly string InstalledByMsi;
            public static readonly string[] KnownVsEditions;
            public static readonly string License;
            public static readonly string Locale;
            public static readonly string MefComponent;
            public static readonly string MoreInfoUrl;
            public static readonly string Name;
            public static readonly string PreviewImage;
            public static readonly string References;
            public static readonly string SupportedFrameworkRuntimeEdition;
            public static readonly string SupportedProducts;
            public static readonly string SystemComponent;
            public static readonly string Version;
            public static readonly string VisualStudio;
            public static readonly string Vsix;
            public static readonly string VsPackage;
        }
        public class static Xmlns
        {
            public static readonly string Vsix;
        }
        public class static XsdBoolean
        {
            public static readonly string False;
            public static readonly string True;
        }
    }
    public class static VsixWriter
    {
        public static void Install([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Install.Installer installer, [JetBrains.Annotations.NotNullAttribute()] System.IO.Stream streamVsixOutput, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath pathProductLicenseFile, JetBrains.VsIntegration.DevTen.Install.VsixWriter.CreateVsixFlags flags) { }
        [System.FlagsAttribute()]
        public enum CreateVsixFlags
        {
            OptionIncludePdb = 0,
            OptionIncludeXmlDoc = 1,
            OptionRequireStrongName = 2,
        }
    }
}
namespace JetBrains.VsIntegration.DevTen.Interop.Extension
{
    
    public class static IPropertyOwnerEx
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static TType GetPropertyByType<TType>([JetBrains.Annotations.NotNullAttribute()] this Microsoft.VisualStudio.Utilities.IPropertyOwner propowner) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static TType GetPropertyByType<TType>([JetBrains.Annotations.NotNullAttribute()] this Microsoft.VisualStudio.Utilities.IPropertyOwner propowner, [JetBrains.Annotations.NotNullAttribute()] System.Func<TType> FCreateIfMissing) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static TType TryGetPropertyByType<TType>([JetBrains.Annotations.NotNullAttribute()] this Microsoft.VisualStudio.Utilities.IPropertyOwner propowner) { }
    }
    public class static ITextBufferEx
    {
        public static JetBrains.VsIntegration.Interop.Shim.TextManager.IVsTextBuffer GetIVsTextBuffer([JetBrains.Annotations.NotNullAttribute()] this Microsoft.VisualStudio.Text.ITextBuffer buffer, Microsoft.VisualStudio.Editor.IVsEditorAdaptersFactoryService vsEditorAdaptersFactoryService) { }
        public static Microsoft.VisualStudio.Text.ITextBuffer GetTextBuffer(this JetBrains.VsIntegration.Interop.Shim.TextManager.IVsTextBuffer vsTextBuffer, Microsoft.VisualStudio.Editor.IVsEditorAdaptersFactoryService vsEditorAdaptersFactoryService) { }
        public static JetBrains.VsIntegration.Interop.Shim.TextManager.IVsTextBuffer TryGetIVsTextBuffer([JetBrains.Annotations.NotNullAttribute()] this Microsoft.VisualStudio.Text.ITextBuffer buffer, Microsoft.VisualStudio.Editor.IVsEditorAdaptersFactoryService vsEditorAdaptersFactoryService) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static string TryGetPathFromTextDocument([JetBrains.Annotations.NotNullAttribute()] this Microsoft.VisualStudio.Text.ITextBuffer buffer) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static Microsoft.VisualStudio.Text.ITextBuffer TryGetTextBuffer(this JetBrains.VsIntegration.Interop.Shim.TextManager.IVsTextBuffer vsTextBuffer, Microsoft.VisualStudio.Editor.IVsEditorAdaptersFactoryService vsEditorAdaptersFactoryService) { }
    }
    public class static IWpfTextViewEx
    {
        public static void EnsureOutliningExpanded([JetBrains.Annotations.NotNullAttribute()] this Microsoft.VisualStudio.Text.Editor.IWpfTextView view, Microsoft.VisualStudio.Text.SnapshotPoint pos, [JetBrains.Annotations.NotNullAttribute()] Microsoft.VisualStudio.Text.Outlining.IOutliningManagerService outliningManagerService) { }
        public static void EnsureOutliningExpanded([JetBrains.Annotations.NotNullAttribute()] this Microsoft.VisualStudio.Text.Editor.IWpfTextView view, Microsoft.VisualStudio.Text.SnapshotSpan span, [JetBrains.Annotations.NotNullAttribute()] Microsoft.VisualStudio.Text.Outlining.IOutliningManagerService outliningManagerService) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static Microsoft.VisualStudio.Text.Operations.IEditorOperations GetEditorOperations([JetBrains.Annotations.NotNullAttribute()] this Microsoft.VisualStudio.Text.Editor.IWpfTextView view, [JetBrains.Annotations.NotNullAttribute()] Microsoft.VisualStudio.Text.Operations.IEditorOperationsFactoryService editorOperationsFactoryService) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static Microsoft.VisualStudio.Text.Editor.IWpfTextView GetITextView([JetBrains.Annotations.NotNullAttribute()] this JetBrains.VsIntegration.Interop.Shim.TextManager.IVsTextView vsView, [JetBrains.Annotations.NotNullAttribute()] Microsoft.VisualStudio.Editor.IVsEditorAdaptersFactoryService vsEditorAdaptersFactoryService) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.VsIntegration.Interop.Shim.TextManager.IVsTextView GetIVsTextView([JetBrains.Annotations.NotNullAttribute()] this Microsoft.VisualStudio.Text.Editor.IWpfTextView view, [JetBrains.Annotations.NotNullAttribute()] Microsoft.VisualStudio.Editor.IVsEditorAdaptersFactoryService vsEditorAdaptersFactoryService) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static Microsoft.VisualStudio.OLE.Interop.IOleCommandTarget GetOleCommandTarget([JetBrains.Annotations.NotNullAttribute()] this Microsoft.VisualStudio.Text.Editor.IWpfTextView view, [JetBrains.Annotations.NotNullAttribute()] Microsoft.VisualStudio.Editor.IVsEditorAdaptersFactoryService vsEditorAdaptersFactoryService) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.IServiceProvider GetServiceProvider([JetBrains.Annotations.NotNullAttribute()] this Microsoft.VisualStudio.Text.Editor.IWpfTextView view, [JetBrains.Annotations.NotNullAttribute()] Microsoft.VisualStudio.Editor.IVsEditorAdaptersFactoryService vsEditorAdaptersFactoryService) { }
        public static Microsoft.VisualStudio.Text.Editor.IWpfTextViewHost GetTextViewHost([JetBrains.Annotations.NotNullAttribute()] this Microsoft.VisualStudio.Text.Editor.IWpfTextView view, [JetBrains.Annotations.NotNullAttribute()] Microsoft.VisualStudio.Editor.IVsEditorAdaptersFactoryService vsEditorAdaptersFactoryService) { }
        public static Microsoft.VisualStudio.Text.Editor.IWpfTextViewHost GetTextViewHost([JetBrains.Annotations.NotNullAttribute()] this JetBrains.VsIntegration.Interop.Shim.TextManager.IVsTextView vsTextView) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static Microsoft.VisualStudio.TextManager.Interop.IVsCompoundAction GetVsCompoundAction([JetBrains.Annotations.NotNullAttribute()] this Microsoft.VisualStudio.Text.Editor.IWpfTextView view, [JetBrains.Annotations.NotNullAttribute()] Microsoft.VisualStudio.Editor.IVsEditorAdaptersFactoryService vsEditorAdaptersFactoryService) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.VsIntegration.Interop.Shim.Shell.IVsWindowFrame GetWindowFrame([JetBrains.Annotations.NotNullAttribute()] this Microsoft.VisualStudio.Text.Editor.IWpfTextView view, [JetBrains.Annotations.NotNullAttribute()] Microsoft.VisualStudio.Editor.IVsEditorAdaptersFactoryService vsEditorAdaptersFactoryService) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.DataFlow.IProperty<JetBrains.TextControl.ITextControl> JetTextControl([JetBrains.Annotations.NotNullAttribute()] this Microsoft.VisualStudio.Text.Editor.ITextView view) { }
        public static System.Windows.Rect ToTextBoundsRect(this Microsoft.VisualStudio.Text.Formatting.TextBounds bounds) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static Microsoft.VisualStudio.Text.Editor.IWpfTextView TryGetITextView([JetBrains.Annotations.NotNullAttribute()] this JetBrains.VsIntegration.Interop.Shim.TextManager.IVsTextView vsView, [JetBrains.Annotations.NotNullAttribute()] Microsoft.VisualStudio.Editor.IVsEditorAdaptersFactoryService vsEditorAdaptersFactoryService) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.VsIntegration.Interop.Shim.TextManager.IVsTextView TryGetIVsTextView([JetBrains.Annotations.NotNullAttribute()] this Microsoft.VisualStudio.Text.Editor.IWpfTextView view, [JetBrains.Annotations.NotNullAttribute()] Microsoft.VisualStudio.Editor.IVsEditorAdaptersFactoryService vsEditorAdaptersFactoryService) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static System.IServiceProvider TryGetServiceProvider([JetBrains.Annotations.NotNullAttribute()] this Microsoft.VisualStudio.Text.Editor.IWpfTextView view, [JetBrains.Annotations.NotNullAttribute()] Microsoft.VisualStudio.Editor.IVsEditorAdaptersFactoryService vsEditorAdaptersFactoryService) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.VsIntegration.Interop.Shim.Shell.IVsWindowFrame TryGetWindowFrame([JetBrains.Annotations.NotNullAttribute()] this Microsoft.VisualStudio.Text.Editor.IWpfTextView view, [JetBrains.Annotations.NotNullAttribute()] Microsoft.VisualStudio.Editor.IVsEditorAdaptersFactoryService vsEditorAdaptersFactoryService) { }
    }
    public class static SnapshotSpanEx
    {
        public static bool ContainsFullyInclusive(this Microsoft.VisualStudio.Text.SnapshotSpan span, Microsoft.VisualStudio.Text.SnapshotPoint point) { }
    }
}
namespace JetBrains.VsIntegration.DevTen.Interop.Shim
{
    
    public class static ConversionDevTen
    {
        public static JetBrains.DocumentModel.DocumentCoords AsDocLineColumn(this Microsoft.VisualStudio.Text.VirtualSnapshotPoint vpt) { }
        public static JetBrains.TextControl.DocOffsetAndVirtual AsDocOffsetAndVirtual(this Microsoft.VisualStudio.Text.VirtualSnapshotPoint vpt) { }
        public static Microsoft.VisualStudio.Text.SnapshotPoint AssertValid(this Microsoft.VisualStudio.Text.SnapshotPoint pt) { }
        public static Microsoft.VisualStudio.Text.VirtualSnapshotPoint AssertValid(this Microsoft.VisualStudio.Text.VirtualSnapshotPoint vpt) { }
        public static JetBrains.TextControl.TextControlLineColumn AsTextControlLineColumn(this Microsoft.VisualStudio.Text.VirtualSnapshotPoint vpt) { }
        public static System.Nullable<Microsoft.VisualStudio.Text.SnapshotPoint> MapUpToTop2(this Microsoft.VisualStudio.Text.Projection.IBufferGraph graph, Microsoft.VisualStudio.Text.SnapshotPoint pointNonTop, Microsoft.VisualStudio.Text.PointTrackingMode pointTrackingMode, Microsoft.VisualStudio.Text.PositionAffinity positionAffinity) { }
        public static Microsoft.VisualStudio.Text.VirtualSnapshotPoint ToDocVsVirtualSnapshotPoint([JetBrains.Annotations.NotNullAttribute()] this JetBrains.TextControl.Coords.ITextControlPos pos) { }
        public static Microsoft.VisualStudio.Text.Span ToSpan(this JetBrains.Util.TextRange range) { }
        public static Microsoft.VisualStudio.Text.VirtualSnapshotPoint ToVsVirtualSnapshotPoint(this JetBrains.TextControl.DocOffsetAndVirtual docoffs, [JetBrains.Annotations.NotNullAttribute()] Microsoft.VisualStudio.Text.Editor.ITextView textview) { }
        public static Microsoft.VisualStudio.Text.VirtualSnapshotPoint ToVsVirtualSnapshotPoint(this JetBrains.DocumentModel.DocumentCoords posDoc, [JetBrains.Annotations.NotNullAttribute()] Microsoft.VisualStudio.Text.Editor.ITextView textview) { }
        public static Microsoft.VisualStudio.Text.VirtualSnapshotPoint ToVsVirtualSnapshotPoint(this JetBrains.TextControl.TextControlLineColumn posTxt, [JetBrains.Annotations.NotNullAttribute()] Microsoft.VisualStudio.Text.Editor.ITextView textview) { }
    }
    public class MefServiceContainer : Microsoft.VisualStudio.ComponentModelHost.IComponentModel { }
    public class static ShimDynamicApi
    {
        public static double GetSpaceWidth([JetBrains.Annotations.NotNullAttribute()] this Microsoft.VisualStudio.Text.Formatting.IFormattedLineSource formatted) { }
    }
}
namespace JetBrains.VsIntegration.DevTen.Local
{
    
    [JetBrains.Application.ShellComponentAttribute(JetBrains.Application.Sharing.Product, JetBrains.Application.Lifecycle.Deferred, JetBrains.Application.Creation.PrimaryThread, JetBrains.Application.Access.None)]
    public class JumpVsixFromMachineToPerUser
    {
        public JumpVsixFromMachineToPerUser(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Threading.IThreading threading, JetBrains.Application.Env.RunsProducts.ProductConfigurations productConfigurations, JetBrains.VsIntegration.Application.IVsEnvironmentInformation vsEnvironmentInformation, JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.Application.IApplicationDescriptor applicationDescriptor, JetBrains.Application.Env.Components.IApplicationRestart applicationRestart) { }
        public JetBrains.DataFlow.IProperty<bool> IsEnabled { get; }
        public JetBrains.DataFlow.IProperty<bool> IsRelocatingAutomatically { get; }
        public JetBrains.DataFlow.IProperty<bool> IsRelocatingAutomaticallyOnce { get; }
    }
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(JetBrains.Application.Settings.HousekeepingSettings), "JumpVsixFromMachineToPerUser settings")]
    public class JumpVsixFromMachineToPerUserSettings
    {
        [JetBrains.Application.Settings.SettingsEntryAttribute(true, "Whether enabled")]
        public bool IsEnabled;
        [JetBrains.Application.Settings.SettingsEntryAttribute(false, "Whether relocation is automatic")]
        public bool IsRelocatingAutomatically;
        [JetBrains.Application.Settings.SettingsEntryAttribute(false, "Whether relocation is automatic (applied only once)")]
        public bool IsRelocatingAutomaticallyOnce;
    }
    [JetBrains.Application.Configuration.Upgrade.GlobalSettingsUpgraderAttribute()]
    public class JumpVsixFromMachineToPerUserSettingsUpgrader : JetBrains.Application.Configuration.SettingTablesUpgrader
    {
        public JumpVsixFromMachineToPerUserSettingsUpgrader(JetBrains.Application.Env.RunsProducts.ProductConfigurations productConfigurations) { }
        protected override void DoUpgrade(JetBrains.Application.Configuration.IComponentSettingsProvider legacySettingsProvider, JetBrains.Application.Settings.IContextBoundSettingsStore boundSettingsStore, JetBrains.DataFlow.Lifetime upgradeLifetime, JetBrains.Application.Configuration.SettingsTableBase workspaceSettingsTable, JetBrains.Application.Configuration.SettingsTableBase globalSettingsTable) { }
    }
}
namespace JetBrains.VsIntegration.DevTen.Markup
{
    
    public class static ClassificationPriorityRange
    {
        public const string After = "Formal Language Priority";
        public const string Before = "MarkerPlaceHolder";
    }
    public interface IVs10HighlighterTags
    {
        Microsoft.VisualStudio.Text.Tagging.ITag CreateTag(JetBrains.VsIntegration.DevTen.Markup.Vs10Highlighter highlighter);
    }
    public interface IVs10HighlighterTags<out TTagType> : JetBrains.VsIntegration.DevTen.Markup.IVs10HighlighterTags
        where out TTagType : Microsoft.VisualStudio.Text.Tagging.ITag
    {
        TTagType CreateTag(JetBrains.VsIntegration.DevTen.Markup.Vs10Highlighter highlighter);
    }
    public class Vs10Highlighter : JetBrains.TextControl.DocumentMarkup.HighlighterBase
    {
        public override JetBrains.DocumentModel.IDocument Document { get; }
        public override bool IsValid { get; }
        public override JetBrains.Util.TextRange Range { get; }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class Vs10HighlighterTags
    {
        public Vs10HighlighterTags(JetBrains.DataFlow.IViewable<JetBrains.VsIntegration.DevTen.Markup.IVs10HighlighterTags> factories, JetBrains.DataFlow.Lifetime lifetime) { }
        public TTagType CreateTag<TTagType>(JetBrains.VsIntegration.DevTen.Markup.Vs10Highlighter highlighter)
            where TTagType :  class, Microsoft.VisualStudio.Text.Tagging.ITag { }
    }
    [Microsoft.VisualStudio.Text.Classification.ClassificationTypeAttribute(ClassificationTypeNames="ReSharper Analysis Priority")]
    [Microsoft.VisualStudio.Text.Classification.UserVisibleAttribute(false)]
    [Microsoft.VisualStudio.Utilities.DisplayNameAttribute("ReSharper Analysis Priority")]
    [Microsoft.VisualStudio.Utilities.NameAttribute("ReSharper Analysis Priority")]
    [Microsoft.VisualStudio.Utilities.OrderAttribute(After="Formal Language Priority", Before="ReSharper Highlight Priority")]
    [System.ComponentModel.Composition.ExportAttribute(typeof(Microsoft.VisualStudio.Text.Classification.EditorFormatDefinition))]
    public class VsAnalysisPriorityClassificationDefinition : Microsoft.VisualStudio.Text.Classification.ClassificationFormatDefinition
    {
        public const string Name = "ReSharper Analysis Priority";
        public VsAnalysisPriorityClassificationDefinition() { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class VsDocumentMarkupTaggerComponent
    {
        public VsDocumentMarkupTaggerComponent(JetBrains.DataFlow.Lifetime lifetime, JetBrains.TextControl.TextControlManager textControlManager, JetBrains.TextControl.DocumentMarkup.IDocumentMarkupManager documentMarkupManager, JetBrains.Util.Lazy.Lazy<Microsoft.VisualStudio.Editor.IVsEditorAdaptersFactoryService> service) { }
        public JetBrains.TextControl.DocumentMarkup.IDocumentMarkupManager DocumentMarkupManager { get; }
        public static JetBrains.VsIntegration.DevTen.Markup.VsDocumentMarkupTaggerComponent.Context GetShellContext(JetBrains.VsIntegration.Interop.Shim.TextManager.IVsTextBuffer textBuffer) { }
        public void ResetTagger(JetBrains.VsIntegration.Interop.Shim.TextManager.IVsTextBuffer textBuffer) { }
        public class Context
        {
            public readonly JetBrains.DataFlow.Property<JetBrains.VsIntegration.DevTen.Markup.VsDocumentMarkupTaggerComponent> Component;
            public Context() { }
            public void ReleaseComponent() { }
            public void SetComponent(JetBrains.VsIntegration.DevTen.Markup.VsDocumentMarkupTaggerComponent component) { }
        }
    }
    [Microsoft.VisualStudio.Text.Tagging.TagTypeAttribute(typeof(JetBrains.VsIntegration.DevTen.Markup.VsGlyphMarginTag))]
    [Microsoft.VisualStudio.Text.Tagging.TagTypeAttribute(typeof(JetBrains.VsIntegration.DevTen.Markup.VsClassificationTag))]
    [Microsoft.VisualStudio.Text.Tagging.TagTypeAttribute(typeof(JetBrains.VsIntegration.DevTen.Markup.VsGutterMarginTag))]
    [Microsoft.VisualStudio.Text.Tagging.TagTypeAttribute(typeof(JetBrains.VsIntegration.DevTen.Markup.VsTextAdornmentTag))]
    [Microsoft.VisualStudio.Utilities.ContentTypeAttribute("text")]
    [System.ComponentModel.Composition.ExportAttribute(typeof(Microsoft.VisualStudio.Text.Tagging.ITaggerProvider))]
    public class VsDocumentMarkupTaggerProvider : Microsoft.VisualStudio.Text.Tagging.ITaggerProvider
    {
        public VsDocumentMarkupTaggerProvider() { }
        public Microsoft.VisualStudio.Text.Tagging.ITagger<TTag> CreateTagger<TTag>(Microsoft.VisualStudio.Text.ITextBuffer buffer)
            where TTag : Microsoft.VisualStudio.Text.Tagging.ITag { }
    }
    public class static VsHighlighterClassificationHelper
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static string ClassificationName_To_HighlighterId([JetBrains.Annotations.NotNullAttribute()] string name, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.IProductNameAndVersion product) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static string HighlighterId_To_ClassificationName([JetBrains.Annotations.NotNullAttribute()] string id, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.IProductNameAndVersion product) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class VsHighlighterCustomizationDevTen : JetBrains.VsIntegration.Markup.VsHighlighterCustomizationCommon
    {
        public VsHighlighterCustomizationDevTen(JetBrains.DataFlow.Lifetime lifetime, JetBrains.TextControl.DefaultTextControlSchemeManager textControlSchemeManager, JetBrains.Util.Lazy.Lazy<Microsoft.VisualStudio.Text.Classification.IClassificationTypeRegistryService> classificationTypeRegistryService, JetBrains.Util.Lazy.Lazy<Microsoft.VisualStudio.Text.Classification.IClassificationFormatMapService> classificationFormatMapService, JetBrains.Application.IProductNameAndVersion productNameAndVersion, JetBrains.TextControl.DocumentMarkup.IHighlightingAttributeRegistry highlightingAttributeRegistry, JetBrains.Threading.IThreading threading) { }
        protected override JetBrains.TextControl.DocumentMarkup.HighlighterAttributes ApplyVsCustomizations([JetBrains.Annotations.NotNullAttribute()] JetBrains.TextControl.DocumentMarkup.HighlighterAttributes sample, [JetBrains.Annotations.NotNullAttribute()] string sRegisteredHighlighterAttributeId) { }
    }
    [Microsoft.VisualStudio.Text.Editor.TextViewRoleAttribute("DOCUMENT")]
    [Microsoft.VisualStudio.Text.Editor.TextViewRoleAttribute("EMBEDDED_PEEK_TEXT_VIEW")]
    [Microsoft.VisualStudio.Utilities.ContentTypeAttribute("text")]
    [System.ComponentModel.Composition.ExportAttribute(typeof(Microsoft.VisualStudio.Text.Editor.IWpfTextViewCreationListener))]
    [System.ComponentModel.Composition.PartCreationPolicyAttribute(System.ComponentModel.Composition.CreationPolicy.Shared)]
    public sealed class VsHighlightingViewListener : Microsoft.VisualStudio.Text.Editor.IWpfTextViewCreationListener
    {
        public const string AdornmentLayerIdentifier = "ReSharperAdornmentLayer";
    }
    [Microsoft.VisualStudio.Text.Classification.ClassificationTypeAttribute(ClassificationTypeNames="ReSharper Highlight Priority")]
    [Microsoft.VisualStudio.Text.Classification.UserVisibleAttribute(false)]
    [Microsoft.VisualStudio.Utilities.DisplayNameAttribute("ReSharper Highlight Priority")]
    [Microsoft.VisualStudio.Utilities.NameAttribute("ReSharper Highlight Priority")]
    [Microsoft.VisualStudio.Utilities.OrderAttribute(After="Formal Language Priority", Before="ReSharper Top Priority")]
    [System.ComponentModel.Composition.ExportAttribute(typeof(Microsoft.VisualStudio.Text.Classification.EditorFormatDefinition))]
    public class VsHighlightPriorityClassificationDefinition : Microsoft.VisualStudio.Text.Classification.ClassificationFormatDefinition
    {
        public const string Name = "ReSharper Highlight Priority";
        public VsHighlightPriorityClassificationDefinition() { }
    }
    [Microsoft.VisualStudio.Text.Classification.ClassificationTypeAttribute(ClassificationTypeNames="ReSharper Syntax Priority")]
    [Microsoft.VisualStudio.Text.Classification.UserVisibleAttribute(false)]
    [Microsoft.VisualStudio.Utilities.DisplayNameAttribute("ReSharper Syntax Priority")]
    [Microsoft.VisualStudio.Utilities.NameAttribute("ReSharper Syntax Priority")]
    [Microsoft.VisualStudio.Utilities.OrderAttribute(After="Formal Language Priority", Before="ReSharper Analysis Priority")]
    [System.ComponentModel.Composition.ExportAttribute(typeof(Microsoft.VisualStudio.Text.Classification.EditorFormatDefinition))]
    public class VsSyntaxPriorityClassificationDefinition : Microsoft.VisualStudio.Text.Classification.ClassificationFormatDefinition
    {
        public const string Name = "ReSharper Syntax Priority";
        public VsSyntaxPriorityClassificationDefinition() { }
    }
    [Microsoft.VisualStudio.Text.Classification.ClassificationTypeAttribute(ClassificationTypeNames="ReSharper Top Priority")]
    [Microsoft.VisualStudio.Text.Classification.UserVisibleAttribute(false)]
    [Microsoft.VisualStudio.Utilities.DisplayNameAttribute("ReSharper Top Priority")]
    [Microsoft.VisualStudio.Utilities.NameAttribute("ReSharper Top Priority")]
    [Microsoft.VisualStudio.Utilities.OrderAttribute(After="Formal Language Priority", Before="MarkerPlaceHolder")]
    [System.ComponentModel.Composition.ExportAttribute(typeof(Microsoft.VisualStudio.Text.Classification.EditorFormatDefinition))]
    public class VsTopPriorityClassificationDefinition : Microsoft.VisualStudio.Text.Classification.ClassificationFormatDefinition
    {
        public const string Name = "ReSharper Top Priority";
        public VsTopPriorityClassificationDefinition() { }
    }
}
namespace JetBrains.VsIntegration.DevTen.Markup.FormatDefinitions.Install
{
    
    [JetBrains.VsIntegration.Install.VsPackageAssembly.VsPackageAssemblyEmitterComponentAttribute()]
    public class VsPackageEmitVsClassificationFormatDefinitions : JetBrains.VsIntegration.Install.VsPackageAssembly.IEmitSourceFiles
    {
        public VsPackageEmitVsClassificationFormatDefinitions(JetBrains.Application.IApplicationDescriptor product, JetBrains.Application.Parts.IPartsCatalogue catalog, JetBrains.VsIntegration.Application.IVsEnvironmentInformation vsEnvironmentInformation) { }
    }
}
namespace JetBrains.VsIntegration.DevTen.NuGet
{
    
    [JetBrains.ProjectModel.SolutionInstanceComponentAttribute()]
    public class NuGetReferenceManager
    {
        public NuGetReferenceManager(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Util.ILogger logger, JetBrains.Util.Lazy.Lazy<JetBrains.Application.Components.Optional<NuGet.VisualStudio.IVsPackageInstallerEvents>> vsPackageInstalerEvents, JetBrains.Util.Lazy.Lazy<JetBrains.Application.Components.Optional<NuGet.VisualStudio.IVsPackageInstallerServices>> vsPackageInstallerServices) { }
        public System.Collections.Generic.JetHashSet<JetBrains.Util.FileSystemPath> InstalledPackagePaths { get; }
        public JetBrains.DataFlow.ISignal<string> NugetReferencesAdded { get; }
        public bool IsPackageInstalled([JetBrains.Annotations.NotNullAttribute()] EnvDTE.Project project, [JetBrains.Annotations.NotNullAttribute()] string packageId) { }
    }
}
namespace JetBrains.VsIntegration.DevTen.ProjectModel
{
    
    public class ProjectReferenceManager10 : JetBrains.VsIntegration.ProjectModel.ProjectReferenceManager
    {
        public ProjectReferenceManager10(JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.VsIntegration.ProjectModel.VSProjectInfo vsProjectInfo, [JetBrains.Annotations.NotNullAttribute()] EnvDTE.Project project, [JetBrains.Annotations.NotNullAttribute()] VSLangProj.VSProject vsProject, [JetBrains.Annotations.NotNullAttribute()] JetBrains.VsIntegration.ProjectModel.ProjectModelSynchronizer projectModelSynchronizer, JetBrains.ProjectModel.Update.ProjectReferenceFactory projectReferenceFactory, JetBrains.Application.IShellLocks locks, JetBrains.ProjectModel.UnloadedProjectSupportManager unloadedProjectSupportManager, JetBrains.ProjectModel.Caches.ProjectFileDataCache projectFileDataCache, JetBrains.VsIntegration.ProjectModel.ProjectReferencesProvider referencesProvider, JetBrains.VsIntegration.DevTen.NuGet.NuGetReferenceManager nuGetReferenceManager) { }
        protected override JetBrains.ProjectModel.Update.IProjectReferenceProperties CreateReferenceProperties(JetBrains.ProjectModel.Update.IProjectReferenceDescriptor descriptor, VSLangProj.Reference reference) { }
        protected override void FixReferencesWithoutDescriptor(System.Collections.Generic.List<VSLangProj.Reference> referencesWithoutDescriptor, System.Collections.Generic.List<JetBrains.Util.Pair<JetBrains.ProjectModel.Update.IProjectReferenceDescriptor, JetBrains.ProjectModel.Update.IProjectReferenceProperties>> result, System.Collections.Generic.List<string> resolvedReferences) { }
    }
    [JetBrains.VsIntegration.ProjectModel.VsProjectReferenceManagerFactoryAttribute()]
    public class ProjectReferenceManagerFactory10 : JetBrains.VsIntegration.ProjectModel.ProjectReferenceManagerFactory
    {
        public ProjectReferenceManagerFactory10(JetBrains.VsIntegration.DevTen.NuGet.NuGetReferenceManager nuGetReferenceManager) { }
        protected JetBrains.VsIntegration.DevTen.NuGet.NuGetReferenceManager NuGetReferenceManager { get; }
        public override JetBrains.VsIntegration.ProjectModel.IVsProjectReferenceManager Create(JetBrains.DataFlow.Lifetime lifetime, JetBrains.VsIntegration.ProjectModel.VSProjectInfo vsProjectInfo, EnvDTE.Project project, JetBrains.VsIntegration.ProjectModel.ProjectModelSynchronizer projectModelSynchronizer, JetBrains.ProjectModel.Update.ProjectReferenceFactory projectReferenceFactory, JetBrains.Application.ChangeManager changeManager, JetBrains.Application.IShellLocks locks, JetBrains.ProjectModel.UnloadedProjectSupportManager unloadedProjectSupportManager, JetBrains.ProjectModel.References.Impl.SdkReferenceFactory sdkReferenceFactory, JetBrains.ProjectModel.Caches.ProjectFileDataCache projectFileDataCache, JetBrains.VsIntegration.ProjectModel.ProjectReferencesProvider referencesProvider) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class VsSolutionManager10 : JetBrains.VsIntegration.ProjectModel.VSSolutionManager, Microsoft.VisualStudio.Shell.Interop.IVsSolutionLoadEvents
    {
        public VsSolutionManager10(
                    JetBrains.DataFlow.Lifetime lifetime, 
                    JetBrains.Util.ILogger logger, 
                    JetBrains.Application.Parts.IPartsCatalogueSet catalogueSet, 
                    JetBrains.Application.Components.IComponentContainer componentContainer, 
                    JetBrains.Application.IShellLocks locks, 
                    Microsoft.VisualStudio.Shell.Interop.IVsSolutionBuildManager2 vsSolutionBuildManager2, 
                    Microsoft.VisualStudio.Shell.Interop.IVsTrackProjectDocuments2 vsTrackProjectDocuments2, 
                    JetBrains.VsIntegration.Interop.Events.VsSelection vsSelection, 
                    Microsoft.VisualStudio.Shell.Interop.IVsSolution vsSolution, 
                    JetBrains.Threading.IThreading threading, 
                    Microsoft.VisualStudio.Shell.Interop.IVsSolution4 vsSolution4, 
                    JetBrains.ProjectModel.PlatformManager platformManager, 
                    JetBrains.Application.ChangeManager changeManager, 
                    JetBrains.Application.Env.RunsProducts.ProductConfigurations productConfigurations, 
                    System.Collections.Generic.IEnumerable<JetBrains.ProjectModel.IQuerySolutionCloseHandler> solutionCloseHandlers, 
                    JetBrains.ProjectModel.Properties.ProjectPropertiesFactory projectPropertiesFactory, 
                    JetBrains.ProjectModel.Properties.ProjectFlavoursFactory projectFlavoursFactory, 
                    JetBrains.ProjectModel.Tasks.ISolutionLoadTasksScheduler scheduler, 
                    JetBrains.VsIntegration.ActionManagement.VsLocalizer localizer, 
                    JetBrains.ProjectModel.Properties.ProjectFilePropertiesFactory projectFilePropertiesFactory, 
                    JetBrains.ProjectModel.IProjectFileExtensions projectFileExtensions) { }
        protected override void EnqueueLoadFromCache(JetBrains.ProjectModel.Impl.SolutionElement solutionElement) { }
        public int OnAfterBackgroundSolutionLoadComplete() { }
        public int OnAfterLoadProjectBatch(bool fIsBackgroundIdleBatch) { }
        public override int OnAfterOpenProject(Microsoft.VisualStudio.Shell.Interop.IVsHierarchy pHierarchy, int fAdded) { }
        public override int OnAfterOpenSolution(object pUnkReserved, int fNewSolution) { }
        public override void OnAfterStartup() { }
        public int OnBeforeBackgroundSolutionLoadBegins() { }
        public int OnBeforeLoadProjectBatch(bool fIsBackgroundIdleBatch) { }
        public int OnBeforeOpenSolution(string pszSolutionFilename) { }
        public int OnQueryBackgroundLoadProjectBatch(out bool pfShouldDelayLoadToNextIdle) { }
        protected override void SolutionReady(JetBrains.ProjectModel.SolutionInstance solutionInstance) { }
    }
}
namespace JetBrains.VsIntegration.DevTen.ProjectModel.SqlServerDatabaseProject
{
    
    public interface IObjectWrapper
    {
        object Value { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.VsIntegration.DevTen.ProjectModel.SqlServerDatabaseProject.IObjectWrapper GetPropertyValueSafe(string propertyName);
        T GetPropertyValueSafe<T>(string propertyName);
        void InvokeInstanceMethod(string methodName, params object[] args);
        TResult InvokeInstanceMethod<TResult>(string methodName, params object[] args);
        void SubscribeToEvent(JetBrains.DataFlow.Lifetime lifetime, string eventName, System.Func<System.Type, System.Delegate> createDelegateFunc);
    }
    public interface ISqlServerDatabaseProjectNodeWrapper : JetBrains.VsIntegration.DevTen.ProjectModel.SqlServerDatabaseProject.IObjectWrapper
    {
        Microsoft.Build.Execution.ProjectInstance MsBuildProjectInstance { get; }
        JetBrains.ProjectModel.Properties.ProjectLanguage TargetLanguage { get; }
    }
    public class ObjectWrapper : JetBrains.VsIntegration.DevTen.ProjectModel.SqlServerDatabaseProject.IObjectWrapper
    {
        public ObjectWrapper([JetBrains.Annotations.NotNullAttribute()] object o) { }
        public object Value { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.VsIntegration.DevTen.ProjectModel.SqlServerDatabaseProject.IObjectWrapper GetPropertyValueSafe(string propertyName) { }
        public T GetPropertyValueSafe<T>(string propertyName) { }
        public void InvokeInstanceMethod(string methodName, params object[] args) { }
        public TResult InvokeInstanceMethod<TResult>(string methodName, params object[] args) { }
        public void SubscribeToEvent(JetBrains.DataFlow.Lifetime lifetime, string eventName, System.Func<System.Type, System.Delegate> createDelegateFunc) { }
    }
    public class SafeMsBuildProjectPropertyInstance : JetBrains.VsIntegration.ProjectModel.ProjectProperties.ISafeProperty
    {
        public SafeMsBuildProjectPropertyInstance(Microsoft.Build.Execution.ProjectPropertyInstance property) { }
        public string PropertyName { get; }
        public T GetPropertyValue<T>(T defaultValue = null) { }
    }
    [JetBrains.ProjectModel.Properties.ProjectModelExtensionAttribute()]
    public class SqlServerDatabaseProjectContentBuilder : JetBrains.VsIntegration.ProjectModel.ProjectContent.VSDefaultProjectContentBuilder
    {
        public SqlServerDatabaseProjectContentBuilder(JetBrains.ProjectModel.ProjectFileExtensions projectFileExtensions) { }
        protected override JetBrains.ProjectModel.Update.IProjectItemDescriptor CreateChildItemDescriptor(JetBrains.VsIntegration.ProjectModel.VsHierarchyItem childHitem, JetBrains.ProjectModel.Update.IProjectFolderDescriptor parentFolderDescriptor, JetBrains.VsIntegration.ProjectModel.IVSProjectFilePropertiesBuilder projectFilePropertiesBuilder, JetBrains.ProjectModel.Properties.IProjectFilePropertiesProvider filePropertiesProvider, JetBrains.VsIntegration.ProjectModel.ProjectModelStatistics statistics, System.Collections.Generic.JetHashSet<JetBrains.VsIntegration.ProjectModel.VsHierarchyItem> modifiedFiles) { }
        public override bool IsApplicable(JetBrains.ProjectModel.Properties.IProjectProperties projectProperties) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class SqlServerDatabaseProjectEventsListener
    {
        public SqlServerDatabaseProjectEventsListener(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.ISolution solution, JetBrains.ProjectModel.impl.ViewableProjectsCollection projectsCollection, JetBrains.VsIntegration.ProjectModel.ProjectModelSynchronizer pms, JetBrains.VsIntegration.ProjectModel.VSProjectModelDescriptionBuilder descriptionBuilder, JetBrains.ProjectModel.Update.ProjectModelUpdater projectModelUpdater, JetBrains.Application.IShellLocks shellLocks) { }
    }
    public class SqlServerDatabaseProjectNodeWrapper : JetBrains.VsIntegration.DevTen.ProjectModel.SqlServerDatabaseProject.ObjectWrapper, JetBrains.VsIntegration.DevTen.ProjectModel.SqlServerDatabaseProject.IObjectWrapper, JetBrains.VsIntegration.DevTen.ProjectModel.SqlServerDatabaseProject.ISqlServerDatabaseProjectNodeWrapper
    {
        public Microsoft.Build.Execution.ProjectInstance MsBuildProjectInstance { get; }
        public JetBrains.ProjectModel.Properties.ProjectLanguage TargetLanguage { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.VsIntegration.DevTen.ProjectModel.SqlServerDatabaseProject.ISqlServerDatabaseProjectNodeWrapper TryCreate([JetBrains.Annotations.NotNullAttribute()] Microsoft.VisualStudio.Shell.Interop.IVsHierarchy vsHierarchy) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.VsIntegration.DevTen.ProjectModel.SqlServerDatabaseProject.ISqlServerDatabaseProjectNodeWrapper TryCreate([JetBrains.Annotations.NotNullAttribute()] EnvDTE.Project project) { }
    }
    [JetBrains.ProjectModel.Properties.ProjectModelExtensionAttribute()]
    public class SqlServerDatabaseProjectProjectFilePropertiesBuilder : JetBrains.VsIntegration.ProjectModel.ProjectFilePropertiesBuilder
    {
        public override bool FillProjectFilePropertiesDispatch(JetBrains.VsIntegration.ProjectModel.VsHierarchyItem hitem, object browseObject, JetBrains.ProjectModel.Properties.IProjectFileProperties projectFileProperties) { }
        public override bool IsApplicable(JetBrains.ProjectModel.Properties.IProjectProperties projectProperties) { }
    }
    [JetBrains.ProjectModel.Properties.ProjectModelExtensionAttribute()]
    public class SqlServerDatabaseProjectPropertiesFactoryVs : JetBrains.VsIntegration.ProjectModel.ProjectProperties.ProjectPropertiesFactoryVs
    {
        public SqlServerDatabaseProjectPropertiesFactoryVs(System.Collections.Generic.IEnumerable<JetBrains.ProjectModel.Properties.IProjectPropertiesFactory> factories) { }
        public override JetBrains.ProjectModel.Properties.IProjectProperties CreateProjectProperties(Microsoft.VisualStudio.Shell.Interop.IVsHierarchy hierarchy, System.Guid projectTypeGuid, System.Collections.Generic.ICollection<System.Guid> projectTypeGuids, JetBrains.ProjectModel.PlatformID platformIdVs, JetBrains.Metadata.Utils.TargetPlatformData targetPlatfromData) { }
        public override bool IsApplicable(Microsoft.VisualStudio.Shell.Interop.IVsHierarchy hierarchy, System.Guid projectTypeGuid, System.Collections.Generic.ICollection<System.Guid> projectTypeGuids, JetBrains.ProjectModel.PlatformID platformId) { }
    }
    public class SqlServerDatabaseProjectReferenceManager : JetBrains.VsIntegration.ProjectModel.VsProjectReferenceManagerBase
    {
        public SqlServerDatabaseProjectReferenceManager(JetBrains.DataFlow.Lifetime lifetime, JetBrains.VsIntegration.DevTen.ProjectModel.SqlServerDatabaseProject.IObjectWrapper referenceContainerWrapper, JetBrains.ProjectModel.IProject project, JetBrains.VsIntegration.ProjectModel.VSProjectInfo vsProjectInfo, JetBrains.Application.IShellLocks shellLocks, JetBrains.ProjectModel.UnloadedProjectSupportManager unloadedProjectSupportManager, JetBrains.VsIntegration.ProjectModel.ProjectModelSynchronizer projectModelSynchronizer, JetBrains.ProjectModel.Update.ProjectReferenceFactory projectReferenceFactory) { }
        public override void AddAssemblyReference(JetBrains.Util.FileSystemPath assemblyPath) { }
        public override void AddProjectReference(EnvDTE.Project project) { }
        public override System.Collections.Generic.IList<JetBrains.Util.Pair<JetBrains.ProjectModel.Update.IProjectReferenceDescriptor, JetBrains.ProjectModel.Update.IProjectReferenceProperties>> GetProjectReferences(System.Collections.Generic.List<string> resolvedReferences) { }
        public override void RemoveReference(JetBrains.ProjectModel.IProjectToModuleReference reference) { }
    }
    [JetBrains.VsIntegration.ProjectModel.VsProjectReferenceManagerFactoryAttribute()]
    public class SqlServerDatabaseProjectReferenceManagerFactory : JetBrains.VsIntegration.ProjectModel.IVsProjectReferenceManagerFactory
    {
        public JetBrains.VsIntegration.ProjectModel.IVsProjectReferenceManager Create(JetBrains.DataFlow.Lifetime lifetime, JetBrains.VsIntegration.ProjectModel.VSProjectInfo vsProjectInfo, EnvDTE.Project project, JetBrains.VsIntegration.ProjectModel.ProjectModelSynchronizer projectModelSynchronizer, JetBrains.ProjectModel.Update.ProjectReferenceFactory projectReferenceFactory, JetBrains.Application.ChangeManager changeManager, JetBrains.Application.IShellLocks locks, JetBrains.ProjectModel.UnloadedProjectSupportManager unloadedProjectSupportManager, JetBrains.ProjectModel.References.Impl.SdkReferenceFactory sdkReferenceFactory, JetBrains.ProjectModel.Caches.ProjectFileDataCache projectFileDataCache, JetBrains.VsIntegration.ProjectModel.ProjectReferencesProvider referencesProvider) { }
    }
}
namespace JetBrains.VsIntegration.DevTen.Src.ProjectModel
{
    
    [JetBrains.ProjectModel.SolutionInstanceComponentAttribute()]
    public class ProjectModelSynchronizer10 : JetBrains.VsIntegration.ProjectModel.ProjectModelSynchronizer
    {
        public const string ImplicitlyExpandTargetFrameworkTarget = "ImplicitlyExpandTargetFramework";
        public const string ResolveAssemblyReferencesTarget = "ResolveAssemblyReferences";
        public const string ResolveComReferencesTarget = "ResolveComReferences";
        public const string ResolveReferencesTarget = "ResolveReferences";
        public const string ResolveSDKReferencesTarget = "ResolveSDKReferences";
        public ProjectModelSynchronizer10(
                    JetBrains.DataFlow.Lifetime lifetime, 
                    JetBrains.ProjectModel.ISolution solution, 
                    JetBrains.Application.IShellLocks locks, 
                    Microsoft.VisualStudio.Shell.Interop.IVsSolution vsSolution, 
                    Microsoft.VisualStudio.Shell.Interop.IVsSolution4 vsSolution4, 
                    Microsoft.VisualStudio.Shell.Interop.IVsExternalFilesManager vsExternalFilesManager, 
                    JetBrains.VsIntegration.Interop.Shim.Shell.IVsRunningDocumentTable vsRunningDocumentTable, 
                    JetBrains.ProjectModel.PlatformManager platformManager, 
                    JetBrains.VsIntegration.Interop.Events.VsRunningDocumentTableEvents vsRunningDocumentTableEvents, 
                    JetBrains.ProjectModel.impl.SpecialFiles.SpecialFilesManager specialFilesManager, 
                    JetBrains.VsIntegration.ProjectModel.BizTalkReferencesHelper bizTalkReferencesHelper, 
                    JetBrains.VsIntegration.ProjectModel.WinJSWindowsSDKReferenceHelper winJsReferenceHelper, 
                    JetBrains.VsIntegration.ProjectModel.VsProjectReferenceManagerFactory vsProjectReferenceManagerFactory, 
                    JetBrains.VsIntegration.Application.IVsEnvironmentInformation vsEnvironmentInformation, 
                    JetBrains.ProjectModel.IProjectFileExtensions projectFileExtensions, 
                    JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IModuleReferenceResolveManager moduleReferenceResolveManager, 
                    JetBrains.ProjectModel.Update.ProjectModelUpdater updater, 
                    JetBrains.VsIntegration.ProjectModel.VSProjectModelDescriptionBuilder descriptionBuilder, 
                    JetBrains.Application.Settings.ISettingsStore settingsStore, 
                    JetBrains.ProjectModel.Update.ProjectReferenceFactory projectReferenceFactory, 
                    JetBrains.ProjectModel.Tasks.ISolutionLoadTasksScheduler scheduler, 
                    JetBrains.ProjectModel.References.SdkReferencesManager sdkReferencesManager, 
                    JetBrains.ProjectModel.impl.IFrameworkDetectionHelper frameworkDetectionHelper, 
                    JetBrains.ProjectModel.UnloadedProjectSupportManager unloadedProjectSupportManager, 
                    JetBrains.VsIntegration.ActionManagement.VsLocalizer localizer, 
                    JetBrains.ProjectModel.References.Impl.SdkReferenceFactory sdkReferenceFactory, 
                    JetBrains.VsIntegration.ProjectModel.PropertiesExtender.PropertiesExtenderProviderManager extenderManager, 
                    JetBrains.ProjectModel.Caches.ProjectFileDataCache projectFileDataCache, 
                    JetBrains.VsIntegration.ProjectModel.ProjectReferencesProvider referencesProvider, 
                    JetBrains.ProjectModel.Properties.ProjectModelExtensionsContainer projectModelExtensionsContainer, 
                    JetBrains.VsIntegration.Settings.VsSaveMonitor vsSaveMonitor, 
                    JetBrains.VsIntegration.ProjectModel.ProjectProperties.ProjectActiveConfigurationAccessor activeConfigurationAccessor, 
                    [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.Lazy.Lazy<JetBrains.Application.Components.Optional<NuGet.VisualStudio.IVsPackageInstallerEvents>> vsPackageInstalerEvents, 
                    [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.Lazy.Lazy<JetBrains.Application.Components.Optional<NuGet.VisualStudio.IVsPackageInstallerServices>> vsPackageInstallerServices, 
                    JetBrains.VsIntegration.ProjectModel.VsSolutionWrapper vsSolutionWrapper = null) { }
        protected override bool DoUseMsbuildToResolveAssemblyReferences(JetBrains.VsIntegration.ProjectModel.VSProjectInfo projectInfo) { }
        protected override void EnsureProjectLoadedAndSync(JetBrains.ProjectModel.IProject project) { }
        protected override void EnsureProjectSync(Microsoft.VisualStudio.Shell.Interop.IVsHierarchy hierarchy) { }
        protected override void RemoveMapping(Microsoft.VisualStudio.Shell.Interop.IVsHierarchy hierarchy, JetBrains.VsIntegration.ProjectModel.VSProjectInfo projectInfo) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public System.Collections.Generic.List<string> ResolveAssemblyReferencesUsingMsBuild(JetBrains.VsIntegration.ProjectModel.VSProjectInfo projectInfo, params string[] targetNames) { }
        protected override System.Collections.Generic.List<string> TryResolveAssemblyReferencesUsingMsBuildInternal(JetBrains.VsIntegration.ProjectModel.VSProjectInfo projectInfo) { }
        public override void UpdateAllProjectsReferences() { }
    }
}
namespace JetBrains.VsIntegration.DevTen.TextControl
{
    
    public class CreateVsTextControlDevTenParams : JetBrains.TextControl.CreateTextControlParams<JetBrains.VsIntegration.DevTen.TextControl.VsTextControlDevTen>
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly JetBrains.VsIntegration.DocumentModel.Whidbey.VsDocumentWhidbey Document;
        [JetBrains.Annotations.CanBeNullAttribute()]
        public readonly JetBrains.ProjectModel.ISolution Solution;
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly Microsoft.VisualStudio.Text.Editor.IWpfTextView VsTextView;
        public CreateVsTextControlDevTenParams([JetBrains.Annotations.NotNullAttribute()] JetBrains.VsIntegration.DocumentModel.Whidbey.VsDocumentWhidbey document, [JetBrains.Annotations.NotNullAttribute()] Microsoft.VisualStudio.Text.Editor.IWpfTextView textview, JetBrains.UI.WindowManagement.WindowFrame frame, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ProjectModel.ISolution solution) { }
        public CreateVsTextControlDevTenParams([JetBrains.Annotations.NotNullAttribute()] JetBrains.VsIntegration.DocumentModel.Whidbey.VsDocumentWhidbey document, JetBrains.UI.WindowManagement.WindowFrame frame, [JetBrains.Annotations.NotNullAttribute()] Microsoft.VisualStudio.Text.Editor.IWpfTextView textview) { }
    }
    public interface IVsTextControlDevTenIncrementalSearchClient
    {
        bool IsVsIncrementalSearchActive([JetBrains.Annotations.NotNullAttribute()] Microsoft.VisualStudio.Text.Editor.IWpfTextView wpfTextView);
    }
    public class VsCodeEditorDevTen : JetBrains.Application.IChangeProvider, JetBrains.TextControl.ITextControl, JetBrains.Util.IUserDataHolder, Microsoft.VisualStudio.OLE.Interop.IOleCommandTarget, System.IDisposable
    {
        public VsCodeEditorDevTen([JetBrains.Annotations.NotNullAttribute()] JetBrains.VsIntegration.Application.RawVsServiceProvider serviceProvider, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.Lazy.Lazy<Microsoft.VisualStudio.Editor.IVsEditorAdaptersFactoryService> adaptersFactory, [JetBrains.Annotations.NotNullAttribute()] Microsoft.VisualStudio.Shell.Interop.ILocalRegistry localRegistry, [JetBrains.Annotations.NotNullAttribute()] Microsoft.VisualStudio.Shell.Interop.IVsFilterKeys2 filterKeys2, [JetBrains.Annotations.NotNullAttribute()] Microsoft.VisualStudio.Shell.Interop.IVsRegisterPriorityCommandTarget registerPriorityCommandTarget, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Threading.IThreading threading, JetBrains.VsIntegration.Interop.Shim.TextManager.IVsTextBuffer vsTextBuffer, [JetBrains.Annotations.NotNullAttribute()] JetBrains.UI.CrossFramework.EitherControl parentControl) { }
        public bool IsDisposed { get; }
        public bool IsReadOnly { get; }
        public JetBrains.TextControl.ITextControl TextControl { get; }
        public Microsoft.VisualStudio.Text.Editor.IWpfTextView WpfTextView { get; }
        public event System.EventHandler<JetBrains.DataFlow.EventArgs<JetBrains.TextControl.ITextControl>> JetBrains.TextControl.ITextControl.BeforeDispose;
        public void AttachToTextControl([JetBrains.Annotations.NotNullAttribute()] JetBrains.TextControl.ITextControl textcontrol) { }
        public void Dispose() { }
        public void SetReadonly(bool fReadonly) { }
    }
    public class VsErrorStripeLayouterDevTen : JetBrains.TextControl.ErrorStripe.WpfErrorStripeLayouter
    {
        public VsErrorStripeLayouterDevTen([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Threading.IThreading threading, [JetBrains.Annotations.NotNullAttribute()] JetBrains.TextControl.ErrorStripe.WpfErrorStripeControl errorStripe, [JetBrains.Annotations.NotNullAttribute()] Microsoft.VisualStudio.Text.Editor.IWpfTextView textView, [JetBrains.Annotations.NotNullAttribute()] System.Windows.FrameworkElement verticalScrollBarElement) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class VsErrorStripeLayoutManagerDevTen : JetBrains.TextControl.ErrorStripe.ErrorStripeLayoutManager
    {
        protected readonly JetBrains.Threading.IThreading Threading;
        public VsErrorStripeLayoutManagerDevTen([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Threading.IThreading threading, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.Store.Implementation.SettingsStore settingsStore, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.Lazy.Lazy<Microsoft.VisualStudio.Editor.IVsEditorAdaptersFactoryService> vsEditorAdaptersFactoryService, [JetBrains.Annotations.NotNullAttribute()] JetBrains.UI.Theming.ITheming theming) { }
        public override JetBrains.TextControl.ErrorStripe.ErrorStripeLayout AvailableLayouts { get; }
        protected virtual JetBrains.TextControl.ErrorStripe.WpfErrorStripeLayouter CreateLayouter(JetBrains.DataFlow.Lifetime lifetime, Microsoft.VisualStudio.Text.Editor.IWpfTextView textView, JetBrains.TextControl.ErrorStripe.WpfErrorStripeControl errorStripeControl) { }
        public void DoLayout(JetBrains.DataFlow.Lifetime lifetime, Microsoft.VisualStudio.Text.Editor.IWpfTextView textView, JetBrains.TextControl.ErrorStripe.WpfErrorStripeControl errorStripe) { }
        protected Microsoft.VisualStudio.Text.Editor.IWpfTextViewHost GetTextViewHost(Microsoft.VisualStudio.Text.Editor.IWpfTextView textView) { }
        public Microsoft.VisualStudio.Text.Editor.IVerticalScrollBar GetVerticalScrollBar(Microsoft.VisualStudio.Text.Editor.IWpfTextView textView) { }
        protected Microsoft.VisualStudio.Text.Editor.IWpfTextViewMargin GetVerticalScrollBarMargin(Microsoft.VisualStudio.Text.Editor.IWpfTextView textView) { }
    }
    public sealed class VsTextControlDevTen : JetBrains.VsIntegration.TextControl.VsTextControlCommon
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly JetBrains.VsIntegration.DocumentModel.Whidbey.VsDocumentWhidbey VsDocument;
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly Microsoft.VisualStudio.Text.Editor.IWpfTextView VsTextView;
        public VsTextControlDevTen(
                    [JetBrains.Annotations.NotNullAttribute()] Microsoft.VisualStudio.Text.Editor.IWpfTextView vstextview, 
                    [JetBrains.Annotations.NotNullAttribute()] JetBrains.VsIntegration.DocumentModel.Whidbey.VsDocumentWhidbey document, 
                    [JetBrains.Annotations.NotNullAttribute()] JetBrains.UI.WindowManagement.WindowFrame frame, 
                    [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.IShellLocks locks, 
                    JetBrains.TextControl.Impl.TextControlTypingHandlers textControlTypingHandlers, 
                    JetBrains.VsIntegration.Application.VsCommandProcessor vsCommandProcessor, 
                    JetBrains.VsIntegration.ActionManagement.VsActionManager vsActionManager, 
                    JetBrains.Application.ChangeManager changeManager, 
                    JetBrains.DocumentModel.Impl.DocumentChangeManager documentChangeManager, 
                    JetBrains.VsIntegration.DocumentModel.VsDocumentManagerSynchronization vsDocumentManagerSynchronization, 
                    JetBrains.TextControl.DefaultTextControlSchemeManager defaultTextControlSchemeManager, 
                    JetBrains.Util.Lazy.Lazy<Microsoft.VisualStudio.Editor.IVsEditorAdaptersFactoryService> vsEditorAdaptersFactoryService, 
                    JetBrains.Util.Lazy.Lazy<Microsoft.VisualStudio.Text.Outlining.IOutliningManagerService> outliningManagerService, 
                    JetBrains.Util.Lazy.Lazy<Microsoft.VisualStudio.Text.Operations.IEditorOperationsFactoryService> editorOperationsFactoryService, 
                    JetBrains.TextControl.DocumentMarkup.IDocumentMarkupManager documentMarkupManager, 
                    JetBrains.TextControl.DocumentMarkup.IHighlighterCustomization highlighterCustomization, 
                    JetBrains.Application.Interop.NativeHook.IWindowsHookManager windowsHookManager, 
                    JetBrains.UI.PopupWindowManager.MainWindowPopupWindowContext mainWindowPopupWindowContext, 
                    JetBrains.VsIntegration.DevTen.TextControl.IVsTextControlDevTenIncrementalSearchClient vsTextControlDevTenIncrementalSearchClient, 
                    JetBrains.UI.Application.IUIApplication environment, 
                    [JetBrains.Annotations.NotNullAttribute()] JetBrains.VsIntegration.DevTen.TextControl.VsErrorStripeLayoutManagerDevTen errorStripeLayoutManager) { }
        public override JetBrains.TextControl.ITextControlCaret Caret { get; }
        public override JetBrains.TextControl.Coords.ITextControlCoords Coords { get; }
        public override bool IsReadOnly { get; }
        public override JetBrains.TextControl.ITextControlScrolling Scrolling { get; }
        public override JetBrains.TextControl.ITextControlSelection Selection { get; }
        public override JetBrains.TextControl.ITextControlWindow Window { get; }
        protected override object Execute(JetBrains.Application.IChangeMap changeMap) { }
        public override void FillVirtualSpaceUntilCaret() { }
        protected override Microsoft.VisualStudio.TextManager.Interop.IVsCompoundAction GetVsTextViewCompoundAction() { }
        public override Microsoft.VisualStudio.OLE.Interop.IOleCommandTarget GetVsTextViewOleCommandTarget() { }
        protected override void Init_AfterFieldInit() { }
        public override bool IsPositionInTextView(JetBrains.TextControl.Coords.ITextControlPos position) { }
        public override void PushOleCommandFilter(JetBrains.DataFlow.Lifetime lifetime, Microsoft.VisualStudio.OLE.Interop.IOleCommandTarget filter, out Microsoft.VisualStudio.OLE.Interop.IOleCommandTarget callnext) { }
        [JetBrains.Threading.GuardAttribute(JetBrains.Threading.Rgc.Guarded)]
        public override void SyncToVsGuarded() { }
    }
    [JetBrains.Annotations.UsedImplicitlyAttribute()]
    [Microsoft.VisualStudio.Text.Editor.TextViewRoleAttribute("INTERACTIVE")]
    [Microsoft.VisualStudio.Utilities.ContentTypeAttribute("text")]
    [System.ComponentModel.Composition.ExportAttribute(typeof(Microsoft.VisualStudio.Text.Editor.IWpfTextViewCreationListener))]
    [System.ComponentModel.Composition.PartCreationPolicyAttribute(System.ComponentModel.Composition.CreationPolicy.Shared)]
    public class VsTextViewSink : Microsoft.VisualStudio.Text.Editor.IWpfTextViewCreationListener
    {
        public VsTextViewSink() { }
    }
}
namespace JetBrains.VsIntegration.DevTen.TextControl.CurrentLine
{
    
    [JetBrains.Application.ShellComponentAttribute()]
    public class VsCurrentLineDevTen
    {
        public VsCurrentLineDevTen(JetBrains.DataFlow.Lifetime lifetime, JetBrains.TextControl.ITextControlManager textman, JetBrains.Util.Lazy.Lazy<Microsoft.VisualStudio.Text.Classification.IClassificationTypeRegistryService> classificationTypeRegistryService, JetBrains.Util.Lazy.Lazy<Microsoft.VisualStudio.Text.Classification.IClassificationFormatMapService> classificationFormatMapService) { }
    }
}
namespace JetBrains.VsIntegration.DevTen.TextControl.GutterMargin
{
    
    public interface IVsGutterMarginTag : Microsoft.VisualStudio.Text.Tagging.ITag
    {
        JetBrains.TextControl.DocumentMarkup.IGutterMarkInfo GlyphMarginInfo { get; }
        JetBrains.Util.TextRange Range { get; }
    }
    public class VsGutterMargin : System.Windows.Controls.Grid, Microsoft.VisualStudio.Text.Editor.ITextViewMargin, Microsoft.VisualStudio.Text.Editor.IWpfTextViewMargin, System.IDisposable
    {
        public VsGutterMargin(Microsoft.VisualStudio.Text.Editor.IWpfTextViewHost textViewHost, Microsoft.VisualStudio.Text.Tagging.ITagAggregator<JetBrains.VsIntegration.DevTen.TextControl.GutterMargin.IVsGutterMarginTag> tagAggregator, Microsoft.VisualStudio.Editor.IVsEditorAdaptersFactoryService editorAdaptersFactoryService) { }
        public JetBrains.DataFlow.Property<JetBrains.VsIntegration.DevTen.TextControl.GutterMargin.VsTextViewComponentContext> ComponentContext { get; }
        public bool Enabled { get; }
        public JetBrains.VsIntegration.DevTen.TextControl.GutterMargin.VsGutterMarginControl MarginControl { get; }
        public JetBrains.DataFlow.IProperty<bool> MarginEnabled { get; }
        public double MarginSize { get; }
        public static JetBrains.DataFlow.PropertyId<JetBrains.VsIntegration.DevTen.TextControl.GutterMargin.VsGutterMargin> PropertyId { get; }
        public Microsoft.VisualStudio.Text.Tagging.ITagAggregator<JetBrains.VsIntegration.DevTen.TextControl.GutterMargin.IVsGutterMarginTag> TagAggregator { get; }
        public Microsoft.VisualStudio.Text.Editor.IWpfTextView TextView { get; }
        public System.Windows.FrameworkElement VisualElement { get; }
        public void Dispose() { }
        public Microsoft.VisualStudio.Text.Editor.ITextViewMargin GetTextViewMargin(string marginName) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class VsGutterMarginComponentDisabledByDefault : JetBrains.TextControl.GutterMargin.GutterMarginImpl
    {
        public VsGutterMarginComponentDisabledByDefault(JetBrains.DataFlow.Lifetime lifetime) { }
        public override JetBrains.UI.IAnchoringRect GetAnchorForLine(JetBrains.TextControl.ITextControl textControl, JetBrains.DocumentModel.DocumentCoords line, JetBrains.DataFlow.Lifetime lifetime) { }
        public static JetBrains.DataFlow.Property<JetBrains.VsIntegration.DevTen.TextControl.GutterMargin.VsGutterMargin> GetOrCreateSingletonProperty(Microsoft.VisualStudio.Text.Editor.IWpfTextView wpfTextView) { }
        public override bool IsApplicable() { }
    }
    public class VsGutterMarginControl : System.Windows.Controls.Canvas
    {
        public VsGutterMarginControl(JetBrains.DataFlow.Lifetime lifetime, JetBrains.VsIntegration.DevTen.TextControl.GutterMargin.VsGutterMargin margin) { }
        public JetBrains.UI.IAnchoringRect GetContextForLine(JetBrains.TextControl.ITextControl textControl, JetBrains.DocumentModel.DocumentCoords line, JetBrains.DataFlow.Lifetime lifetime) { }
        public void OnLayoutChanged() { }
    }
    [Microsoft.VisualStudio.Text.Editor.MarginContainerAttribute("Left")]
    [Microsoft.VisualStudio.Text.Editor.TextViewRoleAttribute("INTERACTIVE")]
    [Microsoft.VisualStudio.Utilities.ContentTypeAttribute("text")]
    [Microsoft.VisualStudio.Utilities.NameAttribute("ReSharperVsTextControlMarginProvider2")]
    [Microsoft.VisualStudio.Utilities.OrderAttribute(After="Glyph", Before="LeftSelection")]
    [System.ComponentModel.Composition.ExportAttribute(typeof(Microsoft.VisualStudio.Text.Editor.IWpfTextViewMarginProvider))]
    public class VsGutterMarginProvider : Microsoft.VisualStudio.Text.Editor.IWpfTextViewMarginProvider, System.IDisposable
    {
        public const string MargniName = "ReSharperVsTextControlMarginProvider2";
        [System.ComponentModel.Composition.ImportAttribute()]
        public Microsoft.VisualStudio.Editor.IVsEditorAdaptersFactoryService myEditorService;
        [System.ComponentModel.Composition.ImportAttribute()]
        public Microsoft.VisualStudio.Text.Tagging.IViewTagAggregatorFactoryService TagAggregatorFactory { get; set; }
        public Microsoft.VisualStudio.Text.Editor.IWpfTextViewMargin CreateMargin(Microsoft.VisualStudio.Text.Editor.IWpfTextViewHost textViewHost, Microsoft.VisualStudio.Text.Editor.IWpfTextViewMargin marginContainer) { }
        public void Dispose() { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class VsTextViewComponent
    {
        public VsTextViewComponent(JetBrains.DataFlow.Lifetime lifetime, JetBrains.TextControl.TextControlManager textControlManager, JetBrains.Application.Settings.Store.Implementation.SettingsStore settingsStore, JetBrains.VsIntegration.DevTen.Markup.VsDocumentMarkupTaggerComponent vsDocumentMarkupTagger, JetBrains.UI.Application.IUIApplication environment, JetBrains.UI.BulbMenu.BulbMenuComponent bulbMenuComponent, JetBrains.UI.PopupWindowManager.MainWindowPopupWindowContext mainWindowPopupWindowContext, JetBrains.TextControl.GutterMargin.IGutterMargin gutterMargin, JetBrains.Application.Interop.NativeHook.IWindowsHookManager hooksManager) { }
        public static JetBrains.DataFlow.Property<JetBrains.VsIntegration.DevTen.TextControl.GutterMargin.VsTextViewComponentContext> GetOrCreateSingletonProperty(Microsoft.VisualStudio.Text.Editor.IWpfTextView wpfTextView) { }
    }
    public class VsTextViewComponentContext
    {
        public VsTextViewComponentContext(JetBrains.TextControl.GutterMargin.IGutterMargin gutterMargin, JetBrains.TextControl.ITextControl textControl, JetBrains.Application.Settings.Store.Implementation.SettingsStore settingsStore, JetBrains.VsIntegration.DevTen.Markup.VsDocumentMarkupTaggerComponent vsDocumentMarkupTagger, JetBrains.UI.Application.IUIApplication environment, JetBrains.UI.BulbMenu.BulbMenuComponent bulbMenuComponent, JetBrains.UI.PopupWindowManager.MainWindowPopupWindowContext mainWindowPopupWindowContext, JetBrains.DataFlow.Lifetime textControlLifetime, JetBrains.Application.Interop.NativeHook.IWindowsHookManager hooksManager) { }
        public JetBrains.UI.BulbMenu.BulbMenuComponent BulbMenuComponent { get; }
        public JetBrains.UI.Application.IUIApplication Environment { get; }
        public JetBrains.TextControl.GutterMargin.IGutterMargin GutterMargin { get; }
        public JetBrains.Application.Interop.NativeHook.IWindowsHookManager HooksManager { get; }
        public JetBrains.DataFlow.IProperty<bool> IsMarginEnabled { get; }
        public JetBrains.UI.PopupWindowManager.MainWindowPopupWindowContext MainWindowPopupWindowContext { get; }
        public JetBrains.Application.Settings.Store.Implementation.SettingsStore SettingsStore { get; }
        public JetBrains.TextControl.ITextControl TextControl { get; }
        public JetBrains.VsIntegration.DevTen.Markup.VsDocumentMarkupTaggerComponent VsDocumentMarkupTagger { get; }
    }
}
namespace JetBrains.VsIntegration.DevTen.TextControl.Marginal
{
    
    public class VsTextControlDynamicMargin : Microsoft.VisualStudio.Text.Editor.ITextViewMargin, Microsoft.VisualStudio.Text.Editor.IWpfTextViewMargin, System.IDisposable
    {
        public VsTextControlDynamicMargin([JetBrains.Annotations.NotNullAttribute()] JetBrains.VsIntegration.DevTen.TextControl.Marginal.VsTextControlDynamicMargin.Data data) { }
        public static void AddToTextControl([JetBrains.Annotations.NotNullAttribute()] Microsoft.VisualStudio.Text.Editor.IWpfTextView textview, [JetBrains.Annotations.NotNullAttribute()] JetBrains.VsIntegration.DevTen.TextControl.Marginal.VsTextControlDynamicMargin.Data data, System.Windows.Controls.Dock dock, Microsoft.VisualStudio.Editor.IVsEditorAdaptersFactoryService vsEditorAdaptersFactoryService, JetBrains.Application.IApplicationDescriptor applicationDescriptor) { }
        public class Data
        {
            [JetBrains.Annotations.NotNullAttribute()]
            public readonly string Id;
            public readonly double Width;
            public Data([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] string id, double width, [JetBrains.Annotations.NotNullAttribute()] System.Func<JetBrains.DataFlow.Lifetime, System.Windows.FrameworkElement> FCreateView) { }
            [JetBrains.Annotations.NotNullAttribute()]
            public System.Windows.FrameworkElement CreateView() { }
        }
        public class Provider : Microsoft.VisualStudio.Text.Editor.IWpfTextViewMarginProvider
        {
            public Provider([JetBrains.Annotations.NotNullAttribute()] JetBrains.VsIntegration.DevTen.TextControl.Marginal.VsTextControlDynamicMargin.Data creationData) { }
            [JetBrains.Annotations.NotNullAttribute()]
            public JetBrains.VsIntegration.DevTen.TextControl.Marginal.VsTextControlDynamicMargin.Provider Clone() { }
            [JetBrains.Annotations.NotNullAttribute()]
            public Microsoft.VisualStudio.Text.Editor.IWpfTextViewMargin CreateMargin() { }
        }
    }
    public class VsTextControlMarginDevTen : Microsoft.VisualStudio.Text.Editor.ITextViewMargin, Microsoft.VisualStudio.Text.Editor.IWpfTextViewMargin, System.IDisposable
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly JetBrains.DataFlow.ListEvents<System.Windows.UIElement> Children;
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly Microsoft.VisualStudio.Text.Editor.IWpfTextViewMargin Container;
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly JetBrains.DataFlow.ObsoleteLifetimeAndDefinitionAtTheSameTime Disposables;
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly Microsoft.VisualStudio.Text.Editor.IWpfTextViewHost Host;
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly string MarginFullName;
        public VsTextControlMarginDevTen([JetBrains.Annotations.NotNullAttribute()] string marginFullName, System.Windows.Controls.Orientation orientation, [JetBrains.Annotations.NotNullAttribute()] Microsoft.VisualStudio.Text.Editor.IWpfTextViewHost host, [JetBrains.Annotations.NotNullAttribute()] Microsoft.VisualStudio.Text.Editor.IWpfTextViewMargin container) { }
    }
    public class static VsTextControlMarginDevTenEx
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.VsIntegration.DevTen.TextControl.Marginal.VsTextControlMarginDevTen GetMargin([JetBrains.Annotations.NotNullAttribute()] this Microsoft.VisualStudio.Text.Editor.IWpfTextView view, System.Windows.Controls.Dock dock) { }
    }
}
namespace JetBrains.VsIntegration.DevTen.UI
{
    
    [JetBrains.Application.ShellComponentAttribute()]
    public class PublishPlatformResourceDictionaryToAvalonApplicationV4
    {
        public PublishPlatformResourceDictionaryToAvalonApplicationV4([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.UI.Wpf.IPlatformResourceDictionary platformResourceDictionary) { }
    }
    public class static VsAvalonStatusBarShimDevTen
    {
        public static void SubclassDevTenBeta2StatusDockPanel(JetBrains.DataFlow.Lifetime lifetime, System.Windows.Controls.Panel dockStatus, JetBrains.DataFlow.IListEvents<JetBrains.UI.StatusBar.JetStatusBarIndicator> indicators, JetBrains.UI.PopupWindowManager.MainWindowPopupWindowContext mainWindowPopupWindowContext, JetBrains.UI.PopupMenu.JetPopupMenus jetPopupMenus, JetBrains.Application.Interop.NativeHook.IWindowsHookManager windowsHookManager, JetBrains.UI.Theming.ITheming environment) { }
        public static bool TrySubclassDevTenBeta2StatusDockPanelInWindow(JetBrains.DataFlow.Lifetime lifetime, System.IntPtr hwnd, JetBrains.DataFlow.IListEvents<JetBrains.UI.StatusBar.JetStatusBarIndicator> indicators, JetBrains.UI.PopupWindowManager.MainWindowPopupWindowContext mainWindowPopupWindowContext, JetBrains.UI.PopupMenu.JetPopupMenus jetPopupMenus, JetBrains.Application.Interop.NativeHook.IWindowsHookManager windowsHookManager, JetBrains.UI.Theming.ITheming environment) { }
    }
    [JetBrains.Application.ShellComponentAttribute(JetBrains.Application.Sharing.Common, JetBrains.Application.Lifecycle.Deferred, JetBrains.Application.Creation.PrimaryThread, JetBrains.Application.Access.None)]
    public class VsStatusBarIndicatorsDevTen
    {
        public VsStatusBarIndicatorsDevTen(JetBrains.DataFlow.Lifetime lifetime, JetBrains.UI.StatusBar.IStatusBar statusBar, JetBrains.UI.Application.IMainWindow mainwin, JetBrains.Threading.IThreading threading, JetBrains.UI.PopupWindowManager.MainWindowPopupWindowContext mainWindowPopupWindowContext, JetBrains.UI.PopupMenu.JetPopupMenus jetPopupMenus, JetBrains.Application.Interop.NativeHook.IWindowsHookManager windowsHookManager, JetBrains.UI.Theming.ITheming environment) { }
    }
}
namespace JetBrains.VsIntegration.SinceVs10.Diagnostics
{
    
    [JetBrains.Application.ShellComponentAttribute()]
    public class TextControlDebugMonitorDevTen : JetBrains.TextControl.Diagnostics.TextControlDebugMonitor
    {
        public TextControlDebugMonitorDevTen(JetBrains.DataFlow.Lifetime lifetime, JetBrains.UI.Application.IMainWindow mainwin, JetBrains.TextControl.ITextControlManager textControlManager, JetBrains.Application.IApplicationDescriptor applicationDescriptor, JetBrains.Application.IShellLocks locks) { }
        protected override string GetTextControlRoles(JetBrains.TextControl.ITextControl textcontrol) { }
    }
}
namespace JetBrains.VsIntegration.SinceVs10.Interop
{
    
    [JetBrains.VsIntegration.Application.WrapVsInterfacesAttribute()]
    public class ExposeSinceVs10Services : JetBrains.VsIntegration.Application.IExposeVsServices { }
    public class static VsServiceMapEx
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.VsIntegration.Application.VsServiceProviderResolver.VsServiceMap Mef<TMefInterface>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.VsIntegration.Application.VsServiceProviderResolver.VsServiceMap thіs)
            where TMefInterface :  class { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.VsIntegration.Application.VsServiceProviderResolver.VsServiceMap OptionalMef<TMefInterface>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.VsIntegration.Application.VsServiceProviderResolver.VsServiceMap thіs)
            where TMefInterface :  class { }
    }
}
namespace JetBrains.VsIntegration.SinceVs10.NuGet
{
    
    [JetBrains.VsIntegration.Application.WrapVsInterfacesAttribute()]
    public class ExposeNuGetServices : JetBrains.VsIntegration.Application.IExposeVsServices
    {
        public void Register(JetBrains.VsIntegration.Application.VsServiceProviderResolver.VsServiceMap map) { }
    }
}
namespace JetBrains.VsIntegration.SinceVs10.ProjectModel
{
    
    public class UnloadedProjectOutputPathsCache
    {
        public UnloadedProjectOutputPathsCache() { }
        public static void CreateTemporary(JetBrains.DataFlow.Lifetime lifetime) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.Util.FileSystemPath GetOutputPath(JetBrains.Util.FileSystemPath projectPath) { }
    }
}
namespace JetBrains.VsIntegration.SinceVs10.Shell
{
    
    [JetBrains.Application.Env.EnvironmentComponentAttribute(JetBrains.Application.Sharing.Common)]
    public class VsSkipFirstLaunchSetupProductCanBeStarted : JetBrains.Application.Env.IProductCanBeStarted
    {
        public VsSkipFirstLaunchSetupProductCanBeStarted([JetBrains.Annotations.NotNullAttribute()] Microsoft.VisualStudio.Shell.Interop.IVsAppCommandLine vsAppCommandLine) { }
    }
}
namespace JetBrains.VsIntegration.SinceVs10.TextControl
{
    
    [JetBrains.Application.ShellComponentAttribute()]
    public class FindWindowFrameViaTextViewServiceProvider : JetBrains.VsIntegration.SinceVs10.TextControl.IFindWindowFrameForVsTextView
    {
        public FindWindowFrameViaTextViewServiceProvider([JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.Lazy.Lazy<Microsoft.VisualStudio.Editor.IVsEditorAdaptersFactoryService> vsEditorAdaptersFactoryService, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.Lazy.Lazy<JetBrains.VsIntegration.WindowManagement.VsWindowFrameManager> vsWindowFrameManager, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.ILogger logger) { }
    }
    public interface IFindWindowFrameForVsTextView
    {
        double Priority { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.UI.WindowManagement.WindowFrame TryFindWindowFrameForVsTextView([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] Microsoft.VisualStudio.Text.Editor.IWpfTextView wpfTextView);
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class VsTextControlDevTenIncrementalSearchClientSinceVs10 : JetBrains.VsIntegration.DevTen.TextControl.IVsTextControlDevTenIncrementalSearchClient
    {
        public VsTextControlDevTenIncrementalSearchClientSinceVs10([JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.Lazy.Lazy<Microsoft.VisualStudio.Text.IncrementalSearch.IIncrementalSearchFactoryService> incrementalSearchFactoryService) { }
        protected virtual bool IsVsIncrementalSearchActive([JetBrains.Annotations.NotNullAttribute()] Microsoft.VisualStudio.Text.Editor.IWpfTextView wpfTextView) { }
    }
}