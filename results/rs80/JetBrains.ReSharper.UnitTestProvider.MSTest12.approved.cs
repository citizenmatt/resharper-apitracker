[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]
[assembly: System.Runtime.Versioning.TargetFrameworkAttribute(".NETFramework,Version=v4.5", FrameworkDisplayName=".NET Framework 4.5")]

namespace JetBrains.ReSharper.UnitTestProvider.MSTest11
{
    
    public interface IMsTest11Runner
    {
        void Abort();
        void Cancel();
        void Run(JetBrains.ReSharper.TaskRunnerFramework.IRemoteTaskServer server, string assemblyLocation, string runConfigurationFilename, JetBrains.ReSharper.UnitTestFramework.IUnitTestRun run);
    }
    public class InProcRemoteTaskServer : JetBrains.ReSharper.TaskRunnerFramework.IRemoteTaskServer
    {
        public InProcRemoteTaskServer(JetBrains.ReSharper.UnitTestFramework.IUnitTestRun run, JetBrains.ReSharper.UnitTestFramework.IUnitTestLaunch launch) { }
        public void CreateDynamicElement(JetBrains.ReSharper.TaskRunnerFramework.RemoteTask remoteTask) { }
        public void SetTempFolderPath(string path) { }
        public void TaskDiscovered(JetBrains.ReSharper.TaskRunnerFramework.RemoteTask remoteTask) { }
        public void TaskDuration(JetBrains.ReSharper.TaskRunnerFramework.RemoteTask remoteTask, System.TimeSpan duration) { }
        public void TaskException(JetBrains.ReSharper.TaskRunnerFramework.RemoteTask remoteTask, JetBrains.ReSharper.TaskRunnerFramework.TaskException[] exceptions) { }
        public void TaskFinished(JetBrains.ReSharper.TaskRunnerFramework.RemoteTask remoteTask, string message, JetBrains.ReSharper.TaskRunnerFramework.TaskResult result) { }
        public void TaskOutput(JetBrains.ReSharper.TaskRunnerFramework.RemoteTask remoteTask, string text, JetBrains.ReSharper.TaskRunnerFramework.TaskOutputType outputType) { }
        public void TaskStarting(JetBrains.ReSharper.TaskRunnerFramework.RemoteTask remoteTask) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class MetroPackageManager
    {
        public MetroPackageManager(Microsoft.VisualStudio.Shell.Interop.IVsSolution vsSolution, JetBrains.VsIntegration.ProjectModel.ProjectModelSynchronizer pms, Microsoft.VisualStudio.Shell.Interop.IVsAppContainerProjectDeploy appContainerProjectDeploy) { }
        public void DeployAndRegister(JetBrains.ProjectModel.IProject project) { }
        public string GetFullPackageName(JetBrains.ProjectModel.IProject project) { }
    }
    public class MsTest11Debugger : JetBrains.ReSharper.UnitTestProvider.MSTest11.MsTest11Runner
    {
        public MsTest11Debugger(System.IServiceProvider serviceProvider, Microsoft.VisualStudio.TestWindow.Controller.SafeDispatcher safeDispatcher, Microsoft.VisualStudio.TestWindow.Extensibility.ILogger logger, JetBrains.ReSharper.UnitTestProvider.MSTest11.MsTestVSFacade vsFacade) { }
        protected override void DoRun(System.Collections.Generic.IEnumerable<Microsoft.VisualStudio.TestPlatform.ObjectModel.TestCase> testCases, string settings, JetBrains.ReSharper.UnitTestFramework.IUnitTestRun run) { }
    }
    public class MsTest11Runner : JetBrains.ReSharper.UnitTestProvider.MSTest11.IMsTest11Runner
    {
        protected readonly System.Collections.Generic.Dictionary<string, JetBrains.ReSharper.UnitTestRunner.MSTest.MsTestTestMethodTask> ourTests;
        protected readonly System.Collections.Generic.Dictionary<string, int> ourTestsInClassStarted;
        protected readonly JetBrains.ReSharper.UnitTestProvider.MSTest11.MsTestVSFacade ourVsFacade;
        protected Microsoft.VisualStudio.TestPlatform.ObjectModel.Client.ITestRunRequest TestRunRequest;
        public MsTest11Runner(JetBrains.ReSharper.UnitTestProvider.MSTest11.MsTestVSFacade vsFacade) { }
        public void Abort() { }
        public void Cancel() { }
        protected virtual void DoRun(System.Collections.Generic.IEnumerable<Microsoft.VisualStudio.TestPlatform.ObjectModel.TestCase> testCases, string settings, JetBrains.ReSharper.UnitTestFramework.IUnitTestRun run) { }
        protected virtual System.Collections.Generic.IEnumerable<Microsoft.VisualStudio.TestPlatform.ObjectModel.TestCase> GetTestCases(string assemblyLocation, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.UnitTestFramework.IUnitTestElement> elements) { }
        protected bool IsIgnored(JetBrains.ReSharper.UnitTestRunner.MSTest.MsTestTestMethodTask methodTask) { }
        public void Run(JetBrains.ReSharper.TaskRunnerFramework.IRemoteTaskServer server, string assemblyLocation, string runConfigurationFilename, JetBrains.ReSharper.UnitTestFramework.IUnitTestRun run) { }
        protected void testRunRequest_OnRunStatsChange(object sender, Microsoft.VisualStudio.TestPlatform.ObjectModel.Client.TestRunChangedEventArgs args) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class MsTestAttributesProvider : JetBrains.ReSharper.UnitTestProvider.MSTest.MsTestAttributesProviderBase
    {
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IClrTypeName> CategoryAttributes { get; }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IClrTypeName> IgnoreAttributes { get; }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IClrTypeName> TestClassAttributes { get; }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IClrTypeName> TestMethodAttributes { get; }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class MsTestElementFactory : JetBrains.ReSharper.UnitTestProvider.MSTest.IMsTestElementFactory
    {
        public MsTestElementFactory(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.UnitTestProvider.MSTest.IMsTestServices services, JetBrains.ReSharper.UnitTestFramework.Elements.IUnitTestElementManager unitTestElementManager, JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.ProjectModel.ISolution solution) { }
        public JetBrains.ReSharper.UnitTestProvider.MSTest.MsTestTestClassElementBase GetOrCreateClassElement(JetBrains.ReSharper.Psi.IClrTypeName id, JetBrains.ProjectModel.IProject project, JetBrains.ProjectModel.ProjectModelElementEnvoy envoy) { }
        public JetBrains.ReSharper.UnitTestProvider.MSTest.MsTestTestMethodElementBase GetOrCreateMethodElement(string id, JetBrains.ProjectModel.IProject project, JetBrains.ReSharper.UnitTestProvider.MSTest.MsTestTestClassElementBase parent, JetBrains.ProjectModel.ProjectModelElementEnvoy envoy, JetBrains.ReSharper.Psi.IClrTypeName typeName) { }
        public JetBrains.ReSharper.UnitTestProvider.MSTest.MsTestTestMethodElementBase GetOrCreateMethodElement(Microsoft.VisualStudio.TestPlatform.ObjectModel.TestCase testCase, JetBrains.ProjectModel.IProject project, JetBrains.ReSharper.UnitTestProvider.MSTest.MsTestTestClassElementBase parent, JetBrains.ProjectModel.ProjectModelElementEnvoy envoy, JetBrains.ReSharper.Psi.IClrTypeName typeName) { }
        public JetBrains.ReSharper.UnitTestProvider.MSTest.MsTestTestRowElementBase GetOrCreateRowElement(string id, JetBrains.ProjectModel.IProject project, JetBrains.ReSharper.UnitTestProvider.MSTest.MsTestTestMethodElementBase parent, JetBrains.ProjectModel.ProjectModelElementEnvoy envoy) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class MsTestElementSerializer : JetBrains.ReSharper.UnitTestFramework.IUnitTestElementSerializer
    {
        public MsTestElementSerializer(JetBrains.ReSharper.UnitTestProvider.MSTest11.MsTestProvider provider, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.UnitTestProvider.MSTest11.MsTestElementFactory factory) { }
        public JetBrains.ReSharper.UnitTestFramework.IUnitTestProvider Provider { get; }
        public JetBrains.ReSharper.UnitTestFramework.IUnitTestElement DeserializeElement(System.Xml.XmlElement parent, JetBrains.ReSharper.UnitTestFramework.IUnitTestElement parentElement) { }
        public void SerializeElement(System.Xml.XmlElement parent, JetBrains.ReSharper.UnitTestFramework.IUnitTestElement element) { }
    }
    public class MsTestMetroDebugger : JetBrains.ReSharper.UnitTestProvider.MSTest11.MsTestMetroRunner
    {
        public MsTestMetroDebugger(string packageFullName, System.IServiceProvider serviceProvider, Microsoft.VisualStudio.TestWindow.Controller.SafeDispatcher safeDispatcher, Microsoft.VisualStudio.TestWindow.Extensibility.ILogger logger, JetBrains.ReSharper.UnitTestProvider.MSTest11.MsTestVSFacade vsFacade) { }
        protected override void DoRun(System.Collections.Generic.IEnumerable<Microsoft.VisualStudio.TestPlatform.ObjectModel.TestCase> testCases, string settings, JetBrains.ReSharper.UnitTestFramework.IUnitTestRun run) { }
    }
    public class MsTestMetroRunner : JetBrains.ReSharper.UnitTestProvider.MSTest11.MsTest11Runner
    {
        protected readonly string ourPackageFullName;
        public MsTestMetroRunner(string packageFullName, JetBrains.ReSharper.UnitTestProvider.MSTest11.MsTestVSFacade vsFacade) { }
        protected override void DoRun(System.Collections.Generic.IEnumerable<Microsoft.VisualStudio.TestPlatform.ObjectModel.TestCase> testCases, string settings, JetBrains.ReSharper.UnitTestFramework.IUnitTestRun run) { }
        protected override System.Collections.Generic.IEnumerable<Microsoft.VisualStudio.TestPlatform.ObjectModel.TestCase> GetTestCases(string assemblyLocation, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.UnitTestFramework.IUnitTestElement> elements) { }
    }
    [JetBrains.ReSharper.UnitTestFramework.UnitTestProviderAttribute()]
    public class MsTestProvider : JetBrains.ReSharper.UnitTestProvider.MSTest.MsTestProviderBase
    {
        public MsTestProvider(JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.ReSharper.UnitTestProvider.MSTest.IMsTestAttributesProvider attributesProvider) { }
        public override int CompareUnitTestElements(JetBrains.ReSharper.UnitTestFramework.IUnitTestElement x, JetBrains.ReSharper.UnitTestFramework.IUnitTestElement y) { }
        public static string GetVisualStudioDirectory() { }
        public bool RunWithMsTestExe(JetBrains.ProjectModel.ISolution solution) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class MsTestServices : JetBrains.ReSharper.UnitTestProvider.MSTest.IMsTestServices
    {
        public MsTestServices(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.UnitTestProvider.MSTest11.MsTestProvider provider, JetBrains.Application.Settings.ISettingsStore store) { }
        public JetBrains.ReSharper.UnitTestFramework.IUnitTestProvider Provider { get; }
        public int VsVersionMajor { get; }
        public string GetRunConfigurationFilename(JetBrains.ReSharper.UnitTestFramework.IUnitTestLaunch launch) { }
        public JetBrains.ReSharper.UnitTestFramework.Strategy.IUnitTestRunStrategy GetRunStrategy(JetBrains.ReSharper.UnitTestFramework.IHostProvider hostProvider, JetBrains.ReSharper.UnitTestFramework.IUnitTestElement element) { }
    }
    public class MsTestTestClassElement : JetBrains.ReSharper.UnitTestProvider.MSTest.MsTestTestClassElementBase, System.IEquatable<JetBrains.ReSharper.UnitTestProvider.MSTest11.MsTestTestClassElement>
    {
        public MsTestTestClassElement(JetBrains.ReSharper.UnitTestProvider.MSTest.IMsTestServices services, JetBrains.ProjectModel.ProjectModelElementEnvoy project, JetBrains.ReSharper.Psi.IClrTypeName typeName, string assemblyLocation, JetBrains.Application.Settings.IContextBoundSettingsStore boundSettingsStore) { }
        public override string Id { get; }
        public override string Kind { get; }
        public override string ShortName { get; }
        public override bool Equals(JetBrains.ReSharper.UnitTestFramework.IUnitTestElement other) { }
        public bool Equals(JetBrains.ReSharper.UnitTestProvider.MSTest11.MsTestTestClassElement other) { }
        public override bool Equals(object obj) { }
        public override JetBrains.ReSharper.Psi.IDeclaredElement GetDeclaredElement() { }
        public override JetBrains.ReSharper.UnitTestFramework.UnitTestElementDisposition GetDisposition() { }
        public override int GetHashCode() { }
        public override string GetPresentation(JetBrains.ReSharper.UnitTestFramework.IUnitTestElement parent = null) { }
        public override System.Collections.Generic.IEnumerable<JetBrains.ProjectModel.IProjectFile> GetProjectFiles() { }
        public override System.Collections.Generic.IList<JetBrains.ReSharper.UnitTestFramework.UnitTestTask> GetTaskSequence(System.Collections.Generic.ICollection<JetBrains.ReSharper.UnitTestFramework.IUnitTestElement> explicitElements, JetBrains.ReSharper.UnitTestFramework.IUnitTestLaunch launch) { }
        public static JetBrains.ReSharper.UnitTestProvider.MSTest.MsTestTestClassElementBase ReadFromXml(System.Xml.XmlElement parent, JetBrains.ReSharper.UnitTestProvider.MSTest11.MsTestElementFactory factory, JetBrains.ProjectModel.ISolution solution) { }
        public void WriteToXml(System.Xml.XmlElement parent) { }
    }
    public class MsTestTestMethodElement : JetBrains.ReSharper.UnitTestProvider.MSTest.MsTestTestMethodElementBase, System.IEquatable<JetBrains.ReSharper.UnitTestProvider.MSTest11.MsTestTestMethodElement>
    {
        public MsTestTestMethodElement(string id, JetBrains.ReSharper.UnitTestProvider.MSTest.IMsTestServices services, JetBrains.ReSharper.UnitTestProvider.MSTest.MsTestTestClassElementBase testClass, JetBrains.ProjectModel.ProjectModelElementEnvoy project, JetBrains.ReSharper.Psi.IClrTypeName declaringTypeName, string methodName) { }
        public override string Id { get; }
        public override string Kind { get; }
        public override string ShortName { get; }
        public Microsoft.VisualStudio.TestPlatform.ObjectModel.TestCase TestCase { get; set; }
        public override bool Equals(JetBrains.ReSharper.UnitTestFramework.IUnitTestElement other) { }
        public bool Equals(JetBrains.ReSharper.UnitTestProvider.MSTest11.MsTestTestMethodElement other) { }
        public override bool Equals(object obj) { }
        public override JetBrains.ReSharper.Psi.IDeclaredElement GetDeclaredElement() { }
        public override JetBrains.ReSharper.UnitTestFramework.UnitTestElementDisposition GetDisposition() { }
        public override int GetHashCode() { }
        public override string GetPresentation(JetBrains.ReSharper.UnitTestFramework.IUnitTestElement parent = null) { }
        public override System.Collections.Generic.IEnumerable<JetBrains.ProjectModel.IProjectFile> GetProjectFiles() { }
        public override System.Collections.Generic.IList<JetBrains.ReSharper.UnitTestFramework.UnitTestTask> GetTaskSequence(System.Collections.Generic.ICollection<JetBrains.ReSharper.UnitTestFramework.IUnitTestElement> explicitElements, JetBrains.ReSharper.UnitTestFramework.IUnitTestLaunch launch) { }
        public static JetBrains.ReSharper.UnitTestProvider.MSTest.MsTestTestMethodElementBase ReadFromXml(System.Xml.XmlElement parent, JetBrains.ReSharper.UnitTestFramework.IUnitTestElement parentElement, JetBrains.ReSharper.UnitTestProvider.MSTest11.MsTestElementFactory factory, JetBrains.ProjectModel.ISolution solution) { }
        public void WriteToXml(System.Xml.XmlElement parent) { }
    }
    public class MsTestTestRowElement : JetBrains.ReSharper.UnitTestProvider.MSTest.MsTestTestRowElementBase, System.IEquatable<JetBrains.ReSharper.UnitTestProvider.MSTest11.MsTestTestRowElement>
    {
        public MsTestTestRowElement(JetBrains.ReSharper.UnitTestProvider.MSTest.IMsTestServices services, JetBrains.ReSharper.UnitTestProvider.MSTest.MsTestTestMethodElementBase testMethodElement, JetBrains.ProjectModel.ProjectModelElementEnvoy project, string tableName, int order) { }
        public override string Id { get; }
        public override string Kind { get; }
        public override string ShortName { get; }
        public override bool Equals(JetBrains.ReSharper.UnitTestFramework.IUnitTestElement other) { }
        public bool Equals(JetBrains.ReSharper.UnitTestProvider.MSTest11.MsTestTestRowElement other) { }
        public override bool Equals(object obj) { }
        public override JetBrains.ReSharper.Psi.IDeclaredElement GetDeclaredElement() { }
        public override JetBrains.ReSharper.UnitTestFramework.UnitTestElementDisposition GetDisposition() { }
        public override int GetHashCode() { }
        public override string GetPresentation(JetBrains.ReSharper.UnitTestFramework.IUnitTestElement parent = null) { }
        public override System.Collections.Generic.IEnumerable<JetBrains.ProjectModel.IProjectFile> GetProjectFiles() { }
        public override System.Collections.Generic.IList<JetBrains.ReSharper.UnitTestFramework.UnitTestTask> GetTaskSequence(System.Collections.Generic.ICollection<JetBrains.ReSharper.UnitTestFramework.IUnitTestElement> explicitElements, JetBrains.ReSharper.UnitTestFramework.IUnitTestLaunch launch) { }
        public static JetBrains.ReSharper.UnitTestProvider.MSTest.MsTestTestRowElementBase ReadFromXml(System.Xml.XmlElement parent, JetBrains.ReSharper.UnitTestFramework.IUnitTestElement parentElement, JetBrains.ReSharper.UnitTestProvider.MSTest11.MsTestElementFactory factory, JetBrains.ProjectModel.ISolution solution) { }
        public void WriteToXml(System.Xml.XmlElement parent) { }
    }
    [JetBrains.ReSharper.UnitTestFramework.FileUnitTestExplorerAttribute()]
    public class MsTestUnitTestFileExplorer : JetBrains.ReSharper.UnitTestFramework.IUnitTestFileExplorer
    {
        public MsTestUnitTestFileExplorer(JetBrains.ReSharper.UnitTestProvider.MSTest11.MsTestProvider provider, JetBrains.ReSharper.UnitTestProvider.MSTest.IMsTestElementFactory factory, JetBrains.ReSharper.UnitTestProvider.MSTest.IMsTestAttributesProvider attributesProvider) { }
        public JetBrains.ReSharper.UnitTestFramework.IUnitTestProvider Provider { get; }
        public void ExploreFile(JetBrains.ReSharper.Psi.Tree.IFile psiFile, JetBrains.ReSharper.UnitTestFramework.UnitTestElementLocationConsumer consumer, JetBrains.Application.CheckForInterrupt interrupted) { }
    }
    [JetBrains.ReSharper.UnitTestFramework.MetadataUnitTestExplorerAttribute()]
    public class MsTestUnitTestMetadataExplorer : JetBrains.ReSharper.UnitTestFramework.IUnitTestMetadataExplorer
    {
        public MsTestUnitTestMetadataExplorer(JetBrains.ReSharper.UnitTestProvider.MSTest11.MsTestProvider provider, JetBrains.ReSharper.UnitTestProvider.MSTest11.MsTestVSFacade vsFacade) { }
        public JetBrains.ReSharper.UnitTestFramework.IUnitTestProvider Provider { get; }
        public void ExploreAssembly(JetBrains.ProjectModel.IProject project, JetBrains.Metadata.Reader.API.IMetadataAssembly assembly, JetBrains.ReSharper.UnitTestFramework.UnitTestElementConsumer consumer, System.Threading.ManualResetEvent exitEvent) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class MsTestVSFacade : System.IDisposable
    {
        public MsTestVSFacade(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.ReSharper.UnitTestProvider.MSTest11.MsTestElementFactory factory, JetBrains.ReSharper.UnitTestFramework.IUnitTestResultManager resultManager, JetBrains.Application.IShellLocks shellLocks, Microsoft.VisualStudio.Shell.Interop.IVsDebugger4 debugger) { }
        public Microsoft.VisualStudio.Shell.Interop.IVsDebugger4 Debugger { get; }
        public JetBrains.ReSharper.UnitTestFramework.IUnitTestResultManager ResultManager { get; }
        public Microsoft.VisualStudio.TestWindow.Controller.SafeDispatcher SafeDispatcher { get; }
        public JetBrains.Application.IShellLocks ShellLocks { get; }
        public string SolutionFolder { get; }
        public Microsoft.VisualStudio.TestPlatform.Client.OutOfProcTestPlatform TestPlatform { get; }
        public Microsoft.VisualStudio.TestWindow.Extensibility.ILogger VsLogger { get; }
        public void AbortRun(JetBrains.ReSharper.UnitTestProvider.MSTest11.IMsTest11Runner runner) { }
        public void CancelRun(JetBrains.ReSharper.UnitTestProvider.MSTest11.IMsTest11Runner runner) { }
        public void Dispose() { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.UnitTestFramework.IUnitTestElement> ExploreAssembly(JetBrains.ProjectModel.IProject project, System.Threading.ManualResetEvent exitEvent) { }
        public System.IDisposable UsingLock() { }
        protected class MsLogger : Microsoft.VisualStudio.TestWindow.Extensibility.ILogger
        {
            public void Clear() { }
            public void Log(Microsoft.VisualStudio.TestWindow.Extensibility.MessageLevel messageLevel, string message) { }
            public static JetBrains.Util.LoggingLevel ToLevel(Microsoft.VisualStudio.TestWindow.Extensibility.MessageLevel lvl) { }
        }
    }
    public class MsTestWinPhoneDebugger : JetBrains.ReSharper.UnitTestProvider.MSTest11.MsTestWinPhoneRunner
    {
        public MsTestWinPhoneDebugger(JetBrains.ReSharper.UnitTestProvider.MSTest11.WinPhonePackageManager manager, JetBrains.ProjectModel.IProject project, System.IServiceProvider serviceProvider, Microsoft.VisualStudio.TestWindow.Controller.SafeDispatcher safeDispatcher, System.Action waitForInstall, JetBrains.ReSharper.UnitTestProvider.MSTest11.MsTestVSFacade vsFacade) { }
        protected override void DoRun(System.Collections.Generic.IEnumerable<Microsoft.VisualStudio.TestPlatform.ObjectModel.TestCase> testCases, string settings, JetBrains.ReSharper.UnitTestFramework.IUnitTestRun run) { }
    }
    public class MsTestWinPhoneRunner : JetBrains.ReSharper.UnitTestProvider.MSTest11.MsTest11Runner
    {
        protected readonly JetBrains.ReSharper.UnitTestProvider.MSTest11.WinPhonePackageManager ourManager;
        protected readonly JetBrains.ProjectModel.IProject ourProject;
        protected readonly System.Action ourWaitForInstall;
        public MsTestWinPhoneRunner(JetBrains.ReSharper.UnitTestProvider.MSTest11.WinPhonePackageManager manager, JetBrains.ProjectModel.IProject project, System.Action waitForInstall, JetBrains.ReSharper.UnitTestProvider.MSTest11.MsTestVSFacade vsFacade) { }
        protected override void DoRun(System.Collections.Generic.IEnumerable<Microsoft.VisualStudio.TestPlatform.ObjectModel.TestCase> testCases, string settings, JetBrains.ReSharper.UnitTestFramework.IUnitTestRun run) { }
        protected override System.Collections.Generic.IEnumerable<Microsoft.VisualStudio.TestPlatform.ObjectModel.TestCase> GetTestCases(string assemblyLocation, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.UnitTestFramework.IUnitTestElement> elements) { }
    }
    public class WinPhonePackageManager
    {
        public WinPhonePackageManager(JetBrains.Application.IShellLocks shellLocks, JetBrains.VsIntegration.ProjectModel.ProjectModelSynchronizer pms) { }
        public void DeployAndRegister(JetBrains.ProjectModel.IProject project) { }
        public string GetDeviceName(JetBrains.ProjectModel.IProject project) { }
        public string GetFullPackageName(JetBrains.ProjectModel.IProject project) { }
    }
}