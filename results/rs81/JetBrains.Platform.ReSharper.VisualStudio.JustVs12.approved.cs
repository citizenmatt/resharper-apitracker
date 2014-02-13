[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]
[assembly: System.Runtime.Versioning.TargetFrameworkAttribute(".NETFramework,Version=v4.5", FrameworkDisplayName=".NET Framework 4.5")]

namespace JetBrains.Application.Extensions
{
    
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "ExtensionManager"})]
    public class ExtensionManagerActionHandler : JetBrains.ActionManagement.IActionHandler
    {
        public void Execute(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.DelegateExecute nextExecute) { }
        public bool Update(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.ActionPresentation presentation, JetBrains.ActionManagement.DelegateUpdate nextUpdate) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class InteractiveProxyCredentialStore : JetBrains.Application.Extensions.IInteractiveProxyCredentialStore
    {
        public InteractiveProxyCredentialStore(Microsoft.VisualStudio.Shell.Interop.IVsWebProxy vsWebProxyService) { }
        public System.Net.ICredentials GetCredentials(System.Uri uri, System.Net.IWebProxy proxy, bool authenticateProxy, bool allowPrompt) { }
    }
}
namespace JetBrains.Application.Extensions.UI
{
    
    public class CachingImageSourceConverter : System.Windows.Data.IValueConverter
    {
        public object Convert(object value, System.Type targetType, object parameter, System.Globalization.CultureInfo culture) { }
        public object ConvertBack(object value, System.Type targetType, object parameter, System.Globalization.CultureInfo culture) { }
    }
    public class CountToVisibilityConverter : System.Windows.Data.IValueConverter
    {
        public bool Inverted { get; set; }
        public object Convert(object value, System.Type targetType, object parameter, System.Globalization.CultureInfo culture) { }
        public object ConvertBack(object value, System.Type targetType, object parameter, System.Globalization.CultureInfo culture) { }
    }
    public class ExtensionDataSource
    {
        public ExtensionDataSource(JetBrains.Application.Extensions.UI.IExtensionQueryProvider queryProvider, JetBrains.Application.Extensions.UI.QueryParameters queryParameters) { }
        public void Cancel() { }
        public void GetExtensionsAsync(int pageNumber, int pageSize, System.Action<JetBrains.Application.Extensions.UI.ExtensionDataSourceResult> onResults) { }
    }
    public class ExtensionDataSourceResult
    {
        public bool Cancelled;
        public System.Exception Exception;
        public System.Collections.Generic.IEnumerable<Microsoft.VisualStudio.ExtensionsExplorer.IVsExtension> Extensions;
        public int TotalCount;
    }
    public abstract class ExtensionItemViewModelBase : JetBrains.Application.Extensions.UI.IExtensionItemViewModel, Microsoft.VisualStudio.ExtensionsExplorer.IVsExtension, System.ComponentModel.INotifyPropertyChanged
    {
        protected ExtensionItemViewModelBase(string id, JetBrains.Application.Extensions.IExtensionMetadata metadata) { }
        public virtual string Authors { get; }
        public virtual System.Collections.Generic.IEnumerable<string> Dependencies { get; }
        public virtual string Description { get; }
        public abstract System.Nullable<int> DownloadCount { get; }
        public virtual string EnableDisableCommandText { get; }
        public abstract System.Uri GalleryDetailsUrl { get; }
        public virtual System.Uri IconUrl { get; }
        public string Id { get; }
        public abstract string InstalledVersion { get; }
        public virtual string InstallUninstallCommandText { get; }
        public abstract bool IsEnabled { get; set; }
        public abstract bool IsInstalled { get; }
        public virtual bool IsPrerelease { get; }
        public bool IsSelected { get; set; }
        public abstract bool IsSupported { get; }
        public virtual System.Uri LicenseUrl { get; }
        public System.Windows.Media.Imaging.BitmapSource MediumThumbnailImage { get; }
        public virtual string Name { get; }
        public System.Windows.Media.Imaging.BitmapSource PreviewImage { get; }
        public float Priority { get; }
        public virtual System.Uri ProjectUrl { get; }
        public abstract System.Nullable<System.DateTimeOffset> PublishedDate { get; }
        public abstract JetBrains.DataFlow.ICollectionEvents<JetBrains.Application.Extensions.ExtensionRecord> Records { get; }
        public abstract string ReleaseNotes { get; }
        public abstract System.Uri ReportAbuseUrl { get; }
        public abstract bool ShowAlreadyInstalledIndicator { get; }
        public bool ShowProblemIndicator { get; }
        public abstract bool ShowReleaseNotes { get; }
        public System.Windows.Media.Imaging.BitmapSource SmallThumbnailImage { get; }
        public virtual string Summary { get; }
        public virtual string Tags { get; }
        public abstract string Version { get; }
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        [JetBrains.Annotations.NotifyPropertyChangedInvocatorAttribute()]
        protected virtual void OnPropertyChanged(string propertyName) { }
        public virtual void UpdateInstalledStatus() { }
    }
    public class static ExtensionItemViewModelExtensions
    {
        public static System.Collections.Generic.IEnumerable<JetBrains.Application.Extensions.UI.IExtensionItemViewModel> Filter(this System.Collections.Generic.IEnumerable<JetBrains.Application.Extensions.UI.IExtensionItemViewModel> source, string searchTerm) { }
        public static System.Collections.Generic.IEnumerable<JetBrains.Application.Extensions.UI.IExtensionItemViewModel> Filter(this System.Collections.Generic.IEnumerable<JetBrains.Application.Extensions.UI.IExtensionItemViewModel> source, System.Collections.Generic.IList<string> searchTerm) { }
        public static System.Collections.Generic.IEnumerable<JetBrains.Application.Extensions.UI.IExtensionItemViewModel> Order(this System.Collections.Generic.IEnumerable<JetBrains.Application.Extensions.UI.IExtensionItemViewModel> source, JetBrains.Application.Extensions.SortOrder sortOrder) { }
        public static System.Collections.Generic.IEnumerable<T> Page<T>(this System.Collections.Generic.IEnumerable<T> source, int pageNumber, int pageSize) { }
    }
    public class ExtensionManagerWindow : Microsoft.VisualStudio.PlatformUI.DialogWindow, System.Windows.Markup.IComponentConnector
    {
        public ExtensionManagerWindow(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.DataContext.IDataContext context) { }
        public ExtensionManagerWindow(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.Extensions.ExtensionManager extensionManager, JetBrains.Application.IApplicationDescriptor product, JetBrains.Application.Extensions.IExtensionCatalogProvider extensionCatalogProvider, JetBrains.Application.Extensions.ExtensionRepositoryManager extensionRepositoryManager, JetBrains.Application.Extensions.IProviderSettings providerSettings, JetBrains.Application.Extensions.UI.ExtensionManagerOptionsPageActivator optionsPageActivator, JetBrains.Application.Env.Components.IApplicationRestart applicationRestart) { }
        public void InitializeComponent() { }
    }
    public class ExtensionRecordSeverityToColorConverter : System.Windows.Data.IValueConverter
    {
        public object Convert(object value, System.Type targetType, object parameter, System.Globalization.CultureInfo culture) { }
        public object ConvertBack(object value, System.Type targetType, object parameter, System.Globalization.CultureInfo culture) { }
    }
    public class ExtensionSortDescriptor : Microsoft.VisualStudio.ExtensionsExplorer.IVsSortDescriptor, System.Collections.IComparer
    {
        public ExtensionSortDescriptor(string name, JetBrains.Application.Extensions.SortOrder sortOrder) { }
        public string Name { get; }
        public JetBrains.Application.Extensions.SortOrder SortOrder { get; }
        public int Compare(object x, object y) { }
        public override string ToString() { }
    }
    public abstract class ExtensionsProviderBase : Microsoft.VisualStudio.ExtensionsExplorer.UI.VsExtensionsProvider, System.ComponentModel.INotifyPropertyChanged
    {
        protected ExtensionsProviderBase(JetBrains.Application.Extensions.UI.ProviderServices providerServices, System.Windows.ResourceDictionary resources) { }
        public override object DetailViewDataTemplate { get; }
        public JetBrains.Application.Extensions.SortOrder ExtensionSortOrder { get; set; }
        public override Microsoft.VisualStudio.ExtensionsExplorer.IVsExtensionsTreeNode ExtensionsTree { get; }
        public virtual bool IncludePrerelease { get; set; }
        public override object MediumIconDataTemplate { get; }
        public abstract string NoItemsMessage { get; }
        public System.Action OnInstallUninstallCompletedCallback { get; set; }
        protected abstract string ProgressWindowTitle { get; }
        protected JetBrains.Application.Extensions.UI.VsExtensionsTreeNodeBase SelectedNode { get; }
        public virtual bool ShowPrereleaseCombo { get; }
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        protected bool AcceptLicenses(System.Collections.Generic.IEnumerable<JetBrains.Application.Extensions.IExtensionCatalogItem> extensions) { }
        public virtual bool CanEnableDisable(JetBrains.Application.Extensions.UI.IExtensionItemViewModel extension) { }
        public virtual bool CanInstallUninstall(JetBrains.Application.Extensions.UI.IExtensionItemViewModel extension) { }
        protected void ClearProgressMessages() { }
        protected void CloseProgressWindow() { }
        public virtual void DoInstallUninstall(JetBrains.Application.Extensions.UI.IExtensionItemViewModel extension) { }
        protected virtual void DoInstallUninstallBackground(object sender, System.ComponentModel.DoWorkEventArgs eventArgs) { }
        protected abstract bool DoInstallUninstallBackground(JetBrains.Application.Extensions.UI.IExtensionItemViewModel extension);
        protected void EnsureExtensionsTree() { }
        protected virtual System.Collections.Generic.IEnumerable<Microsoft.VisualStudio.ExtensionsExplorer.IVsExtensionsTreeNode> GetTreeNodes(Microsoft.VisualStudio.ExtensionsExplorer.IVsExtensionsTreeNode rootNode) { }
        protected void HideProgressWindow() { }
        protected void LogMessage(JetBrains.Util.LoggingLevel level, string message) { }
        protected virtual void OnInstallUninstallCancelled() { }
        protected void OnInstallUninstallCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs eventArgs) { }
        protected virtual void OnInstallUninstallCompleted() { }
        protected virtual void OnInstallUninstallFailed(System.Exception error) { }
        [JetBrains.Annotations.NotifyPropertyChangedInvocatorAttribute()]
        protected virtual void OnPropertyChanged(string propertyName) { }
        public override Microsoft.VisualStudio.ExtensionsExplorer.IVsExtensionsTreeNode Search(string searchTerm) { }
        protected void SetProgressCompleted(bool successful) { }
        protected void ShowProgressWindow() { }
        protected System.Nullable<bool> ShowRemoveDependenciesWindow(string message) { }
        public virtual void ToggleEnabled(JetBrains.Application.Extensions.UI.IExtensionItemViewModel extension) { }
        protected void UpdateProgress(string operation, int percentComplete) { }
        protected class ExtensionCatalogEvents : JetBrains.Application.Extensions.IExtensionCatalogActionEvents
        {
            public ExtensionCatalogEvents(JetBrains.Application.Extensions.UI.ExtensionsProviderBase provider) { }
            public bool AcceptLicenses(System.Collections.Generic.IEnumerable<JetBrains.Application.Extensions.IExtensionCatalogItem> extensions) { }
            public void Log(JetBrains.Util.LoggingLevel level, string message) { }
            public void ProgressAvailable(string operation, int percentComplete) { }
        }
    }
    public class FixUrlConverter : System.Windows.Data.IValueConverter
    {
        public object Convert(object value, System.Type targetType, object parameter, System.Globalization.CultureInfo culture) { }
        public object ConvertBack(object value, System.Type targetType, object parameter, System.Globalization.CultureInfo culture) { }
    }
    public interface IExtensionItemViewModel
    {
        string Authors { get; }
        System.Collections.Generic.IEnumerable<string> Dependencies { get; }
        string Description { get; }
        System.Nullable<int> DownloadCount { get; }
        string EnableDisableCommandText { get; }
        System.Uri GalleryDetailsUrl { get; }
        System.Uri IconUrl { get; }
        string Id { get; }
        string InstalledVersion { get; }
        string InstallUninstallCommandText { get; }
        bool IsEnabled { get; set; }
        bool IsInstalled { get; }
        bool IsPrerelease { get; }
        bool IsSelected { get; }
        bool IsSupported { get; }
        System.Uri LicenseUrl { get; }
        string Name { get; }
        System.Uri ProjectUrl { get; }
        System.Nullable<System.DateTimeOffset> PublishedDate { get; }
        JetBrains.DataFlow.ICollectionEvents<JetBrains.Application.Extensions.ExtensionRecord> Records { get; }
        string ReleaseNotes { get; }
        System.Uri ReportAbuseUrl { get; }
        bool ShowAlreadyInstalledIndicator { get; }
        bool ShowProblemIndicator { get; }
        bool ShowReleaseNotes { get; }
        string Summary { get; }
        string Tags { get; }
        string Version { get; }
        void UpdateInstalledStatus();
    }
    public interface IExtensionQuery
    {
        int GetTotalCount();
        System.Collections.Generic.IEnumerable<Microsoft.VisualStudio.ExtensionsExplorer.IVsExtension> MaterialisePage(int pageNumber, int pageSize);
    }
    public interface IExtensionQueryProvider
    {
        JetBrains.Application.Extensions.UI.IExtensionQuery GetQuery(string searchTerm, bool includePrerelease, JetBrains.Application.Extensions.SortOrder sortOrder);
    }
    public class InstalledExtensionsProvider : JetBrains.Application.Extensions.UI.ExtensionsProviderBase, System.IDisposable
    {
        public InstalledExtensionsProvider(JetBrains.Application.Extensions.ExtensionManager extensionManager, JetBrains.Application.Extensions.ExtensionRepositoryManager extensionRepositoryManager, JetBrains.Application.Extensions.UI.ProviderServices providerServices, System.Windows.ResourceDictionary resources) { }
        public override bool IncludePrerelease { get; set; }
        public override string Name { get; }
        public override string NoItemsMessage { get; }
        protected override string ProgressWindowTitle { get; }
        public override bool ShowPrereleaseCombo { get; }
        public override float SortOrder { get; }
        public override bool CanEnableDisable(JetBrains.Application.Extensions.UI.IExtensionItemViewModel extension) { }
        public override bool CanInstallUninstall(JetBrains.Application.Extensions.UI.IExtensionItemViewModel extension) { }
        public void Dispose() { }
        protected override bool DoInstallUninstallBackground(JetBrains.Application.Extensions.UI.IExtensionItemViewModel extension) { }
        protected override System.Collections.Generic.IEnumerable<Microsoft.VisualStudio.ExtensionsExplorer.IVsExtensionsTreeNode> GetTreeNodes(Microsoft.VisualStudio.ExtensionsExplorer.IVsExtensionsTreeNode rootNode) { }
        protected override void OnInstallUninstallCompleted() { }
        public void Reload() { }
        public override void ToggleEnabled(JetBrains.Application.Extensions.UI.IExtensionItemViewModel extension) { }
    }
    public class InstalledExtensionsTreeNode : JetBrains.Application.Extensions.UI.VsExtensionsTreeNodeBase
    {
        public InstalledExtensionsTreeNode(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.Extensions.UI.ExtensionsProviderBase provider, Microsoft.VisualStudio.ExtensionsExplorer.IVsExtensionsTreeNode parent, string name, JetBrains.Application.Extensions.ExtensionManager extensionManager, System.Func<JetBrains.Application.Extensions.IExtension, bool> includeExtensionPredicate) { }
        protected override System.Collections.Generic.IEnumerable<JetBrains.Application.Extensions.SortOrder> SupportedSortOrders { get; }
    }
    public interface IProgressWindowOpener
    {
        bool IsOpen { get; }
        public event System.EventHandler UpgradeNuGetRequested;
        void AddMessage(JetBrains.Util.LoggingLevel level, string message);
        void ClearMessages();
        bool Close();
        void Hide();
        void SetCompleted(bool successful, bool showUpgradeNuGetButton);
        void Show(string title, System.Windows.Window owner);
        void ShowProgress(string operation, int percentComplete);
    }
    public interface IUserNotifierServices
    {
        bool ShowLicenseWindow(System.Collections.Generic.IEnumerable<JetBrains.Application.Extensions.IExtensionCatalogItem> packages);
        System.Nullable<bool> ShowRemoveDependenciesWindow(string message);
    }
    public class LicenseAcceptanceWindow : Microsoft.VisualStudio.PlatformUI.DialogWindow, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector
    {
        public LicenseAcceptanceWindow(System.Collections.Generic.IEnumerable<JetBrains.Application.Extensions.IExtensionCatalogItem> extensions) { }
        public void InitializeComponent() { }
    }
    public class NormalizeTextConverter : System.Windows.Data.IValueConverter
    {
        public object Convert(object value, System.Type targetType, object parameter, System.Globalization.CultureInfo culture) { }
        public object ConvertBack(object value, System.Type targetType, object parameter, System.Globalization.CultureInfo culture) { }
    }
    public class NullOrEmptyStringToVisibilityConverter : System.Windows.Data.IValueConverter
    {
        public object Convert(object value, System.Type targetType, object parameter, System.Globalization.CultureInfo culture) { }
        public object ConvertBack(object value, System.Type targetType, object parameter, System.Globalization.CultureInfo culture) { }
    }
    public class OnlineExtensionsProvider : JetBrains.Application.Extensions.UI.ExtensionsProviderBase
    {
        public OnlineExtensionsProvider(JetBrains.Application.Extensions.IExtensionCatalogProvider extensionCatalogProvider, JetBrains.Application.Extensions.ExtensionManager extensionManager, JetBrains.Application.Extensions.UI.ProviderServices providerServices, System.Windows.ResourceDictionary resources) { }
        public override string Name { get; }
        public override string NoItemsMessage { get; }
        protected override string ProgressWindowTitle { get; }
        public override float SortOrder { get; }
        public override bool CanInstallUninstall(JetBrains.Application.Extensions.UI.IExtensionItemViewModel extension) { }
        protected override bool DoInstallUninstallBackground(JetBrains.Application.Extensions.UI.IExtensionItemViewModel extension) { }
        protected override System.Collections.Generic.IEnumerable<Microsoft.VisualStudio.ExtensionsExplorer.IVsExtensionsTreeNode> GetTreeNodes(Microsoft.VisualStudio.ExtensionsExplorer.IVsExtensionsTreeNode rootNode) { }
    }
    public class OnlineExtensionsTreeNode : JetBrains.Application.Extensions.UI.VsExtensionsTreeNodeBase
    {
        public OnlineExtensionsTreeNode(JetBrains.Application.Extensions.UI.ExtensionsProviderBase provider, Microsoft.VisualStudio.ExtensionsExplorer.IVsExtensionsTreeNode parent, JetBrains.Application.Extensions.IExtensionCatalog catalog, JetBrains.Application.Extensions.ExtensionManager extensionManager) { }
        public OnlineExtensionsTreeNode(JetBrains.Application.Extensions.UI.ExtensionsProviderBase provider, Microsoft.VisualStudio.ExtensionsExplorer.IVsExtensionsTreeNode parent, string name, JetBrains.Application.Extensions.IExtensionCatalog catalog, JetBrains.Application.Extensions.ExtensionManager extensionManager) { }
        protected override System.Collections.Generic.IEnumerable<JetBrains.Application.Extensions.SortOrder> SupportedSortOrders { get; }
        public bool Install(JetBrains.Application.Extensions.UI.IExtensionItemViewModel extension, JetBrains.Application.Extensions.IExtensionCatalogActionEvents events) { }
        public class ExtensionCatalogItemViewModel : JetBrains.Application.Extensions.UI.ExtensionItemViewModelBase
        {
            public ExtensionCatalogItemViewModel(JetBrains.Application.Extensions.IExtensionCatalogItem extension, JetBrains.Application.Extensions.ExtensionManager extensionManager) { }
            public JetBrains.Application.Extensions.IExtensionCatalogItem CatalogItem { get; }
            public override System.Nullable<int> DownloadCount { get; }
            public override System.Uri GalleryDetailsUrl { get; }
            public override string InstalledVersion { get; }
            public override bool IsEnabled { get; set; }
            public override bool IsInstalled { get; }
            public override bool IsSupported { get; }
            public override System.Nullable<System.DateTimeOffset> PublishedDate { get; }
            public override JetBrains.DataFlow.ICollectionEvents<JetBrains.Application.Extensions.ExtensionRecord> Records { get; }
            public override string ReleaseNotes { get; }
            public override System.Uri ReportAbuseUrl { get; }
            public override bool ShowAlreadyInstalledIndicator { get; }
            public override bool ShowReleaseNotes { get; }
            public override string Version { get; }
            public override void UpdateInstalledStatus() { }
        }
    }
    public class ProgressDialog : Microsoft.VisualStudio.PlatformUI.DialogWindow, System.Windows.Markup.IComponentConnector
    {
        public ProgressDialog() { }
        public bool UpgradeNuGetRequested { get; }
        public void AddMessage(string message, System.Windows.Media.Brush messageColor) { }
        public void ClearMessages() { }
        public void ForceClose() { }
        public void InitializeComponent() { }
        protected override void OnClosing(System.ComponentModel.CancelEventArgs e) { }
        protected override void OnSourceInitialized(System.EventArgs e) { }
        public void ShowProgress(string operation, int percentComplete) { }
    }
    public sealed class ProgressWindowOpener : JetBrains.Application.Extensions.UI.IProgressWindowOpener
    {
        public ProgressWindowOpener(System.Windows.Window owner) { }
        public ProgressWindowOpener() { }
        public bool IsOpen { get; }
        public event System.EventHandler UpgradeNuGetRequested;
        public void AddMessage(JetBrains.Util.LoggingLevel level, string message) { }
        public void ClearMessages() { }
        public bool Close() { }
        public void Hide() { }
        public void SetCompleted(bool successful, bool showUpgradeNuGetButton) { }
        public void Show(string title, System.Windows.Window owner) { }
        public void ShowProgress(string operation, int percentComplete) { }
    }
    public sealed class ProviderServices
    {
        public ProviderServices(JetBrains.Application.Extensions.UI.IUserNotifierServices userNotifierServices, JetBrains.Application.Extensions.UI.IProgressWindowOpener progressWindow, JetBrains.Application.Extensions.IProviderSettings selectedProviderSettings) { }
        public JetBrains.Application.Extensions.UI.IProgressWindowOpener ProgressWindow { get; }
        public JetBrains.Application.Extensions.IProviderSettings ProviderSettings { get; }
        public JetBrains.Application.Extensions.UI.IUserNotifierServices UserNotifierServices { get; }
    }
    public class QueryParameters
    {
        public bool IncludePrerelease;
        public string SearchTerm;
        public JetBrains.Application.Extensions.SortOrder SortOrder;
    }
    public class RestartRequiredBar : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector
    {
        public RestartRequiredBar(JetBrains.Application.Extensions.ExtensionRepositoryManager extensionRepositoryManager, JetBrains.Application.Env.Components.IApplicationRestart applicationRestart) { }
        public void CheckForUnsuccessfulUninstall() { }
        public void InitializeComponent() { }
    }
    public class RestoreExtensionsBar : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector
    {
        public RestoreExtensionsBar(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.Extensions.ExtensionRepositoryManager repositoryManager) { }
        public JetBrains.DataFlow.ISimpleSignal ExtensionsRestored { get; }
        public void InitializeComponent() { }
    }
    public class RootExtensionsTreeNode : Microsoft.VisualStudio.ExtensionsExplorer.IVsExtensionsTreeNode
    {
        public RootExtensionsTreeNode(Microsoft.VisualStudio.ExtensionsExplorer.IVsExtensionsTreeNode parent, string name) { }
        public System.Collections.IList Extensions { get; }
        public bool IsExpanded { get; set; }
        public bool IsSearchResultsNode { get; }
        public bool IsSelected { get; set; }
        public string Name { get; set; }
        public System.Collections.Generic.IList<Microsoft.VisualStudio.ExtensionsExplorer.IVsExtensionsTreeNode> Nodes { get; }
        public Microsoft.VisualStudio.ExtensionsExplorer.IVsExtensionsTreeNode Parent { get; set; }
    }
    public class SearchTreeNode : JetBrains.Application.Extensions.UI.VsExtensionsTreeNodeBase
    {
        public SearchTreeNode(JetBrains.Application.Extensions.UI.ExtensionsProviderBase provider, Microsoft.VisualStudio.ExtensionsExplorer.IVsExtensionsTreeNode parent, string searchTerm, JetBrains.Application.Extensions.UI.IExtensionQueryProvider sourceQueryProvider, JetBrains.Application.Extensions.UI.VsExtensionsTreeNodeBase sourceNode) { }
        public JetBrains.Application.Extensions.UI.VsExtensionsTreeNodeBase SourceNode { get; }
        protected override System.Collections.Generic.IEnumerable<JetBrains.Application.Extensions.SortOrder> SupportedSortOrders { get; }
        public void Reset(string searchTerm) { }
    }
    public class ShowRecordsWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector
    {
        public ShowRecordsWindow(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.Extensions.UI.IExtensionItemViewModel extension, JetBrains.Application.IApplicationDescriptor product) { }
        public void InitializeComponent() { }
    }
    public class static ShowRecordsWindowCommands
    {
        public static readonly System.Windows.Input.RoutedCommand ShowExceptionCommand;
    }
    public class StringCollectionsToStringConverter : System.Windows.Data.IValueConverter
    {
        public object Convert(object value, System.Type targetType, object parameter, System.Globalization.CultureInfo culture) { }
        public object ConvertBack(object value, System.Type targetType, object parameter, System.Globalization.CultureInfo culture) { }
    }
    public class TextBlockControl : System.Windows.Controls.TextBlock
    {
        protected override System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer() { }
    }
    public class static UIResources
    {
        public static object ContentBackgroundBrushKey { get; }
        public static object WindowBackgroundBrushKey { get; }
    }
    public class UpdateAllExtensionsBar : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector
    {
        public UpdateAllExtensionsBar() { }
        public void InitializeComponent() { }
    }
    public class UpdatesExtensionsProvider : JetBrains.Application.Extensions.UI.ExtensionsProviderBase
    {
        public UpdatesExtensionsProvider(JetBrains.Application.Extensions.IExtensionCatalogProvider extensionCatalogProvider, JetBrains.Application.Extensions.ExtensionManager extensionManager, JetBrains.Application.Extensions.UI.ProviderServices providerServices, System.Windows.ResourceDictionary resources) { }
        public override string Name { get; }
        public override string NoItemsMessage { get; }
        protected override string ProgressWindowTitle { get; }
        public override float SortOrder { get; }
        public override bool CanInstallUninstall(JetBrains.Application.Extensions.UI.IExtensionItemViewModel extension) { }
        public bool CanUpdateAll() { }
        public void CheckForUpdates() { }
        public void ClearCachedUpdates(bool dueToUpdate) { }
        protected override void DoInstallUninstallBackground(object sender, System.ComponentModel.DoWorkEventArgs eventArgs) { }
        protected override bool DoInstallUninstallBackground(JetBrains.Application.Extensions.UI.IExtensionItemViewModel extension) { }
        protected override System.Collections.Generic.IEnumerable<Microsoft.VisualStudio.ExtensionsExplorer.IVsExtensionsTreeNode> GetTreeNodes(Microsoft.VisualStudio.ExtensionsExplorer.IVsExtensionsTreeNode rootNode) { }
        public void UpdateAll() { }
    }
    public class UpdatesExtensionsTreeNode : JetBrains.Application.Extensions.UI.VsExtensionsTreeNodeBase
    {
        public UpdatesExtensionsTreeNode(JetBrains.Application.Extensions.UI.ExtensionsProviderBase provider, Microsoft.VisualStudio.ExtensionsExplorer.IVsExtensionsTreeNode parent, JetBrains.Application.Extensions.IExtensionCatalog catalog, JetBrains.Application.Extensions.ExtensionManager extensionManager) { }
        public UpdatesExtensionsTreeNode(JetBrains.Application.Extensions.UI.ExtensionsProviderBase provider, Microsoft.VisualStudio.ExtensionsExplorer.IVsExtensionsTreeNode parent, string name, JetBrains.Application.Extensions.IExtensionCatalog catalog, JetBrains.Application.Extensions.ExtensionManager extensionManager) { }
        protected override System.Collections.Generic.IEnumerable<JetBrains.Application.Extensions.SortOrder> SupportedSortOrders { get; }
        public void ClearQueryCache() { }
        public bool Update(JetBrains.Application.Extensions.UI.IExtensionItemViewModel extension, JetBrains.Application.Extensions.IExtensionCatalogActionEvents events) { }
        public bool UpdateAll(JetBrains.Application.Extensions.IExtensionCatalogActionEvents events) { }
    }
    public class static VSExtensionsExplorerCtlEx
    {
        public static System.Tuple<JetBrains.Application.Extensions.UI.RestartRequiredBar, JetBrains.Application.Extensions.UI.UpdateAllExtensionsBar> FutzWithTemplates(this Microsoft.VisualStudio.ExtensionsExplorer.UI.VSExtensionsExplorerCtl extensionsExplorer, JetBrains.Application.Extensions.UI.ExtensionManagerWindow extensionManagerWindow, JetBrains.DataFlow.IProperty<bool> includePrerelease, JetBrains.Application.Extensions.ExtensionRepositoryManager extensionRepositoryManager, JetBrains.Application.Env.Components.IApplicationRestart applicationRestart) { }
        public static void ShowPrereleaseComboBox(this Microsoft.VisualStudio.ExtensionsExplorer.UI.VSExtensionsExplorerCtl extensionsExplorer, bool show) { }
    }
    public abstract class VsExtensionsTreeNodeBase : JetBrains.Application.Extensions.UI.IPageDataLoadingCallback, Microsoft.VisualStudio.ExtensionsExplorer.IVsExtensionsTreeNode, Microsoft.VisualStudio.ExtensionsExplorer.IVsMessagePaneConsumer, Microsoft.VisualStudio.ExtensionsExplorer.IVsPageDataSource, Microsoft.VisualStudio.ExtensionsExplorer.IVsProgressPaneConsumer, Microsoft.VisualStudio.ExtensionsExplorer.IVsSortDataSource, System.ComponentModel.INotifyPropertyChanged
    {
        protected VsExtensionsTreeNodeBase(JetBrains.Application.Extensions.UI.ExtensionsProviderBase provider, Microsoft.VisualStudio.ExtensionsExplorer.IVsExtensionsTreeNode parent, string name, JetBrains.Application.Extensions.UI.IExtensionQueryProvider queryProvider) { }
        public int CurrentPage { get; }
        public System.Collections.IList Extensions { get; }
        public bool IsExpanded { get; set; }
        public bool IsSearchResultsNode { get; set; }
        public bool IsSelected { get; set; }
        public string Name { get; }
        public System.Collections.Generic.IList<Microsoft.VisualStudio.ExtensionsExplorer.IVsExtensionsTreeNode> Nodes { get; set; }
        public Microsoft.VisualStudio.ExtensionsExplorer.IVsExtensionsTreeNode Parent { get; }
        public JetBrains.Application.Extensions.UI.IExtensionQueryProvider QueryProvider { get; }
        protected abstract System.Collections.Generic.IEnumerable<JetBrains.Application.Extensions.SortOrder> SupportedSortOrders { get; }
        public int TotalCount { get; }
        public int TotalPages { get; }
        public event System.EventHandler<System.EventArgs> PageDataChanged;
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        public System.Collections.Generic.IList<Microsoft.VisualStudio.ExtensionsExplorer.IVsSortDescriptor> GetSortDescriptors() { }
        public void LoadingCancelled() { }
        public void LoadingCompleted() { }
        public void LoadingFailed(System.Exception exception) { }
        public void LoadingStarted(System.Action onCancel) { }
        public void LoadPage(int pageNumber) { }
        public virtual void OnClosed() { }
        public virtual void OnOpened() { }
        protected virtual void OnPageDataChanged() { }
        [JetBrains.Annotations.NotifyPropertyChangedInvocatorAttribute()]
        protected virtual void OnPropertyChanged(string propertyName) { }
        public void Reload() { }
        public void SetMessagePane(Microsoft.VisualStudio.ExtensionsExplorer.IVsMessagePane messagePane) { }
        public void SetProgressPane(Microsoft.VisualStudio.ExtensionsExplorer.IVsProgressPane progressPane) { }
        protected void SetSearchTerm(string searchTerm) { }
        public bool SortSelectionChanged(Microsoft.VisualStudio.ExtensionsExplorer.IVsSortDescriptor selectedDescriptor) { }
    }
}
namespace JetBrains.VsIntegration.JustVs12.Hacks
{
    
    [JetBrains.Application.ShellComponentAttribute()]
    public class SuppressOwnerlessFloatingWindowsJustVs12 : JetBrains.VsIntegration.SinceVs11.Hacks.SuppressOwnerlessFloatingWindowsSinceVs11
    {
        public SuppressOwnerlessFloatingWindowsJustVs12(JetBrains.DataFlow.Lifetime lifetime, JetBrains.VsIntegration.Settings.VsToolsOptionsMonitor vsToolsOptionsMonitor, JetBrains.Application.Settings.ISettingsStore settingsStore) { }
    }
}
namespace JetBrains.VsIntegration.JustVs12.Interop
{
    
    [JetBrains.VsIntegration.Application.WrapVsInterfacesAttribute()]
    public class ExposeJustVs12Services : JetBrains.VsIntegration.Application.IExposeVsServices { }
}
namespace JetBrains.VsIntegration.JustVs12.ProjectModel
{
    
    public class VCProjectEngine12 : JetBrains.VsIntegration.VX.ProjectModel.VCProjectEngineMirror
    {
        protected override JetBrains.ProjectModel.ProjectOutputType GetOutputType(Microsoft.VisualStudio.VCProjectEngine.VCConfiguration vcConfiguration, JetBrains.Util.FileSystemPath primaryOutputPath) { }
    }
    [JetBrains.ProjectModel.Properties.ProjectModelExtensionAttribute()]
    public class VcxProjectPropertiesBuilder12 : JetBrains.VsIntegration.ProjectModel.ProjectProperties.VcxProjectPropertiesBuilder
    {
        public VcxProjectPropertiesBuilder12(JetBrains.VsIntegration.ProjectModel.ProjectProperties.ProjectActiveConfigurationAccessor activeConfigurationAccessor) { }
        protected override void ProcessVCProject(EnvDTE.Project project, JetBrains.ProjectModel.Properties.VCXProj.VCXBuildSettings vcxBuildSettings, EnvDTE.Configuration configuration, JetBrains.ProjectModel.Properties.VCXProj.VCXProjectConfiguration vcxProjectConfiguration) { }
    }
}
namespace JetBrains.VsIntegration.JustVs12.TabStrip
{
    
    [JetBrains.Application.ShellComponentAttribute()]
    public class TabbedToolWindowOptionsJustVs12 : JetBrains.UI.ToolWindowManagement.TabbedToolWindowOptions
    {
        public TabbedToolWindowOptionsJustVs12(JetBrains.DataFlow.Lifetime lifetime) { }
    }
}
namespace JetBrains.VsIntegration.JustVs12.TextControl
{
    
    [JetBrains.Application.ShellComponentAttribute()]
    public class VsTextControlDevTenIncrementalSearchClientJustVs12 : JetBrains.VsIntegration.SinceVs11.TextControl.VsTextControlDevTenIncrementalSearchClientSinceVs11
    {
        public VsTextControlDevTenIncrementalSearchClientJustVs12([JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.Lazy.Lazy<Microsoft.VisualStudio.Text.IncrementalSearch.IIncrementalSearchFactoryService> incrementalSearchFactoryService, [JetBrains.Annotations.NotNullAttribute()] Microsoft.VisualStudio.Editor.Implementation.IVsFindManagerHelper vsFindManagerHelper) { }
        protected override Microsoft.VisualStudio.Shell.Interop.IVsUIDataSource GetDataSourceFromFindManager() { }
    }
}
namespace JetBrains.VsIntegration.VX.ProjectModel.Transactions
{
    
    public class static VcxActionUtil
    {
        public static void Commit(JetBrains.Application.IShellLocks locks, JetBrains.Util.Concurrency.UnguardedCallbackMerger unguardedCallbackMerger, JetBrains.VsIntegration.DocumentModel.VsDocumentManagerSynchronization vsDocumentManagerSynchronization, System.Action action) { }
        public static System.Collections.Generic.IList<Microsoft.VisualStudio.VCProjectEngine.VCFile> GetFileOrAllFilesInFolder(Microsoft.VisualStudio.VCProjectEngine.VCProject vcProject, JetBrains.ProjectModel.IProjectItem projectItem) { }
        public static void RefreshProjectInSolutionExplorer(JetBrains.Application.IShellLocks locks, JetBrains.ProjectModel.ISolutionExplorer solutionExplorer, JetBrains.ProjectModel.IProjectItem projectItem) { }
    }
    public class VcxAddFileAction : JetBrains.ProjectModel.Transaction.Actions.AddFileAction
    {
        public VcxAddFileAction(JetBrains.ProjectModel.IProjectFolder parentFolder, JetBrains.Util.FileSystemPath location, Microsoft.VisualStudio.VCProjectEngine.VCProject vcProject, JetBrains.Application.IShellLocks locks, JetBrains.Util.Concurrency.UnguardedCallbackMerger unguardedCallbacks, JetBrains.VsIntegration.DocumentModel.VsDocumentManagerSynchronization vsDocumentManagerSynchronization, JetBrains.DocumentManagers.impl.DocumentManagerOperations documentOperations, JetBrains.ProjectModel.ISolutionExplorer solutionExplorer) { }
        public override void Commit() { }
    }
    public class VcxAddFolderAction : JetBrains.ProjectModel.Model2.Transaction.Actions.AddFolderAction
    {
        public VcxAddFolderAction(JetBrains.ProjectModel.IProjectFolder parentFolder, string name, JetBrains.Util.FileSystemPath folderPath, Microsoft.VisualStudio.VCProjectEngine.VCProject vcProject, JetBrains.Application.IShellLocks locks, JetBrains.Util.Concurrency.UnguardedCallbackMerger unguardedCallbacks, JetBrains.VsIntegration.DocumentModel.VsDocumentManagerSynchronization vsDocumentManagerSynchronization, JetBrains.ProjectModel.ISolutionExplorer solutionExplorer) { }
        public override void Commit() { }
    }
    public class VcxCopyAction : JetBrains.ProjectModel.Model2.Transaction.Actions.CopyAction
    {
        public VcxCopyAction(JetBrains.ProjectModel.IProjectItem projectItem, JetBrains.ProjectModel.IProjectFolder newParentItem, Microsoft.VisualStudio.VCProjectEngine.VCProject vcProject, JetBrains.Application.IShellLocks locks, JetBrains.Util.Concurrency.UnguardedCallbackMerger unguardedCallbacks, JetBrains.VsIntegration.DocumentModel.VsDocumentManagerSynchronization vsDocumentManagerSynchronization, JetBrains.DocumentManagers.DocumentManager documentManager, JetBrains.DocumentManagers.impl.DocumentManagerOperations documentOperations, JetBrains.ProjectModel.ISolutionExplorer solutionExplorer) { }
        public override void Commit() { }
        protected override void CopyDocument(JetBrains.ProjectModel.IProjectFile oldProjectFile, JetBrains.ProjectModel.IProjectFile newProjectFile) { }
    }
    [JetBrains.ProjectModel.Properties.SolutionProjectModelExtensionAttribute()]
    public class VcxFilesAndFoldersEditor : JetBrains.VsIntegration.ProjectModel.Transactions.DefaultVsFilesAndFoldersEditor
    {
        public VcxFilesAndFoldersEditor(JetBrains.DocumentManagers.DocumentManager documentManager, JetBrains.DocumentManagers.impl.DocumentManagerOperations documentOperations, JetBrains.VsIntegration.ProjectModel.VSSolutionExplorer solutionExplorer, JetBrains.VsIntegration.DocumentModel.VsDocumentManagerSynchronization vsDocumentManagerSynchronization, JetBrains.Application.IShellLocks locks, JetBrains.VsIntegration.ProjectModel.ProjectModelSynchronizer projectModelSynchronizer, JetBrains.VsIntegration.ProjectModel.VsSolutionWrapper vsSolutionWrapper = null) { }
        public override JetBrains.ProjectModel.Transaction.Actions.AddFileAction CreateAddFileAction(JetBrains.ProjectModel.IProjectFolder parentFolder, JetBrains.Util.FileSystemPath location) { }
        public override JetBrains.ProjectModel.Model2.Transaction.Actions.AddFolderAction CreateAddFolderAction(JetBrains.ProjectModel.IProjectFolder parentFolder, string name, JetBrains.Util.FileSystemPath folderPath) { }
        public override JetBrains.ProjectModel.Model2.Transaction.Actions.CopyAction CreateCopyAction(JetBrains.ProjectModel.IProjectItem projectItem, JetBrains.ProjectModel.IProjectFolder newParentItem) { }
        public override JetBrains.ProjectModel.Model2.Transaction.Actions.MoveAction CreateMoveAction(JetBrains.ProjectModel.IProjectItem projectItem, JetBrains.ProjectModel.IProjectFolder newParentItem) { }
        public override JetBrains.ProjectModel.Model2.Transaction.Actions.RemoveAction CreateRemoveAction(JetBrains.ProjectModel.IProjectItem projectItem) { }
        public override JetBrains.ProjectModel.Model2.Transaction.Actions.RenameAction CreateRenameAction(JetBrains.ProjectModel.IProjectItem projectItem, string newName) { }
        public override bool IsApplicable(JetBrains.ProjectModel.Properties.IProjectProperties projectProperties) { }
    }
    public class VcxRemoveAction : JetBrains.ProjectModel.Model2.Transaction.Actions.RemoveAction
    {
        public VcxRemoveAction(JetBrains.ProjectModel.IProjectItem projectItem, Microsoft.VisualStudio.VCProjectEngine.VCProject vcProject, JetBrains.Application.IShellLocks locks, JetBrains.Util.Concurrency.UnguardedCallbackMerger unguardedCallbacks, JetBrains.VsIntegration.DocumentModel.VsDocumentManagerSynchronization vsDocumentManagerSynchronization, JetBrains.ProjectModel.ISolutionExplorer solutionExplorer) { }
        public override void Commit() { }
    }
    public class VcxRenameAction : JetBrains.ProjectModel.Model2.Transaction.Actions.RenameAction
    {
        public VcxRenameAction(JetBrains.ProjectModel.IProjectItem projectItem, string newName, Microsoft.VisualStudio.VCProjectEngine.VCProject vcProject, JetBrains.Application.IShellLocks locks, JetBrains.Util.Concurrency.UnguardedCallbackMerger unguardedCallbacks, JetBrains.VsIntegration.DocumentModel.VsDocumentManagerSynchronization vsDocumentManagerSynchronization, JetBrains.ProjectModel.ISolutionExplorer solutionExplorer) { }
        public override void Commit() { }
    }
}
namespace JetBrains.VsIntegration.VX.ProjectModel
{
    
    public class VCProjectEngineMirror
    {
        protected void CheckForExceptions([JetBrains.Annotations.InstantHandleAttribute()] System.Action getPropertyValue, ref bool result) { }
        protected virtual void FetchConfigurationProperties(JetBrains.ProjectModel.Properties.VCXProj.VCXProjectConfiguration vcxProjectConfiguration, Microsoft.VisualStudio.VCProjectEngine.VCConfiguration vcConfiguration, string configurationName, JetBrains.ProjectModel.Properties.VCXProj.VCXBuildSettings vcxBuildSettings, Microsoft.VisualStudio.VCProjectEngine.VCProjectEngine vcProjectEngine, Microsoft.VisualStudio.VCProjectEngine.VCProject vcProject, ref bool result) { }
        protected virtual JetBrains.ProjectModel.ProjectOutputType GetOutputType(Microsoft.VisualStudio.VCProjectEngine.VCConfiguration vcConfiguration, JetBrains.Util.FileSystemPath primaryOutputPath) { }
        protected virtual void ProcessCompilerToolProperties(Microsoft.VisualStudio.VCProjectEngine.VCCLCompilerTool compilerTool, JetBrains.ProjectModel.Properties.VCXProj.VCXProjectConfiguration vcxProjectConfiguration) { }
        public void ProcessVCProject(EnvDTE.Project project, JetBrains.ProjectModel.Properties.VCXProj.VCXBuildSettings vcxBuildSettings, EnvDTE.Configuration activeConfiguration, JetBrains.ProjectModel.Properties.VCXProj.VCXProjectConfiguration vcxProjectConfiguration) { }
    }
    [JetBrains.ProjectModel.Properties.ProjectModelExtensionAttribute()]
    public class VcxProjectContentBuilderMirror : JetBrains.VsIntegration.ProjectModel.ProjectContent.VSDefaultProjectContentBuilder
    {
        public VcxProjectContentBuilderMirror(JetBrains.ProjectModel.ProjectFileExtensions projectFileExtensions) { }
        public override void CreateMissingItems(JetBrains.VsIntegration.ProjectModel.VsHierarchyItem hitem, JetBrains.ProjectModel.Update.IProjectDescriptor projectDescriptor, JetBrains.VsIntegration.ProjectModel.IVSProjectFilePropertiesBuilder projectFilePropertiesBuilder, JetBrains.ProjectModel.Properties.IProjectFilePropertiesProvider filePropertiesProvider, JetBrains.VsIntegration.ProjectModel.ProjectModelStatistics statistics, JetBrains.Util.FileSystemPath solutionCacheFolder, System.Collections.Generic.JetHashSet<JetBrains.VsIntegration.ProjectModel.VsHierarchyItem> modifiedFiles) { }
        public override void FillProjectDescriptor(JetBrains.VsIntegration.ProjectModel.VsHierarchyItem rootItem, JetBrains.ProjectModel.Update.IProjectDescriptor projectDescriptor, JetBrains.VsIntegration.ProjectModel.IVSProjectFilePropertiesBuilder projectFilePropertiesBuilder, JetBrains.ProjectModel.Properties.IProjectFilePropertiesProvider filePropertiesProvider, JetBrains.VsIntegration.ProjectModel.ProjectModelStatistics statistics, JetBrains.Util.FileSystemPath solutionCacheFolder, System.Collections.Generic.JetHashSet<JetBrains.VsIntegration.ProjectModel.VsHierarchyItem> modifiedFiles) { }
        public override bool IsApplicable(JetBrains.ProjectModel.Properties.IProjectProperties projectProperties) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class VcxProjectEventHandler
    {
        public VcxProjectEventHandler(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.impl.ViewableProjectsCollection projectsCollection, JetBrains.VsIntegration.ProjectModel.ProjectModelSynchronizer pms, JetBrains.ProjectModel.Tasks.ISolutionLoadTasksScheduler solutionLoadTasksScheduler, JetBrains.Application.IShellLocks locks, JetBrains.ProjectModel.ISolution solution) { }
    }
}