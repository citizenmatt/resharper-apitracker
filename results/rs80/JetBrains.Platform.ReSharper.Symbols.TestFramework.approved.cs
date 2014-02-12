[assembly: JetBrains.Util.TestDataPathBaseAttribute("Platform\\test\\data")]
[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]

namespace JetBrains.ReSharper.ExternalSources.Tests
{
    
    [JetBrains.Application.ShellComponentAttribute()]
    public class DownloadServiceMock : JetBrains.Symbols.Downloader.DownloadServiceImpl
    {
        public DownloadServiceMock(JetBrains.Symbols.Downloader.DownloaderCookiesStorage downloaderCookiesStorage, JetBrains.Symbols.IPdbSpecificLogger pdbSpecificLogger, JetBrains.Application.Communication.WebProxySettingsReader proxySettings, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.UI.Application.IMainWindow mainwin, JetBrains.Threading.IThreading threading) { }
        public void AddMockedUrl(System.Uri uri, JetBrains.Symbols.Downloader.DownloadStatus result, JetBrains.Util.FileSystemPath localSubstitution) { }
        public override JetBrains.Symbols.Downloader.DownloadStatus DownloadFile(System.Uri uri, JetBrains.Util.FileSystemPath local, string taskName, JetBrains.Application.Progress.IProgressIndicator indicator) { }
    }
}
namespace JetBrains.ReSharper.ExternalSources.Tests.Pdb
{
    
    [JetBrains.Application.ShellComponentAttribute()]
    public class FakePdbCmdExecutionConfirmation : JetBrains.Symbols.DefaultPdbCmdExecutionConfirmation
    {
        public FakePdbCmdExecutionConfirmation([JetBrains.Annotations.NotNullAttribute()] JetBrains.Threading.IThreading mainThread) { }
        public override bool RequestCommandExecutionConfirmation(string command, string args) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class FakePdbSpecificLogger : JetBrains.Symbols.DefaultPdbSpecificLogger
    {
        public override void LogFailure(string format, params object[] args) { }
        public override void LogInformation(string format, params object[] args) { }
    }
}
namespace JetBrains.TestFramework.Components.Symbols
{
    
    [JetBrains.Application.ShellComponentAttribute()]
    public class TestDownloaderCookiesStorage : JetBrains.Symbols.Downloader.DownloaderCookiesStorage
    {
        public TestDownloaderCookiesStorage(JetBrains.Application.Env.Components.ProductSettingsLocation settingsLocation) { }
        protected override void LoadCookies(JetBrains.Util.FileSystemPath path) { }
        protected override void SaveCookies() { }
    }
}
namespace JetBrains.TestFramework.Symbols.src
{
    
    [JetBrains.Application.ShellComponentAttribute()]
    public class TestImplSettingsLogging : JetBrains.Application.Settings.Logging.SettingsLogging
    {
        public TestImplSettingsLogging([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.ILogger loggerSystem, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Threading.IThreading threading, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Env.RunsProducts.ProductConfigurations config) { }
        protected override JetBrains.Util.ILogger GetLoggerCore() { }
    }
}