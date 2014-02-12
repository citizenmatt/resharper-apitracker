[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]

namespace JetBrains.Symbols
{
    
    [JetBrains.Application.ShellComponentAttribute()]
    public class DefaultPdbCmdExecutionConfirmation : JetBrains.Symbols.IPdbCmdExecutionConfirmation
    {
        public DefaultPdbCmdExecutionConfirmation([JetBrains.Annotations.NotNullAttribute()] JetBrains.Threading.IThreading mainThread) { }
        public virtual bool RequestCommandExecutionConfirmation(string command, string args) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class DefaultPdbSpecificLogger : JetBrains.Symbols.IPdbSpecificLogger
    {
        public virtual void LogFailure(string format, params object[] args) { }
        public virtual void LogInformation(string format, params object[] args) { }
    }
    public interface IPdbCmdExecutionConfirmation
    {
        bool RequestCommandExecutionConfirmation(string command, string args);
    }
    public interface IPdbSpecificLogger
    {
        [JetBrains.Annotations.StringFormatMethodAttribute("format")]
        void LogFailure(string format, params object[] args);
        [JetBrains.Annotations.StringFormatMethodAttribute("format")]
        void LogInformation(string format, params object[] args);
    }
    public interface ISourcesDownloader
    {
        JetBrains.Symbols.SourceDownloadResult Download(JetBrains.Metadata.Utils.Pdb.SrcSrv.SourceLocation sourceLocation, JetBrains.Util.FileSystemPath cacheDirectory, JetBrains.Application.Progress.IProgressIndicator progressIndicator);
    }
    public interface ISymbolsDownloader
    {
        JetBrains.Symbols.SymbolsDownloadResult Download(JetBrains.Symbols.Providers.IDebugAssemblyInfo assemblyInfo, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Symbols.SymbolsSource symbolsSource, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Progress.IProgressIndicator progressIndicator);
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class PdbFallbackService
    {
        public PdbFallbackService() { }
        public bool Disabled { get; set; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.Symbols.Providers.IDebugAssemblyInfo GetFallbackPdbSignature(JetBrains.Symbols.Providers.IDebugAssemblyInfo assemblyInfo) { }
    }
    public enum SourceDownloadResult
    {
        Ok = 0,
        NotFound = 1,
        Cancelled = 2,
        Error = 3,
    }
    public abstract class SourcesCache
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public abstract JetBrains.DataFlow.IProperty<JetBrains.DataStructures.ImmutableArray<JetBrains.Util.FileSystemPath>> CacheDirectories { get; }
        public abstract JetBrains.Util.FileSystemPath PrimaryCacheDir { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public abstract JetBrains.Util.FileSystemPath Locate([JetBrains.Annotations.NotNullAttribute()] JetBrains.Metadata.Utils.Pdb.SrcSrv.SourceLocation sourceLocation);
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class SourcesCacheImpl : JetBrains.Symbols.SourcesCache, JetBrains.Application.IExternalSourcesDebugInfoProvider
    {
        public SourcesCacheImpl() { }
        public override JetBrains.DataFlow.IProperty<JetBrains.DataStructures.ImmutableArray<JetBrains.Util.FileSystemPath>> CacheDirectories { get; }
        public override JetBrains.Util.FileSystemPath PrimaryCacheDir { get; }
        public override JetBrains.Util.FileSystemPath Locate(JetBrains.Metadata.Utils.Pdb.SrcSrv.SourceLocation sourceLocation) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class SourcesDownloaderImpl : JetBrains.Symbols.ISourcesDownloader
    {
        public SourcesDownloaderImpl(JetBrains.Symbols.IPdbCmdExecutionConfirmation cmdExecutionConfirmation, JetBrains.Symbols.IPdbSpecificLogger pdbSpecificLogger, JetBrains.Symbols.Downloader.IDownloadService downloadService) { }
        public virtual JetBrains.Symbols.SourceDownloadResult Download(JetBrains.Metadata.Utils.Pdb.SrcSrv.SourceLocation sourceLocation, JetBrains.Util.FileSystemPath cacheDirectory, JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class SymbolsDownloaderCached : JetBrains.Symbols.SymbolsDownloaderSimple, JetBrains.Application.IExternalSourcesDebugInfoProvider
    {
        public SymbolsDownloaderCached(JetBrains.Symbols.IPdbSpecificLogger pdbSpecificLogger, JetBrains.Symbols.Downloader.IDownloadService downloadService) { }
        public override JetBrains.Symbols.SymbolsDownloadResult Download(JetBrains.Symbols.Providers.IDebugAssemblyInfo assemblyInfo, JetBrains.Symbols.SymbolsSource symbolsSource, JetBrains.Application.Progress.IProgressIndicator indicator) { }
    }
    public class SymbolsDownloaderSimple : JetBrains.Symbols.ISymbolsDownloader
    {
        public SymbolsDownloaderSimple(JetBrains.Symbols.IPdbSpecificLogger pdbSpecificLogger, JetBrains.Symbols.Downloader.IDownloadService downloadService) { }
        public virtual JetBrains.Symbols.SymbolsDownloadResult Download(JetBrains.Symbols.Providers.IDebugAssemblyInfo assemblyInfo, JetBrains.Symbols.SymbolsSource symbolsSource, JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
    }
    public enum SymbolsDownloadResult
    {
        Ok = 0,
        NotFound = 1,
        Cancelled = 2,
        Error = 3,
    }
    public class SymbolsSource : System.IEquatable<JetBrains.Symbols.SymbolsSource>
    {
        public SymbolsSource([JetBrains.Annotations.CanBeNullAttribute()] string url, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath cacheDirectory) { }
        public SymbolsSource([JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath cacheDirectory) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.Util.FileSystemPath CacheDirectory { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public string Url { get; }
        public bool Equals(JetBrains.Symbols.SymbolsSource other) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
        public static JetBrains.Symbols.SymbolsSource ParseAsteriskCoded(string str, JetBrains.Util.FileSystemPath defaultCacheDir) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.Symbols.SymbolsSource[] ParsePathString([JetBrains.Annotations.CanBeNullAttribute()] string path, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath primaryDir) { }
        public override string ToString() { }
    }
}
namespace JetBrains.Symbols.Downloader
{
    
    [JetBrains.Application.ShellComponentAttribute()]
    public class DownloaderCookiesStorage
    {
        public DownloaderCookiesStorage(JetBrains.Application.Env.Components.ProductSettingsLocation settingsLocation) { }
        public void AddCookies(System.Collections.Generic.IEnumerable<System.Net.Cookie> newCookies) { }
        public void InitializeCookieContainer(System.Net.CookieContainer container) { }
        protected virtual void LoadCookies(JetBrains.Util.FileSystemPath path) { }
        protected virtual void SaveCookies() { }
    }
    public class DownloadResult
    {
        public DownloadResult(System.Net.WebHeaderCollection headers, JetBrains.Util.FileSystemPath dataFile, System.Net.CookieCollection cookies, System.Nullable<System.Net.HttpStatusCode> httpCode, string errorDescription) { }
        public System.Net.CookieCollection Cookies { get; }
        public JetBrains.Util.FileSystemPath DataFile { get; }
        public string ErrorDescription { get; }
        public System.Net.WebHeaderCollection Headers { get; }
        public System.Nullable<System.Net.HttpStatusCode> HttpCode { get; }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class DownloadServiceImpl : JetBrains.Symbols.Downloader.IDownloadService
    {
        public DownloadServiceImpl(JetBrains.Symbols.Downloader.DownloaderCookiesStorage downloaderCookiesStorage, JetBrains.Symbols.IPdbSpecificLogger pdbSpecificLogger, JetBrains.Application.Communication.WebProxySettingsReader proxySettings, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.UI.Application.IMainWindow mainwin, JetBrains.Threading.IThreading mainThread) { }
        public virtual JetBrains.Symbols.Downloader.DownloadStatus DownloadFile(System.Uri uri, JetBrains.Util.FileSystemPath local, string taskName, JetBrains.Application.Progress.IProgressIndicator indicator) { }
    }
    public struct DownloadStatus
    {
        public DownloadStatus(JetBrains.Symbols.Downloader.DownloadStatusResult result, System.Nullable<System.Net.HttpStatusCode> httpCode) { }
        public DownloadStatus(JetBrains.Symbols.Downloader.DownloadStatusResult result) { }
        public bool Cancelled { get; }
        public System.Nullable<System.Net.HttpStatusCode> HttpStatusCode { get; }
        public JetBrains.Symbols.Downloader.DownloadStatusResult Result { get; }
        public bool Succeded { get; }
    }
    public enum DownloadStatusResult
    {
        OK = 0,
        CANCELLED = 1,
        ERROR = 2,
    }
    public class EulaContent
    {
        public EulaContent(string eulaBodyToBeParsed) { }
        public string AcceptButtonText { get; }
        public string AcceptKey { get; }
        public string DeclineButtonText { get; }
        public string DeclineKey { get; }
        public string DialogTitle { get; }
        public string EulaText { get; }
        public string FullEulaBody { get; }
    }
    public class EulaDialog : JetBrains.UI.CommonControls.Controls.FormOwnedByMainWindow
    {
        protected override void Dispose(bool disposing) { }
        public static bool Show(JetBrains.Symbols.Downloader.EulaContent content, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.UI.Application.IMainWindow mainwin) { }
    }
    public interface IDownloadService
    {
        JetBrains.Symbols.Downloader.DownloadStatus DownloadFile(System.Uri uri, JetBrains.Util.FileSystemPath local, string taskName, JetBrains.Application.Progress.IProgressIndicator indicator);
    }
}
namespace JetBrains.Symbols.Providers
{
    
    [JetBrains.Application.ShellComponentAttribute()]
    public class AppSpecificSymbolsProvider : JetBrains.Symbols.Providers.ISourceSymbolsProvider, JetBrains.Symbols.Providers.ISymbolsProvider
    {
        public AppSpecificSymbolsProvider(JetBrains.Symbols.SymbolsCache.AppSpecificSymbolsCache symbolsCache, JetBrains.Symbols.ISymbolsDownloader symbolsDownloader) { }
        public int Priority { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.Symbols.SymbolsSource> SymbolsSources { get; }
        public bool DownloadPdbFile(JetBrains.Symbols.Providers.IDebugAssemblyInfo assemblyInfo, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public System.Collections.Generic.ICollection<JetBrains.Util.FileSystemPath> GetPdbFiles(JetBrains.Symbols.Providers.IDebugAssemblyInfo assemblyInfo) { }
    }
    public class DebugAssemblyInfo : JetBrains.Symbols.Providers.IDebugAssemblyInfo
    {
        public DebugAssemblyInfo(JetBrains.Util.FileSystemPath assemblyFile, string pdbSignature) { }
        public JetBrains.Util.FileSystemPath AssemblyFile { get; }
        public string PdbSignature { get; }
    }
    public class static DebugAssemblyInfoHelper
    {
        public static JetBrains.Symbols.Providers.IDebugAssemblyInfo GetDebugAssemblyInfo(this JetBrains.Util.FileSystemPath assembly) { }
        public static bool HasSignature(this JetBrains.Symbols.Providers.IDebugAssemblyInfo assemblyInfo) { }
    }
    public abstract class FallbackSourceSymbolProvider : JetBrains.Symbols.Providers.SmartSymbolProvider
    {
        protected FallbackSourceSymbolProvider(JetBrains.Symbols.ISymbolsDownloader symbolDownloader, JetBrains.Symbols.PdbFallbackService pdbFallbackService) { }
        public override bool DownloadPdbFile(JetBrains.Symbols.Providers.IDebugAssemblyInfo assemblyInfo, JetBrains.Application.Progress.IProgressIndicator progress) { }
    }
    public interface IDebugAssemblyInfo
    {
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.Util.FileSystemPath AssemblyFile { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        string PdbSignature { get; }
    }
    public interface ISourceSymbolsProvider : JetBrains.Symbols.Providers.ISymbolsProvider
    {
        System.Collections.Generic.IEnumerable<JetBrains.Symbols.SymbolsSource> SymbolsSources { get; }
    }
    public interface ISymbolsProvider
    {
        int Priority { get; }
        bool DownloadPdbFile([JetBrains.Annotations.NotNullAttribute()] JetBrains.Symbols.Providers.IDebugAssemblyInfo assemblyInfo, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Progress.IProgressIndicator progress);
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.ICollection<JetBrains.Util.FileSystemPath> GetPdbFiles([JetBrains.Annotations.NotNullAttribute()] JetBrains.Symbols.Providers.IDebugAssemblyInfo assemblyInfo);
    }
    public interface ISymbolsProvidersManager
    {
        System.Collections.Generic.IEnumerable<JetBrains.Symbols.Providers.ISymbolsProvider> OrderedProviders { get; }
        bool DownloadPdbFile(JetBrains.Symbols.Providers.IDebugAssemblyInfo assemblyInfo, JetBrains.Application.Progress.IProgressIndicator progress);
        JetBrains.Symbols.Providers.PdbPathInfo[] GetPdbFilesInfo(JetBrains.Symbols.Providers.IDebugAssemblyInfo assemblyInfo);
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class NextToDllSymbolsProvider : JetBrains.Symbols.Providers.ISymbolsProvider
    {
        public int Priority { get; }
        public bool DownloadPdbFile(JetBrains.Symbols.Providers.IDebugAssemblyInfo assemblyInfo, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public System.Collections.Generic.ICollection<JetBrains.Util.FileSystemPath> GetPdbFiles(JetBrains.Symbols.Providers.IDebugAssemblyInfo assemblyInfo) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class NtSymbolPathSymbolsProvider : JetBrains.Symbols.Providers.ISourceSymbolsProvider, JetBrains.Symbols.Providers.ISymbolsProvider
    {
        public NtSymbolPathSymbolsProvider(JetBrains.Symbols.SymbolsCache.NtSymbolPathSymbolsCache symbolsCache, JetBrains.Symbols.ISymbolsDownloader symbolsDownloader) { }
        public int Priority { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.Symbols.SymbolsSource> SymbolsSources { get; }
        public bool DownloadPdbFile(JetBrains.Symbols.Providers.IDebugAssemblyInfo assemblyInfo, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public System.Collections.Generic.ICollection<JetBrains.Util.FileSystemPath> GetPdbFiles(JetBrains.Symbols.Providers.IDebugAssemblyInfo assemblyInfo) { }
    }
    public class PdbPathInfo
    {
        public PdbPathInfo([JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath path, JetBrains.Symbols.Providers.ISymbolsProvider symbolsProvider) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.Util.FileSystemPath Path { get; }
        public JetBrains.Symbols.Providers.ISymbolsProvider SymbolsProvider { get; }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class ReferenceSourceSymbolsProvider : JetBrains.Symbols.Providers.FallbackSourceSymbolProvider
    {
        public ReferenceSourceSymbolsProvider(JetBrains.Symbols.SymbolsCache.ReferenceSourceSymbolsCache referenceSourceSymbolsCache, JetBrains.Symbols.PdbFallbackService pdbFallbackService, JetBrains.Symbols.ISymbolsDownloader symbolsDownloader) { }
        protected override JetBrains.Util.FileSystemPath CacheDirectory { get; }
        protected override string ServerUrl { get; }
        public override System.Collections.Generic.ICollection<JetBrains.Util.FileSystemPath> GetPdbFiles(JetBrains.Symbols.Providers.IDebugAssemblyInfo assemblyInfo) { }
        protected override bool IsApplicable(JetBrains.Symbols.Providers.IDebugAssemblyInfo assemblyInfo) { }
    }
    public abstract class SmartSymbolProvider : JetBrains.Symbols.Providers.ISourceSymbolsProvider, JetBrains.Symbols.Providers.ISymbolsProvider
    {
        protected SmartSymbolProvider(JetBrains.Symbols.ISymbolsDownloader symbolDownloader) { }
        protected abstract JetBrains.Util.FileSystemPath CacheDirectory { get; }
        public virtual int Priority { get; }
        protected abstract string ServerUrl { get; }
        protected JetBrains.Symbols.ISymbolsDownloader SymbolsDownloader { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.Symbols.SymbolsSource> SymbolsSources { get; }
        public abstract bool DownloadPdbFile(JetBrains.Symbols.Providers.IDebugAssemblyInfo assemblyInfo, JetBrains.Application.Progress.IProgressIndicator progress);
        public abstract System.Collections.Generic.ICollection<JetBrains.Util.FileSystemPath> GetPdbFiles(JetBrains.Symbols.Providers.IDebugAssemblyInfo assemblyInfo);
        protected abstract bool IsApplicable(JetBrains.Symbols.Providers.IDebugAssemblyInfo assemblyInfo);
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class SymbolSourceSymbolsProvider : JetBrains.Symbols.Providers.UrlSourceSymbolProvider
    {
        public SymbolSourceSymbolsProvider(JetBrains.Symbols.SymbolsCache.SymbolSourceSymbolsCache symbolSourceSymbolsCache, JetBrains.Symbols.ISymbolsDownloader symbolsDownloader) { }
        protected override JetBrains.Util.FileSystemPath CacheDirectory { get; }
        protected override string ServerUrl { get; }
        public override System.Collections.Generic.ICollection<JetBrains.Util.FileSystemPath> GetPdbFiles(JetBrains.Symbols.Providers.IDebugAssemblyInfo assemblyInfo) { }
        protected override bool IsApplicable(JetBrains.Symbols.Providers.IDebugAssemblyInfo assemblyInfo) { }
    }
    public class static SymbolsProviderHelper
    {
        public static bool DownloadPdbFile(JetBrains.Symbols.Providers.IDebugAssemblyInfo assemblyInfo, JetBrains.Application.Progress.IProgressIndicator progress, JetBrains.Symbols.ISymbolsDownloader symbolsDownloader, System.Collections.Generic.IEnumerable<JetBrains.Symbols.SymbolsSource> sources) { }
        public static bool DownloadPdbFileWithFallback(JetBrains.Symbols.Providers.IDebugAssemblyInfo assemblyInfo, JetBrains.Application.Progress.IProgressIndicator progress, JetBrains.Symbols.ISymbolsDownloader symbolsDownloader, JetBrains.Symbols.PdbFallbackService pdbFallbackService, JetBrains.Symbols.SymbolsSource symbolsSource) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class SymbolsProvidersManager : JetBrains.Symbols.Providers.ISymbolsProvidersManager
    {
        public SymbolsProvidersManager(JetBrains.DataFlow.Lifetime lifetime, JetBrains.DataFlow.IViewable<JetBrains.Symbols.Providers.ISymbolsProvider> providers) { }
        public System.Collections.Generic.IEnumerable<JetBrains.Symbols.Providers.ISymbolsProvider> OrderedProviders { get; }
        public bool DownloadPdbFile(JetBrains.Symbols.Providers.IDebugAssemblyInfo assemblyInfo, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public JetBrains.Symbols.Providers.PdbPathInfo[] GetPdbFilesInfo(JetBrains.Symbols.Providers.IDebugAssemblyInfo assemblyInfo) { }
    }
    public abstract class UrlSourceSymbolProvider : JetBrains.Symbols.Providers.SmartSymbolProvider
    {
        protected UrlSourceSymbolProvider(JetBrains.Symbols.ISymbolsDownloader symbolDownloader) { }
        public override bool DownloadPdbFile(JetBrains.Symbols.Providers.IDebugAssemblyInfo assemblyInfo, JetBrains.Application.Progress.IProgressIndicator progress) { }
    }
}
namespace JetBrains.Symbols.SymbolsCache
{
    
    [JetBrains.Application.ShellComponentAttribute()]
    public class AppSpecificSymbolsCache : JetBrains.Symbols.SymbolsCache.SymbolsCacheBase, JetBrains.Application.IExternalSourcesDebugInfoProvider
    {
        public AppSpecificSymbolsCache(JetBrains.DataFlow.Lifetime lifetime) { }
        public JetBrains.DataFlow.IProperty<JetBrains.DataStructures.ImmutableArray<JetBrains.Symbols.SymbolsSource>> SymbolsSources { get; }
        public static JetBrains.Util.FileSystemPath GetFallbackCacheLocation() { }
    }
    public interface IDirectorySymbolsCache : JetBrains.Symbols.SymbolsCache.ISymbolsCache
    {
        JetBrains.DataFlow.IProperty<JetBrains.DataStructures.ImmutableArray<JetBrains.Util.FileSystemPath>> SymbolsDirectories { get; }
    }
    public interface ISymbolsCache
    {
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.ICollection<JetBrains.Util.FileSystemPath> LocatePdbFile(JetBrains.Symbols.Providers.IDebugAssemblyInfo assemblyInfo);
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class NtSymbolPathSymbolsCache : JetBrains.Symbols.SymbolsCache.SymbolsCacheBase, JetBrains.Application.IExternalSourcesDebugInfoProvider
    {
        public NtSymbolPathSymbolsCache(JetBrains.DataFlow.Lifetime lifetime) { }
        public System.Collections.Generic.IEnumerable<JetBrains.Symbols.SymbolsSource> SymbolsSources { get; }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class PackagedReferenceSourceDetector
    {
        public virtual JetBrains.Util.FileSystemPath[] GetPaths() { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class ReferenceSourceSymbolsCache : JetBrains.Symbols.SymbolsCache.SymbolsCacheBase, JetBrains.Application.IExternalSourcesDebugInfoProvider
    {
        public ReferenceSourceSymbolsCache(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Symbols.PdbFallbackService pdbFallbackService, JetBrains.Symbols.SymbolsCache.PackagedReferenceSourceDetector packagedReferenceSourceDetector) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.Util.FileSystemPath ReferenceSourceCacheDirectory { get; }
        public override System.Collections.Generic.ICollection<JetBrains.Util.FileSystemPath> LocatePdbFile(JetBrains.Symbols.Providers.IDebugAssemblyInfo assemblyInfo) { }
    }
    public abstract class SymbolsCacheBase : JetBrains.Symbols.SymbolsCache.IDirectorySymbolsCache, JetBrains.Symbols.SymbolsCache.ISymbolsCache
    {
        protected SymbolsCacheBase(JetBrains.DataFlow.Lifetime lifetime) { }
        public JetBrains.DataFlow.IProperty<JetBrains.DataStructures.ImmutableArray<JetBrains.Util.FileSystemPath>> SymbolsDirectories { get; }
        public virtual System.Collections.Generic.ICollection<JetBrains.Util.FileSystemPath> LocatePdbFile(JetBrains.Symbols.Providers.IDebugAssemblyInfo assemblyInfo) { }
        protected System.Collections.Generic.ICollection<JetBrains.Util.FileSystemPath> SearchPdbInSymbolsSources(string pdbName, string pdbSignature) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class SymbolSourceSymbolsCache : JetBrains.Symbols.SymbolsCache.SymbolsCacheBase, JetBrains.Application.IExternalSourcesDebugInfoProvider
    {
        public SymbolSourceSymbolsCache(JetBrains.DataFlow.Lifetime lifetime) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.Util.FileSystemPath SymbolSourceCacheDirectory { get; }
    }
}
namespace JetBrains.Symbols.Utils
{
    
    public class CmdExeProcessRunner
    {
        public CmdExeProcessRunner(JetBrains.DataFlow.Lifetime lifetime, string command) { }
        public int ExitCode { get; }
        public System.TimeSpan MaxExecutionTime { get; set; }
        public bool Timeout { get; }
        public string WorkingDirectory { get; set; }
        public event JetBrains.Symbols.Utils.CmdExeProcessRunner.DataHandler OnStdErrData;
        public event JetBrains.Symbols.Utils.CmdExeProcessRunner.DataHandler OnStdOutData;
        public void Run() { }
        public delegate void DataHandler(byte[] buf, int offset, int bytesCount);
        public delegate void ExitHandler(JetBrains.Symbols.Utils.CmdExeProcessRunner process, int exitCode, bool byTimeout);
    }
    [System.Xml.Serialization.XmlRootAttribute("Cookies")]
    public class CookieSerializableCollection
    {
        public CookieSerializableCollection() { }
        [System.Xml.Serialization.XmlElementAttribute("Cookie")]
        public JetBrains.Symbols.Utils.SerializableCookie[] Cookies { get; set; }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.Symbols.Utils.CookieSerializableCollection Deserialize([JetBrains.Annotations.NotNullAttribute()] System.Xml.XmlReader xmlReader) { }
        public void Serialize(System.Xml.XmlWriter xmlWriter) { }
    }
    public class static PdbUtils
    {
        public static string GetPdbName(JetBrains.Util.FileSystemPath pePath) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static string GetPdbSignature(JetBrains.Util.FileSystemPath pePath) { }
    }
    public class static ReferenceSourceUtilsMetadata
    {
        public const string AssemblyCompanyAttributeFqn = "System.Reflection.AssemblyCompanyAttribute";
        public const string Microsoft = "Microsoft";
        public static bool IsRelatedToReferenceSource(JetBrains.Util.FileSystemPath assemblyFile) { }
    }
    public class SerializableCookie
    {
        public string Comment { get; set; }
        public string CommentUri { get; set; }
        public bool Discard { get; set; }
        public string Domain { get; set; }
        public bool Expired { get; set; }
        public System.DateTime Expires { get; set; }
        public bool HttpOnly { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public string Port { get; set; }
        public bool Secure { get; set; }
        public string Value { get; set; }
        public int Version { get; set; }
        public static JetBrains.Symbols.Utils.SerializableCookie FromCookie(System.Net.Cookie c) { }
        public System.Net.Cookie ToCookie() { }
    }
}